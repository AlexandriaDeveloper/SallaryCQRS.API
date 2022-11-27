using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common
{
    public  class Response <T>
    {


        public Response()
        {
            this.Errors=new List<string>();
        }
        public T Result { get; set; }
        public List<string> Errors  { get; }

        public bool HasErrors { get => Errors.Count> 0; }


        public void AddError(string ErrorMessage) {
            this.Errors.Add(ErrorMessage);
        }



    }
}
