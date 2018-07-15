using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace Help.WebForms
{
	public abstract class WFLink : WFWebControl
	{
	#region HtmlLink

		/// <summary>
		/// Assigna una URL a un HyperLink 
		/// </summary>
		/// <param name="elem">HtmlLink</param>
		/// <param name="url">string</param>
		public static void SetUrl( HtmlLink elem, string url )
		{
			elem.Href = url;
		}


		/// <summary>
		/// Devuelve la url de un HyperLink
		/// </summary>
		/// <param name="elem">HtmlLink</param>
		/// <returns>string</returns>
		public static string GetUrl( HtmlLink elem )
		{
			return elem.Href;
		}

	#endregion

	#region HtmlAnchor

		/// <summary>
		/// Assigna una URL a un HtmlAnchor <a href=""></a>
		/// </summary>
		/// <param name="elem">HtmlAnchor</param>
		/// <param name="url">string</param>
		public static void SetUrl( HtmlAnchor elem, string url )
		{
			elem.HRef = url;
		}


		/// <summary>
		/// Devuelve la URL del link
		/// </summary>
		/// <param name="elem">HtmlAnchor</param>
		/// <returns>string</returns>
		public static string GetUrl( HtmlAnchor elem )
		{
			return elem.HRef;
		}

		/// <summary>
		/// Asigna la ventana donde se abrirá el link
		/// </summary>
		/// <param name="inp">HtmlAnchor </param>
		/// <param name="value">sring</param>
		public static void SetTarget( HtmlAnchor inp, string value )
		{
			inp.Target = value;
		}

		/// <summary>
		/// Devuelve la ventana donde se abrirá el link
		/// </summary>
		/// <param name="inp">HtmlAnchor </param>
		/// <returns>sring/returns>
		public static string GetTarget( HtmlAnchor inp )
		{
			return inp.Target;
		}

	#endregion

	#region HyperLink

		/// <summary>
		/// Assigna una URL a un HyperLink 
		/// </summary>
		/// <param name="elem">HyperLink</param>
		/// <param name="url">string</param>
		public static void SetUrl( HyperLink elem, string url )
		{
			elem.NavigateUrl = url;
		}


		/// <summary>
		/// Devuelve la url de un HyperLink
		/// </summary>
		/// <param name="elem">HyperLink</param>
		/// <returns>string</returns>
		public static string GetUrl( HyperLink elem )
		{
			return elem.NavigateUrl;
		}

		/// <summary>
		/// Asigna un valor string a un HyperLink
		/// </summary>
		/// <param name="inp">HyperLink</param>
		/// <param name="value">string</param>
		public static void SetValue( HyperLink inp, string value )
		{
			inp.Text = value;
		}

		/// <summary>
		/// Devuelve el valor de una HyperLink
		/// </summary>
		/// <param name="inp">HyperLink</param>
		/// <returns>string</returns>
		public static string GetValue( HyperLink inp )
		{
			return inp.Text; ;
		}

		/// <summary>
		/// Asigna la ventana donde se abrirá el link
		/// </summary>
		/// <param name="inp">HyperLink</param>
		/// <param name="value">string</param>
		public static void SetTarget( HyperLink inp, string value )
		{
			inp.Target = value;
		}

		/// <summary>
		/// Devuelve la ventana donde se abrirá el link
		/// </summary>
		/// <param name="inp">HyperLink </param>
		/// <returns>string</returns>
		public static string GetTarget( HyperLink inp )
		{
			return inp.Target;
		}

	#endregion

	}
}