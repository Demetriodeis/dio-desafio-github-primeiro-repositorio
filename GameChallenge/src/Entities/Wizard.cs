namespace GameChallenge.src.Entities
{
    public class Wizard : Hero
    {
        /// <summary>
        /// Constructor wizard
        /// </summary>
        public Wizard(string name, int level, string heroType)
        {
            this.Name = name;
            this.Level = level;
            this.HeroType = heroType;
        }

        /// <summary>
        /// Attack with magic normal
        /// </summary>
        /// <returns>Cast magic</returns>
        public override string Attack()
        {
            return $"{Name} cast magic";
        }

        /// <summary>
        /// Attack with magic with bonus
        /// </summary>        
        /// <returns>Cast a strong or weak spell</returns>
        public string Attack(int bonus)
        {
            if(bonus > 6)
                return $"{Name} cast magic + strong bonus";
            else
                return $"{Name} cast magic + weak bonus";
        }
    }
}