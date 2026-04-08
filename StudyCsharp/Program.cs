using System;
using System.Collections.Generic;
using System.Net.Sockets;

namespace StudyCsharp
{
    public class Creature
    {
        public string Name;
        public int Atk;

        public Creature(string name, int atk)
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

            Dictionary<string, Creature> unknownCreatures = new Dictionary<string, Creature>();
            Dictionary<string, Creature> findCreatures = new Dictionary<string, Creature>();

            unknownCreatures.Add("dragon", new Creature("드래곤", 100)); // 일단은 지정해서쓰는 List라고 생각하고 사용
            unknownCreatures.Add("griffin", new Creature("그리핀", 50));
            unknownCreatures.Add("golem", new Creature("골렘", 40));

            Console.WriteLine("미발견 생물");


            while (unknownCreatures.Count > 0)
            {

                foreach (var Pocket in unknownCreatures)
                {
                    Console.WriteLine(Pocket.Key);
                }

                Console.Write("\n찾는 생물 입력:");
                string Key = Console.ReadLine();

                if (unknownCreatures.ContainsKey(Key))
                {
                    Creature find = unknownCreatures[Key];

                    Console.WriteLine("발견했다!");
                    find.Attack();

                    findCreatures.Add(Key, find); // findCreatures로 했었는데 오류남
                    unknownCreatures.Remove(Key);

                    Console.WriteLine($"\n조우한 생물: {findCreatures.Count}");
                }
                else
                {
                    Console.WriteLine("잘못된 입력");
                }

                Console.WriteLine("\n 남은 생물 목록:");


            }

            Console.WriteLine("\n=======================\n모든 생물을 다 찾았다!\n=======================");

            Console.WriteLine("\n발견한 생물 목록:");
            foreach (var item in findCreatures)
            {
                Console.WriteLine(item.Key);
            }
        }
    }
}
