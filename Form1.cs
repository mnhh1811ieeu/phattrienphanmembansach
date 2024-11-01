using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Phát_triển_phần_mềm_bán_sách
{
    public partial class Form1 : Form
    {
        private DataProvider dataProvider = new DataProvider();
        public Form1()
        {
            InitializeComponent();
            init();
        }
        private void init()
        {
            initSach();
        }
        private void initSach()
        {
            loaddgSach();
        }
        private void loaddgSach()
        {
            DataTable dt = new DataTable();
            StringBuilder query= new StringBuilder("SELECT * FROM Sach");
            dt= dataProvider.execQuery(query.ToString());
            dgSach.DataSource = dt;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void dgSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgSach_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void datePhieunhapNgaylapphieunhap_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
