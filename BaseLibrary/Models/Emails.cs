namespace BaseLibrary
{
	public class EmailModel
	{
		public Guid ClientId { get; set; }
		public string Address { get; set; }
		public int EmailTypeId { get; set; }
		public Guid CreatedBy { get; set; }
		public DateTime CreatedDate { get; set; } = DateTime.Now;

	}
}