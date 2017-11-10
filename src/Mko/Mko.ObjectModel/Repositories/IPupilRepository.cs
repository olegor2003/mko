using System.Collections.Generic;
using System.Linq;
using Mko.ObjectModel.Model;

namespace Mko.ObjectModel.Repositories
{
    public interface IPupilRepository
    {
        IQueryable<Pupil> GetYearPupils(int yearId);

        void AddPupil(Pupil pupil);

        void DeletePupil(int id);

        Pupil UpdatePupil(Pupil pupil);
    }
}