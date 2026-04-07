using Microsoft.SqlServer.Server;
using System;

namespace ConsoleStudy
{
    internal class Program
    {
        public class MagicPot // (1)
        {
            public void MakePotion(string firstItem, string secondItem)
            {
                string collapsedMaterial = $"마법의 포션만들";

                Console.WriteLine($"{firstItem}{secondItem}");
            }
        }

        public class Witch // (1)
        {
            public void CraftPotion(MagicPot targetMagicPot) // ## 몰랏었음 target 잘 못 씀
            {
                targetMagicPot.MakePotion("사탕", "과자");


            }
        }

        static void Main(string[] args)
        {
            MagicPot magicPot = new MagicPot(); // (1)
            // var magicpot333 = new MagicPot(); // 위아래 같던가? (구분하기편해서)
            Witch witch = new Witch();
            // var witch = new Witch();


            magicPot.MakePotion("도마뱁 꼬리", "머리카락"); // (1)
            witch.CraftPotion(magicPot);

        }
    }
}
