using System;

// Клас Address
class Address
{
    public int Index { get; set; }
    public string Country { get; set; }
    public string City { get; set; }
    public string Street { get; set; }
    public string House { get; set; }
    public string Apartment { get; set; }

    public Address(int index, string country, string city, string street, string house, string apartment)
    {
        Index = index;
        Country = country;
        City = city;
        Street = street;
        House = house;
        Apartment = apartment;
    }
}

// Клас Converter
class Converter
{
    private double USD { get; }
    private double EUR { get; }
    private double PLN { get; }

    public Converter(double usd, double eur, double pln)
    {
        USD = usd;
        EUR = eur;
        PLN = pln;
    }

    public double ConvertToUSD(double uah)
    {
        return uah / USD;
    }

    public double ConvertToEUR(double uah)
    {
        return uah / EUR;
    }

    public double ConvertToPLN(double uah)
    {
        return uah / PLN;
    }

    public double ConvertFromUSD(double usd)
    {
        return usd * USD;
    }

    public double ConvertFromEUR(double eur)
    {
        return eur * EUR;
    }

    public double ConvertFromPLN(double pln)
    {
        return pln * PLN;
    }
}

// Клас Employee
class Employee
{
    public string LastName { get; set; }
    public string FirstName { get; set; }
    public string Position { get; set; }
    public int Experience { get; set; }

    public Employee(string lastName, string firstName)
    {
        LastName = lastName;
        FirstName = firstName;
    }

    public double CalculateSalary()
    {
        // Розрахунок окладу (залежно від посади та стажу) тут
        // Приклад: просто повертаємо фіксований оклад
        return 5000;
    }

    public double CalculateTax()
    {
        // Розрахунок податкового збору 
        // Приклад: просто повертаємо фіксований податок
        return 1000;
    }
}

// Клас User
class User
{
    public string Login { get; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public DateTime RegistrationDate { get; }

    public User(string login, string firstName, string lastName, int age)
    {
        Login = login;
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        RegistrationDate = DateTime.Now;
    }

    public void DisplayUserInfo()
    {
        Console.WriteLine($"Логін: {Login}");
        Console.WriteLine($"Ім'я: {FirstName}");
        Console.WriteLine($"Прізвище: {LastName}");
        Console.WriteLine($"Вік: {Age}");
        Console.WriteLine($"Дата реєстрації: {RegistrationDate}");
    }
}