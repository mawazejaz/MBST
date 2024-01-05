using Newtonsoft.Json;

namespace BaseLibrary.Wraper
{
	public class RandomUserWraper
	{
		string deffaultUser = @"{""results"":[{""gender"":""female"",""name"":{""title"":""Miss"",""first"":""Noémie"",""last"":""Harris""},""location"":{""street"":{""number"":3353,""name"":""Oak St""},""city"":""Georgetown"",""state"":""New Brunswick"",""country"":""Canada"",""postcode"":""G6R 8G7"",""coordinates"":{""latitude"":""-67.6478"",""longitude"":""105.6474""},""timezone"":{""offset"":""-2:00"",""description"":""Mid-Atlantic""}},""email"":""noemie.harris@example.com"",""login"":{""uuid"":""d6165a54-6865-4fbd-b6b7-1acf1535ed5e"",""username"":""heavybutterfly712"",""password"":""rachael"",""salt"":""Gzu9RZmz"",""md5"":""bf27c0ee05697079967b4310e44b0f9a"",""sha1"":""dd0fdaf41badf15fbb15e0f18a14a78983542d47"",""sha256"":""2c821a57d7a3d9e205dad3ca811f883c5d199661c9f34d1e460361d2e759296c""},""dob"":{""date"":""1987-04-10T18:53:12.296Z"",""age"":36},""registered"":{""date"":""2021-09-26T17:27:14.758Z"",""age"":2},""phone"":""J23 Y83-9536"",""cell"":""T59 R16-5417"",""id"":{""name"":""SIN"",""value"":""018363762""},""picture"":{""large"":""https://randomuser.me/api/portraits/women/11.jpg"",""medium"":""https://randomuser.me/api/portraits/med/women/11.jpg"",""thumbnail"":""https://randomuser.me/api/portraits/thumb/women/11.jpg""},""nat"":""CA""}],""info"":{""seed"":""a056ed30b6f075f7"",""results"":1,""page"":1,""version"":""1.4""}}";
		public async Task<RandomUserApiResponse> GetUserAsync()
		{
			try
			{
				using (HttpClient client = new HttpClient())
				{
					//string apiUrl = "https://randomuser.me/api/";
					//HttpResponseMessage response = await client.GetAsync(apiUrl);

					//if (response.IsSuccessStatusCode)
					//{
						//string jsonResponse = await response.Content.ReadAsStringAsync();
						// Deserialize the JSON response
						return JsonConvert.DeserializeObject<RandomUserApiResponse>(deffaultUser);
					//}
					//else
					//{
					//	return new RandomUserApiResponse();
					//}
				}
			}
			catch (Exception ex)
			{
				// Log or print the exception details for debugging
				Console.WriteLine(ex.ToString());
				return new RandomUserApiResponse(); // or throw an exception if appropriate
			}
		}

	}

	public class RandomUserApiResponse
	{
		public List<RandomUser> Results { get; set; }
		public Info Info { get; set; }
	}

	public class RandomUser
	{
		public string Gender { get; set; }
		public Name Name { get; set; }
		public Location Location { get; set; }
		public string Email { get; set; }
		public Login Login { get; set; }
		public Dob Dob { get; set; }
		public Registered Registered { get; set; }
		public string Phone { get; set; }
		public string Cell { get; set; }
		public Id Id { get; set; }
		public Picture Picture { get; set; }
		public string Nat { get; set; }
	}

	public class Name
	{
		public string Title { get; set; }
		public string First { get; set; }
		public string Last { get; set; }
	}

	public class Location
	{
		public Street Street { get; set; }
		public string City { get; set; }
		public string State { get; set; }
		public string Country { get; set; }
		public string Postcode { get; set; }
		public Coordinates Coordinates { get; set; }
		public Timezone Timezone { get; set; }
	}

	public class Street
	{
		public int Number { get; set; }
		public string Name { get; set; }
	}

	public class Coordinates
	{
		public string Latitude { get; set; }
		public string Longitude { get; set; }
	}

	public class Timezone
	{
		public string Offset { get; set; }
		public string Description { get; set; }
	}

	public class Login
	{
		public string Uuid { get; set; }
		public string Username { get; set; }
		public string Password { get; set; }
		public string Salt { get; set; }
		public string Md5 { get; set; }
		public string Sha1 { get; set; }
		public string Sha256 { get; set; }
	}

	public class Dob
	{
		public DateTime Date { get; set; }
		public int Age { get; set; }
	}

	public class Registered
	{
		public DateTime Date { get; set; }
		public int Age { get; set; }
	}

	public class Id
	{
		public string Name { get; set; }
		public string Value { get; set; }
	}

	public class Picture
	{
		public string Large { get; set; }
		public string Medium { get; set; }
		public string Thumbnail { get; set; }
	}

	public class Info
	{
		public string Seed { get; set; }
		public int Results { get; set; }
		public int Page { get; set; }
		public string Version { get; set; }
	}
}
