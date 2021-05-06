using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace guessingGame
{
    public partial class Form1 : Form
    {
        Random randGen = new Random();

        int random = 0;


        public Form1()
        {
            InitializeComponent();
            random = randGen.Next(1, 101);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guessButton_Click(object sender, EventArgs e)
        {
            int userGuess = Convert.ToInt32(numInput.Text);

            if (userGuess > random)
            {
                outputLabel.Text = "Too High!";
            }
            else if (userGuess < random)
            {
                outputLabel.Text = "Too low!";
            }
            else if (userGuess == random)
            {
                outputLabel.Text = "You got it!";
                random = randGen.Next(1, 101);
            }

        }
        
    }
}
