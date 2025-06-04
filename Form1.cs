using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Numerics;

namespace ZPO

{
    public partial class Form1 : Form
    {
        private PlayerCharacter playerCharacter;
        public Form1()
        {
            InitializeComponent();
            btnInteract.Visible = false;
            btnSaveToJSON.Visible = false;
            btnLinQ.Visible = false;

            this.BackColor = AppConfig.Instance.GetColor();


            string filePathRace = "E:\\ZPO Projekt\\ZPO\\races.json";

            try
            {
                if (!File.Exists(filePathRace))
                {
                    richTextBox1.Text = "Plik z rasami nie istnieje.";
                    return;
                }

                string json = File.ReadAllText(filePathRace);
                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };

                List<Race> races = JsonSerializer.Deserialize<List<Race>>(json, options);

                comboBoxRaces.DataSource = races;
                comboBoxRaces.DisplayMember = "Name";

                // Tu możesz użyć `races` np. do GUI w Windows Forms (ComboBox, ListBox itd.)
            }
            catch (Exception ex)
            {
                Console.WriteLine("Błąd odczytu ras: " + ex.Message);
            }

            string filePathClass = "E:\\ZPO Projekt\\ZPO\\GameClass.json";
            List<GameClass> LoadCharacterClasses(string filePath)
            {
                try
                {
                    string json = File.ReadAllText(filePath);
                    var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                    return JsonSerializer.Deserialize<List<GameClass>>(json, options);
                }
                catch (FileNotFoundException ex)
                {
                    MessageBox.Show($"Plik nie został znaleziony: {ex.Message}", "Błąd odczytu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (JsonException ex)
                {
                    MessageBox.Show($"Błąd formatu JSON: {ex.Message}", "Błąd przetwarzania JSON", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Nieoczekiwany błąd: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Zwróć pustą listę, żeby nie wywalić DataSource
                return new List<GameClass>();
            }

            cbClassName.DataSource = LoadCharacterClasses(filePathClass);
            cbClassName.DisplayMember = "Name";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                groupBox1.Enabled = false;
                boxStats.Enabled = true;
                btnInteract.Visible = true;
                btnSaveToJSON.Visible = true;
                btnLinQ.Visible = true;

                Race selectedRace = (Race)comboBoxRaces.SelectedItem;
                GameClass selectedClass = (GameClass)cbClassName.SelectedItem;
                List<GameClass> gameClasses = new List<GameClass>();
                gameClasses.Add(selectedClass);
                playerCharacter = new PlayerCharacter(textBox1.Text, 1, gameClasses, "Tragiczna historia", "Dawno temu wydarzyło się coś tragicznego");
                textTest.Text = playerCharacter.characterName.ToString();
                string jsonTest = JsonSerializer.Serialize(playerCharacter, new JsonSerializerOptions { WriteIndented = true });
                textTest.Text = jsonTest;
            }
            catch (ExceptionGeralt ex)
            {
                MessageBox.Show(ex.Message, "BŁĄD", MessageBoxButtons.OK);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            classSelectPanel.Visible = true;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

            Race selectedRace = (Race)comboBoxRaces.SelectedItem;
            txtBoxSTR.Text = selectedRace.StatBonuses.ContainsKey("Strength")
               ? rollStatsWithBonus(selectedRace.StatBonuses["Strength"])
               : rollStats();

        }


        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void graczToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private string rollStats()
        {
            Random rnd = new Random();
            List<int> list = new List<int>();
            int diceRoll = 0;

            for (int i = 0; i < 4; i++)
            {
                list.Add(rnd.Next(1, 7));
            }

            list.Remove(list.Min());
            foreach (int i in list) { diceRoll = diceRoll + i; }

            return diceRoll.ToString();
        }
        private string rollStatsWithBonus(int bonus)
        {
            int diceRoll = Int32.Parse(rollStats());
            diceRoll = diceRoll + bonus;
            return diceRoll.ToString();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Race selectedRace = (Race)comboBoxRaces.SelectedItem;
            txtBoxWIS.Text = selectedRace.StatBonuses.ContainsKey("Wisdom")
               ? rollStatsWithBonus(selectedRace.StatBonuses["Wisdom"])
               : rollStats();
            playerCharacter.SetAbility("Wisdom", Int32.Parse(txtBoxWIS.Text));

        }

        private void label3_Click(object sender, EventArgs e)
        {

            Race selectedRace = (Race)comboBoxRaces.SelectedItem;
            txtBoxDEX.Text = selectedRace.StatBonuses.ContainsKey("Dexterity")
               ? rollStatsWithBonus(selectedRace.StatBonuses["Dexterity"])
               : rollStats();
            playerCharacter.SetAbility("Dexterity", Int32.Parse(txtBoxDEX.Text));

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            Race selectedRace = (Race)comboBoxRaces.SelectedItem;
            txtBoxCON.Text = selectedRace.StatBonuses.ContainsKey("Constitution")
               ? rollStatsWithBonus(selectedRace.StatBonuses["Constitution"])
               : rollStats();
            playerCharacter.SetAbility("Constitution", Int32.Parse(txtBoxCON.Text));

        }

        private void label9_Click(object sender, EventArgs e)
        {
            Race selectedRace = (Race)comboBoxRaces.SelectedItem;
            txtBoxCHA.Text = selectedRace.StatBonuses.ContainsKey("Charisma")
               ? rollStatsWithBonus(selectedRace.StatBonuses["Charisma"])
               : rollStats();
            playerCharacter.SetAbility("Charisma", Int32.Parse(txtBoxCHA.Text));

        }

        private void label11_Click(object sender, EventArgs e)
        {
            Race selectedRace = (Race)comboBoxRaces.SelectedItem;
            txtBoxWIS.Text = selectedRace.StatBonuses.ContainsKey("Intelligence")
               ? rollStatsWithBonus(selectedRace.StatBonuses["Intelligence"])
               : rollStats();
            playerCharacter.SetAbility("Intelligence", Int32.Parse(txtBoxINT.Text));

        }

        private void btnRollAll_Click(object sender, EventArgs e)
        {
            Race selectedRace = (Race)comboBoxRaces.SelectedItem;

            txtBoxSTR.Text = selectedRace.StatBonuses.ContainsKey("Strength")
                ? rollStatsWithBonus(selectedRace.StatBonuses["Strength"])
                : rollStats();

            txtBoxDEX.Text = selectedRace.StatBonuses.ContainsKey("Dexterity")
                ? rollStatsWithBonus(selectedRace.StatBonuses["Dexterity"])
                : rollStats();

            txtBoxCON.Text = selectedRace.StatBonuses.ContainsKey("Constitution")
                ? rollStatsWithBonus(selectedRace.StatBonuses["Constitution"])
                : rollStats();

            txtBoxINT.Text = selectedRace.StatBonuses.ContainsKey("Intelligence")
                ? rollStatsWithBonus(selectedRace.StatBonuses["Intelligence"])
                : rollStats();

            txtBoxWIS.Text = selectedRace.StatBonuses.ContainsKey("Wisdom")
                ? rollStatsWithBonus(selectedRace.StatBonuses["Wisdom"])
                : rollStats();

            txtBoxCHA.Text = selectedRace.StatBonuses.ContainsKey("Charisma")
                ? rollStatsWithBonus(selectedRace.StatBonuses["Charisma"])
                : rollStats();

            playerCharacter.SetAbility("Strength", Int32.Parse(txtBoxSTR.Text));
            playerCharacter.SetAbility("Dexterity", Int32.Parse(txtBoxDEX.Text));
            playerCharacter.SetAbility("Constitution", Int32.Parse(txtBoxCON.Text));
            playerCharacter.SetAbility("Intelligence", Int32.Parse(txtBoxINT.Text));
            playerCharacter.SetAbility("Wisdom", Int32.Parse(txtBoxWIS.Text));
            playerCharacter.SetAbility("Charisma", Int32.Parse(txtBoxCHA.Text));
        }

        private void button1_Click_1(object sender, EventArgs e)
        {




        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxRaces_SelectedIndexChanged(object sender, EventArgs e)
        {
            Race selectedRace = (Race)comboBoxRaces.SelectedItem;

            richTextBox1.Text = selectedRace.Description;

            if (selectedRace.StatBonuses.ContainsKey("Strength"))
            {
                int strengthBonus = selectedRace.StatBonuses["Strength"];
                int temp = Int32.Parse(txtBoxSTR.Text);
                txtBoxSTR.Text = (temp + 2).ToString();
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            GameClass selectedClass = (GameClass)cbClassName.SelectedItem;

            textClassOpis.Text = selectedClass.Description;

        }

        private void lblRasa_Click(object sender, EventArgs e)
        {

        }

        private void textTest_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            try
            {
                playerCharacter.SaveToJson(playerCharacter.characterName);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("Twoja postać nie ma imienia! A musi mieć");

                groupBox1.Enabled = true;
                boxStats.Enabled = false;
                btnInteract.Visible = false;
                btnSaveToJSON.Visible = false;
                btnLinQ.Visible = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            playerCharacter.attackRoll();
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            MessageBox.Show($"{playerCharacter.getAmountOfCasterClass()} Tyle jest magi w obecnej postaci");
        }
    }
}
