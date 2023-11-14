namespace _2labaFinal
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNewAutomat = new System.Windows.Forms.Button();
            this.listBoxAutomats = new System.Windows.Forms.ListBox();
            this.listBoxCompanies = new System.Windows.Forms.ListBox();
            this.btnNewCompany = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.companyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNewAutomat
            // 
            this.btnNewAutomat.Enabled = false;
            this.btnNewAutomat.Font = new System.Drawing.Font("Impact", 15.75F);
            this.btnNewAutomat.ForeColor = System.Drawing.Color.SlateGray;
            this.btnNewAutomat.Location = new System.Drawing.Point(239, 253);
            this.btnNewAutomat.Name = "btnNewAutomat";
            this.btnNewAutomat.Size = new System.Drawing.Size(221, 42);
            this.btnNewAutomat.TabIndex = 33;
            this.btnNewAutomat.Text = "New Automat";
            this.btnNewAutomat.UseVisualStyleBackColor = true;
            this.btnNewAutomat.Click += new System.EventHandler(this.btnNewAutomat_Click);
            // 
            // listBoxAutomats
            // 
            this.listBoxAutomats.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxAutomats.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.listBoxAutomats.FormattingEnabled = true;
            this.listBoxAutomats.ItemHeight = 21;
            this.listBoxAutomats.Location = new System.Drawing.Point(239, 23);
            this.listBoxAutomats.Name = "listBoxAutomats";
            this.listBoxAutomats.Size = new System.Drawing.Size(221, 214);
            this.listBoxAutomats.TabIndex = 34;
            this.listBoxAutomats.DoubleClick += new System.EventHandler(this.listBoxAutomats_DoubleClick);
            // 
            // listBoxCompanies
            // 
            this.listBoxCompanies.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxCompanies.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.listBoxCompanies.FormattingEnabled = true;
            this.listBoxCompanies.ItemHeight = 21;
            this.listBoxCompanies.Location = new System.Drawing.Point(12, 23);
            this.listBoxCompanies.Name = "listBoxCompanies";
            this.listBoxCompanies.Size = new System.Drawing.Size(221, 214);
            this.listBoxCompanies.TabIndex = 36;
            this.listBoxCompanies.Click += new System.EventHandler(this.listBoxCompanies_Click);
            this.listBoxCompanies.DoubleClick += new System.EventHandler(this.listBoxCompanies_DoubleClick);
            // 
            // btnNewCompany
            // 
            this.btnNewCompany.Font = new System.Drawing.Font("Impact", 15.75F);
            this.btnNewCompany.ForeColor = System.Drawing.Color.SlateGray;
            this.btnNewCompany.Location = new System.Drawing.Point(12, 253);
            this.btnNewCompany.Name = "btnNewCompany";
            this.btnNewCompany.Size = new System.Drawing.Size(221, 42);
            this.btnNewCompany.TabIndex = 35;
            this.btnNewCompany.Text = "New Company";
            this.btnNewCompany.UseVisualStyleBackColor = true;
            this.btnNewCompany.Click += new System.EventHandler(this.btnNewCompany_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(470, 24);
            this.menuStrip1.TabIndex = 37;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.companyToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // companyToolStripMenuItem
            // 
            this.companyToolStripMenuItem.Name = "companyToolStripMenuItem";
            this.companyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.companyToolStripMenuItem.Text = "Company";
            this.companyToolStripMenuItem.Click += new System.EventHandler(this.companyToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(470, 303);
            this.Controls.Add(this.listBoxCompanies);
            this.Controls.Add(this.btnNewCompany);
            this.Controls.Add(this.listBoxAutomats);
            this.Controls.Add(this.btnNewAutomat);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Menu";
            this.Text = "Menu";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Menu_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewAutomat;
        private System.Windows.Forms.ListBox listBoxAutomats;
        private System.Windows.Forms.ListBox listBoxCompanies;
        private System.Windows.Forms.Button btnNewCompany;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem companyToolStripMenuItem;
    }
}