//// ----------------------------------------------------------------------------
//// Título:    GetMXServers
////
//// Fecha:     22/06/2016
//// Autor:    Alex Solé
//// ----------------------------------------------------------------------------

///// <summary>
///// Devuelve una lista delos servidores de correo (MX) de un dominio
///// </summary>
///// <param name="domainName"></param>
///// <returns></returns>
//public List<string> GetMXServers(string domainName)
//{
//    string command = "nslookup -q=mx " + domainName;
//    ProcessStartInfo procStartInfo = new ProcessStartInfo("cmd", "/c " + command);

//    procStartInfo.RedirectStandardOutput = true;
//    procStartInfo.UseShellExecute = false;

//    procStartInfo.CreateNoWindow = true;

//    Process proc = new Process();
//    proc.StartInfo = procStartInfo;
//    proc.Start();
//    string result = proc.StandardOutput.ReadToEnd();

//    if (!string.IsNullOrEmpty(result))
//        result = result.Replace("\r\n", Environment.NewLine);

//    List<string> list = new List<string>();
//    foreach( string line in result.Split( new string[ ] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries ) ) {
//        if( line.Contains( "MX preference =" ) && line.Contains( "mail exchanger =" ) ) {
//            //MXServer mxServer = new MXServer();
//            //mxServer.Preference = Int(GetStringBetween(line, "MX preference = ", ","));
//            //mxServer.MailExchanger = GetStringFrom(line, "mail exchanger = ");

//            //list.Add(mxServer);
//            list.Add( line );
//        }
//    }
//    return list; //.OrderBy(m => m.Preference).ToList();
//}
