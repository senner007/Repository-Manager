﻿using Manager.Models;
using System;
using System.Collections.Generic;

namespace Manager.Views
{
    public interface IFind
    {
        bool SortNameRadio { get; }
        bool SortAgeRadio { get; }
        bool Sort_Salary_Major_Type_Radio { get; }

        bool ShowStudentsCheck { get; set; }
        bool ShowEmployedCheck { get; set; }

        bool SortDirectionCheck { get; set; }
        IEnumerable<IPerson> PersonList { get; set; }

        string FilterText { get; }

        event Action OnShow;
        event Action OnFilter;

        void ColumnOrder();

    }
}
