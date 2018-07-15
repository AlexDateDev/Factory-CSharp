using System.Diagnostics;

namespace Help.Systems
{

	public partial class HelperString
	{

		/// <summary>
		/// Devuelve le nombre del dominio de red asociado al usurio actual
		/// </summary>
		/// <returns></returns>
		public static string GetNameDomain( )
		{
			return System.Environment.UserDomainName;
		}



	}
}