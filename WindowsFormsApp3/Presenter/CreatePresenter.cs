using Manager.Models;
using Manager.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Presenter
{
    public class CreatePresenter
    {
        ICreate _view;
        PersonRepository _manage = new PersonRepository();
        Determine determine = new Determine();
        public event Action CallShow; // Call show in FindPresenter event action
        public CreatePresenter(ICreate view)
        {
            _view = view;
            _view.OnCreate += CreatePerson;
            _view.OnDisplayLabels += DisplayLabels;
        }

        public void DisplayLabels()
        {
            _view._errorCreateFirstNameText = determine.IfName(_view.CreateFirstNameText) ? "FORnavn \u2713" : determine.FirstNameFail;
            _view._errorCreateLastNameText = determine.IfName(_view.CreateLastNameText) ? "EFTERnavn \u2713" : determine.LastNameFail;
            _view._errorCreateMajorText = determine.IfMisc(_view.CreateMajorText) ? "Fag \u2713" : determine.MajorNameFail;
            _view._errorCreateCompanyText = determine.IfMisc(_view.CreateCompanyText) ? "Firma \u2713" : determine.CompanyNameFail;
            _view._errorCreateSalaryText = determine.IfUint(_view.CreateSalaryText) ? "Løn \u2713" : determine.NumberFail;
            _view._errorCreateAgeText = determine.IfAge(_view.CreateAgeText) ? "Alder \u2713" : determine.AgeFail;
            _view._errorCreateTlfText = determine.IfTLF(_view.CreateTlfText) ? "Tlf \u2713" : determine.TlfFail;

            _view.CreatePersonLabel = "";
        }

        private bool Create()
        {
           // Console.WriteLine(_view.CreateFirstNameText);
            if (_view.CreateStudentRadio)
            {
                if (!determine.ValidateNewStudent(
                        _view.CreateTlfText,
                        _view.CreateFirstNameText,
                        _view.CreateLastNameText,
                        _view.CreateAgeText,
                        _view.CreateMajorText
                    )) return false;
                Console.WriteLine(_view.CreateFirstNameText);

                return _manage.CreateStudent(
                       _view.CreateTlfText,
                       _view.CreateFirstNameText,
                       _view.CreateLastNameText,
                       Convert.ToUInt32(_view.CreateAgeText),
                       _view.CreateMajorText
                   );
            }

            else if (_view.CreateEmployedRadio)
            {

                if (!determine.ValidateNewEmployed(
                        _view.CreateTlfText,
                        _view.CreateFirstNameText,
                        _view.CreateLastNameText,
                        _view.CreateAgeText,
                        _view.CreateCompanyText,
                        _view.CreateSalaryText
                   )) return false;

                return _manage.CreateEmployed(
                        _view.CreateTlfText,
                        _view.CreateFirstNameText,
                        _view.CreateLastNameText,
                        Convert.ToUInt32(_view.CreateAgeText),
                        _view.CreateCompanyText,
                        Convert.ToUInt32(_view.CreateSalaryText)
                    );

            }
            return false;
        }

        private void CreatePerson()
        {           
            if (Create())
            {
                ClearPerson();
                CallShow();
                Console.WriteLine("person oprettet");
                _view.CreatePersonLabel = "Oprettet!"; // omdøb variabel fra Errorlabel til feedbacklabel
            }
            else
            {
                Console.WriteLine("not created");
                _view.CreatePersonLabel = "Fejl! - ikke oprettet";
            }
        }    
                
        private void ClearPerson()
        {
            _view.CreateFirstNameText = "";
            _view.CreateLastNameText = "";
            _view.CreateMajorText = "";
            _view.CreateSalaryText = "";
            _view.CreateTlfText = "";
            _view.CreateAgeText = "";
            _view.CreateCompanyText = "";
        }
    }
}
