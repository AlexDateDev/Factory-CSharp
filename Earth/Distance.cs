//// ----------------------------------------------------------------------------
//// Título:    Distance
////
//// Fecha:     02/03/2013
//// Autor:    Alex Solé
//// ----------------------------------------------------------------------------

//using System;
///// <summary>
///// Returns the distance in miles or kilometers of any two
///// latitude / longitude points.
///// </summary>
///// <param name=îpos1?></param>
///// <param name=îpos2?></param>
///// <param name=îtypeî></param>
///// <returns></returns>
//public static double Distance(double pos1Latitude, double pos1Longitude, double pos2Latitude, double pos2Longitude)
//{

//    double R = 6371d;
//    double dLat = toRadian(pos2Latitude - pos1Latitude);
//    double dLon = toRadian(pos2Longitude - pos1Longitude);
//    double a = Math.Sin(dLat / 2d) * Math.Sin(dLat / 2d) +
//        Math.Cos(toRadian(pos1Latitude)) * Math.Cos(toRadian(pos2Latitude)) *
//            Math.Sin(dLon / 2d) * Math.Sin(dLon / 2d);
//    double c = 2d * Math.Asin(Math.Min(1, Math.Sqrt(a)));
//    double d = R * c;
//    return d;

//}

