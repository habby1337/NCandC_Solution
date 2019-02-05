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
            Random rnd = new Random();

            int pos = rnd.Next(0, 20);

            //Console.WriteLine("Pos: " + pos + "\n Letter: " + alphabet[pos]+ "\n  All: " + alphabet);

            alphabet = alphabet.Remove(pos, 1);

            //Console.WriteLine("new arr: " + alphabet);
                
        }

    }
}
