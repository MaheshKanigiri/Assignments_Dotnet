using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    internal interface Admin
    {
        void LoginAdmin(List<String> admins);
        void AdminDetails();
    }
}
