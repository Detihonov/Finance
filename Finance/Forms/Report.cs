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
    public partial class Report : Form
    {
        private TransactionRepository repository = new TransactionRepository();
        private List<Transaction> transaction;
        private List<Transaction> transactionOut;
        public Report(List<Transaction> transactions)
        {
            InitializeComponent();
            dateBeginningPeriod.Value = DateTime.Now.AddMonths(-1);
            dateEndPeriod.Value = DateTime.Now;
            this.transaction = transactions;
        }

        private void viewReport_Click(object sender, EventArgs e)
        {
            DateTime start = dateBeginningPeriod.Value.Date;
            DateTime end = dateEndPeriod.Value.Date;

            transactionOut = repository.LoadAll().Where(t => t.Date >= start && t.Date <= end).ToList();

            decimal income = transactionOut.Where(t => t.Type == "Доход").Sum(t => t.Amount);
            decimal expense = transactionOut.Where(t => t.Type == "Расход").Sum(t => t.Amount);
            decimal balance = income - expense;

            labelIncome.Text = "Доход: " + income.ToString("0.00");
            labelExpenditure.Text = "Расход: " + expense.ToString("0.00");
            labelBalance.Text = "Баланс: " + balance.ToString("0.00");

            // panel1.Controls.Clear();
            Invalidate();
        }

        private void DrawChart(Graphics g)
        {
            var chartTop = 200;
            var barWidth = 40;
            var spacing = 20;
            var startX = 50;
            var font = new Font("Segoe UI", 9);
            var incomeBrush = Brushes.Green;
            var expenseBrush = Brushes.Red;

            var categories = transactionOut
                .GroupBy(t => t.Category)
                .Select(grp => new
                {
                    Category = grp.Key,
                    Income = grp.Where(t => t.Type == "Доход").Sum(t => t.Amount),
                    Expense = grp.Where(t => t.Type == "Расход").Sum(t => t.Amount)
                }).ToList();

            // Any() - Проверка наличия элементов в коллекции.
            if (!categories.Any())
            {
                return;
            }

            decimal maxValue = categories.Select(c => Math.Max(c.Income, c.Expense)).Max();
            float scale = 150f / (float)maxValue; // шкала до 150 пикселей
            int x = startX;

            foreach (var cat in categories)
            {
                // Доход
                int incomeHeight = (int)(cat.Income * (decimal)scale);
                g.FillRectangle(incomeBrush, x, chartTop - incomeHeight, barWidth, incomeHeight);
                g.DrawString("↑", font,incomeBrush, x + 10, chartTop - incomeHeight - 15);

                // Расход
                int expenseHeight = (int)(cat.Expense * (decimal)scale);
                g.FillRectangle(expenseBrush, x + barWidth + 5, chartTop - expenseHeight - 15, barWidth, expenseHeight);
                g.DrawString("↓", font, expenseBrush, x + barWidth + 15, chartTop - expenseHeight - 15);

                // Категории
                g.DrawString(cat.Category, font, Brushes.Black, x, chartTop + 10);
                x += (barWidth * 2) + spacing;
            }

            g.DrawString("Гистограмма доходов и расходов по категориям", new Font("Segoe UI", 12, FontStyle.Bold), Brushes.Black, 20, chartTop - 180);
        }

        private void Report_Paint(object sender, PaintEventArgs e)
        {
            if (transactionOut == null || transactionOut.Count == 0)
            {
                return;
            }

            DrawChart(e.Graphics);
        }
    }
}
