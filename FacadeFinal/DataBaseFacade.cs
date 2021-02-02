using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeFinal
{
    public class DataBaseFacade
    {
        private CouchDB _couchDB;
        private MongoDB _mongoDB;
        private MySQLDB _mySQLDB;
        private OracleDB _oracleDB;
        private SQLiteDB _sQLiteDB;
        private SQLServerDB _sQLServerDB;

        public DataBaseFacade()
        {
            _couchDB = new CouchDB();
            _mongoDB = new MongoDB();
            _mySQLDB = new MySQLDB();
            _oracleDB = new OracleDB();
            _sQLiteDB = new SQLiteDB();
            _sQLServerDB = new SQLServerDB();
        }

        public void CouchVeriTabaninaBaglanma()
        {
            _couchDB.CouchDBBaglandi();
        }
        public void MongoVeriTabaninaBaglanma()
        {
            _mongoDB.MongoDBBaglandi();
        }
        public void MySQLVeriTabaninaBaglanma()
        {
            _mySQLDB.MySQLDBBaglandi();
        }
        public void OracleVeriTabaninaBaglanma()
        {
            _oracleDB.OracleDBBaglandi();
        }
        public void SQLiteVeriTabaninaBaglanma()
        {
            _sQLiteDB.SQLiteDBBaglandi();
        }
        public void SQLServerVeriTabaninaBaglanma()
        {
            _sQLServerDB.SQLServerDBBaglandi();
        }
    }
    
}
