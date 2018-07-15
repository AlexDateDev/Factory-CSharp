// ----------------------------------------------------------------------------
// Título:    Tweet
//
// Fecha:     01/07/2016
// Autor:    Alex Solé
// ----------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Atexsa.Factory.Twitter {

    /// <summary>
    /// Entidad quer erpesenta un twit
    /// </summary>
    public class Tweet {

        public long Id {get;set;}
        public DateTime CreatedAt {get;set;}
        public string SinceTo {
            get {
                DateTime oldDate = this.CreatedAt;
                DateTime newDate = DateTime.Now;

                // Difference in days, hours, and minutes.
                TimeSpan ts = newDate - oldDate;

                string sDif = "";
                if( ts.Days == 0 ){
                    if( ts.Hours == 0 ){
                        sDif = ts.Minutes.ToString() + " min.";
                    }
                    else{
                        string m = "00" + ts.Minutes.ToString( );
                        m = m.Substring( m.Length - 2 );
                        sDif = ts.Hours.ToString( ) + ":" + m + " h.";
                    }

                }
                else{
                    sDif = ts.Days.ToString() + " dÃ­as ";
                    sDif += ts.Hours.ToString( ) + ":" + ts.Minutes.ToString( ) + " h.";
                }

                return sDif;
            }
        }
        public string UserName {get;set;}
        public string ScreenName {get;set;}
        public string Text {get;set;}
        public string MediaUrl {
            get;
            set;
        }
        public int MediaWidth {
            get;
            set;
        }
        public int MediaHeight {
            get;
            set;
        }
    }
}
