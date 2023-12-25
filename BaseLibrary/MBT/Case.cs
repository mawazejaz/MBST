using BaseLibrary.Interface;

namespace BaseLibrary.MBT
{
	public class CaseMBT : ICodeGenerator<CaseMBT, CaseModel>
	{
		private readonly CaseModel _data;

		public CaseMBT()
		{
			_data = new CaseModel();

		}

		public CaseModel CreateData()
		{
			return _data;
		}
	}
}