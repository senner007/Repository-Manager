using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Manager.Models;
using Manager.Views;

namespace Manager.Presenter
{
    public class ReadPresenter
    {
        private IFind _view;
        private PersonRepository _manage = new PersonRepository();
        private Determine determine = new Determine();
        bool skipSort = false;
        public ReadPresenter(IFind view, UpdateDeletePresenter updateDeletePresenter, CreatePresenter createPresenter)
        {
            _view = view;
            _view.OnShow += FilterSort;
            _view.OnFilter += () =>
            {
                //Hop over sortering og sæt radioSortName og sortdirection, når der indtastes filterkriterie:
                //Hvis der er tale om en meget stor datasamling eg. 1/2 million+, 
                //kan man vælge at undlade sortering efterfølgende og kun vise listen som den er sorteret i forvejen (efter LastName)
                skipSort = true;
                _view.SortNameRadio = false;
                _view.SortAgeRadio = false;
                _view.Sort_Salary_Major_Type_Radio = false;
                _view.SortDirectionCheck = false;
                FilterSort();
            };
            updateDeletePresenter.CallShow += FilterSort;
            createPresenter.CallShow += FilterSort;

        }
        private void FilterSort() // TODO : cache sorteret liste ved tryk på hent og sort. Implementer binær søgning på andre egenskaber
        {
            Stopwatch sw = Stopwatch.StartNew();
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
                List<IPerson> lst = SortList(Filter(_manage.GetPeople), o => o.Status);
               _view.PersonList = _manage.MergeTypes(lst).ToList();

            }
          
            skipSort = false;
            _view.FilterSortResult_LABEL = "Antal : " + _view.PersonList.Count(); // TODO : Count hurtig nok? eller gem i SortList methoden
            _view.ColumnOrder(); // kald columnOrder i view
            sw.Stop();
            Console.WriteLine(sw.Elapsed);
        }
        
        public IEnumerable<T> Filter<T>(IEnumerable<T> list) where T : IPerson 
            // TODO : tilføj case-insensitive filter
        {
           
            if (determine.IfName(_view.FilterText))
            {
                
          
                //Console.WriteLine("binary sort");
               
                // find efternavn med binær/liniær søgning
                return ReadBinary.ListBinary<T>(list.ToList(), _view.FilterText);

                // find udsnit af liste med binær søgning - tillader meget hurtigere filtrering (1/2 million personer uden lag)
                // TODO : kræver at listen er indexeret efter navn - lav evt. et indexeret view i db med merged  

            }
            else if (determine.IfTLF(_view.FilterText)) 
            {

                //  var lst =  list.Where(n => n.TLF.ToString().StartsWith(_view.FilterText));
                // find i OrderedDictionary (O(1))


                var lst = _manage.GetDict[Convert.ToUInt32(_view.FilterText)];
                return lst is T ? new List <T> { (T)lst } : new List<T>();
          

            }
            return list; // TODO : returner ingen eller hel liste ved fejlindtastning?
        }


        private List<T> SortList<T>(IEnumerable<T> list, Func<T, dynamic> lambda) where T : IPerson
        {
            if (skipSort == true) return list.ToList();

             Console.WriteLine("from sort function");

            if (_view.SortNameRadio) // TODO : tilføj sorter på efternavn
            {
                list = list.OrderBy(o => o.FirstName).ThenBy(o => o.LastName);
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
