﻿namespace Restful.Core.Models;

public class Product : BaseModel
{
    public string Name { get; set; }
    public int Stock { get; set; }
    public decimal Price { get; set; }
}
