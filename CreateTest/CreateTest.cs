using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Manager.Models;
using Manager.Presenter;
using Manager.Views;
using System.Reflection;
using System.Linq;
using System.Diagnostics;
using System.Collections.Generic;

namespace CreateTest
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
            _readPresenter = new ReadPresenter(_view, _updateDeletePresenter, _createPresenter);
            _view.FilterText = "";
        }
        [TestCleanup()]
        public void Cleanup()
        {// Clear static class for hver test https://colinmackay.scot/2007/06/16/unit-testing-a-static-class/

            Type staticType = typeof(PersonRepository);
            ConstructorInfo ci = staticType.TypeInitializer;
            object[] parameters = new object[0];
            ci.Invoke(null, parameters);
        }
        [TestMethod]
        public void Model_Create_Person()
        {
            _view.CreateFirstNameText = "Abraham";
            _view.CreateLastNameText = "Lincoln";
            _view.CreateAgeText = "19";
            _view.CreateTlfText = "11111112";
            _view.CreateMajorText = "Computer Science 101";
            _view.CreateStudentRadio = true;

            _view.buttonCreate();

            string expected = "Abraham Lincoln, Alder: 19, Tlf: 11111112, Student";
            string actual = _manage.GetPeople.ToList()[8].ToString();

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Model_Create_Person_Tlf_FAIL()
        {
            _view.CreateFirstNameText = "Abraham";
            _view.CreateLastNameText = "Lincoln";
            _view.CreateAgeText = "19";
            _view.CreateTlfText = "22222222";
            _view.CreateMajorText = "Computer Science 101";
            _view.CreateStudentRadio = true;

            _view.buttonCreate();

            string expected = "Jeremy McPeak, Alder: 40, Tlf: 55555555, Employed";
            string actual = _manage.GetPeople.ToList()[8].ToString();

            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void View_Create_Person()
        {
            _view.CreateFirstNameText = "Abraham";
            _view.CreateLastNameText = "Lincoln";
            _view.CreateAgeText = "19";
            _view.CreateTlfText = "11111112";
            _view.CreateMajorText = "Computer Science 101";
            _view.CreateStudentRadio = true;

            _view.buttonCreate();

            string expected = "Abraham Lincoln, Alder: 19, Tlf: 11111112, Student";
            string actual = _view.PersonList.ToList()[8].ToString();

            Assert.AreEqual(expected, actual);

            string expectedFededback = "Oprettet!";
            string actualFeedback = _view.CreatePersonLabel;

            Assert.AreEqual(expectedFededback, actualFeedback);
        }
        [TestMethod]
        public void View_Create_Person_TLF_Fail()
        {
            _view.textChangeFilter();
            _view.CreateFirstNameText = "Abraham";
            _view.CreateLastNameText = "Adams";
            _view.CreateAgeText = "19";
            _view.CreateTlfText = "22222222";
            _view.CreateMajorText = "Computer Science 101";
            _view.CreateStudentRadio = true;

            _view.buttonCreate();

            string expected = "Poul Adams, Alder: 40, Tlf: 33333333, Employed";
            string actual = _view.PersonList.FirstOrDefault().ToString();

            Assert.AreEqual(expected, actual);

            string expectedFededback = "Fejl! - ikke oprettet";
            string actualFeedback = _view.CreatePersonLabel;

            Assert.AreEqual(expectedFededback, actualFeedback);
        }
        [TestMethod]
        public void View_Create_Person_TLF_Leading_Zeroes()
        {
            _view.CreateFirstNameText = "Abraham";
            _view.CreateLastNameText = "Lincoln";
            _view.CreateAgeText = "19";
            _view.CreateTlfText = "00000001";
            _view.CreateMajorText = "Computer Science 101";
            _view.CreateStudentRadio = true;

            _view.buttonCreate();

            string expected = "Abraham Lincoln, Alder: 19, Tlf: 00000001, Student";
            string actual = _view.PersonList.ToList()[8].ToString();

            Assert.AreEqual(expected, actual);

            string expectedFededback = "Oprettet!";
            string actualFeedback = _view.CreatePersonLabel;

            Assert.AreEqual(expectedFededback, actualFeedback);
        }
        [TestMethod]
        public void View_Create_Person_LastName_RepeatingLetters()
        {
            _view.CreateFirstNameText = "Anton";
            _view.CreateLastNameText = "Aagard";
            _view.CreateAgeText = "19";
            _view.CreateTlfText = "12345678";
            _view.CreateMajorText = "Computer Science 101";
            _view.CreateStudentRadio = true;

            _view.buttonCreate();

            string expected = "Anton Aagard, Alder: 19, Tlf: 12345678, Student";
            string actual = _view.PersonList.ToList()[0].ToString();

            Assert.AreEqual(expected, actual);

            string expectedFededback = "Oprettet!";
            string actualFeedback = _view.CreatePersonLabel;

            Assert.AreEqual(expectedFededback, actualFeedback);
        }
    }
}
