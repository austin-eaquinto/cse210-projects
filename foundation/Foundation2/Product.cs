using System;

class Product
{
    private string _itemName;
    private int _productID;
    private int _price;
    private int _quantity;
    private List<string> _productList;
    public Product(string itemName, int productID, int price, int quantity, List<string> productList)
    {
        _itemName = itemName;
        _productID = productID;
        _price = price;
        _quantity = quantity;
        _productList = new List<string>(productList); // initilizes the list
    }
    public void Subtotal()
    {

    }
}

/* _prompts = ["item", "item", "item"]; */