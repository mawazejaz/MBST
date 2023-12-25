using System.Collections.ObjectModel;

namespace BaseLibrary.Wraper
{
	public class TimeZone
	{
		private List<string> ReturnTimeZones()
		{
			ReadOnlyCollection<TimeZoneInfo> timeZones = TimeZoneInfo.GetSystemTimeZones();
			List<string> time = new List<string>();
			foreach (TimeZoneInfo timeZone in timeZones)
			{
				time.Add(timeZone.DisplayName);
			}
			return time;
		}

	}
}
