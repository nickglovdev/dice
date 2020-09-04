using System;
namespace ShootingDice
{
    // TODO: Complete this class

    // A Player who shouts a taunt every time they roll dice
    public class SmackTalkingPlayer : Player
    {
        public string Taunt { get; } = "Come back in 10 years";

        public override int Roll()
        {
            Console.WriteLine($"{Name} Says {Taunt}");
            return new Random().Next(DiceSize) + 1;
        }
    }
}