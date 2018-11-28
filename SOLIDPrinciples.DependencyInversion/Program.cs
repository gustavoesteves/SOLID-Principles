using SOLIDPrinciples.DependencyInversion.WithDI;
using System;

namespace SOLIDPrinciples.DependencyInversion
{
    class Program
    {
        static void Main(string[] args)
        {
            object obj = new object();
            DataAccessLayer dal = new DataAccessLayer();
            // DALSQLServer dalSqlServer = new DALSQLServer();
            BusinessLogicLayer bll = new BusinessLogicLayer(dal);
            bll.Save(obj);
        }
    }
}
