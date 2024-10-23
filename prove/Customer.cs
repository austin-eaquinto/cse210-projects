using System;

class CustomerAddress{
    private string _customerName;
    class Address;

    public CustomerAddress(string name)
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