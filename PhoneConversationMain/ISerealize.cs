using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneConversation
{
    interface ISerealize
    {
        /// <summary>
        /// //
        /// </summary>
        /// <param name="client"></param>
        /// <param name="str"></param>
        void Save(Client client,string str);
        
        void Load(Client client,string str);
       


    }
}
