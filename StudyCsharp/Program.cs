using System;
using System.Numerics;
using System.Threading;

namespace StudyCsharp
{

    internal class Program
    {

        public class RPGPlayer
        {

            public string Name { get; private set; }
            public int Atk { get; private set; }
            public int Hp { get; private set; }

            /*public RPGPlayer(string name, int Atk, int Hp)
            { 
            }*/

            public void InitRPGPlayer(string name, int atk, int hp)
            {
                Name = name;
                Atk = atk;
                Hp = hp;
            }
            public void AttackMonster(RPGMonster targetMonster)
            {
                //public Setter 니깐 우선 깎아 본다?
                targetMonster.Hp -= this.Atk;
                Console.WriteLine($"{this.Name}이 {targetMonster.GetName()}을 " +
                    $"{this.Atk}만큼 공격해서 {targetMonster.Hp}만큼 남았다");

            }

            public void TakeDamage(int targetMonsterAtk)
            {
                this.Hp -= targetMonsterAtk;
                Console.WriteLine($"{this.Name}이 {targetMonsterAtk}의 공격을 받아" +
                    $"{this.Hp}가 남았다");
            }
        }

        public class RPGMonster
        {

            public string m_name;
            private int m_atk;
            public int Hp { get; set; }

            public int Atk
            {
                get { return m_atk; }
                set
                {
                    if (m_atk != value)
                    {
                        m_atk = value;
                    }
                }
            }

            public string GetName()
            {
                return m_name;
            }

            public void SetName(string name)
            {
                m_name = name;
            }

            public void InitRPGMonster(string name, int atk, int hp)
            {
                SetName(name); // m_name = name; 도 가능
                Atk = atk;
                Hp = hp;
            }

            public void AttackPlayer(RPGPlayer targetPlayer)
            {
                //왜 이게 접근이 안 될까 왜 이게 캡슐화인걸까
                // 좋은걸까
                //targetPlayer.Hp -= this.Atk;

                targetPlayer.TakeDamage(this.Atk);
            }
        }
        static void Main(string[] args)
        {
            var player = new RPGPlayer();
            player.InitRPGPlayer("홍길동", 100, 200);

            var monster333 = new RPGMonster();
            monster333.InitRPGMonster("슬라임", 1000, 10);

            var monster443 = new RPGMonster();
            monster333.InitRPGMonster("드래곤", 200, 100);

            var monster223 = new RPGMonster();
            monster333.InitRPGMonster("프로그", 10, 30);

            //임프의 선공
            monster223.AttackPlayer(player);


            // 플레이어의 임프 공격
            player.AttackMonster(monster223);
        }
    }
}