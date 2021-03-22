namespace dotnet_rpg.Models
{
    public class Weapon
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Damage { get; set; }
        public Character Character { get; set; }
        //with the help of the following naming convention (CharacterId), 
        //Enity Framework knows that this is the corresponding foreign key for the character property
        public int CharacterId { get; set; }
    }
}