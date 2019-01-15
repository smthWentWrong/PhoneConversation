using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace PhoneConversation
{
    public  class SerealizeJson: ISerealize
    {
        //static string defaultPath = @"D:\3семестр\ООП\PhoneConversation\PhoneConversation\Objects";
        public void Save(Client client,string str)
        {
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(List<Client>));

            using (FileStream fs = new FileStream("ClientJson.json", FileMode.OpenOrCreate))
            {
                jsonFormatter.WriteObject(fs,client.contacts );
            }
        }
        public void Load(Client client,string str)
        {
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(List<Client>));
            using (FileStream fs = new FileStream("ClientJson.json", FileMode.OpenOrCreate))
            {
                List<Client> helpList = ((List<Client>)jsonFormatter.ReadObject(fs));
                client.contacts = helpList;

            }
        }

    }
}
