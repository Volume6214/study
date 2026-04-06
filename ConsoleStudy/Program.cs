using System;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace ConsoleStudy
{

    internal class Program
    {

        public class Vacation
        {
            public int m_surviveday = 0;

            public void AliveDay()
            {
                // m_surviveday++; 아래와 같음
                m_surviveday = (m_surviveday + 1);
                
                if(m_surviveday > 130)
                {
                    Console.Write("탈진!!!");
                    return;
                }
            }
        }

        static void Main(string[] args)
        {
            Vacation vacation = new Vacation();
            vacation.AliveDay();
        }
    }
}