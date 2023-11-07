using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rasgele_sayi_olusturmak_sayıya_göre_renk_degistirme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd=new Random();
            int sayi=rnd.Next(1,101);
            label1.Text=sayi.ToString();
            if (sayi < 50)
            {
                label1.ForeColor= Color.Red;
            }
            else if (sayi>=50 && sayi <= 70)
            {
                label1.ForeColor= Color.Orange;
            }
            else
            {
                label1.ForeColor = Color.Blue;
            }
        }
    }
}
