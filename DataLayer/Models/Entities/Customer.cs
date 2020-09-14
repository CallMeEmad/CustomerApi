namespace CustomerApi.DataLayer.Models.Entities
{
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string InternationalCode { get; set; }
        public string TelephoneNumber { get; set; }
        public string Address { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
