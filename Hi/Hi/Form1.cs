using System.Xml.Linq;

namespace Hi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult check_Exit = MessageBox.Show("bạn có muốn exit khum ?", "confrim", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textname_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btlogin_Click(object sender, EventArgs e)
        {
            string usename = txtname.Text;//ten se lay gia tri tu o ten minh nhap tu ban phim
            string password = txtpass.Text;
            string[] list = { "'", ":" };
            if (usename == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (password == "")
                {
                    MessageBox.Show("Mật khẩu không chính xác hoặc có các kí tự đặc biệt", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
           
                        Form2 form2 = new Form2();
                        form2.ShowDialog();
                        this.Hide();
                
                }
            }

        }
    }
}
