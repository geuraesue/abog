namespace abog
{
    partial class Form4
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            basicButton = new Button();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.white;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(28, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(744, 395);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI Variable Small", 20.25F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(90, 118, 132);
            label1.Location = new Point(429, 65);
            label1.Name = "label1";
            label1.Size = new Size(176, 36);
            label1.TabIndex = 4;
            label1.Text = "DEEP CLEAN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI Emoji", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(148, 163, 124);
            label2.Location = new Point(330, 101);
            label2.Name = "label2";
            label2.Size = new Size(378, 17);
            label2.TabIndex = 7;
            label2.Text = "Heavy-duty cleaning for large & post-renovation spaces";
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.deepClean;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(67, 69);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(232, 262);
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI Variable Display", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(90, 118, 132);
            label3.Location = new Point(117, 334);
            label3.Name = "label3";
            label3.Size = new Size(133, 36);
            label3.TabIndex = 9;
            label3.Text = "PHP 3199";
            // 
            // basicButton
            // 
            basicButton.BackColor = Color.Transparent;
            basicButton.BackgroundImage = Properties.Resources.bookbutton1;
            basicButton.BackgroundImageLayout = ImageLayout.Stretch;
            basicButton.FlatAppearance.BorderColor = Color.CadetBlue;
            basicButton.FlatStyle = FlatStyle.Flat;
            basicButton.ForeColor = Color.Transparent;
            basicButton.Location = new Point(141, 367);
            basicButton.Name = "basicButton";
            basicButton.Size = new Size(79, 23);
            basicButton.TabIndex = 10;
            basicButton.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.White;
            pictureBox3.BackgroundImage = Properties.Resources.deepWew;
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(330, 121);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(388, 254);
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.d9c3a45d_0958_4e44_bf30_c2b2dffd7ab4;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox3);
            Controls.Add(basicButton);
            Controls.Add(label3);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form4";
            Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox2;
        private Label label3;
        private Button basicButton;
        private PictureBox pictureBox3;
    }
}