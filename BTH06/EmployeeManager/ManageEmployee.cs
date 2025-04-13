using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace EmployeeManager
{
    internal class ManageEmployee
    {
        private List<Employee> employees = new List<Employee>();

        public List<Employee> Employees {  get { return employees; } }

        public void add(Employee employee)
        {
            employees.Add(employee);
        }

        public void serialization(string fileName)
        {
            FileStream stream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(stream, employees);
;       }

        public void deserialization(string fileName)
        {
            FileStream stream;
            try
            {
                stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                BinaryFormatter bf = new BinaryFormatter();
                employees = (List<Employee>)bf.Deserialize(stream);
                //stream.Close();
            }
            catch
            {

            }
            finally
            {
                //stream.Close();
            }
        }
    }
}
