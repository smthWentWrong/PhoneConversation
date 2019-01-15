using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PhoneConversation
{
    [DataContract,Serializable]
    public class Replenishment: ICloneable
    {
        [DataMember]
        private  DateTime timeOfReplenishment;
        [DataMember]
        private  int sum;

        public Replenishment(Client cl,int sum)
        {
            timeOfReplenishment = DateTime.Now;
            this.sum = sum;
            cl.SetReplenishment = this;
        }
        public Replenishment()
        {
        }

        public int Sum
        {
            get { return sum; }
        }

        public DateTime TimeOfReplenishment {
            get { return timeOfReplenishment; }
        }

        //клонинорание обьекта
        public object Clone()
        {
            
            return new Replenishment()
            {
                timeOfReplenishment = this.timeOfReplenishment,
                sum = this.sum
            };
        }

        public override string ToString()
        {
            return "Sum: " + sum + " Time: " + timeOfReplenishment;
        }
    }
}
