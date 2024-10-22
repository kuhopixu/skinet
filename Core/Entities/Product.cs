using System;

namespace Core.Entities;

public class Product : BaseEntity
{
    public required string Name { get; set; }

    public required string Description { get; set; }

    public decimal Price { get; set; }

    public string PictureURL {get; set; } = "default.jpeg";

    public required string Type { get; set; }

    public required string Brand { get; set; }

    public int QuantityInStock {get; set;}
}
