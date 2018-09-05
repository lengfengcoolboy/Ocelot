using System.Collections.Generic;
using Ocelot.Configuration.File;

namespace Ocelot.Configuration.Creator
{
    public interface IDynamicsCreator
    {
        List<ReRoute> Dynamics(FileConfiguration fileConfiguration);
    }
}
