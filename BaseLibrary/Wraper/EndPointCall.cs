using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BaseLibrary.Wraper
{
	
	class EndPointCall
	{
		public async Task<string> CallEndPoint(string apiUrl, object payload)
		{

			//Set the URL
			//string apiUrl = "https://linuxapi-stage.ezymigrate.co.nz/v1/user/identity/AuthenticateUser";

			// Set the payload
			//var payload = new
			//{
			//	email = "nabeeloutsourcenz1@gmail.com",
			//	password = "Nabeel@123"
			//};

			// Convert payload to JSON string
			string jsonPayload = Newtonsoft.Json.JsonConvert.SerializeObject(payload);

			// Create an instance of HttpClient
			using (HttpClient client = new HttpClient())
			{
				// Set the Content-Type header on the StringContent object
				StringContent content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");

				// Send the POST request and get the response
				HttpResponseMessage response = await client.PostAsync(apiUrl, content);

				// Check if the response is successful (status code 200 OK)
				if (response.IsSuccessStatusCode)
				{
					// Read and display the response content
					return await response.Content.ReadAsStringAsync();
				}
				else
				{
					// Display error message if the request is not successful
					Console.WriteLine("Error: " + response.StatusCode + " - " + response.ReasonPhrase);
					return "";
				}
			}
		}
	}
}
