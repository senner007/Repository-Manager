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
            _view.OnCreate += Create;
            _view.OnDisplayLabels += DisplayLabels;
        }

        public void DisplayLabels()
        {
            _view._errorCreateFirstNameText = determine.IfName(_view.CreateFirstNameText) ? "" : "Indtast et navn bestående af bogstaver";
            _view._errorCreateLastNameText = determine.IfName(_view.CreateLastNameText) ? "" : "Indtast et navn bestående af bogstaver";
            _view._errorCreateAgeText = determine.IfAge(_view.CreateAgeText) ? "" : "Indtast en gyldig alder";
            _view._errorCreateTlfText = determine.IfTLF(_view.CreateTlfText) ? "" : "Indtast et gyldigt telefonnummer";
            _view._errorCreateMajorText = determine.IfMisc(_view.CreateMajorText) ? "" : "Indtast et gyldigt fag";
            _view._errorCreateCompanyText = determine.IfMisc(_view.CreateCompanyText) ? "" : "Indtast et firmanavn";
            _view._errorCreateSalaryText = determine.IfUint(_view.CreateSalaryText) ? "" : "Indtast løn";
        }

        private void Create () 
        {
            if (_view.CreateStudentRadio)
            {
                if (!determine.ValidateNewStudent(   
                        _view.CreateTlfText,
                        _view.CreateFirstNameText,
                        _view.CreateLastNameText,
                        _view.CreateAgeText,
                        _view.CreateMajorText
                    )) return;


                bool success = _manage.CreateStudent(
                        Convert.ToUInt32(_view.CreateTlfText), 
                        _view.CreateFirstNameText, 
                        _view.CreateLastNameText, 
                        Convert.ToUInt32(_view.CreateAgeText), 
                        _view.CreateMajorText
                    );

                if (success) CallShow(); // TODO : feedback - slet felter efter indsættelse

            }

            if (_view.CreateEmployedRadio)
            {

                if (!determine.ValidateNewEmployed(  
                        _view.CreateTlfText,
                        _view.CreateFirstNameText,
                        _view.CreateLastNameText,
                        _view.CreateAgeText,
                        _view.CreateCompanyText,
                        _view.CreateSalaryText
                   )) return;

                bool success = _manage.CreateEmployed(
                        Convert.ToUInt32(_view.CreateTlfText),
                        _view.CreateFirstNameText,
                        _view.CreateLastNameText,
                        Convert.ToUInt32(_view.CreateAgeText),
                        _view.CreateCompanyText,
                        Convert.ToUInt32(_view.CreateSalaryText)
                    );

               if (success) CallShow();
            }

        }
    }
}
