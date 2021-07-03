using System;

public class Produit
{
    public string Name { get; init; }
    public string Description { get; init; }
    public DateTime DateCreation { get; init; }

    public Produit() { }

    public Produit(string name, string description, DateTime dateCreation) => (Name, Description, DateCreation) = (name, description, dateCreation);

    public void Deconstruct(out string name, out string description, out DateTime dateCreation) => (name, description, dateCreation) = (Name, Description, DateCreation);
}

public class Categorie
{
    private string name { get; init; }
    private DateTime dateCreation { get; init; }
    private string description { get; init; }   

    public string Name
    {
        get => name;
        init => name = (value ?? throw new ArgumentException(nameof(Name)));
    }

    public string Description
    {
        get => description;
        init => description = (value ?? throw new ArgumentException(nameof(Description)));
    }

    public DateTime DateCreation
    {
        get => dateCreation;
        init => dateCreation = value;
    }
}

record Order
{   
    private Produit produit { get; init; }
    private DateTime dateCreation { get; init; }
    private string description { get; init; }

    public Produit Produit
    {
        get => produit;
        init => produit = (value ?? throw new ArgumentException(nameof(Produit)));
    }

    public string Description
    {
        get => description;
        init => description = (value ?? throw new ArgumentException(nameof(Description)));
    }

    public DateTime DateCreation
    {
        get => dateCreation;
        init => dateCreation = value;
    }
}

//public record Person(string FirstName, string LastName, string[] PhoneNumbers);

public abstract record Person(string FirstName, string LastName);

public record Teacher(string FirstName, string LastName, int Grade)
    : Person(FirstName, LastName);

public record Student(string FirstName, string LastName, int Grade)
    : Person(FirstName, LastName);


