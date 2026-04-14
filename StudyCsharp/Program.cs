using System;
using System.Numerics;
using System.Threading;

namespace StudyCsharp
{

    internal class Program
    {

        public class RPGPlayer
        {

            public string Name { get; set; }
        }

        public class RPGMonster
        {

            public string m_name;
            private int m_atk;
            public int Hp { get; set; }

            public int Atk
            {
                get { return m_atk; }
                set
                {
                    if (m_atk != value) 
                    { 
                        m_atk = value; 
                    }
                }
            }

            public string GetName()
            {
                return m_name;
            }

            public void SetNAme(string name)
            {
                m_name = name;
            }
        }
        static void Main(string[] args)
        {

        }
    }
}