using ApiPneuStore.Models;
using System.Collections.Generic;

namespace ApiPneuStore.Services
{
    public interface IServiceTyre
    {
        List<Tyre> All();

        Tyre Get(int id);

        bool Create(Tyre tyre);

        bool Update(Tyre tyre);
    }
}
