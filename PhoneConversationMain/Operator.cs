using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace PhoneConversation
{
    [DataContractAttribute,Serializable]

    public class Operator : Base<Operator>, ICloneable
    {
        private List<Client> clients;
        [DataMember]
        private List<Tariff> tariffs;
        [DataMember]
        private string name;
        [DataMember]
        private string numbId;
        [DataMember]
        private readonly Guid id;

        public Guid Id
        {
            get { return id; }
        }
        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        public List<Tariff> Tariffs
        {
            get { return tariffs; }
            set { tariffs = value;
            }
        }

        public List<Client> Clients
        {
            get { return clients; }
            set
            {
                clients = value;
            }
        }
        public string NumbId
        {
            get { return numbId; }
            set { numbId = value; }
        }

        public Tariff Tariff
        {
            get => default;
            set
            {
            }
        }

        public Operator(string name,string numbIden): base(name)
        {
            this.name = name;
            this.numbId = numbIden;
            tariffs = new List<Tariff>();
            clients = new List<Client>();
            id = Guid.NewGuid();
        }
        ~Operator()
        {

        }

        public Operator(string name) : base(name)
        {
            this.name = name;
            tariffs = new List<Tariff>();
            clients = new List<Client>();
            id = Guid.NewGuid();
        }
        public Operator()
        {

        }

        public void AddClient(Client cl)
        {
            clients.Add(cl);
            cl.CurrentOperator = this;
        }
        public void DeleteClient(Client cl)
        {
            clients.Remove(cl);
            cl.CurrentOperator = null;
        }

        public void AddTariff(Tariff tar)
        {
            tariffs.Add(tar);
            tar.Operator = this;
            
        }
        public void DeleteTariff(Tariff tar)
        {
            tariffs.Remove(tar);
        }

        public void BlockUser(Client cl,string reason)
        {
            cl.SetBlock = new Block(reason,cl);
        }
        //перегрузка метода
        public void CreateTariff()
        {
            Tariff tar = new Tariff("Unbeliveble");
            tariffs.Add(tar);
        }
        public void CreateTariff(string _nameOfTar,double _pricePerMinute)
        {
            Tariff tar = new Tariff(_nameOfTar,_pricePerMinute);
            tariffs.Add(tar);
        }
        /// <summary>
        
        public override string ToString()
        {
            return Name + " (" + numbId + ") ";
        }

        //клонирование обьекта
        public object Clone()
        {
            List<Client> _clients = new List<Client>() { };
            foreach (Client cl in this.clients)
            {
                _clients.Add((Client)cl.Clone());
            }

            List<Tariff> _tariffs = new List<Tariff>() { };
            foreach(Tariff _tar in tariffs)
            {
                _tariffs.Add((Tariff)_tar.Clone());
            }
            
            return new Operator()
            {
                clients = _clients,
                tariffs = _tariffs,
                name = this.name,
                numbId = this.numbId
            };
            
        }

        public Client Client
        {
            get => default;
            set
            {
            }
        }
    }

}
