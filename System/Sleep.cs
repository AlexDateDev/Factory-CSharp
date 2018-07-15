using System.Diagnostics;

namespace Help.Systems
{

	public partial class HelperString
	{

		/// <summary>
		/// Realiza una pausa de N milisegundos
		/// </summary>
		/// <param name="MilliSeconds"></param>
		public static void Sleep( int MilliSeconds )
		{
			System.Threading.Thread.Sleep( MilliSeconds );
		}

	}
}