namespace EShoppingGatewayAPI.Models
{
    public class ProductDetailsDTO
    {
        //    ProductId,
        //Name,
        //Price,
        //Quantity,
        //Categoryname,
        //NoOfDaysForDelivery
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }
        public string CategoryName { get; set; }
        public int ExpectedDays { get; set; }
    }
}
