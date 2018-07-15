using System.Diagnostics;

namespace Help.Systems
{

	public partial class HelperString
	{
		/// <summary>
		/// Devuelve la ruta completa al directorio del sistema
		/// </summary>
		/// <returns></returns>
		public static string GetNameSystemDirectory( )
		{
			return System.Environment.SystemDirectory;
		}


	}
}