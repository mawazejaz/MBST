using BaseLibrary.Interface;
using BaseLibrary.Wraper;

namespace BaseLibrary.MBT
{
	public class AdressMBT : ICodeGenerator<AdressMBT, AdressModel>
	{
		private readonly AdressModel _data;

		public AdressMBT(Location add)
		{
			_data = new AdressModel();
			_data.Flat = RandomNumber.GenerateRandomNumber(3).ToString();
			_data.StreetNumber = add.Street.Number.ToString();
			_data.StreetName = add.Street.Name.ToString();
			_data.City = add.City;
			_data.State = add.State;
			_data.Country = 168;
		}

		public AdressModel CreateData()
		{
			return _data;
		}
	}

}