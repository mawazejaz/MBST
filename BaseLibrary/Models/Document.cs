namespace BaseLibrary
{
	public class DocumentModel
	{
		public int Id { get; set; }
		public Guid SubjectId { get; set; }
		public int DocumentTypeId { get; set; }
		public string Title { get; set; }
		public int SizeInKB { get; set; }
		public string DocuementExtension { get; set; }
		public string DocuementBlobUrl { get; set; }
		public bool IsAgent { get; set; }
		public bool IsClient { get; set; }
		public bool ShowAgent { get; set; }
		public bool ShowClient { get; set; }
		public int QuestionnaireId { get; set; }
		public DateTimeOffset DeletedDate { get; set; }
		public Guid CreatedBy { get; set; }
		public DateTimeOffset CreatedDate { get; set; }
		public Guid ModifiedBy { get; set; }
		public DateTimeOffset ModifiedDate { get; set; }
		public string BlobFileName { get; set; }
		public string OldId { get; set; }
		public int SubjectTypeId { get; set; }
		public Guid FamilyId { get; set; }
		public int ImportedFromQuestionOld { get; set; }
		public string BlobContainer { get; set; }
		public int CheckListId { get; set; }
		public int CheckListItemId { get; set; }
	}
}