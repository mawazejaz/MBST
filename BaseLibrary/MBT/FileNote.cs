using BaseLibrary.Interface;
using BaseLibrary.Wraper;

namespace BaseLibrary.MBT
{
	public class FileNoteMBT : ICodeGenerator<FileNoteMBT, FileNoteModel>
	{

		private readonly FileNoteModel _data;

		public FileNoteMBT()
		{
			_data = new FileNoteModel();
			RandomFileNote randomFileNote = new RandomFileNote();
			var result = randomFileNote.MakeRequest();
			_data.FileNote = result.Result ?? "";
		}

		public FileNoteModel CreateData()
		{
			return _data;
		}
	}
}