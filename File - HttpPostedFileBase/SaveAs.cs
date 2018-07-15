using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Web;


namespace Help.Files
{
	public partial class HelperStreamReader
	{

		/// <summary>
		/// Guardar el archivo subido
		/// </summary>
		/// <param name="FileUpload"></param>
		/// <returns></returns>
		public static void SaveAs( HttpPostedFileBase FileUpload, string fullPathDest )
		{
			if( !System.IO.File.Exists( fullPathDest ) ) {
				FileUpload.SaveAs( fullPathDest );
			}
		}

	}
}
