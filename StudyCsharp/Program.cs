using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace StudyCsharp
{

    interface IFlyAble // I넣는게 익숙치않음
    {
        void Fly(); // fly 도 on off가 필요한가? 잘 모르겠음
    }

    interface ISwimAble
    {
        void Swim();
    }

    interface IEatAble
    {
        void Eat();
    }

    internal class Program
    {

        class Human : IEatAble, ISwimAble
        {

            public void Move()
            {
                Console.WriteLine("인간이 이동 중");
            }

            public void Attack()
            {
                Console.WriteLine("인간이 공격 중");
            }

            public void Eat()
            {
                Console.WriteLine("인간이 먹는 중");
            }

            public void Swim()
            {
                Console.WriteLine("인간이 수영 중");
            }
        }
        class Dolphin : IEatAble, ISwimAble
        {
            public void Move()
            {
                Console.WriteLine("돌고래가 이동 중");
            }

            public void Attack()
            {
                Console.WriteLine("돌고래가 공격 중");

            }

            public void Eat()
            {
                Console.WriteLine("돌고래가 먹는 중");

            }

            public void Swim()
            {
                Console.WriteLine("돌고래가 수영 중");

            }
        }
        class Roc : IEatAble, IFlyAble
        {
            public void Move()
            {
                Console.WriteLine("로크가 이동 중");
            }

            public void Attack()
            {
                Console.WriteLine("로크가 공격 중");

            }

            public void Eat()
            {
                Console.WriteLine("로크가 먹는 중");

            }

            public void Fly()
            {
                Console.WriteLine("로크가 나는 중");

            }
        }
        static void Main(string[] args)
        {
            Human human01 = new Human();
            human01.Move();
            human01.Attack();
            human01.Eat();
            human01.Swim();

            Dolphin dolphin01 = new Dolphin();
            dolphin01.Move();
            dolphin01.Attack();
            dolphin01.Eat();
            dolphin01.Swim();

            Roc roc01 = new Roc();
            roc01.Move();
            roc01.Attack();
            roc01.Eat();
            roc01.Fly();

            //강사님 그룹과외 추가예제 List에 실체화된 애들을 보관해 볼 것

            Console.WriteLine("==================\n추가예제\n==================");

            List<IEatAble> eatAblse = new List<IEatAble>();
            eatAblse.Add(roc01);
            eatAblse.Add(human01);
            eatAblse.Add(dolphin01);

            foreach (IEatAble eatalbe in eatAblse)
            {
                eatalbe.Eat();
            }

        }
    }
}