using System;

namespace StudyCsharp
{
    class Player
    {
        public string Name;

        // 1. 행동했을 때 알리는 이벤트
        public Action<string> OnActionCompleted;
        // 2. 반응했을 때 알리는 이벤트
        public Action<string> OnReactionCompleted;

        public void DoAction(string actionName)
        {
            Console.WriteLine($"{Name}이(가) {actionName}을 했다.");

            OnActionCompleted?.Invoke(actionName);
        }

        // 상대방의 '행동'을 받았을 때 실행됨
        public void TakeAction(string actionName)
        {
            Console.WriteLine($"{Name}이(가) {actionName}의 맞반응!");

            // 맞대응 했음을 알림
            OnReactionCompleted?.Invoke(actionName);
        }

        // 상대방의 '반응'을 받았을 때 실행됨
        public void TakeReaction(string actionName)
        {
            // 리액션에 대한 처리 하지 않고 여기서 흐름을 끝냅니다.
            Console.WriteLine($"{Name}이(가) 상대방의 반응을 보았다 끝!");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Player player01 = new Player();
            player01.Name = "플레이어1";

            Player player02 = new Player();
            player02.Name = "플레이어2";

            player01.OnActionCompleted += player02.TakeAction;
            player02.OnReactionCompleted += player01.TakeReaction;

            player02.OnActionCompleted += player01.TakeAction;
            player01.OnReactionCompleted += player02.TakeReaction;

            player01.DoAction("하이파이브");
        }
    }
}