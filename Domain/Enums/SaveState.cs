using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Enums
{
    public enum SaveState
    {

        Saved = 0,
        SqlDublicateException=1,
        SqlException = 2,
        
        Exception= 3,
    }
}
