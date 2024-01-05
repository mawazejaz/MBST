using BaseLibrary.Interface;
using BaseLibrary.Wraper;

namespace BaseLibrary.MBT
{
	public class UserMBT : ICodeGenerator<UserMBT, UserModel>
	{
		private readonly UserModel _data;

		public UserMBT()
		{
			_data = new UserModel()
			{
				Email = "nabeeloutsourcenz1@gmail.com",
				Password = "password",
			};
		}

		public UserModel CreateData()
		{
			return _data;
		}
		public async Task<string> Login()
		{
			EndPointCall endPointCall = new EndPointCall();
			string apiUrl = ApisSettings.baseUrl+ ApisSettings.versionUrl+ ApisSettings.loginUrl;
			string token = string.Empty;
			// Set the payload
			var payload = new
			{
				email = "nabeeloutsourcenz1@gmail.com",
				password = "Nabeel@123"
			};

			try
			{
				// Call the Login method to authenticate user
				 token = await endPointCall.CallEndPoint(apiUrl, payload);

				if (!string.IsNullOrEmpty(token))
				{
					Console.WriteLine("Login successful Token");
				}
				else
				{
					Console.WriteLine("Login failed.");
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error: " + ex.Message);
			}

			return token;
		}
	}
}