using System;

public class Produit
{
    public string Name { get; init; }
    public string Description { get; init; }
    public float Price { get; init; }
    public DateTime DateCreation { get; init; }
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
