using Finance.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finance.Forms
{
    public partial class Example : Form
    {
        private List<Transaction> transactions = new List<Transaction>();
        public Example()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new Settings());
        }

        private void OpenFormInPanel(Form form)
        {
            panelContainer.Controls.Clear();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            form.FormBorderStyle = FormBorderStyle.None;
            panelContainer.Controls.Add(form);
            form.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new AddTransacttion());
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new History());
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new Report(transactions));
        }
    }
}
