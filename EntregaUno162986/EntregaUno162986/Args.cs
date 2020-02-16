using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntregaUno162986
{
    public class Args1
    {
        String name = "Omar";
       
     
     public void setName(String name)
        {
            this.name = name;
        }    
       
        public String getName()
        {
            return this.name;
        }

        internal void setName(Args1 name)
        {
            throw new NotImplementedException();
        }
    }
    
}

