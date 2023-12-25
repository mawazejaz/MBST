using BaseLibrary.Interface;
using BaseLibrary.Wraper;

namespace BaseLibrary.MBT
{
	public class ClientMBT : ICodeGenerator<ClientMBT, ClientModel>
	{
		private readonly ClientModel _data;
		public ClientMBT(RandomUser cli)
		{
			_data = new ClientModel();
			_data.Id = Guid.NewGuid();
			_data = new ClientModel();
			_data.FirstName = cli.Name.First;
			_data.LastName = cli.Name.Last;
			_data.Title = cli.Name.Title;
			_data.FamilyId = _data.Id;
			// _client.Gender = Enum.TryParse<Gnderenum>(cli.Gender??"male", true, out Gnderenum genderEnum);
			_data.DateOfBirth = cli.Dob.Date;
			_data.MaritalStatus = MaritalStatus.Married.ToString().ToLower();

		}

		public ClientModel CreateData()
		{
			return _data;
		}
	}
}