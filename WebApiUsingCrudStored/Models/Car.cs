using System;
using System.Collections.Generic;

namespace WebApiUsingCrudStored.Models;

public partial class Car
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Model { get; set; } = null!;

    public string Color { get; set; } = null!;

    public int Year { get; set; }
}
