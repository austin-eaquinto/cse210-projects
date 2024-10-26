using System;

class Address
{
    // needs get; set; for user input
    private string _street;
    private string _city;
    private string _stateOrProvince;
    private string _country;

    /* line below sets the parameters and order.
        notice the _varibales store the parameters
        the _variables are then used in the ToString()
        method which returns a string.
        the Address object in the Program.cs takes
        parameters that determine what is printed. */
    publlic Address(string street, string city, string stateOrProvince, string country)
    {
        _street = street;
        _city = city;
        _stateOrProvince = stateOrProvince;
        _country = country;
    }
    public bool CheckOrderLocation(string country)
    {
        /* supposed to determine if the order is 
        from the United States or not */
        _country = country;
        string whatCountry = Console.ReadLine();
        if (whatCountry.ToLower() != "USA")
        {
            return false;
        }
        return true;
    }
    public string CustomerAddress()
    {
        /* this method provides a string representation
        of the object. when i call a print method on an 
        object, it implicitly calls that object's ToString()
        method. */
        return $"{_street}\n{_city}, {_stateOrProvince}\n{_country}";
    }
}