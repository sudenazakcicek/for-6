﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace for6_1691
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            lbTek.Items.Clear();
            lbCift.Items.Clear();

            int baslangic = Convert.ToInt32(txtBaslangic.Text);
            int bitis = Convert.ToInt32(txtBitis.Text);

            for (int i = baslangic; i < bitis; i++)
            {
                if (i % 2 != 0)
                {
                    lbTek.Items.Add(i);

                }
                else
                {
                    lbCift.Items.Add(i);
                }


            }
        }
    }
}
