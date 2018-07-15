using System.Web.UI.WebControls;

namespace Help.WebForms
{
	public abstract class WFButton : WFWebControl
	{
		/// <summary>
		/// Asigna la URl del button
		/// </summary>
		/// <param name="elem">Button</param>
		/// <param name="url">string</param>
		public static void SetUrl( Button elem, string url )
		{
			elem.PostBackUrl = url;
		}

		/// <summary>
		/// Devuelve la url de un Button
		/// </summary>
		/// <param name="elem">Button</param>
		/// <returns>string</returns>
		public static string GetUrl( Button elem )
		{
			return elem.PostBackUrl;
		}
		/// <summary>
		/// Asigna un valor string a un Button
		/// </summary>
		/// <param name="inp">Button</param>
		/// <param name="value">string</param>
		public static void SetValue( Button inp, string value )
		{
			inp.Text = value;
		}

		/// <summary>
		/// Devuelve el valor de una Button
		/// </summary>
		/// <param name="inp">HyperLink</param>
		public static string GetValue( Button inp )
		{
			return inp.Text; ;
		}
	}
}
