using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Controller;
using System.Net.Mail;


namespace View
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Declarations
        const string SUCCESS = null;
        static List<TextBox> tags;
        static List<EmployeeError> errors;
        List<Employee> employees;
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            btnUpdate.Visible = false;
            btnCancel.Visible = false;

            Result result = RefreshEmployeeDB();
            if (result.Status == ResultEnum.Success)
            {
                DataDisplay(result);

            }
            else
            {
                MessageBox.Show("Error Loading Database.");
            }

            Report report = RefreshReportDB();
            if(report.Status == ResultEnum.Success)
            {
                DisplayReport(report);
            }
        }

        #region Insert Employee
        private void btnCreate_Click(object sender, EventArgs e)
        {

            List<EmployeeError> errors = ValidateEmployee(gbInsert);
            string err = GetErrorMsg();
            if (err != SUCCESS)
            {
                MessageBox.Show(err);
                tags[0].Focus();
                return;
            }
            ResultEnum result = Insert();

            if (result == ResultEnum.Success)
            {
                MessageBox.Show("Successfully Created Employee in Database.");
            }
            else
            {
                MessageBox.Show("An Unexpected Error occured. Please contact Admin");
            }
        }

        #endregion

        #region Edit/Update Employee
        private void btnRefresh_Click(object sender, EventArgs e)
        {

            Result display = RefreshEmployeeDB();


            if (display.Status == ResultEnum.Success)
            {

                DataDisplay(display);

            }

            else
            {
                MessageBox.Show("Error occured while refreshing database Data. please contact admin.");
            }

        }

      

        private void lbID_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lbID.SelectedIndex;
            Employee emp = employees[index];
            txtEditFirst.Text = emp.FirstName;
            txtEditLast.Text = emp.LastName;
            txtEditPhone.Text = emp.EmployeePhone;
            txtEditEmail.Text = emp.EmployeeEmail;
            txtEditDOB.Text = emp.EmployeeDOB;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnUpdate.Visible = true;
            btnCancel.Visible = true;

            txtEditFirst.Enabled = true;
            txtEditLast.Enabled = true;
            txtEditPhone.Enabled = true;
            txtEditEmail.Enabled = true;
            txtEditDOB.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            List<EmployeeError> errors = ValidateEmployee(gbDetails);
            string err = GetErrorMsg();
            if (err != SUCCESS)
            {
                MessageBox.Show(err);
                tags[0].Focus();
                return;
            }
            ResultEnum result = Update(lbID.SelectedIndex);

            if (result == ResultEnum.Success)
            {
                MessageBox.Show("Successfully Updated Employee Details.");
            }
            else
            {
                MessageBox.Show("An Unexpected Error occured. Please contact Admin");
            }

            ResetForm();
        }
        #endregion

        #region Enter Hours
        private void btnEnter_Click(object sender, EventArgs e)
        {
            form2 form = new form2();
            form.empID = int.Parse(lbID.Text);
            form.Owner = this;
            form.ShowDialog();

           

        }
        #endregion

        #region Employee Hour Reports
        private void btnHourRep_Click(object sender, EventArgs e)
        {

            Report report = RefreshReportDB();

            if (report.Status == ResultEnum.Success)
            {
                DisplayReport(report);

            }
            else
            {
                MessageBox.Show("Could not retrieve Employee Reports at this time. Please Contact administrator.");
            }
        }
      
        private void lbEmpID_SelectedIndexChanged(object sender, EventArgs e)
        {
            EmployeeReport empReport = (EmployeeReport)lbEmpID.SelectedValue;
            int ID = empReport.EmpID;


            EmpHourController controller = new EmpHourController();
            HourResult result = controller.GetHours(ID);


            if (result.status == ResultEnum.Success)
            {
                var bindingList = new BindingList<WorkingHour>(result.hours);

                var source = new BindingSource(bindingList, null);
                txtTotal.Text = empReport.TotalHours.ToString();
                dataGridView2.DataSource = source;
                dataGridView2.Columns[1].Visible = false;

            }
            else
            {
                MessageBox.Show("Failed To generate Employee Data. Please Contact Admin");
            }


        }

        #endregion

        #region misc.
        private void ResetForm()
        {
            btnUpdate.Visible = false;
            btnCancel.Visible = false;
            txtEditDOB.Enabled = false;
            txtEditEmail.Enabled = false;
            txtEditFirst.Enabled = false;
            txtEditLast.Enabled = false;
            txtEditPhone.Enabled = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ResetForm();
            Result result = RefreshEmployeeDB();
            if (result.Status == ResultEnum.Success)
            {
                DataDisplay(result);

            }
            else
            {
                MessageBox.Show("Could not reset Database at this Time");
            }
        }

        private void Form1_VisibilityChanged(object sender, EventArgs e)
        {
            if (this.Enabled == true)
            {
                Report report = RefreshReportDB();


                if (report.Status == ResultEnum.Success)
                {
                    DisplayReport(report);
                }
                else
                {
                    MessageBox.Show("Unexpected Error Occured.");
                }
            }
        }

        #endregion

        #region Insert/Update/Refresh Database
        private ResultEnum Update(int index)
        {
            Employee employee = employees[index];

            employee.FirstName = txtEditFirst.Text;
            employee.LastName = txtEditLast.Text;
            employee.EmployeeDOB = txtEditDOB.Text;
            employee.EmployeeEmail = txtEditEmail.Text;
            employee.EmployeePhone = txtEditPhone.Text;

            EmployeeController controller = new EmployeeController();
            ResultEnum result = controller.UpdateEmployee(employee);

            return result;

        }

        private ResultEnum Insert()
        {
            Employee emp = new Employee();

            emp.FirstName = txtFirst.Text;
            emp.LastName = txtLast.Text;
            emp.EmployeeDOB = txtDOB.Text;
            emp.EmployeeEmail = txtEmail.Text;
            emp.EmployeePhone = txtPhone.Text;

            EmployeeController controller = new EmployeeController();
            ResultEnum result = controller.Add(emp);

            Result refreshDB = RefreshEmployeeDB();
            DataDisplay(refreshDB);

            return result;
        }

        private Result RefreshEmployeeDB()
        {
            EmployeeController controller = new EmployeeController();
            return controller.GetEmployeeList();

        }

        private void DataDisplay(Result display)
        {
            employees = display.Data;
            lbID.DataSource = employees;
            lbID.DisplayMember = "employeeID";
            btnEnter.Enabled = true;
            btnEdit.Enabled = true;
        }

        private Report RefreshReportDB()
        {
            EmpReportController controller = new EmpReportController();
            return controller.GetReport();
        }

        private void DisplayReport(Report report)
        {
            lbEmpID.DataSource = report.EmpReport;
            lbEmpID.DisplayMember = "EmpID";
        }
        #endregion

        #region Validation
        private static List<EmployeeError> ValidateEmployee(GroupBox gb)
        {
            //initialise our error list and tags to generate useful error messages
            errors = new List<EmployeeError>();
            tags = new List<TextBox>();

            foreach (Control tb in gb.Controls)
            {
                //go to the next iteration if control type is not TextBox
                if (!(tb is TextBox))
                {
                    continue;
                }
                //null and whitespace validation checking
                if (string.IsNullOrWhiteSpace(tb.Text))
                {
                    errors.Add(EmployeeError.nullError);
                    tags.Add(tb as TextBox);
                    continue;
                }
                //checks if the textbox contains a whitespace
                if (tb.Text.Contains(" "))
                {
                    errors.Add(EmployeeError.spaceError);
                    tags.Add(tb as TextBox);
                    continue;
                }
                switch (tb.Tag)
                {
                    //validate first and last names for letters only
                    case "First Name":
                    case "Last Name":
                        if (tb.Text.Any(c => char.IsDigit(c)))
                        {
                            errors.Add(EmployeeError.nameError);
                            tags.Add(tb as TextBox);
                        }
                        else
                        {
                            errors.Add(EmployeeError.success);
                        }
                        break;
                    //validate email address
                    case "Email":
                        try
                        {
                            MailAddress mail = new MailAddress(tb.Text);
                            errors.Add(EmployeeError.success);
                        }
                        catch (FormatException)
                        {
                            errors.Add(EmployeeError.EmailError);
                            tags.Add(tb as TextBox);

                        }


                        break;
                    //validation for phone
                    case "Phone":
                        int n = 0;
                        if (int.TryParse(tb.Text, out n) == false || tb.Text.Length != 10)
                        {
                            errors.Add(EmployeeError.PhoneError);
                            tags.Add(tb as TextBox);
                        }
                        else
                        {
                            errors.Add(EmployeeError.success);

                        }
                        break;
                    case "DOB":
                        //validation for date
                        DateTime dob;
                        bool d = DateTime.TryParse(tb.Text, out dob);
                        if (d == false)
                        {
                            errors.Add(EmployeeError.dateError);
                            tags.Add(tb as TextBox);
                        }
                        else
                        {
                            tb.Text = dob.ToString("yyyy/MM/dd");
                            errors.Add(EmployeeError.success);

                        }
                        break;

                }


            }
            return errors;
        }

        private static string GetErrorMsg()
        {
            //index value for lists
            int i = 0;
            //default error message defaults to success if no error is found
            string err = SUCCESS;
            foreach (EmployeeError error in errors)
            {


                switch (error)
                {
                    //relevant errors are entered
                    case EmployeeError.nullError:
                        err += "Please Enter Input at: " + tags[i].Tag.ToString() + "\n";
                        break;
                    case EmployeeError.nameError:
                        err += "Please enter letters only in " + tags[i].Tag.ToString() + "\n";
                        break;
                    case EmployeeError.EmailError:
                        err += "please enter a valid email eg. joe@live.com " + "\n";
                        break;
                    case EmployeeError.PhoneError:
                        err += "please enter a valid phone number eg. 0411339977 " + "\n";
                        break;
                    case EmployeeError.dateError:
                        err += "please enter a valid date in the format YYYY/MM/DD " + "\n";
                        break;
                    case EmployeeError.spaceError:
                        err += "Please Do not enter Whitespaces at: " + tags[i].Tag.ToString() + "\n";
                        break;
                    default:

                        continue;
                }
                i++;
            }
            return err;
        }


        #endregion

      
    }
}
