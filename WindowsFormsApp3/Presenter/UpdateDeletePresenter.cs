using Manager.Models;
using Manager.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Manager.Presenter
{
    public class UpdateDeletePresenter
    {
        private IUpdateDelete _view;
        private PersonRepository _manage = new PersonRepository();
        private IPerson _personToUpdate = null;
        private Determine determine = new Determine();
        private string _propToUpdate;
        public event Action CallShow; // Call show in FindPresenter event action
        public UpdateDeletePresenter(IUpdateDelete view)
        {
            _view = view;
            _view.OnUpdate += Update;
            _view.OnListClick += ListClick;
            _view.OnTextUpdate += DisplayLabels;
            _view.OnDelete += Delete;
        }
        // klik på listen - gem person object og egenskab navn(kolonne) og celleværdi - vis i opdateringsboks
        private void ListClick(IPerson person, string prop, string propValue)
        {
            _personToUpdate = person;
            _propToUpdate = prop;
           
            _view.UpdateText = propValue;
            _view.PropertyLabel = prop;
            _view.PersonInfoLabel = _personToUpdate.ToString();

            _view.PersonDeleteText = "";

        }

        private void Update()  // TODO : call FindPresenter to update
        { 
            // updater fornavn, efternavn, alder, tlf
            // TODO : tilføj manglende opdateringsmuligheder
           
            if (!determine.ValidateUpdate(_propToUpdate, _view.UpdateText) || _personToUpdate == null) return;

            bool success = _manage.UpdatePerson(
                            _personToUpdate,
                            _propToUpdate, 
                            _view.UpdateText);

            if (success)
            { 
                ClearPerson();
                CallShow(); // Call show in FindPresenter
                _view.UpdateResponseLabel = "Opdatering gennemført!"; // omdøb variabel fra Errorlabel til feedbacklabel
            }
            else
                _view.UpdateResponseLabel = "Fejl! person ikke opdateret";


            
        }
        // TODO : genbrug i PersonCreate
        // TODO : farv rød
        // TODO : Tilføj feedback

        private void ClearPerson()
        {
            _personToUpdate = null;
            _view.UpdateText = "";
            _view.PropertyLabel = "";
            _view.PersonInfoLabel = "";
        }
        public void  DisplayLabels()
        {
            _view.UpdateResponseLabel = Labels();
        }


        public string Labels()
        {
            if (_propToUpdate == "FirstName" && !determine.ValidateUpdate(_propToUpdate, _view.UpdateText))
                return determine.FirstNameFail;
            else if (_propToUpdate == "LastName" && !determine.ValidateUpdate(_propToUpdate, _view.UpdateText))
                return determine.LastNameFail;
            else if (_propToUpdate == "Age" && !determine.ValidateUpdate(_propToUpdate, _view.UpdateText))
                return determine.AgeFail;
            else if (_propToUpdate == "TLF" && !determine.ValidateUpdate(_propToUpdate, _view.UpdateText))
                return determine.TlfFail;
            else if (_propToUpdate == "Salary" && !determine.ValidateUpdate(_propToUpdate, _view.UpdateText))
                return determine.NumberFail;  
            else if (_propToUpdate == "Company")
                return "";
            else if (_propToUpdate == "Major")
                return "";
            return "";
        }


        private void Delete () // TODO : messageboks ved delete
        {
            if (_personToUpdate == null) return;
            bool success = _manage.DeletePerson(_personToUpdate);

            if (success)
            {
                ClearPerson();
                CallShow();
                _view.PersonDeleteText = "Person slettet!"; // omdøb variabel fra Errorlabel til feedbacklabel
            }
            else
                _view.PersonDeleteText = "Fejl! - person ikke slettet";
                
           
        }

    }
}
