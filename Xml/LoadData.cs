// ----------------------------------------------------------------------------
// XmlParser
//
//
//
// Date : 02/01/2014
// By   : Type here your name or nickname.
// ----------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;

namespace Help.Xmls
{
	public abstract partial class HelperXml
	{
        /// <summary>
        /// Carga un archivo XML a un objeto C#
        /// El objeto se crear con el XSD mediante el comando xsd.exe /c file.xsd => genera un file.cs
        /// formado po un dataroot que contiene la colección el elementos leidos
        /// C:\Program Files (x86)\Microsoft SDKs\Windows\v8.0A\bin\NETFX 4.0 Tools\xsd.exe
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="filename"></param>
        /// <returns></returns>
        public static T LoadData<T>( string filename )
        {
            try {
                T result;
                XmlSerializer xmlSerializer = new XmlSerializer( typeof( T ) );
                FileStream fs = new FileStream( filename, FileMode.Open, FileAccess.Read, FileShare.Read );
                result = ( T ) xmlSerializer.Deserialize( fs );
                fs.Close( );
                return result;
            } catch( Exception ex ) {
                throw new Exception( "Imposible cargar xml: XmlParser LoadData", ex );
            }
        }

    }

}

