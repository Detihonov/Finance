using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Finance.Other
{
    class SQLtoJSON
    {

        public static void FileConvert()
        {
            // jsonData - файл в формате JSON, содержащая данные для десериализации.
            // JsonConverter — класс - конвертер для работы с JSON (обычно из библиотек Newtonsoft.Json или System.Text.Json).
            // DeserializeObject<T>() — метод, преобразующий JSON-строку в объект указанного типа T.
            // <List<TrafficRecord>> — указывает, что ожидается список объектов класса TrafficRecord.
            // connect - эта строка определяет строку подключения (connection string) для доступа к базе данных
            var jsonPath = "data.json";
            var jsonData = File.ReadAllText(jsonPath);
            var records = JsonConvert.DeserializeObject<List<TrafficRecord>>(jsonData);

            // Server - Сервер базы данных. localhost означает, что СУБД работает на том же компьютере.
            // Database - Имя базы данных, к которой нужно подключиться.
            // Trusted_connection - Использовать встроенную аутентификацию Windows (текущий пользователь ОС).
            var connect = "Server=localhost;Database=TrafficDB;Trusted_connection=True;";
            // Доаолнительно:
            // - Encrypt = True — включение шифрования(обязательно для Azure SQL).
            // - Connection Timeout = 30 — время ожидания подключения(секунды).

            /*
            Как это работает?
            - Метод принимает строку jsonData.
            - Анализирует её структуру.
            - Создает экземпляры класса TrafficRecord на основе данных JSON.
            - Возвращает список List<TrafficRecord>.
            */

            // Создание подключения
            using (var connection = new SqlConnection(connect))
            {
                // Открываем подключение с помощью метода Open().
                connection.Open();

                foreach (var record in records)
                {
                    var command = new SqlCommand($"INSERT INTO TrafficData (date_time, volume) " +
                        $"VALUES (@date_time, @volume)");

                    // // Добавляем параметры (имена должны совпадать с SQL)
                    command.Parameters.AddWithValue("@id", record.Id);
                    command.Parameters.AddWithValue("@date_time", record.date_time);
                    command.Parameters.AddWithValue("@volume", record.Volume);

                    // Возвращает int - количество затронутых строк
                    command.ExecuteNonQuery();
                }
                // connection.Close() вызывается автоматически
            }
        }
    }

    class TrafficRecord
    {
        // Должен соответствовать структуре JSON-объектов
        public int Id { get; set; }
        public DateTime date_time { get; set; }
        public double Volume { get; set; }
    }
}
