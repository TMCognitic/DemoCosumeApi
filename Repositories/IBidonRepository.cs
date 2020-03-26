using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IBidonRepository
    {
        IEnumerable<Bidon> Get();
        Bidon Get(int id);
        bool Post(Bidon entity);
    }
}
