using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;
using System.Linq.Expressions;
using System.Collections;
using System.Reflection;
using Utils.Strings;
using Help.Validates;

namespace Help.WebForms
{
	public abstract class WFCombobox : WFWebControl
	{
		/// <summary>
		/// Elimina la opción seleccionada
		/// </summary>
		/// <param name="ddl">DropDownList </param>
		public static void RemoveSeletcedItem( DropDownList ddl )
		{
			ListItem item = ddl.SelectedItem;
			if( null != item ) {
				ddl.Items.Remove( item );
			}
		}

		/// <summary>
		/// Devuelve true si hay algún valor seleccionado (selectedvalue == null o "") o false si no hay ninguno
		/// </summary>
		/// <param name="lstBox">DropDownList </param>
		/// <returns>bool</returns>
		public static bool IsEmpty( DropDownList lstBox )
		{
			if( null == lstBox.SelectedValue ) {
				return true;
			}
			return lstBox.SelectedValue.Trim( ) == "";
		}

		/// <summary>
		/// Elimina todas las opciones de un combo
		/// </summary>
		/// <param name="ddl">DropDownList </param>
		public static void Reset( DropDownList ddl )
		{
			ddl.Items.Clear( );
		}


		public static void Clear( DropDownList ddl )
		{
			ddl.SelectedIndex = -1;
		}
	#region SelectedValue

		/// <summary>
		/// Selecciona un determinado valor (string) de un combo
		/// </summary>
		/// <param name="ddl">DropDownList </param>
		/// <param name="Val">string</param>
		public static void SetSelectedValue( DropDownList ddl, string Val )
		{
			ddl.SelectedValue = Val;
		}

		/// <summary>
		/// Selecciona un determinado valor (int?) de un combo
		/// </summary>
		/// <param name="ddl">DropDownList </param>
		/// <param name="Val">int?</param>
		public static void SetSelectedValue( DropDownList ddl, int? Val )
		{
			if( null != Val ) {
				ddl.SelectedValue = Val.Value.ToString( );
			} else {
				ddl.SelectedIndex = -1;
			}
		}

		/// <summary>
		/// Selecciona un determinado valor (int) de un combo
		/// </summary>
		/// <param name="ddl">DropDownList </param>
		/// <param name="Val">int</param>
		public static void SetSelectedValue( DropDownList ddl, int Val )
		{
			ddl.SelectedValue = Val.ToString();
		}


		/// <summary>
		/// Devuelve el valor seleccionado del combo como un string
		/// </summary>
		/// <param name="ddl"></param>
		/// <returns></returns>
		public static string GetSelectedValue( DropDownList ddl )
		{
			return ddl.SelectedValue;
		}

		/// <summary>
		/// Devuelve el valor seleccionado del combo como un int?.
		/// Si es "0", "" o null  devuelve null
		/// Si no se puede convertir a int => Exception
		/// </summary>
		/// <param name="ddl">DropDownList</param>
		/// <exception cref="ex">Exception</exception>
		/// <returns>int?</returns>
		public static int? GetSelectedValueInt( DropDownList ddl )
		{
			if( ( null == ddl.SelectedValue ) || ( 0 == ddl.SelectedValue.Length ) || "0" == ddl.SelectedValue ) {
				return null;
			}

			int i =0;
			if( Int32.TryParse( ddl.SelectedValue, out i ) ) {
				return i;
			}
			throw new ArgumentOutOfRangeException( "No se puede convertir SelectedValue a int (WFCombobox: GetSelectedValueInt)" );
		}

	#endregion

	#region SelectedIndex 

		/// <summary>
		/// Devuelve el íncide seleccionado. -1 si no hay ninguno
		/// </summary>
		/// <param name="ddl">DropDownList</param>
		/// <returns>int</returns>
		public static int GetSelectedIndex( DropDownList ddl )
		{
			return ddl.SelectedIndex;
		}

		/// <summary>
		/// Selecciona un indice del un combo
		/// </summary>
		/// <param name="ddl">DropDownList</param>
		/// <param name="Index">int</param>
		public static void SetSelectedIndex( DropDownList ddl, int Index )
		{
			if( Index < 0 ) {
				throw new ArgumentOutOfRangeException( "SelectedIndex  no puede ser menor de 0 (WFCombobox SetSelectedIndex)" );
			}
			ddl.SelectedIndex = Index;
		}

	#endregion


		/// <summary>
		/// Elimina una clave (int) determinada del combo, devuelve true si la ha elimiando o false so no la ha eliminado (no existe)
		/// </summary>
		/// <param name="ddl">DropDownList </param>
		/// <param name="Key">int</param>
		/// <returns>bool</returns>
		public static bool RemoveKey( DropDownList ddl, int Key )
		{
			ListItem item = ddl.Items.FindByValue( Key.ToString( ) );
			if( null != item ) {
				ddl.Items.Remove( item );
				return true;
			}
			return false;
		}

		/// <summary>
		/// Elimina una clave (string) determinada del combo, devuelve true si la ha elimiando o false so no la ha eliminado (no existe)
		/// </summary>
		/// <param name="ddl">DropDownList </param>
		/// <param name="Key">string</param>
		/// <returns>bool</returns>
		public static bool RemoveKey( DropDownList ddl, string Key )
		{
			if( HelperValidate.IsEmpty( Key ) ) {
				throw new ArgumentNullException( "No se ha indicado la clave donde insertar (WFCombobox: AddKeyValue)" );
			}
			ListItem item = ddl.Items.FindByValue( Key );
			if( null != item ) {
				ddl.Items.Remove( item );
				return true;
			}
			return false;
		}


		/// <summary>
		/// Inserta un clave(int)/valor(string) al combo en una posicion determinada.
		/// 0 es la primera.
		/// </summary>
		/// <param name="Pos">int</param>
		/// <param name="ddl">DropDownList</param>
		/// <param name="key">int</param>
		/// <exception cref="ex">Exception</exception>
		/// <param name="value">string</param>
		public static void InsertKeyValue( DropDownList ddl, int Pos, int key, string value )
		{
			if( Pos < 0 ) {
				throw new ArgumentOutOfRangeException( "La posición donde insertar no puede ser menor de 0 (WFCombobox InsertKeyValue)" );
			}
			ddl.Items.Insert( Pos, new ListItem( value, key.ToString( ) ) );
		}
		/// <summary>
		/// Inserta un clave(string)/valor(int) al combo en una posicion determinada.
		/// </summary>
		/// <param name="ddl">DropDownList</param>
		/// <param name="Pos">int</param>
		/// <param name="key">string</param>
		/// <param name="value">int</param>
		/// <exception cref="ex">Exception</exception>
		public static void InsertKeyValue( DropDownList ddl, int Pos, string key, int value )
		{
			if( Pos < 0 ) {
				throw new ArgumentOutOfRangeException( "La posición donde insertar no puede ser menor de 0 (WFCombobox InsertKeyValue)" );
			}
			if( HelperValidate.IsEmpty( key ) ) {
				throw new ArgumentNullException( "No se ha indicado la clave donde insertar (WFCombobox: InsertKeyValue)" );
			}
			ddl.Items.Insert( Pos, new ListItem( value.ToString(), key ) );
		}

		/// <summary>
		/// Inserta un clave(int)/valor(int) al combo en una posicion determinada.
		/// </summary>
		/// <param name="ddl">DropDownList</param>
		/// <param name="Pos">int</param>
		/// <param name="key">int</param>
		/// <param name="value">int</param>
		/// <exception cref="ex">Exception</exception>
		public static void InsertKeyValue( DropDownList ddl, int Pos, int key, int value )
		{
			if( Pos < 0 ) {
				throw new ArgumentOutOfRangeException( "La posición donde insertar no puede ser menor de 0 (WFCombobox InsertKeyValue)" );
			}
			ddl.Items.Insert( Pos, new ListItem( value.ToString(), key.ToString( ) ) );
		}

		/// <summary>
		/// Inserta un clave(string)/valor(string) al combo en una posicion determinada.
		/// </summary>
		/// <param name="ddl">DropDownList</param>
		/// <param name="Pos">int</param>
		/// <param name="key">string</param>
		/// <param name="value">string</param>
		/// <exception cref="ex">Exception</exception>
		public static void InsertKeyValue( DropDownList ddl, int Pos, string key, string value )
		{
			if( Pos < 0 ) {
				throw new ArgumentOutOfRangeException( "La posición donde insertar no puede ser menor de 0 (WFCombobox InsertKeyValue)" );
			}
			ddl.Items.Insert( Pos, new ListItem( value, key ) );
		}
		/// <summary>
		/// Añade un valor (int)/ clave (int) al combo
		/// </summary>
		/// <param name="ddl"></param>
		/// <param name="key"></param>
		/// <param name="value"></param>
		public static void AddKeyValue( DropDownList ddl, int key, int value )
		{
			ddl.Items.Add( new ListItem( value.ToString( ), key.ToString( ) ) );
		}

		/// <summary>
		/// Añade un valor (string)/ clave (int) al combo
		/// </summary>
		/// <param name="ddl"></param>
		/// <param name="key"></param>
		/// <exception cref="ex"></exception>
		/// <param name="value"></param>
		public static void AddKeyValue( DropDownList ddl, string key, string value )
		{
			if( HelperValidate.IsEmpty( key ) ) {
				throw new ArgumentNullException( "No se ha indicado la clave donde insertar (WFCombobox: AddKeyValue)" );
			}
			ddl.Items.Add( new ListItem( value, key ) );
		}


		/// <summary>
		/// Añade un valor (string)/ clave (int) al combo
		/// </summary>
		/// <param name="ddl"></param>
		/// <param name="key"></param>
		/// <param name="value"></param>
		public static void AddKeyValue( DropDownList ddl, int key, string value )
		{
			ddl.Items.Add( new ListItem( value, key.ToString( ) ) );
		}


		/// <summary>
		/// Asigna una colección de objeto a un combo
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="elem"></param>
		/// <param name="lst"></param>
		/// <exception cref="ex"></exception>
		/// <param name="Key">Nombre del campo del obleto que se usa para la clave</param>
		/// <param name="Text">Nombre del campo del obleto que se usa para el texto</param>
		public static void DataBind<T>( DropDownList elem, IEnumerable<T> lst, string FieldNameKey, string FieldNameText )
		{

			if( HelperValidate.IsEmpty( FieldNameKey) ) {
				throw new ArgumentNullException( "No se ha indicado la clave (WFCombobox: DataBind)" );
			}
			if( HelperValidate.IsEmpty( FieldNameText ) ) {
				throw new ArgumentNullException( "No se ha indicado el texto (WFCombobox: DataBind)" );
			}
			elem.DataSource = lst;
			elem.DataTextField = FieldNameText;
			elem.DataValueField = FieldNameKey;
			elem.DataBind( );
		}


		
		/// <summary>
		/// Asigna una colección de objeto a un combo
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="elem"></param>
		/// <param name="lst"></param>
		/// <param name="key"></param>
		/// <param name="val"></param>
		public static void DataBind<T>( DropDownList elem, IEnumerable<T> lst, Expression<Func<T, int>> key,  Expression<Func<T, string>> val, string TextFirstValue=null )
		{
			Reset( elem );
			elem.DataSource = lst;
			elem.DataTextField = GetMemberInfo( val ).Member.Name; //"FieldNameText;
			elem.DataValueField = GetMemberInfo( key ).Member.Name; // FieldNameKey;
			elem.DataBind( );

			if( null != TextFirstValue ) {
				// ---------
				// Cuidado el elemento ASP ha de tener  AppendDataBoundItems="true"
				// ---------
				elem.Items.Insert( 0, new ListItem( TextFirstValue, "0" ) );
				elem.SelectedIndex = 0;
			}


		}

		private static MemberExpression GetMemberInfo( Expression method )
		{
			LambdaExpression lambda = method as LambdaExpression;
			if( lambda == null )
				throw new ArgumentNullException( "method" );

			MemberExpression memberExpr = null;

			if( lambda.Body.NodeType == ExpressionType.Convert ) {
				memberExpr =
					( ( UnaryExpression ) lambda.Body ).Operand as MemberExpression;
			} else if( lambda.Body.NodeType == ExpressionType.MemberAccess ) {
				memberExpr = lambda.Body as MemberExpression;
			}

			if( memberExpr == null )
				throw new ArgumentException( "method" );

			return memberExpr;
		}

		/// <summary>
		/// Devuelve las claves seleccionadas en un ListBox Multiple
		/// </summary>
		/// <param name="elem"></param>
		/// <returns></returns>
		public static List<string> GetMultipleSelectedKey( DropDownList elem )
		{
			List<string> lst = new List<string>( );
			foreach( ListItem listItem in elem.Items ) {
				if( listItem.Selected ) {
					lst.Add( listItem.Value );
				}
			}
			return lst;
		}

		//public static void InsertKeyValueInGroup( DropDownList ddl, int IdGroup, int key, string value )
		//{
		//    int n = 0;
		//    int PosToInsert = -1;
		//    foreach( ListItem item in ddl.Items ) {
		//        if( item.Value == IdGroup.ToString( ) ) {
		//            PosToInsert = ( n + 1 );
		//            break;
		//        }
		//        n++;
		//    }

		//    ddl.Items.Insert( PosToInsert, new ListItem( ) {
		//        Text = value,
		//        Value = ( key.ToString( ) + "#" + IdGroup.ToString( ) )
		//    } );
		//}
	}
}
