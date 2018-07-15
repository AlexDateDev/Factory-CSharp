using System.Diagnostics;

namespace Help.Systems
{

	public partial class HelperString
	{
		public static void EjecutarBat( string pathArchivoBat )
		{
			Process proceso = new Process();  
			proceso.StartInfo.FileName = pathArchivoBat;  
			proceso.Start();  
			proceso.WaitForExit(); //Espera a que termine la ejecución del archivo .bat  
		}
	}
}