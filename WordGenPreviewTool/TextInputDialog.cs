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
  public partial class TextInputDialog : Form
  {

    public TextInputDialog(string title, string text)
    {
      InitializeComponent();
      this.Text = title;
      this.lblText.Text = text;
    }

    public static string getInput(IWin32Window parent, string title, string text)
    {
      TextInputDialog dlg = new TextInputDialog(title, text);
      if (dlg.ShowDialog(parent) == DialogResult.OK)
        return dlg.txtUserInput.Text;
      else
        return null;
    }

    private void TextInputDialog_Load(object sender, EventArgs e)
    {

    }
  }
}
