class Program
{
    static void Main(string[] args)
    {
        Animal myAnimal = new Animal();
        Animal myPig = new Pig();
        Animal myDog = new Dog();
        myAnimal.animalSound();
        myPig.animalSound();
        myDog.animalSound();

        Console.WriteLine();
        
        Arbol myArbol = new Arbol();
        Arbol myNogal = new Nogal();
        Arbol myHiguera = new Higuera();
        myArbol.arbolFruta();
        myNogal.arbolFruta();
        myHiguera.arbolFruta();
    }
}