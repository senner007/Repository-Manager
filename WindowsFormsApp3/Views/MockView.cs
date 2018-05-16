using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Manager.Models;

namespace Manager.Views
{
    public class MockView : IFind, IUpdateDelete, ICreate
    {
        public bool SortNameRadio { get; set; }
        public bool SortAgeRadio { get; set; }
        public bool Sort_Salary_Major_Type_Radio { get; set; }

        public bool ShowStudentsCheck { get; set; }
        public bool ShowEmployedCheck { get; set; }
        public bool SortDirectionCheck { get; set; }
        public IEnumerable<IPerson> PersonList { get; set; }

        public string FilterText { get; set; }

        public string UpdateText { get; set; }
        public string PersonInfoLabel { get; set; }
        public string PropertyLabel { get; set; }
        public string UpdateResponseLabel { get; set; }

        public string CreateFirstNameText { get; set; }
        public string CreateLastNameText { get; set; }
        public string CreateAgeText { get; set; }
        public string CreateTlfText { get; set; }
        public string CreateCompanyText { get; set; }
        public string CreateSalaryText { get; set; }
        public string CreateMajorText { get; set; }

        public bool CreateStudentRadio { get; set; }
        public bool CreateEmployedRadio { get; set; }

        public string _errorCreateFirstNameText { get; set; }
        public string _errorCreateLastNameText { get; set; }
        public string _errorCreateAgeText { get; set; }
        public string _errorCreateTlfText { get; set; }
        public string _errorCreateCompanyText { get; set; }
        public string _errorCreateSalaryText { get; set; }
        public string _errorCreateMajorText { get; set; }

        public string CreatePersonLabel { get; set; }
        public string PersonDeleteText { get; set; }
        public string FilterSortResultLabel { get; set; }

        public event Action OnShow;
        public event Action OnUpdate;
        public event Action OnTextUpdate;
        public event EventWithArgs OnListClick;
        public event Action OnDisplayLabels;
        public event Action OnCreate;
        public event Action OnDelete;
        public event Action OnFilter;

        public void buttonSort() => OnShow();
        public void gridListCLick(IPerson person, string prop, string propValue)
        {
            OnListClick(
                person,
                prop,
                propValue
           );
        }
        public void buttonUpdate() => OnUpdate();
        public void buttonCreate() => OnCreate();
        public void textChangeFilter()
        {

            OnFilter();    
        }
        public void ColumnOrder() { }

        // TODO : tilføj manglende knapper
    }
}
