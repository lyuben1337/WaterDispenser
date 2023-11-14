using _2labaFinal.Models;
using _2labaFinal.Models.Company;
using _2labaFinal.Models.Machine;
using _2labaFinal.Utils;
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
        private List<WaterProvider> companies = CompanyRepository.Instance.WaterProviders;
        private WaterProvider choosenCompany = null;
        public Menu()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void drawAutomatsForm()
        {
            listBoxAutomats.Items.Clear();
            foreach (var automat in choosenCompany.GetMachines())
            {
                listBoxAutomats.Items.Add(automat.Address);
            }
        }

        private void btnNewAutomat_Click(object sender, EventArgs e)
        {
            var addAutomat = new AddAutomat(listBoxCompanies.SelectedIndex);
            addAutomat.ShowDialog();
            if (addAutomat.CreatedMachine.Address != "default")
            {
                try
                {
                    choosenCompany.AddMachine(addAutomat.CreatedMachine);
                    var automatForm = new Form1(addAutomat.CreatedMachine);
                    listBoxAutomats.Items.Add(automatForm.AutomatAdress);
                    automatForm.ShowDialog();
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
        }

        private void listBoxAutomats_DoubleClick(object sender, EventArgs e)
        {
            var index = listBoxAutomats.IndexFromPoint(((MouseEventArgs)e).Location);

            if (index != ListBox.NoMatches)
            {
                var automat = choosenCompany.GetMachines()[index];
                var automatForm = new Form1(automat);
                automatForm.ShowDialog();
            }
        }

        private void btnNewCompany_Click(object sender, EventArgs e)
        {
            var addCompanyForm = new AddCompany();
            addCompanyForm.ShowDialog();
            if (addCompanyForm.CreatedCompany == null)
                return;
            var company = addCompanyForm.CreatedCompany;
            listBoxCompanies.Items.Add(company.Name);
            companies.Add(company);
        }

        private void listBoxCompanies_Click(object sender, EventArgs e)
        {
            var index = listBoxCompanies.IndexFromPoint(((MouseEventArgs)e).Location);
            if (index == ListBox.NoMatches) return;
            btnNewAutomat.Enabled = true;
            choosenCompany = companies[index];
            drawAutomatsForm();
        }

        private void Menu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete) 
            {
                var index = listBoxAutomats.SelectedIndex;
                if (index == ListBox.NoMatches) return;
                listBoxAutomats.Items.RemoveAt(index);
                choosenCompany.RemoveMachine(index);
            }
        }

        private void listBoxCompanies_DoubleClick(object sender, EventArgs e)
        {
            var index = listBoxCompanies.IndexFromPoint(((MouseEventArgs)e).Location);

            if (index != ListBox.NoMatches)
            {
                var companyForm = new Company(choosenCompany);
                companyForm.ShowDialog();
            }
        }

        private void companyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
                openFileDialog.Title = "Add Company";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var company = CompanyFileManager.LoadCompany(openFileDialog.FileName);
                    listBoxCompanies.Items.Add(company.Name);
                    company.Machines.ForEach(m => m.CompanyID = companies.Count);
                    companies.Add(company);
                    MessageBox.Show("Company added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}