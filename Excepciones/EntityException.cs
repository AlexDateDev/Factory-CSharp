//// ----------------------------------------------------------------------------
//// Título:    EntityException
////
//// Fecha:     02/03/2013
//// Autor:    Alex Solé
//// ----------------------------------------------------------------------------


//using System.Data;

//public User GetByDNI( string sDNI )
//{
//    using( WSigeDataModel context = new WSigeDataModel( ) ) {
//        try {

//            User u = context.User.FirstOrDefault( usr => usr.DNI == sDNI &&
//                                                          usr.Deleted == false );
//            return u;

//        } catch( EntityException exDb ) {
//            //TODO
//            throw new Exception( exDb.Message );
//        } finally {
//            context.Dispose( );
//        }
//    }
//}

