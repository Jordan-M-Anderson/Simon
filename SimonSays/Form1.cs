using System;
using System.Media;
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
        
        //The sounds added from Recorces and created using Bfxr
        SoundPlayer orangeSound = new SoundPlayer(SimonSays.Properties.Resources.Orange);
        SoundPlayer blueSound = new SoundPlayer(SimonSays.Properties.Resources.Blue);
        SoundPlayer greenSound = new SoundPlayer(SimonSays.Properties.Resources.Green);
        SoundPlayer yellowSound = new SoundPlayer(SimonSays.Properties.Resources.Yellow);
        SoundPlayer purpleSound = new SoundPlayer(SimonSays.Properties.Resources.Purple);
        SoundPlayer redSound = new SoundPlayer(SimonSays.Properties.Resources.Red);


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
                        Orange.BackColor = Color.Transparent;
                        orangeSound.Play();
                        Thread.Sleep(200);
                        Orange.BackColor = Color.Orange;
                        break;

                    case 1:
                        Blue.BackColor = Color.Transparent;
                        blueSound.Play();
                        Thread.Sleep(200);
                        Blue.BackColor = Color.Blue;
                        break;

                    case 2:
                        Green.BackColor = Color.Transparent;
                        greenSound.Play();
                        Thread.Sleep(200);
                        Green.BackColor = Color.Green;
                        break;

                    case 3:
                        Purple.BackColor = Color.Transparent;
                        purpleSound.Play();
                        Thread.Sleep(200);
                        Purple.BackColor = Color.Purple;
                        break;

                    case 4:
                        Red.BackColor = Color.Transparent;
                        redSound.Play();
                        Thread.Sleep(200);
                        Red.BackColor = Color.Red;
                        break;

                    case 5:
                        Yellow.BackColor = Color.Transparent;
                        yellowSound.Play();
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
            else if (colorList[position] == testColor)
            {
                position++;
            }
            else
            {
                MessageBox.Show("Game Over... Final Score: " + (colorList.Count - 1));
                position = 0;
                isActive = false;
                colorList = new List<int>();
                return;
            }

            if (position >= colorList.Count)
            {
                colorList.Add(colorGen.Next(6));
                position = 0;
                new Thread(showColors).Start();
            }

            Score.Text = ("Score: " + (colorList.Count - 1));

            if (colorList.Count - 1 > highScore)
            {
                highScore++;
                HighScore.Text = ("High Score: " + highScore);
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
