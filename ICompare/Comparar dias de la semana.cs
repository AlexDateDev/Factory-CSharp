//// ----------------------------------------------------------------------------
//// Título:    Comparar dias de la semana
////
//// Fecha:     02/03/2013
//// Autor:    Alex Solé
//// ----------------------------------------------------------------------------

//public class ComparerDayOfWeek : IComparer<Object>
//{
//    //public int Compare( Object DatyOfWeekA, Object DatyOfWeekB )
//    //{
//    //    int nDatyOfWeekA = Convert.ToInt32( DatyOfWeekA );
//    //    if( nDatyOfWeekA == 0 ) {
//    //        nDatyOfWeekA = 7;
//    //    }
//    //    int nDatyOfWeekB = Convert.ToInt32( DatyOfWeekB );
//    //    if( nDatyOfWeekB == 0 ) {
//    //        nDatyOfWeekB = 7;
//    //    }

//    //    return String.Compare( nDatyOfWeekA.ToString( ), nDatyOfWeekB.ToString( ) );
//    //}
//}
////public ActionResult ajaxLoadTimeTableSportActivity( int IdSportActivity )
////{
////    SportActivity sp = this._SportActivityService.GetAllDataSportActivity( IdSportActivity );

////    // Comparador
////    ComparerDayOfWeek comparerDayOfWeek = new ComparerDayOfWeek( );

////    List<TimeTableSportActivity> lst  = new List<TimeTableSportActivity>( );
////    if( null != sp && null != sp.TimeTableSportActivity && sp.TimeTableSportActivity.Count > 0 ){

////        lst = sp.TimeTableSportActivity.OrderBy( p => p.DayWeek, comparerDayOfWeek)
////                                        .ThenBy( p => p.HourFrom )
////                                        .ToList();
////    }
////    return View( new GridModel { Data = lst } );
////}

