using System;
using System.Collections;

namespace roleplay
{
    public class Dwarf
    {
        public string Name{get;}
        public int Defense{get;set;}
        public int Hp{get;set;}
        public string Power{get;}
        public int Damage{get;set;}
        bool Pocket=false;
        public int HpMax{get;}

        public Dwarf (string name, int defense, int hpmax, string power, int damage)// Constructor para los enanos
        {
            this.Name = name;
            this.Defense = defense;
            this.Hp = hpmax;
            this.Power = power;
            this.Damage = damage;
            this.HpMax = hpmax;

            Console.WriteLine("Se ha creado el Enano!");
        }

        public void AddItem(Item item)// Metodo para agregar item a los enanos
        {
            if (!Pocket)
            {
                this.Damage += item.Damage;
                this.Hp     += item.Hp;
                this.Defense+= item.Defense;
                Console.WriteLine($"Gracias a recibir el item {item.Name}, {this.Name} a aumentado sus estadisticas");
                Console.WriteLine ($"Sus estadisticas son...");
                Console.WriteLine ($"Vida = {this.Hp}");
                Console.WriteLine ($"Daño = {this.Damage}");
                Console.WriteLine ($"Defensa = {this.Defense}");
                Pocket=true;
            }
            else
            {
                Console.WriteLine("El personaje tiene un item equipado");
            }
        }
        public void RemoveItem(Item item)// Metodo para remover items de los enanos
        {
            if (Pocket)// Pocket verifica si el personaje tiene un objeto equipado o no, en case de ser falsa el bolsillo esta vacio y permite equipar un objeto, de lo contrario devolvera un mensaje diciendo que no se puede equipar un objeto 
            {
                this.Damage -= item.Damage;
                this.Hp     -= item.Hp;
                this.Defense-= item.Defense;
                Console.WriteLine($"Se le elimino el item {item.Name}, {this.Name} a perdido estadisticas");
                Console.WriteLine ($"Sus estadisticas son...");
                Console.WriteLine ($"Vida = {this.Hp}");
                Console.WriteLine ($"Daño = {this.Damage}");
                Console.WriteLine ($"Defensa = {this.Defense}");
                Pocket=false;
            }
            else
            {
                Console.WriteLine("El personaje no tiene un item equipado");
            }
        }
    }
}