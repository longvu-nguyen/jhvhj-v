using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Hi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private Form currentFormChild;

        private void OpenChildForm(Form childForm)
        {
            // Đóng form hiện tại nếu có
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }

            // Gán form mới cho currentFormChild
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            // Xóa các điều khiển cũ trong panel3
            panel3.Controls.Clear();
            panel3.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new product());
            label1.Text = button1.Text;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {


        }
        private void LoadFormIntoPanel(UserControl userControl)
        {

        }


        private void addUserControl(UserControl userControl)
        {
            ;
        }
        private void bt3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CustomerManagement());
            label1.Text = bt3.Text;

        }

        private void bt2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new EmployeeManagement());
            label1.Text = bt2.Text;

        }

        private void bt4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Statistics());
            label1.Text = bt4.Text;

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
