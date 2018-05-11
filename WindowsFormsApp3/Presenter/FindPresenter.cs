using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Manager.Models;
using Manager.Views;

namespace Manager.Presenter
{
    public class FindPresenter
    {
        private IFind _view;
        private PersonRepository _manage = new PersonRepository();
        private Determine determine = new Determine();
        bool skipSort = false;
        public FindPresenter(IFind view, UpdateDeletePresenter updateDeletePresenter, CreatePresenter createPresenter)
        {
            _view = view;
            _view.OnShow += FilterSort;
            // hop over sortering og sæt radioSortName og sortdirection, når der indtastes filterkriterie 
            _view.OnFilter += () => skipSort = true;
            _view.OnFilter += () => _view.SortNameRadio = true;
            _view.OnFilter += () =>  _view.SortDirectionCheck = false;
            _view.OnFilter += FilterSort;
            updateDeletePresenter.CallShow += FilterSort;
            createPresenter.CallShow += FilterSort;

        }
        private void FilterSort() // TODO : cache sorteret liste ved tryk på hent og sort. Implementer binær søgning på andre egenskaber
        {
            
            // hvis vis studerende, ikke vis employed
            if (_view.ShowStudentsCheck && !_view.ShowEmployedCheck)
            {   // kald sort med student objecter og lambda med filtrer - sorter efter fag
                _view.PersonList = SortList(Filter(_manage.GetByType(s => s as Student)), o => o.Major);
            }
            else if (!_view.ShowStudentsCheck && _view.ShowEmployedCheck)
            {
                _view.PersonList = SortList(Filter(_manage.GetByType(s => s as Employed)), o => o.Salary);    
            }
            else
            {
                _view.PersonList = SortList(Filter(_manage.MergeTypes()), o => o.Status);
            }
     
            skipSort = false;
            _view.FilterSortResult_LABEL = "Antal : " + _view.PersonList.Count();
            _view.ColumnOrder(); // kald columnOrder i view
        }

        public IEnumerable<T> Filter<T>(IEnumerable<T> list) where T : IPerson 
            // TODO : øjeblikkelig fokus på filter tekstbox ved programstart
            // TODO : tilføj case-insensitive filter
        {
           
            if (determine.IfName(_view.FilterText))
            {
                // set sortby radiobuttons to false
                Console.WriteLine("binary sort");
               
                // find efternavn med binær/liniær søgning
                return ReadBinary.GetListWithBinaryLetters<T>(list.ToList(), _view.FilterText);
                // find udsnit af liste med binær søgning - tillader meget hurtigere filtrering (1/2 million personer uden lag)
                // TODO : kræver at listen er indexeret efter navn - lav evt. et indexeret view i db med merged  

            }
            else if (determine.IfUint(_view.FilterText) && _view.FilterText.Length == 8)
            {
          
                return list.Where(n => n.TLF.ToString().StartsWith(_view.FilterText));
               // return ReadTlfBinary.GetListWithBinary<T>(list.ToList(), Convert.ToUInt32(_view.FilterText));    

            }
            return list; // TODO : returner ingen eller hel liste ved fejlindtastning?
        }


        private List<T> SortList<T>(IEnumerable<T> list, Func<T, dynamic> lambda) where T : IPerson
        {
            if (skipSort == true) return list.ToList();

             Console.WriteLine("hello from sort function");

            if (_view.SortNameRadio)
            {
                list = list.OrderBy(o => o.LastName).ThenBy(o => o.FirstName);
            }
            else if (_view.SortAgeRadio) 
            {
                list = list.OrderBy(o => o.Age).ThenBy(o => o.LastName);
            }
            else if (_view.Sort_Salary_Major_Type_Radio)
            {
                list = list.OrderBy(lambda).ThenBy(o => o.LastName);
            }
            return _view.SortDirectionCheck ? OrderReverse(list) : list.ToList();
        }
        
        private List<T> OrderReverse<T>(IEnumerable<T> list)
        {
            return list.AsEnumerable().Reverse().ToList();
        }
       


    }
}
