using System;
using System.Drawing;
using System.IO;
using System.Text.Json;

namespace ZPO
{
    public class AppConfig
    {
        private static AppConfig _instance;
        private static readonly string configPath = "E:\\ZPO Projekt\\ZPO\\config.json";

        public string ThemeColorHex { get; set; } = "#FFFFFF"; 

        public AppConfig() { }

        public static AppConfig Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = Load();
                }
                return _instance;
            }
        }

        public Color GetColor()
        {
            return ColorTranslator.FromHtml(ThemeColorHex);
        }

        // Ustaw nowy kolor i zapisz do pliku
        public void SetColor(Color color)
        {
            ThemeColorHex = ColorTranslator.ToHtml(color);
            Save();
        }

        // Wczytaj konfigurację z pliku
        private static AppConfig Load()
        {
            if (File.Exists(configPath))
            {
                string json = File.ReadAllText(configPath);
                return JsonSerializer.Deserialize<AppConfig>(json);
            }
            return new AppConfig(); // Zwraca domyślną konfigurację
        }

        // Zapisz konfigurację do pliku
        private void Save()
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(this, options);
            File.WriteAllText(configPath, json);
        }
    }
}
