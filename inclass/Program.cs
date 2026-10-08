// See https://aka.ms/new-console-template for more information

using inclass;
using System.Threading.Channels;

//TransportShip transportship = new TransportShip(5);
//Console.WriteLine(transportship.Move(10));

//Console.WriteLine(transportship.ToString()); 


//Dog dog = new Dog() { Weight = 30, Name = " buddy" };
//Donkey donkey = new Donkey() { Weight = 50, Name = "yampanpon" };
//Cat cat = new Cat() { Weight = 10, Name = "makao" };
//Bear bear = new Bear() { Weight = 200, Name = "poo" };

//Animal[] animals = new Animal[] { cat, bear, donkey, dog };

//Dog dog2 = new Dog();
//Console.WriteLine(Dog.counter);
//Console.WriteLine(Dog.DoSomething());

//foreach (Animal animal in animals)
//{
//    Console.WriteLine(animal.SayHello());
//}



//Student std1 = new Student() { Name = "john", Age  = 20 };
//Student std2 = new Student() { Name = "Alice", Age = 22 };
//Student[] students = { std1, std2 };
//Array.Sort(students);

//foreach (Student student in students)
//{
//    Console.WriteLine(student);
//}



Console.WriteLine("hello to github!");



while (true)
{
    try
    {

        Console.WriteLine("Enter the number please: ");
        int num = int.Parse(Console.ReadLine());
        num = num + 3;
        //num = num / 0;
        test();
        Console.WriteLine("Result is : " + num);


    }
    catch (FormatException ex)
    {
        Console.WriteLine("Format Exception " + ex.Message);
    }
    catch (DivideByZeroException ex)
    {
        Console.WriteLine("DivideByZeroException" + ex.Message);
    }

    catch (Exception ex)
    {

        Console.WriteLine("General Exception " + ex.Message);
    }

}

static void test()
{

    Console.Write("Enter your name please: ");
    string? name = Console.ReadLine();
    if (name == "ido")
    { Console.WriteLine("hello " + name); }

    else
    { throw new Exception("name is not ido"); }
}



