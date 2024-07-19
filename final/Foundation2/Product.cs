public class Product
{
    private string name;
    private int productId;
    private decimal pricePerUnit;
    private int quantity;

    public Product(string name, int productId, decimal pricePerUnit, int quantity)
    {
        this.name = name;
        this.productId = productId;
        this.pricePerUnit = pricePerUnit;
        this.quantity = quantity;
    }

    public string GetName()
    {
        return name;
    }

    public int GetProductId()
    {
        return productId;
    }

    public decimal CalculateTotalCost()
    {
        return pricePerUnit * quantity;
    }
}
