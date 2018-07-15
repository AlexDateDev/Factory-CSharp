//// ----------------------------------------------------------------------------
//// T�tulo:    CeckDNSMail
////
//// Fecha:     22/06/2016
//// Autor:    Alex Sol�
//// ----------------------------------------------------------------------------

//using System.Diagnostics;
///// <summary>
///// Comprueba si un DNS existe
///// </summary>
///// <param name="host"></param>
///// <param name="recType"></param>
///// <returns></returns>
//bool checkDNS( string host, string recType = "MX" )
//{
//    bool result = false;
//    try {
//        using( Process proc = new Process( ) ) {
//            proc.StartInfo.FileName = "nslookup";
//            proc.StartInfo.Arguments = string.Format( "-type={0} {1}", recType, host );
//            proc.StartInfo.CreateNoWindow = true;
//            proc.StartInfo.ErrorDialog = false;
//            proc.StartInfo.RedirectStandardError = true;
//            proc.StartInfo.RedirectStandardOutput = true;
//            proc.StartInfo.UseShellExecute = false;
//            proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
//            proc.OutputDataReceived += ( object sender, DataReceivedEventArgs e ) => {
//                    if( ( e.Data != null ) && ( !result ) )
//                        result = e.Data.StartsWith( host );
//                };
//            proc.ErrorDataReceived += ( object sender, DataReceivedEventArgs e ) => {
//                    if( e.Data != null ) {
//                        //read error output here, not sure what for?
//                    }
//                };
//            proc.Start( );
//            proc.BeginErrorReadLine( );
//            proc.BeginOutputReadLine( );
//            proc.WaitForExit( 30000 ); //timeout after 30 seconds.
//        }
//    } catch {
//        result = false;
//    }
//    return result;
//}
