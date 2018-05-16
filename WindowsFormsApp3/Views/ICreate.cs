using System;


namespace Manager.Views
{
    public interface ICreate
    {

        string CreateFirstNameText { get; set; }
        string CreateLastNameText { get; set; }
        string CreateAgeText { get; set; }
        string CreateTlfText { get; set; }

        string CreateCompanyText { get; set; }
        string CreateSalaryText { get; set; }

        string CreateMajorText { get; set; }

        bool CreateStudentRadio { get; set; }
        bool CreateEmployedRadio { get; set; }

        string _errorCreateFirstNameText { get; set; }
        string _errorCreateLastNameText { get; set; }
        string _errorCreateAgeText { get; set; }
        string _errorCreateTlfText { get; set; }

        string _errorCreateCompanyText { get; set; }
        string _errorCreateSalaryText { get; set; }

        string _errorCreateMajorText { get; set; }

        string CreatePersonLabel { get; set; }


        event Action OnDisplayLabels;
        event Action OnCreate;
    }
}
