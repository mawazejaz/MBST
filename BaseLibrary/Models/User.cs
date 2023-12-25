namespace BaseLibrary
{
	public class UserModel
	{
		public Guid Id { get; set; }
		public int RoleId { get; set; }
		public string Email { get; set; }
		public string FullName { get; set; }
		public string Title { get; set; }
		public string Image { get; set; }
		public DateTimeOffset LastSignedIn { get; set; }
		public string TimeZone { get; set; }
		// Additional related classes
		public string Address1 { get; set; }
		public string Address2 { get; set; }
		public string Address3 { get; set; }
		public string City { get; set; }
		public string Country { get; set; }
		public DateTimeOffset DeletedDate { get; set; }
		public Guid CreatedBy { get; set; }
		public DateTimeOffset CreatedDate { get; set; }
		public Guid ModifiedBy { get; set; }
		public DateTimeOffset ModifiedDate { get; set; }
	}
}