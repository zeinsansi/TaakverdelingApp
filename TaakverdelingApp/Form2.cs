using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void btnTerug_Click(object sender, EventArgs e)
        {
            Form1 f = new ();
            this.Hide();    
            f.ShowDialog();
        }

        private void MijnGroepn_Load(object sender, EventArgs e)
        {
            lbxMijnGroepen.Items.AddRange(db.GetGroepn().ToArray());
        }
    }
}
