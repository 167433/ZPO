using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ZPO
{
    internal class PlayerCharacter: Character
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
            File.WriteAllText(filePath, json);
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
            public void SetAbility(string key, int bonus)
        {
            switch (key.ToLower())
            {
                case "strength":
                    this.Strength += bonus;
                    break;
                case "dexterity":
                    this.Dexterity += bonus;
                    break;
                case "constitution":
                    this.Constitution += bonus;
                    break;
                case "intelligence":
                    this.Intelligence += bonus;
                    break;
                case "wisdom":
                    this.Wisdom += bonus;
                    break;
                case "charisma":
                    this.Charisma += bonus;
                    break;
                default:
                    throw new ArgumentException($"Unknown ability name: {key}");
            }
        }
    }
}
