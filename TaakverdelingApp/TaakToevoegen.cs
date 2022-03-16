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
        List<Taak> taken;
        public TaakToevoegen(List<Taak> taken)
        {
            InitializeComponent();
            this.taken = taken;
        }
        public TaakToevoegen()
        {
            InitializeComponent();
            taken = new List<Taak>();
        }
        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            if(tbBeschrijving.Text != "" && tbNaam.Text != "")
            {
                taken.Add(new Taak(tbNaam.Text, tbBeschrijving.Text, datePicker.Value));
                MessageBox.Show("Taak toegevoegd");
            }
        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
            if(taken != null)
            {
                Form1 f = new Form1(taken);
                this.Hide();
                f.ShowDialog();
            }
            else
            {
                Form1 form = new Form1();
                this.Hide();
                form.ShowDialog();
            }
        }

        private void TaakToevoegen_Load(object sender, EventArgs e)
        {

        }
    }
}
