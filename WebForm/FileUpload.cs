using System;
using System.Web.UI.WebControls;
using System.IO;

namespace Help.WebForms
{
	public abstract class WFFileUpload : WFWebControl
	{
		/// <summary>
		/// Devuelve el archivo como un array de bytes
		/// </summary>
		/// <param name="elem">FileUpload </param>
		/// <returns>byte[]</returns>
		public static byte[ ] GetArrayBytes( FileUpload elem )
		{
			try{
				BinaryReader reader = new BinaryReader( elem.PostedFile.InputStream );
				byte[] arrBytes = reader.ReadBytes( elem.PostedFile.ContentLength );
				return arrBytes;
			} catch( Exception ex ) {
				throw new Exception( "No se puede obtener el array de bytes del archivo (WFFileUpload: GetArrayBytes): " + ex.Message );
			}
		}

		/// <summary>
		/// Guardar el archivo en una ruta
		/// </summary>
		/// <param name="elem">FileUpload </param>
		/// <param name="PathFileName">string</param>
		/// <exception cref="ex">Exception</exception>
		public static void SaveAs( FileUpload elem, string PathFileName )
		{
			try {
				elem.PostedFile.SaveAs( PathFileName );
			} catch( Exception ex ) {
				throw new Exception( "No se ha podido guardar al archivo (WFFileUpload: SaveAs): " + ex.Message );
			}
		}

		/// <summary>
		/// Devuelve el nombre del archivo
		/// </summary>
		/// <param name="elem">FileUpload</param>
		/// <returns>string</returns>
		public static string GetFilename( FileUpload elem )
		{
			return elem.PostedFile.FileName;
		}

		/// <summary>
		/// Devuelve la extensión del archivo (en minúsculas)
		/// </summary>
		/// <param name="elem">FileUpload </param>
		/// <returns>string</returns>
		public static string GetExtension( FileUpload elem )
		{
			string ext = System.IO.Path.GetExtension( elem.PostedFile.FileName );
			return ext.ToLower( );
		}

		/// <summary>
		/// Devuelve true si es un archivo con extension determinada
		/// </summary>
		/// <param name="elem"></param>
		/// <returns></returns>
		public static bool IsExtension( FileUpload elem, string extension )
		{
			string ext = System.IO.Path.GetExtension( elem.PostedFile.FileName );
			return ext.ToLower( ) == "."+extension.ToLower();
		}

		/// <summary>
		/// Devuelve el ContentType del archivo
		/// </summary>
		/// <param name="elem">FileUpload</param>
		/// <returns>string</returns>
		public static string GetContentType( FileUpload elem )
		{
			return elem.PostedFile.ContentType;
		}
		/// <summary>
		/// Devuelve el tamaño del archivo
		/// </summary>
		/// <param name="elem">FileUpload</param>
		/// <returns>int</returns>
		public static int GetSize( FileUpload elem )
		{
			return elem.PostedFile.ContentLength;
		}

		/// <summary>
		/// Devuelve el Stream del archivo
		/// </summary>
		/// <param name="elem">FileUpload </param>
		/// <returns>Stream</returns>
		public static Stream GetStream( FileUpload elem )
		{
			return elem.PostedFile.InputStream;
		}


		/// <summary>
		/// Devuelve trus si un hay u n archivo seleccionado
		/// </summary>
		/// <param name="elem">FileUpload </param>
		/// <returns>bool</returns>
		public static bool IsEmpty( FileUpload elem )
		{
			return !elem.HasFile;
		}
	}
}