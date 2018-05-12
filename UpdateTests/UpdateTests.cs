using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Manager.Models;
using Manager.Presenter;
using Manager.Views;
using System.Reflection;
using System.Linq;
using System.Diagnostics;
using System.Collections.Generic;


namespace UpdateTests
{
    [TestClass]
    public class UpdateTests
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
            _readPresenter = new ReadPresenter(_view, _updateDeletePresenter, _createPresenter);
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
         * View IUpdateDelete tests
         * 
         * 
         */

        [TestMethod]
        public void View_Click_List_Will_Update_UpdateTextBox()
        {

            _view.FilterText = "";
            _view.SortNameRadio = true;
            _view.buttonSort();

            Merged clicked = _view.PersonList.FirstOrDefault() as Merged;
            var obj = new Merged
            {
                TLF = clicked.TLF,
                FirstName = clicked.FirstName,
                LastName = clicked.LastName,
                Age = clicked.Age,
                Company = clicked.Company,
                Major = clicked.Major,
                Salary = clicked.Salary
            };

            _view.gridListCLick(
             (IPerson)obj,
              "FirstName",
              "Poul");

            string actual = _view.UpdateText;
            string expected = "Poul";

            Assert.AreEqual(expected, actual);
        
        }
        [TestMethod]
        public void View_Update_First_Person_Merged_FirstName()
        {

            _view.FilterText = "";
            _view.SortNameRadio = true;
            _view.buttonSort();

            Merged clicked = _view.PersonList.FirstOrDefault() as Merged;
            var obj = new Merged
            {
                TLF = clicked.TLF,
                FirstName = clicked.FirstName,
                LastName = clicked.LastName,
                Age = clicked.Age,
                Company = clicked.Company,
                Major = clicked.Major,
                Salary = clicked.Salary
            };
            _view.gridListCLick(
              (IPerson)obj,
              "FirstName",
              "Poul");

            _view.UpdateText = "James";
            _view.buttonUpdate();

            string expected = "James";
            string actual = _view.PersonList.FirstOrDefault().FirstName;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void View_Update_First_Person_Student_FirstName()
        {

            _view.FilterText = "";
            _view.SortNameRadio = true;
            _view.ShowStudentsCheck = true;
            _view.buttonSort();

            Student clicked = _view.PersonList.FirstOrDefault() as Student;
            var obj = new Student
            {
                TLF = clicked.TLF,
                FirstName = clicked.FirstName,
                LastName = clicked.LastName,
                Age = clicked.Age,
                Major = clicked.Major,
            };

            _view.gridListCLick(
              (IPerson)obj,
              "FirstName",
              "Thomas");

            _view.UpdateText = "James";
            _view.buttonUpdate();

            string expected = "James";
            string actual = _view.PersonList.FirstOrDefault().FirstName;

            Assert.AreEqual(expected, actual);
        }

    }
}
