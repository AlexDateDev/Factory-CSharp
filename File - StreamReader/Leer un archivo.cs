//// ----------------------------------------------------------------------------
//// Título:    Leer un archivo
//// Leermos un archivo de texto linea a linea hasta el final
////
//// Fecha:    15/01/2014
//// Autor:    Alex Solé
//// ----------------------------------------------------------------------------

//// ----------------------------------------------------------------------------
//// StreamReader - Leer archivo

//// Date :
//// ----------------------------------------------------------------------------

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.IO;

//// Leermos un archivo de texto linea a linea hasta el final
//namespace ImportZipCode
//{
//    class Program
//    {
//        static void Main( string[ ] args )
//        {
//            ZipCodeEntities dbContext = new ZipCodeEntities( );

//            string line;
//            StreamReader file = new StreamReader( @"C:\TFS\ImportZipCode\ImportZipCode\ZipCode.csv" );
//            while( ( line = file.ReadLine( ) ) != null ) {

//                string[] val = line.Split( ';' );

//                ZipCode zp = new ZipCode( );
//                zp.IdZipCode = 0;
//                zp.NombreProvincia = val[ 0 ];
//                zp.ZipCode1 = val[ 1 ];
//                zp.Ciudad = val[ 2 ];
//                zp.Calle = val[ 3 ];

//                dbContext.ZipCode.AddObject( zp );
//                dbContext.SaveChanges( );

//            }

//            file.Close( );
//        }


//    }
//}


