namespace WordGenPreviewTool
{
  partial class DoubleTextInputDialog
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
      this.lblText1 = new System.Windows.Forms.Label();
      this.btnCommit1 = new System.Windows.Forms.Button();
      this.txtUserInput1 = new System.Windows.Forms.TextBox();
      this.txtUserInput2 = new System.Windows.Forms.TextBox();
      this.btnCommit2 = new System.Windows.Forms.Button();
      this.lblText2 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // lblText1
      // 
      this.lblText1.Location = new System.Drawing.Point(13, 13);
      this.lblText1.Name = "lblText1";
      this.lblText1.Size = new System.Drawing.Size(401, 75);
      this.lblText1.TabIndex = 0;
      this.lblText1.Text = "测试文字";
      this.lblText1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // btnCommit1
      // 
      this.btnCommit1.AutoSize = true;
      this.btnCommit1.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.btnCommit1.Location = new System.Drawing.Point(420, 13);
      this.btnCommit1.Name = "btnCommit1";
      this.btnCommit1.Size = new System.Drawing.Size(96, 82);
      this.btnCommit1.TabIndex = 3;
      this.btnCommit1.Text = "确定";
      this.btnCommit1.UseVisualStyleBackColor = true;
      this.btnCommit1.Click += new System.EventHandler(this.btnCommit1_Click);
      // 
      // txtUserInput1
      // 
      this.txtUserInput1.Location = new System.Drawing.Point(12, 101);
      this.txtUserInput1.Name = "txtUserInput1";
      this.txtUserInput1.Size = new System.Drawing.Size(504, 30);
      this.txtUserInput1.TabIndex = 0;
      // 
      // txtUserInput2
      // 
      this.txtUserInput2.Location = new System.Drawing.Point(12, 205);
      this.txtUserInput2.Name = "txtUserInput2";
      this.txtUserInput2.Size = new System.Drawing.Size(504, 30);
      this.txtUserInput2.TabIndex = 1;
      // 
      // btnCommit2
      // 
      this.btnCommit2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.btnCommit2.AutoSize = true;
      this.btnCommit2.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.btnCommit2.Location = new System.Drawing.Point(420, 236);
      this.btnCommit2.Name = "btnCommit2";
      this.btnCommit2.Size = new System.Drawing.Size(96, 30);
      this.btnCommit2.TabIndex = 2;
      this.btnCommit2.Text = "确定";
      this.btnCommit2.UseVisualStyleBackColor = true;
      this.btnCommit2.Click += new System.EventHandler(this.btnCommit2_Click);
      // 
      // lblText2
      // 
      this.lblText2.Location = new System.Drawing.Point(12, 146);
      this.lblText2.Name = "lblText2";
      this.lblText2.Size = new System.Drawing.Size(504, 52);
      this.lblText2.TabIndex = 4;
      this.lblText2.Text = "测试文字";
      this.lblText2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
      // 
      // DoubleTextInputDialog
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(529, 275);
      this.Controls.Add(this.txtUserInput2);
      this.Controls.Add(this.btnCommit2);
      this.Controls.Add(this.lblText2);
      this.Controls.Add(this.txtUserInput1);
      this.Controls.Add(this.btnCommit1);
      this.Controls.Add(this.lblText1);
      this.Font = new System.Drawing.Font("FangSong", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Margin = new System.Windows.Forms.Padding(4);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "DoubleTextInputDialog";
      this.ShowInTaskbar = false;
      this.Text = "测试标题";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblText1;
    private System.Windows.Forms.Button btnCommit1;
    private System.Windows.Forms.TextBox txtUserInput1;
    private System.Windows.Forms.TextBox txtUserInput2;
    private System.Windows.Forms.Button btnCommit2;
    private System.Windows.Forms.Label lblText2;
  }
}