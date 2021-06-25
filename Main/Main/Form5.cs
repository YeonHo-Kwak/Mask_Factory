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
    public partial class Form5 : Form
    {
        public delegate void FormSendDataHandler(int sendstring);
        public event FormSendDataHandler FormSendEvent;
        private int T_move = 0;

        OracleCommand cmd;

        void sell_mask()
        {
            cmd.CommandText = "select vol from m_factory where ID = 801";
            OracleDataReader tb_dental = cmd.ExecuteReader();
            while (tb_dental.Read())
            {
                int vol = tb_dental.GetInt32(0);
                tb_goods_dental.Text = vol.ToString();
            }

            cmd.CommandText = "select vol from m_factory where ID = 802";
            OracleDataReader tb_80 = cmd.ExecuteReader();
            while (tb_80.Read())
            {
                int vol = tb_80.GetInt32(0);
                tb_goods_80.Text = vol.ToString();
            }

            cmd.CommandText = "select vol from m_factory where ID = 803";
            OracleDataReader tb_94 = cmd.ExecuteReader();
            while (tb_94.Read())
            {
                int vol = tb_94.GetInt32(0);
                tb_goods_94.Text = vol.ToString();
            }

            cmd.CommandText = "select vol from m_factory where ID = 804";
            OracleDataReader tb_ad = cmd.ExecuteReader();
            while (tb_ad.Read())
            {
                int vol = tb_ad.GetInt32(0);
                tb_goods_ad.Text = vol.ToString();
            }

            cmd.CommandText = "select vol from m_factory where ID = 805";
            OracleDataReader tb_dp = cmd.ExecuteReader();
            while (tb_dp.Read())
            {
                int vol = tb_dp.GetInt32(0);
                tb_goods_dp.Text = vol.ToString();
            }

            cmd.CommandText = "select vol from m_factory where ID = 901";
            OracleDataReader sell_dental = cmd.ExecuteReader();
            while (sell_dental.Read())
            {
                int vol = sell_dental.GetInt32(0);
                tb_price_dental.Text = vol.ToString();
            }

            cmd.CommandText = "select vol from m_factory where ID = 902";
            OracleDataReader sell_80 = cmd.ExecuteReader();
            while (sell_80.Read())
            {
                int vol = sell_80.GetInt32(0);
                tb_price_80.Text = vol.ToString();
            }

            cmd.CommandText = "select vol from m_factory where ID = 903";
            OracleDataReader sell_94 = cmd.ExecuteReader();
            while (sell_94.Read())
            {
                int vol = sell_94.GetInt32(0);
                tb_price_94.Text = vol.ToString();
            }

            cmd.CommandText = "select vol from m_factory where ID = 904";
            OracleDataReader sell_ad = cmd.ExecuteReader();
            while (sell_ad.Read())
            {
                int vol = sell_ad.GetInt32(0);
                tb_price_ad.Text = vol.ToString();
            }

            cmd.CommandText = "select vol from m_factory where ID = 905";
            OracleDataReader sell_dp = cmd.ExecuteReader();
            while (sell_dp.Read())
            {
                int vol = sell_dp.GetInt32(0);
                tb_price_dp.Text = vol.ToString();
            }

            cmd.CommandText = "select vol from m_factory where ID = 908";
            OracleDataReader sell_total = cmd.ExecuteReader();
            while (sell_total.Read())
            {
                int vol = sell_total.GetInt32(0);
                tb_total_goods.Text = vol.ToString();
            }

            cmd.CommandText = "select vol from m_factory where ID = 909";
            OracleDataReader sell_sales = cmd.ExecuteReader();
            while (sell_sales.Read())
            {
                int vol = sell_sales.GetInt32(0);
                tb_total_sales.Text = vol.ToString();
            }
        }

        public Form5()
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
            sell_mask();
        }

        private void btn_sales_Click(object sender, EventArgs e)
        {
            //dental_mask 완성품 출고
            int ordeo = int.Parse(tb_sell_dental.Text);
            cmd.CommandText = $"update m_factory set VOL = VOL - {ordeo} where ID = 701";
            cmd.ExecuteNonQuery();

            //k80_mask 완성품 출고
            int or80o = int.Parse(tb_sell_80.Text);
            cmd.CommandText = $"update m_factory set VOL = VOL - {or80o} where ID = 702";
            cmd.ExecuteNonQuery();

            //k94_mask 완성품 출고
            int or94o = int.Parse(tb_sell_94.Text);
            cmd.CommandText = $"update m_factory set VOL = VOL - {or94o} where ID = 703";
            cmd.ExecuteNonQuery();

            //ad_mask 완성품 출고
            int orado = int.Parse(tb_sell_ad.Text);
            cmd.CommandText = $"update m_factory set VOL = VOL - {orado} where ID = 704";
            cmd.ExecuteNonQuery();

            //dust_mask 완성품 출고
            int orduo = int.Parse(tb_sell_dp.Text);
            cmd.CommandText = $"update m_factory set VOL = VOL - {orduo} where ID = 705";
            cmd.ExecuteNonQuery();

            //dental_mask 판매갯수
            cmd.CommandText = $"update m_factory set VOL = VOL + {ordeo} where ID = 801";
            cmd.ExecuteNonQuery();

            //k80_mask 판매갯수
            cmd.CommandText = $"update m_factory set VOL = VOL + {or80o} where ID = 802";
            cmd.ExecuteNonQuery();

            //k94_mask 판매갯수
            cmd.CommandText = $"update m_factory set VOL = VOL + {or94o} where ID = 803";
            cmd.ExecuteNonQuery();

            //ad_mask 판매갯수
            cmd.CommandText = $"update m_factory set VOL = VOL + {orado} where ID = 804";
            cmd.ExecuteNonQuery();

            //dust_mask 판매갯수
            cmd.CommandText = $"update m_factory set VOL = VOL + {orduo} where ID = 805";
            cmd.ExecuteNonQuery();

            //dental_mask 매출액            
            cmd.CommandText = $"update m_factory set VOL = VOL + {ordeo} * 160 where ID = 901";
            cmd.ExecuteNonQuery();

            //k80_mask 매출액
            cmd.CommandText = $"update m_factory set VOL = VOL + {or80o} * 250 where ID = 902";
            cmd.ExecuteNonQuery();

            //k94_mask 매출액
            cmd.CommandText = $"update m_factory set VOL = VOL + {or94o} * 300 where ID = 903";
            cmd.ExecuteNonQuery();

            //ad_mask 매출액
            cmd.CommandText = $"update m_factory set VOL = VOL + {orado} * 200 where ID = 904";
            cmd.ExecuteNonQuery();

            //dust_mask 매출액
            cmd.CommandText = $"update m_factory set VOL = VOL + {orduo} * 890 where ID = 905";
            cmd.ExecuteNonQuery();

            //mask 총 판매갯수
            cmd.CommandText = $"update m_factory set VOL = VOL + {ordeo} + {or80o} + {or94o} + {orado} + {orduo} where ID = 908";
            cmd.ExecuteNonQuery();

            //mask 총 매출액
            cmd.CommandText = $"update m_factory set VOL = VOL + {ordeo} * 160 + {or80o} * 250 + {or94o} * 300 + {orado} * 200 + {orduo} * 890 where ID = 909";
            cmd.ExecuteNonQuery();

            T_move=1;
            this.FormSendEvent(T_move);
            sell_mask();
        }


 

        private void Form5_Load(object sender, EventArgs e)
        {
            sell_mask();
        }
    }
}
