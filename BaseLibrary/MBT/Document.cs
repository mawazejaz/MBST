using BaseLibrary.Interface;

namespace BaseLibrary.MBT
{
	public class DocumentMBT : ICodeGenerator<DocumentMBT, DocumentModel>
	{
		private readonly DocumentModel _data;

		public DocumentMBT()
		{
			_data = new DocumentModel();

		}

		public DocumentModel CreateData()
		{
			return _data;
		}
	}
}