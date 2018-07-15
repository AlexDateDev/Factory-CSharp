using System.Diagnostics;

namespace Help.Systems
{

	public partial class HelperString
	{

		/// <summary>
		/// Devuelve le nombre del usuario que ha iniciado la sesión
		/// </summary>
		/// <returns></returns>
		public static string GetNameUserSession( )
		{
			return System.Environment.UserName;
		}



	}
}