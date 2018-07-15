using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;
using System.Linq.Expressions;
using Help.Linqs;
using Help.Strings;
using Help.Validates;

namespace Help.WebForms
{
	public abstract class WFListbox : WFWebControl
	{
		/// <summary>
		/// Devuelve el número de option del ListBox
		/// </summary>
		/// <param name="ddl"></param>
		/// <returns></returns>
		public static int GetSize( ListBox ddl )
		{
			return ddl.Items.Count;
		}

		/// <summary>
		/// Elimina la opción seleccionada del las opciones del listbox
		/// </summary>
		/// <param name="ddl">ListBox</param>
		public static void RemoveSeletcedItem( ListBox ddl )
		{
			ListItem item = ddl.SelectedItem;
			if( null != item ) {
				ddl.Items.Remove( item );
			}
		}

		/// <summary>
		/// Devuelve true si no hay algún valor seleccionado o false si no hay ninguno
		/// </summary>
		/// <param name="lstBox">ListBox</param>
		/// <returns>bool</returns>
		public static bool IsEmpty( ListBox lstBox )
		{
			if( null == lstBox.SelectedValue ) {
				return true;
			}
			return lstBox.SelectedValue.Trim( ) == "";
		}

		/// <summary>
		/// Elimina todas las opciones de un combo
		/// </summary>
		/// <param name="ddl">ListBox</param>
		public static void Reset( ListBox ddl )
		{
			ddl.Items.Clear( );
		}

		/// <summary>
		///  No selecciona ninguna opción
		/// </summary>
		/// <param name="ddl">ListBox</param>
		public static void ClearSelectedIndex( ListBox ddl )
		{
			ddl.SelectedIndex = -1;
		}

	#region SelectedValue

		/// <summary>
		/// Selecciona un determinado valor (string) de un ListBox
		/// </summary>
		/// <param name="ddl">ListBox</param>
		/// <param name="Val">string</param>
		public static void SetSelectedValue( ListBox ddl, string Val )
		{
			ddl.SelectedValue = Val;
		}

		/// <summary>
		/// Selecciona un determinado valor (int?) de un ListBox
		/// </summary>
		/// <param name="ddl">ListBox</param>
		/// <param name="Val">int</param>
		public static void SetSelectedValue( ListBox ddl, int Val )
		{
			ddl.SelectedValue = Val.ToString( );
		}

		/// <summary>
		/// Selecciona un determinado valor (int?) de un ListBox
		/// </summary>
		/// <param name="ddl">ListBox</param>
		/// <param name="Val">int</param>
		public static void SetSelectedValue( ListBox ddl, int? Val )
		{
			if( null != Val ) {
				ddl.SelectedValue = Val.Value.ToString( );
			} else {
				ddl.SelectedIndex = -1;
			}
		}

		/// <summary>
		/// Devuelve el valor seleccionado del ListBox como un string
		/// </summary>
		/// <param name="ddl">ListBox</param>
		/// <returns>string</returns>
		public static string GetSelectedValue( ListBox ddl )
		{
			return ddl.SelectedValue;
		}

		/// <summary>
		/// Devuelve el valor seleccionado del ListBox como un int?.
		/// Si es "0", "" o null  devuelve null
		/// Si SelectedValue no se puede convertir a int => Exception
		/// </summary>
		/// <param name="ddl">ListBox</param>
		/// <returns>int?</returns>
		/// <exception cref="ex">Exception</exception>
		public static int? GetSelectedValueInt( ListBox ddl )
		{
			if( ( null == ddl.SelectedValue ) || ( 0 == ddl.SelectedValue.Length ) || "0" == ddl.SelectedValue ) {
				return null;
			}
			int i =0;
			if( Int32.TryParse( ddl.SelectedValue, out i ) ) {
				return i;
			}
			throw new Exception( "No se puede convertir el SelectedValue a un int (WFListbox: GetSelectedValueInt)");
		}

	#endregion

	#region SelectedIndex

		/// <summary>
		/// Devuelve el íncide seleccionado. -1 si no hay ninguno
		/// </summary>
		/// <param name="ddl">ListBox</param>
		/// <returns>int</returns>
		public static int GetSelectedIndex( ListBox ddl )
		{
			return ddl.SelectedIndex;
		}

		/// <summary>
		/// Selecciona un indice del un ListBox
		/// </summary>
		/// <param name="ddl">ListBox</param>
		/// <param name="Index">int</param>
		public static void SetSelectedIndex( ListBox ddl, int Index )
		{
			if( Index < 0 ) {
				throw new ArgumentOutOfRangeException( "SelectedIndex no puede ser menor de 0 (AtxListbix SetSelectedIndex)" );
			}
			ddl.SelectedIndex = Index;
		}

	#endregion


		/// <summary>
		/// Elimina una clave determinada (int) del ListBox
		/// </summary>
		/// <param name="ddl">ListBox</param>
		/// <param name="Key">int</param>
		public static void RemoveKey( ListBox ddl, int Key )
		{
			ListItem item = ddl.Items.FindByValue( Key.ToString( ) );
			if( null != item ) {
				ddl.Items.Remove( item );
			}
		}

		/// <summary>
		/// Elimina una clave determinada (string) del ListBox
		/// </summary>
		/// <param name="ddl">ListBox</param>
		/// <param name="Key">string</param>
		public static void RemoveKey( ListBox ddl, string Key )
		{
			if( HelperValidate.IsEmpty( Key ) ) {
				throw new ArgumentNullException( "No se ha indicado la clave a eliminar (AtxListBox: RemoveKey)" );
			}
			ListItem item = ddl.Items.FindByValue( Key );
			if( null != item ) {
				ddl.Items.Remove( item );
			}
		}
		
		/// <summary>
		/// Inserta una clave(int)/valor(string) al ListBox en una posicion determinada.
		/// 0 es la primera
		/// </summary>
		/// <param name="ddl">ListBox</param>
		/// <param name="Pos">int</param>
		/// <param name="key">int</param>
		/// <param name="value">string</param>
		public static void InsertKeyValue( ListBox ddl, int Pos, int key, string value )
		{
			if( Pos < 0 ) {
				throw new ArgumentOutOfRangeException( "La posición donde insertar no puede ser menor de 0 (AtxListbix InsertKeyValue)" );
			}
			ddl.Items.Insert( Pos, new ListItem( value, key.ToString( ) ) );
		}

		/// <summary>
		/// Inserta una clave(int)/valor(int) al ListBox en una posicion determinada.
		/// 0 es la primera
		/// </summary>
		/// <param name="ddl">Listbox</param>
		/// <param name="Pos">int</param>
		/// <param name="key">int</param>
		/// <param name="value">int</param>
		public static void InsertKeyValue( ListBox ddl, int Pos, int key, int value )
		{
			if( Pos < 0 ) {
				throw new ArgumentOutOfRangeException( "La posición donde insertar no puede ser menor de 0 (AtxListbix InsertKeyValue)" );
			}
			ddl.Items.Insert( Pos, new ListItem( value.ToString( ), key.ToString( ) ) );
		}

		/// <summary>
		/// Inserta una clave(string)/valor(int) al ListBox en una posicion determinada.
		/// 0 es la primera
		/// </summary>
		/// <param name="ddl">Listbox</param>
		/// <param name="Pos">int</param>
		/// <param name="key">string</param>
		/// <param name="value">int</param>
		public static void InsertKeyValue( ListBox ddl, int Pos, string key, int value )
		{
			if( Pos < 0 ) {
				throw new ArgumentOutOfRangeException( "La posición donde insertar no puede ser menor de 0 (AtxListbix InsertKeyValue)" );
			}
			if( HelperValidate.IsEmpty( key ) ) {
				throw new ArgumentNullException( "No se ha indicado la clave donde insertar (AtxListBox: InsertKeyValue)" );
			}

			ddl.Items.Insert( Pos, new ListItem( value.ToString( ), key ) );
		}

		/// <summary>
		/// Inserta una clave(string)/valor(string) al ListBox en una posicion determinada.
		/// 0 es la primera
		/// </summary>
		/// <param name="ddl">Listbox</param>
		/// <param name="Pos">int</param>
		/// <param name="key">string</param>
		/// <param name="value">string</param>
		public static void InsertKeyValue( ListBox ddl, int Pos, string key, string value )
		{
			if( Pos < 0 ) {
				throw new ArgumentOutOfRangeException( "La posición donde insertar no puede ser menor de 0 (AtxListbix InsertKeyValue)" );
			}
			if( HelperValidate.IsEmpty( key ) ) {
				throw new ArgumentNullException( "No se ha indicado la clave donde insertar (AtxListBox: InsertKeyValue)" );
			}
			ddl.Items.Insert( Pos, new ListItem( value, key ) );
		}

		/// <summary>
		/// Añade al final una clave(int)/valor(int) al ListBox
		/// </summary>
		/// <param name="ddl">ListBox</param>
		/// <param name="key">int</param>
		/// <param name="value">int</param>
		public static void AddKeyValue( ListBox ddl, int key, int value )
		{
			ddl.Items.Add( new ListItem( value.ToString( ), key.ToString( ) ) );
		}

		/// <summary>
		/// Añade al final una clave(string)/valor(string) al ListBox
		/// </summary>
		/// <param name="ddl">Listbox</param>
		/// <param name="key">string</param>
		/// <param name="value">string</param>
		public static void AddKeyValue( ListBox ddl, string key, string value )
		{
			if( HelperValidate.IsEmpty( key ) ) {
				throw new ArgumentNullException( "No se ha indicado la clave donde insertar (AtxListBox: AddKeyValue)" );
			}
			ddl.Items.Add( new ListItem( value, key ) );
		}


		/// <summary>
		/// Añade al final una clave(int)/valor(string) al ListBox 
		/// </summary>
		/// <param name="ddl">Listbox</param>
		/// <param name="key">int</param>
		/// <param name="value">string</param>
		public static void AddKeyValue( ListBox ddl, int key, string value )
		{
			ddl.Items.Add( new ListItem( value, key.ToString( ) ) );
		}

		/// <summary>
		/// Añade al final una clave(string)/valor(int) al ListBox 
		/// </summary>
		/// <param name="ddl">Listbox</param>
		/// <param name="key">string</param>
		/// <param name="value">int</param>
		public static void AddKeyValue( ListBox ddl, string key, int value )
		{
			if( HelperValidate.IsEmpty( key ) ) {
				throw new ArgumentNullException( "No se ha indicado la clave donde insertar (AtxListBox: AddKeyValue)" );
			}

			ddl.Items.Add( new ListItem( value.ToString(), key ) );
		}

		/// <summary>
		/// Asigna una colección de objeto a un ListBox
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="elem"></param>
		/// <param name="lst"></param>
		/// <param name="Key">Nombre del campo del obleto que se usa para la clave</param>
		/// <param name="Text">Nombre del campo del obleto que se usa para el texto</param>
		public static void DataBind<T>( ListBox elem, IEnumerable<T> lst, string FieldNameKey, string FieldNameText )
		{
			if( HelperValidate.IsEmpty( FieldNameKey ) ) {
				throw new ArgumentNullException( "No se ha indicado la clave (AtxListBox: DataBind)" );
			}
			if( HelperValidate.IsEmpty( FieldNameText ) ) {
				throw new ArgumentNullException( "No se ha indicado el texto (AtxListBox: DataBind)" );
			}
			elem.DataSource = lst;
			elem.DataTextField = FieldNameText;
			elem.DataValueField = FieldNameKey;
			elem.DataBind( );
		}

		public static void DataBind<T>( ListBox elem, IEnumerable<T> lst, Expression<Func<T, int>> key, Expression<Func<T, string>> val )
		{
			elem.DataSource = lst;
			elem.DataTextField = HelperLinq.GetExpresionName( val );
			elem.DataValueField = HelperLinq.GetExpresionName( key);
			elem.DataBind( );
		}


		/// <summary>
		/// Devuelve las claves seleccionadas en un ListBox Multiple
		/// </summary>
		/// <param name="elem">Listbox</param>
		/// <returns>List<string></string></returns>
		public static List<string> GetMultipleSelectedKey( ListBox elem )
		{
			List<string> lst = new List<string>( );
			foreach( ListItem listItem in elem.Items ) {
				if( listItem.Selected ) {
					lst.Add( listItem.Value );
				}
			}
			return lst;
		}


	}
}