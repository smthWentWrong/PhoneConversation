using PhoneConversation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Json;
using System.Xml;

namespace PhoneConversation
{
    public class SerealizeXml : ISerealize
    {
        string DefaultPath = @"D:\3семестр\ООП\PhoneConversation\PhoneConversation\Objects";

        public void SaveClient(Client cl)
        {
                DataContractSerializer dcs = new DataContractSerializer(typeof(List<Client>));
                XmlWriter xmlw = XmlWriter.Create("Client.xml");
                dcs.WriteObject(xmlw, cl.contacts);
                xmlw.Close();
        }

        public void LoadClient(Client cl)
        {
            DataContractSerializer dcs = new DataContractSerializer(typeof(List<Client>));
            XmlReaderSettings settings = new XmlReaderSettings();
            XmlReader xmlr = XmlReader.Create("Client.xml", settings);
            cl.contacts = (List<Client>)dcs.ReadObject(xmlr);
            xmlr.Close();
        }

        public  void Save(Client cl, string str)
        {


            if (str.Equals("Replenishment"))
            {
                DataContractSerializer dcs = new DataContractSerializer(typeof(List<Replenishment>));
                XmlWriter xmlw = XmlWriter.Create("Replenishment.xml");
                dcs.WriteObject(xmlw, cl.replenishments);
                xmlw.Close();
            }
            else if (str.Equals("Block"))
            {
                DataContractSerializer dcs = new DataContractSerializer(typeof(List<Block>));
                XmlWriter xmlw = XmlWriter.Create("Block.xml");
                dcs.WriteObject(xmlw, cl.blocks);
                xmlw.Close();
            } else if (str.Equals("Call"))
            {
                DataContractSerializer dcs = new DataContractSerializer(typeof(List<Call>));
                XmlWriter xmlw = XmlWriter.Create("Call.xml");
                dcs.WriteObject(xmlw, Call.Items);
                xmlw.Close();
            }
            else if (str.Equals("Operator"))
            {
                DataContractSerializer dcs = new DataContractSerializer(typeof(List<Operator>));
                XmlWriter xmlw = XmlWriter.Create("Operator.xml");
                dcs.WriteObject(xmlw, Operator.Items);
                xmlw.Close();
            }
            else if (str.Equals("Tariff"))
            {
                DataContractSerializer dcs = new DataContractSerializer(typeof(List<Tariff>));
                XmlWriter xmlw = XmlWriter.Create("Tariff.xml");
                dcs.WriteObject(xmlw, Tariff.Items);
                xmlw.Close();
            }
            

        }
        public void Load(Client cl,string str)
        {
            if (str.Equals("Replenishment")) 
            {
                DataContractSerializer dcs = new DataContractSerializer(typeof(List<Replenishment>));
                XmlReaderSettings settings = new XmlReaderSettings();
                XmlReader xmlr = XmlReader.Create("Replenishment.xml", settings);
                cl.replenishments = (List<Replenishment>)dcs.ReadObject(xmlr);
                xmlr.Close();
            }else if (str.Equals("Block") )
            {
                DataContractSerializer dcs = new DataContractSerializer(typeof(List<Block>));
                XmlReaderSettings settings = new XmlReaderSettings();
                XmlReader xmlr = XmlReader.Create("Block.xml", settings);
                cl.blocks = (List<Block>)dcs.ReadObject(xmlr);
                xmlr.Close();
            }
            else if ( str.Equals("Call"))
            {
                DataContractSerializer dcs = new DataContractSerializer(typeof(List<Call>));
                XmlReaderSettings settings = new XmlReaderSettings();
                XmlReader xmlr = XmlReader.Create("Call.xml", settings);
                Call.Items = (List<Call>)dcs.ReadObject(xmlr);
                xmlr.Close();
            }
            else if (str.Equals("Operator"))
            {
                DataContractSerializer dcs = new DataContractSerializer(typeof(List<Operator>));
                XmlReaderSettings settings = new XmlReaderSettings();
                XmlReader xmlr = XmlReader.Create("Operator.xml", settings);
                Operator.Items = (List<Operator>)dcs.ReadObject(xmlr);
                xmlr.Close();
            }
            else if (str.Equals("Tariff"))
            {
                DataContractSerializer dcs = new DataContractSerializer(typeof(List<Tariff>));
                XmlReaderSettings settings = new XmlReaderSettings();
                XmlReader xmlr = XmlReader.Create("Tariff.xml", settings);
                Tariff.Items = (List<Tariff>)dcs.ReadObject(xmlr);
                xmlr.Close();
            }
        }
        //public static void LoadInformationTxt()
        //{
        //    IFormatter formatter = new BinaryFormatter();

        //    Stream stream = new FileStream(@"D:\Users.txt", FileMode.Open, FileAccess.Read);
        //    Users objnew = (Users)formatter.Deserialize(stream);
        //    Users.users.Add(objnew);

        //}
        //public static void LoadInformationJson()
        //{
        //    DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(List<Users>));
        //    using (FileStream fs = new FileStream("UsersJson.Json", FileMode.OpenOrCreate))
        //    {
        //        List<Users> helpList = ((List<Users>)jsonFormatter.ReadObject(fs));
        //        Users.users = helpList;

        //    }
        //}
    }
}
