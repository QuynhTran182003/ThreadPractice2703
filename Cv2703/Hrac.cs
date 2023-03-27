using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cv2703
{
    public class Hrac
    {
        private string name;
        private int health;
        private bool isLiving;
        private static readonly Object locker = new Object();

        public string Name {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Health
        {
            get { return this.health; }
            set { this.health = value; }
        }
        public bool IsLiving
        {
            get { return Health > 0 ? true : false; }
            private set { this.isLiving = value; }
        }

        public Hrac(string name, int health)
        {
            Name = name;
            Health = health;
        }

        public void DecreaseHealth(int hodnota)
        {
            lock (locker)
            {
                if (IsLiving)
                {
                    Health -= hodnota;

                    Console.WriteLine($"Decreasing {hodnota} ... Remains: {Health}");
                }
            }
            
        }

        public void IncreaseHealth(int hodnota)
        {
            lock (locker)
            {
                if (IsLiving)
                {
                    Health += hodnota;
                    Console.WriteLine($"increasing {hodnota} ...Remains: {Health}");
                }
            }
        }
    }


}
