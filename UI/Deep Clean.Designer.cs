namespace abog
{
    partial class deepClean
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
            linkBack = new LinkLabel();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            btnDeepClean = new Button();
            label1 = new Label();
            label2 = new Label();
            pictureBox3 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(linkBack);
            panel1.Location = new Point(43, 38);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(716, 371);
            panel1.TabIndex = 16;
            // 
            // linkBack
            // 
            linkBack.ActiveLinkColor = Color.FromArgb(90, 118, 132);
            linkBack.AutoSize = true;
            linkBack.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkBack.ForeColor = Color.FromArgb(90, 118, 132);
            linkBack.LinkBehavior = LinkBehavior.AlwaysUnderline;
            linkBack.LinkColor = Color.FromArgb(90, 118, 132);
            linkBack.Location = new Point(22, 6);
            linkBack.Margin = new Padding(2, 0, 2, 0);
            linkBack.Name = "linkBack";
            linkBack.Size = new Size(121, 15);
            linkBack.TabIndex = 0;
            linkBack.TabStop = true;
            linkBack.Text = "<- Back to dashboard";
            linkBack.LinkClicked += linkBack_LinkClicked;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.deepClean;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(74, 69);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(232, 262);
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI Variable Display", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(90, 118, 132);
            label3.Location = new Point(113, 334);
            label3.Name = "label3";
            label3.Size = new Size(140, 36);
            label3.TabIndex = 18;
            label3.Text = "PHP 3,199";
            // 
            // btnDeepClean
            // 
            btnDeepClean.BackColor = Color.FromArgb(155, 167, 123);
            btnDeepClean.FlatStyle = FlatStyle.Flat;
            btnDeepClean.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeepClean.ForeColor = Color.White;
            btnDeepClean.Location = new Point(152, 368);
            btnDeepClean.Margin = new Padding(2);
            btnDeepClean.Name = "btnDeepClean";
            btnDeepClean.Size = new Size(78, 20);
            btnDeepClean.TabIndex = 19;
            btnDeepClean.Text = "Book";
            btnDeepClean.UseVisualStyleBackColor = false;
            btnDeepClean.Click += btnDeepClean_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI Variable Small", 20.25F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(90, 118, 132);
            label1.Location = new Point(435, 53);
            label1.Name = "label1";
            label1.Size = new Size(176, 36);
            label1.TabIndex = 20;
            label1.Text = "DEEP CLEAN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI Emoji", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(148, 163, 124);
            label2.Location = new Point(337, 85);
            label2.Name = "label2";
            label2.Size = new Size(403, 17);
            label2.TabIndex = 21;
            label2.Text = "Heavy-duty cleaning for large and post-renovation spaces";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.White;
            pictureBox3.BackgroundImage = Properties.Resources.deepWew;
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(344, 112);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(388, 254);
            pictureBox3.TabIndex = 22;
            pictureBox3.TabStop = false;
            // 
            // deepClean
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.d9c3a45d_0958_4e44_bf30_c2b2dffd7ab4;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnDeepClean);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Name = "deepClean";
            Text = "Deep Clean";
            Load += Form4_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private PictureBox pictureBox2;
        private LinkLabel linkBack;
        private PictureBox pictureBox1;
        private Label label3;
        private Button btnDeepClean;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox3;
    }
}