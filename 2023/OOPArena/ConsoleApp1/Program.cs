using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPArena
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }

        public class Peasant
        {
            protected int Health { get; set; }
            int Stamina { get; set; }
            int Attack { get; set; }
            int Defense { get; set; }
            int Sing { get; set; }

            public virtual void AttackHim(Peasant rival) 
            {
                rival.Health -= Attack;
            }

            public void DefendeHim(Peasant rival)
            {

            }

            public void SingHim(Peasant rival)
            {

            }
        }

        public class Knight : Peasant
        {
            public override void AttackHim(Peasant rival) 
            {
                base.AttackHim(rival);
            }
        }
    }
}
