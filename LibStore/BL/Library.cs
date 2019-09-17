using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibStore
{
    public class Library
    {
        IStore _objIstore;

        public Library(IStore objIStore)
        {
            _objIstore = objIStore;
        }
        public void Import(string strJson)
        {
            _objIstore.Import(strJson);
        }
        public int Quantity(string name)
        {
            return _objIstore.Quantity(name);
        }
    }
}
