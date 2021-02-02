using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            DataBaseFacade dataBaseFacade = new DataBaseFacade();

            string secilenDB;
            Console.WriteLine("Couch DB Mongo DB MySQL DB Oracle DB SQLite DB SQLServer DB");
            Console.WriteLine("Veriyi cekmek istediginiz veri tabani uygulamasini seciniz: ");
            secilenDB=Console.ReadLine();
            
            Console.WriteLine("Cekmek istediginiz verinin linkini veya adresini giriniz: ");
            Console.ReadLine();
            if (secilenDB == "Couch DB")
            {
                dataBaseFacade.CouchVeriTabaninaBaglanma();
                Console.ReadLine();
            }
            else if (secilenDB == "Mongo DB")
            {
                dataBaseFacade.MongoVeriTabaninaBaglanma();
                Console.ReadLine();
            }
            else if(secilenDB=="MySQL DB")
            {
                dataBaseFacade.MySQLVeriTabaninaBaglanma();
                Console.ReadLine();
            }
            else if(secilenDB=="Oracle DB")
            {
                dataBaseFacade.OracleVeriTabaninaBaglanma();
                Console.ReadLine();
            }
            else if(secilenDB=="SQLite DB")
            {
                dataBaseFacade.SQLiteVeriTabaninaBaglanma();
                Console.ReadLine();
            }
            else if(secilenDB=="SQLServer DB")
            {
                dataBaseFacade.SQLServerVeriTabaninaBaglanma();
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Hatali secim yaptiniz. Program sonlanacaktir.");
                Console.ReadLine();
            }
        }
    }
}
