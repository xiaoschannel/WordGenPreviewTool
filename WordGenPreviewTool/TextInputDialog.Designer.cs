namespace WordGenPreviewTool
{
  partial class TextInputDialog
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
      this.lblText = new System.Windows.Forms.Label();
      this.btnCommit = new System.Windows.Forms.Button();
      this.txtUserInput = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // lblText
      // 
      this.lblText.Location = new System.Drawing.Point(13, 13);
      this.lblText.Name = "lblText";
      this.lblText.Size = new System.Drawing.Size(401, 75);
      this.lblText.TabIndex = 0;
      this.lblText.Text = "测试文字";
      this.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // btnCommit
      // 
      this.btnCommit.AutoSize = true;
      this.btnCommit.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.btnCommit.Location = new System.Drawing.Point(420, 13);
      this.btnCommit.Name = "btnCommit";
      this.btnCommit.Size = new System.Drawing.Size(96, 75);
      this.btnCommit.TabIndex = 1;
      this.btnCommit.Text = "确定";
      this.btnCommit.UseVisualStyleBackColor = true;
      // 
      // txtUserInput
      // 
      this.txtUserInput.Location = new System.Drawing.Point(12, 101);
      this.txtUserInput.Name = "txtUserInput";
      this.txtUserInput.Size = new System.Drawing.Size(504, 30);
      this.txtUserInput.TabIndex = 0;
      // 
      // TextInputDialog
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(528, 143);
      this.Controls.Add(this.txtUserInput);
      this.Controls.Add(this.btnCommit);
      this.Controls.Add(this.lblText);
      this.Font = new System.Drawing.Font("FangSong", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Margin = new System.Windows.Forms.Padding(4);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "TextInputDialog";
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "测试标题";
      this.TopMost = true;
      this.Load += new System.EventHandler(this.TextInputDialog_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblText;
    private System.Windows.Forms.Button btnCommit;
    private System.Windows.Forms.TextBox txtUserInput;
  }
}