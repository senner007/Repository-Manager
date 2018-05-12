﻿using System;
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
    public class ManagerTest
    {

        private PersonRepository _manage;

        public ReadPresenter _readPresenter;
        public UpdateDeletePresenter _updateDeletePresenter;
        public CreatePresenter _createPresenter;
        public MockView _view;


        [TestInitialize()]
        public void TestInitialize() // executes once before each test run https://stackoverflow.com/questions/13943078/c-sharp-unit-test-with-common-code-repeated
        {
            _manage = new PersonRepository();
            _view = new MockView();
            _updateDeletePresenter = new UpdateDeletePresenter(_view);
            _createPresenter = new CreatePresenter(_view);
            _readPresenter = new ReadPresenter(_view, _updateDeletePresenter, _createPresenter) ;
        }
        [TestCleanup()]
        public void Cleanup()
        {// Clear static class for hver test https://colinmackay.scot/2007/06/16/unit-testing-a-static-class/

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
        public void Model_Get_First_Person()
        {
            string actual = _manage.GetPeople.FirstOrDefault().ToString();

            string expected = "Poul Adams, Alder: 40, Tlf: 33333333, Employed";


            Trace.WriteLine(actual);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Model_Get_Last_Person()
        {
            string actual = _manage.GetPeople.LastOrDefault().ToString();

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
        public void View_SortByName_Get_First_Person()
        {
            
            _view.FilterText = "";
            _view.SortNameRadio = true;
            _view.buttonSort();

            string actual = _view.PersonList.FirstOrDefault().ToString();

            string expected = "Poul Adams, Alder: 40, Tlf: 33333333, Employed";

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void View_SortByAge_Get_First_Person()
        {

            _view.FilterText = "";
            _view.SortAgeRadio = true;
            _view.buttonSort();

            string actual = _view.PersonList.FirstOrDefault().ToString();

            string expected = "Thomas Anderson, Alder: 20, Tlf: 77777777, Student";

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void View_SortByType_Get_First_Person()
        {

            _view.FilterText = "";
            _view.Sort_Salary_Major_Type_Radio = true;
            _view.buttonSort();

            string actual = _view.PersonList.FirstOrDefault().ToString();

            string expected = "Poul Adams, Alder: 40, Tlf: 33333333, Employed";

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void View_SortByName_Employed_Get_First_Person()
        {

            _view.FilterText = "";
            _view.SortNameRadio = true;
            _view.ShowEmployedCheck = true;
            _view.buttonSort();

            string actual = _view.PersonList.FirstOrDefault().ToString();

            string expected = "Poul Adams, Alder: 40, Tlf: 33333333, Employed";

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void View_SortByName_Employed_Descending_Get_First_Person()
        {

            _view.FilterText = "";
            _view.SortNameRadio = true;
            _view.ShowEmployedCheck = true;
            _view.SortDirectionCheck = true;
            _view.buttonSort();

            string actual = _view.PersonList.FirstOrDefault().ToString();

            string expected = "Jeremy McPeak, Alder: 40, Tlf: 55555555, Employed";

            Assert.AreEqual(expected, actual);
        }

        /*
       * 
       * View IFind Sort Filter Tests
       * 
       */
        [TestMethod]
        public void View_Filter_Doe_Employed_Get_First_Person()
        {

            _view.FilterText = "Doe";
            _view.ShowEmployedCheck = true;
            _view.SortDirectionCheck = true;
            _view.buttonSort();

            IPerson actual = _view.PersonList.FirstOrDefault();

            IPerson expected = null;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void View_Filter_Doe_Employed_Get_Last_Person()
        {

            _view.FilterText = "Doe";
            _view.ShowEmployedCheck = true;
            _view.SortDirectionCheck = true;
            _view.buttonSort();

            IPerson actual = _view.PersonList.LastOrDefault();

            IPerson expected = null;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void View_Filter_Doe_Students_Get_First_Person()
        {

            _view.FilterText = "Doe";
            _view.ShowStudentsCheck = true;
            _view.SortDirectionCheck = false;
            _view.buttonSort();

            string actual = _view.PersonList.FirstOrDefault().ToString();

            Trace.WriteLine(actual);

            string expected = "Jane Doe, Alder: 25, Tlf: 99999999, Student";

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void View_Filter_Doe_Students_Get_Last_Person()
        {

            _view.FilterText = "Doe";
            _view.ShowStudentsCheck = true;
            _view.SortDirectionCheck = false;
            _view.buttonSort();

            string actual = _view.PersonList.LastOrDefault().ToString();

            Trace.WriteLine(actual);

            string expected = "John Doe, Alder: 30, Tlf: 88888888, Student";

            Assert.AreEqual(expected, actual);
        }
    }
}
