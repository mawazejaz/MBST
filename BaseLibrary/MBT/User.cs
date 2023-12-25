using BaseLibrary.Interface;
using BaseLibrary.Wraper;

namespace BaseLibrary.MBT
{
	public class UserMBT : ICodeGenerator<UserMBT, UserModel>
	{
		private readonly UserModel _data;

		public UserMBT()
		{
			_data = new UserModel();
			RandomUserWraper randomUserWraper = new RandomUserWraper();
			var randomuser = randomUserWraper.GetUserAsync().Result.Results.FirstOrDefault();
			if (randomuser != null)
			{
				_data.Id = new Guid();
				_data.Title = randomuser.Name.Title;
				_data.FullName = randomuser.Name.First + " " + randomuser.Name.Last;
				_data.Email = randomuser.Email.ToLower();
				_data.Address1 = randomuser.Location.Street + "" + randomuser.Location.State;
				_data.City = randomuser.Location.City;
				_data.Country = randomuser.Location.Country;

			}
		}

		public UserModel CreateData()
		{
			return _data;
		}
	}
}