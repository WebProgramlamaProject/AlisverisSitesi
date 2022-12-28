using AlisverisSitesi.Models;

namespace AlisverisSitesi.Models.ViewModels
{
    public class CartViewModel
    {
        public List<CartItem> CartItems { get; set; }
      
        public decimal GrandTotal { get; set; }
    }
}

    
    
