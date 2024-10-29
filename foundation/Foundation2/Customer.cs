using System;

class Customer
{
    private string _customerName;
    class Address;

    public Customer(string name)
    {
        _customerName = name;
    }
    public string CustomerIdentity()
    {
        return _customerName;
    }
    public void WhereCustomer()
    {
        Address a = new Address();
    }
}