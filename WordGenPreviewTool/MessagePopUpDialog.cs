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
  public partial class MessagePopUpDialog : Form
  {
    Action action;
    public MessagePopUpDialog(string message,Action action)
    {
      InitializeComponent();
      this.lblMessage.Text=message;
      this.action = action;
    }

    public static void ShowDialogAndDo(IWin32Window parent, string message, Action action)
    {
      MessagePopUpDialog dlg = new MessagePopUpDialog(message,action);
      dlg.ShowDialog(parent);
    }

    private void MessagePopUpDialog_Shown(object sender, EventArgs e)
    {
      action.Invoke();
      this.Close();
    }

  }
}
