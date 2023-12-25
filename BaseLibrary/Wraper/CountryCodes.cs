using Newtonsoft.Json;

public class CountryModel
{
	public string CountryName { get; set; }
	public string CountryCode { get; set; }
	public string LangName { get; set; }
	public string CountryCodeName { get; set; }
	public string LangCode { get; set; }
}

public class CountryService
{
	private List<CountryModel> _countries;

	public CountryService()
	{
		string jsonFilePath = @"C:\Users\Mawaz\Desktop\MS\2nd Semester\SQA\Project 2\Code\MBST-Project\BaseLibrary\Data\countries.json";

		_countries = JsonConvert.DeserializeObject<List<CountryModel>>(jsonFilePath);
	}

	public List<CountryModel> GetAllCountries()
	{
		return _countries;
	}

	public CountryModel GetCountryByName(string countryName)
	{
		return _countries.FirstOrDefault(c => c.CountryName.Equals(countryName, StringComparison.OrdinalIgnoreCase));
	}

}
