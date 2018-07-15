
using System.Web.UI.WebControls;
namespace Help.WebForms
{
	public abstract class WFPlaceholder // No es un WebControl
	{

		/// <summary>
		/// Indica si el WebControl es visible
		/// </summary>
		/// <param name="inp">WebControl </param>
		/// <returns>bool</returns>
		public static bool IsVisible( PlaceHolder inp )
		{
			return inp.Visible;
		}

		/// <summary>
		/// Oculta/Visualiza el WebControl
		/// </summary>
		/// <param name="inp">WebControl </param>
		/// <param name="Visible">bool</param>
		public static void SetVisible( PlaceHolder inp, bool Visible )
		{
			inp.Visible = Visible;
		}
			
	}
}