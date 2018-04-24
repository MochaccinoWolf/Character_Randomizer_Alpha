namespace Character_Randomizer
{
    partial class aboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(aboutForm));
            this.rtb_About = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtb_About
            // 
            this.rtb_About.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_About.Location = new System.Drawing.Point(12, 12);
            this.rtb_About.Name = "rtb_About";
            this.rtb_About.ReadOnly = true;
            this.rtb_About.Size = new System.Drawing.Size(279, 189);
            this.rtb_About.TabIndex = 0;
            this.rtb_About.Text = resources.GetString("rtb_About.Text");
            this.rtb_About.TextChanged += new System.EventHandler(this.rtb_About_TextChanged);
            // 
            // aboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(304, 259);
            this.Controls.Add(this.rtb_About);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "aboutForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About ";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb_About;
    }
}