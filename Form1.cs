namespace WinFormsApp26
{
    public partial class Form1 : Form
    {
        string memberName;
        string memberPhone;
        string memberImage;
        string memberCode;
        string memberLastName;
        string memberNumber;
        string memberAddress;
        string bookName;
        string bookAuthor;
        string bookTranslator;
        string bookPublication;
        string bookyear;
        string bookSubject;
        string bookShabk;
        string bookImage;
        string search;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox4.Enabled = false;
            textBox3.Enabled = false;
            textBox2.Enabled = false;
            textBox1.Focus();

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox4.Enabled = false;
            textBox3.Enabled = false;
            textBox2.Focus();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox4.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Focus();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";

            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;

            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;

            MessageBox.Show("Fields Cleared Successfully");
        }
        

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image = Image.FromFile(ofd.FileName);
                bookImage = ofd.FileName;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)

        {
            this.Text = "Library Platform" + DateTime.Now.ToString();
            panelMembers.Enabled = false;
            panelBooks.Enabled = false;

        }
        public void EnableAdminPanels()
        {
            panelMembers.Enabled = true;
            panelBooks.Enabled = true;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Form2Login login = new Form2Login(this);
            login.ShowDialog();




        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
                memberImage = ofd.FileName;

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            memberCode = txtCode.Text;
            memberName = txtName.Text;
            memberLastName = txtLastName.Text;
            memberNumber = txtNumber.Text;
            memberPhone = txtPhone.Text;
            memberAddress = txtAddress.Text;
            MessageBox.Show("Member saved");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtCode.Clear();
            txtName.Clear();
            txtLastName.Clear();
            txtNumber.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
            pictureBox1.Image = null;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            bookName = txtBookName.Text;
            bookAuthor = txtAuthor.Text;
            bookTranslator = txtTranslator.Text;
            bookPublication = txtPublication.Text;
            bookyear = txtYear.Text;
            bookSubject = txtSubject.Text;
            bookShabk = txtShabak.Text;
            MessageBox.Show("Book saved successfully");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtBookName.Clear();
            txtAuthor.Clear();
            txtTranslator.Clear();
            txtPublication.Clear();
            txtYear.Clear();
            txtSubject.Clear();
            txtShabak.Clear();
            pictureBox2.Image = null;

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Focus();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                MessageBox.Show("Searching for Book by Name:" + textBox1.Text);
            }
            else if (radioButton2.Checked)
            {
                MessageBox.Show("Searching for Author:" + textBox4.Text);
         }
            else if(radioButton3.Checked)
            {
                MessageBox.Show("Searching for Subject" + textBox2.Text);
            }
            else if (radioButton4.Checked)
            {
                MessageBox.Show("Searching book by Year" + textBox3.Text);
            }
            else
            {
                MessageBox.Show("Please select a Search Type");
            }
        }
    }
}
