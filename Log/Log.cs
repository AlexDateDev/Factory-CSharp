using System;
using System.IO;
using System.Web;

namespace Help.Logs
{
	/// <summary>
	/// Log
	/// </summary>
	public class HelperLog
	{
		private string _Path = null;
		const string NL = "\r\n\r\n";

		public HelperLog( string Path )
		{
			this._Path = Path;
		}

		/// <summary>
		/// Guarda un mensage de texto de tarza numerada en el log
		/// </summary>
		/// <param name="NumTrace"></param>
		/// <param name="msg"></param>
		public void Save( int NumTrace, string msg )
		{
			msg = " [" + NumTrace.ToString( ).PadLeft( 4, '0' ) + "] " + msg;
			this._Save(  msg );
		}

		/// <summary>
		/// Guarda un mensage de texto en el log
		/// </summary>
		/// <param name="NumTrace"></param>
		/// <param name="msg"></param>
		public void Save( string msg )
		{
			this._Save( msg );
		}

		/// <summary>
		/// Guardamos una exception
		/// </summary>
		/// <param name="ex"></param>
		/// <param name="msg"></param>
		public void Save( string msg, Exception ex )
		{
			string str = "";
			str += "==> Exception: " + ex.Message + NL;
			str += "==> Funcion: " + ex.TargetSite.ToString( ) + NL;
			str += "==> StackTrace: " + ex.StackTrace + NL;
			str += this.VolcadoSession( );
			this._Save( str );
		}

		/// <summary>
		/// Volcado de todos los valores guardados en la sesión
		/// </summary>
		/// <returns></returns>
		private string VolcadoSession( )
		{
			string msg = "\r\n\r\n************* Inici volcat memòria ****************\r\n";

			foreach( var obj in HttpContext.Current.Session ) {
				string key = obj.ToString( );

				string val = "";
				switch( key ) {
					case "_UserRoles_":
						continue;
					default:
						if( null != HttpContext.Current.Session[ key ] ) {
							val = HttpContext.Current.Session[ key ].ToString( );
						} else {
							val = "null";
						}
						break;
				}

				msg += "\r\n[" + key + "]=" + val;
			}
			msg += "\r\n************* Fi volcat memòria ****************\r\n\r\n";
			return msg;
		}

		/// <summary>
		/// Guarda un mensage de texto al log de errores de un archivo concreto
		/// El nombre del archivo contiene el dia. Generandose un archivo por cada dia
		/// </summary>
		/// <param name="sPathName"></param>
		/// <param name="sErrMsg"></param>
		/// <exception cref="Exception"></exception>
		protected void _Save( string sErrMsg )
		{			
			System.DateTime dt = System.DateTime.Now;
			string sYear = dt.ToString( "yyyy" );
			string sMonth = dt.ToString( "MM" );
			string sDay = dt.ToString( "dd" );
			
			string sErrorTime =  "Log_" + sYear + "_" + sMonth + "_" + sDay;

			// Obtener todo lo de la session
			string date = DateTime.Now.ToShortDateString( ) + " " + DateTime.Now.ToShortTimeString( );

			string fileLog = this._Path + sErrorTime + ".txt";
			try {
				StreamWriter sw = new StreamWriter( fileLog, true );
				sw.WriteLine( date + ": " + sErrMsg );
				sw.Flush( );
				sw.Close( );
			} catch( Exception ex ) {
				throw new Exception( "Imposible guardar la traza (Log: Save): " +ex.Message, ex );
			}
		}
	}
}
