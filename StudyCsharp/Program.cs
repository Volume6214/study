using System;
using System.Collections.Generic;

namespace StudyCsharp
{
    public class Creature
    {
        public string Name;
        public int Atk;

        public Creature(string name, int atk)  // 위 클래스와 이름이 다르면 오류 왜지?
        {
            Name = name;
            Atk = atk;
        }

        public void Attack()
        {
            Console.WriteLine($"{Name}! 공격력 : {Atk}!!");
        }
    }
    internal class Program
    {


        static void Main(string[] args)
        {
            Dictionary<string, Creature> creatures = new Dictionary<string, Creature>();

            creatures.Add("dragon", new Creature("드래곤", 100));
            creatures.Add("griffin", new Creature("그리핀", 50));
            creatures.Add("golem", new Creature("골렘", 40));

            Console.WriteLine("미발견 생물");

            foreach (var item in creatures)
            {
                Console.WriteLine(item.Key);
            }

            Console.Write("찾는 생물 입력:");
            string Key = Console.ReadLine();

            if (creatures.ContainsKey(Key))
            {
                Creature find = creatures[Key];

                Console.WriteLine("발견했다!");
                find.Attack();

                creatures.Remove(Key);
                Console.WriteLine("미발견 목록에서 삭제");
            }
            else
            {
                Console.WriteLine("잘못된 입력");
            }

            Console.WriteLine("\n 남은 생물 목록:");

            foreach (var item in creatures)
            {
                Console.WriteLine(item.Key);
            }
        }
    }
}
