using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2labaFinal
{
    public partial class Menu : Form
    {
        Dictionary<int, Form1> automats = new Dictionary<int, Form1>();

        public Menu()
        {
            InitializeComponent();
        }

        private void btnNewAutomat_Click(object sender, EventArgs e)
        {
            var addAutomat = new AddAutomat();
            addAutomat.ShowDialog();
            if (addAutomat.CreatedMachine.Address != "default")
            {
                var automatForm = new Form1(addAutomat.CreatedMachine, automats.Count);
                automats.Add(automats.Count, automatForm);
                listBoxAutomats.Items.Add(automatForm.AutomatAdress);
                automatForm.ShowDialog();
            }
        }

        private void listBoxAutomats_DoubleClick(object sender, EventArgs e)
        {
            var index = listBoxAutomats.IndexFromPoint(((MouseEventArgs) e).Location);

            if (index != ListBox.NoMatches)
            {
                automats[index].ShowDialog();
            }
        }
    }
}
