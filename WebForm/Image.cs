using System.Web.UI.HtmlControls;

namespace Help.WebForms
{
	public abstract class WFImage : WFWebControl
	{
		/// <summary>
		/// Asigna el SRC de una imagen
		/// </summary>
		/// <param name="elem">HtmlImage</param>
		/// <param name="url">string</param>
		public static void SetSrc( HtmlImage elem, string url )
		{
			elem.Src = url;
		}

		/// <summary>
		/// Devuelve el SRC de una imagen
		/// </summary>
		/// <param name="elem">HtmlImage</param>
		/// <returns>string</returns>
		public static string GetSrc( HtmlImage elem )
		{
			return elem.Src;
		}
	}
}