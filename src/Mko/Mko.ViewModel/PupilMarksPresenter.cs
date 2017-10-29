using System;
using Mko.ObjectModel.Model;
using Mko.ObjectModel.Repositories;
using System.Windows.Forms;

namespace Mko.ViewModel
{
    public class PupilMarksPresenter
    {
        private readonly IPupilRepository _pupilRepository;

        public Year CurrentYear { get; set; }

        public IPeopleMarksView View { get; set; }

        public PupilMarksPresenter(IPupilRepository pupilRepository, IPeopleMarksView pupilView)
        {
            _pupilRepository = pupilRepository;
            View = pupilView;
            View.CurrentPupilCahnged += OnCurrentPupilCahnged;
            View.Pupils = pupilRepository.GetActiveYearPupils();
        }

        private void OnCurrentPupilCahnged(object sender, EventArgs e)
        {

        }
    }
}
