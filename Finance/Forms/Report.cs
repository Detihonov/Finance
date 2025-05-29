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
        public Report(List<Transaction> transaction)
        {
            InitializeComponent();
            dateBeginningPeriod.Value = DateTime.Now.AddMonths(-1);
            dateEndPeriod.Value = DateTime.Now;
            this.transaction = transaction;
        }

        private void viewReport_Click(object sender, EventArgs e)
        {
            DateTime start = dateBeginningPeriod.Value.Date;
            DateTime end = dateEndPeriod.Value.Date;

            transactionOut = repository.LoadAll().Where(t => t.Date >= start && t.Date <= end).ToList();

            decimal income = transactionOut.Where(t => t.Type == "Доход").Sum(t => t.Amount);
            decimal expenditure = transactionOut.Where(t => t.Type == "Расход").Sum(t => t.Amount);
            decimal balance = income - expenditure;

            labelIncome.Text = income.ToString("0.00");
            labelExpenditure.Text = expenditure.ToString("0.00");
            labelBalance.Text = balance.ToString("0.00");
        }
    }
}
