using _2labaFinal.Models;
using _2labaFinal.Models.Machine;
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
        private Dictionary<int, Form1> automats = new Dictionary<int, Form1>();
        private List<WaterProvider> companies = new List<WaterProvider>();

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
            var index = listBoxAutomats.SelectedIndex;

            if (index != ListBox.NoMatches)
            {
                automats[index].ShowDialog();
            }
        }

        private void listBoxCompanies_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnNewAutomat.Enabled = true;
            var index = listBoxCompanies.SelectedIndex;
            if (index != ListBox.NoMatches)
            {
                MessageBox.Show(index.ToString());
            }
        }

        private void btnNewCompany_Click(object sender, EventArgs e)
        {
            var companie = new WaterProvider("Sebek", "Chuhuiv, Yabluneva 18", "ED22313",
                new List<WaterTank>{ new WaterTank(1000),  new WaterTank(1300)});
            listBoxCompanies.Items.Add(companie.Name);
            companies.Add(companie);
        }
    }
}
