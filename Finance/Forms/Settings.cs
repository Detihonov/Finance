using Finance.Data;
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
    public partial class Settings : Form
    {
        private SettingsRepository settingsRepository;
        private UserSettings userSettings;
        public Settings()
        {
            InitializeComponent();
            coboxUser.Items.AddRange(new[] { "₽", "$", "€", "¥", "₤" });
        }

        private void LoadSettings()
        {
            userSettings = settingsRepository.Load();
            textName.Text = userSettings.UserName;
            coboxUser.SelectedItem = userSettings.CurrentSymbol;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            userSettings.UserName = textName.Text;
            userSettings.CurrentSymbol = coboxUser.SelectedItem.ToString();
            settingsRepository.Save(userSettings);
            MessageBox.Show("Настройки сохранены","Успех",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
