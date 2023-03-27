using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27._3
{
    public class Hrac
    {
        private string name;
        private int hp;
        public bool isAlive;

        public string Name { get { return name; } set { name = value; } }
        public int HP { get { return hp; } set { hp = value; } }

        public Hrac(string name, int hp)
        {
            this.name = name;
            this.hp = hp;
        }

        public void Zvysit(int n)
        {
            lock()
            {
                if (isAlive == true)
                {
                    hp += n;
                }
            }
        }

        public void Snizit(int n)
        {
            lock()
            {
                if (isAlive == true)
                {
                    hp -= n;
                }
            }
        }
    }
}
