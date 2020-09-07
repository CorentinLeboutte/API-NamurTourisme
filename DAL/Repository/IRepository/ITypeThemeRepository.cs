using DAL.Models;
using System.Collections.Generic;

namespace DAL.Repository.Repositories
{
    public interface ITypeThemeRepository
    {
        int Create(TypeTheme typetheme);
        IEnumerable<TypeTheme> GetAll();
        void Update(TypeTheme typetheme);
    }
}