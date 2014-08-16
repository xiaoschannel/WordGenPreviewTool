namespace WordGenPreviewTool
{
  partial class frmKeyword
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
      this.lstKeyWords = new System.Windows.Forms.ListBox();
      this.lstCharecters = new System.Windows.Forms.ListView();
      this.lblCharDisplay = new System.Windows.Forms.Label();
      this.lblCurrentKeyword = new System.Windows.Forms.Label();
      this.btnUseKeyword = new System.Windows.Forms.Button();
      this.lstSelectedKeywords = new System.Windows.Forms.ListBox();
      this.btnManageChars = new System.Windows.Forms.Button();
      this.btnRemoveSelected = new System.Windows.Forms.Button();
      this.btnGoogleIt = new System.Windows.Forms.Button();
      this.btnWikiIt = new System.Windows.Forms.Button();
      this.lblCharKeywords = new System.Windows.Forms.Label();
      this.btnDone = new System.Windows.Forms.Button();
      this.btnEditKeywords = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // lstKeyWords
      // 
      this.lstKeyWords.FormattingEnabled = true;
      this.lstKeyWords.ItemHeight = 20;
      this.lstKeyWords.Items.AddRange(new object[] {
            "读取中……"});
      this.lstKeyWords.Location = new System.Drawing.Point(13, 12);
      this.lstKeyWords.Name = "lstKeyWords";
      this.lstKeyWords.Size = new System.Drawing.Size(159, 384);
      this.lstKeyWords.TabIndex = 1;
      this.lstKeyWords.SelectedIndexChanged += new System.EventHandler(this.lstKeyWords_SelectedIndexChanged);
      // 
      // lstCharecters
      // 
      this.lstCharecters.Location = new System.Drawing.Point(178, 45);
      this.lstCharecters.MultiSelect = false;
      this.lstCharecters.Name = "lstCharecters";
      this.lstCharecters.Size = new System.Drawing.Size(433, 141);
      this.lstCharecters.TabIndex = 2;
      this.lstCharecters.TileSize = new System.Drawing.Size(28, 28);
      this.lstCharecters.UseCompatibleStateImageBehavior = false;
      this.lstCharecters.View = System.Windows.Forms.View.Tile;
      this.lstCharecters.SelectedIndexChanged += new System.EventHandler(this.lstCharecters_SelectedIndexChanged);
      // 
      // lblCharDisplay
      // 
      this.lblCharDisplay.Font = new System.Drawing.Font("FangSong", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblCharDisplay.Location = new System.Drawing.Point(478, 189);
      this.lblCharDisplay.Name = "lblCharDisplay";
      this.lblCharDisplay.Size = new System.Drawing.Size(165, 121);
      this.lblCharDisplay.TabIndex = 3;
      // 
      // lblCurrentKeyword
      // 
      this.lblCurrentKeyword.Location = new System.Drawing.Point(178, 4);
      this.lblCurrentKeyword.Name = "lblCurrentKeyword";
      this.lblCurrentKeyword.Size = new System.Drawing.Size(348, 34);
      this.lblCurrentKeyword.TabIndex = 4;
      this.lblCurrentKeyword.Text = "（选中的关键字）";
      this.lblCurrentKeyword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.lblCurrentKeyword.UseCompatibleTextRendering = true;
      // 
      // btnUseKeyword
      // 
      this.btnUseKeyword.Location = new System.Drawing.Point(532, 4);
      this.btnUseKeyword.Name = "btnUseKeyword";
      this.btnUseKeyword.Size = new System.Drawing.Size(79, 34);
      this.btnUseKeyword.TabIndex = 5;
      this.btnUseKeyword.Text = "加入>";
      this.btnUseKeyword.UseVisualStyleBackColor = true;
      // 
      // lstSelectedKeywords
      // 
      this.lstSelectedKeywords.FormattingEnabled = true;
      this.lstSelectedKeywords.ItemHeight = 20;
      this.lstSelectedKeywords.Location = new System.Drawing.Point(617, 4);
      this.lstSelectedKeywords.Name = "lstSelectedKeywords";
      this.lstSelectedKeywords.Size = new System.Drawing.Size(159, 344);
      this.lstSelectedKeywords.TabIndex = 6;
      // 
      // btnManageChars
      // 
      this.btnManageChars.Location = new System.Drawing.Point(13, 403);
      this.btnManageChars.Name = "btnManageChars";
      this.btnManageChars.Size = new System.Drawing.Size(159, 33);
      this.btnManageChars.TabIndex = 7;
      this.btnManageChars.Text = "管理文字...";
      this.btnManageChars.UseVisualStyleBackColor = true;
      // 
      // btnRemoveSelected
      // 
      this.btnRemoveSelected.Location = new System.Drawing.Point(617, 355);
      this.btnRemoveSelected.Name = "btnRemoveSelected";
      this.btnRemoveSelected.Size = new System.Drawing.Size(159, 33);
      this.btnRemoveSelected.TabIndex = 8;
      this.btnRemoveSelected.Text = "移除所选";
      this.btnRemoveSelected.UseVisualStyleBackColor = true;
      // 
      // btnGoogleIt
      // 
      this.btnGoogleIt.Location = new System.Drawing.Point(182, 362);
      this.btnGoogleIt.Name = "btnGoogleIt";
      this.btnGoogleIt.Size = new System.Drawing.Size(429, 34);
      this.btnGoogleIt.TabIndex = 9;
      this.btnGoogleIt.Text = "谷歌一下这个字";
      this.btnGoogleIt.UseVisualStyleBackColor = true;
      // 
      // btnWikiIt
      // 
      this.btnWikiIt.Location = new System.Drawing.Point(182, 402);
      this.btnWikiIt.Name = "btnWikiIt";
      this.btnWikiIt.Size = new System.Drawing.Size(429, 34);
      this.btnWikiIt.TabIndex = 10;
      this.btnWikiIt.Text = "在维基字典上查这个字";
      this.btnWikiIt.UseVisualStyleBackColor = true;
      // 
      // lblCharKeywords
      // 
      this.lblCharKeywords.Location = new System.Drawing.Point(178, 200);
      this.lblCharKeywords.Name = "lblCharKeywords";
      this.lblCharKeywords.Size = new System.Drawing.Size(310, 156);
      this.lblCharKeywords.TabIndex = 11;
      this.lblCharKeywords.Text = "关键字：";
      // 
      // btnDone
      // 
      this.btnDone.Location = new System.Drawing.Point(617, 394);
      this.btnDone.Name = "btnDone";
      this.btnDone.Size = new System.Drawing.Size(159, 42);
      this.btnDone.TabIndex = 12;
      this.btnDone.Text = "确定";
      this.btnDone.UseVisualStyleBackColor = true;
      // 
      // btnEditKeywords
      // 
      this.btnEditKeywords.Location = new System.Drawing.Point(498, 314);
      this.btnEditKeywords.Name = "btnEditKeywords";
      this.btnEditKeywords.Size = new System.Drawing.Size(113, 42);
      this.btnEditKeywords.TabIndex = 13;
      this.btnEditKeywords.Text = "编辑...";
      this.btnEditKeywords.UseVisualStyleBackColor = true;
      // 
      // frmKeyword
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(786, 444);
      this.Controls.Add(this.btnEditKeywords);
      this.Controls.Add(this.btnDone);
      this.Controls.Add(this.lblCharKeywords);
      this.Controls.Add(this.btnWikiIt);
      this.Controls.Add(this.btnGoogleIt);
      this.Controls.Add(this.btnRemoveSelected);
      this.Controls.Add(this.btnManageChars);
      this.Controls.Add(this.lstSelectedKeywords);
      this.Controls.Add(this.btnUseKeyword);
      this.Controls.Add(this.lstKeyWords);
      this.Controls.Add(this.lblCurrentKeyword);
      this.Controls.Add(this.lstCharecters);
      this.Controls.Add(this.lblCharDisplay);
      this.Font = new System.Drawing.Font("FangSong", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(4);
      this.Name = "frmKeyword";
      this.Text = "预设字组";
      this.Load += new System.EventHandler(this.frmKeyword_Load);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.ListBox lstKeyWords;
    private System.Windows.Forms.ListView lstCharecters;
    private System.Windows.Forms.Label lblCharDisplay;
    private System.Windows.Forms.Label lblCurrentKeyword;
    private System.Windows.Forms.Button btnUseKeyword;
    private System.Windows.Forms.ListBox lstSelectedKeywords;
    private System.Windows.Forms.Button btnManageChars;
    private System.Windows.Forms.Button btnRemoveSelected;
    private System.Windows.Forms.Button btnGoogleIt;
    private System.Windows.Forms.Button btnWikiIt;
    private System.Windows.Forms.Label lblCharKeywords;
    private System.Windows.Forms.Button btnDone;
    private System.Windows.Forms.Button btnEditKeywords;
  }
}