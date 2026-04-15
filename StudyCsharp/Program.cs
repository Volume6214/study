using System;

namespace StudyCsharp
{
    public class RPGPlayer
    {
        public string Name { get; private set; }
        public int Atk { get; private set; }
        public int Hp { get; private set; }

        public Action<int> OnAttack; // (1) 이벤트 선언

        public void InitRPGPlayer(string name, int atk, int hp)
        {
            Name = name;
            Atk = atk;
            Hp = hp;
        }

        public void AttackMonster() // (1) 파라미터 제거
        {
            Console.WriteLine($"{this.Name}이 공격을 시도했다"); // (1)

            OnAttack?.Invoke(this.Atk);

            /*targetMonster.Hp -= this.Atk;
            Console.WriteLine($"{this.Name}이 {targetMonster.Name}을" + // (1) 의존성 제거?
                $" {this.Atk}만큼 공격해서 {targetMonster.Hp}만큼 남았다");*/
        }

        public void TakeDamage(int monsterAtk) // (1)
        {
            this.Hp -= monsterAtk;
            Console.WriteLine($"{this.Name}이 {monsterAtk}만큼 피해를 입어 {this.Hp}가 남았다");
        }
    }

    public class RPGMonster
    {
        public string Name { get; set; }
        public int Atk { get; set; }
        public int Hp { get; set; }

        public Action<int> OnAttack; //(2) 이벤트 발생? 정의 꼭 해야함 다 해놓고 여기서 해맴

        public void InitRPGMonster(string name, int atk, int hp)
        {
            Name = name;
            Atk = atk;
            Hp = hp;
        }

        public void TakeDamage(int playerAtk) // (1)
        {
            this.Hp -= playerAtk;
            Console.WriteLine($"{this.Name}이 {playerAtk}만큼 피해를 입어 {this.Hp}가 남았다");
        }

        public void AttackPlayer() // (2)
        {
            Console.WriteLine($"{this.Name}이 공격을 시도했다"); // (1)

            OnAttack?.Invoke(this.Atk);

            /*Console.WriteLine($"{this.Name}이 {targetPlayer.Name}을" +
              $" {this.Atk}만큼 공격했다");
            targetPlayer.TakeDamage(this.Atk);*/
        }

        static void Main(string[] args)
        {
            var player = new RPGPlayer();
            player.InitRPGPlayer("홍길동", 100, 200);

            var monster333 = new RPGMonster();
            monster333.InitRPGMonster("슬라임", 1000, 10);

            var monster447 = new RPGMonster();
            monster447.InitRPGMonster("용", 200, 100);

            var monster227 = new RPGMonster();
            monster227.InitRPGMonster("임프", 10, 30);

            monster227.OnAttack += player.TakeDamage; //(2) 몬스터도 이벤트로 공격

            // 임프의 선공
            monster227.AttackPlayer();

            player.OnAttack += monster227.TakeDamage; //(1) 플레이어의 공격에 몬스터가 받도록 한다?
            // 위 코드는 공격한 것이 아닌 상황부여

            // 임프 한번 공격해볼게요
            player.AttackMonster(); //플레이어가 공격한다. 따라서 위 조건을 실행하여 데미지를 받는다.


        }
    }
}