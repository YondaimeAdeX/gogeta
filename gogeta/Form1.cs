using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gogeta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Ogretmen og = new Ogretmen();
            og.adiSoyadi = "Son Goku";
            Yonetim idareci = new Yonetim();
            idareci.maasi = 2750;
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Ogretmen og = new Ogretmen();
            og.adiSoyadi = textBox1.Text;
            og.tcNo = textBox2.Text;
            og.maasi = float.Parse( textBox3.Text);
            og.cinsiyeti = textBox4.Text;
            og.bransi = textBox5.Text;
            listBox1.Items.Add(og.adiSoyadi + " " + og.tcNo + " " + og.maasi + " " + og.cinsiyeti + " " + og.bransi);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Yonetim yo = new Yonetim();
            yo.adiSoyadi = textBox6.Text;
            yo.tcNo = textBox10.Text;
            yo.maasi = float.Parse(textBox8.Text);
            yo.cinsiyeti = textBox7.Text;
            yo.bransi = textBox9.Text;
            yo.gorevi = textBox11.Text;
            listBox2.Items.Add(yo.adiSoyadi + " " + yo.tcNo + " " + yo.maasi + " " + yo.cinsiyeti + " " + yo.bransi + " "+ yo.gorevi);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Araba car = new Araba();
            car.modeli = textBox16.Text;
            car.rengi = textBox13.Text;
            car.fiyat = int.Parse(textBox15.Text);
            car.kapasite = textBox18.Text;
            car.yakit = textBox17.Text;
            car.marka = textBox14.Text;
            listBox3.Items.Add(car.modeli + " " + car.fiyat + " " + car.marka + " " + car.rengi + " " + car.kapasite + " " + car.yakit);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Kamyon kam = new Kamyon();
            kam.modeli=tex
            listBox3.Items.Add(car.modeli + " " + car.fiyat + " " + car.marka + " " + car.rengi + " " + car.kapasite + " " + car.yakit);
        }
    }
}
