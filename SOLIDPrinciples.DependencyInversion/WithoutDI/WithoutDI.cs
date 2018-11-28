using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDPrinciples.DependencyInversion.WithoutDI
{
    public class BusinessLogicLayer
    {
        private readonly DataAccessLayer DAL;
        public BusinessLogicLayer()
        {
            DAL = new DataAccessLayer();
        }
        public void Save(Object details)
        {
            DAL.Save(details);
        }
    }

    public class DataAccessLayer
    {
        public void Save(object details)
        {

        }
    }
}
