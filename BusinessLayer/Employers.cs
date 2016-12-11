using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewLayer;

namespace BusinessLayer
{
    class Employers : IViewEmployer
    {
        public List<string[]> GetEmployers()
        {
            List<string[]> list = new List<string[]>();
            string[] tmp = new string[4];
            tmp.SetValue("0", 0);
            tmp.SetValue("1", 1);
            tmp.SetValue("2", 2);
            tmp.SetValue("3", 3);
            list.Add(tmp);
            return list;
        }

        public void RegisterEmployer(string name, string itn, string address, string phone)
        {
            throw new NotImplementedException();
        }
    }
}
