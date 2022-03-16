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
    public partial class Form1 : Form
    {
        List<Taak> taken;
        DatabaseManeger db = new DatabaseManeger();
        public Form1()
        {
            InitializeComponent();
        }
        public Form1(List<Taak> taken)
        {
            InitializeComponent();
            this.taken = taken;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            db.TestToevoegen("Zein");
            if(taken != null)
            {
                TaakToevoegen taak = new TaakToevoegen(taken);
                this.Hide();
                taak.ShowDialog();
            }
            else
            {
                TaakToevoegen taak = new TaakToevoegen();
                this.Hide();
                taak.ShowDialog();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if(taken != null)
            {
                lbxTaken.Items.AddRange(taken.ToArray());
            }
        }

        private void lbxTaken_SelectedIndexChanged(object sender, EventArgs e)
        {
            Taak taak = lbxTaken.SelectedItem as Taak;
            if(taak != null)
            {
               DialogResult result =  MessageBox.Show($"{taak}\n\nWil je deze taak verwijderen?","Taak Beschrijving",MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    lbxTaken.Items.Clear();
                    this.taken.Remove(taak);
                    lbxTaken.Items.AddRange(taken.ToArray());
                }
            }
        }
    }
}
