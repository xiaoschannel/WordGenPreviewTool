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
      this.btnUnselectKeywords = new System.Windows.Forms.Button();
      this.btnGoogleIt = new System.Windows.Forms.Button();
      this.btnWikiIt = new System.Windows.Forms.Button();
      this.lblCharKeywords = new System.Windows.Forms.Label();
      this.btnApply = new System.Windows.Forms.Button();
      this.btnEditCharOfKeyword = new System.Windows.Forms.Button();
      this.btnDeleteSelectedKeywords = new System.Windows.Forms.Button();
      this.btnNewKeyword = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // lstKeyWords
      // 
      this.lstKeyWords.FormattingEnabled = true;
      this.lstKeyWords.ItemHeight = 20;
      this.lstKeyWords.Items.AddRange(new object[] {
            "读取中……"});
      this.lstKeyWords.Location = new System.Drawing.Point(13, 4);
      this.lstKeyWords.Name = "lstKeyWords";
      this.lstKeyWords.Size = new System.Drawing.Size(159, 344);
      this.lstKeyWords.TabIndex = 1;
      this.lstKeyWords.SelectedIndexChanged += new System.EventHandler(this.lstKeyWords_SelectedIndexChanged);
      // 
      // lstCharecters
      // 
      this.lstCharecters.Location = new System.Drawing.Point(178, 87);
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
      this.lblCharDisplay.Location = new System.Drawing.Point(477, 231);
      this.lblCharDisplay.Name = "lblCharDisplay";
      this.lblCharDisplay.Size = new System.Drawing.Size(165, 121);
      this.lblCharDisplay.TabIndex = 3;
      this.lblCharDisplay.Text = "例";
      // 
      // lblCurrentKeyword
      // 
      this.lblCurrentKeyword.Font = new System.Drawing.Font("FangSong", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblCurrentKeyword.Location = new System.Drawing.Point(178, 8);
      this.lblCurrentKeyword.Name = "lblCurrentKeyword";
      this.lblCurrentKeyword.Size = new System.Drawing.Size(311, 72);
      this.lblCurrentKeyword.TabIndex = 4;
      this.lblCurrentKeyword.Text = "（请选择一个关键字）";
      this.lblCurrentKeyword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // btnUseKeyword
      // 
      this.btnUseKeyword.Location = new System.Drawing.Point(495, 4);
      this.btnUseKeyword.Name = "btnUseKeyword";
      this.btnUseKeyword.Size = new System.Drawing.Size(116, 36);
      this.btnUseKeyword.TabIndex = 5;
      this.btnUseKeyword.Text = "加入>";
      this.btnUseKeyword.UseVisualStyleBackColor = true;
      this.btnUseKeyword.Click += new System.EventHandler(this.btnUseKeyword_Click);
      // 
      // lstSelectedKeywords
      // 
      this.lstSelectedKeywords.FormattingEnabled = true;
      this.lstSelectedKeywords.ItemHeight = 20;
      this.lstSelectedKeywords.Location = new System.Drawing.Point(617, 4);
      this.lstSelectedKeywords.Name = "lstSelectedKeywords";
      this.lstSelectedKeywords.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
      this.lstSelectedKeywords.Size = new System.Drawing.Size(159, 344);
      this.lstSelectedKeywords.TabIndex = 6;
      // 
      // btnUnselectKeywords
      // 
      this.btnUnselectKeywords.Location = new System.Drawing.Point(617, 351);
      this.btnUnselectKeywords.Name = "btnUnselectKeywords";
      this.btnUnselectKeywords.Size = new System.Drawing.Size(159, 33);
      this.btnUnselectKeywords.TabIndex = 8;
      this.btnUnselectKeywords.Text = "移除所选";
      this.btnUnselectKeywords.UseVisualStyleBackColor = true;
      this.btnUnselectKeywords.Click += new System.EventHandler(this.btnRemoveSelected_Click);
      // 
      // btnGoogleIt
      // 
      this.btnGoogleIt.Location = new System.Drawing.Point(178, 362);
      this.btnGoogleIt.Name = "btnGoogleIt";
      this.btnGoogleIt.Size = new System.Drawing.Size(433, 34);
      this.btnGoogleIt.TabIndex = 9;
      this.btnGoogleIt.Text = "谷歌一下这个字";
      this.btnGoogleIt.UseVisualStyleBackColor = true;
      // 
      // btnWikiIt
      // 
      this.btnWikiIt.Location = new System.Drawing.Point(178, 402);
      this.btnWikiIt.Name = "btnWikiIt";
      this.btnWikiIt.Size = new System.Drawing.Size(433, 34);
      this.btnWikiIt.TabIndex = 10;
      this.btnWikiIt.Text = "在维基字典上查这个字";
      this.btnWikiIt.UseVisualStyleBackColor = true;
      // 
      // lblCharKeywords
      // 
      this.lblCharKeywords.Location = new System.Drawing.Point(178, 231);
      this.lblCharKeywords.Name = "lblCharKeywords";
      this.lblCharKeywords.Size = new System.Drawing.Size(310, 126);
      this.lblCharKeywords.TabIndex = 11;
      this.lblCharKeywords.Text = "关键字：";
      // 
      // btnApply
      // 
      this.btnApply.Location = new System.Drawing.Point(617, 402);
      this.btnApply.Name = "btnApply";
      this.btnApply.Size = new System.Drawing.Size(159, 34);
      this.btnApply.TabIndex = 14;
      this.btnApply.Text = "应用";
      this.btnApply.UseVisualStyleBackColor = true;
      this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
      // 
      // btnEditCharOfKeyword
      // 
      this.btnEditCharOfKeyword.Location = new System.Drawing.Point(495, 44);
      this.btnEditCharOfKeyword.Name = "btnEditCharOfKeyword";
      this.btnEditCharOfKeyword.Size = new System.Drawing.Size(116, 36);
      this.btnEditCharOfKeyword.TabIndex = 15;
      this.btnEditCharOfKeyword.Text = "编辑...";
      this.btnEditCharOfKeyword.UseVisualStyleBackColor = true;
      this.btnEditCharOfKeyword.Click += new System.EventHandler(this.btnEditCharOfKeyword_Click);
      // 
      // btnDeleteSelectedKeywords
      // 
      this.btnDeleteSelectedKeywords.Location = new System.Drawing.Point(13, 351);
      this.btnDeleteSelectedKeywords.Name = "btnDeleteSelectedKeywords";
      this.btnDeleteSelectedKeywords.Size = new System.Drawing.Size(159, 33);
      this.btnDeleteSelectedKeywords.TabIndex = 16;
      this.btnDeleteSelectedKeywords.Text = "移除所选";
      this.btnDeleteSelectedKeywords.UseVisualStyleBackColor = true;
      this.btnDeleteSelectedKeywords.Click += new System.EventHandler(this.btnDeleteSelectedKeywords_Click);
      // 
      // btnNewKeyword
      // 
      this.btnNewKeyword.Location = new System.Drawing.Point(13, 402);
      this.btnNewKeyword.Name = "btnNewKeyword";
      this.btnNewKeyword.Size = new System.Drawing.Size(159, 34);
      this.btnNewKeyword.TabIndex = 17;
      this.btnNewKeyword.Text = "新关键字...";
      this.btnNewKeyword.UseVisualStyleBackColor = true;
      this.btnNewKeyword.Click += new System.EventHandler(this.btnNewKeyword_Click);
      // 
      // frmKeyword
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(786, 444);
      this.Controls.Add(this.btnNewKeyword);
      this.Controls.Add(this.btnDeleteSelectedKeywords);
      this.Controls.Add(this.btnEditCharOfKeyword);
      this.Controls.Add(this.btnApply);
      this.Controls.Add(this.lblCharKeywords);
      this.Controls.Add(this.btnWikiIt);
      this.Controls.Add(this.btnGoogleIt);
      this.Controls.Add(this.btnUnselectKeywords);
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
    private System.Windows.Forms.Button btnUnselectKeywords;
    private System.Windows.Forms.Button btnGoogleIt;
    private System.Windows.Forms.Button btnWikiIt;
    private System.Windows.Forms.Label lblCharKeywords;
    private System.Windows.Forms.Button btnApply;
    private System.Windows.Forms.Button btnEditCharOfKeyword;
    private System.Windows.Forms.Button btnDeleteSelectedKeywords;
    private System.Windows.Forms.Button btnNewKeyword;
  }
}