using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDPrinciples.DependencyInversion.WithDI
{
    public class BusinessLogicLayer
    {
        private readonly IRepositoryLayer DAL;
        public BusinessLogicLayer(IRepositoryLayer repositoryLayer)
        {
            DAL = repositoryLayer;
        }
        public void Save(Object details)
        {
            DAL.Save(details);
        }
    }

    public interface IRepositoryLayer
    {
        void Save(Object details);
    }

    public class DataAccessLayer : IRepositoryLayer
    {
        public void Save(object details)
        {
            Console.WriteLine("DAL");
        }
    }

    public class DALSQLServer : IRepositoryLayer
    {
        public void Save(object details)
        {
            Console.WriteLine("SQLServer");
        }
    }
}
