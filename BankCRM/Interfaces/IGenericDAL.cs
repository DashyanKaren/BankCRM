using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankCRM.Interfaces
{
    public interface IGenericDAL
    {
        void AddEntity<T>(T entity, string tableName, string[] propertyNames, object[] propertyValues);
        public void UpdateEntity<T>(T entity, string tableName, string[] propertyNames, object[] propertyValues, string idPropertyName, object idPropertyValue);


        public void DeleteEntity<T>(string tableName, string idPropertyName, object idPropertyValue);

        public T GetEntity<T>(string tableName, string idPropertyName, object idPropertyValue);
       
    }
}
