using ApiMobile.BaseRepository;
using ApiMobile.Interfaces;
using ApiMobile.Models;

namespace ApiMobile.Repositories
{
    public class vwItemsCategoriaRepositorycs : BaseRepository<VwItemsCategoria>, IvwItemsCategoria
    {
        public vwItemsCategoriaRepositorycs(ApiContext context) : base(context)
        {
                
        }
    }
}
