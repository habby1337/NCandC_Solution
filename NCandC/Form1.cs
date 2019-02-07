using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data;

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
           /* Players.giocatori[0] = "Geppetto";
            Players.giocatori[1] = "Peppino";
            Players.giocatori[2] = "Peppetto";*/

            setPlayers();
/*
            setPoints(1, 60); //TODO REMOVVE
            setPoints(0, 200); //TODO REMOVVE
            setPoints(2, 450); //TODO REMOVVE*/
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

        private void setPoints(int PlayerID, int point)
        {
            int i = 0;
            string pl = Players.giocatori[PlayerID];
            /*Segna i punti sulla classe del player*/
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {

                if (row.Cells[0].Value.ToString().Contains(pl))
                {
                    dataGridView1.Rows.RemoveAt(i);
                    this.dataGridView1.Rows.Add(Players.giocatori[PlayerID], point);
                    



                    break;
                }
                i++;
                
                //row.Cells["chat1"].Style.ForeColor = Color.CadetBlue;
            }

            //this.dataGridView1.Rows.Add(Players.giocatori[PlayerID], point);

        }

        private void getPoints()
        {
            /*scrive i punti sulla classe del player*/
        }

        private void setPlayers()
        {
            foreach (var item in Players.giocatori)
            {
                if (item != null)
                {
                    this.dataGridView1.Rows.Add(item, "0");
                }
            }
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

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
