using System;
using System.Collections.Generic;

namespace StudyCsharp
{
    internal class Program
    {

        class Item
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }


            public Item(int id, string name, string description) // public \ 끝에;붙이지말고
            {
                Id = id;
                Name = name;
                Description = description;
            }

        }

        class ItemShop
        {
            Dictionary<string, Item> ItemDictionary = new Dictionary<string, Item>();


            public void TodayItem()
            {
                // 아래 코드가 필요가 없었음 왜 이걸 붙잡고 있었지
                /*Item item111 = new Item(101, "의자", "편안한 의자");

                ItemDictionary.Add(item111.Name, item111); // item111.Name 형식기억해야함 기억해내는데 오래걸림
                */
                for (int i = 0; i < 10; i++)
                {
                    Item item = new Item(i, "의자" + i, "편안한 의자" + i);

                    ItemDictionary.Add(item.Name, item);
                }
            }

            public void ShowShop()
            {

                foreach (var item in ItemDictionary.Values)
                {
                    Console.WriteLine($"{item.Id} - {item.Name} - {item.Description}");// item은 그대로 두고 Name을 수정해야함
                }
            }
        }

        static void Main(string[] args)
        {
            // 이 위로는 아무것도 한게 없음 Console에 시간 버렸음

            // 아 문제지문에 있었음 상점 클래스를 실체화하고....

            ItemShop itemShop = new ItemShop(); // 상점부르기

            itemShop.TodayItem(); // 상점에 아이템넣기

            itemShop.ShowShop(); // 상점보여주기

        }
    }
}