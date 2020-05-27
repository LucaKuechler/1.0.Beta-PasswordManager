using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Manager
{
    public class Mail
    {

        #region DataMail
        public string MailName {get; set; }
        public int Mail_ID { get; set; }
        public int realMail_ID { get; set; }
        #endregion


        #region constructor Mail
        public Mail(int realMail_ID, string MailName, int Mail_ID)
        {
            this.MailName = MailName;
            this.Mail_ID = Mail_ID;
            this.realMail_ID = realMail_ID;
        }
        #endregion

    }
}
