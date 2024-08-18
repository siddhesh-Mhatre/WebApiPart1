using System;
using System.Collections.Generic;

namespace WebApiUsingCrudStored.Models;

public partial class Product
{
    public int Id { get; set; }

    public string ProdName { get; set; } = null!;

    public int Price { get; set; }

    public string Category { get; set; } = null!;
}
