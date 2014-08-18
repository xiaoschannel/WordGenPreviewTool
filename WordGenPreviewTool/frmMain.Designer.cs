namespace WordGenPreviewTool
{
    partial class frmMain
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
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.btnCharSets = new System.Windows.Forms.Button();
      this.btnAddChar = new System.Windows.Forms.Button();
      this.nudNWords = new System.Windows.Forms.NumericUpDown();
      this.label8 = new System.Windows.Forms.Label();
      this.cbxNoRepeating = new System.Windows.Forms.CheckBox();
      this.txtPattern = new System.Windows.Forms.TextBox();
      this.nudNChars = new System.Windows.Forms.NumericUpDown();
      this.rbtModePattern = new System.Windows.Forms.RadioButton();
      this.rbtModeNChar = new System.Windows.Forms.RadioButton();
      this.label7 = new System.Windows.Forms.Label();
      this.txtPostFix = new System.Windows.Forms.TextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.txtPrefix = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.btnCharsClear = new System.Windows.Forms.Button();
      this.btnCharsRemove = new System.Windows.Forms.Button();
      this.lstChars = new System.Windows.Forms.ListView();
      this.label4 = new System.Windows.Forms.Label();
      this.txtCharToAdd = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.groupBox3 = new System.Windows.Forms.GroupBox();
      this.btnTypeNewWord = new System.Windows.Forms.Button();
      this.cbxBold = new System.Windows.Forms.CheckBox();
      this.label10 = new System.Windows.Forms.Label();
      this.cmxTypefaces = new System.Windows.Forms.ComboBox();
      this.cbxUnderline = new System.Windows.Forms.CheckBox();
      this.cbxItalic = new System.Windows.Forms.CheckBox();
      this.lbl18 = new System.Windows.Forms.Label();
      this.label13 = new System.Windows.Forms.Label();
      this.lbl12 = new System.Windows.Forms.Label();
      this.label11 = new System.Windows.Forms.Label();
      this.lbl8 = new System.Windows.Forms.Label();
      this.label9 = new System.Windows.Forms.Label();
      this.btnUnselectWord = new System.Windows.Forms.Button();
      this.btnClearSelection = new System.Windows.Forms.Button();
      this.btnGenerate = new System.Windows.Forms.Button();
      this.btnSelectWord = new System.Windows.Forms.Button();
      this.lstSelected = new System.Windows.Forms.ListView();
      this.label2 = new System.Windows.Forms.Label();
      this.lstGenerated = new System.Windows.Forms.ListView();
      this.label1 = new System.Windows.Forms.Label();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.btnCopyAllChars = new System.Windows.Forms.Button();
      this.btnCopyAllGenerated = new System.Windows.Forms.Button();
      this.btnCopyAllSelected = new System.Windows.Forms.Button();
      this.btnCopyCurrentPreview = new System.Windows.Forms.Button();
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.nudNWords)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.nudNChars)).BeginInit();
      this.groupBox3.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.btnCharSets);
      this.groupBox1.Controls.Add(this.btnAddChar);
      this.groupBox1.Controls.Add(this.nudNWords);
      this.groupBox1.Controls.Add(this.label8);
      this.groupBox1.Controls.Add(this.cbxNoRepeating);
      this.groupBox1.Controls.Add(this.txtPattern);
      this.groupBox1.Controls.Add(this.nudNChars);
      this.groupBox1.Controls.Add(this.rbtModePattern);
      this.groupBox1.Controls.Add(this.rbtModeNChar);
      this.groupBox1.Controls.Add(this.label7);
      this.groupBox1.Controls.Add(this.txtPostFix);
      this.groupBox1.Controls.Add(this.label6);
      this.groupBox1.Controls.Add(this.txtPrefix);
      this.groupBox1.Controls.Add(this.label5);
      this.groupBox1.Controls.Add(this.btnCharsClear);
      this.groupBox1.Controls.Add(this.btnCharsRemove);
      this.groupBox1.Controls.Add(this.lstChars);
      this.groupBox1.Controls.Add(this.label4);
      this.groupBox1.Controls.Add(this.txtCharToAdd);
      this.groupBox1.Controls.Add(this.label3);
      this.groupBox1.Location = new System.Drawing.Point(12, 12);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(287, 597);
      this.groupBox1.TabIndex = 8;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "设定";
      // 
      // btnCharSets
      // 
      this.btnCharSets.Location = new System.Drawing.Point(14, 89);
      this.btnCharSets.Name = "btnCharSets";
      this.btnCharSets.Size = new System.Drawing.Size(267, 28);
      this.btnCharSets.TabIndex = 20;
      this.btnCharSets.Text = "字组管理...";
      this.btnCharSets.UseVisualStyleBackColor = true;
      this.btnCharSets.Click += new System.EventHandler(this.btnCharSets_Click);
      // 
      // btnAddChar
      // 
      this.btnAddChar.Location = new System.Drawing.Point(204, 56);
      this.btnAddChar.Name = "btnAddChar";
      this.btnAddChar.Size = new System.Drawing.Size(77, 30);
      this.btnAddChar.TabIndex = 1;
      this.btnAddChar.Text = "加入";
      this.btnAddChar.UseVisualStyleBackColor = true;
      this.btnAddChar.Click += new System.EventHandler(this.btnAddChar_Click);
      // 
      // nudNWords
      // 
      this.nudNWords.Location = new System.Drawing.Point(221, 556);
      this.nudNWords.Name = "nudNWords";
      this.nudNWords.Size = new System.Drawing.Size(51, 30);
      this.nudNWords.TabIndex = 19;
      this.nudNWords.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(164, 561);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(72, 20);
      this.label8.TabIndex = 18;
      this.label8.Text = "词数：";
      // 
      // cbxNoRepeating
      // 
      this.cbxNoRepeating.AutoSize = true;
      this.cbxNoRepeating.Checked = true;
      this.cbxNoRepeating.CheckState = System.Windows.Forms.CheckState.Checked;
      this.cbxNoRepeating.Location = new System.Drawing.Point(7, 557);
      this.cbxNoRepeating.Name = "cbxNoRepeating";
      this.cbxNoRepeating.Size = new System.Drawing.Size(136, 24);
      this.cbxNoRepeating.TabIndex = 17;
      this.cbxNoRepeating.Text = "不重复用字";
      this.cbxNoRepeating.UseVisualStyleBackColor = true;
      // 
      // txtPattern
      // 
      this.txtPattern.Location = new System.Drawing.Point(138, 520);
      this.txtPattern.Name = "txtPattern";
      this.txtPattern.Size = new System.Drawing.Size(134, 30);
      this.txtPattern.TabIndex = 16;
      this.txtPattern.TextChanged += new System.EventHandler(this.txtPattern_TextChanged);
      // 
      // nudNChars
      // 
      this.nudNChars.Location = new System.Drawing.Point(10, 520);
      this.nudNChars.Name = "nudNChars";
      this.nudNChars.Size = new System.Drawing.Size(122, 30);
      this.nudNChars.TabIndex = 15;
      this.nudNChars.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.nudNChars.ValueChanged += new System.EventHandler(this.nudNChars_ValueChanged);
      this.nudNChars.EnabledChanged += new System.EventHandler(this.nudNChars_EnabledChanged);
      // 
      // rbtModePattern
      // 
      this.rbtModePattern.AutoSize = true;
      this.rbtModePattern.Location = new System.Drawing.Point(138, 492);
      this.rbtModePattern.Name = "rbtModePattern";
      this.rbtModePattern.Size = new System.Drawing.Size(114, 24);
      this.rbtModePattern.TabIndex = 14;
      this.rbtModePattern.Text = "模板生成";
      this.rbtModePattern.UseVisualStyleBackColor = true;
      this.rbtModePattern.CheckedChanged += new System.EventHandler(this.rbtModePattern_CheckedChanged);
      // 
      // rbtModeNChar
      // 
      this.rbtModeNChar.AutoSize = true;
      this.rbtModeNChar.Checked = true;
      this.rbtModeNChar.Location = new System.Drawing.Point(11, 492);
      this.rbtModeNChar.Name = "rbtModeNChar";
      this.rbtModeNChar.Size = new System.Drawing.Size(114, 24);
      this.rbtModeNChar.TabIndex = 13;
      this.rbtModeNChar.TabStop = true;
      this.rbtModeNChar.Text = "字数生成";
      this.rbtModeNChar.UseVisualStyleBackColor = true;
      this.rbtModeNChar.CheckedChanged += new System.EventHandler(this.rbtModeNChar_CheckedChanged);
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(138, 433);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(72, 20);
      this.label7.TabIndex = 12;
      this.label7.Text = "后缀：";
      // 
      // txtPostFix
      // 
      this.txtPostFix.Location = new System.Drawing.Point(138, 456);
      this.txtPostFix.Name = "txtPostFix";
      this.txtPostFix.Size = new System.Drawing.Size(134, 30);
      this.txtPostFix.TabIndex = 11;
      this.txtPostFix.TextChanged += new System.EventHandler(this.txtPostFix_TextChanged);
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(10, 433);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(72, 20);
      this.label6.TabIndex = 10;
      this.label6.Text = "前缀：";
      // 
      // txtPrefix
      // 
      this.txtPrefix.Location = new System.Drawing.Point(10, 456);
      this.txtPrefix.Name = "txtPrefix";
      this.txtPrefix.Size = new System.Drawing.Size(122, 30);
      this.txtPrefix.TabIndex = 8;
      this.txtPrefix.TextChanged += new System.EventHandler(this.txtPrefix_TextChanged);
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(10, 119);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(135, 20);
      this.label5.TabIndex = 7;
      this.label5.Text = "生成用汉字：";
      // 
      // btnCharsClear
      // 
      this.btnCharsClear.Location = new System.Drawing.Point(196, 382);
      this.btnCharsClear.Name = "btnCharsClear";
      this.btnCharsClear.Size = new System.Drawing.Size(76, 43);
      this.btnCharsClear.TabIndex = 6;
      this.btnCharsClear.Text = "清空";
      this.btnCharsClear.UseVisualStyleBackColor = true;
      this.btnCharsClear.Click += new System.EventHandler(this.btnCharsClear_Click);
      // 
      // btnCharsRemove
      // 
      this.btnCharsRemove.Location = new System.Drawing.Point(11, 382);
      this.btnCharsRemove.Name = "btnCharsRemove";
      this.btnCharsRemove.Size = new System.Drawing.Size(179, 43);
      this.btnCharsRemove.TabIndex = 5;
      this.btnCharsRemove.Text = "移除所选";
      this.btnCharsRemove.UseVisualStyleBackColor = true;
      this.btnCharsRemove.Click += new System.EventHandler(this.btnCharsRemove_Click);
      // 
      // lstChars
      // 
      this.lstChars.Location = new System.Drawing.Point(11, 142);
      this.lstChars.Name = "lstChars";
      this.lstChars.Size = new System.Drawing.Size(261, 234);
      this.lstChars.TabIndex = 4;
      this.lstChars.TileSize = new System.Drawing.Size(36, 36);
      this.lstChars.UseCompatibleStateImageBehavior = false;
      this.lstChars.View = System.Windows.Forms.View.Tile;
      this.lstChars.SelectedIndexChanged += new System.EventHandler(this.lstChars_SelectedIndexChanged);
      // 
      // label4
      // 
      this.label4.Font = new System.Drawing.Font("FangSong", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.Image = global::WordGenPreviewTool.Properties.Resources.glyphicons_195_circle_info;
      this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.label4.Location = new System.Drawing.Point(45, 57);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(153, 29);
      this.label4.TabIndex = 3;
      this.label4.Text = "无需分隔文字";
      this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // txtCharToAdd
      // 
      this.txtCharToAdd.Location = new System.Drawing.Point(109, 20);
      this.txtCharToAdd.Name = "txtCharToAdd";
      this.txtCharToAdd.Size = new System.Drawing.Size(172, 30);
      this.txtCharToAdd.TabIndex = 2;
      this.txtCharToAdd.Text = "甲乙丙丁";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(7, 26);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(114, 20);
      this.label3.TabIndex = 0;
      this.label3.Text = "加入汉字：";
      // 
      // groupBox3
      // 
      this.groupBox3.Controls.Add(this.groupBox2);
      this.groupBox3.Controls.Add(this.btnTypeNewWord);
      this.groupBox3.Controls.Add(this.cbxBold);
      this.groupBox3.Controls.Add(this.label10);
      this.groupBox3.Controls.Add(this.cmxTypefaces);
      this.groupBox3.Controls.Add(this.cbxUnderline);
      this.groupBox3.Controls.Add(this.cbxItalic);
      this.groupBox3.Controls.Add(this.lbl18);
      this.groupBox3.Controls.Add(this.label13);
      this.groupBox3.Controls.Add(this.lbl12);
      this.groupBox3.Controls.Add(this.label11);
      this.groupBox3.Controls.Add(this.lbl8);
      this.groupBox3.Controls.Add(this.label9);
      this.groupBox3.Controls.Add(this.btnUnselectWord);
      this.groupBox3.Controls.Add(this.btnClearSelection);
      this.groupBox3.Controls.Add(this.btnGenerate);
      this.groupBox3.Controls.Add(this.btnSelectWord);
      this.groupBox3.Controls.Add(this.lstSelected);
      this.groupBox3.Controls.Add(this.label2);
      this.groupBox3.Controls.Add(this.lstGenerated);
      this.groupBox3.Controls.Add(this.label1);
      this.groupBox3.Location = new System.Drawing.Point(305, 12);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new System.Drawing.Size(662, 597);
      this.groupBox3.TabIndex = 10;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "生成及预览";
      // 
      // btnTypeNewWord
      // 
      this.btnTypeNewWord.Location = new System.Drawing.Point(10, 543);
      this.btnTypeNewWord.Name = "btnTypeNewWord";
      this.btnTypeNewWord.Size = new System.Drawing.Size(106, 43);
      this.btnTypeNewWord.TabIndex = 27;
      this.btnTypeNewWord.Text = "输入新词";
      this.btnTypeNewWord.UseVisualStyleBackColor = true;
      this.btnTypeNewWord.Click += new System.EventHandler(this.btnTypeNewWord_Click);
      // 
      // cbxBold
      // 
      this.cbxBold.AutoSize = true;
      this.cbxBold.Location = new System.Drawing.Point(380, 262);
      this.cbxBold.Name = "cbxBold";
      this.cbxBold.Size = new System.Drawing.Size(73, 24);
      this.cbxBold.TabIndex = 26;
      this.cbxBold.Text = "粗体";
      this.cbxBold.UseVisualStyleBackColor = true;
      this.cbxBold.CheckedChanged += new System.EventHandler(this.cbxBold_CheckedChanged);
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Location = new System.Drawing.Point(374, 312);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(114, 20);
      this.label10.TabIndex = 25;
      this.label10.Text = "选择字体：";
      // 
      // cmxTypefaces
      // 
      this.cmxTypefaces.FormattingEnabled = true;
      this.cmxTypefaces.Location = new System.Drawing.Point(374, 350);
      this.cmxTypefaces.Name = "cmxTypefaces";
      this.cmxTypefaces.Size = new System.Drawing.Size(269, 28);
      this.cmxTypefaces.TabIndex = 24;
      this.cmxTypefaces.SelectedIndexChanged += new System.EventHandler(this.cmxTypefaces_SelectedIndexChanged);
      // 
      // cbxUnderline
      // 
      this.cbxUnderline.AutoSize = true;
      this.cbxUnderline.Location = new System.Drawing.Point(538, 262);
      this.cbxUnderline.Name = "cbxUnderline";
      this.cbxUnderline.Size = new System.Drawing.Size(94, 24);
      this.cbxUnderline.TabIndex = 23;
      this.cbxUnderline.Text = "下划线";
      this.cbxUnderline.UseVisualStyleBackColor = true;
      this.cbxUnderline.CheckedChanged += new System.EventHandler(this.cbxUnderLine_CheckedChanged);
      // 
      // cbxItalic
      // 
      this.cbxItalic.AutoSize = true;
      this.cbxItalic.Location = new System.Drawing.Point(459, 262);
      this.cbxItalic.Name = "cbxItalic";
      this.cbxItalic.Size = new System.Drawing.Size(73, 24);
      this.cbxItalic.TabIndex = 22;
      this.cbxItalic.Text = "斜体";
      this.cbxItalic.UseVisualStyleBackColor = true;
      this.cbxItalic.CheckedChanged += new System.EventHandler(this.cbxItalic_CheckedChanged);
      // 
      // lbl18
      // 
      this.lbl18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.lbl18.Font = new System.Drawing.Font("FangSong", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl18.Location = new System.Drawing.Point(386, 189);
      this.lbl18.Name = "lbl18";
      this.lbl18.Size = new System.Drawing.Size(257, 42);
      this.lbl18.TabIndex = 21;
      this.lbl18.Text = "请选中一个词";
      this.lbl18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // label13
      // 
      this.label13.AutoSize = true;
      this.label13.Location = new System.Drawing.Point(370, 169);
      this.label13.Name = "label13";
      this.label13.Size = new System.Drawing.Size(73, 20);
      this.label13.TabIndex = 20;
      this.label13.Text = "18号：";
      // 
      // lbl12
      // 
      this.lbl12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.lbl12.Font = new System.Drawing.Font("FangSong", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl12.Location = new System.Drawing.Point(386, 119);
      this.lbl12.Name = "lbl12";
      this.lbl12.Size = new System.Drawing.Size(257, 42);
      this.lbl12.TabIndex = 19;
      this.lbl12.Text = "请选中一个词";
      this.lbl12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // label11
      // 
      this.label11.AutoSize = true;
      this.label11.Location = new System.Drawing.Point(370, 97);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(73, 20);
      this.label11.TabIndex = 18;
      this.label11.Text = "12号：";
      // 
      // lbl8
      // 
      this.lbl8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.lbl8.Font = new System.Drawing.Font("FangSong", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl8.Location = new System.Drawing.Point(386, 47);
      this.lbl8.Name = "lbl8";
      this.lbl8.Size = new System.Drawing.Size(257, 42);
      this.lbl8.TabIndex = 17;
      this.lbl8.Text = "请选中一个词";
      this.lbl8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Location = new System.Drawing.Point(370, 23);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(62, 20);
      this.label9.TabIndex = 16;
      this.label9.Text = "8号：";
      // 
      // btnUnselectWord
      // 
      this.btnUnselectWord.AutoSize = true;
      this.btnUnselectWord.Location = new System.Drawing.Point(122, 543);
      this.btnUnselectWord.Name = "btnUnselectWord";
      this.btnUnselectWord.Size = new System.Drawing.Size(143, 43);
      this.btnUnselectWord.TabIndex = 15;
      this.btnUnselectWord.Text = "移除所选";
      this.btnUnselectWord.UseVisualStyleBackColor = true;
      this.btnUnselectWord.Click += new System.EventHandler(this.btnUnselectWord_Click);
      // 
      // btnClearSelection
      // 
      this.btnClearSelection.Location = new System.Drawing.Point(271, 543);
      this.btnClearSelection.Name = "btnClearSelection";
      this.btnClearSelection.Size = new System.Drawing.Size(76, 43);
      this.btnClearSelection.TabIndex = 14;
      this.btnClearSelection.Text = "清空";
      this.btnClearSelection.UseVisualStyleBackColor = true;
      this.btnClearSelection.Click += new System.EventHandler(this.btnClearSelection_Click);
      // 
      // btnGenerate
      // 
      this.btnGenerate.AutoSize = true;
      this.btnGenerate.Location = new System.Drawing.Point(10, 235);
      this.btnGenerate.Name = "btnGenerate";
      this.btnGenerate.Size = new System.Drawing.Size(160, 43);
      this.btnGenerate.TabIndex = 13;
      this.btnGenerate.Text = "刷新备选词";
      this.btnGenerate.UseVisualStyleBackColor = true;
      this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
      // 
      // btnSelectWord
      // 
      this.btnSelectWord.Location = new System.Drawing.Point(176, 235);
      this.btnSelectWord.Name = "btnSelectWord";
      this.btnSelectWord.Size = new System.Drawing.Size(170, 43);
      this.btnSelectWord.TabIndex = 12;
      this.btnSelectWord.Text = "加入候补";
      this.btnSelectWord.UseVisualStyleBackColor = true;
      this.btnSelectWord.Click += new System.EventHandler(this.btnSelectWord_Click);
      // 
      // lstSelected
      // 
      this.lstSelected.Location = new System.Drawing.Point(10, 306);
      this.lstSelected.Name = "lstSelected";
      this.lstSelected.Size = new System.Drawing.Size(336, 231);
      this.lstSelected.TabIndex = 11;
      this.lstSelected.UseCompatibleStateImageBehavior = false;
      this.lstSelected.View = System.Windows.Forms.View.List;
      this.lstSelected.SelectedIndexChanged += new System.EventHandler(this.lstSelected_SelectedIndexChanged);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(6, 283);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(135, 20);
      this.label2.TabIndex = 10;
      this.label2.Text = "已选定候补：";
      // 
      // lstGenerated
      // 
      this.lstGenerated.Location = new System.Drawing.Point(10, 49);
      this.lstGenerated.Name = "lstGenerated";
      this.lstGenerated.Size = new System.Drawing.Size(336, 180);
      this.lstGenerated.TabIndex = 9;
      this.lstGenerated.UseCompatibleStateImageBehavior = false;
      this.lstGenerated.View = System.Windows.Forms.View.Tile;
      this.lstGenerated.SelectedIndexChanged += new System.EventHandler(this.lstGenerated_SelectedIndexChanged);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(6, 26);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(93, 20);
      this.label1.TabIndex = 8;
      this.label1.Text = "备选词：";
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.btnCopyCurrentPreview);
      this.groupBox2.Controls.Add(this.btnCopyAllSelected);
      this.groupBox2.Controls.Add(this.btnCopyAllGenerated);
      this.groupBox2.Controls.Add(this.btnCopyAllChars);
      this.groupBox2.Location = new System.Drawing.Point(368, 386);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(275, 100);
      this.groupBox2.TabIndex = 28;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "复制到剪贴板";
      // 
      // btnCopyAllChars
      // 
      this.btnCopyAllChars.Location = new System.Drawing.Point(9, 29);
      this.btnCopyAllChars.Name = "btnCopyAllChars";
      this.btnCopyAllChars.Size = new System.Drawing.Size(60, 60);
      this.btnCopyAllChars.TabIndex = 0;
      this.btnCopyAllChars.Text = "所有汉字";
      this.btnCopyAllChars.UseVisualStyleBackColor = true;
      this.btnCopyAllChars.Click += new System.EventHandler(this.btnCopyAllChars_Click);
      // 
      // btnCopyAllGenerated
      // 
      this.btnCopyAllGenerated.Location = new System.Drawing.Point(75, 29);
      this.btnCopyAllGenerated.Name = "btnCopyAllGenerated";
      this.btnCopyAllGenerated.Size = new System.Drawing.Size(60, 60);
      this.btnCopyAllGenerated.TabIndex = 1;
      this.btnCopyAllGenerated.Text = "所有备选";
      this.btnCopyAllGenerated.UseVisualStyleBackColor = true;
      this.btnCopyAllGenerated.Click += new System.EventHandler(this.btnCopyAllGenerated_Click);
      // 
      // btnCopyAllSelected
      // 
      this.btnCopyAllSelected.Location = new System.Drawing.Point(141, 29);
      this.btnCopyAllSelected.Name = "btnCopyAllSelected";
      this.btnCopyAllSelected.Size = new System.Drawing.Size(60, 60);
      this.btnCopyAllSelected.TabIndex = 2;
      this.btnCopyAllSelected.Text = "所有候补";
      this.btnCopyAllSelected.UseVisualStyleBackColor = true;
      this.btnCopyAllSelected.Click += new System.EventHandler(this.btnCopyAllSelected_Click);
      // 
      // btnCopyCurrentPreview
      // 
      this.btnCopyCurrentPreview.Location = new System.Drawing.Point(207, 29);
      this.btnCopyCurrentPreview.Name = "btnCopyCurrentPreview";
      this.btnCopyCurrentPreview.Size = new System.Drawing.Size(60, 60);
      this.btnCopyCurrentPreview.TabIndex = 3;
      this.btnCopyCurrentPreview.Text = "当前预览";
      this.btnCopyCurrentPreview.UseVisualStyleBackColor = true;
      this.btnCopyCurrentPreview.Click += new System.EventHandler(this.btnCopyCurrentPreview_Click);
      // 
      // frmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(979, 621);
      this.Controls.Add(this.groupBox3);
      this.Controls.Add(this.groupBox1);
      this.Font = new System.Drawing.Font("FangSong", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Margin = new System.Windows.Forms.Padding(4);
      this.Name = "frmMain";
      this.Text = "造词及预览工具";
      this.Load += new System.EventHandler(this.frmMain_Load);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.nudNWords)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.nudNChars)).EndInit();
      this.groupBox3.ResumeLayout(false);
      this.groupBox3.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnUnselectWord;
        private System.Windows.Forms.Button btnClearSelection;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnSelectWord;
        private System.Windows.Forms.ListView lstSelected;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lstGenerated;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCharToAdd;
        private System.Windows.Forms.Button btnAddChar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbtModePattern;
        private System.Windows.Forms.RadioButton rbtModeNChar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPostFix;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPrefix;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCharsClear;
        private System.Windows.Forms.Button btnCharsRemove;
        private System.Windows.Forms.ListView lstChars;
        private System.Windows.Forms.CheckBox cbxNoRepeating;
        private System.Windows.Forms.TextBox txtPattern;
        private System.Windows.Forms.NumericUpDown nudNChars;
        private System.Windows.Forms.NumericUpDown nudNWords;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl18;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbl12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmxTypefaces;
        private System.Windows.Forms.CheckBox cbxUnderline;
        private System.Windows.Forms.CheckBox cbxItalic;
        private System.Windows.Forms.CheckBox cbxBold;
        private System.Windows.Forms.Button btnCharSets;
        private System.Windows.Forms.Button btnTypeNewWord;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCopyCurrentPreview;
        private System.Windows.Forms.Button btnCopyAllSelected;
        private System.Windows.Forms.Button btnCopyAllGenerated;
        private System.Windows.Forms.Button btnCopyAllChars;


    }
}

