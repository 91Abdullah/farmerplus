using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Configuration;

namespace FarmerPlusDataAccessLayer
{
    public class DBUtility
    {
        #region Class Variables
        // database object
        Database _db;
        // command object 
        DbCommand _dbCommand;        
        // Time out for the Command Execution
        const int _commandTimeout = 200; //Later on will fetch this from config
        //Connection
        DbConnection _connection = null;
        //Transaction        
        DbTransaction _transaction = null;        
        #endregion

        #region Contruction/Destruction
        /// <summary>
        /// Constructor of utility
        /// </summary>
        public DBUtility()
        {            
            // Create the Database object, using the default database service.            
            //"ConnectionString"
            _db = DatabaseFactory.CreateDatabase
                ("ConnectionString");
            _connection = _db.CreateConnection();
            //_connection.Open();
        }       
		public DBUtility(string DatabaseName)
		{			
			// Create the Database object, using the name provided.            
            _db = DatabaseFactory.CreateDatabase(DatabaseName);
            _connection = _db.CreateConnection();
            //_connection.Open();		
		}	
		~DBUtility()
		{
            try
            {
                if (_connection.State == ConnectionState.Open)
                {
                    //_connection.Close();
                    //_connection.Dispose();
                    _connection = null;
                    _db = null;
                    _dbCommand = null;
                }               
            }
            catch (Exception ex)
            {
                _db = null;
                _dbCommand = null;
                _connection = null;
                throw ex;
            }
		}
        #endregion      

        #region Methods Related to DataSet
        /// <summary>
        /// Get the dataSet from the DataBase through EL DataAccess Block
        /// </summary>
        /// <param name="storedProcName"> The stored procedure Name to be executed</param>
        /// <param name="values">Values of the parameter objects</param>
        /// <returns> Dataset containing the results from DataBase</returns>
        public DataSet GetDataSet(string storedProcName, object[] values)
        {
            // DataSet that will hold the returned results		
            DataSet _ds = null;
            try
            { 
                // call the method to get the dataset from DB 
                _connection.Open();
                Object[] param = new Object[values.Length+1];
                for (int i = 0; i < values.Length; i++)
                {
                    param[i+1] = values[i];
                }
                 _ds = _db.ExecuteDataSet(storedProcName,param);
                 _connection.Close();

            }
            catch (Exception exDataSetExecution)
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
                // exception occurs whule getting the dataset
                throw exDataSetExecution;

                //CommonUtility.LoggExceptionInXMLFile(exDataSetExecution.ToString());
            }
            
            //returns the data set 
            return _ds;
        }
        
        public DataSet GetDataSet(string storedProcName)
        {
            // DataSet that will hold the returned results		
            DataSet _ds = null;          

            try
            {
                // call the method to get the dataset from DB 
                _connection.Open();
                object[] param = new object[1];
                _ds = _db.ExecuteDataSet(storedProcName, param);
                _connection.Close();
            }
            catch (Exception exDataSetExecution)
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
                // exception occurs whule getting the dataset
                 throw exDataSetExecution;
                //CommonUtility.LoggExceptionInXMLFile(exDataSetExecution.ToString());
            }

            //returns the data set 
            return _ds;
        }
        #endregion

        #region Methods Related to DataReader
        /// <summary>
        /// Get the DataReader from the DataBase through EL DataAccess Block
        /// </summary>
        /// <param name="storedProc"> The stored procedure Name to be executed</param>
        /// <param name="values">Values of the parameter objects</param>
        /// <returns> DataReader containing the results from DataBase</returns>
        public IDataReader GetDataReader(string storedProc, object[] values)
        {
             // IDataReader that will hold the returned results		
            IDataReader _dr = null;

           try
            {
                object[] param = new object[values.Length+1];
                //GetDBType(values.GetValue(1).GetType().Name);
                for (int i = 0; i < values.Length; i++)
                {
                   
                    param[i+1] = values[i].ToString();
                }

                _dr = _db.ExecuteReader(storedProc,param);
            }
            catch (Exception exDataReaderExecution)
            {
                // exception occurs whule getting the dataset
                throw exDataReaderExecution;
                //CommonUtility.LoggExceptionInXMLFile(exDataReaderExecution.ToString());
            }

            //returns the dataReader 
            return _dr;
        }
        /// <summary>
        /// Get the DataReader from the DataBase through EL DataAccess Block
        /// </summary>
        /// <param name="storedProc"> The stored procedure Name to be executed</param>       
        /// <returns> DataReader containing the results from DataBase</returns>
        public IDataReader GetDataReader(string storedProc)
        {
             // DataReader that will hold the returned results		
            IDataReader _dr = null;         

            try
            {
                // call the method to get the DataReader from DB 
                 object[] param = new object[1];
                _dr = _db.ExecuteReader(storedProc, param);
            }
            catch (Exception exDataReaderExecution)
            {
                // exception occurs whule getting the dataReader
                throw exDataReaderExecution;
               // CommonUtility.LoggExceptionInXMLFile(exDataReaderExecution.ToString());
            }

            //returns the DataReader 
            return _dr;
        }
        #endregion

        #region Methods Related to InLine SQL

        #endregion 

        #region Methods Related to Single Item
        /// <summary>
        /// Retrieves the Single Item returned from Database.
        /// </summary>
        /// <param name="StoredProcParam">The Parameter to send the Stored Procedure</param>
        /// <param name="parameter_Name">The Parameter Name in  Stored Procedure</param>
        /// <returns>Single Item returned by the Stored Procedure</returns>       

        public object GetSingleItemFromSP(string storedProcName,String outParameter)
        {
            
            // Object to hold the value returned
             object retVal = null;
             try
             {
                     _connection.Open();

                 _dbCommand = _db.GetStoredProcCommand(storedProcName);


                 _db.AddOutParameter(_dbCommand, outParameter, DbType.String, 30);
                 _db.ExecuteScalar(_dbCommand);

                 retVal = _dbCommand.Parameters[outParameter].Value;
                 if (_connection.State == ConnectionState.Open)
                     _connection.Close();
                
             }
             catch (Exception ee)
             {
                 if (_connection.State == ConnectionState.Open)
                     _connection.Close();
                 throw ee;
                 //CommonUtility.LoggExceptionInXMLFile(ee.ToString());
             }
             return retVal;
        }
        public object GetSingleItemFromSP(string storedProcName, string outParameter,DbType sType, string inParameter, object value)
        {

            // Object to hold the value returned
            object retVal = null;
            try
            {
                    _connection.Open();
                _dbCommand = _db.GetStoredProcCommand(storedProcName);



                _db.AddInParameter(_dbCommand, inParameter,GetDBType(value.GetType().Name),value);
                _db.AddOutParameter(_dbCommand, outParameter, sType, 30);
                _db.ExecuteScalar(_dbCommand);

                retVal = _dbCommand.Parameters[outParameter].Value;
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
            }
            catch (Exception ee)
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
                throw ee;
               // CommonUtility.LoggExceptionInXMLFile(ee.ToString());  
            }
            return retVal;
        }

        #endregion

        #region Methods to Execute Stored Procedures
       
        public DataSet GetDataSetCustom(string spName, object paramValue)
        {
             DataSet Ds =null;
            try
            {
                    _connection.Open();

                object[] param = new object[2];
                param[1] = paramValue.ToString();
                Ds  = _db.ExecuteDataSet(spName, param);
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
                
                 
            }

            catch (Exception ee)
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
                throw ee;
                //CommonUtility.LoggExceptionInXMLFile(ee.ToString());
            }
            return Ds;

        }

        public DataSet GetDataSetForMultiInputCustom(string spName, object[] paramValue)
        {
            DataSet _ds = null;

            try
            {
                    _connection.Open();

                // call the method to get the dataset from DB 
                Object[] param = new Object[paramValue.Length + 1];
                for (int i = 0; i < paramValue.Length; i++)
                {
                    GetDBType(paramValue.GetValue(i).GetType().Name);
                    param[i + 1] = paramValue[i].ToString();

                }

                _ds = _db.ExecuteDataSet(spName, param);
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
           

            }
            catch (Exception exDataSetExecution)
            {
                // exception occurs whule getting the dataset
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
                 throw exDataSetExecution;
                //CommonUtility.LoggExceptionInXMLFile(exDataSetExecution.ToString());
            }
            return _ds;
        }

        public void ExecuteNoneQueryCustom(string spName, object[] paramValue)
        {
            try
            {
                    _connection.Open();


                _db.ExecuteNonQuery(spName, paramValue);
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();


            }
            catch (Exception eee)
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
                throw eee;
                //CommonUtility.LoggExceptionInXMLFile(eee.ToString());
            }
        }

        public bool ExecuteStoredProc(string storedProcName,string []inParameters, object[] values)
        {

            try
            {
                    _connection.Open();
                _dbCommand = _db.GetStoredProcCommand(storedProcName);
                if (inParameters.Length != values.Length)
                    return false;
                for (int index = 0; index < values.Length; index++)
                {
                    _db.AddInParameter(_dbCommand, inParameters[index], GetDBType(values[index].GetType().ToString()), values[index]);
                }
               
                _db.ExecuteNonQuery(_dbCommand);
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();

            }
            catch (Exception exNonQueryExecution)
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
                // exception occurs 
                throw exNonQueryExecution;
                //CommonUtility.LoggExceptionInXMLFile(exNonQueryExecution.ToString());
            }

            return true;


        }

       

        public bool ExecuteStoredProc(string storedProcName, object[] values )
        {
           
              try
            {
                // make the command object null, can be use for this method
                    _connection.Open();
                _dbCommand = null;

                // Get the stored procedure command object
                _dbCommand = _db.GetStoredProcCommand(storedProcName);

                // set the default time out for the command to be executed
                _dbCommand.CommandTimeout = _commandTimeout;

                    Object[] param = new Object[values.Length];
                for (int i = 0; i < values.Length; i++)
                {
                    GetDBType(values.GetValue(i).GetType().Name);
                    param[i] = values[i];
                }

                    _db.ExecuteNonQuery(storedProcName,param);
                    if (_connection.State == ConnectionState.Open)
                        _connection.Close();
                
                return true;
            }
            catch (Exception ex)
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
                // exception occurs 
                throw ex;
                //CommonUtility.LoggExceptionInXMLFile(ex.ToString());

            }         
                
                return true;
           
                    
        }
        #endregion

        public DataSet GetDataSetWithParams(string storedProcName, object[] values)
        {
            // DataSet that will hold the returned results  
            DataSet _ds = null;
            try
            {
                    _connection.Open();
                // call the method to get the dataset from DB 

                _ds = _db.ExecuteDataSet(storedProcName, values);
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();

            }
            catch (Exception exDataSetExecution)
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
                // exception occurs whule getting the dataset
                throw exDataSetExecution;
                //CommonUtility.LoggExceptionInXMLFile(exDataSetExecution.ToString());
            }

            //returns the data set 
            return _ds;
        }


        #region Methods Related to Updates

        #endregion

        #region Methods for Transactions

        public bool CreateCommandForParams(String storedProcName, Dictionary<object, object> paramlist,out DbCommand dbCommand)
        {
            // Get the stored procedure command object
            dbCommand = _db.GetStoredProcCommand(storedProcName);

            // set the default time out for the command to be executed
            dbCommand.CommandTimeout = _commandTimeout;
            
            try
            {
                // loop to iterate the parameters                
                foreach (KeyValuePair<object, object> kvp in paramlist)
                {                   
                    // Add the parameters to command object, Param Name then Param DB type and then values
                    _db.AddInParameter(_dbCommand, (string)kvp.Key, GetDBType(kvp.Value.GetType().Name),kvp.Value);
                }
            }
            catch (Exception exParams)
            {
                // exception occurs while adding the params 
                throw exParams;            
            }
            return true;
        }
        public void ExecuteTransaction(List<DbCommand> CommandsList)
        {
            try
            {
                foreach (DbCommand dbCommand in CommandsList)
                {
                    _db.ExecuteNonQuery(dbCommand,_transaction);
                }
                _transaction.Commit();
            }
            catch (Exception exNonQueryExecution)
            {
                _transaction.Rollback();
                throw exNonQueryExecution;                
            }           
        }
        #endregion

        #region Helper Methods
        /// <summary>
        /// To get the DBType object for command params
        /// </summary>
        /// <param name="strType"> Data type in the form of string</param>
        /// <returns>returns the database type for DBCommand params</returns>
        internal  DbType GetDBType(string strType)
        {
            if (strType.IndexOf("System") > -1)
                strType = strType.Remove(0, 7);
            switch (strType.Trim())
            {
                case "Binary":
                    return System.Data.DbType.Binary;

                case "Boolean":
                    return System.Data.DbType.Boolean;

                case "Byte":
                    return System.Data.DbType.Byte;

                case "Currency":
                    return System.Data.DbType.Currency;

                case "Date":
                    return System.Data.DbType.Date;

                case "DateTime":
                    return System.Data.DbType.DateTime;

                case "Decimal":
                    return System.Data.DbType.Decimal;

                case "Double":
                    return System.Data.DbType.Double;

                case "Int16":
                    return System.Data.DbType.Int16;

                case "Int32":
                    return System.Data.DbType.Int32;

                case "Int64":
                    return System.Data.DbType.Int64;

                case "SByte":
                    return System.Data.DbType.SByte;

                case "Single":
                    return System.Data.DbType.Single;

                case "String":
                    return System.Data.DbType.String;

                case "StringFixedLength":
                    return System.Data.DbType.StringFixedLength;

                case "Time":
                    return System.Data.DbType.Time;

                case "UInt16":
                    return System.Data.DbType.UInt16;

                case "UInt32":
                    return System.Data.DbType.UInt32;

                case "UInt64":
                    return System.Data.DbType.UInt64;

                case "VarNumeric":
                    return System.Data.DbType.VarNumeric;
                case "Byte[]":
                    return System.Data.DbType.Guid;
                case "Guid":
                    return System.Data.DbType.Guid;
                default:
                    return System.Data.DbType.Int64;
            }
        }
        #endregion

        public object SingleOutputForMultipuleInputs(string storedProcName, string outParameter,string[] inParameters, DbType sType,object[] values)
        {          

            object retVal = null;
            try
            {
                _connection.Open();
                _dbCommand = _db.GetStoredProcCommand(storedProcName);


                for (int index = 0; index < values.Length; index++)
                {                    
                    _db.AddInParameter(_dbCommand,inParameters[index], GetDBType(values[index].GetType().ToString()), values[index]);
                }
               
                _db.AddOutParameter(_dbCommand, outParameter, sType, 30);
                _db.ExecuteScalar(_dbCommand);

                retVal = _dbCommand.Parameters[outParameter].Value;
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
            }
            catch (Exception ee)
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
                 throw ee;
                //CommonUtility.LoggExceptionInXMLFile(ee.ToString());
            }
            return retVal;
        }

        #region For Queries

        public DataSet GetDataSetFromQuery(string queryString)
        {
            // DataSet that will hold the returned results		
            DataSet _ds = null;

            try
            {
                // call the method to get the dataset from DB 
                _connection.Open();
                object[] param = new object[1];
                DbCommand _dbCommandForQueries = _db.GetSqlStringCommand(queryString);

                _ds = _db.ExecuteDataSet(_dbCommandForQueries);
                _connection.Close();
            }
            catch (Exception exDataSetExecution)
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
                // exception occurs whule getting the dataset
                throw exDataSetExecution;
                //CommonUtility.LoggExceptionInXMLFile(exDataSetExecution.ToString());
            }

            //returns the data set 
            return _ds;
        }

        #endregion
    }  
}
