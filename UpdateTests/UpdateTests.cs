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
        public MockView _view;


        [TestInitialize()]
        public void TestInitialize() // executes once before each test run https://stackoverflow.com/questions/13943078/c-sharp-unit-test-with-common-code-repeated
        {
            _manage = new PersonRepository();
            _view = new MockView();
            new ReadPresenter(_view, new UpdateDeletePresenter(_view), new CreatePresenter(_view));
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
              obj.FirstName);

            string actual = _view.UpdateText;
            string expected = "Bill";

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
            Console.WriteLine(obj.FirstName);

            _view.gridListCLick(
              (IPerson)obj,
              "FirstName",
              obj.FirstName);

            _view.UpdateText = "James";
            _view.buttonUpdate();

            string expected = "Douglas";
            string actual = _view.PersonList.FirstOrDefault().FirstName;

            string expectedFeedback = "Opdatering gennemført!";
            string actualFeedback = _view.UpdateResponseLabel;

            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expectedFeedback, actualFeedback);
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
              obj.FirstName);

            _view.UpdateText = "James";
            _view.buttonUpdate();

            string expected = "James";
            string actual = _view.PersonList.FirstOrDefault().FirstName;

            string expectedFeedback = "Opdatering gennemført!";
            string actualFeedback = _view.UpdateResponseLabel;

            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expectedFeedback, actualFeedback);
        }
        [TestMethod]
        public void View_Update_First_Person_Student_Tlf()
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
              "TLF",
              obj.TLF);

            _view.UpdateText = "11111112";
            _view.buttonUpdate();

            string expected = "11111112";
            string actual = _view.PersonList.FirstOrDefault().TLF.ToString();

            string expectedFeedback = "Opdatering gennemført!";
            string actualFeedback = _view.UpdateResponseLabel;

            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expectedFeedback, actualFeedback);
        }
        [TestMethod]
        public void View_Update_First_Person_Student_Tlf_FAIL()
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
              "TLF",
              obj.TLF);

            _view.UpdateText = "11111111";
            _view.buttonUpdate();

            string expected = "99999999";
            string actual = _view.PersonList.FirstOrDefault().TLF.ToString();

            string expectedFeedback = "Fejl! person ikke opdateret";
            string actualFeedback = _view.UpdateResponseLabel;

            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expectedFeedback, actualFeedback);
        }
        [TestMethod]
        public void View_Update_First_Person_Merged_LastName()
        {

            _view.FilterText = "";
            _view.textChangeFilter();
            _view.buttonSort();

            Merged clicked = _view.PersonList.FirstOrDefault() as Merged;
            var obj = new Merged
            {
                TLF = clicked.TLF,
                FirstName = clicked.FirstName,
                LastName = clicked.LastName,
                Age = clicked.Age,
                Company = clicked.Company,
                Salary = clicked.Salary 
            };

            _view.gridListCLick(
              (IPerson)obj,
              "LastName",
              obj.LastName);

            _view.UpdateText = "Adamsq";
            _view.buttonUpdate();

            string expected = "Adamsq";
            string actual = _view.PersonList.FirstOrDefault().LastName;

            string expectedFeedback = "Opdatering gennemført!";
            string actualFeedback = _view.UpdateResponseLabel;

            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expectedFeedback, actualFeedback);
        }
        [TestMethod]
        public void View_Update_Last_Person_Merged_LastName()
        {

            _view.FilterText = "";
            _view.textChangeFilter();
            _view.buttonSort();

            Merged clicked = _view.PersonList.LastOrDefault() as Merged;
            var obj = new Merged
            {
                TLF = clicked.TLF,
                FirstName = clicked.FirstName,
                LastName = clicked.LastName,
                Age = clicked.Age,
                Company = clicked.Company,
                Salary = clicked.Salary
            };

            _view.gridListCLick(
              (IPerson)obj,
              "LastName",
              obj.LastName);

            _view.UpdateText = "McPeakq";
            _view.buttonUpdate();

            string expected = "McPeakq";
            string actual = _view.PersonList.LastOrDefault().LastName;

            string expectedFeedback = "Opdatering gennemført!";
            string actualFeedback = _view.UpdateResponseLabel;

            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expectedFeedback, actualFeedback);
        }


    }
}
