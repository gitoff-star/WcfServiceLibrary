using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        string GetData(string value);

        [OperationContract]
        int GetTotalMarks(Student s); //passing object to acces subjects 


        [OperationContract]
        int getAvgMarks(int s1, int s2, int s3);


        [OperationContract]
        List<Country> GetCountries();

        // TODO: Add your service operations here
    }

    [DataContract]
    public class Country
    {
        [DataMember]
        public int CountryId { get; set; }    
        [DataMember]
        public string CountryName { get; set; } 
    }

    [DataContract] //DataContract is to serialze class to use it over network
   public class Student
    {
        [DataMember]  // it serialize class member to use a serialize 
        public int s1 { get; set; }
        [DataMember]
        public int s2 { get; set; }
        [DataMember]
        public int s3 { get; set; }
    }

}
