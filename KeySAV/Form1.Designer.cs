namespace KeySAV
{
    partial class KeySAV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KeySAV));
            this.B_OpenKey = new System.Windows.Forms.Button();
            this.T_key = new System.Windows.Forms.TextBox();
            this.T_KeyOffset = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.B_DumpEKX = new System.Windows.Forms.Button();
            this.B_DumpKey = new System.Windows.Forms.Button();
            this.T_ekx = new System.Windows.Forms.TextBox();
            this.B_OpenEKX = new System.Windows.Forms.Button();
            this.T_S1 = new System.Windows.Forms.TextBox();
            this.B_S1 = new System.Windows.Forms.Button();
            this.B_S2 = new System.Windows.Forms.Button();
            this.T_S2 = new System.Windows.Forms.TextBox();
            this.B_E1 = new System.Windows.Forms.Button();
            this.B_E2 = new System.Windows.Forms.Button();
            this.T_E1 = new System.Windows.Forms.TextBox();
            this.T_E2 = new System.Windows.Forms.TextBox();
            this.T_Key2Offset = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.B_GetKey2 = new System.Windows.Forms.Button();
            this.T_Open1 = new System.Windows.Forms.TextBox();
            this.B_OpenSAV = new System.Windows.Forms.Button();
            this.TC = new System.Windows.Forms.TabControl();
            this.Tab_BreakBox = new System.Windows.Forms.TabPage();
            this.B_DumpBlank = new System.Windows.Forms.Button();
            this.B_DumpBreakBox2 = new System.Windows.Forms.Button();
            this.B_DumpBreakBox1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.T_0xE0 = new System.Windows.Forms.MaskedTextBox();
            this.T_0xE3 = new System.Windows.Forms.MaskedTextBox();
            this.T_0xE2 = new System.Windows.Forms.MaskedTextBox();
            this.T_0xE1 = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.T_Nick = new System.Windows.Forms.TextBox();
            this.B_DoBreak = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.T_OBreak1 = new System.Windows.Forms.TextBox();
            this.B_OBreak1 = new System.Windows.Forms.Button();
            this.B_OBreak2 = new System.Windows.Forms.Button();
            this.T_OBreak2 = new System.Windows.Forms.TextBox();
            this.Tab_RipBox = new System.Windows.Forms.TabPage();
            this.C_Format = new System.Windows.Forms.ComboBox();
            this.CHK_ALT = new System.Windows.Forms.CheckBox();
            this.Label_Box = new System.Windows.Forms.Label();
            this.CB_Box = new System.Windows.Forms.ComboBox();
            this.B_DumpBoxKey = new System.Windows.Forms.Button();
            this.T_Blank = new System.Windows.Forms.TextBox();
            this.B_OpenBlank = new System.Windows.Forms.Button();
            this.B_ChangeOutputFolder = new System.Windows.Forms.Button();
            this.T_OutPath = new System.Windows.Forms.TextBox();
            this.T_BoxSAV = new System.Windows.Forms.TextBox();
            this.B_OpenBoxSave = new System.Windows.Forms.Button();
            this.B_DumpBoxEKXs = new System.Windows.Forms.Button();
            this.B_OpenBoxKey = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.T_BoxKey = new System.Windows.Forms.TextBox();
            this.T_BoxOffset = new System.Windows.Forms.TextBox();
            this.Tab_RipEKX = new System.Windows.Forms.TabPage();
            this.B_FixEKX = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.T_FixKey = new System.Windows.Forms.TextBox();
            this.B_FixKey = new System.Windows.Forms.Button();
            this.Tab_Foreign2Key = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.B_FindOffset = new System.Windows.Forms.Button();
            this.B_About = new System.Windows.Forms.Button();
            this.T_Dialog = new System.Windows.Forms.RichTextBox();
            this.TC.SuspendLayout();
            this.Tab_BreakBox.SuspendLayout();
            this.Tab_RipBox.SuspendLayout();
            this.Tab_RipEKX.SuspendLayout();
            this.Tab_Foreign2Key.SuspendLayout();
            this.SuspendLayout();
            // 
            // B_OpenKey
            // 
            this.B_OpenKey.Location = new System.Drawing.Point(18, 35);
            this.B_OpenKey.Name = "B_OpenKey";
            this.B_OpenKey.Size = new System.Drawing.Size(75, 23);
            this.B_OpenKey.TabIndex = 3;
            this.B_OpenKey.Text = "Open Key";
            this.B_OpenKey.UseVisualStyleBackColor = true;
            this.B_OpenKey.Click += new System.EventHandler(this.B_OpenKey_Click);
            // 
            // T_key
            // 
            this.T_key.Location = new System.Drawing.Point(99, 37);
            this.T_key.Name = "T_key";
            this.T_key.ReadOnly = true;
            this.T_key.Size = new System.Drawing.Size(179, 20);
            this.T_key.TabIndex = 4;
            this.T_key.TextChanged += new System.EventHandler(this.toggle_getekx);
            // 
            // T_KeyOffset
            // 
            this.T_KeyOffset.Location = new System.Drawing.Point(99, 112);
            this.T_KeyOffset.Name = "T_KeyOffset";
            this.T_KeyOffset.Size = new System.Drawing.Size(73, 20);
            this.T_KeyOffset.TabIndex = 5;
            this.T_KeyOffset.TextChanged += new System.EventHandler(this.toggle_getekx);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Stream Offset:";
            // 
            // B_DumpEKX
            // 
            this.B_DumpEKX.Location = new System.Drawing.Point(188, 84);
            this.B_DumpEKX.Name = "B_DumpEKX";
            this.B_DumpEKX.Size = new System.Drawing.Size(90, 23);
            this.B_DumpEKX.TabIndex = 6;
            this.B_DumpEKX.Text = "Dump EKX";
            this.B_DumpEKX.UseVisualStyleBackColor = true;
            this.B_DumpEKX.Click += new System.EventHandler(this.B_DumpEKX_Click);
            // 
            // B_DumpKey
            // 
            this.B_DumpKey.Location = new System.Drawing.Point(188, 110);
            this.B_DumpKey.Name = "B_DumpKey";
            this.B_DumpKey.Size = new System.Drawing.Size(90, 23);
            this.B_DumpKey.TabIndex = 10;
            this.B_DumpKey.Text = "Dump Key";
            this.B_DumpKey.UseVisualStyleBackColor = true;
            this.B_DumpKey.Click += new System.EventHandler(this.B_DumpKey_Click);
            // 
            // T_ekx
            // 
            this.T_ekx.Location = new System.Drawing.Point(99, 61);
            this.T_ekx.Name = "T_ekx";
            this.T_ekx.ReadOnly = true;
            this.T_ekx.Size = new System.Drawing.Size(179, 20);
            this.T_ekx.TabIndex = 8;
            this.T_ekx.TextChanged += new System.EventHandler(this.toggle_getkey);
            // 
            // B_OpenEKX
            // 
            this.B_OpenEKX.Location = new System.Drawing.Point(18, 59);
            this.B_OpenEKX.Name = "B_OpenEKX";
            this.B_OpenEKX.Size = new System.Drawing.Size(75, 23);
            this.B_OpenEKX.TabIndex = 7;
            this.B_OpenEKX.Text = "Open EKX";
            this.B_OpenEKX.UseVisualStyleBackColor = true;
            this.B_OpenEKX.Click += new System.EventHandler(this.B_OpenEKX_Click);
            // 
            // T_S1
            // 
            this.T_S1.Location = new System.Drawing.Point(99, 13);
            this.T_S1.Name = "T_S1";
            this.T_S1.ReadOnly = true;
            this.T_S1.Size = new System.Drawing.Size(179, 20);
            this.T_S1.TabIndex = 12;
            this.T_S1.TextChanged += new System.EventHandler(this.toggle_key2);
            // 
            // B_S1
            // 
            this.B_S1.Location = new System.Drawing.Point(18, 11);
            this.B_S1.Name = "B_S1";
            this.B_S1.Size = new System.Drawing.Size(75, 23);
            this.B_S1.TabIndex = 11;
            this.B_S1.Text = "Open SAV 1";
            this.B_S1.UseVisualStyleBackColor = true;
            this.B_S1.Click += new System.EventHandler(this.B_S1_Click);
            // 
            // B_S2
            // 
            this.B_S2.Location = new System.Drawing.Point(18, 59);
            this.B_S2.Name = "B_S2";
            this.B_S2.Size = new System.Drawing.Size(75, 23);
            this.B_S2.TabIndex = 15;
            this.B_S2.Text = "Open SAV 2";
            this.B_S2.UseVisualStyleBackColor = true;
            this.B_S2.Click += new System.EventHandler(this.B_S2_Click);
            // 
            // T_S2
            // 
            this.T_S2.Location = new System.Drawing.Point(99, 61);
            this.T_S2.Name = "T_S2";
            this.T_S2.ReadOnly = true;
            this.T_S2.Size = new System.Drawing.Size(179, 20);
            this.T_S2.TabIndex = 16;
            this.T_S2.TextChanged += new System.EventHandler(this.toggle_key2);
            // 
            // B_E1
            // 
            this.B_E1.Location = new System.Drawing.Point(18, 35);
            this.B_E1.Name = "B_E1";
            this.B_E1.Size = new System.Drawing.Size(75, 23);
            this.B_E1.TabIndex = 13;
            this.B_E1.Text = "Open EKX 1";
            this.B_E1.UseVisualStyleBackColor = true;
            this.B_E1.Click += new System.EventHandler(this.B_E1_Click);
            // 
            // B_E2
            // 
            this.B_E2.Location = new System.Drawing.Point(18, 83);
            this.B_E2.Name = "B_E2";
            this.B_E2.Size = new System.Drawing.Size(75, 23);
            this.B_E2.TabIndex = 17;
            this.B_E2.Text = "Open EKX 2";
            this.B_E2.UseVisualStyleBackColor = true;
            this.B_E2.Click += new System.EventHandler(this.B_E2_Click);
            // 
            // T_E1
            // 
            this.T_E1.Location = new System.Drawing.Point(99, 37);
            this.T_E1.Name = "T_E1";
            this.T_E1.ReadOnly = true;
            this.T_E1.Size = new System.Drawing.Size(179, 20);
            this.T_E1.TabIndex = 14;
            this.T_E1.TextChanged += new System.EventHandler(this.toggle_key2);
            // 
            // T_E2
            // 
            this.T_E2.Location = new System.Drawing.Point(99, 85);
            this.T_E2.Name = "T_E2";
            this.T_E2.ReadOnly = true;
            this.T_E2.Size = new System.Drawing.Size(179, 20);
            this.T_E2.TabIndex = 18;
            this.T_E2.TextChanged += new System.EventHandler(this.toggle_key2);
            // 
            // T_Key2Offset
            // 
            this.T_Key2Offset.Location = new System.Drawing.Point(99, 112);
            this.T_Key2Offset.Name = "T_Key2Offset";
            this.T_Key2Offset.Size = new System.Drawing.Size(73, 20);
            this.T_Key2Offset.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Stream Offset:";
            // 
            // B_GetKey2
            // 
            this.B_GetKey2.Location = new System.Drawing.Point(188, 110);
            this.B_GetKey2.Name = "B_GetKey2";
            this.B_GetKey2.Size = new System.Drawing.Size(90, 23);
            this.B_GetKey2.TabIndex = 20;
            this.B_GetKey2.Text = "Dump Key";
            this.B_GetKey2.UseVisualStyleBackColor = true;
            this.B_GetKey2.Click += new System.EventHandler(this.B_DumpKey2_Click);
            // 
            // T_Open1
            // 
            this.T_Open1.Location = new System.Drawing.Point(99, 13);
            this.T_Open1.Name = "T_Open1";
            this.T_Open1.ReadOnly = true;
            this.T_Open1.Size = new System.Drawing.Size(179, 20);
            this.T_Open1.TabIndex = 2;
            this.T_Open1.TextChanged += new System.EventHandler(this.toggle_main1);
            // 
            // B_OpenSAV
            // 
            this.B_OpenSAV.Location = new System.Drawing.Point(18, 11);
            this.B_OpenSAV.Name = "B_OpenSAV";
            this.B_OpenSAV.Size = new System.Drawing.Size(75, 23);
            this.B_OpenSAV.TabIndex = 1;
            this.B_OpenSAV.Text = "Open SAV";
            this.B_OpenSAV.UseVisualStyleBackColor = true;
            this.B_OpenSAV.Click += new System.EventHandler(this.B_OpenSave_Click);
            // 
            // TC
            // 
            this.TC.Controls.Add(this.Tab_BreakBox);
            this.TC.Controls.Add(this.Tab_RipBox);
            this.TC.Controls.Add(this.Tab_RipEKX);
            this.TC.Controls.Add(this.Tab_Foreign2Key);
            this.TC.Location = new System.Drawing.Point(7, 8);
            this.TC.Name = "TC";
            this.TC.SelectedIndex = 0;
            this.TC.Size = new System.Drawing.Size(304, 192);
            this.TC.TabIndex = 0;
            // 
            // Tab_BreakBox
            // 
            this.Tab_BreakBox.Controls.Add(this.B_DumpBlank);
            this.Tab_BreakBox.Controls.Add(this.B_DumpBreakBox2);
            this.Tab_BreakBox.Controls.Add(this.B_DumpBreakBox1);
            this.Tab_BreakBox.Controls.Add(this.label11);
            this.Tab_BreakBox.Controls.Add(this.label10);
            this.Tab_BreakBox.Controls.Add(this.label9);
            this.Tab_BreakBox.Controls.Add(this.label8);
            this.Tab_BreakBox.Controls.Add(this.T_0xE0);
            this.Tab_BreakBox.Controls.Add(this.T_0xE3);
            this.Tab_BreakBox.Controls.Add(this.T_0xE2);
            this.Tab_BreakBox.Controls.Add(this.T_0xE1);
            this.Tab_BreakBox.Controls.Add(this.label7);
            this.Tab_BreakBox.Controls.Add(this.T_Nick);
            this.Tab_BreakBox.Controls.Add(this.B_DoBreak);
            this.Tab_BreakBox.Controls.Add(this.label6);
            this.Tab_BreakBox.Controls.Add(this.label5);
            this.Tab_BreakBox.Controls.Add(this.T_OBreak1);
            this.Tab_BreakBox.Controls.Add(this.B_OBreak1);
            this.Tab_BreakBox.Controls.Add(this.B_OBreak2);
            this.Tab_BreakBox.Controls.Add(this.T_OBreak2);
            this.Tab_BreakBox.Location = new System.Drawing.Point(4, 22);
            this.Tab_BreakBox.Name = "Tab_BreakBox";
            this.Tab_BreakBox.Size = new System.Drawing.Size(296, 166);
            this.Tab_BreakBox.TabIndex = 3;
            this.Tab_BreakBox.Text = "Box Breaker";
            this.Tab_BreakBox.UseVisualStyleBackColor = true;
            // 
            // B_DumpBlank
            // 
            this.B_DumpBlank.Enabled = false;
            this.B_DumpBlank.Location = new System.Drawing.Point(233, 110);
            this.B_DumpBlank.Name = "B_DumpBlank";
            this.B_DumpBlank.Size = new System.Drawing.Size(49, 23);
            this.B_DumpBlank.TabIndex = 36;
            this.B_DumpBlank.Text = "Blank";
            this.B_DumpBlank.UseVisualStyleBackColor = true;
            this.B_DumpBlank.Click += new System.EventHandler(this.B_DumpBlank_Click);
            // 
            // B_DumpBreakBox2
            // 
            this.B_DumpBreakBox2.Enabled = false;
            this.B_DumpBreakBox2.Location = new System.Drawing.Point(193, 110);
            this.B_DumpBreakBox2.Name = "B_DumpBreakBox2";
            this.B_DumpBreakBox2.Size = new System.Drawing.Size(34, 23);
            this.B_DumpBreakBox2.TabIndex = 35;
            this.B_DumpBreakBox2.Text = "K2";
            this.B_DumpBreakBox2.UseVisualStyleBackColor = true;
            this.B_DumpBreakBox2.Click += new System.EventHandler(this.B_DumpBreakBox2_Click);
            // 
            // B_DumpBreakBox1
            // 
            this.B_DumpBreakBox1.Enabled = false;
            this.B_DumpBreakBox1.Location = new System.Drawing.Point(153, 110);
            this.B_DumpBreakBox1.Name = "B_DumpBreakBox1";
            this.B_DumpBreakBox1.Size = new System.Drawing.Size(34, 23);
            this.B_DumpBreakBox1.TabIndex = 34;
            this.B_DumpBreakBox1.Text = "K1";
            this.B_DumpBreakBox1.UseVisualStyleBackColor = true;
            this.B_DumpBreakBox1.Click += new System.EventHandler(this.B_DumpBreakBox1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(224, 142);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 33;
            this.label11.Text = "0xE3";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(156, 142);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 32;
            this.label10.Text = "0xE2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(87, 142);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "0xE1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "0xE0";
            // 
            // T_0xE0
            // 
            this.T_0xE0.Location = new System.Drawing.Point(53, 138);
            this.T_0xE0.Mask = "00";
            this.T_0xE0.Name = "T_0xE0";
            this.T_0xE0.ReadOnly = true;
            this.T_0xE0.Size = new System.Drawing.Size(21, 20);
            this.T_0xE0.TabIndex = 29;
            this.T_0xE0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // T_0xE3
            // 
            this.T_0xE3.Location = new System.Drawing.Point(257, 138);
            this.T_0xE3.Mask = "00";
            this.T_0xE3.Name = "T_0xE3";
            this.T_0xE3.ReadOnly = true;
            this.T_0xE3.Size = new System.Drawing.Size(21, 20);
            this.T_0xE3.TabIndex = 28;
            this.T_0xE3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // T_0xE2
            // 
            this.T_0xE2.Location = new System.Drawing.Point(189, 138);
            this.T_0xE2.Mask = "00";
            this.T_0xE2.Name = "T_0xE2";
            this.T_0xE2.ReadOnly = true;
            this.T_0xE2.Size = new System.Drawing.Size(21, 20);
            this.T_0xE2.TabIndex = 27;
            this.T_0xE2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // T_0xE1
            // 
            this.T_0xE1.Location = new System.Drawing.Point(121, 138);
            this.T_0xE1.Mask = "00";
            this.T_0xE1.Name = "T_0xE1";
            this.T_0xE1.ReadOnly = true;
            this.T_0xE1.Size = new System.Drawing.Size(21, 20);
            this.T_0xE1.TabIndex = 26;
            this.T_0xE1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(68, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Nick:";
            // 
            // T_Nick
            // 
            this.T_Nick.Location = new System.Drawing.Point(106, 112);
            this.T_Nick.Name = "T_Nick";
            this.T_Nick.Size = new System.Drawing.Size(41, 20);
            this.T_Nick.TabIndex = 24;
            this.T_Nick.Text = "Egg";
            // 
            // B_DoBreak
            // 
            this.B_DoBreak.Enabled = false;
            this.B_DoBreak.Location = new System.Drawing.Point(18, 110);
            this.B_DoBreak.Name = "B_DoBreak";
            this.B_DoBreak.Size = new System.Drawing.Size(44, 23);
            this.B_DoBreak.TabIndex = 23;
            this.B_DoBreak.Text = "Break";
            this.B_DoBreak.UseVisualStyleBackColor = true;
            this.B_DoBreak.Click += new System.EventHandler(this.B_DoBreak_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(240, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Save 2: Box2 Empty, Box1 same first6 rest empty.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(212, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Save 1: Box1 Empty, Box2 first6 rest empty.";
            // 
            // T_OBreak1
            // 
            this.T_OBreak1.Location = new System.Drawing.Point(99, 13);
            this.T_OBreak1.Name = "T_OBreak1";
            this.T_OBreak1.ReadOnly = true;
            this.T_OBreak1.Size = new System.Drawing.Size(179, 20);
            this.T_OBreak1.TabIndex = 18;
            this.T_OBreak1.TextChanged += new System.EventHandler(this.togglebreak);
            // 
            // B_OBreak1
            // 
            this.B_OBreak1.Location = new System.Drawing.Point(18, 11);
            this.B_OBreak1.Name = "B_OBreak1";
            this.B_OBreak1.Size = new System.Drawing.Size(75, 23);
            this.B_OBreak1.TabIndex = 17;
            this.B_OBreak1.Text = "Open SAV 1";
            this.B_OBreak1.UseVisualStyleBackColor = true;
            this.B_OBreak1.Click += new System.EventHandler(this.B_OBreak1_Click);
            // 
            // B_OBreak2
            // 
            this.B_OBreak2.Location = new System.Drawing.Point(18, 59);
            this.B_OBreak2.Name = "B_OBreak2";
            this.B_OBreak2.Size = new System.Drawing.Size(75, 23);
            this.B_OBreak2.TabIndex = 19;
            this.B_OBreak2.Text = "Open SAV 2";
            this.B_OBreak2.UseVisualStyleBackColor = true;
            this.B_OBreak2.Click += new System.EventHandler(this.B_OBreak2_Click);
            // 
            // T_OBreak2
            // 
            this.T_OBreak2.Location = new System.Drawing.Point(99, 61);
            this.T_OBreak2.Name = "T_OBreak2";
            this.T_OBreak2.ReadOnly = true;
            this.T_OBreak2.Size = new System.Drawing.Size(179, 20);
            this.T_OBreak2.TabIndex = 20;
            this.T_OBreak2.TextChanged += new System.EventHandler(this.togglebreak);
            // 
            // Tab_RipBox
            // 
            this.Tab_RipBox.Controls.Add(this.C_Format);
            this.Tab_RipBox.Controls.Add(this.CHK_ALT);
            this.Tab_RipBox.Controls.Add(this.Label_Box);
            this.Tab_RipBox.Controls.Add(this.CB_Box);
            this.Tab_RipBox.Controls.Add(this.B_DumpBoxKey);
            this.Tab_RipBox.Controls.Add(this.T_Blank);
            this.Tab_RipBox.Controls.Add(this.B_OpenBlank);
            this.Tab_RipBox.Controls.Add(this.B_ChangeOutputFolder);
            this.Tab_RipBox.Controls.Add(this.T_OutPath);
            this.Tab_RipBox.Controls.Add(this.T_BoxSAV);
            this.Tab_RipBox.Controls.Add(this.B_OpenBoxSave);
            this.Tab_RipBox.Controls.Add(this.B_DumpBoxEKXs);
            this.Tab_RipBox.Controls.Add(this.B_OpenBoxKey);
            this.Tab_RipBox.Controls.Add(this.label3);
            this.Tab_RipBox.Controls.Add(this.T_BoxKey);
            this.Tab_RipBox.Controls.Add(this.T_BoxOffset);
            this.Tab_RipBox.Location = new System.Drawing.Point(4, 22);
            this.Tab_RipBox.Name = "Tab_RipBox";
            this.Tab_RipBox.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_RipBox.Size = new System.Drawing.Size(296, 166);
            this.Tab_RipBox.TabIndex = 2;
            this.Tab_RipBox.Text = "Box Ripping";
            this.Tab_RipBox.UseVisualStyleBackColor = true;
            // 
            // C_Format
            // 
            this.C_Format.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.C_Format.FormattingEnabled = true;
            this.C_Format.Items.AddRange(new object[] {
            "Default",
            "Reddit",
            "TSV"});
            this.C_Format.Location = new System.Drawing.Point(210, 137);
            this.C_Format.Name = "C_Format";
            this.C_Format.Size = new System.Drawing.Size(68, 21);
            this.C_Format.TabIndex = 35;
            // 
            // CHK_ALT
            // 
            this.CHK_ALT.AutoSize = true;
            this.CHK_ALT.Location = new System.Drawing.Point(21, 89);
            this.CHK_ALT.Name = "CHK_ALT";
            this.CHK_ALT.Size = new System.Drawing.Size(46, 17);
            this.CHK_ALT.TabIndex = 34;
            this.CHK_ALT.Text = "ALT";
            this.CHK_ALT.UseVisualStyleBackColor = true;
            this.CHK_ALT.CheckedChanged += new System.EventHandler(this.CHK_ALT_CheckedChanged);
            // 
            // Label_Box
            // 
            this.Label_Box.AutoSize = true;
            this.Label_Box.Location = new System.Drawing.Point(65, 90);
            this.Label_Box.Name = "Label_Box";
            this.Label_Box.Size = new System.Drawing.Size(28, 13);
            this.Label_Box.TabIndex = 33;
            this.Label_Box.Text = "Box:";
            // 
            // CB_Box
            // 
            this.CB_Box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Box.FormattingEnabled = true;
            this.CB_Box.Items.AddRange(new object[] {
            "1",
            "2"});
            this.CB_Box.Location = new System.Drawing.Point(99, 86);
            this.CB_Box.Name = "CB_Box";
            this.CB_Box.Size = new System.Drawing.Size(73, 21);
            this.CB_Box.TabIndex = 32;
            this.CB_Box.SelectedIndexChanged += new System.EventHandler(this.changebox);
            // 
            // B_DumpBoxKey
            // 
            this.B_DumpBoxKey.Location = new System.Drawing.Point(188, 110);
            this.B_DumpBoxKey.Name = "B_DumpBoxKey";
            this.B_DumpBoxKey.Size = new System.Drawing.Size(90, 23);
            this.B_DumpBoxKey.TabIndex = 28;
            this.B_DumpBoxKey.Text = "Dump Key";
            this.B_DumpBoxKey.UseVisualStyleBackColor = true;
            this.B_DumpBoxKey.Click += new System.EventHandler(this.B_DumpBoxKey_Click);
            // 
            // T_Blank
            // 
            this.T_Blank.Location = new System.Drawing.Point(99, 61);
            this.T_Blank.Name = "T_Blank";
            this.T_Blank.ReadOnly = true;
            this.T_Blank.Size = new System.Drawing.Size(179, 20);
            this.T_Blank.TabIndex = 26;
            this.T_Blank.TextChanged += new System.EventHandler(this.togglebox);
            // 
            // B_OpenBlank
            // 
            this.B_OpenBlank.Location = new System.Drawing.Point(18, 59);
            this.B_OpenBlank.Name = "B_OpenBlank";
            this.B_OpenBlank.Size = new System.Drawing.Size(75, 23);
            this.B_OpenBlank.TabIndex = 25;
            this.B_OpenBlank.Text = "Open Blank";
            this.B_OpenBlank.UseVisualStyleBackColor = true;
            this.B_OpenBlank.Click += new System.EventHandler(this.B_OpenBlank_Click);
            // 
            // B_ChangeOutputFolder
            // 
            this.B_ChangeOutputFolder.Location = new System.Drawing.Point(18, 136);
            this.B_ChangeOutputFolder.Name = "B_ChangeOutputFolder";
            this.B_ChangeOutputFolder.Size = new System.Drawing.Size(75, 23);
            this.B_ChangeOutputFolder.TabIndex = 30;
            this.B_ChangeOutputFolder.Text = "Output To:";
            this.B_ChangeOutputFolder.UseVisualStyleBackColor = true;
            this.B_ChangeOutputFolder.Click += new System.EventHandler(this.B_ChangeOutputFolder_Click);
            // 
            // T_OutPath
            // 
            this.T_OutPath.Location = new System.Drawing.Point(99, 138);
            this.T_OutPath.Name = "T_OutPath";
            this.T_OutPath.ReadOnly = true;
            this.T_OutPath.Size = new System.Drawing.Size(105, 20);
            this.T_OutPath.TabIndex = 31;
            // 
            // T_BoxSAV
            // 
            this.T_BoxSAV.Location = new System.Drawing.Point(99, 13);
            this.T_BoxSAV.Name = "T_BoxSAV";
            this.T_BoxSAV.ReadOnly = true;
            this.T_BoxSAV.Size = new System.Drawing.Size(179, 20);
            this.T_BoxSAV.TabIndex = 22;
            this.T_BoxSAV.TextChanged += new System.EventHandler(this.togglebox);
            // 
            // B_OpenBoxSave
            // 
            this.B_OpenBoxSave.Location = new System.Drawing.Point(18, 11);
            this.B_OpenBoxSave.Name = "B_OpenBoxSave";
            this.B_OpenBoxSave.Size = new System.Drawing.Size(75, 23);
            this.B_OpenBoxSave.TabIndex = 21;
            this.B_OpenBoxSave.Text = "Open SAV";
            this.B_OpenBoxSave.UseVisualStyleBackColor = true;
            this.B_OpenBoxSave.Click += new System.EventHandler(this.B_OpenBoxSave_Click);
            // 
            // B_DumpBoxEKXs
            // 
            this.B_DumpBoxEKXs.Location = new System.Drawing.Point(188, 84);
            this.B_DumpBoxEKXs.Name = "B_DumpBoxEKXs";
            this.B_DumpBoxEKXs.Size = new System.Drawing.Size(90, 23);
            this.B_DumpBoxEKXs.TabIndex = 29;
            this.B_DumpBoxEKXs.Text = "Dump Box";
            this.B_DumpBoxEKXs.UseVisualStyleBackColor = true;
            this.B_DumpBoxEKXs.Click += new System.EventHandler(this.B_DumpBoxEKXs_Click);
            // 
            // B_OpenBoxKey
            // 
            this.B_OpenBoxKey.Location = new System.Drawing.Point(18, 35);
            this.B_OpenBoxKey.Name = "B_OpenBoxKey";
            this.B_OpenBoxKey.Size = new System.Drawing.Size(75, 23);
            this.B_OpenBoxKey.TabIndex = 23;
            this.B_OpenBoxKey.Text = "Open Key";
            this.B_OpenBoxKey.UseVisualStyleBackColor = true;
            this.B_OpenBoxKey.Click += new System.EventHandler(this.B_OpenBoxKey_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Stream Offset:";
            // 
            // T_BoxKey
            // 
            this.T_BoxKey.Location = new System.Drawing.Point(99, 37);
            this.T_BoxKey.Name = "T_BoxKey";
            this.T_BoxKey.ReadOnly = true;
            this.T_BoxKey.Size = new System.Drawing.Size(179, 20);
            this.T_BoxKey.TabIndex = 24;
            this.T_BoxKey.TextChanged += new System.EventHandler(this.togglebox);
            // 
            // T_BoxOffset
            // 
            this.T_BoxOffset.Location = new System.Drawing.Point(99, 112);
            this.T_BoxOffset.Name = "T_BoxOffset";
            this.T_BoxOffset.Size = new System.Drawing.Size(73, 20);
            this.T_BoxOffset.TabIndex = 27;
            this.T_BoxOffset.TextChanged += new System.EventHandler(this.togglebox);
            // 
            // Tab_RipEKX
            // 
            this.Tab_RipEKX.Controls.Add(this.B_FixEKX);
            this.Tab_RipEKX.Controls.Add(this.label12);
            this.Tab_RipEKX.Controls.Add(this.T_FixKey);
            this.Tab_RipEKX.Controls.Add(this.B_FixKey);
            this.Tab_RipEKX.Controls.Add(this.T_Open1);
            this.Tab_RipEKX.Controls.Add(this.B_OpenSAV);
            this.Tab_RipEKX.Controls.Add(this.B_DumpEKX);
            this.Tab_RipEKX.Controls.Add(this.B_DumpKey);
            this.Tab_RipEKX.Controls.Add(this.B_OpenKey);
            this.Tab_RipEKX.Controls.Add(this.label1);
            this.Tab_RipEKX.Controls.Add(this.B_OpenEKX);
            this.Tab_RipEKX.Controls.Add(this.T_ekx);
            this.Tab_RipEKX.Controls.Add(this.T_key);
            this.Tab_RipEKX.Controls.Add(this.T_KeyOffset);
            this.Tab_RipEKX.Location = new System.Drawing.Point(4, 22);
            this.Tab_RipEKX.Name = "Tab_RipEKX";
            this.Tab_RipEKX.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_RipEKX.Size = new System.Drawing.Size(296, 166);
            this.Tab_RipEKX.TabIndex = 0;
            this.Tab_RipEKX.Text = "Native EKX";
            this.Tab_RipEKX.UseVisualStyleBackColor = true;
            // 
            // B_FixEKX
            // 
            this.B_FixEKX.Enabled = false;
            this.B_FixEKX.Location = new System.Drawing.Point(234, 136);
            this.B_FixEKX.Name = "B_FixEKX";
            this.B_FixEKX.Size = new System.Drawing.Size(44, 23);
            this.B_FixEKX.TabIndex = 17;
            this.B_FixEKX.Text = "FEKX";
            this.B_FixEKX.UseVisualStyleBackColor = true;
            this.B_FixEKX.Click += new System.EventHandler(this.B_FixEKX_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(33, 141);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "EKX Index:";
            // 
            // T_FixKey
            // 
            this.T_FixKey.Enabled = false;
            this.T_FixKey.Location = new System.Drawing.Point(99, 138);
            this.T_FixKey.Name = "T_FixKey";
            this.T_FixKey.Size = new System.Drawing.Size(73, 20);
            this.T_FixKey.TabIndex = 15;
            this.T_FixKey.TextChanged += new System.EventHandler(this.toggle_fixkey);
            // 
            // B_FixKey
            // 
            this.B_FixKey.Enabled = false;
            this.B_FixKey.Location = new System.Drawing.Point(188, 136);
            this.B_FixKey.Name = "B_FixKey";
            this.B_FixKey.Size = new System.Drawing.Size(40, 23);
            this.B_FixKey.TabIndex = 14;
            this.B_FixKey.Text = "FKey";
            this.B_FixKey.UseVisualStyleBackColor = true;
            this.B_FixKey.Click += new System.EventHandler(this.B_FixKey_Click);
            // 
            // Tab_Foreign2Key
            // 
            this.Tab_Foreign2Key.Controls.Add(this.label4);
            this.Tab_Foreign2Key.Controls.Add(this.B_FindOffset);
            this.Tab_Foreign2Key.Controls.Add(this.B_GetKey2);
            this.Tab_Foreign2Key.Controls.Add(this.T_Key2Offset);
            this.Tab_Foreign2Key.Controls.Add(this.B_E2);
            this.Tab_Foreign2Key.Controls.Add(this.label2);
            this.Tab_Foreign2Key.Controls.Add(this.T_S1);
            this.Tab_Foreign2Key.Controls.Add(this.T_E2);
            this.Tab_Foreign2Key.Controls.Add(this.B_S1);
            this.Tab_Foreign2Key.Controls.Add(this.T_E1);
            this.Tab_Foreign2Key.Controls.Add(this.B_S2);
            this.Tab_Foreign2Key.Controls.Add(this.T_S2);
            this.Tab_Foreign2Key.Controls.Add(this.B_E1);
            this.Tab_Foreign2Key.Location = new System.Drawing.Point(4, 22);
            this.Tab_Foreign2Key.Name = "Tab_Foreign2Key";
            this.Tab_Foreign2Key.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_Foreign2Key.Size = new System.Drawing.Size(296, 166);
            this.Tab_Foreign2Key.TabIndex = 1;
            this.Tab_Foreign2Key.Text = "Foreign EKX";
            this.Tab_Foreign2Key.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Offset Finder:";
            // 
            // B_FindOffset
            // 
            this.B_FindOffset.Location = new System.Drawing.Point(141, 136);
            this.B_FindOffset.Name = "B_FindOffset";
            this.B_FindOffset.Size = new System.Drawing.Size(137, 23);
            this.B_FindOffset.TabIndex = 31;
            this.B_FindOffset.Text = "Get Altered EKX Offsets";
            this.B_FindOffset.UseVisualStyleBackColor = true;
            this.B_FindOffset.Click += new System.EventHandler(this.B_FindOffset_Click);
            // 
            // B_About
            // 
            this.B_About.Location = new System.Drawing.Point(291, 8);
            this.B_About.Name = "B_About";
            this.B_About.Size = new System.Drawing.Size(19, 20);
            this.B_About.TabIndex = 36;
            this.B_About.Text = "?";
            this.B_About.UseVisualStyleBackColor = true;
            this.B_About.Click += new System.EventHandler(this.B_About_Click);
            // 
            // T_Dialog
            // 
            this.T_Dialog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.T_Dialog.Location = new System.Drawing.Point(7, 205);
            this.T_Dialog.Name = "T_Dialog";
            this.T_Dialog.ReadOnly = true;
            this.T_Dialog.Size = new System.Drawing.Size(304, 159);
            this.T_Dialog.TabIndex = 37;
            this.T_Dialog.Text = "";
            this.T_Dialog.WordWrap = false;
            // 
            // KeySAV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 370);
            this.Controls.Add(this.T_Dialog);
            this.Controls.Add(this.B_About);
            this.Controls.Add(this.TC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "KeySAV";
            this.Text = "KeySAV";
            this.TC.ResumeLayout(false);
            this.Tab_BreakBox.ResumeLayout(false);
            this.Tab_BreakBox.PerformLayout();
            this.Tab_RipBox.ResumeLayout(false);
            this.Tab_RipBox.PerformLayout();
            this.Tab_RipEKX.ResumeLayout(false);
            this.Tab_RipEKX.PerformLayout();
            this.Tab_Foreign2Key.ResumeLayout(false);
            this.Tab_Foreign2Key.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button B_OpenKey;
        private System.Windows.Forms.TextBox T_key;
        private System.Windows.Forms.TextBox T_KeyOffset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button B_DumpEKX;
        private System.Windows.Forms.Button B_DumpKey;
        private System.Windows.Forms.TextBox T_ekx;
        private System.Windows.Forms.Button B_OpenEKX;
        private System.Windows.Forms.TextBox T_Open1;
        private System.Windows.Forms.Button B_OpenSAV;
        private System.Windows.Forms.Button B_GetKey2;
        private System.Windows.Forms.TextBox T_Key2Offset;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox T_E2;
        private System.Windows.Forms.TextBox T_E1;
        private System.Windows.Forms.Button B_E2;
        private System.Windows.Forms.Button B_E1;
        private System.Windows.Forms.TextBox T_S2;
        private System.Windows.Forms.Button B_S2;
        private System.Windows.Forms.Button B_S1;
        private System.Windows.Forms.TextBox T_S1;
        private System.Windows.Forms.TabControl TC;
        private System.Windows.Forms.TabPage Tab_RipEKX;
        private System.Windows.Forms.TabPage Tab_Foreign2Key;
        private System.Windows.Forms.TabPage Tab_RipBox;
        private System.Windows.Forms.Button B_DumpBoxKey;
        private System.Windows.Forms.TextBox T_Blank;
        private System.Windows.Forms.Button B_OpenBlank;
        private System.Windows.Forms.Button B_ChangeOutputFolder;
        private System.Windows.Forms.TextBox T_OutPath;
        private System.Windows.Forms.TextBox T_BoxSAV;
        private System.Windows.Forms.Button B_OpenBoxSave;
        private System.Windows.Forms.Button B_DumpBoxEKXs;
        private System.Windows.Forms.Button B_OpenBoxKey;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox T_BoxKey;
        private System.Windows.Forms.TextBox T_BoxOffset;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button B_FindOffset;
        private System.Windows.Forms.TabPage Tab_BreakBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox T_OBreak1;
        private System.Windows.Forms.Button B_OBreak1;
        private System.Windows.Forms.Button B_OBreak2;
        private System.Windows.Forms.TextBox T_OBreak2;
        private System.Windows.Forms.Button B_DumpBreakBox2;
        private System.Windows.Forms.Button B_DumpBreakBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox T_0xE0;
        private System.Windows.Forms.MaskedTextBox T_0xE3;
        private System.Windows.Forms.MaskedTextBox T_0xE2;
        private System.Windows.Forms.MaskedTextBox T_0xE1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox T_Nick;
        private System.Windows.Forms.Button B_DoBreak;
        private System.Windows.Forms.Button B_About;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox T_FixKey;
        private System.Windows.Forms.Button B_FixKey;
        private System.Windows.Forms.Button B_FixEKX;
        private System.Windows.Forms.Button B_DumpBlank;
        private System.Windows.Forms.Label Label_Box;
        private System.Windows.Forms.ComboBox CB_Box;
        private System.Windows.Forms.CheckBox CHK_ALT;
        private System.Windows.Forms.RichTextBox T_Dialog;
        private System.Windows.Forms.ComboBox C_Format;
    }
}

