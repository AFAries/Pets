using System;

namespace Pets
{
    public class Cat : Pet
    {
        public Cat(string name, string owner, double weight) : base ("cat", name, owner, weight)
        {
        }

        //Has to return a string/meows to work 
        //Used a 'for' statement for dogs and a 'while' for cats
        public string meow(int count)
        {
            string meows = "";
            int numMeow = 0;

            while (numMeow < count)
            {
                meows += "meow.";
                numMeow++;
            }
            return meows;
        }
    }
}
