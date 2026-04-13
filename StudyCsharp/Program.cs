using System;

namespace StudyCsharp
{
    interface IRideAble
    {
        void RideOn(); // 타고내리는 걸 생각해서 메서드 2개
        void RideOff();
    }

    interface ICraftAble
    {
        // bool isCraft(); 필요할 수도 있다.
        void StartCraft();
    }

    interface IReceiveInputAble
    {
        void ReceiveInput();
    }
    internal class Program
    {
        class Player : IRideAble, ICraftAble, IReceiveInputAble // 인터페이스 구현불가오류 = 메서드를 만들라는 의미
        {
            public void Move()
            {
                Console.WriteLine("플레이어 이동");
            }

            public void Attack()
            {
                Console.WriteLine("플레이어 공격");
            }

            public void RideOn()
            {
                Console.WriteLine("플레이어 탑승");

            }

            public void RideOff()
            {
                Console.WriteLine("플레이어 탑승해제");

            }

            public void StartCraft()
            {
                Console.WriteLine("플레이어 제작시작");

            }

            public void ReceiveInput()
            {
                Console.WriteLine("플레이어 입력받는 중");

            }
        }

        class Monster : IRideAble
        {
            public void Move()
            {
                Console.WriteLine("몬스터 이동");

            }

            public void Attack()
            {
                Console.WriteLine("몬스터 공격");

            }

            public void RideOn()
            {
                Console.WriteLine("몬스터 탑승");

            }

            public void RideOff()
            {
                Console.WriteLine("몬스터 탑승해제");
            }
        }
        static void Main(string[] args)
        {
            Player player01 = new Player();

            Monster monster01 = new Monster();
            Monster monster02 = new Monster();
            Monster monster03 = new Monster();

            player01.Move();
            player01.Attack();
            player01.RideOn();
            player01.RideOff();
            player01.StartCraft();
            player01.ReceiveInput();

            monster01.Move();
            monster02.Attack();
            monster03.RideOn();
            monster03.RideOff();

        }
    }
}