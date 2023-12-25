using BaseLibrary.Wraper;

namespace BaseLibrary
{
	public class ClientModel
	{
		public Guid Id { get; set; }
		public string ClientNumber { get; set; } = RandomNumber.GenerateRandomNumber(7).ToString();
		public Guid BranchId { get; set; }
		public string EZMId { get; set; } = RandomNumber.GenerateRandomNumber(4).ToString();
		public Guid FamilyId { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string MiddleName { get; set; } = string.Empty;
		public string Title { get; set; }
		public int Gender { get; set; }
		public DateTime DateOfBirth { get; set; }
		public string MaritalStatus { get; set; }
		public byte DependentChildren { get; set; } = 0;
		public string Notes { get; set; } = string.Empty;
		public Guid CreatedBy { get; set; }
		public DateTime CreatedDate { get; set; }
		public string ImageBlobUrl { get; set; }
		public string NationalityId { get; set; }
		public string NationalityCountry { get; set; }
		public string SkypeID { get; set; }
		public string ArbitaryJson { get; set; } = @"{""Signed"":false,""Onshore"":false,""Active"":false,""AllowUpdate"":false,""AreaAccess"":false}";
	}

	public enum Gnderenum
	{
		male, female
	}
	public enum MaritalStatus
	{
		Single,
		Married,
		Divorced,
		Widowed,
		Separated,
		Other
	}

}