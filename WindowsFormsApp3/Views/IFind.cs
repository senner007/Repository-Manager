using Manager.Models;
using System;
using System.Collections.Generic;

namespace Manager.Views
{
    public interface IFind
    {
        bool SortNameRadio { get; set; }
        bool SortAgeRadio { get; set; }
        bool Sort_Salary_Major_Type_Radio { get; set; }

        bool ShowStudentsCheck { get; set; }
        bool ShowEmployedCheck { get; set; }

        bool SortDirectionCheck { get; set; }
        IEnumerable<IPerson> PersonList { get; set; }

        string FilterText { get; }
        string FilterSortResultLabel { get; set; }

        event Action OnShow;
        event Action OnFilter;

        void ColumnOrder();

    }
}
