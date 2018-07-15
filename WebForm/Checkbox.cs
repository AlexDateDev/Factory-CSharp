using System.Web.UI.WebControls;

namespace Help.WebForms
{
	public abstract class WFCheckbox : WFWebControl
	{
		/// <summary>
		/// Indica si el checkbox esta checado
		/// </summary>
		/// <param name="chk"></param>
		/// <returns></returns>
		public static bool IsCheck( CheckBox chk )
		{
			return chk.Checked;
		}

		/// <summary>
		/// Check para el checkbox. Un valor null no es check
		/// </summary>
		/// <param name="chk"></param>
		/// <param name="Check"></param>
		public static void SetCheck( CheckBox chk, bool? Check )
		{
			chk.Checked = Check.HasValue ? Check.Value : false;
		}

		/// <summary>
		/// Asigna un valor string a un CheckBox
		/// </summary>
		/// <param name="inp">HyperLink</param>
		/// <param name="value"></param>
		public static void SetValue( CheckBox inp, string value )
		{
			inp.Text = value;
		}

		/// <summary>
		/// Devuelve el valor de una CheckBox
		/// </summary>
		/// <param name="inp">HyperLink</param>
		public static string GetValue( CheckBox inp )
		{
			return inp.Text; ;
		}

	}
}
