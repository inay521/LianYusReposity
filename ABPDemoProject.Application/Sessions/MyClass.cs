using Abp.Dependency;
using Abp.Runtime.Session;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABPDemoProject.Sessions
{
    public class MyClass : ITransientDependency
    {
        public IAbpSession AbpSession { get; set; }
        public MyClass() {
            AbpSession = NullAbpSession.Instance;
        }

        public void MyMothed() {
            var userID = AbpSession.UserId;
        }
    }
}
