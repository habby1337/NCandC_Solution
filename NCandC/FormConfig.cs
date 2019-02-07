using System;
using System.Windows.Input;
using System.Collections.Generic;
using System.Windows.Forms;
using Data;

namespace NCandC
{
    public partial class FormConfig : Form
    {
        
        public FormConfig()
        {
            InitializeComponent();
        }

        private void FormConfig_Load(object sender, EventArgs e)
        {
            lNumber.Text = Convert.ToString(ListPlayer.Items.Count);
        }

        private void mbox(string testo)
        {
            MessageBox.Show(testo, "AVVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void UNPlayer_TextChanged(object sender, EventArgs e)
        {
            if (UNPlayer.Text.Length <= 0) return;

            string s = UNPlayer.Text.Substring(0, 1);

            if (s != s.ToUpper())
            {
                int curSelStart = UNPlayer.SelectionStart;
                int curSelLength = UNPlayer.SelectionLength;
                UNPlayer.SelectionStart = 0;
                UNPlayer.SelectionLength = 1;
                UNPlayer.SelectedText = s.ToUpper();
                UNPlayer.SelectionStart = curSelStart;
                UNPlayer.SelectionLength = curSelLength;
            }
        }

        private void UNPlayer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bInsert_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Delete)
            {
                bRemove_Click(sender, e);
            }
        }


        private void bInsert_Click(object sender, EventArgs e)
        {
            if (UNPlayer.Text != "")
            {
                if (ListPlayer.Items.Count != 8)
                {
                    ListPlayer.Items.Add(UNPlayer.Text);
                    lNumber.Text = Convert.ToString(ListPlayer.Items.Count);
                }
                else
                {
                    mbox("Nummero massimo di giocatori raggiunto.");
                }
            }
            else
            {
                mbox("Inserisci il nome del giocatore prima.");
            }
            UNPlayer.Clear();
            UNPlayer.Focus();
        }

        private void bRemove_Click(object sender, EventArgs e)
        {
            int i;
            try
            {
                i = ListPlayer.Items.Count;
                ListPlayer.Items.RemoveAt(--i);
                lNumber.Text = Convert.ToString(ListPlayer.Items.Count);
            }
            catch (Exception)
            {
                mbox("Non ci sono più giocatori nella lista.");
            }
            UNPlayer.Clear();
            UNPlayer.Focus();
        }

        public void setGameConf()
        {
            int i = 0;
            Array.Resize(ref Players.giocatori, 8);//Previene un crash se l'utente dovesse aggiungere un giocatore all' ultimo momento

            foreach (var player in ListPlayer.Items)
            {
                Players.giocatori[i] = player.ToString();
                i++;
            }
            Array.Resize(ref Players.giocatori, i);

            /*Just output things*/
            /* foreach (var item in Players.giocatori)
             {
                 Console.WriteLine("Player: " + item + ", ");
             }*/
            Form game = new Home();

            game.Show();
            this.Hide();

        }

        public void bApply_Click(object sender, EventArgs e)
        {
            if (ListPlayer.Items.Count >= 2)
            {
                setGameConf();
            }
            else
            {
                mbox("Giocatori insufficenti per iniziare una partita.");
            }

            
        }

        
    }
}
