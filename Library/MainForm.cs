using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void biblio_Click(object sender, EventArgs e)
        {
            Biblio b = new Biblio();
            b.Show();
            Hide();
        }

        private void reader_Click(object sender, EventArgs e)
        {
            Reader r = new Reader();
            r.Show();
            Hide();
        }
    }
}
