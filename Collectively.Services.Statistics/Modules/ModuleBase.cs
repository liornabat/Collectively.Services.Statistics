using AutoMapper;
using Collectively.Common.Nancy;
using Nancy.Security;

namespace Collectively.Services.Statistics.Modules
{
    public abstract class ModuleBase : ApiModuleBase
    {
        protected ModuleBase(bool requireAuthentication = true) 
            : this(string.Empty, requireAuthentication) { }

        protected ModuleBase(string modulePath, bool requireAuthentication = true) 
            : this(null, modulePath, requireAuthentication) { }

        protected ModuleBase(IMapper mapper, string modulePath = "", bool requireAuthentication = true)
            : base(mapper, modulePath) 
        { 
            if (requireAuthentication)
            {
                this.RequiresAuthentication();
            }
        }
    }
}