﻿using Finance.Data;
using Finance.Forms;
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

namespace Finance
{
    public partial class Main : Form
    {
        private List<Transaction> transactions = new();
        private TransactionRepository repository = new();
        public Main()
        {
            
            InitializeComponent();
            LoadTransaction();
        }

        private void LoadTransaction()
        {
            transactions = repository.LoadAll();
            UpdateBalance();
            ShowRecentTransaction();
        }

        private void ShowRecentTransaction()
        {
            listBoxRecent.Items.Clear();
            var lastFive = transactions.OrderByDescending(t => t.Date).Take(10);
            foreach (var t in lastFive)
            {
                listBoxRecent.Items.Add($"{t.Date:dd.MM.yyyy} - {t.Category}({t.Type}):{t.Amount:C}");
            }
        }

        private void UpdateBalance()
        {
            decimal income = transactions.Where(t => t.Type == "Доход").Sum(t => t.Amount);
            decimal expense = transactions.Where(t => t.Type == "Расход").Sum(t => t.Amount);

            labelBalance.Text = $"Баланс: {income - expense:C}";
        }

        // form.ShowDialog()
        // Открывает форму в модальном режиме (блокирует взаимодействие с родительским окном до закрытия диалога).
        // Возвращает значение типа DialogResult, которое указывает, как пользователь закрыл форму (например, OK, Cancel).

        // DialogResult.OK
        // Это стандартное значение, которое обычно возвращается, когда пользователь подтверждает действие (например, нажал кнопку "OK", "Сохранить" и т.д.).
        // Если форма была закрыта с результатом OK, выполняется код внутри блока if.
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // using, чтобы автоматически вызвать Dispose() для формы.
            using (var form = new AddTransacttion(transactions))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadTransaction();
                }
            }
        }


        private void btnHistory_Click(object sender, EventArgs e)
        {
            var form = new History();
            form.ShowDialog();
            LoadTransaction();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            var form = new Report(transactions);
            form.ShowDialog();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            var form = new Settings();
            form.ShowDialog();
        }

        private void btnExperiment_Click(object sender, EventArgs e)
        {
            var form = new Example();
            form.ShowDialog();
        }
    }
}
