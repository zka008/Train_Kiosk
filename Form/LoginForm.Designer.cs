namespace kiosk
{
    partial class LoginForm
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
            btnLogin = new Button();
            textID = new TextBox();
            textPW = new TextBox();
            groupBox1 = new GroupBox();
            btnCancle = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 41);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(19, 15);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 70);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(25, 15);
            label2.TabIndex = 0;
            label2.Text = "PW";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(201, 21);
            btnLogin.Margin = new Padding(2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(80, 50);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // textID
            // 
            textID.Location = new Point(70, 39);
            textID.Margin = new Padding(2);
            textID.Name = "textID";
            textID.Size = new Size(98, 23);
            textID.TabIndex = 0;
            // 
            // textPW
            // 
            textPW.Location = new Point(70, 68);
            textPW.Margin = new Padding(2);
            textPW.Name = "textPW";
            textPW.PasswordChar = '*';
            textPW.Size = new Size(98, 23);
            textPW.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.AliceBlue;
            groupBox1.Controls.Add(btnCancle);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnLogin);
            groupBox1.Controls.Add(textPW);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textID);
            groupBox1.Location = new Point(52, 145);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(297, 114);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "아이디와 비밀번호를 입력하세요";
            // 
            // btnCancle
            // 
            btnCancle.Location = new Point(201, 76);
            btnCancle.Margin = new Padding(2);
            btnCancle.Name = "btnCancle";
            btnCancle.Size = new Size(80, 24);
            btnCancle.TabIndex = 3;
            btnCancle.Text = "취소";
            btnCancle.UseVisualStyleBackColor = true;
            btnCancle.Click += btnCancle_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(400, 410);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "LoginForm";
            Text = "LoginForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnLogin;
        private TextBox textID;
        private TextBox textPW;
        private GroupBox groupBox1;
        private Button btnCancle;
    }
}