using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PhoneConversation
{
    [DataContractAttribute]
    public class Call: Base<Call>
    {
        [DataMember]
        private Client caller;
        [DataMember]
        private Client callee;
        [DataMember]
        private DateTime startTime;
        [DataMember]
        private DateTime durationCall;

        public DateTime DurationCall
        {
            get { return durationCall; }
            set { durationCall = value; }
        }
        public DateTime StartTime
        {
            get { return startTime; }
            set { startTime = value; }   
        }

        public Client Caller
        {
            get { return caller; }
            set { caller = value;}
        }
        public Client Callee
        {
            get { return callee; }
            set { callee = value; }
        }

        public Call(Client caller,Client callee):base()
        {
            
            this.caller = caller;
            this.callee = callee;
        }
        // перегрузка
        public Block DoBlock()
        {
            startTime = DateTime.Now;
            if (caller.Balance >= caller.Tariff.PricePerMinute)
            {
                caller.Balance -= caller.Tariff.PricePerMinute;
                return null;
            }
            else
            {
                Block bl = new Block("Don`t have money",caller);

                caller.CurrentOperator.BlockUser(caller, "Don`t have money");
                return bl;
            }
        }
        public Block DoBlock(Client cl)
        {
            if(cl.CurrentOperator == null )
            {
                Block bl = new Block("Is not operator",caller);
                cl.blocks.Add(bl);
                return bl;
            }else if(cl.Tariff == null)
            {
                Block bl = new Block("You don`t choose!",caller);
                cl.blocks.Add(bl);
                return bl;
            }
            return null;
        }
        //private void DoCall2()
        //{
        //    while(caller.Balance >= caller.Tariff.PricePerMinute)
        //        {
        //        DoCall2();
        //        caller.Balance -= caller.Tariff.PricePerMinute;
        //    }
        //}
        public void EndCall()
        {
            double durationCall = DateTime.Now.Second - startTime.Second;
        }
        public override string ToString()
        {
            return callee.ToString() + " " + startTime;
        }

    }
}
