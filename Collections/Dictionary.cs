// ----------------------------------------------------------------------------
// Título:    Dictionary
//
// Fecha:     01/01/2015
// Autor:    Alex Solé
// ----------------------------------------------------------------------------


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Utils.Collections
{
    class ProgramCollections
    {
        void Main( )
        {
            // Declaración
            Dictionary<int, bool> MyDictionary = new Dictionary<int, bool>( );
            // Añadir
            MyDictionary.Add( 1, true );

            // Recorrer todos los elementos
            foreach( KeyValuePair<int, bool> dictitem in MyDictionary ) {
                if( dictitem.Key == 1 ) {
                    // ...
                }
                if( dictitem.Value == true ) {
                    // ...
                }
            }

            //////////////

            Dictionary<int, string> lstDestinatarios = null;

            foreach( KeyValuePair<int, string> dicUsers in lstDestinatarios ) {
                int IdUsuariOAC = dicUsers.Key;
                string emailAC = dicUsers.Value;
            }
        }
    }
}

