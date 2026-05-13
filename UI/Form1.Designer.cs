namespace abog
{
    partial class homePage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            login = new Button();
            signup = new Button();
            label1 = new Label();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            basicButton = new Button();
            standardButton = new Button();
            deepButton = new Button();
            autoButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.abog;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(41, 38);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(124, 58);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // login
            // 
            login.BackColor = Color.Transparent;
            login.BackgroundImage = Properties.Resources.login;
            login.BackgroundImageLayout = ImageLayout.Stretch;
            login.FlatAppearance.BorderColor = SystemColors.ButtonFace;
            login.FlatStyle = FlatStyle.Flat;
            login.ForeColor = Color.Transparent;
            login.Location = new Point(834, 38);
            login.Margin = new Padding(4, 5, 4, 5);
            login.Name = "login";
            login.Size = new Size(113, 38);
            login.TabIndex = 1;
            login.UseVisualStyleBackColor = false;
            login.Click += login_Click;
            // 
            // signup
            // 
            signup.BackColor = Color.Transparent;
            signup.BackgroundImage = Properties.Resources.signup;
            signup.BackgroundImageLayout = ImageLayout.Stretch;
            signup.FlatAppearance.BorderColor = SystemColors.ButtonFace;
            signup.FlatStyle = FlatStyle.Flat;
            signup.ForeColor = Color.Transparent;
            signup.Location = new Point(956, 38);
            signup.Margin = new Padding(4, 5, 4, 5);
            signup.Name = "signup";
            signup.Size = new Size(113, 38);
            signup.TabIndex = 2;
            signup.UseVisualStyleBackColor = false;
            signup.Click += signup_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Variable Small", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(90, 118, 132);
            label1.Location = new Point(430, 125);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(306, 54);
            label1.TabIndex = 3;
            label1.Text = "OUR SERVICES";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(148, 163, 124);
            label2.Location = new Point(387, 185);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(391, 32);
            label2.TabIndex = 4;
            label2.Text = "We offer exactly what you need!";
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.choice;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(56, 252);
            pictureBox2.Margin = new Padding(4, 5, 4, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1027, 412);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // basicButton
            // 
            basicButton.BackColor = Color.Transparent;
            basicButton.BackgroundImage = Properties.Resources.bookbutton1;
            basicButton.BackgroundImageLayout = ImageLayout.Stretch;
            basicButton.FlatAppearance.BorderColor = Color.CadetBlue;
            basicButton.FlatStyle = FlatStyle.Flat;
            basicButton.ForeColor = Color.Transparent;
            basicButton.Location = new Point(116, 617);
            basicButton.Margin = new Padding(4, 5, 4, 5);
            basicButton.Name = "basicButton";
            basicButton.Size = new Size(113, 38);
            basicButton.TabIndex = 6;
            basicButton.UseVisualStyleBackColor = false;
            // 
            // standardButton
            // 
            standardButton.BackColor = Color.Transparent;
            standardButton.BackgroundImage = Properties.Resources.bookbutton1;
            standardButton.BackgroundImageLayout = ImageLayout.Stretch;
            standardButton.FlatAppearance.BorderColor = Color.CadetBlue;
            standardButton.FlatStyle = FlatStyle.Flat;
            standardButton.ForeColor = Color.Transparent;
            standardButton.Location = new Point(381, 617);
            standardButton.Margin = new Padding(4, 5, 4, 5);
            standardButton.Name = "standardButton";
            standardButton.Size = new Size(113, 38);
            standardButton.TabIndex = 7;
            standardButton.UseVisualStyleBackColor = false;
            // 
            // deepButton
            // 
            deepButton.BackColor = Color.Transparent;
            deepButton.BackgroundImage = Properties.Resources.bookbutton1;
            deepButton.BackgroundImageLayout = ImageLayout.Stretch;
            deepButton.FlatAppearance.BorderColor = Color.CadetBlue;
            deepButton.FlatStyle = FlatStyle.Flat;
            deepButton.ForeColor = Color.Transparent;
            deepButton.Location = new Point(641, 617);
            deepButton.Margin = new Padding(4, 5, 4, 5);
            deepButton.Name = "deepButton";
            deepButton.Size = new Size(113, 38);
            deepButton.TabIndex = 8;
            deepButton.UseVisualStyleBackColor = false;
            // 
            // autoButton
            // 
            autoButton.BackColor = Color.Transparent;
            autoButton.BackgroundImage = Properties.Resources.bookbutton1;
            autoButton.BackgroundImageLayout = ImageLayout.Stretch;
            autoButton.FlatAppearance.BorderColor = Color.CadetBlue;
            autoButton.FlatStyle = FlatStyle.Flat;
            autoButton.ForeColor = Color.Transparent;
            autoButton.Location = new Point(900, 617);
            autoButton.Margin = new Padding(4, 5, 4, 5);
            autoButton.Name = "autoButton";
            autoButton.Size = new Size(113, 38);
            autoButton.TabIndex = 9;
            autoButton.UseVisualStyleBackColor = false;
            // 
            // homePage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.d9c3a45d_0958_4e44_bf30_c2b2dffd7ab4;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1143, 750);
            Controls.Add(deepButton);
            Controls.Add(standardButton);
            Controls.Add(basicButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(signup);
            Controls.Add(login);
            Controls.Add(pictureBox1);
            Controls.Add(autoButton);
            Controls.Add(pictureBox2);
            Margin = new Padding(4, 5, 4, 5);
            Name = "homePage";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button login;
        private Button signup;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox2;
        private Button basicButton;
        private Button standardButton;
        private Button deepButton;
        private Button autoButton;
    }
}
