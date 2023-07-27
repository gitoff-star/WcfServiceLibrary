using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;


namespace WcfServiceLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
    

        public string GetData(string value)
        {
            return string.Format("You entered: {0}", value);
        }

      


        public int getAvgMarks(int s1, int s2, int s3)
        {
            return s1 + s2+s3;
        }

        int IService1.GetTotalMarks(Student s)
        {
            return s.s1 + s.s2+s.s3; 
        }
    }
}
