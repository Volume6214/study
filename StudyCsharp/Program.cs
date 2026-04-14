using System;
using System.Numerics;
using System.Threading;

namespace StudyCsharp
{
    class Status
    {
        public int Atk;
        public int Hp;

        public Status(int atk, int hp)
        {
            Atk = atk;
            Hp = hp;
        }


    }
    internal class Program
    {
        class Player
        {

            int hp = 100;
            int atk = 10;

            public void Attack(Monster monster)
            {
                Console.WriteLine("플레이어의 공격!");
                monster.TakeDamage(atk);
            }

            public void TakeDamage(int damage)
            {
                hp -= damage;
                Console.WriteLine($"플레이어 HP: {hp}");
            }
        }

        class Monster
        {

            int hp = 50;
            int atk = 15;

            public void Attack(Player player)
            {
                Console.WriteLine("몬스터의 공격!");
                player.TakeDamage(atk);
            }

            public void TakeDamage(int damage)
            {
                hp -= damage;
                Console.WriteLine($"몬스터 HP: {hp}");
            }
        }
        static void Main(string[] args)
        {
            Player player01 = new Player();
            Monster monster01 = new Monster();

            player01.Attack(monster01);
            monster01.Attack(player01);

        }
    }
}