// ----------------------------------------------------------------------------
// NumberDNI
//
// Representa un número DNI (NIF o NIE) (Persona) o un CIF (Empresa)
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
	/// Representa un número DNI (NIF o NIE) (Persona) o un CIF (Empresa)
	/// encontrar
	/// </summary>
	public class NumberDNI
	{

		#region Private Member

		/// <summary>
		/// Tipos de Códigos.
		/// </summary>
		/// <remarks>Aunque actualmente no se utilice el término CIF, se usa en la enumeración
		/// por comodidad</remarks>
		private enum TypeNumber { NIF, NIE, CIF }

		// Número tal cual lo introduce el usuario
		private string numero;
		private TypeNumber tipo;

		/// <summary>
		/// Parte de Nif: En caso de ser un Nif intracomunitario, permite obtener el cógido del país
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
		/// Parte de Nif: Bloque numérico del NIF. En el caso de un NIF de persona física,
		/// corresponderá al DNI
		/// </summary>
		public int Number { get; internal set; }

		/// <summary>
		/// Parte de Nif: Dígito de control. Puede ser número o letra
		/// </summary>
		public string DigitControl { get; internal set; }

		/// <summary>
		/// Valor que representa si el Nif introducido es correcto
		/// </summary>
		public bool IsValid { get; internal set; }

		/// <summary>
		/// Cadena que representa el tipo de Nif comprobado:
		///     - NIF : Número de identificación fiscal de persona física
		///     - NIE : Número de identificación fiscal extranjería
		///     - CIF : Código de identificación fiscal (Entidad jurídica)
		/// </summary>
		public string TypeDNI { get { return tipo.ToString( ); } }

		#endregion

		/// <summary>
		/// Constructor. Al instanciar la clase se realizan todos los cálculos
		/// </summary>
		/// <param name="numero">Cadena de 9 u 11 caracteres que contiene el DNI/NIF
		/// tal cual lo ha introducido el usuario para su verificación</param>
		public NumberDNI( string numero )
		{
			if( null == numero ) {
				return;
			}
			// Se eliminan los carácteres sobrantes
			numero = EliminaCaracteres( numero );

			// Todo en maýusculas
			numero = numero.ToUpper( );

			// Comprobación básica de la cadena introducida por el usuario
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

		#region Preparación del número (desglose)

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
		/// Realiza un desglose del número introducido por el usuario en las propiedades
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
				// Nif español
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
		/// En base al primer carácter del código, se obtiene el tipo de documento que se intenta
		/// comprobar
		/// </summary>
		/// <param name="letra">Primer carácter del número pasado</param>
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
		/// Eliminación de todos los carácteres no numéricos o de texto de la cadena
		/// </summary>
		/// <param name="numero">Número tal cual lo escribe el usuario</param>
		/// <returns>Cadena de 9 u 11 carácteres sin signos</returns>
		private string EliminaCaracteres( string numero )
		{
			if( null == numero ) {
				return numero;
			}
			// Todos los carácteres que no sean números o letras
			string caracteres = @"[^\w]";
			Regex regex = new Regex( caracteres );
			return regex.Replace( numero, "" );
		}

		#endregion

		#region Cálculos

		/// <summary>
		/// Cálculos para la comprobación del Nif
		/// </summary>
		/// <returns></returns>
		private bool IsNIF( )
		{
			return DigitControl == GetLetraNif( );
		}

		/// <summary>
		/// Cálculos para la comprobación del Cif (Entidad jurídica)
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

			// Recorrido por todos los dígitos del número
			for( i = 0; i < n.Length; i++ ) {
				Int32 aux;
				Int32.TryParse( n[ i ].ToString( ), out aux );

				if( ( i + 1 ) % 2 == 0 ) {
					// Si es una posición par, se suman los dígitos
					sumaPares += aux;
				} else {
					// Si es una posición impar, se multiplican los dígitos por 2
					aux = aux * 2;

					// se suman los dígitos de la suma
					sumaImpares += SumaDigitos( aux );
				}
			}
			// Se suman los resultados de los números pares e impares
			sumaTotal += sumaPares + sumaImpares;

			// Se obtiene el dígito de las unidades
			Int32 unidades = sumaTotal % 10;

			// Si las unidades son distintas de 0, se restan de 10
			if( unidades != 0 ) {
				unidades = 10 - unidades;
			}

			switch( Letter ) {
				// Sólo números
				case "A":
				case "B":
				case "E":
				case "H":
					retVal = DigitControl == unidades.ToString( );
					break;

				// Sólo letras
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
		/// Obtiene la suma de todos los dígitos
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
		/// Obtiene una cadena con el número de identificación completo
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