using System;
using System.Threading;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimonSays
{
    public partial class Form1 : Form
    {

        private delegate void SafeCallDelegate(Button button, Color color);
        Random colorGen = new Random();
        List<int> colorList = new List<int>();

        bool isActive = false;
        int position = 0;
        int highScore = 0;

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Generates the first color and then creates a new thread of showColors.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void start_Click(object sender, EventArgs e)
        {
            Score.Text = ("Score: 0");
            isActive = true;

            colorList = new List<int>();
            colorList.Add(colorGen.Next(6));

            new Thread(showColors).Start();
        }

        /// <summary>
        /// Makes the button that corresponds to the colors in the list light up in order
        /// with a delay.
        /// </summary>
        void showColors()
        {
            isActive = false;

            foreach (int color in colorList)
            {
                //Will make the button that corresponds to the color in the
                //colorList light up.
                switch (color)
                {
                    case 0:
                        //WriteButtonSafe(Orange, Color.Orange);
                        Orange.BackColor = Color.Transparent;
                        Thread.Sleep(200);
                        Orange.BackColor = Color.Orange;
                        break;

                    case 1:
                        //WriteButtonSafe(Blue, Color.Blue);
                        Blue.BackColor = Color.Transparent;
                        Thread.Sleep(200);
                        Blue.BackColor = Color.Blue;
                        break;

                    case 2:
                        //WriteButtonSafe(Green, Color.Green);
                        Green.BackColor = Color.Transparent;
                        Thread.Sleep(200);
                        Green.BackColor = Color.Green;
                        break;

                    case 3:
                        //WriteButtonSafe(Purple, Color.Purple);
                        Purple.BackColor = Color.Transparent;
                        Thread.Sleep(200);
                        Purple.BackColor = Color.Purple;
                        break;

                    case 4:
                        //WriteButtonSafe(Red, Color.Red);
                        Red.BackColor = Color.Transparent;
                        Thread.Sleep(200);
                        Red.BackColor = Color.Red;
                        break;

                    case 5:
                        //WriteButtonSafe(Yellow, Color.Yellow);
                        Yellow.BackColor = Color.Transparent;
                        Thread.Sleep(200);
                        Yellow.BackColor = Color.Yellow;
                        break;
                }
                Thread.Sleep(200);

            }

            isActive = true;
        }

        /// <summary>
        /// This method is called everytime a button is pressed to check
        /// if that is the correct button. It controls the score and when
        /// the user has lost.
        /// </summary>
        /// <param name="testColor">
        /// testColor is the color corrsponding to 
        /// the button that the user pressed
        /// </param>
        void isCorrect(int testColor)
        {
            if (!isActive)
            {
                return;
            }
            else if (colorList[position] != testColor)
            {
                MessageBox.Show("Game Over... Final Score: " + (colorList.Count - 1));
                position = 0;
                isActive = false;
                colorList = new List<int>();
                return;
            }

            position++;

            Score.Text = ("Score: " + colorList.Count);

            if (colorList.Count > highScore)
            {
                highScore++;
                HighScore.Text = ("High Score: " + highScore);
            }

            if (position >= colorList.Count)
            {
                colorList.Add(colorGen.Next(6));
                position = 0;
                new Thread(showColors).Start();
            }
            
        }

        private void WriteButtonSafe(Button button, Color color)
        {
            if (button.InvokeRequired)
            {
                var d = new SafeCallDelegate(WriteButtonSafe);
                Invoke(d, new object[] { button, color });
                Thread.Sleep(200);
            }
            else
            {
                Thread.Sleep(200);
                button.BackColor = Color.Transparent;
                Thread.Sleep(1000);
                button.BackColor = color;
                Thread.Sleep(200);
            }
        }

        private void Orange_Click(object sender, EventArgs e)
        {
            isCorrect(0);
        }

        private void Blue_Click(object sender, EventArgs e)
        {
            isCorrect(1);
        }

        private void Green_Click(object sender, EventArgs e)
        {
            isCorrect(2);
        }

        private void Purple_Click(object sender, EventArgs e)
        {
            isCorrect(3);
        }

        private void Red_Click(object sender, EventArgs e)
        {
            isCorrect(4);
        }

        private void Yellow_Click(object sender, EventArgs e)
        {
            isCorrect(5);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
