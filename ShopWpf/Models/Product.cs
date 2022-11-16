using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopProgramWpf.Models;

public class Product
{
    public Guid Id { get; set; } = Guid.NewGuid();

    public string Image { get; set; }
    public string? Name { get; set; }
    public int Count { get; set; }
    public float Cost { get; set; }

    public Product(string Image, string Name, int Count, float Cost)
    {
        this.Image = Image;
        this.Name = Name;
        this.Count = Count;
        this.Cost = Cost;
    }
}