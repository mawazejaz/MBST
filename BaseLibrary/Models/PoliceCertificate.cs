namespace BaseLibrary
{
	public class PoliceCertificateModel
	{

		public long Id { get; set; }
		public Guid ClientId { get; set; }
		public DateTime IssueDate { get; set; }
		public int Country { get; set; }
		public DateTime CertificateExpiryDate { get; set; }
		public Guid CreatedBy { get; set; }
		public DateTime CreatedDate { get; set; }

	}
}