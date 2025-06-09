using Finance.Data;
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
    public partial class AddTransacttion : Form
    {
        public Transaction transaction { get; private set; }
        private List<Transaction> transactionsForm = new();
        private TransactionRepository repositorySave = new();
        public AddTransacttion(List<Transaction> transactions)
        {
            InitializeComponent(); // Инициализатор формы
            transactionsForm = transactions;
            ComboTypeCategory();
        }

        private void ComboTypeCategory()
        {
            // Метод AddRange() добавляет массив элементов в коллекцию ComboBox за одну операцию.
            // Это удобнее и эффективнее, чем добавлять элементы по одному через Add().
            coboxType.Items.AddRange(new[] { "Доход", "Расход" });
            // SelectedIndex — свойство, которое задает или возвращает индекс выбранного элемента в списке.
            coboxType.SelectedIndex = 0;

            coboxCategory.Items.AddRange(new[] { "Зарплата", "Транспорт", "Развлечения", "Прочее" });
            coboxCategory.SelectedIndex = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(textSum.Text, out decimal amount) || amount <= 0)
            {
                MessageBox.Show("Введите корректную сумму", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }
            if (coboxType.Text == "Расход")
            {
                decimal expense = transactionsForm.Where(t => t.Type == "Доход").Sum(t => t.Amount);
                if ( expense < amount)
                {
                    MessageBox.Show("Денег недостаточно", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }


            transaction = new Transaction
            {
                Type = coboxType.Text,
                Category = coboxCategory.Text,
                Amount = amount,
                Date = datePicker.Value.Date,
                Description = textDescription.Text,
            };

            repositorySave.Add(transaction);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.Cancel;
            this.Close();
        }
    }
}
