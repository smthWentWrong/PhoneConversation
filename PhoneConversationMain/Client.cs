
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace PhoneConversation
{
    [DataContract, Serializable]
    public class Client : Person, ICloneable
    {
        
        public List<Replenishment> replenishments = new List<Replenishment>();
        [DataMember]
        public List<Block> blocks = new List<Block>();
        
        public List<Client> contacts = new List<Client>();

        private static int NumbOfAddClients = 0;
        [DataMember]
        private double balance;
        [DataMember]
        private readonly Guid id;
        [DataMember]
        private Operator currentOperator;
        [DataMember]
        private Tariff currentTariff;

        public Client(string firstName, string lastName,double balance) : base(firstName, lastName)
        {
            this.balance = balance;
            id = Guid.NewGuid();
            contacts.Add(this);
        }

        public Client(string firstName, string lastName) : base(firstName, lastName)
        {
            id = Guid.NewGuid();
            contacts.Add(this);
        }

        public Client(string firstName) : base(firstName)
        {
            contacts.Add(this);
            id = Guid.NewGuid();
        }
        public Client() : this("","",0)
        {
            contacts.Add(this);
            id = Guid.NewGuid();
        }

        public Guid Id
        {
            get { return id; }
        }

        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public Operator CurrentOperator
        {
            get { return currentOperator; }
            set {
                currentOperator = value;
                
            }
        }


        public List<Replenishment> GetReplenishments
        {
            get { return replenishments; }
        }
        public List<Replenishment> SetReplenishments
        {
            set { replenishments = value; }
        }

        public Replenishment SetReplenishment
        {
            set
            {
                replenishments.Add(value);
                balance += value.Sum;
            }
        }

        public Tariff Tariff
        {
            get { return currentTariff; }
            set { currentTariff = value; }
        }
        public List<Block> GetBlocks
        {
            get { return blocks; }
        }

        public Block SetBlock
        {
            set
            {
                blocks.Add(value);
            }
        }

        public Replenishment Replenishment
        {
            get => default;
            set
            {
            }
        }

        public Block Block
        {
            get => default;
            set
            {
            }
        }

        public Operator Operator
        {
            get => default;
            set
            {
            }
        }

        public static void SetNumbOfAddClients()
        {
            NumbOfAddClients += 1;
        }
        public static int GetNumbOfAddClients()
        {
            return NumbOfAddClients;
        }

        public void SaveContact(Client contact)
        {
            if (contacts.Contains(contact)) { }
            else { contacts.Add(contact); }
        }

        public override string ToString()
        {
            string str = this.FirstName;
            string tmp = this.LastName == null ? " " : (" " + LastName ) ;
            str += tmp;
            tmp = currentOperator == null ? " " : (" ( " + CurrentOperator.Name + " )");
            str += tmp;
            tmp = Tariff == null ? "" : ("Tarriff: " + Tariff.ToString());
            str += tmp;
            return str;
        }

        public object Clone()
        {

            return new Client()
            {

            };

        }
    }
}

