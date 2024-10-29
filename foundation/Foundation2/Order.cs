using System;

class Order
{
    private List<Product> _products;
    private string _customer;
    private int _subtotal;
    private string _packingLabel;
    private string _shippingLabel;
    private int _costOfShipping;

    public Order()
    {

    }
    public void TotalCost(int subtotla, List<Product> products)
    {

    }
    public void ShippingCost()
    { // call in the InUSA method from the address class.

    }
    public void PackingLabel()
    { // call in the a method from the Product class to supply the details
        // probably return a string

    }
    public void ShippingLabel()
    { // call in the ToString() from address?

    }
}
// nee two orders with 2-3 products each