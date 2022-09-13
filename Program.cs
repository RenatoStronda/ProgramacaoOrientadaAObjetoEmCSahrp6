// See https://aka.ms/new-console-template for more information
using System;

namespace heranca{
    class Program{
    public static void Main(string[] args) {
        Gato g = new Gato();
        Animal a = new Gato();
        a.GetEmitirSom();
        a = new Dog();
        a.GetEmitirSom();
    }
}
public abstract class Animal{
    private Animal gato, dog;

public Animal(Animal gato, Animal dog){
    this.Animal = gato;
    this.Animal = dog;
}
}

public virtual void GetEmitirSom(){
    Console.WtriteLine($"GetEmitirSom: {miau}");
}

public virtual void GetEmitirSom(){
    Console.WtriteLine($"GetEmitirSom: {auau}");
}
}

public class Gato : Animal
{
  public Gato(Animal g, Animal d) : base(g, d)
  {

  }
  public override void GetEmitirSom(){
    base.GetEmitirSom();
  }
}

public class Dog : Animal
{
  public Dog(Animal g, Animal d) : base(g, d)
  {

  }
  public override void GetEmitirSom(){
    base.GetEmitirSom();
  }
}