using System;
using System.Collections.Generic;
using System.Text;

public class Order
{
    private List<Product> products;
    private Customer customer;

    public Order(Customer customer)
    {
        products = new List<Product>();
        this.customer = customer;
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public decimal CalculateTotalCost()
    {
        decimal totalCost = 0;

        foreach (var product in products)
        {
            totalCost += product.CalculateTotalCost();
        }

        if (customer.IsInUSA())
        {
            totalCost += 5; 
        }
        else
        {
            totalCost += 35; 
        }

        return totalCost;
    }

    public string GetPackingLabel()
    {
        StringBuilder sb = new StringBuilder();

        sb.AppendLine("Packing Label:");
        foreach (var product in products)
        {
            sb.AppendLine($"- Product Name: {product.GetName()}, Product ID: {product.GetProductId()}");
        }

        return sb.ToString();
    }

    public string GetShippingLabel()
    {
        StringBuilder sb = new StringBuilder();

        sb.AppendLine("Shipping Label:");
        sb.AppendLine($"- Customer Name: {customer.GetName()}");
        sb.AppendLine("- Address:");
        sb.AppendLine(customer.GetAddress().GetFullAddress());

        return sb.ToString();
    }
}
