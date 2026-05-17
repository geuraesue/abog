namespace abog
{
    partial class autoDetail
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
            label4 = new Label();
            panel1 = new Panel();
            linkBack = new LinkLabel();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            btnAutoBook = new Button();
            label1 = new Label();
            label2 = new Label();
            pictureBox3 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(76, 66);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 14;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(linkBack);
            panel1.Location = new Point(43, 41);
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
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.autoPic;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(70, 66);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(232, 262);
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI Variable Display", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(90, 118, 132);
            label3.Location = new Point(119, 331);
            label3.Name = "label3";
            label3.Size = new Size(121, 36);
            label3.TabIndex = 18;
            label3.Text = "PHP 499";
            // 
            // btnAutoBook
            // 
            btnAutoBook.BackColor = Color.FromArgb(155, 167, 123);
            btnAutoBook.FlatStyle = FlatStyle.Flat;
            btnAutoBook.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAutoBook.ForeColor = Color.White;
            btnAutoBook.Location = new Point(149, 365);
            btnAutoBook.Margin = new Padding(2);
            btnAutoBook.Name = "btnAutoBook";
            btnAutoBook.Size = new Size(78, 20);
            btnAutoBook.TabIndex = 19;
            btnAutoBook.Text = "Book";
            btnAutoBook.UseVisualStyleBackColor = false;
            btnAutoBook.Click += btnAutoBook_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI Variable Small", 20.25F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(90, 118, 132);
            label1.Location = new Point(412, 52);
            label1.Name = "label1";
            label1.Size = new Size(187, 36);
            label1.TabIndex = 20;
            label1.Text = "AUTO DETAIL";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI Emoji", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(148, 163, 124);
            label2.Location = new Point(353, 84);
            label2.Name = "label2";
            label2.Size = new Size(324, 17);
            label2.TabIndex = 21;
            label2.Text = "Professional car cleaning and detailing service";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.White;
            pictureBox3.BackgroundImage = Properties.Resources.autoWew;
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(333, 109);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(370, 263);
            pictureBox3.TabIndex = 22;
            pictureBox3.TabStop = false;
            // 
            // autoDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.d9c3a45d_0958_4e44_bf30_c2b2dffd7ab4;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAutoBook);
            Controls.Add(label3);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Controls.Add(label4);
            Name = "autoDetail";
            Text = "Auto Detail";
            Load += Form5_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label4;
        private Panel panel1;
        private LinkLabel linkBack;
        private PictureBox pictureBox2;
        private Label label3;
        private Button btnAutoBook;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox3;
    }
}