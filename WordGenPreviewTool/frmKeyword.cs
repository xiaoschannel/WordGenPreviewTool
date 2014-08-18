using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordGenPreviewTool
{
  public partial class frmKeyword : Form
  {
    CharKeywordDBHandler db;
    frmMain main;
    Dictionary<string, List<string>> keywordsOfChar;//create another index so we get keywords quickly for a char given.
    bool dbLoaded = false;
    //Char
    public frmKeyword(frmMain frm)
    {
      InitializeComponent();
      main = frm;
      keywordsOfChar = new Dictionary<string, List<string>>();

    }

    private void frmKeyword_Load(object sender, EventArgs e)
    {
      var bw = new BackgroundWorker();
      bw.DoWork += (s, args) => para_loadDB();
      bw.RunWorkerCompleted += (s, args) => db_finishedReadingKeywords();
      bw.RunWorkerAsync();
    }
    private void para_loadDB()
    {
      db = new CharKeywordDBHandler();
      db.loadCharsByKeyword();
      db.loadAllKeywords();
      db.loadAllChars();
      foreach (string k in db.KeywordsCharList.Keys)
      {
        foreach (string c in db.KeywordsCharList[k])
        {
          if (!keywordsOfChar.ContainsKey(c)) keywordsOfChar.Add(c, new List<string>());
          keywordsOfChar[c].Add(k);
        }
      }
      dbLoaded = true;
    }
    private void db_finishedReadingKeywords()
    {
      refreshLstKeywords();
    }
    private void refreshLstKeywords()
    {
      lstKeyWords.Items.Clear();
      foreach (string s in db.keywords)
        lstKeyWords.Items.Add(s.Trim());
    }
    private void lstKeyWords_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (!dbLoaded) return;
      if (lstKeyWords.SelectedItem == null) return;
      string selected = zut_wf.ListBox_GetSelectedItemText(lstKeyWords);
      lblCurrentKeyword.Text = selected;

      lstCharecters.Items.Clear();
      if (db.KeywordsCharList.ContainsKey(selected))
      {
        foreach (string s in db.KeywordsCharList[selected])
          lstCharecters.Items.Add(s.Trim());
        zut_wf.ListView_AdjustTileSizetoFirstItem(lstCharecters);
      }
      else
      {
        lstCharecters.Items.Add("（没有使用这个关键字的汉字）");
        zut_wf.ListView_AdjustTileSizetoFirstItem(lstCharecters);
      }
    }

    private void lstCharecters_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (lstCharecters.SelectedItems.Count == 0) return;

      string selected = lstCharecters.SelectedItems[0].Text;
      if (!keywordsOfChar.ContainsKey(selected) || keywordsOfChar[selected].Count == 0) return;
      lblCharDisplay.Text = selected;
      lblCharKeywords.Text = "关键字：";
      bool flag = false;
      foreach (string s in keywordsOfChar[selected])
      {
        if (flag == false) flag = true;//no comma first time
        else lblCharKeywords.Text += "，";
        lblCharKeywords.Text += s.Trim();
      }
    }

    private void btnUseKeyword_Click(object sender, EventArgs e)
    {
      if (lstKeyWords.SelectedItems.Count == 0) return;
      if (!dbLoaded) return;
      zut_wf.ListBox_AddTextIfNotContained(lstSelectedKeywords, zut_wf.ListBox_GetSelectedItemText(lstKeyWords));
    }

    private void btnRemoveSelected_Click(object sender, EventArgs e)
    {
      if (lstSelectedKeywords.SelectedIndices.Count == 0) return;
      //lstSelectedKeywords.SelectedItems.Clear();
      zut_wf.ListBox_RemoveAllSelectedItems(lstSelectedKeywords);
    }
    private List<string> lastKeywords = new List<string>();
    private void btnApply_Click(object sender, EventArgs e)
    {
      HashSet<string> charstoremove = getCharswithKeywords(lastKeywords);

      ListView lst = main.getLstChars();
      zut_wf.ListView_RemoveItemsWithSetofText(lst, charstoremove);

      List<string> currentKeywords = new List<string>();

      foreach (object k in lstSelectedKeywords.Items)
        currentKeywords.Add(k.ToString());

      HashSet<string> charstoadd = getCharswithKeywords(currentKeywords);
      foreach (string c in charstoadd)
        zut_wf.ListView_AddTextIfNotContained(lst, c);

      //Console.WriteLine("Loaded "+currentKeywords.Count+" keywords, "+charstoadd.Count+" charecters.");
      lastKeywords = currentKeywords;
    }

    private HashSet<string> getCharswithKeywords(List<string> lst)
    {
      HashSet<string> ans = new HashSet<string>();
      foreach (string keyword in lst)
      {
        if (db.KeywordsCharList.ContainsKey(keyword))
        {//if some charecters are associated with this keyword
          foreach (string c in db.KeywordsCharList[keyword])
            ans.Add(c);
        }
      }
      return ans;
    }

    private void btnEditCharOfKeyword_Click(object sender, EventArgs e)
    {
      if (!dbLoaded) return;
      if (lstKeyWords.SelectedItem == null) return;
      string textcharlistbefore = "";
      string keywordEditing = zut_wf.ListBox_GetSelectedItemText(lstKeyWords);

      foreach (string s in db.KeywordsCharList[keywordEditing])
        textcharlistbefore += s + " ";
      textcharlistbefore = textcharlistbefore.Trim();

      List<string> lbefore = new List<string>(textcharlistbefore.Split(' '));

      string textcharlistafter = TextInputDialog.getInputWithPreSetText
        (this, "编辑关键字", "在此处修改拥有这个关键字的文字列表：\n" + keywordEditing, textcharlistbefore + " ");
      if (textcharlistafter == null) return;

      List<string> lafter = new List<string>(textcharlistafter.Trim().Split(' '));

      var diff = zut.listDiff<string>(lbefore, lafter);

      MessagePopUpDialog.ShowDialogAndDo(this, "正在更新数据库，请稍等...", () => para_editKeyword(diff, keywordEditing));


      foreach (string s in diff.Item1)
      {
        if (!keywordsOfChar.ContainsKey(s)) keywordsOfChar.Add(s, new List<string>());
        keywordsOfChar[s].Add(keywordEditing);
      }

      foreach (string s in diff.Item2)
      {
        keywordsOfChar[s].Remove(keywordEditing);
      }
      lstCharecters.Items.Clear();
      foreach (string s in lafter)
        lstCharecters.Items.Add(s);
    }

    private void para_editKeyword(Tuple<List<string>, List<string>> diffs, string keyword)
    {
      List<KeyValuePair<string, string>> addlist, deletelist;
      addlist = new List<KeyValuePair<string, string>>();
      deletelist = new List<KeyValuePair<string, string>>();

      List<string> newChars = new List<string>();

      foreach (string s in diffs.Item1)
      {
        addlist.Add(new KeyValuePair<string, string>(s, keyword));
        if (!db.chars.Contains(s)) newChars.Add(s);
      }
      foreach (string s in diffs.Item2)
      {
        deletelist.Add(new KeyValuePair<string, string>(s, keyword));
      }
      db.addChars(newChars);
      db.addCKWPairs(addlist);
      db.removeCKWPairs(deletelist);
    }

    private void btnDeleteSelectedKeywords_Click(object sender, EventArgs e)
    {
      if (lstKeyWords.SelectedItems.Count == 0) return;
      DialogResult res = SkippableCountDownAreYouSureDialog.ShowDialogWithCustomButtonText(this, "删除关键字", "删除的关键字将不可恢复,\n并从所有当前使用它的汉字中被消除。", 3000, "我明白了，删除");
      if (res == DialogResult.OK)
      {
        List<string> deletelst = new List<string>();
        foreach (object i in lstKeyWords.SelectedItems)
          deletelst.Add(i.ToString());
        MessagePopUpDialog.ShowDialogAndDo(this, "正在删除关键字，请稍等", () => db.deleteKeywords(deletelst));
      }
    }

    private void btnNewKeyword_Click(object sender, EventArgs e)
    {
      DoubleTextInputDialog.DoubleTextInputDialogResult result = DoubleTextInputDialog.getInput(this, "添加关键字", "输入你想添加的关键字，用空格分隔。", "在新关键字中加入汉字（空格分隔）：", "确定并加入以上汉字");
      if (result == null) return;
      List<string> newkwrdlst = new List<string>(result.text1.Trim().Split(' '));
      if (newkwrdlst.Count == 0) return;
      if (result.buttonClicked == 1)
      {
        MessagePopUpDialog.ShowDialogAndDo(this, "正在添加新关键字，请稍等", () => db.addKeywords(newkwrdlst));
      }
      else if (result.buttonClicked == 2)
      {
        //MessagePopUpDialog.ShowDialogAndDo(this, "正在添加新关键字，请稍等", () => db.addKeywords(newkwrdlst));
        List<string> newcharlst = new List<string>(result.text2.Trim().Split(' '));
        //MessagePopUpDialog.ShowDialogAndDo(this, "正在添加新汉字，请稍等", () => db.addChars(newcharlst));
        if (newcharlst.Count > 0)
        {
          List<KeyValuePair<string, string>> ckwlst = new List<KeyValuePair<string, string>>();
          foreach (string kwd in newkwrdlst)
          {
            foreach (string chr in newcharlst)
            {
              if (CharKeywordDBHandler.isValidChar(chr) && CharKeywordDBHandler.isValidKeyword(kwd)) ckwlst.Add(new KeyValuePair<string, string>(chr, kwd));
            }
          }
          MessagePopUpDialog.ShowDialogAndDo(this, "正在添加新关键字，请稍等", () => { db.addKeywords(newkwrdlst); db.addChars(newcharlst); db.addCKWPairs(ckwlst); });
          foreach (string kwd in newkwrdlst)
          {
            foreach (string chr in newcharlst)
            {
              if (!keywordsOfChar.ContainsKey(chr)) keywordsOfChar.Add(chr, new List<string>());
              keywordsOfChar[chr].Add(kwd);
            }
          }
        }
        else
        {
          MessagePopUpDialog.ShowDialogAndDo(this, "正在添加新关键字，请稍等", () => db.addKeywords(newkwrdlst));
        }
      }
      refreshLstKeywords();
    }
  }
}
