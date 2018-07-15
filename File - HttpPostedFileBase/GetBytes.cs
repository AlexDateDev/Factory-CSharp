// ----------------------------------------------------------------------------
// Título:    GetBytes
//
// Fecha:     22/06/2016
// Autor:    Alex Solé
// ----------------------------------------------------------------------------

using System;
using System.Linq;
using System.Web;
using System.IO;

namespace Utils.FilesUploads
{
    public static class FactoryFileUpload
    {
        /// <summary>
        /// Devuelve los bytes de un archivo. tambien devuevle su mimetype y tamaÃƒÂ±o
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
