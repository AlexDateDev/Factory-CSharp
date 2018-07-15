using Help.Validates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using Utils.Strings;

namespace Help.WebSessions
{
	public partial class HelperWebSession
	{

		/// <summary>
		/// Asigna un valor string a una variable guardada en la sesion
		/// </summary>
		/// <param name="key"></param>
		/// <param name="value"></param>
		public static void SetValue( string key, string value )
		{
			if( HelperValidate.IsEmpty( key ) ) {
				throw new NullReferenceException( "Clave no especificada (FactortWebSession: SetValue)" );
			}
			if( null == HttpContext.Current || null == HttpContext.Current.Session  ) {
				throw new Exception( "No existe HttpContext (FactoryWebSession: SetValue)" );
			}
			HttpContext.Current.Session[ key ] = value;
		}

		/// <summary>
		/// Asigna un valor int? a una variable guardada en la sesion
		/// </summary>
		/// <param name="key"></param>
		/// <param name="value"></param>
		public static void SetValue( string key, int? value )
		{
			try{
				if( value.HasValue ) {
					SetValue( key, Convert.ToString( value.Value ) );
				} else {
					HttpContext.Current.Session[ key ] = "Elemento int vacío";
				}
			} catch( Exception ex ) {
				throw ex;
			}
		}

		/// <summary>
		/// Asigna un valor int a una variable guardada en la sesion
		/// </summary>
		/// <param name="key"></param>
		/// <param name="value"></param>
		public static void SetValue( string key, int value )
		{
			try{
				SetValue( key, Convert.ToString( value ));
			}catch( Exception ex ){
				throw ex;
			}
		}
		/// <summary>
		/// Asigna un valor DateTime? una variable guardada en la sesion
		/// </summary>
		/// <param name="key"></param>
		/// <param name="value"></param>
		public static void SetValue( string key, DateTime? value )
		{
			try {
				if( value.HasValue ) {
					SetValue( key, Convert.ToString( value.Value ) );
				} else {
					HttpContext.Current.Session[ key ] = "Elemento datetime vacío";
				}
			} catch( Exception ex ) {
				throw ex;
			}
		}

		/// <summary>
		/// Asigna un valor DateTime una variable guardada en la sesion
		/// </summary>
		/// <param name="key"></param>
		/// <param name="value"></param>
		public static void SetValue( string key, DateTime value )
		{
			try {
				SetValue( key, Convert.ToString( value ) );
			} catch( Exception ex ) {
				throw ex;
			}
		}

		/// <summary>
		/// Asigna un valor bool? a una variable guardada en la sesion
		/// </summary>
		/// <param name="key"></param>
		/// <param name="value"></param>
		public static void SetValue( string key, bool? value )
		{
			try {
				if( value.HasValue ) {
					SetValue( key, Convert.ToString( value.Value ) );
				} else {
					HttpContext.Current.Session[ key ] = "Elemento bool vacío";
				}
			} catch( Exception ex ) {
				throw ex;
			}			
		}

		/// <summary>
		/// Asigna un valor bool a una variable guardada en la sesion
		/// </summary>
		/// <param name="key"></param>
		/// <param name="value"></param>
		public static void SetValue( string key, bool value )
		{
			try {
				SetValue( key, Convert.ToString( value ) );
			} catch( Exception ex ) {
				throw ex;
			}
		}

		/// <summary>
		/// Asigna un valor short? a una variable guardada en la sesion
		/// </summary>
		/// <param name="key"></param>
		/// <param name="value"></param>
		public static void SetValue( string key, short? value )
		{
			try {
				if( value.HasValue ) {
					SetValue( key, Convert.ToString( value.Value ) );
				} else {
					HttpContext.Current.Session[ key ] = "Elemento short vacío";
				}
			} catch( Exception ex ) {
				throw ex;
			}
		}

		/// <summary>
		/// Asigna un valor short a una variable guardada en la sesion
		/// </summary>
		/// <param name="key"></param>
		/// <param name="value"></param>
		public static void SetValue( string key, short value )
		{
			try {
				SetValue( key, Convert.ToString( value ) );
			} catch( Exception ex ) {
				throw ex;
			}
		}
		/// <summary>
		/// Asigna un valor byte? a una variable guardada en la sesion
		/// </summary>
		/// <param name="key"></param>
		/// <param name="value"></param>
		public static void SetValue( string key, byte? value )
		{
			try {
				if( value.HasValue ) {
					SetValue( key, Convert.ToString( value.Value ) );
				} else {
					HttpContext.Current.Session[ key ] = "Elemento byte vacío";
				}
			} catch( Exception ex ) {
				throw ex;
			}
		}

		/// <summary>
		/// Asigna un valor byte a una variable guardada en la sesion
		/// </summary>
		/// <param name="key"></param>
		/// <param name="value"></param>
		public static void SetValue( string key, byte value )
		{
			try {
				SetValue( key, Convert.ToString( value ) );
			} catch( Exception ex ) {
				throw ex;
			}
		}
	}
}
