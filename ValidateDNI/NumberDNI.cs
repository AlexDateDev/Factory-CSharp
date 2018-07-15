// ----------------------------------------------------------------------------
// NumberDNI
//
// Representa un n�mero DNI (NIF o NIE) (Persona) o un CIF (Empresa)
//
// Date : 01/03/2013
// By   : Alex
// ----------------------------------------------------------------------------

using System;
using System.Net;
using System.Text.RegularExpressions;

namespace Help.ValidatesDni
{
	/// <summary>
	/// Representa un n�mero DNI (NIF o NIE) (Persona) o un CIF (Empresa)
	/// encontrar
	/// </summary>
	public class NumberDNI
	{

		#region Private Member

		/// <summary>
		/// Tipos de C�digos.
		/// </summary>
		/// <remarks>Aunque actualmente no se utilice el t�rmino CIF, se usa en la enumeraci�n
		/// por comodidad</remarks>
		private enum TypeNumber { NIF, NIE, CIF }

		// N�mero tal cual lo introduce el usuario
		private string numero;
		private TypeNumber tipo;

		/// <summary>
		/// Parte de Nif: En caso de ser un Nif intracomunitario, permite obtener el c�gido del pa�s
		/// </summary>
		public string CodigoIntracomunitario { get; internal set; }
		internal bool EsIntraComunitario { get; set; }
		#endregion

		#region Public Member

		/// <summary>
		/// Parte de Nif: Letra inicial del Nif, en caso de tenerla
		/// </summary>
		public string Letter { get; internal set; }

		/// <summary>
		/// Parte de Nif: Bloque num�rico del NIF. En el caso de un NIF de persona f�sica,
		/// corresponder� al DNI
		/// </summary>
		public int Number { get; internal set; }

		/// <summary>
		/// Parte de Nif: D�gito de control. Puede ser n�mero o letra
		/// </summary>
		public string DigitControl { get; internal set; }

		/// <summary>
		/// Valor que representa si el Nif introducido es correcto
		/// </summary>
		public bool IsValid { get; internal set; }

		/// <summary>
		/// Cadena que representa el tipo de Nif comprobado:
		///     - NIF : N�mero de identificaci�n fiscal de persona f�sica
		///     - NIE : N�mero de identificaci�n fiscal extranjer�a
		///     - CIF : C�digo de identificaci�n fiscal (Entidad jur�dica)
		/// </summary>
		public string TypeDNI { get { return tipo.ToString( ); } }

		#endregion

		/// <summary>
		/// Constructor. Al instanciar la clase se realizan todos los c�lculos
		/// </summary>
		/// <param name="numero">Cadena de 9 u 11 caracteres que contiene el DNI/NIF
		/// tal cual lo ha introducido el usuario para su verificaci�n</param>
		public NumberDNI( string numero )
		{
			if( null == numero ) {
				return;
			}
			// Se eliminan los car�cteres sobrantes
			numero = EliminaCaracteres( numero );

			// Todo en ma�usculas
			numero = numero.ToUpper( );

			// Comprobaci�n b�sica de la cadena introducida por el usuario
			if( numero.Length != 9 && numero.Length != 11 ) {
				this.IsValid = false;
			} else {
				this.numero = numero;
				Desglosa( );

				switch( tipo ) {
					case TypeNumber.NIE:
						this.IsValid = this.IsNIE( );
						break;
					case TypeNumber.NIF:
						this.IsValid = this.IsNIF( );
						break;
					case TypeNumber.CIF:
						this.IsValid = this.IsCIF( );
						break;
					default:
						this.IsValid = false;
						break;
				}
			}
		}

		#region Preparaci�n del n�mero (desglose)

		/// <summary>
		/// Para comprobar el NIE se sustituye la letra X por 0, Y por 1 y Z = 2 y se calcula como un CIF
		/// </summary>
		/// <returns></returns>
		private bool IsNIE( )
		{
			char primeraLetra = numero[ 0 ];

			string primeraletraConcat;
			if( primeraLetra == 'X' ) {
				primeraletraConcat = "0";
			} else if( primeraLetra == 'Y' ) {
				primeraletraConcat = "1";
			} else if( primeraLetra == 'Z' ) {
				primeraletraConcat = "2";
			} else {
				primeraletraConcat = "";
			}
			string sNum =  numero.Substring( 1, numero.Length - 2 );
			string sUltima = numero.Substring( numero.Length - 1, 1 );
			sNum = primeraletraConcat + sNum;
			Number = Convert.ToInt32( sNum );
			numero = sNum + sUltima;
			this.IsValid = IsNIF( );
			return this.IsValid;
		}

		/// <summary>
		/// Realiza un desglose del n�mero introducido por el usuario en las propiedades
		/// de la clase
		/// </summary>
		private void Desglosa( )
		{
			Int32 n;
			if( numero.Length == 11 ) {
				// Nif Intracomunitario
				EsIntraComunitario = true;
				CodigoIntracomunitario = numero.Substring( 0, 2 );
				Letter = numero.Substring( 2, 1 );
				Int32.TryParse( numero.Substring( 3, 7 ), out n );
				DigitControl = numero.Substring( 10, 1 );
				tipo = GetTipoDocumento( Letter[ 0 ] );
			} else {
				// Nif espa�ol
				tipo = GetTipoDocumento( numero[ 0 ] );
				EsIntraComunitario = false;
				if( tipo == TypeNumber.NIF ) {
					Letter = string.Empty;
					Int32.TryParse( numero.Substring( 0, 8 ), out n );
				} else {
					Letter = numero.Substring( 0, 1 );
					Int32.TryParse( numero.Substring( 1, 7 ), out  n );
				}
				DigitControl = numero.Substring( 8, 1 );
			}
			Number = n;
		}

		/// <summary>
		/// En base al primer car�cter del c�digo, se obtiene el tipo de documento que se intenta
		/// comprobar
		/// </summary>
		/// <param name="letra">Primer car�cter del n�mero pasado</param>
		/// <returns>Tipo de documento</returns>
		private TypeNumber GetTipoDocumento( char letra )
		{
			Regex regexNumeros = new Regex( "[0-9]" );
			if( regexNumeros.IsMatch( letra.ToString( ) ) ) {
				return TypeNumber.NIF;
			}

			Regex regexLetrasNIE = new Regex( "[XYZ]" );
			if( regexLetrasNIE.IsMatch( letra.ToString( ) ) ) {
				return TypeNumber.NIE;
			}

			Regex regexLetrasCIF = new Regex( "[ABCDEFGHJPQRSUVNW]" );
			if( regexLetrasCIF.IsMatch( letra.ToString( ) ) ) {
				return TypeNumber.CIF;
			}

			throw new Exception( );
		}

		/// <summary>
		/// Eliminaci�n de todos los car�cteres no num�ricos o de texto de la cadena
		/// </summary>
		/// <param name="numero">N�mero tal cual lo escribe el usuario</param>
		/// <returns>Cadena de 9 u 11 car�cteres sin signos</returns>
		private string EliminaCaracteres( string numero )
		{
			if( null == numero ) {
				return numero;
			}
			// Todos los car�cteres que no sean n�meros o letras
			string caracteres = @"[^\w]";
			Regex regex = new Regex( caracteres );
			return regex.Replace( numero, "" );
		}

		#endregion

		#region C�lculos

		/// <summary>
		/// C�lculos para la comprobaci�n del Nif
		/// </summary>
		/// <returns></returns>
		private bool IsNIF( )
		{
			return DigitControl == GetLetraNif( );
		}

		/// <summary>
		/// C�lculos para la comprobaci�n del Cif (Entidad jur�dica)
		/// </summary>
		private bool IsCIF( )
		{
			string[] letrasCodigo = { "J", "A", "B", "C", "D", "E", "F", "G", "H", "I" };

			string n = Number.ToString( "0000000" );
			Int32 sumaPares = 0;
			Int32 sumaImpares = 0;
			Int32 sumaTotal = 0;
			Int32 i = 0;
			bool retVal = false;

			// Recorrido por todos los d�gitos del n�mero
			for( i = 0; i < n.Length; i++ ) {
				Int32 aux;
				Int32.TryParse( n[ i ].ToString( ), out aux );

				if( ( i + 1 ) % 2 == 0 ) {
					// Si es una posici�n par, se suman los d�gitos
					sumaPares += aux;
				} else {
					// Si es una posici�n impar, se multiplican los d�gitos por 2
					aux = aux * 2;

					// se suman los d�gitos de la suma
					sumaImpares += SumaDigitos( aux );
				}
			}
			// Se suman los resultados de los n�meros pares e impares
			sumaTotal += sumaPares + sumaImpares;

			// Se obtiene el d�gito de las unidades
			Int32 unidades = sumaTotal % 10;

			// Si las unidades son distintas de 0, se restan de 10
			if( unidades != 0 ) {
				unidades = 10 - unidades;
			}

			switch( Letter ) {
				// S�lo n�meros
				case "A":
				case "B":
				case "E":
				case "H":
					retVal = DigitControl == unidades.ToString( );
					break;

				// S�lo letras
				case "K":
				case "P":
				case "Q":
				case "S":
					retVal = DigitControl == letrasCodigo[ unidades ];
					break;

				default:
					retVal = ( DigitControl == unidades.ToString( ) )
							|| ( DigitControl == letrasCodigo[ unidades ] );
					break;
			}
			return retVal;
		}

		/// <summary>
		/// Obtiene la suma de todos los d�gitos
		/// </summary>
		/// <returns>de 23, devuelve la suma de 2 + 3</returns>
		private Int32 SumaDigitos( Int32 digitos )
		{
			string sNumero = digitos.ToString( );
			Int32 suma = 0;

			for( Int32 i = 0; i < sNumero.Length; i++ ) {
				Int32 aux;
				Int32.TryParse( sNumero[ i ].ToString( ), out aux );
				suma += aux;
			}
			return suma;
		}

		/// <summary>
		/// Obtiene la letra correspondiente al Dni
		/// </summary>
		private string GetLetraNif( )
		{
			int indice = Number % 23;
			return "TRWAGMYFPDXBNJZSQVHLCKET"[ indice ].ToString( );
		}

		/// <summary>
		/// Obtiene una cadena con el n�mero de identificaci�n completo
		/// </summary>
		public override string ToString( )
		{
			string nif;
			string formato = "{0:0000000}";

			if( tipo == TypeNumber.CIF && Letter == "" )
				formato = "{0:00000000}";
			if( tipo == TypeNumber.NIF )
				formato = "{0:00000000}";

			nif = EsIntraComunitario ? CodigoIntracomunitario :
				string.Empty + Letter + string.Format( formato, Number ) + DigitControl;
			return nif;
		}

		#endregion

	}

}