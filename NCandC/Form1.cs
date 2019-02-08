using Data;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace NCandC
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            timer1.Interval = 1000;
            timer1.Start();
        }

        private int curr_player = 0;
        private int NumPlayer = Players.giocatori.Length - 1;
        private void Home_Load(object sender, EventArgs e)
        {
            guessWord();
            setPlayers();
            getPlayerTurn(NumPlayer);
        }

        private void TBWord_TextChanged(object sender, EventArgs e)
        {
            if (TBWord.Text.Length <= 0) return;

            string s = TBWord.Text.Substring(0, 1);

            if (s != s.ToUpper())
            {
                int curSelStart = TBWord.SelectionStart;
                int curSelLength = TBWord.SelectionLength;
                TBWord.SelectionStart = 0;
                TBWord.SelectionLength = 1;
                TBWord.SelectedText = s.ToUpper();
                TBWord.SelectionStart = curSelStart;
                TBWord.SelectionLength = curSelLength;
            }
        }

        private void guessWord()
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
            string pl = Players.giocatori[(PlayerID - 1)];
            /*Segna i punti sulla classe del player*/
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value.ToString().Contains(pl))
                {
                    dataGridView1.Rows.RemoveAt(i);
                    point = point + Convert.ToInt16(row.Cells[1].Value.ToString());
                    dataGridView1.Rows.Add(Players.giocatori[(PlayerID - 1)], point);

                    break;
                }
                i++;
            }
        }

        private void setPlayers()
        {
            foreach (string item in Players.giocatori)
            {
                if (item != null)
                {
                    dataGridView1.Rows.Add(item, "0");
                }
            }
        }

        private void getPlayerTurn(int maxPlayer)
        {
            if (curr_player <= maxPlayer)
            {
                lplayername.Text = Players.giocatori[curr_player];

            }
            else
            {
                curr_player = 0;
                lplayername.Text = Players.giocatori[curr_player];
            }
            curr_player++;

        }

        private void bInsert_Click(object sender, EventArgs e)
        {
            if (TBWord.Text != "")
            {
                DialogResult result = MessageBox.Show(lWord.Text + "\nLa parola: " + TBWord.Text + " è corretta?", "Nomi Cose e Città", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    //TODO 

                    /*
                     * Cercare se già inserita
                     * Aggiungere punti 
                     */
                    setPoints(curr_player, 20);

                }
                else
                {
                    setPoints(curr_player, 1);
                    /*NO POINTS 4 YOU NOOB*/
                }
                TBWord.Clear();
                getPlayerTurn(NumPlayer);
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (MessageBox.Show("Sei sicuro di voler uscire?",
                               "NCandC",
                                MessageBoxButtons.OKCancel,
                                MessageBoxIcon.Information) == DialogResult.OK)
                {
                    Environment.Exit(1);
                }
                else
                {
                    e.Cancel = true; // to don't close form is user change his mind
                }
            }

        }

        private void TBWord_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bInsert_Click(sender, e);
            }
        }

        Random rnd = new Random();

        private void timer1_Tick(object sender, EventArgs e)
        {
            Text = "NCeC :: Home | " + DateTime.Now.ToString("HH:mm:ss") + " |";
            

            Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            lplayername.ForeColor = randomColor;
            bInsert.ForeColor = randomColor;
            bInsert.FlatAppearance.BorderColor = randomColor;
        }
    }
}
