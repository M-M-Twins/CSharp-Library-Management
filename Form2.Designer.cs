namespace WinFormsApp26
{
    partial class Form2Login
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
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            label2 = new Label();
            txtUser = new TextBox();
            txtPass = new TextBox();
            btnLogin = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("2  Compset", 12F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label1.Location = new Point(648, 40);
            label1.Name = "label1";
            label1.Size = new Size(90, 43);
            label1.TabIndex = 0;
            label1.Text = "نام کاربر:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("2  Compset", 12F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label2.Location = new Point(648, 129);
            label2.Name = "label2";
            label2.Size = new Size(89, 43);
            label2.TabIndex = 1;
            label2.Text = "گذرواژه:";
            // 
            // txtUser
            // 
            txtUser.Location = new Point(459, 43);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(183, 31);
            txtUser.TabIndex = 2;
            txtUser.TextChanged += textBox1_TextChanged;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(459, 129);
            txtPass.MaxLength = 8;
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(183, 31);
            txtPass.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("2  Compset", 12F, FontStyle.Bold, GraphicsUnit.Point, 178);
            btnLogin.Location = new Point(625, 316);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(112, 46);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "ورود";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("2  Compset", 12F, FontStyle.Bold, GraphicsUnit.Point, 178);
            btnExit.Location = new Point(364, 316);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(112, 46);
            btnExit.TabIndex = 5;
            btnExit.Text = "خروج";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form2Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(btnLogin);
            Controls.Add(txtPass);
            Controls.Add(txtUser);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.Black;
            Name = "Form2Login";
            RightToLeft = RightToLeft.Yes;
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Label label1;
        private Label label2;
        private TextBox txtUser;
        private TextBox txtPass;
        private Button btnLogin;
        private Button btnExit;
    }
}