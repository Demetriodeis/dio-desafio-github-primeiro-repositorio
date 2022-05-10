using GameChallenge.src.Entities;
using static System.Console;

namespace GameChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero Arus = new Hero("Arus", 12, "Paladin");
            Wizard wizard = new Wizard("Jennica", 23, "Wizard");
            Wizard mage = new Wizard("Ozbi", 2, "Mage");
            Knight knight = new Knight("Tibia", 2, "Knight");
            
            WriteLine(Arus.Attack());
            WriteLine(knight.Attack());
            WriteLine(mage.Attack());
            WriteLine(wizard.Attack(2 + wizard.Level));
            WriteLine(mage.Attack(2 + mage.Level));
        }
    }
}
