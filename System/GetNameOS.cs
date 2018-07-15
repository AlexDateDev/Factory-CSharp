using System.Diagnostics;

namespace Help.Systems
{

	public partial class HelperString
	{
		/// <summary>
		/// Devuelve el identificador de la plataforma y el número de versión
		/// </summary>
		/// <returns></returns>
		public static string GetNameOS( )
		{
			return System.Environment.OSVersion.ToString( );
		}


	}
}