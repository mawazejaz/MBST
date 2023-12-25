using BaseLibrary.Interface;

namespace BaseLibrary.MBT
{
	public class EmailMBT : ICodeGenerator<EmailMBT, EmailModel>
	{
		private readonly EmailModel _data;

		public EmailMBT(string email)
		{
			_data = new EmailModel();
			_data.Address = email;
			_data.EmailTypeId = 1;
		}

		public EmailModel CreateData()
		{
			return _data;
		}
	}
}