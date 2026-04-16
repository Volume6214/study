using System;

namespace StudyCsharp
{
    internal class Program
    {
        static bool IsGameOver = false;

        class Guest // 유저
        {
            public string Name { get; set; }
            public int Hp {  get; set; }
            public int Atk {  get; set; }

            public Guest(string name, int hp, int atk)
            {
                Name = name;
                Hp = hp;
                Atk = atk;
            }

            public void AttackMonster(Resident targetResident)
            {
                targetResident.TakeDamage(this);
            }

            public void TakeDamage(Resident targetResident)
            {
                this.Hp -= targetResident.Atk;

                Console.WriteLine($"{targetResident.Name}의 공격으로 " +
                    $"{targetResident.Atk}만큼 피해를 받아 " +
                    $"{this.Name}의 HP가 {this.Hp}가 되었다.");
            }

            public bool IsGuestDead() // public bool IsResidentDead { get' set'} 둘다 가능
            {
                return this.Hp <= 0;
            }
            // 위 생성자와 공존할 수 없다.
        }

        class Resident // 몬스터
        {
            public string Name { get; set; }
            public int Hp { get; set; }
            public int Atk { get; set; }

            public Resident(string name, int hp, int atk)
            {
                Name = name;
                Hp = hp;
                Atk = atk;
            }

            public void AttackPlayer(Guest targetGuest)
            {
                targetGuest.TakeDamage(this);
            }

            public void TakeDamage(Guest targetGuest)
            {
                this.Hp -= targetGuest.Atk;

                Console.WriteLine($"{targetGuest.Name}의 공격으로 " +
                    $"{targetGuest.Atk}만큼 피해를 받아 " +
                    $"{this.Name}의 HP가 {this.Hp}가 되었다.");
            }

        }

        static void Main(string[] args)
        {


            Console.WriteLine("미지의 공간에 들어온 거 같다. 더 들어가시겠습니까? 1, 돌아간다. 2");
            string startKey = Console.ReadLine();

            if (startKey != "1")
            {
                Console.WriteLine("...돌아간다를 선택했다.. 아무일도 일어나지 않았다...");
                Console.ReadLine();
                return;
            }

            Guest guest01 = new Guest("방문자", 100, 15);
            Console.WriteLine($"({guest01.Name}이(가) 입장했다)");

            Resident mob101 = new Resident("흐물거리는 형체", 50, 10);



            while (!IsGameOver) // IsGameOver == false
            {
                Console.WriteLine("...문이 보인다. 문을연다 1, 뒤로 돌아간다 2");
                string repeatKey = Console.ReadLine();


                if (repeatKey == "1")
                {
                    guest01.AttackMonster(mob101);
                    mob101.AttackPlayer(guest01);

                    IsGameOver = guest01.IsGuestDead();
                }
                else if (repeatKey == "2")
                {
                    IsGameOver = true;
                }
                else
                {
                    Console.WriteLine("잘못된 입력입니다..");
                    return;
                }
            }
        }
    }
}