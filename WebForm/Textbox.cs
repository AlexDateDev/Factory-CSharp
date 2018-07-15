using System;
using System.Web.UI.WebControls;

namespace Help.WebForms
{
	public abstract class WFTextbox : WFWebControl
	{		
	#region GET
		/// <summary>
		/// Devuelve el valor de una TextBox como un string
		/// </summary>
		/// <param name="elem">TextBox</param>
		/// <returns></returns>
		public static string GetValue( TextBox elem )
		{
			elem.Text = elem.Text.Trim( );
			if( _IsEmpty( elem ) ) {
				return null;
			}
			return elem.Text;
		}

		/// <summary>
		/// Devuelve el valor int? del textBox. 
		/// Si el valor del textboc no se puede convertir a int => Exception
		/// </summary>
		/// <param name="elem">TextBox</param>
		/// <returns>int?</returns>
		/// <exception cref="ex">Exception</exception>
		public static int? GetValueInt( TextBox elem )
		{
			elem.Text = elem.Text.Trim( );
			if( _IsEmpty( elem ) ) {
				return null;
			}
			int i =0;
			if( Int32.TryParse( elem.Text, out i ) ) {
				return i;
			}
			throw new Exception( "Imposible devolver in int? en el TextBox (WFTextbox: GetValueInt)");
		}

		/// <summary>
		/// Devuelve el valor DateTime? del textBox
		/// Si el valor del textboc no se puede convertir a DateTime => Exception
		/// </summary>
		/// <param name="elem">TextBox</param>
		/// <returns>DateTime?</returns>
		/// <exception cref="ex">Exception</exception>
		public static DateTime? GetValueDateTime( TextBox elem )
		{
			elem.Text = elem.Text.Trim( );
			if( _IsEmpty( elem ) ) {
				return null;
			}

			System.DateTime dt;
			if( System.DateTime.TryParse( elem.Text, out dt ) ) {
				return dt;
			}
			throw new Exception( "Imposible devolver in DateTime? en el TextBox (AtxTextbob: GetValueDateTime)" );
		}

	#endregion

	#region SET
		/// <summary>
		/// Asigna un valor string a un TextBox
		/// </summary>
		/// <param name="inp">TextBox</param>
		/// <param name="value">string</param>
		public static void SetValue( TextBox inp, string value )
		{
			//inp.Text = value.Trim();
			inp.Text = ( null == value ? null : value.Trim( ) );
		}

		/// <summary>
		/// Asigna un valor int a un TextBox
		/// </summary>
		/// <param name="inp">TextBox</param>
		/// <param name="value">int</param>
		public static void SetValue( TextBox inp, int value )
		{
			inp.Text = value.ToString();
		}

		/// <summary>
		/// Asigna un valor short? a un TextBox
		/// </summary>
		/// <param name="inp">TextBox</param>
		/// <param name="value">short?</param>
		public static void SetValue( TextBox inp, short? value )
		{
			inp.Text = (null == value  ? null :value.ToString( ) );
		}

		/// <summary>
		/// Asigna un valor short a un TextBox
		/// </summary>
		/// <param name="inp">TextBox</param>
		/// <param name="value">short</param>
		public static void SetValue( TextBox inp, short value )
		{
			inp.Text = value.ToString( );
		}

		/// <summary>
		/// Asigna un valor byte? a un TextBox
		/// </summary>
		/// <param name="inp">TextBox</param>
		/// <param name="value">byte?</param>
		public static void SetValue( TextBox inp, byte? value )
		{
			inp.Text = ( null == value ? null : value.ToString( ) );
		}

		/// <summary>
		/// Asigna un valor byte a un TextBox
		/// </summary>
		/// <param name="inp">TextBox</param>
		/// <param name="value">byte</param>
		public static void SetValue( TextBox inp, byte value )
		{
			inp.Text = value.ToString( );
		}

		/// <summary>
		/// Asigna un valor int? a un TextBox
		/// </summary>
		/// <param name="inp">TextBox</param>
		/// <param name="value">int?</param>
		public static void SetValue( TextBox inp, int? value )
		{
			inp.Text = ( null == value ? null : value.ToString( ) );
		}
		/// <summary>
		/// Asigna un valor DateTime a un TextBox
		/// </summary>
		/// <param name="inp">TextBox</param>
		/// <param name="value">DateTime</param>
		/// <param name="IncludeTime">bool</param>
		public static void SetValue( TextBox inp, DateTime value, bool IncludeTime=false )
		{
			if( IncludeTime ) {
				inp.Text = value.ToShortDateString( );
			} else {
				inp.Text = value.ToShortDateString( ) + " " + value.ToShortTimeString();
			}
		}

		/// <summary>
		/// Asigna un valor DateTime? a un TextBox
		/// </summary>
		/// <param name="inp">TextBox</param>
		/// <param name="value">DateTime?</param>
		/// <param name="IncludeTime">bool</param>
		public static void SetValue( TextBox inp, DateTime? value, bool IncludeTime = false )
		{
			if( IncludeTime ) {
				inp.Text = ( null == value ? null : value.Value.ToShortDateString( ) + " " + value.Value.ToShortTimeString( ) );
			} else {
				inp.Text = ( null == value ? null : value.Value.ToShortDateString( ) );
			}
		}

	#endregion


		/// <summary>
		/// Elimina el valor de un textBox
		/// </summary>
		/// <param name="elem">TextBox</param>
		public static void Clear( TextBox elem )
		{
			elem.Text = null;
		}
		
		/// <summary>
		/// Asigna la máxima longitud a un canmpo Textbox
		/// </summary>
		/// <param name="inp">TextBox</param>
		/// <param name="maxLenght">int</param>
		public static void SetMaxLength( TextBox inp, int maxLenght )
		{
			inp.MaxLength = maxLenght;
		}

		/// <summary>
		/// Devuelve la máxima longitud a un campo Textbox
		/// </summary>
		/// <param name="inp"></param>
		public static int GetMaxLength( TextBox inp)
		{
			return inp.MaxLength ;
		}

		/// <summary>
		/// Hace que un Textbox es de solo lectura o no
		/// </summary>
		/// <param name="inp"></param>
		/// <param name="readOnly"></param>
		public static void SetReadOnly( TextBox inp, bool readOnly )
		{
			inp.ReadOnly = readOnly;
		}

		/// <summary>
		/// Indica si un Textbox es de solo lectura o no
		/// </summary>
		/// <param name="inp"></param>
		/// <returns></returns>
		public static bool IsReadOnly( TextBox inp  )
		{
			return inp.ReadOnly;
		}

		/// <summary>
		/// Indica si el input esta vacio
		/// </summary>
		/// <param name="elem"></param>
		/// <returns></returns>
		private static bool _IsEmpty( TextBox elem )
		{
			return ( ( null == elem.Text ) || ( 0 == elem.Text.Length ) || ( "" == elem.Text.Trim( ) ) );
		}
	}
}