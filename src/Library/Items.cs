using System;
using System.Collections;

namespace roleplay
{
    public class Item
        {
        public string Name {get;}
        public int Damage     {get;}
        public int Defense      {get;}
        public int Hp      {get;}
        
        public Item(string name, int damage, int defense, int hp)// Constructor de Items
        {
            this.Name    =    name;
            this.Damage  =    damage;
            this.Defense =    defense;
            this.Hp      =    hp;

            Console.WriteLine($"Se a creado el objeto {this.Name}");
            
        }

    }

}
