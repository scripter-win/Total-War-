using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_game
{
    public class exs
    {
        public List<solider> li;
        private List<int> a;


    }

     public class solider
    {
        int attack;
        int defence;
        int armor;
        int health;
        int demage;
        bool IsAlive { get; set; }
        Random ran;                 
        public solider()
        {
            ran = new Random();
        }
        public void attackto(solider beacttacked)
        {
            beacttacked.beattack(attack, demage);
        }
        public void beattack(int attack, int demage)
        {
          double refer=(figure(attack, this.defence)*100);
            if ((ran.Next() % 100) < refer)
                health-=demage;
        }
        private double figure(int attack, int defense)
        {

           
            return 0;
        }
        private int DemageJudge(int attack, int aromor)
        {
            if (demage < 0 || attack < 0)
                return 0;
            if (demage > aromor)
                return (demage - aromor / 2);
            else return (demage*demage/aromor);
        }

    }
    
}
