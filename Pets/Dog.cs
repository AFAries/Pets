using System;

namespace Pets
{
    public class Dog : Pet
    {

        public Dog(string name, string owner, double weight) : base("dog", name, owner, weight)
        { 
        }

        //Has to return a string/barks to work
        //Used a 'for' statement for dogs and a 'while' for cats
        public string bark(int count)
        {
            string barks = "";

            for(int b = 0; b < count; b++)
            {
                barks += "bark!";
            }
            return barks;
        }
    }
}

