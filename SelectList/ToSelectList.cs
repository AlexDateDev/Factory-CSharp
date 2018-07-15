//// ----------------------------------------------------------------------------
//// Título:    ToSelectList
////
//// Fecha:     26/06/2013
//// Autor:    Alex Solé
//// ----------------------------------------------------------------------------


//using System;
//using System.Collections.Generic;
//using System.Web.Mvc;
//using System.Linq.Expressions;

//    public static partial class Helpers
//    {

//        /// <summary>
//        /// Convierte un IEnumerable en un SelectList para un DropDown
//        /// </summary>
//        /// <typeparam name="TSource"></typeparam>
//        /// <typeparam name="TValue"></typeparam>
//        /// <typeparam name="TText"></typeparam>
//        /// <param name="source"></param>
//        /// <param name="dataValueField"></param>
//        /// <param name="dataTextField"></param>
//        /// <param name="selectedValue"></param>
//        /// <returns></returns>

//       /*
//          IEnumerable<Departamento> IEDep = AdmDepartamentos.ObtenerTodosPorEstado( Departamento.ESTADO_DISPONIBLE );
//          model.selDepartamentos = IEDep.ToSelectList( p => p.DepartamentoID, p => p.NombreCA );
//       */

//        public static SelectList ToSelectList<TSource, TValue, TText>(    this IEnumerable<TSource> source,
//                                                                        Expression<Func<TSource, TValue>> dataValueField,
//                                                                        Expression<Func<TSource, TText>> dataTextField,
//                                                                        object selectedValue = null )
//        {
//            string dataName = ExpressionHelper.GetExpressionText( dataValueField );
//            string textName = ExpressionHelper.GetExpressionText( dataTextField );
//            return new SelectList( source, dataName, textName, selectedValue );
//        }

//    }

