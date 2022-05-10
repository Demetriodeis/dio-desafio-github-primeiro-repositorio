namespace GameChallenge.src.Entities
{
    public class Hero
    {
        /// <summary>
        /// Name character
        /// </summary>        
        public string Name { get; set; }
        
        /// <summary>
        /// Level character
        /// </summary>        
        public int Level { get; set; }

        /// <summary>
        /// Type hero
        /// </summary>        
        public string HeroType { get; set; }

        /// <summary>
        /// Method constructor character hero
        /// </summary>
        public Hero(string name, int level, string heroType)
        {
            this.Name = name;
            this.Level = level;
            this.HeroType = heroType;
        }

        public Hero()
        {
            
        }

        public override string ToString()
        {
            return $"Name: {Name} /n Level: {Level} /n Type Hero: {HeroType}";
        }

        public virtual string Attack()
        {
            return $"{Name} sword attack";
        }
    }
}