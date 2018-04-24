namespace Character_Randomizer
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
            this.lblrandSpecies = new System.Windows.Forms.Label();
            this.bnRandGender = new System.Windows.Forms.Button();
            this.bn_RandAge = new System.Windows.Forms.Button();
            this.bn_randSpecies = new System.Windows.Forms.Button();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bn_RandForm = new System.Windows.Forms.Button();
            this.lblForm = new System.Windows.Forms.Label();
            this.tboxSpecies = new System.Windows.Forms.TextBox();
            this.tboxAge = new System.Windows.Forms.TextBox();
            this.tboxForm = new System.Windows.Forms.TextBox();
            this.tboxGender = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.bnEffect = new System.Windows.Forms.Button();
            this.tboxEffect = new System.Windows.Forms.TextBox();
            this.lblEffect = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblrandSpecies
            // 
            this.lblrandSpecies.AutoSize = true;
            this.lblrandSpecies.Location = new System.Drawing.Point(173, 28);
            this.lblrandSpecies.Name = "lblrandSpecies";
            this.lblrandSpecies.Size = new System.Drawing.Size(62, 17);
            this.lblrandSpecies.TabIndex = 3;
            this.lblrandSpecies.Text = "Species ";
            // 
            // bnRandGender
            // 
            this.bnRandGender.Location = new System.Drawing.Point(12, 161);
            this.bnRandGender.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bnRandGender.Name = "bnRandGender";
            this.bnRandGender.Size = new System.Drawing.Size(133, 55);
            this.bnRandGender.TabIndex = 4;
            this.bnRandGender.Text = "Randomize Gender";
            this.bnRandGender.UseVisualStyleBackColor = true;
            this.bnRandGender.Click += new System.EventHandler(this.bnRandGender_Click);
            // 
            // bn_RandAge
            // 
            this.bn_RandAge.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bn_RandAge.Location = new System.Drawing.Point(12, 103);
            this.bn_RandAge.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bn_RandAge.Name = "bn_RandAge";
            this.bn_RandAge.Size = new System.Drawing.Size(131, 50);
            this.bn_RandAge.TabIndex = 5;
            this.bn_RandAge.Text = "Randomize Age";
            this.bn_RandAge.UseVisualStyleBackColor = true;
            this.bn_RandAge.Click += new System.EventHandler(this.bn_RandAge_Click);
            // 
            // bn_randSpecies
            // 
            this.bn_randSpecies.Location = new System.Drawing.Point(12, 28);
            this.bn_randSpecies.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bn_randSpecies.Name = "bn_randSpecies";
            this.bn_randSpecies.Size = new System.Drawing.Size(131, 67);
            this.bn_randSpecies.TabIndex = 6;
            this.bn_randSpecies.Text = "Randomize Species ";
            this.bn_randSpecies.UseVisualStyleBackColor = true;
            this.bn_randSpecies.Click += new System.EventHandler(this.button4_Click);
            this.bn_randSpecies.Enter += new System.EventHandler(this.button4_Click);
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(172, 83);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(33, 17);
            this.lblAge.TabIndex = 7;
            this.lblAge.Text = "Age";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(173, 156);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(56, 17);
            this.lblGender.TabIndex = 8;
            this.lblGender.Text = "Gender";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(614, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem1});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.CheckOnClick = true;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // bn_RandForm
            // 
            this.bn_RandForm.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bn_RandForm.Location = new System.Drawing.Point(14, 224);
            this.bn_RandForm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bn_RandForm.Name = "bn_RandForm";
            this.bn_RandForm.Size = new System.Drawing.Size(131, 53);
            this.bn_RandForm.TabIndex = 17;
            this.bn_RandForm.Text = "Randomize Form";
            this.bn_RandForm.UseVisualStyleBackColor = true;
            this.bn_RandForm.Click += new System.EventHandler(this.bn_RandForm_Click);
            // 
            // lblForm
            // 
            this.lblForm.AutoSize = true;
            this.lblForm.Location = new System.Drawing.Point(173, 218);
            this.lblForm.Name = "lblForm";
            this.lblForm.Size = new System.Drawing.Size(40, 17);
            this.lblForm.TabIndex = 19;
            this.lblForm.Text = "Form";
            // 
            // tboxSpecies
            // 
            this.tboxSpecies.BackColor = System.Drawing.Color.AliceBlue;
            this.tboxSpecies.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tboxSpecies.Cursor = System.Windows.Forms.Cursors.Default;
            this.tboxSpecies.Location = new System.Drawing.Point(175, 48);
            this.tboxSpecies.Name = "tboxSpecies";
            this.tboxSpecies.ReadOnly = true;
            this.tboxSpecies.Size = new System.Drawing.Size(294, 23);
            this.tboxSpecies.TabIndex = 20;
            // 
            // tboxAge
            // 
            this.tboxAge.BackColor = System.Drawing.Color.AliceBlue;
            this.tboxAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tboxAge.Cursor = System.Windows.Forms.Cursors.Default;
            this.tboxAge.Location = new System.Drawing.Point(175, 107);
            this.tboxAge.Name = "tboxAge";
            this.tboxAge.ReadOnly = true;
            this.tboxAge.Size = new System.Drawing.Size(294, 23);
            this.tboxAge.TabIndex = 21;
            // 
            // tboxForm
            // 
            this.tboxForm.BackColor = System.Drawing.Color.AliceBlue;
            this.tboxForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tboxForm.Cursor = System.Windows.Forms.Cursors.Default;
            this.tboxForm.Location = new System.Drawing.Point(175, 238);
            this.tboxForm.Name = "tboxForm";
            this.tboxForm.ReadOnly = true;
            this.tboxForm.Size = new System.Drawing.Size(294, 23);
            this.tboxForm.TabIndex = 22;
            // 
            // tboxGender
            // 
            this.tboxGender.BackColor = System.Drawing.Color.AliceBlue;
            this.tboxGender.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tboxGender.Cursor = System.Windows.Forms.Cursors.Default;
            this.tboxGender.Location = new System.Drawing.Point(175, 176);
            this.tboxGender.Name = "tboxGender";
            this.tboxGender.ReadOnly = true;
            this.tboxGender.Size = new System.Drawing.Size(294, 23);
            this.tboxGender.TabIndex = 23;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(376, 399);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 44);
            this.button1.TabIndex = 24;
            this.button1.Text = "Go!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(14, 418);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(189, 21);
            this.checkBox1.TabIndex = 25;
            this.checkBox1.Text = "Enable \"Effects\" Catagory";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // bnEffect
            // 
            this.bnEffect.Location = new System.Drawing.Point(14, 298);
            this.bnEffect.Name = "bnEffect";
            this.bnEffect.Size = new System.Drawing.Size(133, 57);
            this.bnEffect.TabIndex = 26;
            this.bnEffect.Text = "Randomize Effect";
            this.bnEffect.UseVisualStyleBackColor = true;
            this.bnEffect.Visible = false;
            this.bnEffect.Click += new System.EventHandler(this.bnEffect_Click);
            // 
            // tboxEffect
            // 
            this.tboxEffect.BackColor = System.Drawing.Color.AliceBlue;
            this.tboxEffect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tboxEffect.Cursor = System.Windows.Forms.Cursors.Default;
            this.tboxEffect.Location = new System.Drawing.Point(175, 322);
            this.tboxEffect.Name = "tboxEffect";
            this.tboxEffect.ReadOnly = true;
            this.tboxEffect.Size = new System.Drawing.Size(294, 23);
            this.tboxEffect.TabIndex = 28;
            this.tboxEffect.Visible = false;
            // 
            // lblEffect
            // 
            this.lblEffect.AutoSize = true;
            this.lblEffect.Location = new System.Drawing.Point(173, 298);
            this.lblEffect.Name = "lblEffect";
            this.lblEffect.Size = new System.Drawing.Size(44, 17);
            this.lblEffect.TabIndex = 27;
            this.lblEffect.Text = "Effect";
            this.lblEffect.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(614, 474);
            this.Controls.Add(this.tboxEffect);
            this.Controls.Add(this.lblEffect);
            this.Controls.Add(this.bnEffect);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tboxGender);
            this.Controls.Add(this.tboxForm);
            this.Controls.Add(this.tboxAge);
            this.Controls.Add(this.tboxSpecies);
            this.Controls.Add(this.lblForm);
            this.Controls.Add(this.bn_RandForm);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.bn_randSpecies);
            this.Controls.Add(this.bn_RandAge);
            this.Controls.Add(this.bnRandGender);
            this.Controls.Add(this.lblrandSpecies);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Character Randomizer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblrandSpecies;
        private System.Windows.Forms.Button bnRandGender;
        private System.Windows.Forms.Button bn_RandAge;
        private System.Windows.Forms.Button bn_randSpecies;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button bn_RandForm;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.Label lblForm;
        public System.Windows.Forms.TextBox tboxSpecies;
        public System.Windows.Forms.TextBox tboxAge;
        public System.Windows.Forms.TextBox tboxForm;
        public System.Windows.Forms.TextBox tboxGender;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button bnEffect;
        public System.Windows.Forms.TextBox tboxEffect;
        private System.Windows.Forms.Label lblEffect;
    }
}

