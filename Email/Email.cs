using System;
using System.Net.Mail;
using Help.Strings;
using Help.Validates;
using System.IO;

namespace Help.Mails
{
    /// <summary>
    /// Descripci�n breve de Mail
    ///
    /// V.1.4    Se ha a�adido Delegate
    /// V.1.3    Se ha añadido port y enableSSL
    /// V.1.2    Se han cambiado SetHtmlFooter, SetHtmlHeader
    ///            Se han añadiro GetHtmlFooter, SetHtmlHeader, getBody y GetBodyFooterHeader
    ///            Se ha cambiado void Send por bool Send
    ///
    /// V.1.1    Se ha hecho public Smtp y Correo, la funciona Send es ahora virtual para que se pueda sobreescribir
    /// V.1.0
    /// </summary>
    public partial class HelperEmail
    {

        public MailMessage Correo = null;
        public SmtpClient Smtp = null;

        private string _HtmlBody = "";

        /// <summary>
        /// Email
        /// </summary>
        /// <param name="emailRemitenteRFC"></param>
        /// <param name="serverSMTP"></param>
        /// <param name="usuarioSMTP"></param>
        /// <param name="pswSMTP"></param>
        /// <param name="port"></param>
        /// <param name="enableSSL"></param>
        public HelperEmail( string emailRemitenteRFC,
                            string serverSMTP,
                            string usuarioSMTP,
                            string pswSMTP,
                            int? port = null,
                            bool? enableSSL = null)
        {
            try {
                if( HelperValidate.IsEmpty( emailRemitenteRFC ) ) {
                    throw new ArgumentNullException( "No se ha indicado el email del remitente (FactoryMail: Email" );
                }
                if( HelperValidate.IsEmpty( serverSMTP ) ) {
                    throw new ArgumentNullException( "No se ha indicado el servidor SMTP (FactoryMail: Email" );
                }
                if( HelperValidate.IsEmpty( emailRemitenteRFC ) ) {
                    throw new ArgumentNullException( "No se ha indicado el usuario del servidor SMTP (FactoryMail: Email" );
                }
                if( HelperValidate.IsEmpty( emailRemitenteRFC ) ) {
                    throw new ArgumentNullException( "No se ha indicado la contraseña del usuario del servidor SMTP (FactoryMail: Email" );
                }

                this.Correo = new MailMessage( ) {
                    HeadersEncoding = System.Text.Encoding.UTF8,
                    SubjectEncoding = System.Text.Encoding.UTF8,
                    BodyEncoding = System.Text.Encoding.UTF8
                };

                this.Correo.From = new MailAddress( emailRemitenteRFC );

                this.Correo.IsBodyHtml = true;
                this.Correo.Priority = MailPriority.Normal;

                // Server SMTP
                this.Smtp = new SmtpClient( serverSMTP );
                this.Smtp.UseDefaultCredentials = false;

                if( port.HasValue ) {
                    this.Smtp.Port = port.Value;
                }
                if( enableSSL.HasValue ) {
                    this.Smtp.EnableSsl = enableSSL.Value;
                }

                // User SMTP
                if( !HelperValidate.IsEmpty( usuarioSMTP ) && !HelperValidate.IsEmpty( pswSMTP ) ) {
                    this.Smtp.Credentials = new System.Net.NetworkCredential( usuarioSMTP, pswSMTP );
                }
            } catch( Exception ex ) {
                throw new Exception( "Imposible crear email (FactoryMail: Email) " + ex.Message, ex );
            }
        }

        /// <summary>
        /// Asigna el puerto por donde enviar el correu
        /// </summary>
        /// <param name="port"></param>
        public void SetPort( int port )
        {
            this.Smtp.Port = port;
        }

        /// <summary>
        /// Devuelve el puerto por denode se envia el correo
        /// </summary>
        /// <returns></returns>
        public int GetPort( )
        {
            return this.Smtp.Port;
        }

        /// <summary>
        /// Activa/desactiva el SSL/TLS
        /// </summary>
        /// <param name="enable"></param>
        public void SetEnableSSL( bool enable )
        {
            this.Smtp.EnableSsl = enable;
        }

        /// <summary>
        /// Indica si el SSL/TLS esta activado o no
        /// </summary>
        /// <returns></returns>
        public bool GetEnableSSL(  )
        {
            return this.Smtp.EnableSsl;
        }

        /// <summary>
        /// Asigna el título del correo
        /// </summary>
        /// <param name="Subject">string</param>
        public void SetSubject( string Subject )
        {
            this.Correo.Subject = Subject;
        }

        /// <summary>
        /// Devuelve el Subject del correo
        /// </summary>
        /// <returns></returns>
        public string GetSubject( )
        {
            return this.Correo.Subject;
        }

        /// <summary>
        /// Asigna el cuerpo del correo
        /// </summary>
        /// <param name="Body"></param>
        public void SetBody( string Body )
        {
            this._HtmlBody = Body;
        }

        /// <summary>
        /// Devuelve sólo el texto del body
        /// </summary>
        /// <returns></returns>
        public string GetBody( )
        {
            return this._HtmlBody;
        }

        /// <summary>
        /// Elimina todos los destinatarios
        /// </summary>
        public void ClearDestinataries( )
        {
            this.Correo.To.Clear( );
            this.Correo.Bcc.Clear( );
            this.Correo.CC.Clear( );
        }

        /// <summary>
        /// Añade un email al To. Lanza excepción sino es un email
        /// </summary>
        /// <param name="email"></param>
        /// <exception cref="ex">Exception</exception>
        public void AddTo( string email )
        {
            if( !HelperValidate.IsEmail( email ) ) {
                throw new Exception( "La dirección de correo TO no es un email válido (FactoryMail: AddTo)" );
            }
            this.Correo.To.Add( new MailAddress( email) );
        }

        /// <summary>
        /// Añade un email y descripción al To. Lanza excepción sino es un email
        /// </summary>
        /// <param name="email"></param>
        /// <param name="displayName"></param>
        public void AddTo( string email, string displayName )
        {
            if( !HelperValidate.IsEmail( email ) ) {
                throw new Exception( "La dirección de correo TO no es un email válido (FactoryMail: AddTo)" );
            }
            this.Correo.To.Add( new MailAddress( email, displayName, System.Text.Encoding.Default) );
        }

        /// <summary>
        /// Añade un emaail al CC. Lanza excepción sino es un email
        /// </summary>
        /// <param name="email"></param>
        /// <exception cref="ex">Exception</exception>
        public void AddCC( string email)
        {
            if( !HelperValidate.IsEmail( email ) ) {
                throw new Exception( "La dirección de correo CC no es un email válido (AtxMail: AddCC)" );
            }
            this.Correo.CC.Add( new MailAddress( email) );
        }

        /// <summary>
        /// Añade un emaail al CCO. Lanza excepción sino es un email
        /// </summary>
        /// <param name="email"></param>
        /// <exception cref="ex">Exception</exception>
        public void AddCCO( string email )
        {
            if( !HelperValidate.IsEmail( email ) ) {
                throw new Exception( "La dirección de correo CCO no es un email válido (AtxMail: AddCCO)" );
            }
            this.Correo.Bcc.Add( new MailAddress(email) );
        }

        /// <summary>
        /// Envia el correo. Lanza una excepción si no se ha enviado
        /// </summary>
        /// <exception cref="ex">Exception</exception>
        public virtual void Send( )
        {
            try {
                this.Correo.Body = this._HtmlBody;
                this.Smtp.Send( this.Correo );
            } catch( SmtpException ex ) {
                throw new Exception( "Imposible enviar el email por error SMTP (FactoryMail: Send):"+ ex.Message, ex );
            } catch( Exception ex ) {
                throw new Exception( "Imposible enviar el email (FactoryMail: Send): " + ex.Message, ex );
            }
        }

        /// <summary>
        /// Envio con delegado
        /// </summary>
        public void SendDelegate( )
        {
            try {
                this.Correo.Body = this._HtmlBody;
                // Invocamos el delegado
                DelegateEmailSend delEmailSend = SendingByDelegate;
                delEmailSend.BeginInvoke( this.Smtp, this.Correo, null, null );
            } catch( Exception ex ) {
                throw new Exception( "Imposible enviar el email delegate (FactoryMail: Send): " + ex.Message, ex );
            }
        }

        /// <summary>
        /// Declaración del delegado par aenviar el email
        /// </summary>
        /// <param name="smtp"></param>
        /// <param name="correo"></param>
        private delegate void DelegateEmailSend( SmtpClient smtp, MailMessage correo );

        /// <summary>
        /// Función que envia el email en delegado
        /// </summary>
        /// <param name="smtp"></param>
        /// <param name="correo"></param>
        private static void SendingByDelegate( SmtpClient smtp, MailMessage correo )
        {
            try {
                smtp.Send( correo );
            } catch( SmtpException ex ) {
                string err = "Imposible enviar el email por error SMTP (FactoryMail: Send):" + ex.Message;
                SaveError( err);
                throw new Exception( err, ex );
            } catch( Exception ex ) {
                string err = "Imposible enviar el email (FactoryMail: Send): " + ex.Message;
                SaveError( err );
                throw new Exception( err, ex );
            }
        }

        /// <summary>
        /// Función que guarda un error ocurrido en un delegate
        /// </summary>
        /// <param name="sErrMsg"></param>
        private static void SaveError( string sErrMsg )
        {
            System.DateTime dt = System.DateTime.Now;
            string sYear = dt.ToString( "yyyy" );
            string sMonth = dt.ToString( "MM" );
            string sDay = dt.ToString( "dd" );

            string sErrorTime =  "EmailError_" + sYear + "_" + sMonth + "_" + sDay;

            // Obtener todo lo de la session
            string date = DateTime.Now.ToShortDateString( ) + " " + DateTime.Now.ToShortTimeString( );

            string fileLog = sErrorTime + ".txt";
            try {
                StreamWriter sw = new StreamWriter( fileLog, true );
                sw.WriteLine( date + ": " + sErrMsg );
                sw.Flush( );
                sw.Close( );
            } catch( Exception ex ) {
                throw new Exception( "Imposible guardar la traza (Log: Save): " + ex.Message, ex );
            }
        }
    }
}
