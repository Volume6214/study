using System;

namespace StudyCsharp
{
    public class RPGPlayer
    {
        public string Name { get; private set; }
        public int Atk { get; private set; }
        public int Hp { get; private set; }

        public void InitRPGPlayer(string name, int atk, int hp)
        {
            Name = name;
            Atk = atk;
            Hp = hp;
        }

        public void AttackMonster(RPGMonster targetMonster)
        {
            targetMonster.Hp -= this.Atk;
            Console.WriteLine($"{this.Name}이 {targetMonster.Name}을" +
                $" {this.Atk}만큼 공격해서 {targetMonster.Hp}만큼 남았다");
        }

        public void TakeDamage(int taregetMonsterAtk)
        {
            this.Hp -= taregetMonsterAtk;
            Console.WriteLine($"{this.Name}이 {taregetMonsterAtk}의 공격을 받아 {this.Hp}가 남았다");
        }
    }

    public class RPGMonster
    {
        public string Name { get; set; }
        public int Atk { get; set; }
        public int Hp { get; set; }

        public void InitRPGMonster(string name, int atk, int hp)
        {
            Name = name;
            Atk = atk;
            Hp = hp;
        }

        public void AttackPlayer(RPGPlayer targetPlayer)
        {
            Console.WriteLine($"{this.Name}이 {targetPlayer.Name}을" +
              $" {this.Atk}만큼 공격했다");
            targetPlayer.TakeDamage(this.Atk);
        }
        }

        public static void StartRPGGame()
        {
            var player = new RPGPlayer();
            player.InitRPGPlayer("홍길동", 100, 200);

            var monster333 = new RPGMonster();
            monster333.InitRPGMonster("슬라임", 1000, 10);

            var monster447 = new RPGMonster();
            monster447.InitRPGMonster("용", 200, 100);

            var monster227 = new RPGMonster();
            monster227.InitRPGMonster("임프", 10, 30);

            // 임프의 선공
            monster227.AttackPlayer(player);


            // 임프 한번 공격해볼게요
            player.AttackMonster(monster227);


        }
    }
}
