using System;
using System.Linq;
using System.Web;
using System.IO;

namespace Help.FilesUploads
{
	public static class HelperFileUpload
	{
		/// <summary>
		/// Devuelve los bytes de un archivo. tambien devuevle su mimetype y tamaÃ±o
		/// </summary>
		/// <param name="file"></param>
		/// <returns></returns>
		public static byte[ ] GetBytes( HttpPostedFileBase file )
		{
			try {
				Stream fileStream = file.InputStream;
				int fileLength = file.ContentLength;
				byte[] fileData = new byte[ fileLength ];
				fileStream.Read( fileData, 0, fileLength );
				return fileData;

			} catch( Exception ex ) {
                throw ex;
			}
		}
	}
}