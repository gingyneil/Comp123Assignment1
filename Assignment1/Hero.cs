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
          //  Console.WriteLine("This is the strength {0}, speed {1} and health {2} for the {3} Hero ", strength, speed, health, name);
            this.name = name;
           
        }
        public void show() 
        {
            Console.WriteLine("The strength is {0}, The health is {1} and the speed is {2} ", this.strength,this.health,this.speed);
        
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
           //THIS IS WEIRD BUT IT WORKS, WITH ONE RND METHOD I ALWAYS ENDED UP WITH THE SAME NUMBER (1) BY DECLARING A SECOND HITATTEMPT VARIABLE AND ASSIGNING IT
           //TO HITATTEMPT2 MY RND NUMBER WAS SUCESSFULLY ALWAYS DIFFERENT (I DONT FULLY UNDERSTAND IT BUT SOMEHOW IT CHANGED THE SEED OR SOMETHING OR OTHER
            Random rnd = new Random();
            int attemptHit = rnd.Next(1, 11);
            int attemptHit2 = attemptHit;
            attemptHit2 = rnd.Next(1, 11);
           
            if (attemptHit2 <= 2)
            {
                return true;
            }
            else
            {
                
                return false;
               
            }


        }
        private int hitDamage()
        {
            int number;
            Random rnd = new Random();
            number = rnd.Next(6)+1;
           // Console.WriteLine(number);
            int damageOnhit = this.strength * number;
           // Console.WriteLine(damageOnhit);
            return damageOnhit;

        }
        // PUBLIC METHODS +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public void fight()
        {
            
            if (hitAttempt() == true)
            {
                int damageAmount = hitDamage();
                Console.WriteLine("The damage attempt was sucessful, The damage dealt is {0}", damageAmount);
            }
            else 
            {
                Console.WriteLine("No damage dealt");
            }
            
        }

      

   
    }
}

