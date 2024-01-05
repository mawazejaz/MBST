
using BaseLibrary.MBT;
using BaseLibrary.Wraper;

namespace StateMachine
{
	public class StateMachineModel
	{
		RandomUser randomClient = new RandomUser();


		DocumentMBT documentMBT = new DocumentMBT();

		FileNoteMBT fileNoteMBT = new FileNoteMBT();
		PoliceCertificateMBT policeCertificateMBT = new PoliceCertificateMBT();
		string token = "ABC";
		public async Task ProcessTransition(string fromState, string toState)
		{
			switch (fromState)
			{
				#region from start State
				case "":
					if (toState == "UserLogin")
					{
						// Call method for transition from '' to 'Login'
						if (string.IsNullOrEmpty(token))
						{
							await ProcessToDashboardTransition(token);
						}
					}
					break;
				#endregion

				#region from Login
				case "UserLogin":
					if (toState == "Dashboard")
					{
						// Call method for transition from 'Login' to 'Dashboard'
						await ProcessToDashboardTransition(token);
					}
					if (toState == "UserLogin")
					{
						// Call method for transition from 'Login' to 'Dashboard'
						token = await ProcessLoginTransition(token);

					}
					// Add more cases for other states as needed
					break;

				case "Dashboard":
					if (toState == "Clients")
					{
						await ProcessCLientTransition(token);
					}
					if (toState == "PotentialClient")
					{
						// Call method for transition from 'Login' to 'Dashboard'
						await ProcessPCCLientTransition(token);
					}

					break;
				#endregion

				#region from client State
				case "Clients":
					if (toState == "Login")
					{
						// Call method for transition from '' to 'Login'
						await ProcessToDashboardTransition(token);

					}
					else if (toState == "Adress")
					{

					}
					else if (toState == "CaseManagement")
					{

					}
					else if (toState == "Email")
					{
						await ProcessEmailTransition(token);
					}
					else if (toState == "FileNote")
					{
						await ProcessFileNoteTransition(token);
					}
					else if (toState == "Police Certificate")
					{
						await ProcessPoliceCertificateTransition(token);
					}

					// Add more cases for other states as needed
					break;
				#endregion

				#region from Email State
				case "Email":
					if (toState == "Login")
					{
						await ProcessLoginTransition(token);
					}
					else if (toState == "Adress")
					{
						await ProcessAdressTransition(token);
					}
					// Add more cases for other states as needed
					break;
				#endregion

				#region from FileNote State
				case "FileNote":
					if (toState == "Login")
					{
						await ProcessLoginTransition(token);
					}
					else if (toState == "Adress")
					{
						await ProcessAdressTransition(token);
					}
					// Add more cases for other states as needed
					break;
				#endregion

				#region from Police Certificate State
				case "Police Certificate":
					if (toState == "Login")
					{
						// Call method for transition from '' to 'Login'
						await ProcessLoginTransition(token);
					}
					else if (toState == "Adress")
					{
						// Call method for transition from '' to 'Adress'
						await ProcessAdressTransition(token);
					}
					break;
				#endregion

				#region from Police Certificate State
				case "PotentialClient":
					if (toState == "FileNotes")
					{

					}
					else if (toState == "Document")
					{

					}
					break;
				#endregion

				default:
					break;
			}
		}

		public async Task<string> ProcessLoginTransition(string token)
		{
			if (string.IsNullOrEmpty(token))
			{
				//return await userMBT.Login();
				UserMBT userMBT = new UserMBT();
				var user = userMBT.CreateData();
				Console.WriteLine("Login User Email :  " + user.Email + " Password : " + user.Password);
			}
			else {
				Console.WriteLine("--------------User Already Loged In------------------");
			}
			return token;
		}
		
		private async Task ProcessAdressTransition(string token)
		{
			await IsLogedIn(token);
		}

		private async Task ProcessToDashboardTransition(string token)
		{
			await IsLogedIn(token);
			Console.WriteLine("-------------------Load Dashboard-----------------------");

		}


		private async Task ProcessEmailTransition(string token)
		{
			await IsLogedIn(token);
			Console.WriteLine("--------------------User Email----------------------");
			Console.WriteLine("User Id :: " + randomClient.Id);
			Console.WriteLine("User Eamil :: "+ randomClient.Email);


		}

		private async Task ProcessFileNoteTransition(string token)
		{
			await IsLogedIn(token);
		}

		private async Task ProcessPoliceCertificateTransition(string token)
		{
			await IsLogedIn(token);
			Console.WriteLine("Process Police Certificate");
		}
		private async Task ProcessCLientTransition(string token)
		{
			await IsLogedIn(token);
			Console.WriteLine("-----------Process CLient-----------");
			RandomUserWraper randomUserWraper = new RandomUserWraper();
			var clients = await randomUserWraper.GetUserAsync();
			var client = clients.Results.FirstOrDefault();
			if (client != null)
			{
				ClientMBT clientMBT = new ClientMBT(client);
				Console.WriteLine("-----------------Client Data--------------------");
				Console.WriteLine("Client First Name --- "+ client.Name.First);
				Console.WriteLine("Client Last Name --- " + client.Name.Last);
				Console.WriteLine("Client Title  --- " + client.Name.Title);
				Console.WriteLine("Client Gender --- " + client.Gender);
				Console.WriteLine("Client Email --- " + client.Email);
				Console.WriteLine("Client DOB --- " + client.Dob);
				Console.WriteLine("Client Phone --- " + client.Phone);
				Console.WriteLine("---------------------------------------------");
				randomClient = client;
			}
			else
			{
				Console.WriteLine("----------------Client Data------------------");
				Console.WriteLine("Exception : Client Data Not Genrated");
				Console.WriteLine("---------------------------------------------");
			}
		}
		private async Task ProcessPCCLientTransition(string token)
		{
			await IsLogedIn(token);
			Console.WriteLine("Potential CLient");
			RandomUserWraper randomUserWraper = new RandomUserWraper();
			var clients = await randomUserWraper.GetUserAsync();
			var client = clients.Results.FirstOrDefault();
			if (client != null)
			{
				ClientMBT clientMBT = new ClientMBT(client);
				Console.WriteLine("-----------------Potential CLient Data--------------------");
				Console.WriteLine("Potential CLient Full Name --- " + client.Name.First+" "+ client.Name.Last);
				Console.WriteLine("Potential CLient Title  --- " + client.Name.Title);
				Console.WriteLine("Potential CLient Gender --- " + client.Gender);
				Console.WriteLine("Potential CLient Email --- " + client.Email);
				Console.WriteLine("Potential CLient DOB --- " + client.Dob);
				Console.WriteLine("Potential CLient Phone --- " + client.Phone);
				Console.WriteLine("---------------------------------------------");
				randomClient = client;
			}
			else
			{
				Console.WriteLine("----------------Potential CLient Data------------------");
				Console.WriteLine("Exception : Potential CLient Data Not Genrated");
				Console.WriteLine("---------------------------------------------");
			}
		}
		private async Task ProcessCaseTransition(string token)
		{
			await IsLogedIn(token);
			Console.WriteLine("Process CLient Case");
		}

		private async Task IsLogedIn(string token)
		{
			if (!string.IsNullOrEmpty(token))
			{
				token = await ProcessLoginTransition(token);
				if (string.IsNullOrEmpty(token))
				{
					throw new ArgumentNullException("token");
				}
				Console.WriteLine("--------------User Already Loged In------------------");
			}
			else
			{
				throw new ArgumentNullException("token");
			}
		}
	}
}
