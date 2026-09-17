namespace WinFormsApp26
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tabControl1 = new TabControl();
            tabPageSearch = new TabPage();
            btnAdminLogin = new Button();
            panel1 = new Panel();
            button1 = new Button();
            button2 = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            groupBox1 = new GroupBox();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            panelMembers = new Panel();
            button6 = new Button();
            button5 = new Button();
            btnMemberImage = new Button();
            pictureBox1 = new PictureBox();
            txtAddress = new TextBox();
            txtPhone = new TextBox();
            txtNumber = new TextBox();
            txtLastName = new TextBox();
            txtName = new TextBox();
            txtCode = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            tabPage3 = new TabPage();
            panelBooks = new Panel();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            pictureBox2 = new PictureBox();
            txtSubject = new TextBox();
            txtShabak = new TextBox();
            txtPublication = new TextBox();
            txtYear = new TextBox();
            txtTranslator = new TextBox();
            txtAuthor = new TextBox();
            txtBookName = new TextBox();
            label19 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            tabControl1.SuspendLayout();
            tabPageSearch.SuspendLayout();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPage2.SuspendLayout();
            panelMembers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabPage3.SuspendLayout();
            panelBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageSearch);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.RightToLeft = RightToLeft.Yes;
            tabControl1.RightToLeftLayout = true;
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 539);
            tabControl1.TabIndex = 0;
            // 
            // tabPageSearch
            // 
            tabPageSearch.BackColor = Color.LightSlateGray;
            tabPageSearch.Controls.Add(btnAdminLogin);
            tabPageSearch.Controls.Add(panel1);
            tabPageSearch.Controls.Add(groupBox1);
            tabPageSearch.Controls.Add(label2);
            tabPageSearch.Controls.Add(label1);
            tabPageSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabPageSearch.Location = new Point(4, 34);
            tabPageSearch.Name = "tabPageSearch";
            tabPageSearch.Padding = new Padding(3);
            tabPageSearch.RightToLeft = RightToLeft.Yes;
            tabPageSearch.Size = new Size(792, 501);
            tabPageSearch.TabIndex = 0;
            tabPageSearch.Text = "جستجو";
            // 
            // btnAdminLogin
            // 
            btnAdminLogin.Font = new Font("2  Compset", 12F, FontStyle.Bold, GraphicsUnit.Point, 178);
            btnAdminLogin.Location = new Point(6, 20);
            btnAdminLogin.Name = "btnAdminLogin";
            btnAdminLogin.Size = new Size(106, 43);
            btnAdminLogin.TabIndex = 14;
            btnAdminLogin.Text = "ورود مدیر";
            btnAdminLogin.UseVisualStyleBackColor = true;
            btnAdminLogin.Click += btnLogin_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox4);
            panel1.ForeColor = SystemColors.Control;
            panel1.Location = new Point(77, 193);
            panel1.Name = "panel1";
            panel1.Size = new Size(654, 300);
            panel1.TabIndex = 3;
            panel1.Paint += panel1_Paint;
            // 
            // button1
            // 
            button1.Font = new Font("2  Compset", 12F, FontStyle.Bold, GraphicsUnit.Point, 178);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(15, 245);
            button1.Name = "button1";
            button1.Size = new Size(106, 43);
            button1.TabIndex = 15;
            button1.Text = "پاک";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("2  Compset", 12F, FontStyle.Bold, GraphicsUnit.Point, 178);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(150, 245);
            button2.Name = "button2";
            button2.Size = new Size(120, 43);
            button2.TabIndex = 16;
            button2.Text = "جستجو کن";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("2  Compset", 14F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label6.Location = new Point(526, 218);
            label6.Name = "label6";
            label6.Size = new Size(111, 50);
            label6.TabIndex = 11;
            label6.Text = "سال چاپ:";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("2  Compset", 14F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label5.Location = new Point(531, 143);
            label5.Name = "label5";
            label5.Size = new Size(95, 50);
            label5.TabIndex = 10;
            label5.Text = "موضوع:";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("2  Compset", 14F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label4.Location = new Point(531, 69);
            label4.Name = "label4";
            label4.Size = new Size(108, 50);
            label4.TabIndex = 9;
            label4.Text = "نام مولف:";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("2  Compset", 14F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label3.Location = new Point(531, 7);
            label3.Name = "label3";
            label3.Size = new Size(106, 50);
            label3.TabIndex = 8;
            label3.Text = "نام کتاب:";
            label3.Click += label3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(61, 8);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(464, 39);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(199, 154);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(326, 39);
            textBox2.TabIndex = 5;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(361, 225);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(164, 39);
            textBox3.TabIndex = 6;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(61, 80);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(464, 39);
            textBox4.TabIndex = 7;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton4);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Font = new Font("2  Compset", 12F, FontStyle.Bold, GraphicsUnit.Point, 178);
            groupBox1.Location = new Point(77, 66);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(654, 109);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "جستجو بر اساس";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(15, 49);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(115, 47);
            radioButton4.TabIndex = 6;
            radioButton4.TabStop = true;
            radioButton4.Text = "سال چاپ";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(199, 49);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(101, 47);
            radioButton3.TabIndex = 5;
            radioButton3.TabStop = true;
            radioButton3.Text = "موضوع";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(361, 49);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(111, 47);
            radioButton2.TabIndex = 4;
            radioButton2.TabStop = true;
            radioButton2.Text = "نام مولف";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(531, 49);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(110, 47);
            radioButton1.TabIndex = 3;
            radioButton1.TabStop = true;
            radioButton1.Text = "نام کتاب";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("2  Compset", 12F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label2.Location = new Point(573, 20);
            label2.Name = "label2";
            label2.Size = new Size(62, 43);
            label2.TabIndex = 1;
            label2.Text = "مهمان";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("2  Compset", 12F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label1.Location = new Point(641, 20);
            label1.Name = "label1";
            label1.Size = new Size(90, 43);
            label1.TabIndex = 0;
            label1.Text = "نام کاربر:";
            label1.Click += label1_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(panelMembers);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 501);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "اعضا";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // panelMembers
            // 
            panelMembers.BackColor = Color.LightSlateGray;
            panelMembers.Controls.Add(button6);
            panelMembers.Controls.Add(button5);
            panelMembers.Controls.Add(btnMemberImage);
            panelMembers.Controls.Add(pictureBox1);
            panelMembers.Controls.Add(txtAddress);
            panelMembers.Controls.Add(txtPhone);
            panelMembers.Controls.Add(txtNumber);
            panelMembers.Controls.Add(txtLastName);
            panelMembers.Controls.Add(txtName);
            panelMembers.Controls.Add(txtCode);
            panelMembers.Controls.Add(label7);
            panelMembers.Controls.Add(label8);
            panelMembers.Controls.Add(label9);
            panelMembers.Controls.Add(label10);
            panelMembers.Controls.Add(label11);
            panelMembers.Controls.Add(label12);
            panelMembers.Dock = DockStyle.Fill;
            panelMembers.Enabled = false;
            panelMembers.Location = new Point(3, 3);
            panelMembers.Name = "panelMembers";
            panelMembers.Size = new Size(786, 495);
            panelMembers.TabIndex = 0;
            panelMembers.Paint += panel2_Paint;
            // 
            // button6
            // 
            button6.Font = new Font("2  Compset", 12F, FontStyle.Bold, GraphicsUnit.Point, 178);
            button6.Location = new Point(45, 394);
            button6.Name = "button6";
            button6.Size = new Size(150, 42);
            button6.TabIndex = 19;
            button6.Text = "جدید";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Font = new Font("2  Compset", 12F, FontStyle.Bold, GraphicsUnit.Point, 178);
            button5.Location = new Point(45, 335);
            button5.Name = "button5";
            button5.Size = new Size(150, 43);
            button5.TabIndex = 18;
            button5.Text = "ثبت";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // btnMemberImage
            // 
            btnMemberImage.Font = new Font("2  Compset", 12F, FontStyle.Bold, GraphicsUnit.Point, 178);
            btnMemberImage.Location = new Point(45, 269);
            btnMemberImage.Name = "btnMemberImage";
            btnMemberImage.Size = new Size(150, 50);
            btnMemberImage.TabIndex = 17;
            btnMemberImage.Text = "درج تصویر";
            btnMemberImage.UseVisualStyleBackColor = true;
            btnMemberImage.Click += button4_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(29, 48);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(189, 187);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(333, 346);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.ScrollBars = ScrollBars.Both;
            txtAddress.Size = new Size(316, 108);
            txtAddress.TabIndex = 4;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(391, 279);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(258, 31);
            txtPhone.TabIndex = 15;
            // 
            // txtNumber
            // 
            txtNumber.Location = new Point(391, 221);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(258, 31);
            txtNumber.TabIndex = 14;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(333, 164);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(316, 31);
            txtLastName.TabIndex = 13;
            // 
            // txtName
            // 
            txtName.Location = new Point(333, 103);
            txtName.Name = "txtName";
            txtName.Size = new Size(316, 31);
            txtName.TabIndex = 5;
            // 
            // txtCode
            // 
            txtCode.Location = new Point(431, 48);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(218, 31);
            txtCode.TabIndex = 6;
            txtCode.TextChanged += textBox10_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("2  Compset", 12F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label7.Location = new Point(655, 221);
            label7.Name = "label7";
            label7.Size = new Size(75, 43);
            label7.TabIndex = 7;
            label7.Text = "کدملی:";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("2  Compset", 12F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label8.Location = new Point(655, 276);
            label8.Name = "label8";
            label8.Size = new Size(57, 43);
            label8.TabIndex = 8;
            label8.Text = "تلفن:";
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("2  Compset", 12F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label9.Location = new Point(655, 346);
            label9.Name = "label9";
            label9.Size = new Size(66, 43);
            label9.TabIndex = 9;
            label9.Text = "نشانی:";
            label9.Click += label9_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("2  Compset", 12F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label10.Location = new Point(655, 161);
            label10.Name = "label10";
            label10.Size = new Size(123, 43);
            label10.TabIndex = 10;
            label10.Text = "نام خانوادگی:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("2  Compset", 12F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label11.Location = new Point(655, 100);
            label11.Name = "label11";
            label11.Size = new Size(44, 43);
            label11.TabIndex = 11;
            label11.Text = "نام:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Compset", 12F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label12.Location = new Point(655, 48);
            label12.Name = "label12";
            label12.Size = new Size(115, 43);
            label12.TabIndex = 12;
            label12.Text = "کد عضویت:";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(panelBooks);
            tabPage3.Location = new Point(4, 34);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(792, 501);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "کتاب";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // panelBooks
            // 
            panelBooks.BackColor = Color.LightSlateGray;
            panelBooks.Controls.Add(button9);
            panelBooks.Controls.Add(button8);
            panelBooks.Controls.Add(button7);
            panelBooks.Controls.Add(pictureBox2);
            panelBooks.Controls.Add(txtSubject);
            panelBooks.Controls.Add(txtShabak);
            panelBooks.Controls.Add(txtPublication);
            panelBooks.Controls.Add(txtYear);
            panelBooks.Controls.Add(txtTranslator);
            panelBooks.Controls.Add(txtAuthor);
            panelBooks.Controls.Add(txtBookName);
            panelBooks.Controls.Add(label19);
            panelBooks.Controls.Add(label13);
            panelBooks.Controls.Add(label14);
            panelBooks.Controls.Add(label15);
            panelBooks.Controls.Add(label16);
            panelBooks.Controls.Add(label17);
            panelBooks.Controls.Add(label18);
            panelBooks.Dock = DockStyle.Fill;
            panelBooks.Enabled = false;
            panelBooks.Location = new Point(3, 3);
            panelBooks.Name = "panelBooks";
            panelBooks.Size = new Size(786, 495);
            panelBooks.TabIndex = 0;
            // 
            // button9
            // 
            button9.Enabled = false;
            button9.Font = new Font("2  Compset", 12F, FontStyle.Bold, GraphicsUnit.Point, 178);
            button9.Location = new Point(53, 370);
            button9.Name = "button9";
            button9.Size = new Size(150, 44);
            button9.TabIndex = 16;
            button9.Text = "جدید";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button8
            // 
            button8.Font = new Font("2  Compset", 12F, FontStyle.Bold, GraphicsUnit.Point, 178);
            button8.Location = new Point(53, 321);
            button8.Name = "button8";
            button8.Size = new Size(150, 43);
            button8.TabIndex = 15;
            button8.Text = "ثبت";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.Font = new Font("2  Compset", 12F, FontStyle.Bold, GraphicsUnit.Point, 178);
            button7.Location = new Point(53, 269);
            button7.Name = "button7";
            button7.Size = new Size(150, 46);
            button7.TabIndex = 1;
            button7.Text = "عکس کتاب";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(25, 62);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(197, 194);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // txtSubject
            // 
            txtSubject.Location = new Point(375, 364);
            txtSubject.Name = "txtSubject";
            txtSubject.Size = new Size(279, 31);
            txtSubject.TabIndex = 13;
            txtSubject.TextChanged += textBox17_TextChanged;
            // 
            // txtShabak
            // 
            txtShabak.Location = new Point(380, 440);
            txtShabak.Name = "txtShabak";
            txtShabak.Size = new Size(279, 31);
            txtShabak.TabIndex = 12;
            txtShabak.TextChanged += textBox16_TextChanged;
            // 
            // txtPublication
            // 
            txtPublication.Location = new Point(446, 225);
            txtPublication.Name = "txtPublication";
            txtPublication.Size = new Size(208, 31);
            txtPublication.TabIndex = 11;
            txtPublication.TextChanged += textBox15_TextChanged;
            // 
            // txtYear
            // 
            txtYear.Location = new Point(446, 294);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(208, 31);
            txtYear.TabIndex = 10;
            txtYear.TextChanged += textBox14_TextChanged;
            // 
            // txtTranslator
            // 
            txtTranslator.Location = new Point(375, 156);
            txtTranslator.Name = "txtTranslator";
            txtTranslator.Size = new Size(279, 31);
            txtTranslator.TabIndex = 9;
            txtTranslator.TextChanged += textBox7_TextChanged;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(375, 88);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(279, 31);
            txtAuthor.TabIndex = 8;
            txtAuthor.TextChanged += textBox6_TextChanged;
            // 
            // txtBookName
            // 
            txtBookName.Location = new Point(437, 24);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(208, 31);
            txtBookName.TabIndex = 1;
            txtBookName.TextChanged += textBox5_TextChanged;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Compset", 12F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label19.Location = new Point(665, 437);
            label19.Name = "label19";
            label19.Size = new Size(70, 43);
            label19.TabIndex = 7;
            label19.Text = "شابک:";
            label19.Click += label19_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Compset", 12F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label13.Location = new Point(660, 361);
            label13.Name = "label13";
            label13.Size = new Size(82, 43);
            label13.TabIndex = 1;
            label13.Text = "موضوع:";
            label13.Click += label13_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Compset", 12F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label14.Location = new Point(651, 282);
            label14.Name = "label14";
            label14.Size = new Size(96, 43);
            label14.TabIndex = 2;
            label14.Text = "سال چاپ:";
            label14.Click += label14_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Compset", 12F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label15.Location = new Point(660, 213);
            label15.Name = "label15";
            label15.Size = new Size(91, 43);
            label15.TabIndex = 3;
            label15.Text = "انتشارات:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Compset", 12F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label16.Location = new Point(660, 153);
            label16.Name = "label16";
            label16.Size = new Size(72, 43);
            label16.TabIndex = 4;
            label16.Text = "مترجم:";
            label16.Click += label16_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Compset", 12F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label17.Location = new Point(660, 85);
            label17.Name = "label17";
            label17.Size = new Size(68, 43);
            label17.TabIndex = 5;
            label17.Text = "مولف:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Compset", 12F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label18.Location = new Point(651, 21);
            label18.Name = "label18";
            label18.Size = new Size(91, 43);
            label18.TabIndex = 6;
            label18.Text = "نام کتاب:";
            label18.Click += label18_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 539);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPageSearch.ResumeLayout(false);
            tabPageSearch.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage2.ResumeLayout(false);
            panelMembers.ResumeLayout(false);
            panelMembers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabPage3.ResumeLayout(false);
            panelBooks.ResumeLayout(false);
            panelBooks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPageSearch;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox1;
        private RadioButton radioButton1;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private Panel panel1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox textBox4;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button btnAdminLogin;
        private Button button1;
        private Button button2;
        private Panel panelMembers;
        private Label label9;
        private Label label8;
        private Label label7;
        private TextBox txtCode;
        private TextBox txtName;
        private TextBox txtAddress;
        private Label label10;
        private Label label11;
        private Label label12;
        private TextBox txtPhone;
        private TextBox txtNumber;
        private TextBox txtLastName;
        private Button button6;
        private Button button5;
        private Button btnMemberImage;
        private PictureBox pictureBox1;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Panel panelBooks;
        private Label label18;
        private Label label19;
        private TextBox txtBookName;
        private TextBox txtAuthor;
        private TextBox txtSubject;
        private TextBox txtShabak;
        private TextBox txtPublication;
        private TextBox txtYear;
        private TextBox txtTranslator;
        private PictureBox pictureBox2;
        private Button button7;
        private Button button9;
        private Button button8;
        private System.Windows.Forms.Timer timer1;
    }
}
