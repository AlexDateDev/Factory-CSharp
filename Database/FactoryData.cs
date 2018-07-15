// ----------------------------------------------------------------------------
// Título:    FactoryData
//
// Fecha:     18/06/2015
// Autor:    Alex Solé
// ----------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace Atexsa.GESDOCTAR2010.Entities
{

    /// <summary>
    /// Factoria de elementos
    /// </summary>
    public static partial class FactoryData
    {


        /// <summary>
        /// Manipulación del request
        /// </summary>
        public abstract class Sql
        {

            public static bool ColumnExists( SqlDataReader reader, string nombreColumna )
            {

                reader.GetSchemaTable( ).DefaultView.RowFilter = "ColumnName= '" + nombreColumna + "'";
                return ( reader.GetSchemaTable( ).DefaultView.Count > 0 );
            }

            public static bool ColumnExists( IDataReader reader, string nombreColumna )
            {

                reader.GetSchemaTable( ).DefaultView.RowFilter = "ColumnName= '" + nombreColumna + "'";
                return ( reader.GetSchemaTable( ).DefaultView.Count > 0 );
            }


            public static int? ToInt( SqlDataReader reader, string Field )
            {
                if( !ColumnExists( reader, Field ) ) {
                    return null;
                }
                if( Convert.IsDBNull( reader[ Field ] ) == true ) {
                    return null;
                } else {
                    return Convert.ToInt32( reader[ Field ] );
                }
            }

            public static int? ToInt( IDataReader reader, string Field )
            {
                if( !ColumnExists( reader, Field ) ) {
                    return null;
                }
                if( Convert.IsDBNull( reader[ Field ] ) == true ) {
                    return null;
                } else {
                    return Convert.ToInt32( reader[ Field ] );
                }
            }

            public static bool? ToBool( SqlDataReader reader, string Field )
            {
                if( !ColumnExists( reader, Field )){
                    return null;
                }

                if( Convert.IsDBNull( reader[ Field ] ) == true ) {
                    return null;
                } else {
                    return Convert.ToBoolean( reader[ Field ] );
                }
            }
            public static bool? ToBool( IDataReader reader, string Field )
            {
                if( !ColumnExists( reader, Field ) ) {
                    return null;
                }

                if( Convert.IsDBNull( reader[ Field ] ) == true ) {
                    return null;
                } else {
                    return Convert.ToBoolean( reader[ Field ] );
                }
            }

            public static short? ToShort( SqlDataReader reader, string Field )
            {
                if( !ColumnExists( reader, Field ) ) {
                    return null;
                }
                if( Convert.IsDBNull( reader[ Field ] ) == true ) {
                    return null;
                } else {
                    return Convert.ToInt16( reader[ Field ] );
                }
            }

            public static short? ToShort( IDataReader reader, string Field )
            {
                if( !ColumnExists( reader, Field ) ) {
                    return null;
                }
                if( Convert.IsDBNull( reader[ Field ] ) == true ) {
                    return null;
                } else {
                    return Convert.ToInt16( reader[ Field ] );
                }
            }
            public static string ToString( SqlDataReader reader, string Field )
            {
                if( !ColumnExists( reader, Field ) ) {
                    return null;
                }
                if( Convert.IsDBNull( reader[ Field ] ) == true ) {
                    return null;
                } else {
                    return Convert.ToString( reader[ Field ] );
                }
            }
            public static string ToString( IDataReader reader, string Field )
            {
                if( !ColumnExists( reader, Field ) ) {
                    return null;
                }
                if( Convert.IsDBNull( reader[ Field ] ) == true ) {
                    return null;
                } else {
                    return Convert.ToString( reader[ Field ] );
                }
            }
            public static System.DateTime? ToDateTime( SqlDataReader reader, string Field )
            {
                if( !ColumnExists( reader, Field ) ) {
                    return null;
                }
                if( Convert.IsDBNull( reader[ Field ] ) == true ) {
                    return null;
                } else {
                    return Convert.ToDateTime( reader[ Field ] );
                }
            }
            public static System.DateTime? ToDateTime( IDataReader reader, string Field )
            {
                if( !ColumnExists( reader, Field ) ) {
                    return null;
                }
                if( Convert.IsDBNull( reader[ Field ] ) == true ) {
                    return null;
                } else {
                    return Convert.ToDateTime( reader[ Field ] );
                }
            }

            public static Byte[ ] ToByteArray( SqlDataReader reader, string Field )
            {
                if( !ColumnExists( reader, Field ) ) {
                    return null;
                }
                if( Convert.IsDBNull( reader[ Field ] ) == true ) {
                    return null;
                } else {
                    return ( byte[ ] ) reader[ Field ];
                }
            }
            public static Byte[ ] ToByteArray( IDataReader reader, string Field )
            {
                if( !ColumnExists( reader, Field ) ) {
                    return null;
                }
                if( Convert.IsDBNull( reader[ Field ] ) == true ) {
                    return null;
                } else {
                    return ( byte[ ] ) reader[ Field ];
                }
            }
        }
    }
}
