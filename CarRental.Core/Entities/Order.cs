namespace CarRental.Domain.Entities
{
    public class Order : BaseEntity
    {
        public Renter Renter { get; set; }
        public PriceListItem Item { get; set; }
        public int DaysQuantity { get; set; }

        public int RenterId { get; set; }
        public int PriceListItemId { get; set; }
    }
}
