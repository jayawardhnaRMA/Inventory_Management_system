using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using ShopManagementSystem.Exceptions;
using ShopManagementSystem.Models;

namespace ShopManagementSystem.DataAccess
{
    // Generic CRUD implementation. Subclasses only supply the stored procedure names
    // and how to convert between their model and the database.
    public abstract class BaseDAL<T> : DataAccessBase, IRepository<T> where T : Entity
    {
        protected abstract string GetAllProcedure { get; }
        protected abstract string SearchProcedure { get; }
        protected abstract string AddProcedure { get; }
        protected abstract string UpdateProcedure { get; }
        protected abstract string DeleteProcedure { get; }
        protected abstract string IdParameter { get; }

        // Builds a model object from one database row.
        protected abstract T MapRow(DataRow row);

        // Adds the parameters shared by the insert and update procedures.
        protected abstract void AddParameters(SqlCommand cmd, T entity);

        // Update needs the ID as well; subclasses can override to add extra fields.
        protected virtual void AddUpdateParameters(SqlCommand cmd, T entity)
        {
            cmd.Parameters.AddWithValue(IdParameter, entity.Id);
            AddParameters(cmd, entity);
        }

        public List<T> GetAll()
        {
            return MapRows(ExecuteQuery(GetAllProcedure));
        }

        public List<T> Search(string keyword)
        {
            return MapRows(ExecuteQuery(SearchProcedure, cmd => cmd.Parameters.AddWithValue("@Keyword", keyword)));
        }

        public bool Add(T entity)
        {
            entity.Validate();
            return ExecuteNonQuery(AddProcedure, cmd => AddParameters(cmd, entity)) > 0;
        }

        public bool Update(T entity)
        {
            if (entity.IsNew)
                throw new ValidationException("Please select a record to update.");

            entity.Validate();
            return ExecuteNonQuery(UpdateProcedure, cmd => AddUpdateParameters(cmd, entity)) > 0;
        }

        public bool Delete(int id)
        {
            return ExecuteNonQuery(DeleteProcedure, cmd => cmd.Parameters.AddWithValue(IdParameter, id)) > 0;
        }

        private List<T> MapRows(DataTable table)
        {
            List<T> items = new List<T>();
            foreach (DataRow row in table.Rows)
            {
                items.Add(MapRow(row));
            }
            return items;
        }
    }
}
