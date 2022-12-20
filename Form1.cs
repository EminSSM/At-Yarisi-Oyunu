using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace At_Yarışı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //int birinciatsolauzaklık, ikinciatsolauzaklık, ücüncüatsolauzaklık;
        Random rastgele = new Random();


        private void button1_Click_1(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
        int derece = 0;
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            timer1.Interval=100;

            derece++;
            label7.Text = derece.ToString();

            int birinciatgenislik = pictureBox1.Width;
            int ikinciatgenislik = pictureBox2.Width;
            int ücüncüatgenislik = pictureBox3.Width;
            int dördüncüatgenislik = pictureBox4.Width;
            int besinciatgenislik = pictureBox5.Width;

            pictureBox1.Left = pictureBox1.Left + rastgele.Next(5, 15);
            pictureBox2.Left = pictureBox2.Left + rastgele.Next(5, 15);
            pictureBox3.Left = pictureBox3.Left + rastgele.Next(5, 15);
            pictureBox4.Left = pictureBox4.Left + rastgele.Next(5, 15);
            pictureBox5.Left = pictureBox5.Left + rastgele.Next(5, 15);
            int bitisuzaklıgı = label5.Left;
            if (pictureBox1.Left > pictureBox2.Left + 5 && pictureBox1.Left > pictureBox3.Left + 5 && pictureBox1.Left > pictureBox4.Left + 5
                && pictureBox1.Left > pictureBox5.Left + 5)
            {
                label6.Text = "1.at yarışı önde götürüyor!";
            }
            if (pictureBox2.Left > pictureBox1.Left + 5 && pictureBox2.Left > pictureBox3.Left + 5 && pictureBox2.Left > pictureBox4.Left + 5
                && pictureBox2.Left > pictureBox5.Left + 5)
            {
                label6.Text = "2.at liderliği ele geçirdi!!";
            }
            if (pictureBox3.Left > pictureBox2.Left + 5 && pictureBox3.Left > pictureBox2.Left + 5 && pictureBox3.Left > pictureBox4.Left + 5
                && pictureBox3.Left > pictureBox5.Left + 5)
            {
                label6.Text = "3.at kazanacak gibi duruyor!!!";
            }
            if (pictureBox4.Left > pictureBox1.Left + 5 && pictureBox4.Left > pictureBox2.Left + 5 && pictureBox4.Left > pictureBox3.Left + 5
                && pictureBox4.Left > pictureBox5.Left + 5)
            {
                label6.Text = "4.at liderliği ele geçirdi!!!";
            }

                if (pictureBox5.Left > pictureBox1.Left + 5 && pictureBox5.Left > pictureBox2.Left + 5 && pictureBox5.Left > pictureBox3.Left + 5
                    && pictureBox5.Left > pictureBox4.Left + 5)
                {
                    label6.Text = "5.at şaha kalktı!!!";
                }
                if (birinciatgenislik + pictureBox1.Left >= bitisuzaklıgı)
                {
                    timer1.Enabled = false;
                    label6.Text = ("1 numaralı at yarışı kazandı!!");
                }
                if (ikinciatgenislik + pictureBox2.Left >= bitisuzaklıgı)
                {
                    timer1.Enabled = false;
                    label6.Text = ("2 numaralı at yarışı kazandı!!");
                }
                if (ücüncüatgenislik + pictureBox3.Left >= bitisuzaklıgı)
                {
                    timer1.Enabled = false;
                    label6.Text = ("3 numaralı at yarışı kazandı!!");
                }
                if (dördüncüatgenislik + pictureBox4.Left >= bitisuzaklıgı)
                {
                    timer1.Enabled = false;
                    label6.Text = ("4 numaralı at yarışı kazandı!!");
                }
                if (besinciatgenislik + pictureBox5.Left >= bitisuzaklıgı)
                {
                    timer1.Enabled = false;
                    label6.Text = ("5 numaralı at yarışı kazandı!!");
                }
        
        }

        private void label8_Click(object sender, EventArgs e)
        {
            timer1.Enabled=false;
            label6.Text = "";
            label7.Text = "";
            pictureBox1.Left = 0;
            pictureBox2.Left = 0;
            pictureBox3.Left = 0;
            pictureBox4.Left = 0;
            pictureBox5.Left = 0;
            derece = 0;
        }

        //private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //}
    }

                //private void Form1_Load(object sender, EventArgs e)
        //{
        //    //birinciatsolauzaklık = pictureBox1.Left;
        //    //ikinciatsolauzaklık = pictureBox2.Left;
        //    //ücüncüatsolauzaklık = pictureBox3.Left;
        //}

        //private void label8_Click(object sender, EventArgs e)
        //{
        //    timer1.Enabled = false;
        //    label6.Text = "";
        //    label7.Text = "";
        //    pictureBox1.Left = 0;
        //    pictureBox2.Left = 0;
        //    pictureBox3.Left = 0;
        //    pictureBox4.Left = 0;
        //    pictureBox5.Left = 0;
        //}
    
}
