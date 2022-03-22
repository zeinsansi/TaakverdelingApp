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
    public partial class MijnGroepn : Form
    {
        DatabaseManeger db = new();
        public MijnGroepn()
        {
            InitializeComponent();
        }

        private void btnGroepMaken_Click(object sender, EventArgs e)
        {
            GroepMaken g = new();
            this.Hide();
            g.ShowDialog();
        }

        private void MijnGroepn_Load(object sender, EventArgs e)
        {
            FilGroepList();
        }

        private void lbxMijnGroepen_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilGroepledenList();
          
            /*            Form1 f = new();
                        this.Hide();
                        f.ShowDialog();*/
        }

        private void FilGroepList()
        {
            lbxMijnGroepen.DataSource = db.GetGroepen();
            lbxMijnGroepen.DisplayMember = "Naam";
            lbxMijnGroepen.ValueMember = "Id";
        }

        private void FilGroepledenList()
        {
            int id;
            Int32.TryParse(lbxMijnGroepen.SelectedValue.ToString(), out id);
            lbGroepleden.DataSource = db.GetGroepleden(id);
            lbGroepleden.DisplayMember = "Naam";
            lbGroepleden.ValueMember = "Id";
        }

        private void btnVerwijderen_Click(object sender, EventArgs e)
        {
            bool parseResult = int.TryParse(lbxMijnGroepen.SelectedValue.ToString(), out int id);
            if (parseResult)
            {
                Groep groep = db.GroepWeergeven(Convert.ToInt32(lbxMijnGroepen.SelectedValue));
                if (groep != null)
                {
                    DialogResult result = MessageBox.Show($"{groep}\n\nWil je deze groep verwijderen?", "Groep Beschrijving", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        db.GroepVerwijderen(Convert.ToInt32(lbxMijnGroepen.SelectedValue));
                        FilGroepList();
                    }
                }
            }
        }
    }
}
