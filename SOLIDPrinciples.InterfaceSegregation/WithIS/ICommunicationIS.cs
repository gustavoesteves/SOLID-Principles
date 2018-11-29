using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDPrinciples.InterfaceSegregation.WithIS
{
    public interface IEmail
    {
        bool SendEmail(string content);
    }

    public interface ICellphone
    {
        bool SendSMS(string content);
        bool SendWhatsAppMessage(string content);
    }

    public interface IPager
    {
        bool SendPager(string content);
    }
}
