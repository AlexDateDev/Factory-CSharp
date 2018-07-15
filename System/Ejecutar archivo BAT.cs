// ----------------------------------------------------------------------------
// T�tulo:    Ejecutar archivo BAT
//
// Fecha:     01/07/2016
// Autor:    Alex Sol�
// ----------------------------------------------------------------------------

using System.Diagnostics;

namespace Utils.Systems
{

    public partial class FactorySystem
    {
        public static void EjecutarBat( string pathArchivoBat )
        {
            Process proceso = new Process();
            proceso.StartInfo.FileName = pathArchivoBat;
            proceso.Start();
            proceso.WaitForExit(); //Espera a que termine la ejecución del archivo .bat
        }
    }
}
