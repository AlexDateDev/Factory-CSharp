using Help.Validates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using Help.Strings;

namespace Help.WebSessions
{
	public partial class HelperWebSession
	{
		/// <summary>
		/// Devuelve un valor (string) de una propiedad guardada en al session.
		/// </summary>
		/// <param name="key"></param>
		/// <exception cref="ex"></exception>
		/// <returns></returns>
		protected static string GetValueStr( string key )
		{
			if( string.IsNullOrWhiteSpace( key ) ) {
				throw new NullReferenceException( "Clave no especificada (FactortWebSession: GetValue)" );
			}
			if( null == HttpContext.Current || null == HttpContext.Current.Session || null == HttpContext.Current.Session[ key ] ) {
				throw new Exception( "No existe valor string de (" + key + ") en la session" );
			}
			return Convert.ToString( HttpContext.Current.Session[ key ] );
		}

		/// <summary>
		/// Devuelve un valor (int) de una propiedad guardada en al session
		/// </summary>
		/// <param name="key"></param>
		/// <exception cref="ex"></exception>
		/// <returns></returns>
		protected static int GetValueInt( string key )
		{
			if( HelperValidate.IsEmpty( key ) ) {
				throw new NullReferenceException( "Clave no especificada (FactortWebSession: GetValue)" );
			}

			if( null == HttpContext.Current || null == HttpContext.Current.Session || null == HttpContext.Current.Session[ key ] ) {
				throw new Exception( "No existe valor int de (" + key + ") en la session" );
			}
			return HelperString.ToInt( Convert.ToString( HttpContext.Current.Session[ key ]));
		}

		/// <summary>
		/// Devuelve un valor (short) de una propiedad guardada en al session
		/// </summary>
		/// <param name="key"></param>
		/// <exception cref="ex"></exception>
		/// <returns></returns>
		protected static short GetValueShort( string key )
		{
			if( string.IsNullOrWhiteSpace( key ) ) {
				throw new NullReferenceException( "Clave no especificada (FactortWebSession: GetValue)" );
			}

			if( null == HttpContext.Current || null == HttpContext.Current.Session || null == HttpContext.Current.Session[ key ] ) {
				throw new Exception( "No existe valor short de (" + key + ") en la session" );
			}
			return HelperString.ToShort( Convert.ToString( HttpContext.Current.Session[ key ] ) );
		}

		/// <summary>
		/// Devuelve un valor (short) de una propiedad guardada en al session
		/// </summary>
		/// <param name="key"></param>
		/// <exception cref="ex"></exception>
		/// <returns></returns>
		protected static byte GetValueByte( string key )
		{
			if( HelperValidate.IsEmpty( key ) ) {
				throw new NullReferenceException( "Clave no especificada (FactortWebSession: GetValue)" );
			}

			if( null == HttpContext.Current || null == HttpContext.Current.Session || null == HttpContext.Current.Session[ key ] ) {
				throw new Exception( "No existe valor Byte de (" + key + ") en la session" );
			}
			return HelperString.ToByte( Convert.ToString( HttpContext.Current.Session[ key ] ) );
		}

		/// <summary>
		/// Devuelve un valor (short) de una propiedad guardada en al session
		/// </summary>
		/// <param name="key"></param>
		/// <exception cref="ex"></exception>
		/// <returns></returns>
		protected static DateTime GetValueDateTime( string key )
		{
			if( HelperValidate.IsEmpty( key ) ) {
				throw new NullReferenceException( "Clave no especificada (FactortWebSession: GetValue)" );
			}

			if( null == HttpContext.Current || null == HttpContext.Current.Session || null == HttpContext.Current.Session[ key ] ) {
				throw new Exception( "No existe valor DateTime de (" + key + ") en la session" );
			}
			string sDate = Convert.ToString( HttpContext.Current.Session[ key ] );
			DateTime dt;
			if( System.DateTime.TryParse( sDate, out dt ) ) {
				return dt;
			}
			throw new Exception( "Valor DateTime erróneo en la session" );
		}
	}
}
