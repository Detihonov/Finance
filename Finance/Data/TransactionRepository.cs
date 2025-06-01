using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Finance.Models;
using System.Text.Json;

namespace Finance.Data
{
    public class TransactionRepository
    {
        private readonly string _filePath = "Save\\transaction.json";   
        public List<Transaction> LoadAll()
        {
            if (!File.Exists(_filePath))
            {
                return new List<Transaction>();
            }

            string json = File.ReadAllText(_filePath);
            return JsonSerializer.Deserialize<List<Transaction>>(json);
        }

        public void Add(Transaction transaction)
        {
            var transactions = LoadAll();
            transactions.Add(transaction);
            SaveAll(transactions);
        }

        public void SaveAll(List<Transaction> transactions)
        {
            string json = JsonSerializer.Serialize(transactions);
        }

        public void Clear()
        {
            File.WriteAllText(_filePath, "[]");
        }
    }
}
