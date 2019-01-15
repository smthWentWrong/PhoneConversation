using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace PhoneConversation
{
    public class SerealizeTxt : ISerealize
    {
        public void Save(Client client,string str)
        {
            IFormatter formatter = new BinaryFormatter();
           // BinaryFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("Client.txt", FileMode.OpenOrCreate, FileAccess.Write);

            formatter.Serialize(stream, client.contacts);
            stream.Close();
        }

        public void Load(Client client,string str)
        {
            IFormatter formatter = new BinaryFormatter();

            Stream stream = new FileStream("Client.txt", FileMode.Open, FileAccess.Read);
            client.contacts = (List<Client>)formatter.Deserialize(stream);
            //Users.users.Add(objnew);

        }
    }
}
