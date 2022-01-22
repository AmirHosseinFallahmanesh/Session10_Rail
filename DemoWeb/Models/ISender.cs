using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoWeb.Models
{
    public interface ISender
    {
        string Send(string subject, string body, string destination);
    }
}

