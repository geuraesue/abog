namespace abog
{
    partial class standardClean
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
            panel1 = new Panel();
            linkLabel1 = new LinkLabel();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            btnStandardClean = new Button();
            label1 = new Label();
            label2 = new Label();
            pictureBox3 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(linkLabel1);
            panel1.Location = new Point(44, 38);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(716, 371);
            panel1.TabIndex = 17;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.FromArgb(90, 118, 132);
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.ForeColor = Color.FromArgb(90, 118, 132);
            linkLabel1.LinkBehavior = LinkBehavior.AlwaysUnderline;
            linkLabel1.LinkColor = Color.FromArgb(90, 118, 132);
            linkLabel1.Location = new Point(22, 6);
            linkLabel1.Margin = new Padding(2, 0, 2, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(121, 15);
            linkLabel1.TabIndex = 0;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "<- Back to dashboard";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.standardPic;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(72, 67);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(232, 262);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI Variable Display", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(90, 118, 132);
            label3.Location = new Point(112, 332);
            label3.Name = "label3";
            label3.Size = new Size(140, 36);
            label3.TabIndex = 18;
            label3.Text = "PHP 1,499";
            // 
            // btnStandardClean
            // 
            btnStandardClean.BackColor = Color.FromArgb(155, 167, 123);
            btnStandardClean.FlatStyle = FlatStyle.Flat;
            btnStandardClean.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStandardClean.ForeColor = Color.White;
            btnStandardClean.Location = new Point(146, 366);
            btnStandardClean.Margin = new Padding(2);
            btnStandardClean.Name = "btnStandardClean";
            btnStandardClean.Size = new Size(78, 20);
            btnStandardClean.TabIndex = 19;
            btnStandardClean.Text = "Book";
            btnStandardClean.UseVisualStyleBackColor = false;
            btnStandardClean.Click += btnStandardClean_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI Variable Small", 20.25F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(90, 118, 132);
            label1.Location = new Point(391, 56);
            label1.Name = "label1";
            label1.Size = new Size(255, 36);
            label1.TabIndex = 20;
            label1.Text = "STANDARD CLEAN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI Emoji", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(148, 163, 124);
            label2.Location = new Point(358, 89);
            label2.Name = "label2";
            label2.Size = new Size(342, 17);
            label2.TabIndex = 21;
            label2.Text = "Full home cleaning for houses and bigger spaces";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.White;
            pictureBox3.BackgroundImage = Properties.Resources.standardWew;
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(340, 116);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(376, 254);
            pictureBox3.TabIndex = 22;
            pictureBox3.TabStop = false;
            // 
            // standardClean
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.d9c3a45d_0958_4e44_bf30_c2b2dffd7ab4;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnStandardClean);
            Controls.Add(label3);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Name = "standardClean";
            ShowIcon = false;
            Text = "Standard Clean";
            Load += Form3_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private LinkLabel linkLabel1;
        private PictureBox pictureBox2;
        private Label label3;
        private Button btnStandardClean;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox3;
    }
}