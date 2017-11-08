using System;
using Mko.ObjectModel.Model;
using Mko.ObjectModel.Repositories;
using System.Windows.Forms;

namespace Mko.ViewModel
{
    public class PupilMarksPresenter
    {
        private readonly IPupilRepository _pupilRepository;
        private readonly Context _context;

        public IPeopleMarksView View { get; set; }

        public PupilMarksPresenter(IPupilRepository pupilRepository, IPeopleMarksView pupilView, Context context)
        {
            _pupilRepository = pupilRepository;
            _context = context;
            View = pupilView;
            View.CurrentPupilCahnged += OnCurrentPupilCahnged;
            View.Pupils = pupilRepository.GetYearPupils(context.CurrentYear.Id);
        }

        private void OnCurrentPupilCahnged(object sender, EventArgs e)
        {

        }
    }
}
