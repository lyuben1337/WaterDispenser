using _2labaFinal.Models;
using _2labaFinal.Models.Company;
using _2labaFinal.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2labaFinal
{
    public partial class Company : Form
    {
        private WaterProvider _company;
        public Company(WaterProvider company)
        {
            _company = company;
            InitializeComponent();
            drawComponents();
        }
        void drawComponents()
        {
            labelCompanyName.Text += _company.Name;
            labelCompanyAdress.Text += _company.Adress;
            labelEDRPOU.Text += _company.ID;
            labelMaxTankVolume.Text += _company.MaxTankVolume.ToString();
            labelIncome.Text += _company.GetIncome();

            comboBoxTanks.Items.AddRange(Enumerable.Range(1, _company.GetTanks().Count).ToList().ConvertAll(el => el.ToString()).ToArray());
        }

        private void comboBoxTanks_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAddWater.Enabled = true;
            drawWaterBar();
        }

        private void drawWaterBar()
        {
            var tank = _company.GetTanks()[comboBoxTanks.SelectedIndex];
            var waterCountProcent = 100 * tank.Volume / _company.MaxTankVolume;
            for (int i = 0; i <= waterCountProcent; i++)
            {
                UpdateProgressBar(i);

                Thread.Sleep(5);
            }
        }

        private void UpdateProgressBar(int value)
        {
            // Use BeginInvoke to update UI controls from a non-UI thread
            if (progressBarWater.InvokeRequired)
            {
                BeginInvoke((MethodInvoker)delegate () {
                    progressBarWater.Value = value;
                });
            }
            else
            {
                progressBarWater.Value = value;
            }
        }
        private void btnAddWater_Click(object sender, EventArgs e)
        {
            try
            {
                var volume = double.Parse(textBoxTankVolume.Text);
                _company.AddWater(volume, comboBoxTanks.SelectedIndex);
                drawWaterBar();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnSaveLogs_Click(object sender, EventArgs e)
        {
            var logs = _company.GetStorage();

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
                saveFileDialog.Title = "Save Logs";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    LogFileManager.SaveLogs(logs, saveFileDialog.FileName);

                    MessageBox.Show("Logs saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnSaveCompany_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
                saveFileDialog.Title = "Save Company";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    CompanyFileManager.SaveCompany(_company, saveFileDialog.FileName);

                    MessageBox.Show("Logs saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
