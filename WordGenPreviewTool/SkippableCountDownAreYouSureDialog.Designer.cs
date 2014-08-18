namespace WordGenPreviewTool
{
  partial class SkippableCountDownAreYouSureDialog
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
      this.components = new System.ComponentModel.Container();
      this.btnConfirm = new System.Windows.Forms.Button();
      this.btnImmediateConfirm = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.lblWarning = new System.Windows.Forms.Label();
      this.tmrCountDown = new System.Windows.Forms.Timer(this.components);
      this.SuspendLayout();
      // 
      // btnConfirm
      // 
      this.btnConfirm.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.btnConfirm.Enabled = false;
      this.btnConfirm.Location = new System.Drawing.Point(142, 134);
      this.btnConfirm.Name = "btnConfirm";
      this.btnConfirm.Size = new System.Drawing.Size(223, 58);
      this.btnConfirm.TabIndex = 0;
      this.btnConfirm.Text = "我知道了，确定";
      this.btnConfirm.UseVisualStyleBackColor = true;
      // 
      // btnImmediateConfirm
      // 
      this.btnImmediateConfirm.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.btnImmediateConfirm.Location = new System.Drawing.Point(142, 219);
      this.btnImmediateConfirm.Name = "btnImmediateConfirm";
      this.btnImmediateConfirm.Size = new System.Drawing.Size(223, 29);
      this.btnImmediateConfirm.TabIndex = 1;
      this.btnImmediateConfirm.Text = "跳过等待";
      this.btnImmediateConfirm.UseVisualStyleBackColor = true;
      // 
      // label1
      // 
      this.label1.Location = new System.Drawing.Point(14, 261);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(485, 20);
      this.label1.TabIndex = 2;
      this.label1.Text = "不用看了，下面没有隐藏按钮。";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // lblWarning
      // 
      this.lblWarning.Font = new System.Drawing.Font("FangSong", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblWarning.Location = new System.Drawing.Point(13, 13);
      this.lblWarning.Name = "lblWarning";
      this.lblWarning.Size = new System.Drawing.Size(486, 118);
      this.lblWarning.TabIndex = 3;
      this.lblWarning.Text = "注意：\r\n按下按钮将会发射很多导弹！";
      this.lblWarning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // tmrCountDown
      // 
      this.tmrCountDown.Enabled = true;
      this.tmrCountDown.Interval = 1000;
      this.tmrCountDown.Tick += new System.EventHandler(this.tmrCountDown_Tick);
      // 
      // SkippableCountDownAreYouSureDialog
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(511, 207);
      this.Controls.Add(this.lblWarning);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.btnImmediateConfirm);
      this.Controls.Add(this.btnConfirm);
      this.Font = new System.Drawing.Font("FangSong", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(4);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "SkippableCountDownAreYouSureDialog";
      this.ShowInTaskbar = false;
      this.Text = "确认操作";
      this.TopMost = true;
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnConfirm;
    private System.Windows.Forms.Button btnImmediateConfirm;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label lblWarning;
    private System.Windows.Forms.Timer tmrCountDown;
  }
}