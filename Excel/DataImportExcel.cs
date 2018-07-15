// ----------------------------------------------------------------------------
// Título:    DataImportExcel
//
// Fecha:     26/06/2013
// Autor:    Alex Solé
// ----------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

    /// Control de importaciones
    /// Perimer paso: Leer todas las lineas, comprobando la validez de cada columna
    /// Segundo paso: Una vez todas las líneas leidas son corractas, realizar el volcado a la DB
    /// </summary>
    public class DataExcelImport
    {
        // Total de líneas leidas
        public int NumLinesReadTotal{ get; set; }

        // Total de líneas leidas sin error
        public int NumLinesReadTotalOk{ get; set; }

        // Total de leida leidas con error
        public int NumLinesReadTotalError{ get; set; }

        // Lista de los números de lineas del excel que estan ok
        public Dictionary<int, string> LinesReadOk { get; set; }

        // Lista de los números de lineas del excel que tienen error, con el error indicado
        public Dictionary<int, string> LinesReadError { get; set; }

        // Todas las lineas del CSV
        public Dictionary<int, string> LinesReadCSV { get; set; }

        // Estas líneas no se rellenan hasta que todas las lineas leidas son válidas
        // Contiene tanto las importaciones correcatas como incorrectas
        // Todas las lineas ya importadas
        public Dictionary<int, string> ImportLines { get; set; }

        // Total de lineas ya importadas
        public int ImportLinesTotal { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        public DataExcelImport( ) {
            this.LinesReadOk = new Dictionary<int, string>();
            this.LinesReadError = new Dictionary<int, string>();
            this.LinesReadCSV = new Dictionary<int, string>();

            this.ImportLines = new Dictionary<int, string>();

            this.NumLinesReadTotal = 0;
            this.NumLinesReadTotalError = 0;
            this.NumLinesReadTotalOk = 0;

            this.ImportLinesTotal = 0;
        }

        /// <summary>
        /// Añade el número de línea donde ha habido un error, el error y la línea CSV
        /// </summary>
        /// <param name="Line"></param>
        /// <param name="Error"></param>
        /// <param name="LineCSV"></param>
        public void addReadError( int Line, string Error, string LineCSV ){
            this.LinesReadError.Add(Line, Error);
            this.LinesReadCSV.Add(Line, LineCSV);
            this.NumLinesReadTotal = this.NumLinesReadTotal + 1;
            this.NumLinesReadTotalError = this.NumLinesReadTotalError + 1;
        }

        /// <summary>
        /// Añade el número de línea ok, un texto y la línea CSV
        /// </summary>
        /// <param name="Line"></param>
        /// <param name="Ok"></param>
        /// <param name="LineCSV"></param>
        public void addReadOk( int Line, string Ok, string LineCSV ) {
            this.LinesReadOk.Add(Line, Ok);
            this.LinesReadCSV.Add(Line, LineCSV);
            this.NumLinesReadTotal = this.NumLinesReadTotal + 1;
            this.NumLinesReadTotalOk = this.NumLinesReadTotalOk + 1;
        }

        /// <summary>
        /// Añade el número de línea y un texto en la realización de la importación correcta
        /// </summary>
        /// <param name="Line"></param>
        /// <param name="Ok"></param>
        public void addImportOk( int Line, string Ok ) {
            this.ImportLines.Add( Line, Ok);
            this.ImportLinesTotal = this.ImportLinesTotal + 1;
        }

        /// <summary>
        /// Añade el número de línea donde ha habido un error, el error en la realización de la importación
        /// </summary>
        /// <param name="Line"></param>
        /// <param name="Error"></param>
        public void addImportError( int Line, string Error ) {
            this.ImportLines.Add(Line, Error);
            this.ImportLinesTotal = this.ImportLinesTotal + 1;
        }
    }


