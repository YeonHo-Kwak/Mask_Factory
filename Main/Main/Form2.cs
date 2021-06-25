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
    public partial class Form2 : Form
    {
        OracleCommand cmd;
        public Form2()
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

            OracleSerch();
        }

        void OracleSerch()
        {
            //////////////////////////////////////////줄////////////////////////////////////////
            cmd.CommandText = "select vol from m_factory where ID = 101";
            OracleDataReader strap = cmd.ExecuteReader();
            while (strap.Read())
            {
                int vol = strap.GetInt32(0);
                pb_line.Value = vol;
            }
            /////////////////////////////////////코 받침//////////////////////////////////////////
            cmd.CommandText = "select vol from m_factory where ID = 201";
            OracleDataReader nose = cmd.ExecuteReader();
            while (nose.Read())
            {
                int vol = nose.GetInt32(0);
                pb_nose.Value = vol;
            }
            /////////////////////////////////////겉감/////////////////////////////////////////////
            // dental outshell
            cmd.CommandText = "select vol from m_factory where ID = 301";
            OracleDataReader shell = cmd.ExecuteReader();
            while (shell.Read())
            {
                int vol = shell.GetInt32(0);
                outshell_dental.Value = vol;
            }
            // 80 outshell
            cmd.CommandText = "select vol from m_factory where ID = 302";
            OracleDataReader shell2 = cmd.ExecuteReader();
            while (shell2.Read())
            {
                int vol = shell2.GetInt32(0);
                outshell_80.Value = vol;
            }
            // 94 outshell
            cmd.CommandText = "select vol from m_factory where ID = 303";
            OracleDataReader shell3 = cmd.ExecuteReader();
            while (shell3.Read())
            {
                int vol = shell3.GetInt32(0);
                outshell_94.Value = vol;
            }
            // ad outshell
            cmd.CommandText = "select vol from m_factory where ID = 304";
            OracleDataReader shell4 = cmd.ExecuteReader();
            while (shell4.Read())
            {
                int vol = shell4.GetInt32(0);
                outshell_ad.Value = vol;
            }
            // dust outshell
            cmd.CommandText = "select vol from m_factory where ID = 305";
            OracleDataReader shell5 = cmd.ExecuteReader();
            while (shell5.Read())
            {
                int vol = shell5.GetInt32(0);
                outshell_dp.Value = vol;
            }
            /////////////////////////////////////필터/////////////////////////////////////////////
            //Dental filter
            cmd.CommandText = "select vol from m_factory where ID = 401";
            OracleDataReader fil1 = cmd.ExecuteReader();
            while (fil1.Read())
            {
                int vol = fil1.GetInt32(0);
                filter_dental.Value = vol;
            }
            //
            //KF80 filter
            cmd.CommandText = "select vol from m_factory where ID = 402";
            OracleDataReader fil2 = cmd.ExecuteReader();
            while (fil2.Read())
            {
                int vol = fil2.GetInt32(0);
                filter_80.Value = vol;
            }
            //KF94 filter
            cmd.CommandText = "select vol from m_factory where ID = 403";
            OracleDataReader fil3 = cmd.ExecuteReader();
            while (fil3.Read())
            {
                int vol = fil3.GetInt32(0);
                filter_94.Value = vol;
            }
            //AD filter
            cmd.CommandText = "select vol from m_factory where ID = 404";
            OracleDataReader fil4 = cmd.ExecuteReader();
            while (fil4.Read())
            {
                int vol = fil4.GetInt32(0);
                filter_ad.Value = vol;
            }
            //Dust filter
            cmd.CommandText = "select vol from m_factory where ID = 405";
            OracleDataReader fil5 = cmd.ExecuteReader();
            while (fil5.Read())
            {
                int vol = fil5.GetInt32(0);
                filter_dp.Value = vol;
            }
            ////////////////////////////////////////////완성///////////////////////////////////////////////////
            // dental
            cmd.CommandText = "select vol from m_factory where ID = 701";
            OracleDataReader g_den = cmd.ExecuteReader();
            while (g_den.Read())
            {
                int vol = g_den.GetInt32(0);
                goods_dental.Value = vol;
            }
            // 80
            cmd.CommandText = "select vol from m_factory where ID = 702";
            OracleDataReader g_80 = cmd.ExecuteReader();
            while (g_80.Read())
            {
                int vol = g_80.GetInt32(0);
                goods_80.Value = vol;
            }
            // 94
            cmd.CommandText = "select vol from m_factory where ID = 703";
            OracleDataReader g_94 = cmd.ExecuteReader();
            while (g_94.Read())
            {
                int vol = g_94.GetInt32(0);
                goods_94.Value = vol;
            }
            // ad
            cmd.CommandText = "select vol from m_factory where ID = 704";
            OracleDataReader g_ad = cmd.ExecuteReader();
            while (g_ad.Read())
            {
                int vol = g_ad.GetInt32(0);
                goods_ad.Value = vol;
            }
            // dust
            cmd.CommandText = "select vol from m_factory where ID = 705";
            OracleDataReader g_dust = cmd.ExecuteReader();
            while (g_dust.Read())
            {
                int vol = g_dust.GetInt32(0);
                goods_dp.Value = vol;
            }
        }
            

        private void btn_re_Click(object sender, EventArgs e)
        {
            OracleSerch();
        }

        
        private void pb_line_MouseHover_1(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pb_line, $"{Convert.ToInt32(pb_line.Value)}/100");
        }

        private void pb_nose_MouseHover(object sender, EventArgs e)
        {
            toolTip2.SetToolTip(pb_nose, $"{Convert.ToInt32(pb_nose.Value)}/100");
        }

        private void goods_dental_MouseHover(object sender, EventArgs e)
        {
            toolTip3.SetToolTip(goods_dental, $"{Convert.ToInt32(goods_dental.Value)}/100");
        }

        private void filter_dental_MouseHover(object sender, EventArgs e)
        {
            toolTip3.SetToolTip(filter_dental, $"{Convert.ToInt32(filter_dental.Value)}/100");
        }

        private void outshell_dental_MouseHover(object sender, EventArgs e)
        {
            toolTip4.SetToolTip(outshell_dental, $"{Convert.ToInt32(outshell_dental.Value)}/100");
        }
    }
}
