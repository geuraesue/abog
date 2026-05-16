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
            pictureBox1 = new PictureBox();
            label4 = new Label();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            btnBasClean = new Button();
            linkBack = new LinkLabel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(linkBack);
            panel1.Location = new Point(61, 59);
            panel1.Name = "panel1";
            panel1.Size = new Size(1023, 619);
            panel1.TabIndex = 15;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.basicPic1;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(94, 110);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(331, 437);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI Variable Small", 20.25F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(90, 118, 132);
            label4.Location = new Point(620, 99);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(282, 54);
            label4.TabIndex = 17;
            label4.Text = "BASIC CLEAN";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI Emoji", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(148, 163, 124);
            label1.Location = new Point(521, 153);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(467, 27);
            label1.TabIndex = 18;
            label1.Text = "Perfect for small spaces and everyday freshness";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.BackgroundImage = Properties.Resources.wew;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(483, 194);
            pictureBox2.Margin = new Padding(4, 5, 4, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(554, 423);
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI Variable Display", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(90, 118, 132);
            label2.Location = new Point(160, 552);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(186, 54);
            label2.TabIndex = 20;
            label2.Text = "PHP 699";
            // 
            // btnBasClean
            // 
            btnBasClean.BackColor = Color.FromArgb(155, 167, 123);
            btnBasClean.FlatStyle = FlatStyle.Flat;
            btnBasClean.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBasClean.ForeColor = Color.White;
            btnBasClean.Location = new Point(197, 609);
            btnBasClean.Name = "btnBasClean";
            btnBasClean.Size = new Size(112, 34);
            btnBasClean.TabIndex = 21;
            btnBasClean.Text = "Book";
            btnBasClean.UseVisualStyleBackColor = false;
            // 
            // linkBack
            // 
            linkBack.ActiveLinkColor = Color.FromArgb(90, 118, 132);
            linkBack.AutoSize = true;
            linkBack.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkBack.ForeColor = Color.FromArgb(90, 118, 132);
            linkBack.LinkBehavior = LinkBehavior.AlwaysUnderline;
            linkBack.LinkColor = Color.FromArgb(90, 118, 132);
            linkBack.Location = new Point(31, 10);
            linkBack.Name = "linkBack";
            linkBack.Size = new Size(185, 25);
            linkBack.TabIndex = 0;
            linkBack.TabStop = true;
            linkBack.Text = "<- Back to dashboard";
            // 
            // basicClean
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.d9c3a45d_0958_4e44_bf30_c2b2dffd7ab4;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1143, 750);
            Controls.Add(btnBasClean);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Margin = new Padding(4, 5, 4, 5);
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