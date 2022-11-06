using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TR_Group.Model.CommonModels
{
    public class ResponseModel
    {

        //public ResponseModel()
        //{

        //}

        public string Version { get; set; }
        public int StatusCode { get; set; }
        public string IsSuccess { get; set; }
        public string ErrorMessage { get; set; }
        public object Data { get; set; }
        //public DateTime Timestamp { get; set; }
        //public long? Size { get; set; }

        //public int StatusCode { get; set; }
        //public string StatusMessage { get; set; }
        //public T Data { get; set; }
        //public string Token { get; set; }
        //public object ValidationError { get; set; }

    }
}
