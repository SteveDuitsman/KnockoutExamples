using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public interface IDummyDependency
    {
        string DummyMethod();
    }

    public class DummyDependency : IDummyDependency
    {
        public string DummyMethod()
        {
            return "This is from the data access layer.";
        }
    }
}
