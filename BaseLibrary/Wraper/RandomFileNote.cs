namespace BaseLibrary.Wraper
{
	public class RandomFileNote
	{
		public async Task<string> MakeRequest()
		{
			using (HttpClient client = new HttpClient())
			{
				string apiUrl = "https://randommer.io/api/Text/LoremIpsum?loremType=normal&type=paragraphs&number=10";
				client.DefaultRequestHeaders.Add("accept", "*/*");
				client.DefaultRequestHeaders.Add("X-Api-Key", "8054c536374e4ef0a76dfbbddfa483f4");

				HttpResponseMessage response = await client.GetAsync(apiUrl);

				if (response.IsSuccessStatusCode)
				{
					string responseData = await response.Content.ReadAsStringAsync();
					return responseData;
				}
				else
				{
					return $"Error: {response.StatusCode} - {response.ReasonPhrase}";
				}
			}
		}
	}
}
