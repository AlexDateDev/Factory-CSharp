using System;
using System.Web.UI.WebControls;

namespace Help.WebForms
{
	public abstract class WFLabel : WFWebControl
	{
		#region GET
		/// <summary>
		/// Devuelve el valor de label como un int
		/// Si no se puede convertir a int => Exception
		/// </summary>
		/// <param name="label">label</param>
		/// <returns>int</returns>
		/// <exception cref="ex">Exception</exception>
		public static int? GetValueInt( Label label )
		{
			int i =0;
			if( Int32.TryParse( label.Text, out i ) ) {
				return i;
			}
			throw new Exception( "No se puede convertir el valor del Label en un int? (WFLabel: GetValueInt)");
		}

		/// <summary>
		/// Devuelve el valor de una Button
		/// </summary>
		/// <param name="inp">HyperLink</param>
		public static string GetValue( Label inp )
		{
			return inp.Text;
		}
	#endregion

	#region SET
		/// <summary>
		/// Asigna un valor int? a un label
		/// </summary>
		/// <param name="label">label</param>
		/// <returns>int</returns>
		public static void SetValueInt( Label label, int? value )
		{
			label.Text = value.HasValue ? Convert.ToString( value.Value ) : "";
		}

		/// <summary>
		/// Asigna un valor int a un Label
		/// </summary>
		/// <param name="label">Label</param>
		/// <param name="value">int</param>
		public static void SetValueInt( Label label, int value )
		{
			label.Text = Convert.ToString( value );
		}
		/// <summary>
		/// Asigna un valor string a un Button
		/// </summary>
		/// <param name="inp">HyperLink</param>
		/// <param name="value"></param>
		public static void SetValue( Label inp, string value )
		{
			inp.Text = value;
		}


	#endregion
		
		/// <summary>
		/// Afegeixa un valor string a un label
		/// </summary>
		/// <param name="label">Label</param>
		/// <param name="value">string</param>
		public static void AddValue( Label label, string value )
		{
			label.Text += value;
		}

		/// <summary>
		/// Elimina el valor de un Label
		/// </summary>
		/// <param name="label">Label</param>
		public static void Clear( Label label )
		{
			label.Text = null;
		}
	}
}