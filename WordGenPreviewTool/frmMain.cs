using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WordGenPreviewTool
{

  public partial class frmMain : Form
  {
    public readonly char RANDOM_PLACEHOLDER = '?';
    private enum GenerationMode { NUMCHAR, PATTERN }
    private GenerationMode cMode;
    public frmMain()
    {
      InitializeComponent();
      setGenerationMode(GenerationMode.NUMCHAR);
    }

    private void setGenerationMode(GenerationMode gm)
    {
      cMode = gm;
      if (cMode == GenerationMode.NUMCHAR)
      {
        nudNChars.Enabled = true;
        txtPattern.Enabled = false;
      }
      else if (cMode == GenerationMode.PATTERN)
      {
        nudNChars.Enabled = false;
        txtPattern.Enabled = true;
      }
    }

    private void frmMain_Load(object sender, EventArgs e)
    {
      nudNChars.Value = Convert.ToInt32(default_values.numChars);
      nudNWords.Value = Convert.ToInt32(default_values.numWords);
      foreach (FontFamily font in System.Drawing.FontFamily.Families)
        cmxTypefaces.Items.Add(font.Name);
      reflectPatternChange();
    }
    private void reflectPatternChange()
    {
      string t = "";
      for (int i = 0; i < nudNChars.Value; i++) t += RANDOM_PLACEHOLDER;
      txtPattern.Text = txtPrefix.Text + t + txtPostFix.Text;
    }

    private void btnAddChar_Click(object sender, EventArgs e)
    {
      for (int i = 0; i < txtCharToAdd.Text.Length; i++)
        if (txtCharToAdd.Text[i] != ' ') lstChars.Items.Add(txtCharToAdd.Text.Substring(i, 1));
    }

    private void btnCharsRemove_Click(object sender, EventArgs e)
    {
      Utility.ListView_RemoveSelected(lstChars);
    }

    private void btnCharsClear_Click(object sender, EventArgs e)
    {
      lstChars.Clear();
    }

    private void rbtModeNChar_CheckedChanged(object sender, EventArgs e)
    {
      setGenerationMode(GenerationMode.NUMCHAR);
    }

    private void rbtModePattern_CheckedChanged(object sender, EventArgs e)
    {
      setGenerationMode(GenerationMode.PATTERN);
    }

    private void nudNChars_ValueChanged(object sender, EventArgs e)
    {
      reflectPatternChange();
    }

    private void txtPrefix_TextChanged(object sender, EventArgs e)
    {
      reflectPatternChange();
    }


    private void txtPostFix_TextChanged(object sender, EventArgs e)
    {
      reflectPatternChange();
    }

    private void nudNChars_EnabledChanged(object sender, EventArgs e)
    {
      reflectPatternChange();
    }

    private void btnUnselectWord_Click(object sender, EventArgs e)
    {
      Utility.ListView_RemoveSelected(lstSelected);
    }

    private void btnClearSelection_Click(object sender, EventArgs e)
    {
      lstSelected.Clear();
    }

    private void btnSelectWord_Click(object sender, EventArgs e)
    {
      foreach (ListViewItem i in lstGenerated.SelectedItems)
        lstSelected.Items.Add(i.Text);
    }

    private void txtPattern_TextChanged(object sender, EventArgs e)
    {

    }

    private void btnGenerate_Click(object sender, EventArgs e)
    {

      Random r = new Random();
      lstGenerated.Clear();
      for (int i = 0; i < nudNWords.Value; i++)
      {
        string s = (string)txtPattern.Text.Clone();
        List<string> usedchar = new List<string>();
        for (int j = 0; j < s.Length; j++)
        {
          if (s[j] == RANDOM_PLACEHOLDER)
          {
            string rs = lstChars.Items[r.Next(lstChars.Items.Count)].Text.Trim();
            if (usedchar.Count < lstChars.Items.Count && cbxNoRepeating.Checked)
              while (usedchar.Contains(rs))
                rs = lstChars.Items[r.Next(lstChars.Items.Count)].Text.Trim();
            s = s.Substring(0, j) + rs + s.Substring(j + 1, s.Length - (j + 1));
            if (!usedchar.Contains(rs)) usedchar.Add(rs);
          }
        }
        lstGenerated.TileSize = new System.Drawing.Size((int)Math.Round(CreateGraphics().MeasureString(s, lstGenerated.Font).Width) + txtPattern.TextLength * 1 + 4, 28);
        if (!Utility.ListView_ContainsItemWithText(lstGenerated, s)) lstGenerated.Items.Add(s);
      }
    }
    private void lstGenerated_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (lstGenerated.SelectedItems.Count != 0) reflectTextFont(lstGenerated.SelectedItems[0].Text);
    }

    private void lstSelected_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (lstSelected.SelectedItems.Count != 0) reflectTextFont(lstSelected.SelectedItems[0].Text);

    }
    private void reflectTextFont(string text)
    {
      lbl8.Text = text;
      lbl12.Text = text;
      lbl18.Text = text;
      reflectFont();
    }
    private void reflectFont()
    {
      lbl8.Font = new System.Drawing.Font(lbl8.Font, System.Drawing.FontStyle.Regular |
          ((cbxItalic.Checked) ? (System.Drawing.FontStyle.Italic) : (0)) |
          ((cbxUnderline.Checked) ? (System.Drawing.FontStyle.Underline) : (0)) |
          ((cbxBold.Checked) ? (System.Drawing.FontStyle.Bold) : (0)));
      lbl12.Font = new System.Drawing.Font(lbl12.Font, System.Drawing.FontStyle.Regular |
          ((cbxItalic.Checked) ? (System.Drawing.FontStyle.Italic) : (0)) |
          ((cbxUnderline.Checked) ? (System.Drawing.FontStyle.Underline) : (0)) |
          ((cbxBold.Checked) ? (System.Drawing.FontStyle.Bold) : (0)));
      lbl18.Font = new System.Drawing.Font(lbl18.Font, System.Drawing.FontStyle.Regular |
          ((cbxItalic.Checked) ? (System.Drawing.FontStyle.Italic) : (0)) |
          ((cbxUnderline.Checked) ? (System.Drawing.FontStyle.Underline) : (0)) |
          ((cbxBold.Checked) ? (System.Drawing.FontStyle.Bold) : (0)));
    }

    private void cbxItalic_CheckedChanged(object sender, EventArgs e)
    {
      reflectFont();
    }

    private void cbxUnderLine_CheckedChanged(object sender, EventArgs e)
    {
      reflectFont();
    }

    private void cbxBold_CheckedChanged(object sender, EventArgs e)
    {
      reflectFont();
    }

    private void cmxTypefaces_SelectedIndexChanged(object sender, EventArgs e)
    {
      lbl8.Font = new Font(cmxTypefaces.SelectedItem.ToString(), 8);
      lbl12.Font = new Font(cmxTypefaces.SelectedItem.ToString(), 12);
      lbl18.Font = new Font(cmxTypefaces.SelectedItem.ToString(), 18);
      reflectFont();
    }

    private void btnTypeNewWord_Click(object sender, EventArgs e)
    {
      string[] s = TextInputDialog.getInput(this, "输入候选词", "请在文本框中输入你想加入的候选词，用空格分开。").Split(' ');
      foreach (string i in s)
        lstSelected.Items.Add(i);
    }
  }
}
