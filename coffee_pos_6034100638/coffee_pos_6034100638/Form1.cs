using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coffee_pos_6034100638
{
    public partial class Form1 : Form
    {
        double pay;
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void pay_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String str;
            double EE1, EE2, EE3, AA1, AA2, LL1, LL2, LL3, MM1, MM2, MM3, CC1, CC2, CC3, GG1, GG2, GG3, TT1, TT2, TT3, Ccocoa1, Ccocoa2, Ccocoa3,
                Mmilk1, Mmilk2, Mmilk3, Mmilktea1, Mmilktea2, Llemon1, Llemon2, Mmilo1, Mmilo2, Mmilo3, Nnes1, Nnes2, Nnes3,
                Nnest1, Nnest2, Nnest3, II1, RR1, HH1, dd;
            str = "";

            if (E1.Checked == true)
            {
                str += "Espresso Hot ราคา 35 บาท" + "\r\n";
                EE1 = 35;
            }
            else
            {
                EE1 = 0;
            }
            if (E2.Checked == true)
            {
                str += "Espresso Ice ราคา 45 บาท" + "\r\n";
                EE2 = 45;
            }
            else
            {
                EE2 = 0;
            }
            if (E3.Checked == true)
            {
                str += "Espresso Frappe ราคา 50 บาท" + "\r\n";
                EE3 = 50;
            }
            else
            {
                EE3 = 0;
            }
            if (A1.Checked == true)
            {
                str += "Americano Hot ราคา 35 บาท" + "\r\n";
                AA1 = 35;
            }
            else
            {
                AA1 = 0;
            }
            if (A2.Checked == true)
            {
                str += "Americano Ice ราคา 45 บาท" + "\r\n";
                AA2 = 45;
            }
            else
            {
                AA2 = 0;
            }
            if (L1.Checked == true)
            {
                str += "Latte Hot ราคา 35 บาท" + "\r\n";
                LL1 = 35;

            }
            else
            {
                LL1 = 0;
            }
            if (L2.Checked == true)
            {
                str += "Latte Ice ราคา 45 บาท" + "\r\n";
                LL2 = 45;
            }
            else
            {
                LL2 = 0;
            }
            if (L3.Checked == true)
            {
                str += "Latte Frappe ราคา 35 บาท" + "\r\n";
                LL3 = 35;
            }
            else
            {
                LL3 = 0;
            }
            if (M1.Checked == true)
            {
                str += "Mocha Hot ราคา 35 บาท" + "\r\n";
                MM1 = 35;
            }
            else
            {
                MM1 = 0;
            }
            if (M2.Checked == true)
            {
                str += "Mocha Ice ราคา 45 บาท" + "\r\n";
                MM2 = 45;
            }
            else
            {
                MM2 = 0;
            }
            if (M3.Checked == true)
            {
                str += "Mocha Frappe ราคา 50 บาท" + "\r\n";
                MM3 = 50;
            }
            else
            {
                MM3 = 0;
            }
            if (C1.Checked == true)
            {
                str += "Cappucino Hot ราคา 35 บาท" + "\r\n";
                CC1 = 35;
            }
            else
            {
                CC1 = 0;
            }
            if (C2.Checked == true)
            {
                str += "Cappucino Ice ราคา 45 บาท" + "\r\n";
                CC2 = 45;
            }
            else
            {
                CC2 = 0;
            }
            if (C3.Checked == true)
            {
                str += "Cappucino Frappe ราคา 50 บาท" + "\r\n";
                CC3 = 50;
            }
            else
            {
                CC3 = 0;
            }
            if (G1.Checked == true)
            {
                str += "GreenTea Hot ราคา 20 บาท" + "\r\n";
                GG1 = 20;
            }
            else
            {
                GG1 = 0;
            }
            if (G2.Checked == true)
            {
                str += "GreenTea Ice ราคา 25 บาท" + "\r\n";
                GG2 = 25;
            }
            else
            {
                GG2 = 0;
            }
            if (G3.Checked == true)
            {
                str += "GreenTea Frappe ราคา 30 บาท" + "\r\n";
                GG3 = 30;
            }
            else
            {
                GG3 = 0;
            }
            if (T1.Checked == true)
            {
                str += "ThaiTea Hot ราคา 20 บาท" + "\r\n";
                TT1 = 20;
            }
            else
            {
                TT1 = 0;
            }
            if (T2.Checked == true)
            {
                str += "ThaiTea Ice ราคา 25 บาท" + "\r\n";
                TT2 = 25;
            }
            else
            {
                TT2 = 0;
            }
            if (T3.Checked == true)
            {
                str += "ThaiTea Frappe ราคา 30 บาท" + "\r\n";
                TT3 = 30;
            }
            else
            {
                TT3 = 0;
            }
            if (cocoa1.Checked == true)
            {
                str += "Cocoa Hot ราคา 20 บาท" + "\r\n";
                Ccocoa1 = 20;
            }
            else
            {
                Ccocoa1 = 0;
            }
            if (cocoa2.Checked == true)
            {
                str += "Cocoa Ice ราคา 25 บาท" + "\r\n";
                Ccocoa2 = 25;
            }
            else
            {
                Ccocoa2 = 0;
            }
            if (cocoa3.Checked == true)
            {
                str += "Cocoa Frappe ราคา 30 บาท" + "\r\n";
                Ccocoa3 = 30;
            }
            else
            {
                Ccocoa3 = 0;
            }
            if (milk1.Checked == true)
            {
                str += "Milk Hot ราคา 20 บาท" + "\r\n";
                Mmilk1 = 20;
            }
            else
            {
                Mmilk1 = 0;
            }
            if (milk2.Checked == true)
            {
                str += "Milk Ice ราคา 25 บาท" + "\r\n";
                Mmilk2 = 25;
            }
            else
            {
                Mmilk2 = 0;
            }
            if (milk3.Checked == true)
            {
                str += "Milk Frappe ราคา 30 บาท" + "\r\n";
                Mmilk3 = 30;
            }
            else
            {
                Mmilk3 = 0;
            }
            if (milktea1.Checked == true)
            {
                str += "Milk Tea Ice ราคา 25 บาท" + "\r\n";
                Mmilktea1 = 25;
            }
            else
            {
                Mmilktea1 = 0;
            }
            if (milktea2.Checked == true)
            {
                str += "Milk Tea Frappe ราคา 30 บาท" + "\r\n";
                Mmilktea2 = 30;
            }
            else
            {
                Mmilktea2 = 0;
            }
            if (lemon1.Checked == true)
            {
                str += "Lemon Tea Ice ราคา 25 บาท" + "\r\n";
                Llemon1 = 25;
            }
            else
            {
                Llemon1 = 0;
            }
            if (lemon2.Checked == true)
            {
                str += "Lemon Tea Frappe ราคา 30 บาท" + "\r\n";
                Llemon2 = 30;
            }
            else
            {
                Llemon2 = 0;
            }
            if (milo1.Checked == true)
            {
                str += "Milo Hot ราคา 20 บาท" + "\r\n";
                Mmilo1 = 20;
            }
            else
            {
                Mmilo1 = 0;
            }
            if (milo2.Checked == true)
            {
                str += "Milo Ice ราคา 25 บาท" + "\r\n";
                Mmilo2 = 25;
            }
            else
            {
                Mmilo2 = 0;
            }
            if (milo3.Checked == true)
            {
                str += "Milo Frappe ราคา 30 บาท" + "\r\n";
                Mmilo3 = 30;
            }
            else
            {
                Mmilo3 = 0;
            }
            if (nes1.Checked == true)
            {
                str += "Nescafe Hot ราคา 20 บาท" + "\r\n";
                Nnes1 = 20;
            }
            else
            {
                Nnes1 = 0;
            }
            if (nes2.Checked == true)
            {
                str += "Nescafe Ice ราคา 25 บาท" + "\r\n";
                Nnes2 = 25;
            }
            else
            {
                Nnes2 = 0;
            }
            if (nes3.Checked == true)
            {
                str += "Nescafe Frappe ราคา 30 บาท" + "\r\n";
                Nnes3 = 30;
            }
            else
            {
                Nnes3 = 0;
            }
            if (nest1.Checked == true)
            {
                str += "Nestca Tea Hot ราคา 20 บาท" + "\r\n";
                Nnest1 = 20;
            }
            else
            {
                Nnest1 = 0;
            }
            if (nest2.Checked == true)
            {
                str += "Nestca Tea Ice ราคา 25 บาท" + "\r\n";
                Nnest2 = 25;
            }
            else
            {
                Nnest2 = 0;
            }
            if (nest3.Checked == true)
            {
                str += "Nestca Tea Frappe ราคา 30 บาท" + "\r\n";
                Nnest3 = 30;
            }
            else
            {
                Nnest3 = 0;
            }
            if (I1.Checked == true)
            {
                str += "Italian Soda  ราคา 25 บาท" + "\r\n";
                II1 = 25;
            }
            else
            {
                II1 = 0;
            }
            if (R1.Checked == true)
            {
                str += "Red lime Soda  ราคา 25 บาท" + "\r\n";
                RR1 = 25;
            }
            else
            {
                RR1 = 0;
            }
            if (H1.Checked == true)
            {
                str += "Honey lime Soda  ราคา 25 บาท" + "\r\n";
                HH1 = 25;
            }
            else
            {
                HH1 = 0;
            }
            allmenu.Text = str;
            ////ให้ menu ที่เลืกไปโชว์ในช่องของ allmenu
            dd = EE1 + EE2 + EE3+ AA1+AA2+ LL1+LL2+LL3+MM1+MM2+MM3+CC1+CC2+CC3+GG1+GG2+GG3+TT1+TT2+TT3+Ccocoa1+Ccocoa2+Ccocoa3+
                Mmilk1+ Mmilk2+Mmilk3+Mmilktea1+Mmilktea2+Llemon1+Llemon2+Mmilo1+Mmilo2+Mmilo3+Nnes1+Nnes2+Nnes3+
                Nnest1+Nnest2+Nnest3+II1+RR1+HH1;
            sum.Text = (dd + "  บาท");
        
            }
        }
    }

