namespace AlisverisSitesi.Models
{
    public class CartItem
    {
        public int UrunId { get; set; }
        public string UrunName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal Total
        {
            get { return Quantity * Price; }
        }
        public string Image { get; set; }

        public CartItem()
        {
        }

        public CartItem(Urun urun)
        {
            UrunId = urun.Id;
            UrunName = urun.Name;
            Price = urun.Price;
            Quantity = 1;
            Image = urun.Image;
        }
    }
}


       

    
