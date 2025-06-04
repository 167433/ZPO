using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ZPO
{
    internal class PlayerCharacter: Character, IInteract
    {
        public string characterName {  get; set; }
        public int  characterLeverl {  get; set; }
        public List<GameClass> characterClasses { get; set;}

        public BackStory BackStory { get; set; }

       public PlayerCharacter(string characterName, int characterLeverl, List<GameClass> characterClasses, string backStoryName,string backStoryDescription)

        {
            this.BackStory = new BackStory(backStoryName, backStoryDescription);
            if(characterName == "Geralt")
            {
                throw new ExceptionGeralt(characterName);
            }
            this.characterName = characterName;
            this.characterLeverl = characterLeverl;
            this.characterClasses = characterClasses;
        }
        
        public void addClass(GameClass gameClass)
        {
            this.characterClasses.Add(gameClass);
        }
        public int getAmountOfCasterClass()
        {
            return this.characterClasses.Where(c=> c.Description.Contains("mag")).ToList().Count();
        }
        public void SaveToJson(string filePath)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                IncludeFields = true
            };
            string json = JsonSerializer.Serialize(this, options);
            if (string.IsNullOrWhiteSpace(this.characterName))
            {
                throw new InvalidOperationException("Imię postaci nie może być puste.");
            }
            File.WriteAllText($"E:\\ZPO Projekt\\ZPO\\{filePath}", json);
            
        }

        public static PlayerCharacter LoadFromJson(string filePath)
        {
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                IncludeFields = true
            };
            string json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<PlayerCharacter>(json, options);
        }
            public void SetAbility(string key, int stat)
        {
            switch (key.ToLower())
            {
                case "strength":
                    this.Strength = stat;
                    break;
                case "dexterity":
                    this.Dexterity = stat;
                    break;
                case "constitution":
                    this.Constitution = stat;
                    break;
                case "intelligence":
                    this.Intelligence = stat;
                    break;
                case "wisdom":
                    this.Wisdom = stat;
                    break;
                case "charisma":
                    this.Charisma = stat;
                    break;
                default:
                    throw new ArgumentException($"Unknown ability name: {key}");
            }
        }

        public int subStractHP()
        {
           return this.HitPoints =- 1;
        }

        public int addHP()
        {
            return this.HitPoints += 1;
        }

        public int attackRoll()
        {
            Random rnd = new Random();
            int attRoll = this.Strength + rnd.Next(1, 20);
           MessageBox.Show($"WYNIK ATAKTU TO: {attRoll} ");
            return attRoll;
        }
    }
}
