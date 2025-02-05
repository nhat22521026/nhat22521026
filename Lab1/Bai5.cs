﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Bai5 : Form
    {
        public Bai5()
        {
            InitializeComponent();
        }

        private void ChooseCal_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Calcu_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(InputA.Text) && !string.IsNullOrEmpty(InputB.Text))
            {
                double num = 0;
                int fac = 1;
                List<Int32> cal = new List<Int32>();
                int a = int.Parse(InputA.Text);
                int b = int.Parse(InputB.Text);
                int c = b - a;
                string choose = ChooseCal.SelectedItem.ToString();
                if (choose == "Bảng cửu chương")
                {
                    for (int i = 1; i <= 10; i++)
                    {
                        cal.Add(i * c);
                    }
                    ListNum.Items.Add("Bảng cửu chương của B - A là: " + string.Join(", ", cal));
                }
                else
                {
                    for(int i = 1;i <= c; i++)
                    {
                        fac *= i;
                    }                  
                    ListNum.Items.Add("Số giai thừa của B - A là: " + fac.ToString());
                    for(int i = 1; i <= b ; i++)
                    {
                        num += Math.Pow(a, i);
                    }
                    ListNum.Items.Add("Tổng là: " + num.ToString());
                    return;
                }
            }
        }

        private void Bai5_Load(object sender, EventArgs e)
        {

        }
    }
}
