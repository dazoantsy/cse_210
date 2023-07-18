public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }
    
    //NAME
    public string GetName()
    {
        return _name;
    }

    //ADDRESS
    public Address GetAddress()
    {
        return _address;
    }

    public bool IsFromUSA()
    {
        return _address.LivesInUSA();
    }

}