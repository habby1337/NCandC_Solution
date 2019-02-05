using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NCandC
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            guess();
        }

        private void guess()
        {
            string alphabet = "ABCDEFGHILMNOPQRSTUVZ";
            string word;
            Random rnd = new Random();

            int pos = rnd.Next(0, 20);

            //Console.WriteLine("Pos: " + pos + "\n Letter: " + alphabet[pos]+ "\n  All: " + alphabet);
            lWord.Text = "Lettera: " + alphabet[pos].ToString();
            word = alphabet[pos].ToString();

            alphabet = alphabet.Remove(pos, 1);
            //Console.WriteLine("new arr: " + alphabet);
        }

        private void setPoints()
        {
            /*Segna i punti sulla classe del player*/
        }

        private void getPoints()
        {
            /*scrive i punti sulla classe del player*/
        }

        private void bInsert_Click(object sender, EventArgs e)
        {
            if (TBWord.Text != "")
            {
                DialogResult result = MessageBox.Show(lWord.Text + "\nLa parola: " + TBWord.Text + " è corretta?", "Game %Game%", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    //TODO 

                    /*
                     * Cercare se già inserita
                     * Aggiungere punti 
                     */
                }
                else
                {
                    /*NO POINTS 4 YOU NOOB*/
                }   

            }
        }
    }
}
