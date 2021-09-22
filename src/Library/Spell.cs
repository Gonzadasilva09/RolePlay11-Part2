using System;
using System.Collections;

namespace roleplay
{
    public class Spell
    {
        public string Name{get;}
        public int Power{get;set;}
        

        public Spell(string name, int power)
        {
            this.Name = name;
            this.Power = power;
            Console.WriteLine($"Se creo el hechizo {this.Name}");
        }


    } 
}