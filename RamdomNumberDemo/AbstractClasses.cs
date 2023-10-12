using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RamdomNumberDemo
{
    public interface IDataAccess
    {
        string LoadConnectionString(string name);
        void LoadData(string sql);
        void SaveDate(string sql);
    }


    public abstract class DataAccess
    {
        public virtual string LoadConnectionString(string name)
        {
            Console.WriteLine("Load connection string");
            return "testConnectionString";
        }

        public abstract void LoadData(string sql);
        public abstract void SaveData(string sql);
    }


    public class SqlDataAccess : DataAccess
    {
        public override string LoadConnectionString(string name)
        {
            string output = base.LoadConnectionString(name);
            output += " (from Ms Sql Server)";
            return output;
        }

        public override void LoadData(string sql)
        {
            Console.WriteLine("Loading data from Ms SQL Server");
        }

        public override void SaveData(string sql)
        {
            Console.WriteLine("Saving data to Ms. SQL Server");
        }
    }


    public class SqlliteDataAccess : DataAccess
    {
        //public string LoadConnectionString(string name)
        //{
        //    Console.WriteLine("Load connection string");
        //    return "testConnectionString";
        //}

        public override void LoadData(string sql)
        {
            Console.WriteLine("Loading Sqlite data");
        }

        public override void SaveData(string sql)
        {
            Console.WriteLine("Saving data to SqlLite");
        }
    }
}
