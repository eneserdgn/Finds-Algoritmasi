using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindsUygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add("Güneşli");
            comboBox1.Items.Add("Yağmurlu");
            comboBox2.Items.Add("Ilık");
            comboBox2.Items.Add("Soğuk");
            comboBox3.Items.Add("Normal");
            comboBox3.Items.Add("Yüksek");
            comboBox4.Items.Add("Güçlü");
            comboBox5.Items.Add("Ilık");
            comboBox5.Items.Add("Soğuk");
            comboBox6.Items.Add("Aynı");
            comboBox6.Items.Add("Farklı");
            comboBox7.Items.Add("Evet");
            comboBox7.Items.Add("Hayır");
            comboBox8.Items.Add("Güneşli");
            comboBox8.Items.Add("Yağmurlu");
            comboBox9.Items.Add("Ilık");
            comboBox9.Items.Add("Soğuk");
            comboBox10.Items.Add("Normal");
            comboBox10.Items.Add("Yüksek");
            comboBox11.Items.Add("Güçlü");
            comboBox12.Items.Add("Ilık");
            comboBox12.Items.Add("Soğuk");
            comboBox13.Items.Add("Aynı");
            comboBox13.Items.Add("Farklı");
            comboBox14.Items.Add("Evet");
            comboBox14.Items.Add("Hayır");
            comboBox15.Items.Add("Güneşli");
            comboBox15.Items.Add("Yağmurlu");
            comboBox16.Items.Add("Ilık");
            comboBox16.Items.Add("Soğuk");
            comboBox17.Items.Add("Normal");
            comboBox17.Items.Add("Yüksek");
            comboBox18.Items.Add("Güçlü");
            comboBox19.Items.Add("Ilık");
            comboBox19.Items.Add("Soğuk");
            comboBox20.Items.Add("Aynı");
            comboBox20.Items.Add("Farklı");
            comboBox21.Items.Add("Evet");
            comboBox21.Items.Add("Hayır");
            comboBox22.Items.Add("Güneşli");
            comboBox22.Items.Add("Yağmurlu");
            comboBox23.Items.Add("Ilık");
            comboBox23.Items.Add("Soğuk");
            comboBox24.Items.Add("Normal");
            comboBox24.Items.Add("Yüksek");
            comboBox25.Items.Add("Güçlü");
            comboBox26.Items.Add("Ilık");
            comboBox26.Items.Add("Soğuk");
            comboBox27.Items.Add("Aynı");
            comboBox27.Items.Add("Farklı");
            comboBox28.Items.Add("Evet");
            comboBox28.Items.Add("Hayır");
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
            comboBox4.SelectedIndex = 0;
            comboBox5.SelectedIndex = 0;
            comboBox6.SelectedIndex = 0;
            comboBox7.SelectedIndex = 0;
            comboBox8.SelectedIndex = 0;
            comboBox9.SelectedIndex = 0;
            comboBox10.SelectedIndex = 0;
            comboBox11.SelectedIndex = 0;
            comboBox12.SelectedIndex = 0;
            comboBox13.SelectedIndex = 0;
            comboBox14.SelectedIndex = 0;
            comboBox15.SelectedIndex = 0;
            comboBox16.SelectedIndex = 0;
            comboBox17.SelectedIndex = 0;
            comboBox18.SelectedIndex = 0;
            comboBox19.SelectedIndex = 0;
            comboBox20.SelectedIndex = 0;
            comboBox21.SelectedIndex = 0;
            comboBox22.SelectedIndex = 0;
            comboBox23.SelectedIndex = 0;
            comboBox24.SelectedIndex = 0;
            comboBox25.SelectedIndex = 0;
            comboBox26.SelectedIndex = 0;
            comboBox27.SelectedIndex = 0;
            comboBox28.SelectedIndex = 0;
            
            









        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sonuc = "";
            string[] dizi1 = new string[7];
            string[] dizi2 = new string[7];
            string[] dizi3 = new string[7];
            string[] dizi4 = new string[7];
            string[] hdizisi = new string[7];


            dizi1[0] = comboBox1.Text;
            dizi1[1] = comboBox2.Text;
            dizi1[2] = comboBox3.Text;
            dizi1[3] = comboBox4.Text;
            dizi1[4] = comboBox5.Text;
            dizi1[5] = comboBox6.Text;
            dizi1[6] = comboBox7.Text;

            dizi2[0] = comboBox8.Text;
            dizi2[1] = comboBox9.Text;
            dizi2[2] = comboBox10.Text;
            dizi2[3] = comboBox11.Text;
            dizi2[4] = comboBox12.Text;
            dizi2[5] = comboBox13.Text;
            dizi2[6] = comboBox14.Text;

            dizi3[0] = comboBox15.Text;
            dizi3[1] = comboBox16.Text;
            dizi3[2] = comboBox17.Text;
            dizi3[3] = comboBox18.Text;
            dizi3[4] = comboBox19.Text;
            dizi3[5] = comboBox20.Text;
            dizi3[6] = comboBox21.Text;

            dizi4[0] = comboBox22.Text;
            dizi4[1] = comboBox23.Text;
            dizi4[2] = comboBox24.Text;
            dizi4[3] = comboBox25.Text;
            dizi4[4] = comboBox26.Text;
            dizi4[5] = comboBox27.Text;
            dizi4[6] = comboBox28.Text;


            for (int i = 0; i < 7; i++)
            {
                hdizisi[i] = dizi1[i];
            }




            if (dizi2[6] == "Evet")
            {
                for (int j = 0; j < 6; j++)
                {
                    if (dizi2[j] != hdizisi[j])
                    {
                        hdizisi[j] = "?";
                    }
                }

            }

            if (dizi3[6] == "Evet")
            {
                for (int j = 0; j < 6; j++)
                {
                    if (dizi3[j] != hdizisi[j])
                    {
                        hdizisi[j] = "?";
                    }
                }

            }
            if (dizi4[6] == "Evet")
            {
                for (int j = 0; j < 6; j++)
                {
                    if (dizi4[j] != hdizisi[j])
                    {
                        hdizisi[j] = "?";
                    }
                }

            }

            for (int x = 0; x < 6; x++)
            {
                sonuc = sonuc  + hdizisi[x]+ ",";
            }

            label8.Text = "En Genel Hipotez =["+sonuc+"]";





        }
    }
}
