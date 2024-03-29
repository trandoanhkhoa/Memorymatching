using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memorymatching
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTaoForm_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = int.Parse(txtSodong.Text);
                int cot = int.Parse(txtSocot.Text);
                //Tạo ra form xuất
                if((dong*cot)%2!=0)
                {
                    MessageBox.Show("Dòng x cột phải là số chẳn. Vui lòng nhập lại !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }    

                FrmXuat frm = new FrmXuat(dong, cot);
                //Hiển thị form lên bằng phương thức ShowDialog
                frm.ShowDialog();

                //frm.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Input sai. Vui lòng nhập lại!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }
    }
}
