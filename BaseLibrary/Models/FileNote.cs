namespace BaseLibrary
{
	public class FileNoteModel
	{
		public Guid ClientId { get; set; }
		public string FileNote { get; set; }
		public DateTime CreatedDate { get; set; } = DateTime.Now;
		public Guid CreatedBy { get; set; }

	}
}