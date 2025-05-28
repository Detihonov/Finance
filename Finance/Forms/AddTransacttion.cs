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
        public AddTransacttion()
        {
            InitializeComponent(); // Инициализатор формы
            ComboTypeCategory();
        }

        private void ComboTypeCategory()
        {
            // Метод AddRange() добавляет массив элементов в коллекцию ComboBox за одну операцию.
            // Это удобнее и эффективнее, чем добавлять элементы по одному через Add().
            coboxType.Items.AddRange(new[] { "Доход", "Расход" });
            // SelectedIndex — свойство, которое задает или возвращает индекс выбранного элемента в списке.
            coboxType.SelectedIndex = 0;

            coboxCategory.Items.AddRange(new[] { "Зарплата", "Транспорт", "Развлечения" });
            coboxCategory.SelectedIndex = 0;
        }
    }
}
