using Finance.Data;
using Finance.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finance.Forms
{
    public partial class History : Form
    {
        private TransactionRepository repository = new();
        private List<Transaction> allTransaction = new();
        public History()
        {
            InitializeComponent();
            comboFilter.Items.Clear();
            comboFilter.Items.AddRange(new[] { "Все", "Доход", "Расход" });
            comboFilter.SelectedIndex = 0;

            dataGridTable.AutoGenerateColumns = true;

            LoadHistory();
        }

        private void LoadHistory()
        {
            allTransaction = repository.LoadAll();
            UpdateTable();
        }

        private void UpdateTable()
        {
            string filter = comboFilter.Text;
            var filtered = allTransaction;

            if (filter != "Все")
            {
                filtered = allTransaction.Where(t => t.Type == filter).ToList();
            }

            dataGridTable.DataSource = new object();
            dataGridTable.DataSource = filtered;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridTable.SelectedRows.Count == 0)
            { 
                MessageBox.Show("Выберите всю строку целиком !!!");
                dataGridTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                return;
            }

            if (dataGridTable.SelectedRows.Count > 0)
            {
                int index = dataGridTable.SelectedRows[0].Index;
                string dataStr = dataGridTable.Rows[index].Cells[0].Value.ToString();
                string type = dataGridTable.Rows[index].Cells[1].Value.ToString();
                string category = dataGridTable.Rows[index].Cells[2].Value.ToString();
                decimal amount = decimal.Parse(dataGridTable.Rows[index].Cells[3].Value.ToString());

                DateTime date = DateTime.Parse(dataStr);

                var toRemote = allTransaction.FirstOrDefault(t => 
                               t.Date.Date == date.Date 
                               && t.Type == type 
                               && t.Category == category 
                               && t.Amount == amount
                );

                if (toRemote != null)
                {
                    allTransaction.Remove(toRemote);
                    repository.SaveAll(allTransaction);
                }

                UpdateTable();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTable();
        }
        
    }
}
