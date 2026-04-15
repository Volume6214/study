using System;

namespace StudyCsharp
{
    class Player
    {
        public string Name;

        public Action<string, bool> OnReact;
        // 그냥 bool없이하니깐 TakeAction끼리 반응해서 TakeAction이 무한 반복된다.


        public void DoAction(string actionName)
        {
            Console.WriteLine($"{Name}이(가) {actionName}을 했다.");

            OnReact?.Invoke(actionName, true);
        }

        public void TakeAction(string actionName, bool isFromDoAction)
        {
            Console.WriteLine($"{Name}이(가) {actionName}을 받았다.");

            if (isFromDoAction == false) 
            {
                return;
            } // 여기서 진짜 애먹음 TakeAction이면 false라는 생각으로 do가 아닌 take로 했었음

            Console.WriteLine($"{Name}이(가) {actionName}로 맞대응!");

            OnReact?.Invoke(actionName, false);
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

            // 양방향 연결
            player01.OnReact += player02.TakeAction;
            player02.OnReact += player01.TakeAction;

            player01.DoAction("하이파이브");

            Console.WriteLine("------");

            player02.DoAction("손인사");
        }
    }
}