namespace BaseLibrary
{
	public class AdressModel
	{
		public long Id { get; set; }
		public Guid ClientId { get; set; }
		public string ContactPerson { get; set; }
		public string Flat { get; set; }
		public string Building { get; set; }
		public string StreetName { get; set; }
		public string Suburb { get; set; }
		public string StreetNumber { get; set; }
		public string City { get; set; }
		public string State { get; set; }
		public string Zip { get; set; }
		public int Country { get; set; }
		public int AddressTypeId { get; set; }
		public Guid CreatedBy { get; set; }
		public DateTime CreatedDate { get; set; } = DateTime.Now;

	}
}