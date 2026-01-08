class Person
{
    public string? Name { get; set; }
    public int Age { get; set; }

    //create a constructor for the person object
    public Person(string? name, int age)
    {
        Name = name;
        Age = age;
    }

    //create a public method that can be called to print user info
    public void PrintInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}
