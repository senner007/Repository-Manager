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
        private string _propertyToUpdate;
        public event Action CallShow; // Call show in FindPresenter event action
        public UpdateDeletePresenter(IUpdateDelete view)
        {
            _view = view;
            _view.OnUpdate += Update;
            _view.OnListClick += ListClick;
            _view.OnTextUpdate += Validate;
            _view.OnDelete += Delete;
        }
        // klik på listen - gem person object og egenskab navn(kolonne) og celleværdi - vis i opdateringsboks
        private void ListClick(IPerson person, string prop, string propValue)
        {
            _personToUpdate = person;
            _propertyToUpdate = prop;
           
            _view.UpdateText = propValue;
            _view.PropertyLabel = prop;
            _view.PersonInfoLabel = _personToUpdate.ToString();

            _view.PersonDeleteText = "";

        }

        private void Update(object PropertyName, EventArgs e)  // TODO : call FindPresenter to update
        { 
            // updater fornavn, efternavn, alder, tlf
            // TODO : tilføj manglende opdateringsmuligheder
           
            if (!Validate()) return;

            bool success = _manage.UpdatePerson(
                            _personToUpdate,
                            _propertyToUpdate, 
                            _view.UpdateText);

            if (success)
            {
                _view.ErrorLabel = "Opdatering gennemført!"; // omdøb variabel fra Errorlabel til feedbacklabel
                ClearPerson();
                CallShow(); // Call show in FindPresenter
            }
            else
                _view.ErrorLabel = "Fejl! person ikke opdateret";


            
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


        private bool Validate () // implementer samme logik som ved personCreate - valider alle egenskaber
        {

            var prop = _propertyToUpdate;
            if (_personToUpdate == null)
            {
                _view.ErrorLabel = "Klik på en persons egenskab for at opdatere";
                return false;
            }
            
            _view.ErrorLabel = "Klik på Update efter indtastning";
            if (prop == "TLF")
            {
                if (!determine.IfTLF(_view.UpdateText))
                {
                    _view.ErrorLabel = "Telefonnummer skal bestå af 8 hele tal";
                    return false;
                }
            }
            else if (prop == "Age")
            {
                if (!determine.IfAge(_view.UpdateText))
                {
                    _view.ErrorLabel = "Alder skal være mellem 15 og 100";
                    return false;
                }                  
            }
            else if (prop == "FirstName" || prop == "LastName")
            {
                if (!determine.IfName(_view.UpdateText))
                {
                    _view.ErrorLabel = "Navn skal består af 1 til 50 bogstaver";
                    return false;
                }                   
            }

            return true;
        } 
        private void Delete () // TODO : messageboks ved delete
        {
            if (_personToUpdate == null) return;
            bool success = _manage.DeletePerson(_personToUpdate);

            if (success)
            {
                _view.PersonDeleteText = "Person slettet!"; // omdøb variabel fra Errorlabel til feedbacklabel
                ClearPerson();
                CallShow();
            }
            else
                _view.PersonDeleteText = "Fejl! - person ikke slettet";
                
           
        }

    }
}
