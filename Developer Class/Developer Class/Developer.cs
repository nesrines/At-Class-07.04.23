 class Developer
{
    public string Name;
    public string Surname;
    public int Age;
    public double Salary;
    public string Position;

    public void GetFullInfo()
    {
        Console.WriteLine(Name + " " + Surname + " " + Age + " " + Salary + " " + Position);
    }

    public Developer(string name, string surname, int age, int salary, string position)
    {
        Name = name;
        Surname = surname;
        Age = age;
        Salary = salary;
        Position = position;
    }
}
