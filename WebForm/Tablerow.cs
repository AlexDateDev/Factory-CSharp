using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI.HtmlControls;

namespace Help.WebForms
{
	public abstract class WFTablerow 
	{
		public static bool IsVisible( HtmlTableRow elem )
		{
		    return elem.Visible;
		}

		// <summary>
		/// Muestra u oculta un control
		/// </summary>
		/// <param name="label"></param>
		/// <param name="Visible"></param>
		public static void SetVisible( HtmlTableRow elem, bool Visible )
		{
		    elem.Visible = Visible;
		}
	}
}