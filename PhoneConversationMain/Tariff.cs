using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace PhoneConversation
{
    
    [DataContractAttribute,Serializable]

    public class Tariff : Base<Tariff>, ICloneable
    {
        [DataMember]
        private string name;
        [DataMember]
        private double pricePerMinute = 2.5;
        
        private Operator op;
        

        public Operator Operator {
            get { return op; }
            set { op = value; }
        }

        public string Name {
            get { return name; }
            set { name = value; }
        }

        public double PricePerMinute
        {
            get { return pricePerMinute; }
            set { pricePerMinute = value; }
        }

        public Tariff(string tar, double tempPricePerMinute) : base("")
        {
            this.name = tar;
            this.pricePerMinute = tempPricePerMinute;
        }
        public Tariff(string str):base("")
        {
            name = str;
        }

        public Tariff()
        {// для возможности сделать клонирование обьекта
        }

        //клонинорание обьекта
        public object Clone()
        {
            Tariff tariff = new Tariff()
            {
                name = this.name,
                pricePerMinute = this.pricePerMinute,
                op = (Operator)this.op.Clone()
            };
            return tariff;
        }

        public override string ToString()
        {
            string str = name + "(" + pricePerMinute + ")";
            return str;
        }
    }
}
