using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseLibrary.Wraper
{
	public static class ApisSettings
	{
		public static string baseUrl { get; } = "https://linuxapi-stage.ezymigrate.co.nz/";
		public static string versionUrl { get; } = "v1";
		public static string loginUrl { get; } = "/user/identity/AuthenticateUser";
	}
}
