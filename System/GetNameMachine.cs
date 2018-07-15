using System.Diagnostics;

namespace Help.Systems
{

	public partial class HelperString
	{
		/// <summary>
		/// Devuelve el nombre NetBIOS de la máquina
		/// </summary>
		/// <returns></returns>
		public static string GetNameMachine( )
		{
			return System.Environment.MachineName;
		}



	}
}