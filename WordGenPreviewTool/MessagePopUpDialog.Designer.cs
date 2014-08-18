namespace WordGenPreviewTool
{
  partial class MessagePopUpDialog
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.lblMessage = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // lblMessage
      // 
      this.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.lblMessage.Location = new System.Drawing.Point(13, 9);
      this.lblMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lblMessage.Name = "lblMessage";
      this.lblMessage.Size = new System.Drawing.Size(442, 132);
      this.lblMessage.TabIndex = 0;
      this.lblMessage.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque egestas adipisci" +
    "ng ipsum vel viverra. Proin vehicula hendrerit justo, eget mollis nisi suscipit " +
    "a.\r\n";
      this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // MessagePopUpDialog
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(468, 150);
      this.Controls.Add(this.lblMessage);
      this.Font = new System.Drawing.Font("FangSong", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Margin = new System.Windows.Forms.Padding(4);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "MessagePopUpDialog";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "救命，我被关在一个幸运饼干的工厂里";
      this.TopMost = true;
      this.Shown += new System.EventHandler(this.MessagePopUpDialog_Shown);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label lblMessage;
  }
}