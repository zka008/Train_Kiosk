namespace kiosk
{
    partial class Ticket
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
            label3 = new Label();
            textName = new TextBox();
            textID = new TextBox();
            textTel = new TextBox();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 25);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 0;
            label1.Text = "이름";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 63);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 0;
            label2.Text = "아이디";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 100);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 0;
            label3.Text = "전화번호";
            // 
            // textName
            // 
            textName.Enabled = false;
            textName.Location = new Point(130, 22);
            textName.Name = "textName";
            textName.Size = new Size(100, 23);
            textName.TabIndex = 1;
            // 
            // textID
            // 
            textID.Enabled = false;
            textID.Location = new Point(130, 60);
            textID.Name = "textID";
            textID.Size = new Size(100, 23);
            textID.TabIndex = 1;
            // 
            // textTel
            // 
            textTel.Enabled = false;
            textTel.Location = new Point(130, 97);
            textTel.Name = "textTel";
            textTel.Size = new Size(100, 23);
            textTel.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.AliceBlue;
            groupBox1.Controls.Add(textTel);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textID);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textName);
            groupBox1.Location = new Point(32, 28);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(264, 126);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "예약자 정보";
            // 
            // Ticket
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(570, 490);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Ticket";
            Text = "InQuery_UserInfo_Form";
            Load += Ticket_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textName;
        private TextBox textID;
        private TextBox textTel;
        private GroupBox groupBox1;
    }
}