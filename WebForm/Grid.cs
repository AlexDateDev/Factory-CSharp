using System.Web.UI.WebControls;

namespace Help.WebForms
{
	public abstract class WFGrid : WFWebControl
	{

		/// <summary>
		/// Muestra o oculta una columna de un grid
		/// </summary>
		/// <param name="grid">GridView </param>
		/// <param name="Column">int</param>
		/// <param name="Visible">bool</param>
		public static void ShowColumn( GridView grid, int Column, bool Visible )
		{
			grid.Columns[ Column ].Visible = Visible;
		}

	}
}