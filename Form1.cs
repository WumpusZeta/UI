using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    class DisplayUI
    {
        static void Main(string[] args)
        {
        }

        public static void DisplayPlayer(/*gameLocation, playerobject*/)
        {
            //displays the player on the screen in the given location
        }
        public int DisplayHS(/*HighScore, Score*/)
        {
            //when tab is hit a popup apear on screen displaying the current score and highScore
            int HS = 1000;
            return HS;
        }
        public static void DisplayTrivia(/*TriviaQs*/)
        {
            //Displays the trivia questions
        }
        public static void DisplayWumpus(/*Wumpus*/)
        {
            //When player encounters wumpus the wumpous is displayed on screen.
        }
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String HS = "1000";
            HighScoreDisplay.Text = HS;
        }
        private System.Windows.Forms.Button button1;


        private System.Windows.Forms.Label HighScoreDisplay;

        private void label1_Click(object sender, System.EventArgs e)
        {
            int HS = 1000;
        }
    }

}