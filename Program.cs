using System;
class Program
{
    static void Main(string[] args)
    {
        //print hello wolrd to the screen
        Console.WriteLine("Hello, World!");

        //create an instance of the person object and provide the info
        Person person1 = new Person("Prince", 21);
        Person person2 = new Person("John", 25);

        //print user into to screen
        person1.PrintInfo();
        person2.PrintInfo();
    }

}