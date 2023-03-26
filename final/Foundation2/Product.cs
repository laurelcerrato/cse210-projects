public class Product{
    private string _productname;
    private int _productid;
    private int _price;
    private int _quantity;
    public Product(string prodctname, int productid, int price, int quantity){
        _productname = prodctname;
        _productid = productid;
        _price = price;
        _quantity = quantity;
    }
    public int CalculatePrice(){
        return _price * _quantity;
    }
    public string GetProductName(){
        return _productname;
    }
    public int GetProductId(){
        return _productid;
    }
}
