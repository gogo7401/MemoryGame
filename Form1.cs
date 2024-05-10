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
      
        public int br = 0; // Глобален брояч за отворени двойки карти - 

        private static Form1 form = null;

        private void OpenCard(string card)
        {
            br++;
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
                case "4":
                    Form1.ActiveForm.Controls["pictureBox4"].Enabled = false;
                    break;
                case "5":
                    Form1.ActiveForm.Controls["pictureBox5"].Enabled = false;
                    break;
                case "6":
                    Form1.ActiveForm.Controls["pictureBox6"].Enabled = false;
                    break;
                case "7":
                    Form1.ActiveForm.Controls["pictureBox7"].Enabled = false;
                    break;
                case "8":
                    Form1.ActiveForm.Controls["pictureBox8"].Enabled = false;
                    break;
                case "9":
                    Form1.ActiveForm.Controls["pictureBox9"].Enabled = false;
                    break;
                case "10":
                    Form1.ActiveForm.Controls["pictureBox10"].Enabled = false;
                    break;
                case "11":
                    Form1.ActiveForm.Controls["pictureBox11"].Enabled = false;
                    break;
                case "12":
                    Form1.ActiveForm.Controls["pictureBox12"].Enabled = false;
                    break;
                case "13":
                    Form1.ActiveForm.Controls["pictureBox13"].Enabled = false;
                    break;
                case "14":
                    Form1.ActiveForm.Controls["pictureBox14"].Enabled = false;
                    break;
                case "15":
                    Form1.ActiveForm.Controls["pictureBox15"].Enabled = false;
                    break;
                case "16":
                    Form1.ActiveForm.Controls["pictureBox16"].Enabled = false;
                    break;

            }
            cardNum1.Text = "";
            cardNum2.Text = "";
            cardA.Text = "";
            cardB.Text = "";
            if (br == 8) MessageBox.Show("Браво! Ти спечели играта.");
        } // Запазва постоянно отворени тези карти, които са познати

        private void CloseCard(string card)
        {
            

            switch (card)
            {
                case "1":
                    form.pictureBox1.Image = imageList1.Images[0];
                    break;
                case "2":
                    form.pictureBox2.Image = imageList1.Images[0];
                    break;
                case "3":
                    form.pictureBox3.Image = imageList1.Images[0];
                    break;
                case "4":
                    form.pictureBox4.Image = imageList1.Images[0];
                    break;
                case "5":
                    form.pictureBox5.Image = imageList1.Images[0];
                    break;
                case "6":
                    form.pictureBox6.Image = imageList1.Images[0];
                    break;
                case "7":
                    form.pictureBox7.Image = imageList1.Images[0];
                    break;
                case "8":
                    form.pictureBox8.Image = imageList1.Images[0]; 
                    break;
                case "9":
                    form.pictureBox9.Image = imageList1.Images[0];
                    break;
                case "10":
                    form.pictureBox10.Image = imageList1.Images[0];
                    break;
                case "11":
                    form.pictureBox11.Image = imageList1.Images[0];
                    break;
                case "12":
                    form.pictureBox12.Image = imageList1.Images[0];
                    break;
                case "13":
                    form.pictureBox13.Image = imageList1.Images[0];
                    break;
                case "14":
                    form.pictureBox14.Image = imageList1.Images[0];
                    break;
                case "15":
                    form.pictureBox15.Image = imageList1.Images[0];
                    break;
                case "16":
                    form.pictureBox16.Image = imageList1.Images[0];
                    break;

            }
        }// Затваря картите, когато не са познати


        public Form1()
        {
            InitializeComponent();
            form = this;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.PerformClick();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            br = 0;
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
            // Задаване цвят на гърба на картите
            pictureBox1.Image = imageList1.Images[0];
            pictureBox2.Image = imageList1.Images[0];
            pictureBox3.Image = imageList1.Images[0];
            pictureBox4.Image = imageList1.Images[0];
            pictureBox5.Image = imageList1.Images[0];
            pictureBox6.Image = imageList1.Images[0];
            pictureBox7.Image = imageList1.Images[0];
            pictureBox8.Image = imageList1.Images[0];
            pictureBox9.Image = imageList1.Images[0];
            pictureBox10.Image = imageList1.Images[0];
            pictureBox11.Image = imageList1.Images[0];
            pictureBox12.Image = imageList1.Images[0];
            pictureBox13.Image = imageList1.Images[0];
            pictureBox14.Image = imageList1.Images[0];
            pictureBox15.Image = imageList1.Images[0];
            pictureBox16.Image = imageList1.Images[0];
            // Разрешава всички карти за игра
            pictureBox1.Enabled = true;
            pictureBox2.Enabled = true;
            pictureBox3.Enabled = true;
            pictureBox4.Enabled = true;
            pictureBox5.Enabled = true;
            pictureBox6.Enabled = true;
            pictureBox7.Enabled = true;
            pictureBox8.Enabled = true;
            pictureBox9.Enabled = true;
            pictureBox10.Enabled = true;
            pictureBox11.Enabled = true;
            pictureBox12.Enabled = true;
            pictureBox13.Enabled = true;
            pictureBox14.Enabled = true;
            pictureBox15.Enabled = true;
            pictureBox16.Enabled = true;


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            CloseCard(cardNum1.Text);   // Затваря 1 карта
            CloseCard(cardNum2.Text);   // Затваря 2 карта
            timer1.Enabled = false;     // Спира таймера

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

                if (cardA.Text == "")            // Проверява се дали картата е първа отворена
                {
                    cardA.Text = label1.Text;       // Запомня се номера на картата                   
                    cardNum1.Text = "1";            // Запомня се поредният номер на картата ( от 1 до 16)                    
                    pictureBox1.Image = imageList1.Images[int.Parse(label1.Text)];    // Отваря цвета на картата
                }
                else   // Ако картата се отваря втора
                {
                    cardB.Text = label1.Text;                           
                    cardNum2.Text = "1";                                
                    if (cardA.Text == cardB.Text)       // Проверя дали 1 и 2 карта са еднакви
                    {  // Ако е ДА
                        pictureBox1.Image = imageList1.Images[int.Parse(label1.Text)];   // Показва цвета на картата 
                        pictureBox1.Enabled = false;                       // Забранява се да се затвори картата 
                        OpenCard(cardNum1.Text);            // Вика процедура за да остави 1(първа) карта постоянно отворена
                    }
                else
                {
                    // Ако е НЕ
                }
                    {
                        cardA.Text = ""; // Изчиства данните за карта 1
                        cardB.Text = ""; // Изчиства данните за карта 2
                        pictureBox1.Image = imageList1.Images[int.Parse(label1.Text)];        // Показва цвета на картата
                        timer1.Enabled = true;  // Пуска таймер за изчакване на 2 сек. и затваря картите
                        
                    }



                }

        }

        

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            if (cardA.Text == "")
            {
                cardA.Text = label2.Text;                           //
                cardNum1.Text = "2";                                //
                pictureBox2.Image = imageList1.Images[int.Parse(label2.Text)];
            }
            else
            {
                cardB.Text = label2.Text;                           //
                cardNum2.Text = "2";                                //
                if (cardA.Text == cardB.Text)
                {
                    pictureBox2.Image = imageList1.Images[int.Parse(label2.Text)];
                    pictureBox2.Enabled = false;                        //
                    OpenCard(cardNum1.Text);
                }
                else
                {
                    cardA.Text = "";
                    cardB.Text = "";
                    pictureBox2.Image = imageList1.Images[int.Parse(label2.Text)];
                    timer1.Enabled = true;

                }



            }

        }

        

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (cardA.Text == "")
            {
                cardA.Text = label3.Text;                           //
                cardNum1.Text = "3";                                //
                pictureBox3.Image = imageList1.Images[int.Parse(label3.Text)];
            }
            else
            {
                cardB.Text = label3.Text;                           //
                cardNum2.Text = "3";                                //
                if (cardA.Text == cardB.Text)
                {
                    pictureBox3.Image = imageList1.Images[int.Parse(label3.Text)];
                    pictureBox3.Enabled = false;                        //
                    OpenCard(cardNum1.Text);
                }
                else
                {
                    cardA.Text = "";
                    cardB.Text = "";
                    pictureBox3.Image = imageList1.Images[int.Parse(label3.Text)];
                    timer1.Enabled = true;

                }



            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (cardA.Text == "")
            {
                cardA.Text = label4.Text;                           //
                cardNum1.Text = "4";                                //
                pictureBox4.Image = imageList1.Images[int.Parse(label4.Text)];
            }
            else
            {
                cardB.Text = label4.Text;                           //
                cardNum2.Text = "4";                                //
                if (cardA.Text == cardB.Text)
                {
                    pictureBox4.Image = imageList1.Images[int.Parse(label4.Text)];
                    pictureBox4.Enabled = false;                        //
                    OpenCard(cardNum1.Text);
                }
                else
                {
                    cardA.Text = "";
                    cardB.Text = "";
                    pictureBox4.Image = imageList1.Images[int.Parse(label4.Text)];
                    timer1.Enabled = true;

                }



            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (cardA.Text == "")
            {
                cardA.Text = label5.Text;                           //
                cardNum1.Text = "5";                                //
                pictureBox5.Image = imageList1.Images[int.Parse(label5.Text)];
            }
            else
            {
                cardB.Text = label5.Text;                           //
                cardNum2.Text = "5";                                //
                if (cardA.Text == cardB.Text)
                {
                    pictureBox5.Image = imageList1.Images[int.Parse(label5.Text)];
                    pictureBox5.Enabled = false;                        //
                    OpenCard(cardNum1.Text);
                }
                else
                {
                    cardA.Text = "";
                    cardB.Text = "";
                    pictureBox5.Image = imageList1.Images[int.Parse(label5.Text)];
                    timer1.Enabled = true;

                }



            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (cardA.Text == "")
            {
                cardA.Text = label6.Text;                           //
                cardNum1.Text = "6";                                //
                pictureBox6.Image = imageList1.Images[int.Parse(label6.Text)];
            }
            else
            {
                cardB.Text = label6.Text;                           //
                cardNum2.Text = "6";                                //
                if (cardA.Text == cardB.Text)
                {
                    pictureBox6.Image = imageList1.Images[int.Parse(label6.Text)];
                    pictureBox6.Enabled = false;                        //
                    OpenCard(cardNum1.Text);
                }
                else
                {
                    cardA.Text = "";
                    cardB.Text = "";
                    pictureBox6.Image = imageList1.Images[int.Parse(label6.Text)];
                    timer1.Enabled = true;

                }



            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (cardA.Text == "")
            {
                cardA.Text = label7.Text;                           //
                cardNum1.Text = "7";                                //
                pictureBox7.Image = imageList1.Images[int.Parse(label7.Text)];
            }
            else
            {
                cardB.Text = label7.Text;                           //
                cardNum2.Text = "7";                                //
                if (cardA.Text == cardB.Text)
                {
                    pictureBox7.Image = imageList1.Images[int.Parse(label7.Text)];
                    pictureBox7.Enabled = false;                        //
                    OpenCard(cardNum1.Text);
                }
                else
                {
                    cardA.Text = "";
                    cardB.Text = "";
                    pictureBox7.Image = imageList1.Images[int.Parse(label7.Text)];
                    timer1.Enabled = true;

                }



            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (cardA.Text == "")
            {
                cardA.Text = label8.Text;                           //
                cardNum1.Text = "8";                                //
                pictureBox8.Image = imageList1.Images[int.Parse(label8.Text)];
            }
            else
            {
                cardB.Text = label8.Text;                           //
                cardNum2.Text = "8";                                //
                if (cardA.Text == cardB.Text)
                {
                    pictureBox8.Image = imageList1.Images[int.Parse(label8.Text)];
                    pictureBox8.Enabled = false;                        //
                    OpenCard(cardNum1.Text);
                }
                else
                {
                    cardA.Text = "";
                    cardB.Text = "";
                    pictureBox8.Image = imageList1.Images[int.Parse(label8.Text)];
                    timer1.Enabled = true;

                }



            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (cardA.Text == "")
            {
                cardA.Text = label9.Text;                           //
                cardNum1.Text = "9";                                //
                pictureBox9.Image = imageList1.Images[int.Parse(label9.Text)];
            }
            else
            {
                cardB.Text = label9.Text;                           //
                cardNum2.Text = "9";                                //
                if (cardA.Text == cardB.Text)
                {
                    pictureBox9.Image = imageList1.Images[int.Parse(label9.Text)];
                    pictureBox9.Enabled = false;                        //
                    OpenCard(cardNum1.Text);
                }
                else
                {
                    cardA.Text = "";
                    cardB.Text = "";
                    pictureBox9.Image = imageList1.Images[int.Parse(label9.Text)];
                    timer1.Enabled = true;

                }



            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            if (cardA.Text == "")
            {
                cardA.Text = label10.Text;                           //
                cardNum1.Text = "10";                                //
                pictureBox10.Image = imageList1.Images[int.Parse(label10.Text)];
            }
            else
            {
                cardB.Text = label10.Text;                           //
                cardNum2.Text = "10";                                //
                if (cardA.Text == cardB.Text)
                {
                    pictureBox10.Image = imageList1.Images[int.Parse(label10.Text)];
                    pictureBox10.Enabled = false;                        //
                    OpenCard(cardNum1.Text);
                }
                else
                {
                    cardA.Text = "";
                    cardB.Text = "";
                    pictureBox10.Image = imageList1.Images[int.Parse(label10.Text)];
                    timer1.Enabled = true;

                }



            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            if (cardA.Text == "")
            {
                cardA.Text = label11.Text;                           //
                cardNum1.Text = "11";                                //
                pictureBox11.Image = imageList1.Images[int.Parse(label11.Text)];
            }
            else
            {
                cardB.Text = label11.Text;                           //
                cardNum2.Text = "11";                                //
                if (cardA.Text == cardB.Text)
                {
                    pictureBox11.Image = imageList1.Images[int.Parse(label11.Text)];
                    pictureBox11.Enabled = false;                        //
                    OpenCard(cardNum1.Text);
                }
                else
                {
                    cardA.Text = "";
                    cardB.Text = "";
                    pictureBox11.Image = imageList1.Images[int.Parse(label11.Text)];
                    timer1.Enabled = true;

                }



            }
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            if (cardA.Text == "")
            {
                cardA.Text = label12.Text;                           //
                cardNum1.Text = "12";                                //
                pictureBox12.Image = imageList1.Images[int.Parse(label12.Text)];
            }
            else
            {
                cardB.Text = label12.Text;                           //
                cardNum2.Text = "12";                                //
                if (cardA.Text == cardB.Text)
                {
                    pictureBox12.Image = imageList1.Images[int.Parse(label12.Text)];
                    pictureBox12.Enabled = false;                        //
                    OpenCard(cardNum1.Text);
                }
                else
                {
                    cardA.Text = "";
                    cardB.Text = "";
                    pictureBox12.Image = imageList1.Images[int.Parse(label12.Text)];
                    timer1.Enabled = true;

                }



            }
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            if (cardA.Text == "")
            {
                cardA.Text = label13.Text;                           //
                cardNum1.Text = "13";                                //
                pictureBox13.Image = imageList1.Images[int.Parse(label13.Text)];
            }
            else
            {
                cardB.Text = label13.Text;                           //
                cardNum2.Text = "13";                                //
                if (cardA.Text == cardB.Text)
                {
                    pictureBox13.Image = imageList1.Images[int.Parse(label13.Text)];
                    pictureBox13.Enabled = false;                        //
                    OpenCard(cardNum1.Text);
                }
                else
                {
                    cardA.Text = "";
                    cardB.Text = "";
                    pictureBox13.Image = imageList1.Images[int.Parse(label13.Text)];
                    timer1.Enabled = true;

                }



            }
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            if (cardA.Text == "")
            {
                cardA.Text = label14.Text;                           //
                cardNum1.Text = "14";                                //
                pictureBox14.Image = imageList1.Images[int.Parse(label14.Text)];
            }
            else
            {
                cardB.Text = label14.Text;                           //
                cardNum2.Text = "14";                                //
                if (cardA.Text == cardB.Text)
                {
                    pictureBox14.Image = imageList1.Images[int.Parse(label14.Text)];
                    pictureBox14.Enabled = false;                        //
                    OpenCard(cardNum1.Text);
                }
                else
                {
                    cardA.Text = "";
                    cardB.Text = "";
                    pictureBox14.Image = imageList1.Images[int.Parse(label14.Text)];
                    timer1.Enabled = true;

                }



            }
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            if (cardA.Text == "")
            {
                cardA.Text = label15.Text;                           //
                cardNum1.Text = "15";                                //
                pictureBox15.Image = imageList1.Images[int.Parse(label15.Text)];
            }
            else
            {
                cardB.Text = label15.Text;                           //
                cardNum2.Text = "15";                                //
                if (cardA.Text == cardB.Text)
                {
                    pictureBox15.Image = imageList1.Images[int.Parse(label15.Text)];
                    pictureBox15.Enabled = false;                        //
                    OpenCard(cardNum1.Text);
                }
                else
                {
                    cardA.Text = "";
                    cardB.Text = "";
                    pictureBox15.Image = imageList1.Images[int.Parse(label15.Text)];
                    timer1.Enabled = true;

                }



            }
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            if (cardA.Text == "")
            {
                cardA.Text = label16.Text;                           //
                cardNum1.Text = "16";                                //
                pictureBox16.Image = imageList1.Images[int.Parse(label16.Text)];
            }
            else
            {
                cardB.Text = label16.Text;                           //
                cardNum2.Text = "16";                                //
                if (cardA.Text == cardB.Text)
                {
                    pictureBox16.Image = imageList1.Images[int.Parse(label16.Text)];
                    pictureBox16.Enabled = false;                        //
                    OpenCard(cardNum1.Text);
                }
                else
                {
                    cardA.Text = "";
                    cardB.Text = "";
                    pictureBox16.Image = imageList1.Images[int.Parse(label16.Text)];
                    timer1.Enabled = true;

                }



            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label16.Visible = false;

            timer2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            label12.Visible = true;
            label13.Visible = true;
            label14.Visible = true;
            label15.Visible = true;
            label16.Visible = true;

            timer2.Enabled = true;
        }
    }
}
