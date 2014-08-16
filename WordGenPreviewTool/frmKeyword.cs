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
    Dictionary<string, List<string>> keywordsOfChar;//create another index so we get keywords quickly for a char given.
    bool dbLoaded = false;
    //Char
    public frmKeyword()
    {
      InitializeComponent();
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
      foreach (string k in db.charKeywords.Keys)
      {
        foreach (string c in db.charKeywords[k])
        {
          if (!keywordsOfChar.ContainsKey(c)) keywordsOfChar.Add(c, new List<string>());
          keywordsOfChar[c].Add(k);
        }
      }
      dbLoaded = true;
    }
    private void db_finishedReadingKeywords()
    {
      lstKeyWords.Items.Clear();
      foreach (string s in db.keywords)
        lstKeyWords.Items.Add(s);
    }

    private void lstKeyWords_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (!dbLoaded) return;
      if (lstKeyWords.SelectedItem==null)return;
      string selected = zut.ListBox_GetSelectedItemText(lstKeyWords);
      lstCharecters.Items.Clear();
      lblCurrentKeyword.Text = selected;
      //lblCurrentKeyword.TextAlign = ContentAlignment.MiddleCenter;

      //lblCurrentKeyword.Invalidate();
      //lblCurrentKeyword.Update();
      //lblCurrentKeyword.Refresh();
      //lblCurrentKeyword.PerformLayout();

      if (db.charKeywords.ContainsKey(selected))
      {
        foreach (string s in db.charKeywords[selected])
          lstCharecters.Items.Add(s);
      }
    }

    private void lstCharecters_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (lstCharecters.SelectedItems.Count == 0) return;
      string selected = lstCharecters.SelectedItems[0].Text;
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


  }
}
