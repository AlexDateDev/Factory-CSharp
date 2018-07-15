using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;
using System.Linq.Expressions;
using Help.Strings;
using Help.Linqs;
using Help.Validates;

namespace Help.WebForms
{
	public abstract class WFCheckboxList : WFWebControl
	{
		/// <summary>
		/// Asigna una colección de objeto a un CheckList.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="elem"></param>
		/// <param name="lst"></param>
		/// <param name="Key">Nombre del campo del obleto que se usa para la clave</param>
		/// <param name="Text">Nombre del campo del obleto que se usa para el texto</param>
		public static void DataBind<T>( CheckBoxList elem, IEnumerable<T> lst, string FieldNameKey, string FieldNameText )
		{
			if( HelperValidate.IsEmpty( FieldNameKey ) ) {
				throw new ArgumentNullException( "No se ha indicado la clave (WFCheckboxList: DataBind)" );
			}
			if( HelperValidate.IsEmpty( FieldNameText ) ) {
				throw new ArgumentNullException( "No se ha indicado el texto (WFCheckboxList: DataBind)" );
			}
			elem.DataSource = lst;
			elem.DataTextField = FieldNameText;
			elem.DataValueField = FieldNameKey;
			elem.DataBind( );
		}


		/// <summary>
		/// Asigna una colección de objeto a un CheckList.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="elem"></param>
		/// <param name="lst"></param>
		/// <param name="key"></param>
		/// <param name="val"></param>
		public static void DataBind<T>( CheckBoxList elem, IEnumerable<T> lst, Expression<Func<T, int>> key, Expression<Func<T, string>> val )
		{
			elem.DataSource = lst;
			elem.DataTextField = HelperLinq.GetExpresionName( val );
			elem.DataValueField = HelperLinq.GetExpresionName( key);
			elem.DataBind( );
		}

		/// <summary>
		/// Asigna un valor string a un CheckBox
		/// </summary>
		/// <param name="inp">CheckBoxList</param>
		/// <param name="value">string</param>
		public static void SetValue( CheckBoxList inp, string value )
		{
			inp.Text = value;
		}

		/// <summary>
		/// Devuelve el valor de una CheckBox
		/// </summary>
		/// <param name="inp">CheckBoxList</param>
		/// <returns></returns>
		public static string GetValue( CheckBoxList inp )
		{
			return inp.Text; ;
		}

	}
}
