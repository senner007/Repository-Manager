using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Manager.Models;
using Manager.Presenter;
using Manager.Views;
using System.Reflection;
using System.Linq;
using System.Diagnostics;
using System.Collections.Generic;

namespace ManagerTest
{
    [TestClass]
    public class ReadTests
    {

        private PersonRepository _manage;
        public MockView _view;

        [TestInitialize()]
        public void TestInitialize() // executes once before each test run https://stackoverflow.com/questions/13943078/c-sharp-unit-test-with-common-code-repeated
        {
            _manage = new PersonRepository();
            _view = new MockView();
            new ReadPresenter(_view, new UpdateDeletePresenter(_view), new CreatePresenter(_view)) ;
        }
        [TestCleanup()]
        public void Cleanup()
        {// Clear static class for hver test https://colinmackay.scot/2007/06/16/unit-testing-a-static-class/
           //PersonRepository.GetPeople = null;
            Type staticType = typeof(PersonRepository);
            ConstructorInfo ci = staticType.TypeInitializer;
            object[] parameters = new object[0];
            ci.Invoke(null, parameters);
        }

        /* // TODO : Tilføj flere/manglende tests - løs click test problem - coded UI tests?
         * 
         * Model IFind tests
         * 
         * 
         */

        [TestMethod]
        public void Model_Read_Get_First_Person()
        {
            string actual = PersonRepository.GetPeople.FirstOrDefault().ToString();

            string expected = "Poul Adams, Alder: 40, Tlf: 33333333, Employed";


            Trace.WriteLine(actual);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Model_Read_Get_Last_Person()
        {
            string actual = PersonRepository.GetPeople.LastOrDefault().ToString();

            string expected = "Jeremy McPeak, Alder: 40, Tlf: 55555555, Employed";


            Trace.WriteLine(actual);

            Assert.AreEqual(expected, actual);
        }

        /*
         * 
         * View IFind Sort Tests
         * 
         */

        [TestMethod]
        public void View_Read_SortByName_Get_First_Person()
        {
            
            _view.FilterText = "";
            _view.SortNameRadio = true;
            _view.buttonSort();

            string actual = _view.PersonList.FirstOrDefault().ToString();

            string expected = "Bill Gates, Alder: 70, Tlf: 44444444, Employed";

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void View_Read_SortByAge_Get_First_Person()
        {

            _view.FilterText = "";
            _view.SortAgeRadio = true;
            _view.buttonSort();

            string actual = _view.PersonList.FirstOrDefault().ToString();

            string expected = "Thomas Anderson, Alder: 20, Tlf: 77777777, Student";

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void View_Read_SortByType_Get_First_Person()
        {

            _view.FilterText = "";
            _view.Sort_Salary_Major_Type_Radio = true;
            _view.buttonSort();

            string actual = _view.PersonList.FirstOrDefault().ToString();

            string expected = "Poul Adams, Alder: 40, Tlf: 33333333, Employed";

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void View_Read_SortByName_Employed_Get_First_Person()
        {

            _view.FilterText = "";
            _view.SortNameRadio = true;
            _view.ShowEmployedCheck = true;
            _view.buttonSort();

            string actual = _view.PersonList.FirstOrDefault().ToString();

            string expected = "Bill Gates, Alder: 70, Tlf: 44444444, Employed";

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void View_Read_SortByName_Employed_Descending_Get_First_Person()
        {

            _view.FilterText = "";
            _view.SortNameRadio = true;
            _view.ShowEmployedCheck = true;
            _view.SortDirectionCheck = true;
            _view.buttonSort();

            string actual = _view.PersonList.FirstOrDefault().ToString();

            string expected = "Poul Irish, Alder: 40, Tlf: 11111111, Employed";

            Assert.AreEqual(expected, actual);
        }

        /*
       * 
       * View IFind Sort Filter Tests
       * 
       */
        [TestMethod]
        public void View_Read_Filter_Doe_Employed_Get_First_Person()
        {

            _view.FilterText = "Doe";
            _view.ShowEmployedCheck = true;
            _view.textChangeFilter();

            IPerson actual = _view.PersonList.FirstOrDefault();

            IPerson expected = null;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void View_Read_Filter_Doe_Employed_Get_Last_Person()
        {

            _view.FilterText = "Doe";
            _view.ShowEmployedCheck = true;
            _view.textChangeFilter();

            IPerson actual = _view.PersonList.LastOrDefault();

            IPerson expected = null;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void View_Read_Filter_Doe_Students_Get_First_Person()
        {

            _view.FilterText = "Doe";
            _view.ShowStudentsCheck = true;
            _view.textChangeFilter();

            string actual = _view.PersonList.FirstOrDefault().ToString();

           

            string expected = "Jane Doe, Alder: 25, Tlf: 99999999, Student";

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void View_Read_Filter_Doe_Students_Sort_Get_Last_Person()
        {

            _view.FilterText = "Doe";
            _view.ShowStudentsCheck = true;
            _view.textChangeFilter();

            string actual = _view.PersonList.LastOrDefault().ToString();

            Trace.WriteLine(actual);

            string expected = "John Doe, Alder: 30, Tlf: 88888888, Student";

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void View_Read_Filter_Students_Get_TLF_Null()
        {

            _view.FilterText = "11111111";
            _view.ShowStudentsCheck = true;
            _view.textChangeFilter();

            IPerson actual = _view.PersonList.FirstOrDefault();

            Trace.WriteLine(actual);

            string expected = null;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void View_Read_Filter_Students_Get_TLF()
        {

            _view.FilterText = "88888888";
            _view.ShowStudentsCheck = true;
            _view.textChangeFilter();

            string actual = _view.PersonList.FirstOrDefault().ToString();

            Trace.WriteLine(actual);

            string expected = "John Doe, Alder: 30, Tlf: 88888888, Student";

            Assert.AreEqual(expected, actual);
        }
    }
}
