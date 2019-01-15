using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PhoneConversation
{
    [DataContractAttribute,Serializable]
    public class Block : ICloneable
    {
        [DataMember]
        private string reason;
        [DataMember]
        private DateTime startBlock;
        [DataMember]
        private Guid IdClient;

        public Block(string reason,Client client)
        {
            this.reason = reason;
            startBlock = DateTime.Now;
            IdClient = client.Id;
        }
        public Block() { }

        public string Reason
        {
            get { return reason; }
            set { reason = value; }
        }

        public Guid client
        {
            get { return IdClient; }
            set { IdClient = value; }
        }

        public DateTime StartBlock { get { return startBlock; } }

        public override string ToString()
        {
            return "Time "+ startBlock  + " " + reason ;
        }
        //клонинорание обьекта
        public object Clone()
        {
            return new Block()
            {
                reason = this.reason,
                startBlock = this.startBlock
            };

        }
    }
}
