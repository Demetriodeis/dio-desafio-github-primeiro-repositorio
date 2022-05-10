namespace GameChallenge.src.Entities
{
    public class Knight : Hero
    {
        /// <summary>
        /// Constructor Kinight
        /// </summary>
        public Knight(string name, int level, string heroType)
        {
            this.Name = name;
            this.Level = level;
            this.HeroType = heroType;
        }
    }
}