using System;
using System.Web.UI.HtmlControls;
using System.Web.UI;

namespace Help.WebForms
{
	public abstract class WFPage
	{
		/// <summary>
		/// Devuelve el control que ha realizado el PostBack
		/// </summary>
		/// <param name="page"></param>
		/// <returns></returns>
		public static Control GetPostBackControl( Page page )
		{
			Control control = null;
			string ctrlname = page.Request.Params.Get( "__EVENTTARGET" );
			if( ctrlname != null && ctrlname != String.Empty ) {
				control = page.FindControl( ctrlname );

			} else {
				foreach( string ctl in page.Request.Form ) {
					Control c = page.FindControl( ctl );
					if( c is System.Web.UI.WebControls.Button ) {
						control = c;
						break;
					}
				}

			}
			return control;
		}

		#region Meta
		/// <summary>
		/// Crea un meta para en una página
		/// </summary>
		/// <param name="label"></param>
		public static void SetMeta( Page page, string name, string value )
		{
			HtmlMeta metaTag = new HtmlMeta( );
			metaTag.Name = name;
			metaTag.Content = value;
			page.Header.Controls.Add( metaTag );
		}

		/// <summary>
		/// Crea un meta author para una página
		/// </summary>
		/// <param name="page"></param>
		/// <param name="value"></param>
		public static void SetMetaAuthor( Page page, string value )
		{
			HtmlMeta metaTag = new HtmlMeta( );
			metaTag.Name = "Author";
			metaTag.Content = value;
			page.Header.Controls.Add( metaTag );
		}

		/// <summary>
		/// Crea un meta Description para una página
		/// </summary>
		/// <param name="page"></param>
		/// <param name="value"></param>
		public static void SetMetaDescription( Page page, string value )
		{
			HtmlMeta metaTag = new HtmlMeta( );
			metaTag.Name = "Description";
			metaTag.Content = value;
			page.Header.Controls.Add( metaTag );
		}

		/// <summary>
		/// Crea un meta keywords para una página
		/// </summary>
		/// <param name="page"></param>
		/// <param name="value"></param>
		public static void SetMetaKeywords( Page page, string value )
		{
			HtmlMeta metaTag = new HtmlMeta( );
			metaTag.Name = "keywords";
			metaTag.Content = value;
			page.Header.Controls.Add( metaTag );
		}
		#endregion


	}
}