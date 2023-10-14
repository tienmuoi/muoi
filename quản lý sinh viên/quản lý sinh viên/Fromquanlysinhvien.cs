using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quản_lý_sinh_viên
{
    public partial class Fromquanlysinhvien : Form
    {
        public Fromquanlysinhvien()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           FromDangkysinhvien   f=new FromDangkysinhvien();
            f.ShowDialog();
        }
    }
}
