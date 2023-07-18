public class Product
{
    private string _name;
    private string _productID;
    private float _unitPrice;
    private float _totalPrice;
    private int _quantity;

    public Product(string name, string productID, float unitPrice, int quantity)
    {
        _name = name;
        _productID = productID;
        _unitPrice = unitPrice;
        _quantity = quantity;
        CalculateTotalPrice();
    }

    //PRODUCT NAME
    public string GetProductName()
    {
        return _name;
    }
    public void SetProductName(string name)
    {
        _name = name;
    }

    //RPODUCT ID
    public string GetProductID()
    {
        return _productID;
    }
    public void SetProductID(string productID)
    {
        _productID = productID;
    }

    //UNIT PRICE
    public float GetUnitPrice()
    {
        return _unitPrice;
    }
    public void SetUnitPrice(float unitPrice)
    {
        _unitPrice = unitPrice;
    }

    //QUANTITY
    public int GetQuantity()
    {
        return _quantity;
    }
    public void SetQuantity()
    {
        
    }

    //TOTAL
    public float GetTotalPrice()
    {
        return _totalPrice;
    }
    private void CalculateTotalPrice()
    {
        _totalPrice = _unitPrice * _quantity;
    }

}