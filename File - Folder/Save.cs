//// ----------------------------------------------------------------------------
//// Título:    Save
////
//// Fecha:    19/01/2015
//// Autor:    Alex Solé
//// ----------------------------------------------------------------------------


//     string Save( string sErrMsg )
//        {
//            const string NL = "\r\n\r\n";
//            const string sep = "------------------------------------------------------------------------------------------------------";

//            string str = NL + sep + NL + "==> ";
//            string sLogFormat = str + DateTime.Now.ToString( "dd/MM/yyyy HH:mm" ) + NL;
//            System.DateTime dt = System.DateTime.Now;
//            string sYear = dt.ToString( "yyyy" );
//            string sMonth = dt.ToString( "MM" );
//            string sDay = dt.ToString( "dd" );
//            string sErrorTime = "_" + sYear + "_" + sMonth + "_" + sDay;

//            string result = sLogFormat + sErrMsg;

//            // Obtener todo lo de la session
//            string fileLog = "MailError_" + sErrorTime + ".txt";
//            try {

//                string codeBase = System.Reflection.Assembly.GetExecutingAssembly().CodeBase;
//                UriBuilder uri = new UriBuilder(codeBase);
//                string pathFile = Uri.UnescapeDataString(uri.Path);
//                string pathOnly = Path.GetDirectoryName( pathFile ); // Directorio bin (donde esta la DLL de la aplicaión)

//                fileLog = pathOnly+ "\\..\\Logs\\" + fileLog;

//                StreamWriter sw = new StreamWriter( fileLog, true );
//                sw.WriteLine( sLogFormat + sErrMsg );
//                sw.Flush( );
//                sw.Close( );
//            } catch( Exception ex ) {
//                throw new Exception( "Imposible guardar la traza (FactoryEmail: Save): " + ex.Message );
//            }

//            return result;
//        }
