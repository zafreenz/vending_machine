using System.Collections.Generic;
using System.Linq;

namespace New_Food
{
    public class CartItem
    {
        public int ProductId { get; set; }
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Subtotal => Quantity * UnitPrice;
    }

    public static class CartManager
    {
        public static List<CartItem> Items = new List<CartItem>();

        public static void AddItem(int productId, string itemName, int quantity, decimal unitPrice)
        {
            var existing = Items.FirstOrDefault(i => i.ProductId == productId);

            if (existing != null)
                existing.Quantity += quantity;
            else
                Items.Add(new CartItem
                {
                    ProductId = productId,
                    ItemName = itemName,
                    Quantity = quantity,
                    UnitPrice = unitPrice
                });
        }

        public static void RemoveItem(int productId) => Items.RemoveAll(i => i.ProductId == productId);
        public static void Clear() => Items.Clear();
        public static decimal GetTotal() => Items.Sum(i => i.Subtotal);

        public static int GetTotalQuantity()
        {
            return Items.Sum(i => i.Quantity);
        }
    }
}