public class Customer{
    private string _customername;
    private Address _address;
    public Customer(string name){
        _customername = name;
    }
    public bool LiveinUsa(Address adr){
        return adr.UsaOrnot();
    }
    public void SetAddress(Address address){
        _address = address;
    }
    public string GetCustomername(){
        return _customername;
    }
}