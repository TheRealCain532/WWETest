namespace WWETest
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openSaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.strengthValue = new System.Windows.Forms.NumericUpDown();
            this.submissionValue = new System.Windows.Forms.NumericUpDown();
            this.speedValue = new System.Windows.Forms.NumericUpDown();
            this.techValue = new System.Windows.Forms.NumericUpDown();
            this.durValue = new System.Windows.Forms.NumericUpDown();
            this.charValue = new System.Windows.Forms.NumericUpDown();
            this.stamValue = new System.Windows.Forms.NumericUpDown();
            this.hardValue = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.fileLoaded = new System.Windows.Forms.ToolStripStatusLabel();
            this.fileLoad = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.strengthValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.submissionValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.durValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.charValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stamValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hardValue)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(404, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openSaveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openSaveToolStripMenuItem
            // 
            this.openSaveToolStripMenuItem.Name = "openSaveToolStripMenuItem";
            this.openSaveToolStripMenuItem.Size = new System.Drawing.Size(200, 34);
            this.openSaveToolStripMenuItem.Text = "Open Save";
            this.openSaveToolStripMenuItem.Click += new System.EventHandler(this.openSaveToolStripMenuItem_Click);
            // 
            // strengthValue
            // 
            this.strengthValue.Enabled = false;
            this.strengthValue.Location = new System.Drawing.Point(86, 93);
            this.strengthValue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.strengthValue.Name = "strengthValue";
            this.strengthValue.Size = new System.Drawing.Size(120, 26);
            this.strengthValue.TabIndex = 1;
            this.strengthValue.ValueChanged += new System.EventHandler(this.StatChange);
            // 
            // submissionValue
            // 
            this.submissionValue.Enabled = false;
            this.submissionValue.Location = new System.Drawing.Point(86, 132);
            this.submissionValue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.submissionValue.Name = "submissionValue";
            this.submissionValue.Size = new System.Drawing.Size(120, 26);
            this.submissionValue.TabIndex = 2;
            this.submissionValue.ValueChanged += new System.EventHandler(this.StatChange);
            // 
            // speedValue
            // 
            this.speedValue.Enabled = false;
            this.speedValue.Location = new System.Drawing.Point(86, 171);
            this.speedValue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.speedValue.Name = "speedValue";
            this.speedValue.Size = new System.Drawing.Size(120, 26);
            this.speedValue.TabIndex = 3;
            this.speedValue.ValueChanged += new System.EventHandler(this.StatChange);
            // 
            // techValue
            // 
            this.techValue.Enabled = false;
            this.techValue.Location = new System.Drawing.Point(86, 211);
            this.techValue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.techValue.Name = "techValue";
            this.techValue.Size = new System.Drawing.Size(120, 26);
            this.techValue.TabIndex = 4;
            this.techValue.ValueChanged += new System.EventHandler(this.StatChange);
            // 
            // durValue
            // 
            this.durValue.Enabled = false;
            this.durValue.Location = new System.Drawing.Point(86, 253);
            this.durValue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.durValue.Name = "durValue";
            this.durValue.Size = new System.Drawing.Size(120, 26);
            this.durValue.TabIndex = 5;
            this.durValue.ValueChanged += new System.EventHandler(this.StatChange);
            // 
            // charValue
            // 
            this.charValue.Enabled = false;
            this.charValue.Location = new System.Drawing.Point(86, 293);
            this.charValue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.charValue.Name = "charValue";
            this.charValue.Size = new System.Drawing.Size(120, 26);
            this.charValue.TabIndex = 6;
            this.charValue.ValueChanged += new System.EventHandler(this.StatChange);
            // 
            // stamValue
            // 
            this.stamValue.Enabled = false;
            this.stamValue.Location = new System.Drawing.Point(86, 331);
            this.stamValue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.stamValue.Name = "stamValue";
            this.stamValue.Size = new System.Drawing.Size(120, 26);
            this.stamValue.TabIndex = 7;
            this.stamValue.ValueChanged += new System.EventHandler(this.StatChange);
            // 
            // hardValue
            // 
            this.hardValue.Enabled = false;
            this.hardValue.Location = new System.Drawing.Point(86, 369);
            this.hardValue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.hardValue.Name = "hardValue";
            this.hardValue.Size = new System.Drawing.Size(120, 26);
            this.hardValue.TabIndex = 8;
            this.hardValue.ValueChanged += new System.EventHandler(this.StatChange);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 300);
            this.label1.TabIndex = 9;
            this.label1.Text = "Strenght\r\n\r\nSubmission\r\n\r\nSpeed\r\n\r\nTechnique\r\n\r\nDurability\r\n\r\nCharisma\r\n\r\nStamina" +
    "\r\n\r\nHardcore";
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "The Rock",
            "Stone Cold",
            "Triple H",
            "Undertaker",
            "Chris Jericho",
            "Motion Test 01",
            "Motion Test 02",
            "Kane",
            "Edge",
            "Jeff Hardy",
            "Matt Hardy",
            "JBL",
            "Mr. McMahon",
            "William Regal",
            "Carlito",
            "Rey Mysterio",
            "Big Show",
            "Motion Test 03",
            "Maria",
            "CM Punk",
            "MVP",
            "Million Dollar Man",
            "Chavo Guerrero",
            "John Cena",
            "Mickie James",
            "Shawn Michaels",
            "Michael Cole",
            "Shane McMahon",
            "Jerry Lawler",
            "Tazz",
            "Umaga",
            "Finlay",
            "Batista",
            "Randy Orton",
            "Mr. Kennedy",
            "Kelly Kelly",
            "JTG",
            "The Great Khali",
            "Tommy Dreamer",
            "Jim Ross",
            "Melina",
            "John Morrison",
            "Kofi Kingston",
            "Shad",
            "Mark Henry",
            "Michelle McCool",
            "Justin Roberts",
            "Tony Chimmel",
            "Lilian Garcia",
            "Green",
            "Red",
            "Moves Man 02",
            "Hornswoggle",
            "Santino Marella",
            "Cody Rhodes",
            "The Brian Kendrick",
            "Shelton Benjamin",
            "Dusty Rhodes",
            "Jesse",
            "Festus",
            "The Miz",
            "Beth Phoenix",
            "Matt Striker",
            "Doctor",
            "Howard Finkel ",
            "Referee",
            "SUPERSTAR",
            "DIVA",
            "Vickie Guerrero",
            "Ted DiBiase",
            "Vladimir Kozlov",
            "Mike Knox",
            "Evan Bourne",
            "Jack Swagger",
            "Ezekiel Jackson",
            "Primo",
            "R-Truth",
            "Dolph Ziggler",
            "Christian",
            "Goldust"});
            this.comboBox1.Location = new System.Drawing.Point(12, 36);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(380, 28);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileLoaded,
            this.fileLoad});
            this.statusStrip1.Location = new System.Drawing.Point(0, 430);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(404, 32);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // fileLoaded
            // 
            this.fileLoaded.Name = "fileLoaded";
            this.fileLoaded.Size = new System.Drawing.Size(0, 25);
            // 
            // fileLoad
            // 
            this.fileLoad.Name = "fileLoad";
            this.fileLoad.Size = new System.Drawing.Size(131, 25);
            this.fileLoad.Text = "No File Loaded";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 462);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hardValue);
            this.Controls.Add(this.stamValue);
            this.Controls.Add(this.charValue);
            this.Controls.Add(this.durValue);
            this.Controls.Add(this.techValue);
            this.Controls.Add(this.speedValue);
            this.Controls.Add(this.submissionValue);
            this.Controls.Add(this.strengthValue);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "WWETest ~ Cain532";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.strengthValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.submissionValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.durValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.charValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stamValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hardValue)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openSaveToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown strengthValue;
        private System.Windows.Forms.NumericUpDown submissionValue;
        private System.Windows.Forms.NumericUpDown speedValue;
        private System.Windows.Forms.NumericUpDown techValue;
        private System.Windows.Forms.NumericUpDown durValue;
        private System.Windows.Forms.NumericUpDown charValue;
        private System.Windows.Forms.NumericUpDown stamValue;
        private System.Windows.Forms.NumericUpDown hardValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel fileLoaded;
        private System.Windows.Forms.ToolStripStatusLabel fileLoad;
    }
}

