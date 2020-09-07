using DAL.Models;
using System.Collections.Generic;

namespace DAL.Repository.Repositories
{
    public interface IThemeRepository
    {
        int Create(Theme theme);
        IEnumerable<Theme> Get();
        int Update(Theme theme);
    }
}