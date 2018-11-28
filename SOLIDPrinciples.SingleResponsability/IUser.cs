using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDPrinciples.SingleResponsability
{
    interface IUser
    {
        bool Login(string username, string password);
        bool Register(string username, string password, string email);
        /* 
         * SendEmail and LogError shouldn't be part of User interface.
         * Instead we'll have to create to new interfaces.
         * Breaking the interface to do just what that should do, is the Single Responsibility. 
         */
        // bool SendEmail(string emailContent);
        // void LogError(string error); 
    }

    interface IEmail
    {
        bool SendEmail(string emailContent);
    }

    interface ILogger
    {
        void LogError(string error);
    }
}
