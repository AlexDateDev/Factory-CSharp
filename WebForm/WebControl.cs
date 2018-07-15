using System.Web.UI.WebControls;

namespace Help.WebForms
{
	public abstract class WFWebControl : WebControl
	{
		/// <summary>
		/// Asigna el texto Title del mouse al estar encima del WebControl
		/// </summary>
		/// <param name="inp">WebControl </param>
		/// <param name="value">string</param>
		public static void SetTitle( WebControl inp, string value )
		{
			inp.ToolTip = value.Trim();
		}

		/// <summary>
		/// Devuelve el texto Title del mouse al estar encima del WebControl
		/// </summary>
		/// <param name="inp">WebControl </param>
		/// <param name="value">string</param>
		/// <returns>strung</returns>
		public static string GetTitle( WebControl inp, string value )
		{
			return inp.ToolTip.Trim();
		}

		/// <summary>
		/// Indica si el WebControl es visible
		/// </summary>
		/// <param name="inp">WebControl </param>
		/// <returns>bool</returns>
		public static bool IsVisible( WebControl inp )
		{
			return inp.Visible;
		}

		/// <summary>
		/// Oculta/Visualiza el WebControl
		/// </summary>
		/// <param name="inp">WebControl </param>
		/// <param name="Visible">bool</param>
		public static void SetVisible( WebControl inp, bool Visible )
		{
			inp.Visible = Visible;
		}
			
			
			

		/// <summary>
		/// Devuele el ID del WebControl
		/// </summary>
		/// <param name="inp">WebControl </param>
		/// <returns>string</returns>
		public static string GetID( WebControl inp )
		{
			return inp.ID;
		}

		/// <summary>
		/// Asigna el ID al WebControl
		/// </summary>
		/// <param name="inp">WebControl </param>
		/// <param name="ID">string</param>
		public static void SetID( WebControl inp, string ID )
		{
			inp.ID = ID.Trim();
		}

		/// <summary>
		/// Asigna el ViewStateMode
		/// </summary>
		/// <param name="inp">WebControl</param>
		/// <param name="ViewStateMode"><bool/param>
		public static void SetEnableViewState( WebControl inp, bool EnableViewStateMode )
		{
			inp.EnableViewState = EnableViewStateMode;
		}

		/// <summary>
		/// Asigna el focus al WebControl
		/// </summary>
		/// <param name="elem">WebControl </param>
		public static void SetFocus( WebControl elem )
		{
			elem.Focus( );
		}

			/// <summary>
		/// Asigna la clase CSS al WebControl
		/// </summary>
		/// <param name="inp">WebControl</param>
		/// <param name="CssClass">string</param>
		public static void SetCssClass( WebControl inp, string CssClass )
		{
			inp.CssClass = CssClass.Trim();
		}

		/// <summary>
		/// Devuelve el nombre de la classe 
		/// </summary>
		/// <param name="inp">WebControl</param>
		/// <returns>string</returns>
		public static string GetCssClass( WebControl inp )
		{
			return inp.CssClass;
		}

		/// <summary>
		/// Indica si el WebControl esta activado o no
		/// </summary>
		/// <param name="inp">WebControl</param>
		/// <returns>bool</returns>
		public static bool IsEnabledControl( WebControl inp )
		{
			return inp.Enabled;
		}

		/// <summary>
		/// Activa/Desactiva el WebControl
		/// </summary>
		/// <param name="inp">WebControl</param>
		/// <param name="Enabled">bool</param>
		public static void SetEnabled( WebControl inp, bool Enabled )
		{
			inp.Enabled = Enabled;
		}
			
	}
}