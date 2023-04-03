public class Address{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public void SetStreet(string street){
        _street = street;
    }
    public void SetCity(string city){
        _city = city;
    }
    public void SetState(string state){
        _state = state;
    }
    public void SetCountry(string country){
        _country = country;
    }
    public bool UsaOrnot(){
        if (_country=="USA" ||_country=="UNITED STATES"){
            return true;
        }
        else{
            return false;
        }
    }
    public string AddresInfo(){
        return $"{_street},{_city},{_state},{_country}";
    }

}