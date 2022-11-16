using ShopProgramWpf.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ShopProgramWpf.FakeDatas;

public class FakeProducts
{
    public List<Product> products = new()
    {
        new Product("C:\\User\\source\\repos\\ShopWpf\\ShopWpf\\Images\\iphone_11.jpg", "Iphone", 12, 12.5f),
        new Product("", "Samsung", 34, 1.5f),
        new Product("", "Xiaomi", 12, 2.5f),
        new Product("", "Samsung", 34, 1.5f),
        new Product("", "Xiaomi", 12, 2.5f),
        new Product("", "Samsung", 34, 1.5f),
        new Product("", "Xiaomi", 12, 2.5f),
        new Product("", "Samsung", 34, 1.5f),
        new Product("", "Xiaomi", 12, 2.5f),

        new Product("C:\\User\\source\\repos\\ShopWpf\\ShopWpf\\Images\\iphone_11.jpg", "Iphone", 12, 12.5f),
    };
}