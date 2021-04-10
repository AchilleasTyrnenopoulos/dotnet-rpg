using System.Collections.Generic;

namespace dotnet_rpg.Models
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; } = "Name";

        public int HitPoints { get; set; } = 100;
        public int Strength { get; set; } = 10;
        public int Agility { get; set; } = 10;
        public int Defence { get; set; } = 10;
        public int Intelligence { get; set; } = 10;

        public RpgClass Class {get; set;} = RpgClass.Warrior;

        public User User { get; set; }
        public Weapon Weapon { get; set; }

        public List<CharacterSkill> CharacterSkills {get; set;}
    }
}