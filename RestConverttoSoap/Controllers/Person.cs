using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Xml.Linq;

namespace RestConverttoSoap.Controllers
{
    [DataContract]
    public class Person
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Surname { get; set; }
    }

    [ServiceContract]
    public interface IPersonService
    {
        [OperationContract]
        string Test(string s);

        [OperationContract]
        void XmlMethod(System.Xml.Linq.XElement xml);

        [OperationContract]
        List<Person> TestCustomModel(Person inputModel);
    }

    public class PersonService : IPersonService
    {
        public string Test(string s)
        {
            Console.WriteLine("Test Method Executed!");
            return s;
        }

        public List<Person> TestCustomModel(Person inputModel)
        {
            return new List<Person>(new[]
            {
                new Person{Id=1,Name="name1",Surname="surname1"},
                new Person{Id=2,Name="name2",Surname="surname2"},
                new Person{Id=3,Name="name3",Surname="surname3"},
                new Person{Id=4,Name="name4",Surname="surname4"},
                new Person{Id=5,Name="name5",Surname="surname5"},
                new Person{Id=6,Name="name6",Surname="surname6"}
         });
        }

        public void XmlMethod(XElement xml)
        {
            Console.WriteLine(xml.ToString());
        }
    }
}