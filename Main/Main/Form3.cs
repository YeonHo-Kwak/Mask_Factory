using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
    public partial class Form3 : Form
    {
        OracleCommand cmd;
        

        List<cl_mask> M_list = new List<cl_mask>();
        public Form3()
        {
            InitializeComponent();

            string strConn = "Data Source=(DESCRIPTION=" +
                "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)" +
                "(HOST=localhost)(PORT=1521)))" +
                "(CONNECT_DATA=(SERVER=DEDICATED)" +
                "(SERVICE_NAME=xe)))" +
                ";User Id=hr;Password=hr;";

            OracleConnection conn = new OracleConnection(strConn);
            conn.Open();

            cmd = new OracleCommand();
            cmd.Connection = conn;
        }     

        private void tb_order_Click(object sender, EventArgs e)
        {
            int[] txtnum = new int[]
            {
                int.Parse(tb_line.Text), int.Parse(tb_nose.Text), int.Parse(tb_outshell_dental.Text), int.Parse(tb_outshell_80.Text),
                int.Parse(tb_outshell_94.Text), int.Parse(tb_outshell_ad.Text), int.Parse(tb_outshell_dp.Text), int.Parse(tb_filter_dental.Text),
                int.Parse(tb_filter_80.Text), int.Parse(tb_filter_94.Text), int.Parse(tb_filter_ad.Text),int.Parse(tb_filter_dp.Text)
            };
            cmd.CommandText = "select * from m_factory where rownum<13 order by id";
            OracleDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                string ID = rdr["ID"].ToString();
                string NAME = rdr["NAME"].ToString();
                string VOL = rdr["VOL"].ToString();
                string PRICE = rdr["PRICE"].ToString();

                M_list.Add(new cl_mask(ID, NAME, VOL, PRICE));
            }

            for (int k = 0; k < M_list.Count; k++)
            {
                int total_mask = int.Parse(M_list[k].VOL) + txtnum[k];
                if (total_mask > 100)
                {
                    MessageBox.Show($"{M_list[k].NAME}이 {total_mask - 100}개 초과하였습니다.");
                }
            }
            Thread.Sleep(100);
            for (int k = 0; k < M_list.Count; k++)
            {
                cmd.CommandText = $"update m_factory set VOL = (CASE WHEN VOL+{txtnum[k]} >= 100 THEN 100 ELSE VOL+{txtnum[k]} END) where ID = {M_list[k].ID}";
                cmd.ExecuteNonQuery();
            }


            
            this.Close();
        }
    }
}
