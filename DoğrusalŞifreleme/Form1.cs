using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoğrusalŞifreleme
{
    public partial class Form1 : Form
    {
        string metin = " ";
        string sifrelimetin = " ";
        string desifrelimetin = " ";
        string alfabe = "abcçdefgğhıijklmnoöprsştuüvyz";
        int a, b, x, y;

     

        public Form1()
        {
            InitializeComponent();
        }
        private void btnsifrele_Click(object sender, EventArgs e)
        {
            //sifreleme
            metin = txtmetin.Text.ToLower();
            sifrelimetin = "";
            a = int.Parse(numA.Value.ToString());
            b = int.Parse(numB.Value.ToString());

            for (int i = 0; i < metin.Length; i++)
            {
                bool sonuc = false;
                for (int j = 0; j < 29; j++)
                {
                    x = j;
                    if (metin[i] == alfabe[j])
                    {
                        sonuc = true;
                        //y=ax+b;
                        y = a * x + b;
                        y %= 29;

                        sifrelimetin += alfabe[y];

                    }
                }
                if (!sonuc)
                {
                    sifrelimetin += metin[i];
                }
            }
            txtsifrelimetin.Text = sifrelimetin.ToString();
        }

        private void btndesifrele_Click(object sender, EventArgs e)
        {
            //desifreleme
            sifrelimetin = txtsifrelimetin.Text.ToLower();
            desifrelimetin = "";
            a = int.Parse(numA.Value.ToString());
            b = int.Parse(numB.Value.ToString());

            for (int i = 0; i < sifrelimetin.Length; i++)
            {
                bool sonuc = false;
                for (int j = 0; j < 29; j++)
                {
                    x = j;
                    if (sifrelimetin[i] == alfabe[j])
                    {
                        sonuc = true;
                        //y=ax+b tersi  y'=(x-b)/a

                        y = x - b;

                        while (y < 0 || y % a != 0)
                        {
                            y += 29;
                        }
                        y /= a;


                        y %= 29;

                        desifrelimetin += alfabe[y];

                    }
                }
                if (!sonuc)
                {
                    desifrelimetin += sifrelimetin[i];
                }
            }
            txtdesifrelimetin.Text = desifrelimetin.ToString();
        
        }
    }
}
