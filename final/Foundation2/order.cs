public class Order{
    private Customer _costumer;
    private List<Product> _products = new List<Product>();
    private List<int> prices = new List<int>();
    private int _total;
    private int _usshipping = 5;
    private int _notus = 35;

    public void TotalCost(bool usaornot, List<Product> list )
    {

        foreach (Product product in list){
            int price = product.CalculatePrice();
            prices.Add(price);}
            
            if(usaornot == true){
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
    public string ShippingLabel(string name, string address){
        return $"{name}, {address}, Total: {_total}";
    }
    public List<Product> GetList(){
        return _products;
    }
    public int ForeachLoop(int[] sourceArray)
{
    var result = 0;
    foreach (var item in sourceArray)
        result += item;
    return result;
}
}