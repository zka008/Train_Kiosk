namespace kiosk
{
    partial class ReservationForm
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
            btnBack1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textName = new TextBox();
            textTel = new TextBox();
            cbDepartureStation = new ComboBox();
            groupBox1 = new GroupBox();
            listTrainSchedule = new ListView();
            groupBox3 = new GroupBox();
            btnNext1 = new Button();
            groupBox4 = new GroupBox();
            cbArriveCity = new ComboBox();
            cbdepartureCity = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            cbArriveStation = new ComboBox();
            label6 = new Label();
            btnTrainQuery = new Button();
            groupBox2 = new GroupBox();
            dtpDepartureDate = new DateTimePicker();
            groupBox5 = new GroupBox();
            cbTrainType = new ComboBox();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // btnBack1
            // 
            btnBack1.Location = new Point(28, 438);
            btnBack1.Name = "btnBack1";
            btnBack1.Size = new Size(75, 23);
            btnBack1.TabIndex = 8;
            btnBack1.Text = "뒤로";
            btnBack1.UseVisualStyleBackColor = true;
            btnBack1.Click += btnBack1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 1;
            label1.Text = "이름";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 48);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 1;
            label2.Text = "전화번호";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(157, 28);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 1;
            label3.Text = "출발역";
            // 
            // textName
            // 
            textName.Enabled = false;
            textName.Location = new Point(71, 16);
            textName.Name = "textName";
            textName.Size = new Size(122, 23);
            textName.TabIndex = 2;
            // 
            // textTel
            // 
            textTel.Enabled = false;
            textTel.Location = new Point(71, 44);
            textTel.Name = "textTel";
            textTel.Size = new Size(122, 23);
            textTel.TabIndex = 2;
            // 
            // cbDepartureStation
            // 
            cbDepartureStation.Enabled = false;
            cbDepartureStation.FormattingEnabled = true;
            cbDepartureStation.Location = new Point(205, 26);
            cbDepartureStation.Name = "cbDepartureStation";
            cbDepartureStation.Size = new Size(104, 23);
            cbDepartureStation.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listTrainSchedule);
            groupBox1.Location = new Point(32, 201);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(504, 231);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "열차 일정";
            // 
            // listTrainSchedule
            // 
            listTrainSchedule.FullRowSelect = true;
            listTrainSchedule.Location = new Point(0, 20);
            listTrainSchedule.Margin = new Padding(2);
            listTrainSchedule.Name = "listTrainSchedule";
            listTrainSchedule.Size = new Size(505, 212);
            listTrainSchedule.TabIndex = 7;
            listTrainSchedule.UseCompatibleStateImageBehavior = false;
            listTrainSchedule.View = View.Details;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(textName);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(textTel);
            groupBox3.Location = new Point(32, 32);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(232, 73);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "예약자 정보";
            // 
            // btnNext1
            // 
            btnNext1.Location = new Point(461, 438);
            btnNext1.Name = "btnNext1";
            btnNext1.Size = new Size(75, 23);
            btnNext1.TabIndex = 9;
            btnNext1.Text = "예약";
            btnNext1.UseVisualStyleBackColor = true;
            btnNext1.Click += btnNext1_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(cbArriveCity);
            groupBox4.Controls.Add(cbdepartureCity);
            groupBox4.Controls.Add(label4);
            groupBox4.Controls.Add(label5);
            groupBox4.Controls.Add(cbArriveStation);
            groupBox4.Controls.Add(label3);
            groupBox4.Controls.Add(label6);
            groupBox4.Controls.Add(cbDepartureStation);
            groupBox4.Location = new Point(32, 111);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(317, 84);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "노선 선택";
            // 
            // cbArriveCity
            // 
            cbArriveCity.FormattingEnabled = true;
            cbArriveCity.Location = new Point(42, 56);
            cbArriveCity.Margin = new Padding(2);
            cbArriveCity.Name = "cbArriveCity";
            cbArriveCity.Size = new Size(104, 23);
            cbArriveCity.TabIndex = 3;
            cbArriveCity.SelectedIndexChanged += cbArriveCity_SelectedIndexChanged;
            // 
            // cbdepartureCity
            // 
            cbdepartureCity.FormattingEnabled = true;
            cbdepartureCity.Location = new Point(42, 26);
            cbdepartureCity.Margin = new Padding(2);
            cbdepartureCity.Name = "cbdepartureCity";
            cbdepartureCity.Size = new Size(104, 23);
            cbdepartureCity.TabIndex = 1;
            cbdepartureCity.SelectedIndexChanged += cbdepartureCity_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(157, 58);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 1;
            label4.Text = "출발역";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 28);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 1;
            label5.Text = "지역";
            // 
            // cbArriveStation
            // 
            cbArriveStation.Enabled = false;
            cbArriveStation.FormattingEnabled = true;
            cbArriveStation.Location = new Point(205, 55);
            cbArriveStation.Name = "cbArriveStation";
            cbArriveStation.Size = new Size(104, 23);
            cbArriveStation.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 58);
            label6.Name = "label6";
            label6.Size = new Size(31, 15);
            label6.TabIndex = 1;
            label6.Text = "지역";
            // 
            // btnTrainQuery
            // 
            btnTrainQuery.Location = new Point(101, 22);
            btnTrainQuery.Margin = new Padding(2);
            btnTrainQuery.Name = "btnTrainQuery";
            btnTrainQuery.Size = new Size(75, 51);
            btnTrainQuery.TabIndex = 6;
            btnTrainQuery.Text = "열차 조회";
            btnTrainQuery.UseVisualStyleBackColor = true;
            btnTrainQuery.Click += btnTrainQuery_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dtpDepartureDate);
            groupBox2.Location = new Point(304, 32);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(232, 73);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "출발 일자";
            // 
            // dtpDepartureDate
            // 
            dtpDepartureDate.Location = new Point(17, 31);
            dtpDepartureDate.Margin = new Padding(2);
            dtpDepartureDate.MaxDate = new DateTime(2024, 12, 31, 0, 0, 0, 0);
            dtpDepartureDate.MinDate = new DateTime(2023, 1, 1, 0, 0, 0, 0);
            dtpDepartureDate.Name = "dtpDepartureDate";
            dtpDepartureDate.Size = new Size(195, 23);
            dtpDepartureDate.TabIndex = 0;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(cbTrainType);
            groupBox5.Controls.Add(btnTrainQuery);
            groupBox5.Location = new Point(355, 111);
            groupBox5.Margin = new Padding(2);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(2);
            groupBox5.Size = new Size(181, 84);
            groupBox5.TabIndex = 2;
            groupBox5.TabStop = false;
            groupBox5.Text = "열차 선택";
            // 
            // cbTrainType
            // 
            cbTrainType.FormattingEnabled = true;
            cbTrainType.Location = new Point(5, 38);
            cbTrainType.Margin = new Padding(2);
            cbTrainType.Name = "cbTrainType";
            cbTrainType.Size = new Size(93, 23);
            cbTrainType.TabIndex = 5;
            // 
            // ReservationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(570, 490);
            Controls.Add(groupBox5);
            Controls.Add(groupBox2);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(btnNext1);
            Controls.Add(btnBack1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ReservationForm";
            Text = "Reservation_UserInfo_Form";
            Load += ReservationForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnBack1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textName;
        private TextBox textTel;
        private ComboBox cbDepartureStation;
        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private Button btnNext1;
        private GroupBox groupBox4;
        private Button button2;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label5;
        private ComboBox cbdepartureCity;
        private ComboBox cbArriveCity;
        private Label label4;
        private ComboBox cbArriveStation;
        private Label label6;
        private GroupBox groupBox2;
        private ListView listTrainSchedule;
        private DateTimePicker dtpDepartureDate;
        private Button button3;
        private Button button4;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label7;
        private Label label8;
        private ComboBox comboBox1;
        private Label label9;
        private Label label10;
        private ComboBox comboBox2;
        private Button btnTrainQuery;
        private GroupBox groupBox5;
        private ComboBox cbTrainType;
    }
}