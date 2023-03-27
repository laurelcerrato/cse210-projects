public class Order{
    private Customer _customer;
    private List<Product> _products = new List<Product>();
    private List<int> prices = new List<int>();
    private int _total;
    private int _usshipping = 5;
    private int _notus = 35;
    private bool _usaornot;
    
    public void SetList(List<Product> list){
        _products = list;
    }
    public void SetUsaornot(bool usaornot){
        _usaornot = usaornot;
    }
    public void TotalCost()
    {

        foreach (Product product in _products){
            int price = product.CalculatePrice();
            prices.Add(price);}
            
            if(_usaornot == true){
                _total = prices.Sum() + _usshipping;
            }else{
                _total = prices.Sum() + _notus;
            }
        
    }

    public void AddProducts(Product product){
        _products.Add(product);
    }
    public int GetTotal(){
        return _total;
    }
    public string PackingLabel(Product product){
        string name = product.GetProductName();
        int id = product.GetProductId();
        return $"{name} - {id}";
    }
    public void SetCustomer(Customer customer){
        _customer = customer;
    }
    public string ShippingLabel(){
        return $"{_customer.GetCustomername()}, {_customer.GetAdrress()}, Total: {_total}";
    }
    public List<Product> GetList(){
        return _products;
    }
}