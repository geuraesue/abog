namespace abog.UI
{
    partial class BookServiceForm1
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
            label3 = new Label();
            label4 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            panelBasic = new Panel();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            panelDeep = new Panel();
            label16 = new Label();
            label13 = new Label();
            label10 = new Label();
            panelStandard = new Panel();
            label15 = new Label();
            label12 = new Label();
            label9 = new Label();
            panelAuto = new Panel();
            label17 = new Label();
            label14 = new Label();
            label11 = new Label();
            label5 = new Label();
            btnContinue = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panelBasic.SuspendLayout();
            panelDeep.SuspendLayout();
            panelStandard.SuspendLayout();
            panelAuto.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.abog;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(28, 22);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(142, 58);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Emoji", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(90, 118, 132);
            label1.Location = new Point(980, 38);
            label1.Name = "label1";
            label1.Size = new Size(136, 27);
            label1.TabIndex = 2;
            label1.Text = "Book a service";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(90, 118, 132);
            label2.Location = new Point(130, 109);
            label2.Name = "label2";
            label2.Size = new Size(164, 24);
            label2.TabIndex = 3;
            label2.Text = "1. Choose service";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(90, 118, 132);
            label3.Location = new Point(499, 110);
            label3.Name = "label3";
            label3.Size = new Size(151, 24);
            label3.TabIndex = 4;
            label3.Text = "2. Booking details";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.ForeColor = Color.FromArgb(90, 118, 132);
            label4.Location = new Point(883, 109);
            label4.Name = "label4";
            label4.Size = new Size(95, 25);
            label4.TabIndex = 5;
            label4.Text = "3. Confirm";
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightGray;
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(3, 137);
            panel2.Name = "panel2";
            panel2.Size = new Size(1145, 10);
            panel2.TabIndex = 7;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(90, 118, 132);
            panel3.Location = new Point(86, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(242, 10);
            panel3.TabIndex = 8;
            // 
            // panelBasic
            // 
            panelBasic.BorderStyle = BorderStyle.FixedSingle;
            panelBasic.Controls.Add(label8);
            panelBasic.Controls.Add(label7);
            panelBasic.Controls.Add(label6);
            panelBasic.Location = new Point(52, 246);
            panelBasic.Name = "panelBasic";
            panelBasic.Size = new Size(503, 163);
            panelBasic.TabIndex = 8;
            panelBasic.Paint += panel4_Paint;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(90, 118, 132);
            label8.Location = new Point(36, 99);
            label8.Name = "label8";
            label8.Size = new Size(224, 24);
            label8.TabIndex = 12;
            label8.Text = "Sweep, mop, wipe surfaces";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(155, 167, 123);
            label7.Location = new Point(35, 67);
            label7.Name = "label7";
            label7.Size = new Size(82, 32);
            label7.TabIndex = 13;
            label7.Text = "₱ 699";
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Emoji", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(90, 118, 132);
            label6.Location = new Point(25, 24);
            label6.Name = "label6";
            label6.Size = new Size(189, 43);
            label6.TabIndex = 12;
            label6.Text = "Basic Clean";
            // 
            // panelDeep
            // 
            panelDeep.BorderStyle = BorderStyle.FixedSingle;
            panelDeep.Controls.Add(label16);
            panelDeep.Controls.Add(label13);
            panelDeep.Controls.Add(label10);
            panelDeep.Location = new Point(52, 432);
            panelDeep.Name = "panelDeep";
            panelDeep.Size = new Size(503, 163);
            panelDeep.TabIndex = 9;
            panelDeep.Paint += panelDeep_Paint;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.Transparent;
            label16.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.FromArgb(90, 118, 132);
            label16.Location = new Point(36, 101);
            label16.Name = "label16";
            label16.Size = new Size(396, 24);
            label16.TabIndex = 15;
            label16.Text = "Scrubbing grout, tiles, and hard-to-reach corners";
            label16.Click += label16_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.FromArgb(155, 167, 123);
            label13.Location = new Point(35, 69);
            label13.Name = "label13";
            label13.Size = new Size(102, 32);
            label13.TabIndex = 14;
            label13.Text = "₱ 3,199";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI Emoji", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(90, 118, 132);
            label10.Location = new Point(25, 26);
            label10.Name = "label10";
            label10.Size = new Size(192, 43);
            label10.TabIndex = 13;
            label10.Text = "Deep Clean";
            // 
            // panelStandard
            // 
            panelStandard.BorderStyle = BorderStyle.FixedSingle;
            panelStandard.Controls.Add(label15);
            panelStandard.Controls.Add(label12);
            panelStandard.Controls.Add(label9);
            panelStandard.Location = new Point(587, 246);
            panelStandard.Name = "panelStandard";
            panelStandard.Size = new Size(503, 163);
            panelStandard.TabIndex = 9;
            panelStandard.Paint += panel1_Paint;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.FromArgb(90, 118, 132);
            label15.Location = new Point(43, 99);
            label15.Name = "label15";
            label15.Size = new Size(378, 24);
            label15.TabIndex = 14;
            label15.Text = "Dusting furniture, fixtures, and accessible areas";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.FromArgb(155, 167, 123);
            label12.Location = new Point(43, 67);
            label12.Name = "label12";
            label12.Size = new Size(102, 32);
            label12.TabIndex = 14;
            label12.Text = "₱ 1,499";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI Emoji", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(90, 118, 132);
            label9.Location = new Point(33, 24);
            label9.Name = "label9";
            label9.Size = new Size(248, 43);
            label9.TabIndex = 14;
            label9.Text = "Standard Clean";
            // 
            // panelAuto
            // 
            panelAuto.BorderStyle = BorderStyle.FixedSingle;
            panelAuto.Controls.Add(label17);
            panelAuto.Controls.Add(label14);
            panelAuto.Controls.Add(label11);
            panelAuto.Location = new Point(587, 432);
            panelAuto.Name = "panelAuto";
            panelAuto.Size = new Size(503, 163);
            panelAuto.TabIndex = 10;
            panelAuto.Paint += panelAuto_Paint;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.Transparent;
            label17.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.FromArgb(90, 118, 132);
            label17.Location = new Point(43, 101);
            label17.Name = "label17";
            label17.Size = new Size(393, 24);
            label17.TabIndex = 16;
            label17.Text = "Wiping and conditioning dashboard, and panels";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.FromArgb(155, 167, 123);
            label14.Location = new Point(43, 69);
            label14.Name = "label14";
            label14.Size = new Size(82, 32);
            label14.TabIndex = 14;
            label14.Text = "₱ 499";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI Emoji", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.FromArgb(90, 118, 132);
            label11.Location = new Point(33, 26);
            label11.Name = "label11";
            label11.Size = new Size(190, 43);
            label11.TabIndex = 13;
            label11.Text = "Auto Detail";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(90, 118, 132);
            label5.Location = new Point(52, 187);
            label5.Name = "label5";
            label5.Size = new Size(188, 24);
            label5.TabIndex = 11;
            label5.Text = "Choose your service";
            // 
            // btnContinue
            // 
            btnContinue.BackColor = Color.FromArgb(90, 118, 132);
            btnContinue.FlatStyle = FlatStyle.Flat;
            btnContinue.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnContinue.ForeColor = Color.White;
            btnContinue.Location = new Point(50, 617);
            btnContinue.Name = "btnContinue";
            btnContinue.Size = new Size(1040, 42);
            btnContinue.TabIndex = 13;
            btnContinue.Text = "Continue ->";
            btnContinue.UseVisualStyleBackColor = false;
            btnContinue.Click += btnContinue_Click;
            // 
            // BookServiceForm1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.d9c3a45d_0958_4e44_bf30_c2b2dffd7ab4;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1143, 750);
            Controls.Add(btnContinue);
            Controls.Add(label5);
            Controls.Add(panelAuto);
            Controls.Add(panelStandard);
            Controls.Add(panelDeep);
            Controls.Add(panelBasic);
            Controls.Add(panel2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "BookServiceForm1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Choose Service";
            Load += BookServiceForm1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panelBasic.ResumeLayout(false);
            panelBasic.PerformLayout();
            panelDeep.ResumeLayout(false);
            panelDeep.PerformLayout();
            panelStandard.ResumeLayout(false);
            panelStandard.PerformLayout();
            panelAuto.ResumeLayout(false);
            panelAuto.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Panel panel2;
        private Panel panel3;
        private Panel panelBasic;
        private Panel panelDeep;
        private Panel panelStandard;
        private Panel panelAuto;
        private Label label5;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label13;
        private Label label10;
        private Label label12;
        private Label label9;
        private Label label14;
        private Label label11;
        private Label label16;
        private Label label15;
        private Label label17;
        private Button btnContinue;
    }
}