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
    public partial class Form1 : Form
    {

        //상태
        int state = 1;
        bool flag = false;

        string strConn = "Data Source=(DESCRIPTION=" +
            "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)" +
            "(HOST=localhost)(PORT=1521)))" +
            "(CONNECT_DATA=(SERVER=DEDICATED)" +
            "(SERVICE_NAME=xe)))" +
            ";User Id=hr;Password=hr;";

        OracleConnection conn;
        OracleCommand cmd;
        //재료
        int str, wir,
            out_den, out_80, out_94, out_ad, out_du,
            fil_den, fil_80, fil_94, fil_ad, fil_du = 0;

        //완제품
        int mask_den, mask_80, mask_94, mask_ad, mask_du = 0;

        Form4 form4;



        public Form1()
        {
            InitializeComponent();
            conn = new OracleConnection(strConn);
            conn.Open();
            cmd = new OracleCommand();
            cmd.Connection = conn;
            search();
            pictureBox6.Hide();
            pictureBox7.Hide();
            pictureBox8.Hide();
            pictureBox10.Hide();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            conn.Close();
        }
        void Step1()
        {

            string mask = selectitem.Text;

            if (mask == "Dental")
            {
                out_den = out_den - 1;
            }
            else if (mask == "KF-80")
            {
                out_80 = out_80 - 1;
            }
            else if (mask == "KF-94")
            {
                out_94 = out_94 - 1;
            }
            else if (mask == "KF-AD")
            {
                out_ad = out_ad - 1;
            }
            else if (mask == "Dust Protective")
            {
                out_du = out_du - 1;
            }

            save();
            search();
            move1();
            Application.DoEvents();
            Thread.Sleep(100);
            Application.DoEvents();
            Thread.Sleep(100);
            Application.DoEvents();
            Thread.Sleep(100);
            Application.DoEvents();
            Thread.Sleep(100);
            Application.DoEvents();
            Thread.Sleep(100);
            state++;
        }

        void Step2()
        {

            string mask = selectitem.Text;

            if (mask == "Dental")
            {
                fil_den = fil_den - 1;
            }
            else if (mask == "KF-80")
            {
                fil_80 = fil_80 - 1;
            }
            else if (mask == "KF-94")
            {
                fil_94 = fil_94 - 1;
            }
            else if (mask == "KF-AD")
            {
                fil_ad = fil_ad - 1;
            }
            else if (mask == "Dust Protective")
            {
                fil_du = fil_du - 1;
            }

            save();
            search();
            move2();
            Application.DoEvents();
            Thread.Sleep(100);
            Application.DoEvents();
            Thread.Sleep(100);
            Application.DoEvents();
            Thread.Sleep(100);
            Application.DoEvents();
            Thread.Sleep(100);
            Application.DoEvents();
            Thread.Sleep(100);
            state++;
        }

        void Step3()
        {

            string mask = selectitem.Text;

            if (mask == "Dental")
            {
                str = str - 1;
            }
            else if (mask == "KF-80")
            {
                str = str - 1;
            }
            else if (mask == "KF-94")
            {
                str = str - 1;
            }
            else if (mask == "KF-AD")
            {
                str = str - 1;
            }
            else if (mask == "Dusk Protective")
            {
                str = str - 1;
            }

            save();
            search();
            move3();
            Application.DoEvents();
            Thread.Sleep(100);
            Application.DoEvents();
            Thread.Sleep(100);
            Application.DoEvents();
            Thread.Sleep(100);
            Application.DoEvents();
            Thread.Sleep(100);
            Application.DoEvents();
            Thread.Sleep(100);
            state++;
        }

        void Step4()
        {

            string mask = selectitem.Text;

            if (mask == "Dental")
            {
                wir = wir - 1;
                mask_den = mask_den + 1;
            }
            else if (mask == "KF-80")
            {
                wir = wir - 1;
                mask_80 = mask_80 + 1;
            }
            else if (mask == "KF-94")
            {
                wir = wir - 1;
                mask_94 = mask_94 + 1;
            }
            else if (mask == "KF-AD")
            {
                wir = wir - 1;
                mask_ad = mask_ad + 1;
            }
            else if (mask == "Dust Protective")
            {
                wir = wir - 1;
                mask_du = mask_du + 1;
            }

            save();
            search();
            move4();
            Application.DoEvents();
            Thread.Sleep(100);
            Application.DoEvents();
            Thread.Sleep(100);
            Application.DoEvents();
            Thread.Sleep(100);
            Application.DoEvents();
            Thread.Sleep(100);
            Application.DoEvents();
            Thread.Sleep(100);


            search();
            save();
            move5();
            state = 1;

        }


        private void btn_stock_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void btn_order_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void btn_made_Click(object sender, EventArgs e)
        {
            form4 = new Form4();
            form4.FormSendEvent += new Form4.FormSendDataHandler(DieaseUpdateEventMethod);
            form4.Show();
        }

        private void btn_restart_Click(object sender, EventArgs e)
        {
            flag = false;
            Run();
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            flag = true;
        }

        private void btn_sell_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.FormSendEvent += new Form5.FormSendDataHandler(truckmove);
            form5.Show();
        }

        private void truckmove(int sender)
        {
            int T_Move = (int)sender;
            if(T_Move==1)
            {
                int i=870;
                int j = 346;


                while (i < 1200)
                {
                    i += 40;
                    Application.DoEvents();
                    Thread.Sleep(30);
                    pictureBox11.Location = new Point(i, j);
                }
            }
            Application.DoEvents();
            Thread.Sleep(1000);
            Application.DoEvents();
            Thread.Sleep(1000);
            
            T_Move = 0;
            pictureBox11.Location = new Point(870, 346);
            Application.DoEvents();
        }

        private void DieaseUpdateEventMethod(object sender)
        {
            string[] arr = ((string)sender).Split('/');
            selectitem.Text = arr[0];
            maketime.Text = arr[1];
            form4.Close();
            flag = false;
            Run();
        }

        private void Wait()
        {
            Application.DoEvents();
            Thread.Sleep(100);
        }

        private void Run()
        {
            search();
            for (; Convert.ToInt32(maketime.Text) > 0; maketime.Text = (Convert.ToInt32(maketime.Text) - 1).ToString())
            {
                string mask = selectitem.Text;

                if (mask == "Dental")
                {
                    if (out_den < 1)
                    {
                        flag = true;
                        MessageBox.Show("겉감이 부족합니다.");
                        break;
                    }

                    else if (fil_den < 1)
                    {
                        flag = true;
                        MessageBox.Show("필터가 부족합니다.");
                        break;
                    }

                    else if (str < 1)
                    {
                        flag = true;
                        MessageBox.Show("끈이 부족합니다.");
                        break;
                    }

                    else if (wir < 1)
                    {
                        flag = true;
                        MessageBox.Show("코받침이 부족합니다.");
                        break;
                    }
                }

                else if (mask == "KF-80")
                {
                    if (out_80 < 1)
                    {
                        flag = true;
                        MessageBox.Show("겉감이 부족합니다.");
                        break;
                    }

                    else if (fil_80 < 1)
                    {
                        flag = true;
                        MessageBox.Show("필터가 부족합니다.");
                        break;
                    }

                    else if (str < 1)
                    {
                        flag = true;
                        MessageBox.Show("끈이 부족합니다.");
                        break;
                    }

                    else if (wir < 1)
                    {
                        flag = true;
                        MessageBox.Show("코받침이 부족합니다.");
                        break;
                    }
                }
                else if (mask == "KF-94")
                {
                    if (out_94 < 1)
                    {
                        flag = true;
                        MessageBox.Show("겉감이 부족합니다.");
                        break;
                    }

                    if (fil_94 < 1)
                    {
                        flag = true;
                        MessageBox.Show("필터가 부족합니다.");
                        break;
                    }

                    if (str < 1)
                    {
                        flag = true;
                        MessageBox.Show("끈이 부족합니다.");
                        break;
                    }

                    if (wir < 1)
                    {
                        flag = true;
                        MessageBox.Show("코받침이 부족합니다.");
                        break;
                    }
                }

                else if (mask == "KF-AD")
                {
                    if (out_ad < 1)
                    {
                        flag = true;
                        MessageBox.Show("겉감이 부족합니다.");
                        break;
                    }

                    if (fil_ad < 1)
                    {
                        flag = true;
                        MessageBox.Show("필터가 부족합니다.");
                        break;
                    }

                    if (str < 1)
                    {
                        flag = true;
                        MessageBox.Show("끈이 부족합니다.");
                        break;
                    }

                    if (wir < 1)
                    {
                        flag = true;
                        MessageBox.Show("코받침이 부족합니다.");
                        break;
                    }
                }

                else if (mask == "Dust Protective")
                {
                    if (out_du < 1)
                    {
                        flag = true;
                        MessageBox.Show("겉감이 부족합니다.");
                        break;
                    }

                    if (fil_du < 1)
                    {
                        flag = true;
                        MessageBox.Show("필터가 부족합니다.");
                        break;
                    }

                    if (str < 1)
                    {
                        flag = true;
                        MessageBox.Show("끈이 부족합니다.");
                        break;
                    }

                    if (wir < 1)
                    {
                        flag = true;
                        MessageBox.Show("코받침이 부족합니다.");
                        break;
                    }
                }
                while (flag)
                    Wait();
                if (state == 1)
                {
                    Step1();
                    while (flag)
                        Wait();
                }
                if (state == 2)
                {
                    Step2();
                    while (flag)
                        Wait();
                }
                if (state == 3)
                {
                    Step3();
                    while (flag)
                        Wait();
                }
                if (state == 4)
                {
                    Step4();
                    while (flag)
                        Wait();
                }

            }
        }

        private void move1()
        {
            int i, j;

            i = 79;
            j = 180;
            pictureBox2.Location = new Point(i, j);
            pictureBox2.Visible = true;

            while (j < 400)
            {
                j += 32;
                Application.DoEvents();
                Thread.Sleep(30);
                pictureBox2.Location = new Point(i, j);
            }
            
            while (i < 279)
            {
                pictureBox10.Show();
                Application.DoEvents();                
                i += 20;
                Application.DoEvents();
                Thread.Sleep(20);
                pictureBox2.Location = new Point(i, j);
                pictureBox10.Hide();
                Application.DoEvents();
                
            }
        }
        

        private void move2()
        {
            int i, j;

            i = 259;
            j = 180;
            pictureBox3.Location = new Point(i, j);
            pictureBox3.Visible = true;

            while (j < 400)
            {
                j += 32;
                Application.DoEvents();
                Thread.Sleep(30);
                pictureBox3.Location = new Point(i, j);
            }

            
            pictureBox2.Hide();           
            pictureBox3.Hide();
            
            
            pictureBox6.Show();
            Application.DoEvents();
            move2_1();
        }

        private void move2_1()
        {
            
            int i, j;
            i = 259;
            j = 400;            
            

            while (i < 479)
            {
                pictureBox10.Show();
                Application.DoEvents();
                
                i += 20;
                Application.DoEvents();
                Thread.Sleep(20);
                pictureBox10.Hide();
                Application.DoEvents();
                

                pictureBox6.Location = new Point(i, j);                
            }
        }

        private void move3()
        {
            int i, j;
            i = 459;
            j = 180;
            pictureBox5.Location = new Point(i, j);
            pictureBox5.Visible = true;

            while (j < 400)
            {
                j += 32;
                Application.DoEvents();
                Thread.Sleep(30);
                pictureBox5.Location = new Point(i, j);
            }

            pictureBox5.Hide();
            pictureBox6.Hide();


            pictureBox7.Show();
            Application.DoEvents();

            move3_1();
        }

        private void move3_1()
        {
            int i, j;
            i = 459;
            j = 400;


            while (i < 679)
            {
                pictureBox10.Show();
                Application.DoEvents();
                i += 20;
                Application.DoEvents();
                Thread.Sleep(20);

                pictureBox10.Hide();
                Application.DoEvents();
                pictureBox7.Location = new Point(i, j);
            }
        }
        private void move4()
        {
            int i, j;
            i = 659;
            j = 194;
            pictureBox4.Location = new Point(i, j);
            pictureBox4.Visible = true;

            while (j < 400)
            {
                j += 32;
                Application.DoEvents();
                Thread.Sleep(30);
                pictureBox4.Location = new Point(i, j);
            }

            pictureBox7.Hide();
            pictureBox4.Hide();

            pictureBox8.Show();
            Application.DoEvents();

            move4_1();
        }

        private void move4_1()
        {
            int i, j;
            i = 659;
            j = 400;


            while (i < 879)
            {
                pictureBox10.Show();
                Application.DoEvents();
                i += 20;
                Application.DoEvents();
                Thread.Sleep(20);
                pictureBox10.Hide();
                Application.DoEvents();
                pictureBox8.Location = new Point(i, j);
            }
        }
        private void move5()
        {           
            pictureBox2.Location = new Point(79, 180);
            pictureBox2.Show();

            pictureBox3.Location = new Point(284, 190);
            pictureBox3.Show();

            pictureBox5.Location = new Point(459, 180);
            pictureBox5.Show();

            pictureBox4.Location = new Point(674, 194);
            pictureBox4.Show();

            pictureBox6.Location = new Point(259, 400);
            pictureBox7.Location = new Point(459, 400);
            pictureBox8.Location = new Point(659, 400);
            pictureBox8.Hide();
        }
        void search() //조회
        {
            //끈
            cmd.CommandText = "select VOL from m_factory where ID = 101";
            OracleDataReader rdr1 = cmd.ExecuteReader();

            while (rdr1.Read())
            {
                int Vol = rdr1.GetInt32(0);
                str = Vol;
            }

            //코받침
            cmd.CommandText = "select VOL from m_factory where ID = 201";
            OracleDataReader rdr2 = cmd.ExecuteReader();

            while (rdr2.Read())
            {
                int Vol = rdr2.GetInt32(0);
                wir = Vol;
            }

            //덴탈 겉감
            cmd.CommandText = "select VOL from m_factory where ID = 301";
            OracleDataReader rdr3 = cmd.ExecuteReader();

            while (rdr3.Read())
            {
                int Vol = rdr3.GetInt32(0);
                out_den = Vol;
            }

            //덴탈 필터
            cmd.CommandText = "select VOL from m_factory where ID = 401";
            OracleDataReader rdr4 = cmd.ExecuteReader();

            while (rdr4.Read())
            {
                int Vol = rdr4.GetInt32(0);
                fil_den = Vol;
            }

            //kf80 겉감
            cmd.CommandText = "select VOL from m_factory where ID = 302";
            OracleDataReader rdr5 = cmd.ExecuteReader();

            while (rdr5.Read())
            {
                int Vol = rdr5.GetInt32(0);
                out_80 = Vol;
            }

            //kf80 필터
            cmd.CommandText = "select VOL from m_factory where ID = 402";
            OracleDataReader rdr6 = cmd.ExecuteReader();

            while (rdr6.Read())
            {
                int Vol = rdr6.GetInt32(0);
                fil_80 = Vol;
            }

            //kf94 겉감
            cmd.CommandText = "select VOL from m_factory where ID = 303";
            OracleDataReader rdr7 = cmd.ExecuteReader();

            while (rdr7.Read())
            {
                int Vol = rdr7.GetInt32(0);
                out_94 = Vol;
            }

            //kf94 필터
            cmd.CommandText = "select VOL from m_factory where ID = 403";
            OracleDataReader rdr8 = cmd.ExecuteReader();

            while (rdr8.Read())
            {
                int Vol = rdr8.GetInt32(0);
                fil_94 = Vol;
            }

            //ad 겉감
            cmd.CommandText = "select VOL from m_factory where ID = 304";
            OracleDataReader rdr9 = cmd.ExecuteReader();

            while (rdr9.Read())
            {
                int Vol = rdr9.GetInt32(0);
                out_ad = Vol;
            }

            //ad 필터
            cmd.CommandText = "select VOL from m_factory where ID = 404";
            OracleDataReader rdr10 = cmd.ExecuteReader();

            while (rdr10.Read())
            {
                int Vol = rdr10.GetInt32(0);
                fil_ad = Vol;
            }

            //dust 겉감
            cmd.CommandText = "select VOL from m_factory where ID = 305";
            OracleDataReader rdr11 = cmd.ExecuteReader();

            while (rdr11.Read())
            {
                int Vol = rdr11.GetInt32(0);
                out_du = Vol;
            }

            //dust 필터
            cmd.CommandText = "select VOL from m_factory where ID = 405";
            OracleDataReader rdr12 = cmd.ExecuteReader();

            while (rdr12.Read())
            {
                int Vol = rdr12.GetInt32(0);
                fil_du = Vol;
            }

            //dental 완제품
            cmd.CommandText = "select VOL from m_factory where ID = 701";
            OracleDataReader rdr13 = cmd.ExecuteReader();

            while (rdr13.Read())
            {
                int Vol = rdr13.GetInt32(0);
                mask_den = Vol;
            }

            //kf80 완제품
            cmd.CommandText = "select VOL from m_factory where ID = 702";
            OracleDataReader rdr14 = cmd.ExecuteReader();

            while (rdr14.Read())
            {
                int Vol = rdr14.GetInt32(0);
                mask_80 = Vol;
            }

            //kf94 완제품
            cmd.CommandText = "select VOL from m_factory where ID = 703";
            OracleDataReader rdr15 = cmd.ExecuteReader();

            while (rdr15.Read())
            {
                int Vol = rdr15.GetInt32(0);
                mask_94 = Vol;
            }

            cmd.CommandText = "select VOL from m_factory where ID = 704";
            OracleDataReader rdr16 = cmd.ExecuteReader();

            while (rdr16.Read())
            {
                int Vol = rdr16.GetInt32(0);
                mask_ad = Vol;
            }

            cmd.CommandText = "select VOL from m_factory where ID = 705";
            OracleDataReader rdr17 = cmd.ExecuteReader();

            while (rdr17.Read())
            {
                int Vol = rdr17.GetInt32(0);
                mask_du = Vol;
            }

        }
        private void save() // 저장
        {
            //끈
            cmd.CommandText = $"update m_factory set vol = {str} where ID = 101";
            cmd.ExecuteNonQuery();
            //코받침
            cmd.CommandText = $"update m_factory set vol = {wir} where ID = 201";
            cmd.ExecuteNonQuery();
            //덴탈 겉감            
            cmd.CommandText = $"update m_factory set vol = {out_den} where ID = 301";
            cmd.ExecuteNonQuery();
            //덴탈 필터       
            cmd.CommandText = $"update m_factory set vol = {fil_den} where ID = 401";
            cmd.ExecuteNonQuery();
            //덴탈 완제품 
            cmd.CommandText = $"update m_factory set vol = {mask_den} where ID = 701";
            cmd.ExecuteNonQuery();
            //k80 겉감            
            cmd.CommandText = $"update m_factory set vol = {out_80} where ID = 302";
            cmd.ExecuteNonQuery();
            //k80 필터     
            cmd.CommandText = $"update m_factory set vol = {fil_80} where ID = 402";
            cmd.ExecuteNonQuery();
            //k80 완제품 
            cmd.CommandText = $"update m_factory set vol = {mask_80} where ID = 702";
            cmd.ExecuteNonQuery();
            //k94 겉감            
            cmd.CommandText = $"update m_factory set vol = {out_94} where ID = 303";
            cmd.ExecuteNonQuery();
            //k94 필터     
            cmd.CommandText = $"update m_factory set vol = {fil_94} where ID = 403";
            cmd.ExecuteNonQuery();
            //k94 완제품  
            cmd.CommandText = $"update m_factory set vol = {mask_94} where ID = 703";
            cmd.ExecuteNonQuery();
            //ad 겉감            
            cmd.CommandText = $"update m_factory set vol = {out_ad} where ID = 304";
            cmd.ExecuteNonQuery();
            //ad 필터     
            cmd.CommandText = $"update m_factory set vol = {fil_ad} where ID = 404";
            cmd.ExecuteNonQuery();
            //ad 완제품     
            cmd.CommandText = $"update m_factory set vol = {mask_ad} where ID = 704";
            cmd.ExecuteNonQuery();
            //dust 겉감            
            cmd.CommandText = $"update m_factory set vol = {out_du} where ID = 305";
            cmd.ExecuteNonQuery();
            //dust 필터     
            cmd.CommandText = $"update m_factory set vol = {fil_du} where ID = 405";
            cmd.ExecuteNonQuery();
            //dust 완제품     
            cmd.CommandText = $"update m_factory set vol = {mask_du} where ID = 705";
            cmd.ExecuteNonQuery();
        }
      
    }
}
