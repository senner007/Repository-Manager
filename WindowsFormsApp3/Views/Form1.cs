using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Manager.Models;
using Manager.Presenter;
using System.Runtime.InteropServices;


namespace Manager.Views
{
    partial class Form1 : Form, IFind, IUpdateDelete, ICreate // TODO : forbedre UI look
    {
        public Form1()
        {
            InitializeComponent();
             AllocConsole();    
            _updatedDeletePresenter = new UpdateDeletePresenter(this); // instantiate UpdateDeletePresenter presenter
            _createPresenter = new CreatePresenter(this);
            _findPresenter = new FindPresenter(this, _updatedDeletePresenter, _createPresenter); 
            // instantiate FindPresenter presenter - indsæt presenters for at kalde event i findpresenter
        }

        [DllImport("kernel32.dll", SetLastError = true)] // Console output
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        public FindPresenter _findPresenter;
        public UpdateDeletePresenter _updatedDeletePresenter;
        public CreatePresenter _createPresenter;

        //IFind View-Presenter--------------
        public IEnumerable<IPerson> PersonList { get => (IEnumerable<IPerson>)dataGridView1.DataSource;  set => dataGridView1.DataSource = value; }
        public bool SortNameRadio => radioOrderByName.Checked;
        public bool SortAgeRadio => radioOrderByAge.Checked;
        public bool Sort_Salary_Major_Type_Radio => radioOrderBySalary.Checked;
        public bool ShowStudentsCheck { get => chkStudent.Checked; set => chkStudent.Checked = value; }
        public bool ShowEmployedCheck { get => chkEmployed.Checked; set => chkEmployed.Checked = value; }
        public bool SortDirectionCheck { get => chkSortDirection.Checked; set => chkSortDirection.Checked = value; }
        public string FilterText => txtFilter.Text;
        public event Action OnShow;

     
        // IUpdateDelete View-Presenter--------------------
        public event EventWithArgs OnListClick; 
        public event EventHandler<EventArgs> OnUpdate;
        public event EventNoArgs OnTextUpdate;
        
        public string UpdateText { get => txtUpdateProperty.Text; set => txtUpdateProperty.Text = value; }
        public string PropertyLabel { get => labelUpdateProperty.Text ; set => labelUpdateProperty.Text = value; }
        public string ErrorLabel { get => labelError.Text; set => labelError.Text = value; }
        public string PersonInfoLabel { get => labelPersonInfo.Text; set => labelPersonInfo.Text = value; }


        // TODO : individuelle access modifiers
        // ICreate View-Presenter--------------------
        public string CreateFirstNameText { get => txtCreateFirstName.Text; set => txtCreateFirstName.Text = value; }
        public string CreateLastNameText { get => txtCreateLastName.Text; set => txtCreateLastName.Text = value; }
        public string CreateAgeText { get => txtCreateAge.Text; set => txtCreateAge.Text = value; }
        public string CreateTlfText { get => txtCreateTlf.Text; set => txtCreateTlf.Text = value; }
        public string CreateCompanyText { get => txtCreateCompany.Text; set => txtCreateCompany.Text = value; }
        public string CreateSalaryText { get => txtCreateSalary.Text; set => txtCreateSalary.Text = value; }
        public string CreateMajorText { get => txtCreateMajor.Text; set => txtCreateMajor.Text = value; }

        public bool CreateStudentRadio { get => radioCreateStudent.Checked; set => radioCreateStudent.Checked = value; }
        public bool CreateEmployedRadio {  get => radioCreateEmployed.Checked; set => radioCreateEmployed.Checked = value; }

        public string _errorCreateFirstNameText { get => labelCreateFirstName.Text; set => labelCreateFirstName.Text = value; }
        public string _errorCreateLastNameText { get => labelCreateLastName.Text; set => labelCreateLastName.Text = value; }
        public string _errorCreateAgeText { get => labelCreateAge.Text; set => labelCreateAge.Text = value; }
        public string _errorCreateTlfText { get => labelCreateTlf.Text; set => labelCreateTlf.Text = value; }
        public string _errorCreateCompanyText { get => labelCreateCompany.Text; set => labelCreateCompany.Text = value; }
        public string _errorCreateSalaryText { get => labelCreateSalary.Text; set => labelCreateSalary.Text = value; }
        public string _errorCreateMajorText { get => labelCreateMajor.Text; set => labelCreateMajor.Text = value; }

        public event Action OnCreate;
        public event Action OnDisplayLabels;
        public event Action OnDelete;

        // hent og sorter liste - TODO : nødvendig? eller opdater automatisk ved ændring af visning og sorteringsindstilling
        private void ColumnOrder()
        {
            dataGridView1.Columns["Type"].DisplayIndex = 0; // sikrer samme rækkefølge
            dataGridView1.Columns["FirstName"].DisplayIndex = 1;
            dataGridView1.Columns["LastName"].DisplayIndex = 2;
            dataGridView1.Columns["Age"].DisplayIndex = 3;
            dataGridView1.Columns["TLF"].DisplayIndex = 4;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // stræk for udfulde plads
            // dataGridView1.AutoResizeColumns();
            dataGridView1.AutoResizeRows();
            dataGridView1.Columns["Type"].Width = 80;
            dataGridView1.Columns["FirstName"].Width = 120;
            dataGridView1.Columns["LastName"].Width = 120;
            dataGridView1.Columns["Age"].Width = 50;
            dataGridView1.Columns["TLF"].Width = 80;
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {         
            OnShow(); 
            ColumnOrder();
        }
        // kaldes for hver tekstændring i filtertekstboks - opdaterer liste efter hver ændring
        private void textFilter_TextChanged(object sender, EventArgs e) 
        {
            // OnShow();
            OnShow();
            ColumnOrder();

        }
        // opdater person
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            OnUpdate.Invoke(labelPersonInfo.Text, EventArgs.Empty);
        }

        // find person med egenskab til opdatering eller sletning
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)     
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return; // hvis der klikkes på en række eller kolonne uden data
           // Console.WriteLine(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].DataGridView.DataSource);

            IPerson currentObject = (IPerson)dataGridView1.CurrentRow.DataBoundItem; // udtræk person object(value) fra datagrid
            Console.WriteLine(dataGridView1.CurrentRow.Selected); 
            var propValue = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;


            OnListClick.Invoke(
                currentObject,  
                propValue != null ? dataGridView1.Columns[e.ColumnIndex].HeaderText : "", // kolonnenavn
                propValue != null ? propValue.ToString() : ""); // cellens værdi

            Console.WriteLine("Række index: " + e.RowIndex.ToString() + " Kolonne index: " + e.ColumnIndex.ToString()); // find række og kolonne index
        }
        // sort retning - opdaterer liste efter tryk.
        private void chkSortDirection_CheckedChanged(object sender, EventArgs e)
        {
            chkSortDirection.Text = chkSortDirection.Checked ? "Asc" : "Desc";
            //https://stackoverflow.com/questions/30717616/winform-image-toggle-button
        }
        // checkbokse for at vælge mellem student og/eller employed visning
        private void chkStudentEmployed_CheckedChanged(object sender, EventArgs e) // Student og Employed check button clicked
        {
            if (chkStudent.Checked && !chkEmployed.Checked)
            {
                radioOrderBySalary.Text = "Sorter efter FAG";
            }
            else if (!chkStudent.Checked && chkEmployed.Checked)
            {
                radioOrderBySalary.Text = "Sorter efter LØN";
            }
            else
            {
                radioOrderBySalary.Text = "Sorter efter TYPE";
            }
        }
        // kaldes for hver tekstændring - validerer input med feedback
        private void txtUpdateProperty_TextChanged(object sender, EventArgs e) => OnTextUpdate();
        // opret person
        private void buttonCreate_Click(object sender, EventArgs e) => OnCreate();  
        // kaldes for hver tekstændring under oprettelse af personer. Alle tekstbokse ved personoprettelse er bundet til denne event
        private void createText_TextChanged(object sender, EventArgs e) => OnDisplayLabels();
        // slet person
        private void buttonDelete_Click(object sender, EventArgs e) => OnDelete();
     
    }
}
