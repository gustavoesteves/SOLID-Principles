using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDPrinciples.InterfaceSegregation.WithoutIS
{
    public interface ICommunication
    {
        bool SendEmail(string content);
        bool SendSMS(string content);
        bool SendWhatsAppMessage(string content);
        bool SendPager(string content);
    }
}
