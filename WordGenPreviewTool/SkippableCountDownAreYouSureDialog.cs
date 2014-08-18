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
  public partial class SkippableCountDownAreYouSureDialog : Form
  {
    public SkippableCountDownAreYouSureDialog()
    {
      InitializeComponent();
      timepassed = 0;
    }

    private string confirmButtonText;
    private int timepassed;
    private int countdownLength;
    public static DialogResult ShowDialogWithCustomButtonText(IWin32Window parent, string title, string text, int countdownMillisecond, string confirmButtonText)
    {
      SkippableCountDownAreYouSureDialog dlg = new SkippableCountDownAreYouSureDialog();
      dlg.Text = title;
      dlg.lblWarning.Text = text;
      dlg.btnConfirm.Text = confirmButtonText;
      dlg.confirmButtonText = confirmButtonText;
      dlg.countdownLength = countdownMillisecond;
      dlg.updateCountdownButtonText();
      return dlg.ShowDialog(parent);
    }

    private void tmrCountDown_Tick(object sender, EventArgs e)
    {
      timepassed += tmrCountDown.Interval;
      updateCountdownButtonText();
      if (timepassed >= countdownLength)
      {
        btnConfirm.Enabled = true;
        tmrCountDown.Enabled = false;
      }
    }

    private void updateCountdownButtonText()
    {
      if (timepassed < countdownLength)
        btnConfirm.Text = confirmButtonText + "\n（还需等" + (int)Math.Ceiling((countdownLength - timepassed)*1.0 / 1000) + "秒）";
      else
        btnConfirm.Text = confirmButtonText;
    }
  }
}
