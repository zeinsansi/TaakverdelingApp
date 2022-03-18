using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaakVerdelingLibrary;

namespace TaakverdelingApp
{
    public partial class TaakToevoegen : Form
    {

        DatabaseManeger DBM = new DatabaseManeger();  
        public TaakToevoegen()
        {
            InitializeComponent();
        }
        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            if(tbBeschrijving.Text != "" && tbNaam.Text != "")
            {
                DBM.TaakToevoegen(new Taak(tbNaam.Text, tbBeschrijving.Text, datePicker.Value));
                MessageBox.Show("Taak toegevoegd");
            }
        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
                Form1 f = new Form1();
                this.Hide();
                f.ShowDialog();
        }

        private void TaakToevoegen_Load(object sender, EventArgs e)
        {

        }
    }
}
