using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Web;


namespace Help.Files
{
	public partial class HelperReader
	{

		/// <summary>
		/// Devuelve el nombre completo del archivo
		/// </summary>
		/// <param name="FileUpload"></param>
		/// <returns></returns>
		public static string GetFullPath( HttpPostedFileBase FileUpload )
		{
			return Path.GetFileName( FileUpload.FileName );
			 
		}

	}
}
