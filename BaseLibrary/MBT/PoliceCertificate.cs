using BaseLibrary.Interface;
using BaseLibrary.Wraper;

namespace BaseLibrary.MBT
{
	public class PoliceCertificateMBT : ICodeGenerator<PoliceCertificateMBT, PoliceCertificateModel>
	{

		private readonly PoliceCertificateModel _data;

		public PoliceCertificateMBT()
		{
			_data = new PoliceCertificateModel();
		
		}

		public PoliceCertificateModel CreateData()
		{
			return _data;
		}
	}
}