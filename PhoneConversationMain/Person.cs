using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace PhoneConversation
{
    [DataContractAttribute,Serializable]
    public class Person
    {
        [DataMember]
        private string firstName;
        
        public string FirstName {
            get { return firstName; }
            set { firstName = value; }
        }
        [DataMember]
        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public Person(string FirstName,string LastName)
        {
            firstName = FirstName;
            lastName = LastName;
        }

        public Person(string firstName)
        {
            this.firstName = firstName;
        }
    }
}
