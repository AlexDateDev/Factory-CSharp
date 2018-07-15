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
		/// Devuelve el StreamReader para leer
		/// </summary>
		/// <param name="FileUpload"></param>
		/// <returns></returns>
		public static StreamReader Open( HttpPostedFileBase FileUpload)
		{
			return new StreamReader( FileUpload.InputStream, System.Text.Encoding.Default );

		}

	}
}
