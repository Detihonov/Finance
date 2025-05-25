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
        private readonly string _filePath = "transaction.json";
        public List<Transaction> LoadAll()
        {
            if (!File.Exists(_filePath))
            {
                return new List<Transaction>();
            }

            string json = File.ReadAllText(_filePath);
            return JsonSerializer.Deserialize<List<Transaction>>(json);
        }
    }
}
