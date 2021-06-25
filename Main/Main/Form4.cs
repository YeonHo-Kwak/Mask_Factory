using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
    public partial class Form4 : Form
    {
        public delegate void FormSendDataHandler(string sendstring);
        public event FormSendDataHandler FormSendEvent;
        private string selected = "";
        private string num = "";

        public Form4()
        {
            InitializeComponent();           
        }

        private void btn_make_Click(object sender, EventArgs e)
        {
            if (selected != "")
            {
                num = tb_make.Text;
                if (num != "")
                {
                    this.FormSendEvent($"{selected}/{num}");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("제작할 제품 선택", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rdo_type_dental_CheckedChanged(object sender, EventArgs e)
        {
            selected = rdo_type_dental.Text;
        }

        private void rdo_type_80_CheckedChanged(object sender, EventArgs e)
        {
            selected = rdo_type_80.Text;
        }

        private void rdo_type_94_CheckedChanged(object sender, EventArgs e)
        {
            selected = rdo_type_94.Text;
        }

        private void rdo_type_ad_CheckedChanged(object sender, EventArgs e)
        {
            selected = rdo_type_ad.Text;
        }

        private void rdo_type_dp_CheckedChanged(object sender, EventArgs e)
        {
            selected = rdo_type_dp.Text;
        }        
    }
}
