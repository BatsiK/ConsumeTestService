using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsumeRESTFulService
{
    public class ConsumeService
    {
        public string RESTConsume(string input)
        {
            string stream,split1,output;
            StreamReader reader;
            var url = "http://batsirestfulservice.apphb.com/Service1.svc/json/" + input;
            var webrequest = (HttpWebRequest)System.Net.WebRequest.Create(url);
            using (var response = webrequest.GetResponse())
            using (reader = new StreamReader(response.GetResponseStream()))
                stream = reader.ReadToEnd();
            split1 = stream.Substring(31);
            output = split1.Remove((split1.Length - 2), 2);
            return output;
        }
    }
}
