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
        public FindPresenter(IFind view, UpdateDeletePresenter updateDeletePresenter, CreatePresenter createPresenter)
        {
            _view = view;
            _view.OnShow += FilterSort;
            updateDeletePresenter.CallShow += FilterSort;
            createPresenter.CallShow += FilterSort;

        }
        private void FilterSort()
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
                _view.PersonList = SortList(Filter(_manage.MergeTypes()), o => o.Type);
            }

            _view.ColumnOrder(); // kald columnOrder i view
        }

        public IEnumerable<T> Filter<T>(IEnumerable<T> list) where T : IPerson 
            // TODO : øjeblikkelig fokus på filter tekstbox ved programstart
            // TODO : tilføj case-insensitive filter
        {

            if (determine.IfName(_view.FilterText))
            {

                return list.Where(n => n.FirstName.StartsWith(_view.FilterText) || n.LastName.StartsWith(_view.FilterText));
                //return list.Where(n => n.FirstName.StartsWith(_view.FilterText) || n.LastName.StartsWith(_view.FilterText));
            }
            else if (determine.IfUint(_view.FilterText))
            {
                  return list.Where(n => n.TLF.ToString().StartsWith(_view.FilterText));

            }
            return list; // TODO : returner ingen eller hel liste ved fejlindtastning?
        }


        private List<T> SortList<T>(IEnumerable<T> list, Func<T, dynamic> lambda) where T : IPerson
        {
             //if (sortCache.Count() != 0) return sortCache.OfType<T>().ToList();
 
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
//Console.WriteLine(cachedString == _view.FilterText.Substring(0, _view.FilterText.Length - 1));
//                if (cachedString != _view.FilterText.Substring(0, _view.FilterText.Length - 1))
//                {
//                    Console.WriteLine("Hello from filter");
//                    cachedString = _view.FilterText;
//                    return list.Where(n => n.TLF.ToString().StartsWith(_view.FilterText));
//                }
//                else if (cachedString == _view.FilterText.Substring(0, _view.FilterText.Length - 1))
//                {
//                    cachedString = _view.FilterText;
//                    return _view.PersonList.Where(n => n.TLF.ToString().StartsWith(_view.FilterText)).OfType<T>();
    
//                }