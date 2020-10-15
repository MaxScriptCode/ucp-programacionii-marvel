using System;


public class Villano:Personaje{
    public override void Atacar(Personaje p){
        Console.WriteLine("El villano ataca al heroe.");
    }   
}