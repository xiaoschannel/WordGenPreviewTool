using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordGenPreviewTool
{
  public partial class DoubleTextInputDialog : Form
  {
    private int btnClicked;
    public DoubleTextInputDialog()
    {
      InitializeComponent();
      btnClicked = 0;
    }

    public static DoubleTextInputDialogResult getInput(IWin32Window parent, string title, string text1, string text2)
    {
      return getInputWithPreSetText(parent, title, text1, text2, "", "", "");
    }

    public static DoubleTextInputDialogResult getInput(IWin32Window parent, string title, string text1, string text2, string secondButtonText)
    {
      return getInputWithPreSetText(parent, title, text1, text2, "", "", secondButtonText);
    }

    public static DoubleTextInputDialogResult getInputWithPreSetText(IWin32Window parent, string title, string text1, string text2, string preSetText1, string preSetText2, string secondButtonText)
    {
      DoubleTextInputDialog dlg = new DoubleTextInputDialog();
      dlg.Text = title;
      dlg.lblText1.Text = text1;
      dlg.txtUserInput1.Text = preSetText1;
      dlg.lblText2.Text = text2;
      dlg.txtUserInput2.Text = preSetText2;
      dlg.btnCommit2.Text = secondButtonText;
      if (dlg.ShowDialog(parent) == DialogResult.OK)
        return new DoubleTextInputDialogResult(dlg.txtUserInput1.Text, dlg.txtUserInput2.Text, dlg.btnClicked);
      else
        return null;
    }

    public class DoubleTextInputDialogResult
    {
      public readonly string text1;
      public readonly string text2;
      public readonly int buttonClicked;
      public DoubleTextInputDialogResult(string text1, string text2, int buttonClicked)
      {
        this.text1 = text1;
        this.text2 = text2;
        this.buttonClicked = buttonClicked;
      }
    }

    private void btnCommit1_Click(object sender, EventArgs e)
    {
      btnClicked = 1;
    }

    private void btnCommit2_Click(object sender, EventArgs e)
    {
      btnClicked = 2;
    }
  }
}
