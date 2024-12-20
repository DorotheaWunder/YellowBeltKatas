﻿using Kata10Exam;

namespace Kata10Exam
{
    public class CombatSetup
    {
        public interface IAttacker
        {
            int Damage { get; set; }
            void Attack(ITarget target);
        }

        public interface ITarget
        {
            string Name { get; set; }
            int Health { get; set; }
            void TakeDamage(int damage);
        }

        //-------------------------------healer??----------------also for player

        public abstract class Combatant : ITarget, IAttacker
        {
            public string Name { get; set; }
            public int Health { get; set; }
            public int Damage { get; set; }

            public Combatant(string name, int damage, int health)
            {
                Name = name;
                Damage = damage;
                Health = health;
            }

            public void Attack(ITarget target)
            {
                Console.WriteLine($"{Name} attacks {target.Name} for {Damage} damage.");
                target.TakeDamage(Damage);
            }

            public void TakeDamage(int damage)
            {
                Health -= damage;
                Console.WriteLine($"{Name} took {damage} damage.");
                Console.WriteLine($"{Name} has {Health} health remaining.");
            }
        }

        public class Player : Combatant
        {
            public Player(string name, int damage, int health, int healPower) : base(name, damage, health)
            {
                
            }

            public void Heal(int healAmount)
            {
                Health += healAmount;
                Console.WriteLine($"{Name} heals for {healAmount} and now has {Health} HP");
            }
        }

        public class Enemy : Combatant
        {
            public Enemy(string name, int damage, int health) : base(name, damage, health)
            {

            }
        }
    }
}