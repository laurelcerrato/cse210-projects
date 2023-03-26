public class Order{
    private Customer _costumer;
    private List<Product> _products = new List<Product>();
    private int _total;
    private int _usshipping = 5;
    private int _notus = 35;

    public void TotalCost(){
        foreach(Product product in _products){
            int price = product.CalculatePrice();
            _total = price+price;
        }
        
    }
    public void PackingLabel(){
        return $""
    }
    public string ShippingLabel(){

    }
    public string SetCostumer(string costumer){
        
    }
}