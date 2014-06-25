using System.Collections.Generic;

namespace WebapiOAuth.Repositories
{
    public interface ITempRepository
    {
        List<string> GetAll();
    }
}
