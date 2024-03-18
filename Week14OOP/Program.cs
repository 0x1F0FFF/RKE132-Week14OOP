Console.WriteLine("Name your dog: ");
string myDogName = Console.ReadLine();

Dog mydog = new Dog(myDogName);

Dog neighboursDog = new Dog("Bad Boy");

Console.WriteLine($"My dogs name is {mydog.Name}.");
Console.WriteLine($"My neighbour's dog name is {neighboursDog.Name}.");

mydog.Rename("Bad Boy");

while (mydog.LevelOfHappiness != 5)
{
    mydog.Bark();
}

mydog.WagTail();

class Dog
{
    private string _name;
    private int _levelOfHappiness;

    // constructor
    public Dog(string name) // name - lets the user name the dog
    {
        _name = name;
        _levelOfHappiness = 0;
    }

    // getter
    public string Name
    {
        get { return _name; }
    }

    public int LevelOfHappiness
    {
        get { return _levelOfHappiness; }
    }

    // setter
    public void Rename(string newName)
    {
        _name = newName;
        Console.WriteLine($"The dog has been renamed, new name is {newName}.");
    }

    public void Bark()
    {
        Console.WriteLine("Woof-woof");
        _levelOfHappiness++;
    }

    public void WagTail()
    {
        Console.WriteLine("Wiggle-wiggle");
    }
}
