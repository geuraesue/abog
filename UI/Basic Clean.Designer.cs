namespace abog
{
    partial class basicClean
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
            label4 = new Label();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            btnBasClean = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(linkBack);
            panel1.Location = new Point(43, 35);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(716, 371);
            panel1.TabIndex = 15;
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
            pictureBox1.BackgroundImage = Properties.Resources.basicPic1;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(66, 66);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(232, 262);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI Variable Small", 20.25F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(90, 118, 132);
            label4.Location = new Point(434, 59);
            label4.Name = "label4";
            label4.Size = new Size(186, 36);
            label4.TabIndex = 17;
            label4.Text = "BASIC CLEAN";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI Emoji", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(148, 163, 124);
            label1.Location = new Point(365, 92);
            label1.Name = "label1";
            label1.Size = new Size(335, 17);
            label1.TabIndex = 18;
            label1.Text = "Perfect for small spaces and everyday freshness";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.BackgroundImage = Properties.Resources.wew;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(338, 116);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(388, 254);
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI Variable Display", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(90, 118, 132);
            label2.Location = new Point(112, 331);
            label2.Name = "label2";
            label2.Size = new Size(121, 36);
            label2.TabIndex = 20;
            label2.Text = "PHP 699";
            // 
            // btnBasClean
            // 
            btnBasClean.BackColor = Color.FromArgb(155, 167, 123);
            btnBasClean.FlatStyle = FlatStyle.Flat;
            btnBasClean.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBasClean.ForeColor = Color.White;
            btnBasClean.Location = new Point(138, 365);
            btnBasClean.Margin = new Padding(2);
            btnBasClean.Name = "btnBasClean";
            btnBasClean.Size = new Size(78, 20);
            btnBasClean.TabIndex = 21;
            btnBasClean.Text = "Book";
            btnBasClean.UseVisualStyleBackColor = false;
            btnBasClean.Click += btnBasClean_Click;
            // 
            // basicClean
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.d9c3a45d_0958_4e44_bf30_c2b2dffd7ab4;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBasClean);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Name = "basicClean";
            Text = "Basic Clean";
            Load += basicClean_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private LinkLabel linkBack;
        private PictureBox pictureBox1;
        private Label label4;
        private Label label1;
        private PictureBox pictureBox2;
        private Label label2;
        private Button btnBasClean;
    }
}