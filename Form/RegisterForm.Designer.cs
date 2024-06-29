namespace kiosk
{
    partial class RegisterForm
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
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            textIdentify = new TextBox();
            textBirth = new TextBox();
            textTel3 = new TextBox();
            textTel2 = new TextBox();
            textTel1 = new TextBox();
            textName = new TextBox();
            label5 = new Label();
            textPassword = new TextBox();
            label4 = new Label();
            textEmail = new TextBox();
            label3 = new Label();
            groupBox2 = new GroupBox();
            radioDisAgree = new RadioButton();
            radioAgree = new RadioButton();
            btnRegister = new Button();
            btnCancle = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 22);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "이메일";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 52);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 0;
            label2.Text = "비밀번호";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(textIdentify);
            groupBox1.Controls.Add(textBirth);
            groupBox1.Controls.Add(textTel3);
            groupBox1.Controls.Add(textTel2);
            groupBox1.Controls.Add(textTel1);
            groupBox1.Controls.Add(textName);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textPassword);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textEmail);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(17, 40);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(471, 187);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "회원 정보";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(268, 112);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(12, 15);
            label8.TabIndex = 2;
            label8.Text = "-";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(150, 112);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(12, 15);
            label7.TabIndex = 2;
            label7.Text = "-";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(184, 142);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(12, 15);
            label6.TabIndex = 2;
            label6.Text = "-";
            // 
            // textIdentify
            // 
            textIdentify.Location = new Point(200, 140);
            textIdentify.Margin = new Padding(2);
            textIdentify.MaxLength = 7;
            textIdentify.Name = "textIdentify";
            textIdentify.PasswordChar = '*';
            textIdentify.PlaceholderText = " 주민번호 뒷자리";
            textIdentify.Size = new Size(98, 23);
            textIdentify.TabIndex = 7;
            // 
            // textBirth
            // 
            textBirth.Location = new Point(82, 140);
            textBirth.Margin = new Padding(2);
            textBirth.MaxLength = 6;
            textBirth.Name = "textBirth";
            textBirth.PlaceholderText = "     생년월일";
            textBirth.Size = new Size(98, 23);
            textBirth.TabIndex = 6;
            // 
            // textTel3
            // 
            textTel3.Location = new Point(285, 110);
            textTel3.Margin = new Padding(2);
            textTel3.MaxLength = 4;
            textTel3.Name = "textTel3";
            textTel3.Size = new Size(98, 23);
            textTel3.TabIndex = 5;
            // 
            // textTel2
            // 
            textTel2.Location = new Point(166, 110);
            textTel2.Margin = new Padding(2);
            textTel2.MaxLength = 4;
            textTel2.Name = "textTel2";
            textTel2.Size = new Size(98, 23);
            textTel2.TabIndex = 4;
            // 
            // textTel1
            // 
            textTel1.Location = new Point(82, 110);
            textTel1.Margin = new Padding(2);
            textTel1.MaxLength = 3;
            textTel1.Name = "textTel1";
            textTel1.Size = new Size(65, 23);
            textTel1.TabIndex = 3;
            // 
            // textName
            // 
            textName.Location = new Point(82, 80);
            textName.Margin = new Padding(2);
            textName.Name = "textName";
            textName.Size = new Size(98, 23);
            textName.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 142);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 0;
            label5.Text = "주민번호";
            // 
            // textPassword
            // 
            textPassword.Location = new Point(82, 50);
            textPassword.Margin = new Padding(2);
            textPassword.Name = "textPassword";
            textPassword.PasswordChar = '*';
            textPassword.Size = new Size(98, 23);
            textPassword.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 112);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 0;
            label4.Text = "전화번호";
            // 
            // textEmail
            // 
            textEmail.Location = new Point(82, 20);
            textEmail.Margin = new Padding(2);
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(98, 23);
            textEmail.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 82);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 0;
            label3.Text = "이름";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioDisAgree);
            groupBox2.Controls.Add(radioAgree);
            groupBox2.Location = new Point(17, 252);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(212, 56);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "개인 정보 수집";
            // 
            // radioDisAgree
            // 
            radioDisAgree.AutoSize = true;
            radioDisAgree.Location = new Point(150, 26);
            radioDisAgree.Margin = new Padding(2);
            radioDisAgree.Name = "radioDisAgree";
            radioDisAgree.Size = new Size(49, 19);
            radioDisAgree.TabIndex = 9;
            radioDisAgree.TabStop = true;
            radioDisAgree.Text = "거부";
            radioDisAgree.UseVisualStyleBackColor = true;
            radioDisAgree.CheckedChanged += radioDisAgree_CheckedChanged;
            // 
            // radioAgree
            // 
            radioAgree.AutoSize = true;
            radioAgree.Location = new Point(15, 26);
            radioAgree.Margin = new Padding(2);
            radioAgree.Name = "radioAgree";
            radioAgree.Size = new Size(49, 19);
            radioAgree.TabIndex = 8;
            radioAgree.TabStop = true;
            radioAgree.Text = "동의";
            radioAgree.UseVisualStyleBackColor = true;
            radioAgree.CheckedChanged += radioAgree_CheckedChanged;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(310, 256);
            btnRegister.Margin = new Padding(2);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(78, 52);
            btnRegister.TabIndex = 10;
            btnRegister.Text = "회원가입";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnCancle
            // 
            btnCancle.Location = new Point(410, 256);
            btnCancle.Margin = new Padding(2);
            btnCancle.Name = "btnCancle";
            btnCancle.Size = new Size(78, 52);
            btnCancle.TabIndex = 11;
            btnCancle.Text = "취소";
            btnCancle.UseVisualStyleBackColor = true;
            btnCancle.Click += btnCancle_Click;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(506, 379);
            Controls.Add(btnCancle);
            Controls.Add(btnRegister);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "RegisterForm";
            Text = "RegisterForm";
            Load += RegisterForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private TextBox textTel1;
        private TextBox textName;
        private TextBox textPassword;
        private Label label4;
        private TextBox textEmail;
        private Label label3;
        private GroupBox groupBox2;
        private RadioButton radioDisAgree;
        private RadioButton radioAgree;
        private TextBox textBirth;
        private Label label5;
        private Button btnRegister;
        private Button btnCancle;
        private Label label8;
        private Label label7;
        private Label label6;
        private TextBox textIdentify;
        private TextBox textTel3;
        private TextBox textTel2;
    }
}