using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Hero
    {
        // PRIVATE PROPERTIES ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private int strength;
        private int speed;
        private int health;

        // PUBLIC PROPERTIES++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public string name;

        // CONSTRUCTOR+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public Hero(string name)
        {
            generateAbilites();
            this.name = name;
           
        }
        
       
        // PRIVATE METHODS++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private void generateAbilites()
        {
            Random rnd = new Random();
            this.strength = rnd.Next(1, 101);
            this.speed = rnd.Next(1, 101);
            this.health = rnd.Next(1, 101);
        }
        private bool hitAttempt()
        {
           //Hit attempt method is to generate a hit 20% of the time.
            Random rnd = new Random();
            int attemptHit = rnd.Next(1, 11);
            
            
           
            if (attemptHit %5 == 0)
            {
                return true;
            }
            else
            {
                
                return false;
               
            }


        }
        // Hit Damage Method is to multiply the strength amount by a random number between 1 and 6.
        private int hitDamage()
        {
            int number;
            Random rnd = new Random();
            number = rnd.Next(6)+1;
           
            int damageOnhit = this.strength * number;
          
            return damageOnhit;

        }
        // PUBLIC METHODS +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        public void show()
        {
            Console.WriteLine("The strength is {0}, The health is {1} and the speed is {2} ", this.strength, this.health, this.speed);

        }
        public void fight()
        {
            
            if (hitAttempt() == true)
            {
                int damageAmount = hitDamage();
                Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
                Console.WriteLine("The damage attempt was sucessful, The damage dealt is {0}", damageAmount);
            }
            else 
            {
                Console.WriteLine("No damage dealt");
            }
            
        }

      

   
    }
}

