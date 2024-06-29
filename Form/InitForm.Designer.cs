namespace kiosk
{
    partial class InitForm
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
            btnReservation = new Button();
            btnInquery = new Button();
            label1 = new Label();
            btnRegister = new Button();
            btbLogin = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnReservation
            // 
            btnReservation.Location = new Point(291, 226);
            btnReservation.Name = "btnReservation";
            btnReservation.Size = new Size(161, 60);
            btnReservation.TabIndex = 0;
            btnReservation.Text = "예약";
            btnReservation.UseVisualStyleBackColor = true;
            btnReservation.Click += btnReservation_Click;
            // 
            // btnInquery
            // 
            btnInquery.Location = new Point(291, 314);
            btnInquery.Name = "btnInquery";
            btnInquery.Size = new Size(161, 60);
            btnInquery.TabIndex = 1;
            btnInquery.Text = "조회";
            btnInquery.UseVisualStyleBackColor = true;
            btnInquery.Click += btnInquery_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(212, 154);
            label1.Name = "label1";
            label1.Size = new Size(134, 37);
            label1.TabIndex = 2;
            label1.Text = "열차 예매";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(105, 314);
            btnRegister.Margin = new Padding(2);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(161, 60);
            btnRegister.TabIndex = 3;
            btnRegister.Text = "회원가입";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btbLogin
            // 
            btbLogin.Location = new Point(105, 226);
            btbLogin.Margin = new Padding(2);
            btbLogin.Name = "btbLogin";
            btbLogin.Size = new Size(161, 60);
            btbLogin.TabIndex = 3;
            btbLogin.Text = "로그인";
            btbLogin.UseVisualStyleBackColor = true;
            btbLogin.Click += btbLogin_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ktx;
            pictureBox1.Location = new Point(105, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(347, 123);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // InitForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(554, 451);
            Controls.Add(pictureBox1);
            Controls.Add(btbLogin);
            Controls.Add(btnRegister);
            Controls.Add(label1);
            Controls.Add(btnInquery);
            Controls.Add(btnReservation);
            Name = "InitForm";
            Text = "열차 예약 프로그램";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnReservation;
        private Button btnInquery;
        private Label label1;
        private Button btnRegister;
        private Button btbLogin;
        private PictureBox pictureBox1;
    }
}
