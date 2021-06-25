
namespace Main
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_make = new System.Windows.Forms.TextBox();
            this.rdo_type_dp = new System.Windows.Forms.RadioButton();
            this.rdo_type_ad = new System.Windows.Forms.RadioButton();
            this.rdo_type_94 = new System.Windows.Forms.RadioButton();
            this.rdo_type_80 = new System.Windows.Forms.RadioButton();
            this.rdo_type_dental = new System.Windows.Forms.RadioButton();
            this.btn_make = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_make);
            this.groupBox1.Controls.Add(this.rdo_type_dp);
            this.groupBox1.Controls.Add(this.rdo_type_ad);
            this.groupBox1.Controls.Add(this.rdo_type_94);
            this.groupBox1.Controls.Add(this.rdo_type_80);
            this.groupBox1.Controls.Add(this.rdo_type_dental);
            this.groupBox1.Location = new System.Drawing.Point(36, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(225, 387);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "생산";
            // 
            // tb_make
            // 
            this.tb_make.Location = new System.Drawing.Point(50, 321);
            this.tb_make.Name = "tb_make";
            this.tb_make.Size = new System.Drawing.Size(129, 27);
            this.tb_make.TabIndex = 1;
            // 
            // rdo_type_dp
            // 
            this.rdo_type_dp.AutoSize = true;
            this.rdo_type_dp.Location = new System.Drawing.Point(46, 275);
            this.rdo_type_dp.Name = "rdo_type_dp";
            this.rdo_type_dp.Size = new System.Drawing.Size(133, 24);
            this.rdo_type_dp.TabIndex = 0;
            this.rdo_type_dp.TabStop = true;
            this.rdo_type_dp.Text = "Dust Protective";
            this.rdo_type_dp.UseVisualStyleBackColor = true;
            this.rdo_type_dp.CheckedChanged += new System.EventHandler(this.rdo_type_dp_CheckedChanged);
            // 
            // rdo_type_ad
            // 
            this.rdo_type_ad.AutoSize = true;
            this.rdo_type_ad.Location = new System.Drawing.Point(46, 223);
            this.rdo_type_ad.Name = "rdo_type_ad";
            this.rdo_type_ad.Size = new System.Drawing.Size(73, 24);
            this.rdo_type_ad.TabIndex = 0;
            this.rdo_type_ad.TabStop = true;
            this.rdo_type_ad.Text = "KF-AD";
            this.rdo_type_ad.UseVisualStyleBackColor = true;
            this.rdo_type_ad.CheckedChanged += new System.EventHandler(this.rdo_type_ad_CheckedChanged);
            // 
            // rdo_type_94
            // 
            this.rdo_type_94.AutoSize = true;
            this.rdo_type_94.Location = new System.Drawing.Point(46, 168);
            this.rdo_type_94.Name = "rdo_type_94";
            this.rdo_type_94.Size = new System.Drawing.Size(68, 24);
            this.rdo_type_94.TabIndex = 0;
            this.rdo_type_94.TabStop = true;
            this.rdo_type_94.Text = "KF-94";
            this.rdo_type_94.UseVisualStyleBackColor = true;
            this.rdo_type_94.CheckedChanged += new System.EventHandler(this.rdo_type_94_CheckedChanged);
            // 
            // rdo_type_80
            // 
            this.rdo_type_80.AutoSize = true;
            this.rdo_type_80.Location = new System.Drawing.Point(46, 120);
            this.rdo_type_80.Name = "rdo_type_80";
            this.rdo_type_80.Size = new System.Drawing.Size(68, 24);
            this.rdo_type_80.TabIndex = 0;
            this.rdo_type_80.TabStop = true;
            this.rdo_type_80.Text = "KF-80";
            this.rdo_type_80.UseVisualStyleBackColor = true;
            this.rdo_type_80.CheckedChanged += new System.EventHandler(this.rdo_type_80_CheckedChanged);
            // 
            // rdo_type_dental
            // 
            this.rdo_type_dental.AutoSize = true;
            this.rdo_type_dental.Location = new System.Drawing.Point(46, 74);
            this.rdo_type_dental.Name = "rdo_type_dental";
            this.rdo_type_dental.Size = new System.Drawing.Size(75, 24);
            this.rdo_type_dental.TabIndex = 0;
            this.rdo_type_dental.TabStop = true;
            this.rdo_type_dental.Text = "Dental";
            this.rdo_type_dental.UseVisualStyleBackColor = true;
            this.rdo_type_dental.CheckedChanged += new System.EventHandler(this.rdo_type_dental_CheckedChanged);
            // 
            // btn_make
            // 
            this.btn_make.Location = new System.Drawing.Point(283, 376);
            this.btn_make.Name = "btn_make";
            this.btn_make.Size = new System.Drawing.Size(161, 48);
            this.btn_make.TabIndex = 1;
            this.btn_make.Text = "생산시작";
            this.btn_make.UseVisualStyleBackColor = true;
            this.btn_make.Click += new System.EventHandler(this.btn_make_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 451);
            this.Controls.Add(this.btn_make);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form4";
            this.Text = "생산";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_make;
        private System.Windows.Forms.RadioButton rdo_type_dp;
        private System.Windows.Forms.RadioButton rdo_type_ad;
        private System.Windows.Forms.RadioButton rdo_type_94;
        private System.Windows.Forms.RadioButton rdo_type_80;
        private System.Windows.Forms.RadioButton rdo_type_dental;
        private System.Windows.Forms.Button btn_make;
    }
}