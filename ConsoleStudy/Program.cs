using System;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace ConsoleStudy
{
    public enum CreatureState
    {
        None,
        Name,
        Grade,
        Level
    }
    class FantasticCreature
    {
        public string m_name;
        public string m_grade;
        public string m_level;

        public void InitCreatureStateInfo(string name, string grade, string level)
        {
            string Name = m_name;
            string Grade = m_grade;
            string Level = m_level;

        }

        public void CallCreature()
        {
            Console.WriteLine($"{m_name},{m_grade},{m_level}");
        }
    }

    internal class Program
    {

        static void Main(string[] args)
        {

            var Creature100 = new FantasticCreature(); // var aaa nnn 숫자빼먹지말기
            Creature100.m_name = "slime";
            Creature100.m_grade = "normal";
            Creature100.m_level = "3";
            Creature100.CallCreature(); // (var) aaa 를 사용하려고 하기 계속 class 함수로 호출하려고함

            var Creature200 = new FantasticCreature();
            Creature200.m_name = "griffin";
            Creature200.m_grade = "legend";
            Creature200.m_level = "100";
            Creature200.CallCreature();

            var Creature300 = new FantasticCreature();
            Creature300.m_name = "girin";
            Creature300.m_grade = "myth";
            Creature300.m_level = "#@$#@#@#!";
            Creature300.CallCreature();

            FantasticCreature[] creatures = { Creature100, Creature200, Creature300};

            bool search = true;
            
            while(search)
            {
                Console.WriteLine("보고 싶은 크리처를 고르세요:");
                Console.WriteLine("slime, griffin, girin");

                string input = Console.ReadLine();
                ///여기부터의 문제 같은데 어디가 문제인지
                bool find = false;

                for (int i = 0; i < 3; i++)
                {
                    if (creatures[i].m_name == input)
                    {
                        creatures[i].CallCreature();
                        find = true;
                        break; // 1에서 차으면 23에서 행동을 안한다 (대신 중복된 목록이 없어야한다) (여러개일때는 x)
                    }
                }
                // 기능을 구분함 원래는 for문 안에 있었음
                if (!find)
                {
                    Console.WriteLine("없는 크리처입니다.");
                }

                Console.WriteLine("계속하시겠습니까? (y/n)");

                string answer = Console.ReadLine();

                if (answer == "n")
                {
                    break;
                }
            }
        }
    }
}