using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PhoneConversation
{
    [DataContractAttribute,Serializable]
    public abstract class Base<T> where T : Base<T> 
    {
        [DataMember]
        public static List<T> Items = new List<T>();

        public Base() : this("") {
        }

        public Base(string name)
        {
            Items.Add((T)this);
            
        }


    }
}
