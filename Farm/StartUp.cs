namespace Farm
{

    using System;

    class StartUp
    {
        static void Main()
        {
            //Single Inheritance
            //Dog dog = new Dog();
            //dog.Bark();
            //dog.Bark();
            //==================================
            Console.WriteLine();

            //Multiple Inheritance
            Puppy puppy = new Puppy();
            puppy.Eat();
            puppy.Bark();
            puppy.Weep();
            //=================================
            Console.WriteLine();

            //Hierarchical Inheritance
            Dog dog = new Dog();
            dog.Bark();
            dog.Bark();

            Console.WriteLine();

            Cat cat = new Cat();
            cat.Eat();
            cat.Meow();


        }
    }
}
