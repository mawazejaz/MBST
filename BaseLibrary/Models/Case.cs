namespace BaseLibrary
{
	public class CaseModel
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public DateTimeOffset DeletedDate { get; set; }
		public Guid CreatedBy { get; set; }
		public DateTimeOffset CreatedDate { get; set; }
		public Guid ModifiedBy { get; set; }
		public DateTimeOffset ModifiedDate { get; set; }
		public string OldId { get; set; }
	}
}