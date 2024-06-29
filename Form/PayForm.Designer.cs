namespace kiosk
{
    partial class PayForm
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
            textDeparture = new TextBox();
            textArrive = new TextBox();
            textArriveT = new TextBox();
            textDepartureT = new TextBox();
            label3 = new Label();
            comboBox1 = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            comboBox2 = new ComboBox();
            button1 = new Button();
            textName = new TextBox();
            label6 = new Label();
            textBox6 = new TextBox();
            textTel = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            button2 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 121);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 0;
            label1.Text = "출발";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(303, 121);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 0;
            label2.Text = "도착";
            // 
            // textDeparture
            // 
            textDeparture.Enabled = false;
            textDeparture.Location = new Point(87, 103);
            textDeparture.Name = "textDeparture";
            textDeparture.Size = new Size(100, 23);
            textDeparture.TabIndex = 1;
            // 
            // textArrive
            // 
            textArrive.Enabled = false;
            textArrive.Location = new Point(348, 103);
            textArrive.Name = "textArrive";
            textArrive.Size = new Size(100, 23);
            textArrive.TabIndex = 1;
            // 
            // textArriveT
            // 
            textArriveT.Enabled = false;
            textArriveT.Location = new Point(348, 132);
            textArriveT.Name = "textArriveT";
            textArriveT.Size = new Size(100, 23);
            textArriveT.TabIndex = 1;
            // 
            // textDepartureT
            // 
            textDepartureT.Enabled = false;
            textDepartureT.Location = new Point(87, 132);
            textDepartureT.Name = "textDepartureT";
            textDepartureT.Size = new Size(100, 23);
            textDepartureT.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("맑은 고딕", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(238, 117);
            label3.Name = "label3";
            label3.Size = new Size(22, 19);
            label3.TabIndex = 2;
            label3.Text = "→";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(24, 50);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(182, 32);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 2;
            label4.Text = "결재 방법";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 32);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 2;
            label5.Text = "결재 수단";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(182, 50);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(446, 424);
            button1.Name = "button1";
            button1.Size = new Size(84, 32);
            button1.TabIndex = 4;
            button1.Text = "예약";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textName
            // 
            textName.Enabled = false;
            textName.Location = new Point(87, 42);
            textName.Name = "textName";
            textName.Size = new Size(100, 23);
            textName.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(42, 45);
            label6.Name = "label6";
            label6.Size = new Size(43, 15);
            label6.TabIndex = 0;
            label6.Text = "예약자";
            // 
            // textBox6
            // 
            textBox6.Enabled = false;
            textBox6.Location = new Point(348, 42);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 5;
            // 
            // textTel
            // 
            textTel.AutoSize = true;
            textTel.Location = new Point(287, 45);
            textTel.Name = "textTel";
            textTel.Size = new Size(55, 15);
            textTel.TabIndex = 0;
            textTel.Text = "전화번호";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(textBox6);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textTel);
            groupBox1.Controls.Add(textDeparture);
            groupBox1.Controls.Add(textDepartureT);
            groupBox1.Controls.Add(textArrive);
            groupBox1.Controls.Add(textArriveT);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(36, 40);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(494, 186);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "예약 정보 확인";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(comboBox2);
            groupBox2.Location = new Point(36, 246);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(494, 100);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "결재 수단";
            // 
            // button2
            // 
            button2.Location = new Point(36, 424);
            button2.Name = "button2";
            button2.Size = new Size(84, 32);
            button2.TabIndex = 4;
            button2.Text = "취소";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // PayForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(570, 490);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PayForm";
            Text = "PayForm";
            Load += PayForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textDeparture;
        private TextBox textArrive;
        private TextBox textArriveT;
        private TextBox textDepartureT;
        private Label label3;
        private ComboBox comboBox1;
        private Label label4;
        private Label label5;
        private ComboBox comboBox2;
        private Button button1;
        private TextBox textName;
        private Label label6;
        private TextBox textBox6;
        private Label textTel;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button button2;
    }
}