using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloApi.models
{
    public class Message
    {
        public string status { get; set; }
        public string message { get; set; }
        

    }
    public class Status
    {
        public Boolean status { get; set; }
        public MessagerError message { get; set;}

    }
    public class MessagerError
    {
        public string error { get; set; }
        public string message { get; set; }
        
    }
    public class StatusOk
    {
        public Boolean status { get; set; }
        public string message { get; set; }

    }
}
