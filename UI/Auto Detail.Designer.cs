namespace abog
{
    partial class AutoDetail
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
            pictureBox3 = new PictureBox();
            btnAutoBook = new Button();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.white;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(40, 47);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1063, 658);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI Variable Small", 20.25F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(90, 118, 132);
            label1.Location = new Point(599, 110);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(282, 54);
            label1.TabIndex = 5;
            label1.Text = "AUTO DETAIL";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI Emoji", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(148, 163, 124);
            label2.Location = new Point(504, 170);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(457, 27);
            label2.TabIndex = 8;
            label2.Text = "Professional car cleaning and detailing service";
            label2.Click += label2_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.autoPic;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(93, 110);
            pictureBox2.Margin = new Padding(4, 5, 4, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(331, 437);
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI Variable Display", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(90, 118, 132);
            label3.Location = new Point(170, 552);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(186, 54);
            label3.TabIndex = 10;
            label3.Text = "PHP 499";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.White;
            pictureBox3.BackgroundImage = Properties.Resources.autoWew;
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(476, 203);
            pictureBox3.Margin = new Padding(4, 5, 4, 5);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(529, 438);
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            // 
            // btnAutoBook
            // 
            btnAutoBook.BackColor = Color.FromArgb(155, 167, 123);
            btnAutoBook.FlatStyle = FlatStyle.Flat;
            btnAutoBook.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAutoBook.ForeColor = Color.White;
            btnAutoBook.Location = new Point(204, 609);
            btnAutoBook.Name = "btnAutoBook";
            btnAutoBook.Size = new Size(112, 34);
            btnAutoBook.TabIndex = 13;
            btnAutoBook.Text = "Book";
            btnAutoBook.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(109, 110);
            label4.Name = "label4";
            label4.Size = new Size(0, 25);
            label4.TabIndex = 14;
            // 
            // AutoDetail
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.d9c3a45d_0958_4e44_bf30_c2b2dffd7ab4;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1143, 750);
            Controls.Add(label4);
            Controls.Add(btnAutoBook);
            Controls.Add(pictureBox3);
            Controls.Add(label3);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "AutoDetail";
            Text = "Auto Detail";
            Load += Form5_Load;
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
        private PictureBox pictureBox3;
        private Button btnAutoBook;
        private Label label4;
    }
}