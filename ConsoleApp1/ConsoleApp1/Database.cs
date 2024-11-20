using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Database<T>
    {
        private List<T> list = new List<T>();        
        public Database()
        {
           
        }

        public void AddRecord(T record)
        {
            list.Add(record);

        }

        public void RemoveRecord(int id)
        {

            foreach (T record in list)
            {

                if (record.GetType() == typeof(Student))
                {
                    if ((record as Student).Id == id)
                    {
                        this.list.Remove(record);
                        return;

                    }
                }
                if (record.GetType() == typeof(Book))
                {
                    if ((record as Book).Id == id)
                    {
                        this.list.Remove(record);
                        return;
                    }
                }
                if (record.GetType() == typeof(Employee))
                {
                    if ((record as Employee).Id == id)
                    {
                        this.list.Remove(record);
                        return;
                    }
                }
            }
        }

        public T GetRecord(int id)
        {
            foreach (T record in list)
            {
                
                if(record.GetType() == typeof(Student))
                {
                     if((record as  Student).Id == id)
                     {
                         return record;
                     }
                }
                if (record.GetType() == typeof(Book))
                {
                    if ((record as Book).Id == id)
                    {
                        return record;
                    }
                }
                if (record.GetType() == typeof(Employee))
                {
                    if ((record as Employee).Id == id)
                    {
                        return record;
                    }
                }
            }
            return default;

        } 

        public override string ToString()
        {
            string s = "";
            foreach (T record in list)
            {
                s += record + " ";
            }
            return s;
        }
    }
}
