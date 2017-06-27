using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalLib.Controler
{
    /*
    * Class para lidar com algumas exceções do banco
    * Criado pelo professor Alex
    */
    public class DataBaseException : Exception
    {
        public DataBaseException() { }
        public DataBaseException(string message) : base(message)
        {
        }

        public DataBaseException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }

    class Util
    {
        public static void HandleSQLDBException(Exception exception)
        {
            DbUpdateConcurrencyException concurrencyEx = exception as DbUpdateConcurrencyException;
            if (concurrencyEx != null)
            {
                throw new DataBaseException();
            }

            DbUpdateException dbUpdateEx = exception as DbUpdateException;
            if (dbUpdateEx != null)
            {
                if (dbUpdateEx.InnerException != null
                        && dbUpdateEx.InnerException.InnerException != null)
                {
                    SqlException sqlException = dbUpdateEx.InnerException.InnerException as SqlException;
                    if (sqlException != null)
                    {
                        switch (sqlException.Number)
                        {
                            case 2627:
                                throw new DataBaseException("O valor inserido está duplicando alguma propriedade única.");   // A custom exception of yours for concurrency issues
                            case 547:
                                throw new DataBaseException("O valor inserido náo respeita alguma restrição específica do modelo.");   // A custom exception of yours for concurrency issues
                            case 2601:
                                throw new DataBaseException("O valor inserido está duplicando alguma propriedade única, possívelmente a chave primária.");   // A custom exception of yours for concurrency issues

                            default:
                                throw new DataBaseException(dbUpdateEx.Message, dbUpdateEx.InnerException);
                        }
                    }

                    throw new DataBaseException(dbUpdateEx.Message, dbUpdateEx.InnerException);
                }
            }
        }
    }
}
