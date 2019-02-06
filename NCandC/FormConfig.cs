using System;
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

        private void popUp(string testo)
        {
            MessageBox.Show(testo, "AVVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    popUp("Nummero massimo di giocatori raggiunto.");
                }
            }
            else
            {
                popUp("Inserisci il nome del giocatore prima.");
            }
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
                popUp("Non ci sono più giocatori nella lista.");
            }
        }

        public void createDictionaries()
        {
           

        }

        public void bApply_Click(object sender, EventArgs e)
        {
            createDictionaries();
        }
    }
}
