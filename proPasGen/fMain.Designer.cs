namespace PasGen {
    partial class fMain {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing ) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            this.gbSettingsGeneral = new System.Windows.Forms.GroupBox();
            this.udSpecialUpper = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.udSpecialLower = new System.Windows.Forms.NumericUpDown();
            this.tbSpecialChars = new System.Windows.Forms.TextBox();
            this.cbSpecialChar = new System.Windows.Forms.CheckBox();
            this.cbDubiousSymbol = new System.Windows.Forms.CheckBox();
            this.udSymbolUpper = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.udSymbolLower = new System.Windows.Forms.NumericUpDown();
            this.udNumericUpper = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.udNumericLower = new System.Windows.Forms.NumericUpDown();
            this.udLowerUpper = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.udLowerLower = new System.Windows.Forms.NumericUpDown();
            this.udCapitalUpper = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.udCapitalLower = new System.Windows.Forms.NumericUpDown();
            this.cbSymbol = new System.Windows.Forms.CheckBox();
            this.lblPasswordQuantity = new System.Windows.Forms.Label();
            this.udPasswordQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblPasswordLentgh = new System.Windows.Forms.Label();
            this.udPasswordLength = new System.Windows.Forms.NumericUpDown();
            this.cbNumber = new System.Windows.Forms.CheckBox();
            this.cbLetterLower = new System.Windows.Forms.CheckBox();
            this.cbLetterCapital = new System.Windows.Forms.CheckBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lvPasswords = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.passwordsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClear = new System.Windows.Forms.Button();
            this.ilPassword = new System.Windows.Forms.ImageList(this.components);
            this.btnCopy = new System.Windows.Forms.Button();
            this.ttMain = new System.Windows.Forms.ToolTip(this.components);
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turkishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblMessage = new System.Windows.Forms.Label();
            this.gbSettingsGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udSpecialUpper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udSpecialLower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udSymbolUpper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udSymbolLower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udNumericUpper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udNumericLower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udLowerUpper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udLowerLower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udCapitalUpper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udCapitalLower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udPasswordQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udPasswordLength)).BeginInit();
            this.passwordsMenu.SuspendLayout();
            this.msMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSettingsGeneral
            // 
            this.gbSettingsGeneral.Controls.Add(this.udSpecialUpper);
            this.gbSettingsGeneral.Controls.Add(this.label5);
            this.gbSettingsGeneral.Controls.Add(this.udSpecialLower);
            this.gbSettingsGeneral.Controls.Add(this.tbSpecialChars);
            this.gbSettingsGeneral.Controls.Add(this.cbSpecialChar);
            this.gbSettingsGeneral.Controls.Add(this.cbDubiousSymbol);
            this.gbSettingsGeneral.Controls.Add(this.udSymbolUpper);
            this.gbSettingsGeneral.Controls.Add(this.label4);
            this.gbSettingsGeneral.Controls.Add(this.udSymbolLower);
            this.gbSettingsGeneral.Controls.Add(this.udNumericUpper);
            this.gbSettingsGeneral.Controls.Add(this.label3);
            this.gbSettingsGeneral.Controls.Add(this.udNumericLower);
            this.gbSettingsGeneral.Controls.Add(this.udLowerUpper);
            this.gbSettingsGeneral.Controls.Add(this.label2);
            this.gbSettingsGeneral.Controls.Add(this.udLowerLower);
            this.gbSettingsGeneral.Controls.Add(this.udCapitalUpper);
            this.gbSettingsGeneral.Controls.Add(this.label1);
            this.gbSettingsGeneral.Controls.Add(this.udCapitalLower);
            this.gbSettingsGeneral.Controls.Add(this.cbSymbol);
            this.gbSettingsGeneral.Controls.Add(this.lblPasswordQuantity);
            this.gbSettingsGeneral.Controls.Add(this.udPasswordQuantity);
            this.gbSettingsGeneral.Controls.Add(this.lblPasswordLentgh);
            this.gbSettingsGeneral.Controls.Add(this.udPasswordLength);
            this.gbSettingsGeneral.Controls.Add(this.cbNumber);
            this.gbSettingsGeneral.Controls.Add(this.cbLetterLower);
            this.gbSettingsGeneral.Controls.Add(this.cbLetterCapital);
            resources.ApplyResources(this.gbSettingsGeneral, "gbSettingsGeneral");
            this.gbSettingsGeneral.Name = "gbSettingsGeneral";
            this.gbSettingsGeneral.TabStop = false;
            // 
            // udSpecialUpper
            // 
            resources.ApplyResources(this.udSpecialUpper, "udSpecialUpper");
            this.udSpecialUpper.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.udSpecialUpper.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udSpecialUpper.Name = "udSpecialUpper";
            this.udSpecialUpper.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udSpecialUpper.ValueChanged += new System.EventHandler(this.udUpDown_ValueChanged);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // udSpecialLower
            // 
            resources.ApplyResources(this.udSpecialLower, "udSpecialLower");
            this.udSpecialLower.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.udSpecialLower.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udSpecialLower.Name = "udSpecialLower";
            this.udSpecialLower.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udSpecialLower.ValueChanged += new System.EventHandler(this.udUpDown_ValueChanged);
            // 
            // tbSpecialChars
            // 
            resources.ApplyResources(this.tbSpecialChars, "tbSpecialChars");
            this.tbSpecialChars.Name = "tbSpecialChars";
            this.tbSpecialChars.TextChanged += new System.EventHandler(this.tbSpecialChars_TextChanged);
            // 
            // cbSpecialChar
            // 
            resources.ApplyResources(this.cbSpecialChar, "cbSpecialChar");
            this.cbSpecialChar.Name = "cbSpecialChar";
            this.cbSpecialChar.UseVisualStyleBackColor = true;
            this.cbSpecialChar.CheckedChanged += new System.EventHandler(this.cb_CheckedChanged);
            // 
            // cbDubiousSymbol
            // 
            resources.ApplyResources(this.cbDubiousSymbol, "cbDubiousSymbol");
            this.cbDubiousSymbol.Name = "cbDubiousSymbol";
            this.ttMain.SetToolTip(this.cbDubiousSymbol, resources.GetString("cbDubiousSymbol.ToolTip"));
            this.cbDubiousSymbol.UseVisualStyleBackColor = true;
            // 
            // udSymbolUpper
            // 
            resources.ApplyResources(this.udSymbolUpper, "udSymbolUpper");
            this.udSymbolUpper.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.udSymbolUpper.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udSymbolUpper.Name = "udSymbolUpper";
            this.udSymbolUpper.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udSymbolUpper.ValueChanged += new System.EventHandler(this.udUpDown_ValueChanged);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // udSymbolLower
            // 
            resources.ApplyResources(this.udSymbolLower, "udSymbolLower");
            this.udSymbolLower.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.udSymbolLower.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udSymbolLower.Name = "udSymbolLower";
            this.udSymbolLower.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udSymbolLower.ValueChanged += new System.EventHandler(this.udUpDown_ValueChanged);
            // 
            // udNumericUpper
            // 
            resources.ApplyResources(this.udNumericUpper, "udNumericUpper");
            this.udNumericUpper.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.udNumericUpper.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udNumericUpper.Name = "udNumericUpper";
            this.udNumericUpper.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udNumericUpper.ValueChanged += new System.EventHandler(this.udUpDown_ValueChanged);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // udNumericLower
            // 
            resources.ApplyResources(this.udNumericLower, "udNumericLower");
            this.udNumericLower.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.udNumericLower.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udNumericLower.Name = "udNumericLower";
            this.udNumericLower.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udNumericLower.ValueChanged += new System.EventHandler(this.udUpDown_ValueChanged);
            // 
            // udLowerUpper
            // 
            resources.ApplyResources(this.udLowerUpper, "udLowerUpper");
            this.udLowerUpper.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.udLowerUpper.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udLowerUpper.Name = "udLowerUpper";
            this.udLowerUpper.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udLowerUpper.ValueChanged += new System.EventHandler(this.udUpDown_ValueChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // udLowerLower
            // 
            resources.ApplyResources(this.udLowerLower, "udLowerLower");
            this.udLowerLower.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.udLowerLower.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udLowerLower.Name = "udLowerLower";
            this.udLowerLower.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udLowerLower.ValueChanged += new System.EventHandler(this.udUpDown_ValueChanged);
            // 
            // udCapitalUpper
            // 
            resources.ApplyResources(this.udCapitalUpper, "udCapitalUpper");
            this.udCapitalUpper.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.udCapitalUpper.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udCapitalUpper.Name = "udCapitalUpper";
            this.udCapitalUpper.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udCapitalUpper.ValueChanged += new System.EventHandler(this.udUpDown_ValueChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // udCapitalLower
            // 
            resources.ApplyResources(this.udCapitalLower, "udCapitalLower");
            this.udCapitalLower.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.udCapitalLower.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udCapitalLower.Name = "udCapitalLower";
            this.udCapitalLower.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udCapitalLower.ValueChanged += new System.EventHandler(this.udUpDown_ValueChanged);
            // 
            // cbSymbol
            // 
            resources.ApplyResources(this.cbSymbol, "cbSymbol");
            this.cbSymbol.Name = "cbSymbol";
            this.ttMain.SetToolTip(this.cbSymbol, resources.GetString("cbSymbol.ToolTip"));
            this.cbSymbol.UseVisualStyleBackColor = true;
            this.cbSymbol.CheckedChanged += new System.EventHandler(this.cb_CheckedChanged);
            // 
            // lblPasswordQuantity
            // 
            resources.ApplyResources(this.lblPasswordQuantity, "lblPasswordQuantity");
            this.lblPasswordQuantity.Name = "lblPasswordQuantity";
            // 
            // udPasswordQuantity
            // 
            resources.ApplyResources(this.udPasswordQuantity, "udPasswordQuantity");
            this.udPasswordQuantity.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.udPasswordQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udPasswordQuantity.Name = "udPasswordQuantity";
            this.udPasswordQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblPasswordLentgh
            // 
            resources.ApplyResources(this.lblPasswordLentgh, "lblPasswordLentgh");
            this.lblPasswordLentgh.Name = "lblPasswordLentgh";
            // 
            // udPasswordLength
            // 
            resources.ApplyResources(this.udPasswordLength, "udPasswordLength");
            this.udPasswordLength.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.udPasswordLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udPasswordLength.Name = "udPasswordLength";
            this.udPasswordLength.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udPasswordLength.ValueChanged += new System.EventHandler(this.udUpDown_ValueChanged);
            // 
            // cbNumber
            // 
            resources.ApplyResources(this.cbNumber, "cbNumber");
            this.cbNumber.Name = "cbNumber";
            this.cbNumber.UseVisualStyleBackColor = true;
            this.cbNumber.CheckedChanged += new System.EventHandler(this.cb_CheckedChanged);
            // 
            // cbLetterLower
            // 
            resources.ApplyResources(this.cbLetterLower, "cbLetterLower");
            this.cbLetterLower.Name = "cbLetterLower";
            this.cbLetterLower.UseVisualStyleBackColor = true;
            this.cbLetterLower.CheckedChanged += new System.EventHandler(this.cb_CheckedChanged);
            // 
            // cbLetterCapital
            // 
            resources.ApplyResources(this.cbLetterCapital, "cbLetterCapital");
            this.cbLetterCapital.Name = "cbLetterCapital";
            this.cbLetterCapital.UseVisualStyleBackColor = true;
            this.cbLetterCapital.CheckedChanged += new System.EventHandler(this.cb_CheckedChanged);
            // 
            // btnGenerate
            // 
            resources.ApplyResources(this.btnGenerate, "btnGenerate");
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // lvPasswords
            // 
            this.lvPasswords.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lvPasswords.ContextMenuStrip = this.passwordsMenu;
            resources.ApplyResources(this.lvPasswords, "lvPasswords");
            this.lvPasswords.MultiSelect = false;
            this.lvPasswords.Name = "lvPasswords";
            this.lvPasswords.UseCompatibleStateImageBehavior = false;
            this.lvPasswords.View = System.Windows.Forms.View.List;
            this.lvPasswords.SelectedIndexChanged += new System.EventHandler(this.lvPasswords_SelectedIndexChanged);
            this.lvPasswords.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvPasswords_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            resources.ApplyResources(this.columnHeader1, "columnHeader1");
            // 
            // passwordsMenu
            // 
            this.passwordsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCopy});
            this.passwordsMenu.Name = "passwordsMenu";
            resources.ApplyResources(this.passwordsMenu, "passwordsMenu");
            // 
            // tsmCopy
            // 
            this.tsmCopy.Name = "tsmCopy";
            resources.ApplyResources(this.tsmCopy, "tsmCopy");
            this.tsmCopy.Click += new System.EventHandler(this.tsmCopy_Click);
            // 
            // btnClear
            // 
            resources.ApplyResources(this.btnClear, "btnClear");
            this.btnClear.Name = "btnClear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // ilPassword
            // 
            this.ilPassword.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilPassword.ImageStream")));
            this.ilPassword.TransparentColor = System.Drawing.Color.Transparent;
            this.ilPassword.Images.SetKeyName(0, "password");
            // 
            // btnCopy
            // 
            resources.ApplyResources(this.btnCopy, "btnCopy");
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.tsmCopy_Click);
            // 
            // msMain
            // 
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.languageToolStripMenuItem});
            resources.ApplyResources(this.msMain, "msMain");
            this.msMain.Name = "msMain";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.turkishToolStripMenuItem,
            this.englishToolStripMenuItem});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            resources.ApplyResources(this.languageToolStripMenuItem, "languageToolStripMenuItem");
            // 
            // turkishToolStripMenuItem
            // 
            this.turkishToolStripMenuItem.CheckOnClick = true;
            this.turkishToolStripMenuItem.Name = "turkishToolStripMenuItem";
            resources.ApplyResources(this.turkishToolStripMenuItem, "turkishToolStripMenuItem");
            this.turkishToolStripMenuItem.Click += new System.EventHandler(this.turkishToolStripMenuItem_Click);
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.CheckOnClick = true;
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            resources.ApplyResources(this.englishToolStripMenuItem, "englishToolStripMenuItem");
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.turkishToolStripMenuItem_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.lblMessage, "lblMessage");
            this.lblMessage.Name = "lblMessage";
            // 
            // fMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.msMain);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lvPasswords);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.gbSettingsGeneral);
            this.Controls.Add(this.lblMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.msMain;
            this.MaximizeBox = false;
            this.Name = "fMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fMain_FormClosing);
            this.Load += new System.EventHandler(this.fMain_Load);
            this.gbSettingsGeneral.ResumeLayout(false);
            this.gbSettingsGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udSpecialUpper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udSpecialLower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udSymbolUpper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udSymbolLower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udNumericUpper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udNumericLower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udLowerUpper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udLowerLower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udCapitalUpper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udCapitalLower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udPasswordQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udPasswordLength)).EndInit();
            this.passwordsMenu.ResumeLayout(false);
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSettingsGeneral;
        private System.Windows.Forms.CheckBox cbLetterCapital;
        private System.Windows.Forms.CheckBox cbLetterLower;
        private System.Windows.Forms.CheckBox cbNumber;
        private System.Windows.Forms.Label lblPasswordLentgh;
        private System.Windows.Forms.NumericUpDown udPasswordLength;
        private System.Windows.Forms.Label lblPasswordQuantity;
        private System.Windows.Forms.NumericUpDown udPasswordQuantity;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.ListView lvPasswords;
        private System.Windows.Forms.CheckBox cbSymbol;
        private System.Windows.Forms.NumericUpDown udCapitalUpper;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown udCapitalLower;
        private System.Windows.Forms.NumericUpDown udLowerUpper;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown udLowerLower;
        private System.Windows.Forms.NumericUpDown udSymbolUpper;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown udSymbolLower;
        private System.Windows.Forms.NumericUpDown udNumericUpper;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown udNumericLower;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ContextMenuStrip passwordsMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmCopy;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ImageList ilPassword;
        private System.Windows.Forms.CheckBox cbDubiousSymbol;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.ToolTip ttMain;
        private System.Windows.Forms.CheckBox cbSpecialChar;
        private System.Windows.Forms.TextBox tbSpecialChars;
        private System.Windows.Forms.NumericUpDown udSpecialUpper;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown udSpecialLower;
        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem turkishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.Label lblMessage;
    }
}

