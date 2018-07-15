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
		///
		/// </summary>
		/// <param name="IClass"></param>
		/// <param name="filename"></param>
		public static void SaveData( object IClass, string filename )
		{
			StreamWriter writer = null;
			try {
				XmlSerializer xmlSerializer = new XmlSerializer( IClass.GetType( ) );
				writer = new StreamWriter( filename );
				xmlSerializer.Serialize( writer, IClass );
			} catch( Exception ex ) {
				throw new Exception( "Imposible guardar xml: XmlParser SaveData", ex );
			} finally {
				if( writer != null ) {
					writer.Close( );
				}

				writer = null;
			}
		}

    }

}

