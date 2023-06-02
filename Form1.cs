using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace MemoryGame
{


    public partial class Form1 : Form
    {
        // Определяне на 8 цвята за гърба на картите
        public int[,] arrayColor = new int[8, 3] { { 0, 0, 0 }, { 125, 125, 0 }, { 0, 125, 125 }, { 0, 0, 255 }, { 255, 0, 0 }, { 0, 255, 0 }, { 255, 0, 125 }, { 255, 255, 255 } };


        private void OpenCard(string card)
        {
            switch (card)
            {
                case "1":
                    Form1.ActiveForm.Controls["pictureBox1"].Enabled = false;
                    break;
                case "2":
                    Form1.ActiveForm.Controls["pictureBox2"].Enabled = false;
                    break;
                case "3":
                    Form1.ActiveForm.Controls["pictureBox3"].Enabled = false;
                    break;

            }
        }

        private void CloseCard(string card)
        {
            switch (card)
            {
                case "1":
                    Form1.ActiveForm.Controls["pictureBox1"].BackColor = Color.FromArgb(192, 192, 192);
                    break;
                case "2":
                    Form1.ActiveForm.Controls["pictureBox2"].BackColor = Color.FromArgb(192, 192, 192);
                    break;
                case "3":
                    Form1.ActiveForm.Controls["pictureBox3"].BackColor = Color.FromArgb(192, 192, 192);
                    break;

            }
        }





        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.PerformClick();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            // Определя се цвета на гърба на карта 1                    //
                int a = arrayColor[int.Parse(label1.Text) - 1, 0];
                int b = arrayColor[int.Parse(label1.Text) - 1, 1];
                int c = arrayColor[int.Parse(label1.Text) - 1, 2];
                if (cardA.Text == "")
                {
                    cardA.Text = label1.Text;                           //
                    cardNum1.Text = "1";                                //
                    pictureBox1.BackColor = Color.FromArgb(a, b, c);    //
                }
                else
                {
                    cardB.Text = label1.Text;                           //
                    cardNum2.Text = "1";                                //
                    if (cardA.Text == cardB.Text)
                    {
                        pictureBox1.BackColor = Color.FromArgb(a, b, c);    //
                        pictureBox1.Enabled = false;                        //
                        OpenCard(cardNum1.Text);
                    }
                    else
                    {
                        cardA.Text = "";
                        cardB.Text = "";
                        pictureBox1.BackColor = Color.FromArgb(a, b, c);        //
                        timer1.Enabled = true;
                        
                    }



                }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cardA.Text = "";
            cardB.Text = "";
            // Разбъркване на подреждането на ПЪРВИТЕ 8 карти
            List<int> listNumbers1 = new List<int>();
            var rand1 = new Random();
            int number1;
            for (int i = 0; i < 20; i++)
            {
                number1 = rand1.Next(1, 8);
                if (!listNumbers1.Contains(number1)) listNumbers1.Add(number1);
            }
            for (int i = 1; i <= 8; i++)
            {
                if (!listNumbers1.Contains(i)) listNumbers1.Add(i);
            }
            // Разбъркване на подреждането на ВТОРИТЕ 8 карти
            List<int> listNumbers2 = new List<int>();
            int j;
            for (int i = 0; i < listNumbers1.Count; i++)
            {
                j = listNumbers1[i] - 1;
                listNumbers2.Add(listNumbers1[j]);
            }
            // Подреждане на номерата по картите
            label1.Text = listNumbers1[0].ToString();
            label2.Text = listNumbers1[1].ToString();
            label3.Text = listNumbers1[2].ToString();
            label4.Text = listNumbers1[3].ToString();
            label5.Text = listNumbers1[4].ToString();
            label6.Text = listNumbers1[5].ToString();
            label7.Text = listNumbers1[6].ToString();
            label8.Text = listNumbers1[7].ToString();
            label9.Text = listNumbers2[0].ToString();
            label10.Text = listNumbers2[1].ToString();
            label11.Text = listNumbers2[2].ToString();
            label12.Text = listNumbers2[3].ToString();
            label13.Text = listNumbers2[4].ToString();
            label14.Text = listNumbers2[5].ToString();
            label15.Text = listNumbers2[6].ToString();
            label16.Text = listNumbers2[7].ToString();
            //label2.Text = label1.Text;


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {


            // Определя се цвета на гърба на карта 2                    //
            int a = arrayColor[int.Parse(label2.Text) - 1, 0];
            int b = arrayColor[int.Parse(label2.Text) - 1, 1];
            int c = arrayColor[int.Parse(label2.Text) - 1, 2];
            if (cardA.Text == "")
            {
                cardA.Text = label2.Text;                           //
                cardNum1.Text = "2";                                //
                pictureBox2.BackColor = Color.FromArgb(a, b, c);    //
            }
            else
            {
                cardB.Text = label2.Text;                           //
                cardNum2.Text = "2";                                //
                if (cardA.Text == cardB.Text)
                {
                    pictureBox2.BackColor = Color.FromArgb(a, b, c);    //
                    pictureBox2.Enabled = false;                        //
                    OpenCard(cardNum1.Text);
                }
                else
                {
                    cardA.Text = "";
                    cardB.Text = "";
                    pictureBox2.BackColor = Color.FromArgb(a, b, c);        //
                    timer1.Enabled = true;

                }



            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            CloseCard(cardNum1.Text);
            CloseCard(cardNum2.Text);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            // Определя се цвета на гърба на карта 3                    //
            int a = arrayColor[int.Parse(label3.Text) - 1, 0];
            int b = arrayColor[int.Parse(label3.Text) - 1, 1];
            int c = arrayColor[int.Parse(label3.Text) - 1, 2];
            if (cardA.Text == "")
            {
                cardA.Text = label3.Text;                           //
                cardNum1.Text = "3";                                //
                pictureBox3.BackColor = Color.FromArgb(a, b, c);    //
            }
            else
            {
                cardB.Text = label3.Text;                           //
                cardNum2.Text = "3";                                //
                if (cardA.Text == cardB.Text)
                {
                    pictureBox3.BackColor = Color.FromArgb(a, b, c);    //
                    pictureBox3.Enabled = false;                        //
                    OpenCard(cardNum1.Text);
                }
                else
                {
                    cardA.Text = "";
                    cardB.Text = "";
                    pictureBox3.BackColor = Color.FromArgb(a, b, c);        //
                    timer1.Enabled = true;

                }



            }
        }
    }
}
