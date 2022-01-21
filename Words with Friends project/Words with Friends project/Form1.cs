using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Words_with_Friends_project
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }


        string[] alphabet = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
        string[] randLetters = new string[8];
        int Score = 0;


        private void BtnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            randomiseLetters();
        }

        private void BtnEnterWord_Click(object sender, EventArgs e)
        {
            string[] dictionary = System.IO.File.ReadAllLines(@"Dictionary.txt");

            int arrayLength = dictionary.Length;
            bool wordFound = false;
            string userWord = txtword.Text;
            userWord = userWord.ToUpper();
            for (int i = 0; i < arrayLength; i++)
            {
                if (userWord == dictionary[i])
                {
                    wordFound = true;
                    break;
                }
            }

            if (wordFound == false)
            {
                MessageBox.Show("Word not found");
            }


            string userInput = txtword.Text;
            Boolean validTextInput = false;

            validTextInput = checkLettersExist(userInput);

            if (validTextInput == true)
            {
                MessageBox.Show("Word can be Made");
                Score = Score + returnScore(userInput);
                lblscore.Text = "Score: " + Score;


            }
            else
            {
                MessageBox.Show("Word can not be Made");

            }
        }
        int returnScore(string word)
        {
            int wordScore = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'A' || word[i] == 'E' || word[i] == 'I' || word[i] == 'L' || word[i] == 'N')
                {
                    wordScore += 1;
                }

                if (word[i] == 'D' || word[i] == 'G')
                {
                    wordScore += 2;
                }
            }

            return wordScore;

        }
    
                
         
        void randomiseLetters()
        {
            System.Random random = new System.Random();
            int randomNum = random.Next(0, 26);


            for (int i = 0; i < 8; i++)
            {
                int number = random.Next(0, alphabet.Length - 1);
                randLetters[i] = alphabet[number];

            }

            lblletter1.Text = randLetters[0];
            lblletter2.Text = randLetters[1];
            lblletter3.Text = randLetters[2];
            lblletter4.Text = randLetters[3];
            lblletter5.Text = randLetters[4];
            lblletter6.Text = randLetters[5];
            lblletter7.Text = randLetters[6];
            lblletter8.Text = randLetters[7];
        }

        Boolean checkLettersExist(string word)
        {
            Boolean LettersExist = true;


            return LettersExist;
            string[] copiedLetters = new string[8];

            for (int i = 0; i < 8; i++)
            {

                copiedLetters[i] = randLetters[i];
            }

            for (int i = 0; i < word.Length; i++)
            {

                for (int wordNum = 0; wordNum < word.Length;)
                {

                }
            }



        }



        

        private void BtnRandomise_Click_1(object sender, EventArgs e)
        {

            randomiseLetters();

        }
    }
}


