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
namespace View
{
    public partial class form2 : Form
    {
        public form2()
        {
            InitializeComponent();
        }

        #region Declerations and properties
        public int empID { get; set; }
        const string SUCCESS = null;
       
        static List<TextBox> tags;
        static List<hourError> errors;
       
        #endregion

        private void Form2_Load(object sender, EventArgs e)
        {
            lblID.Text = "Add hours worked for: " + empID;
            this.ControlBox = false;
            this.Owner.Visible = false;
        }

        #region Insert Hours
        private void btnInsert_Click(object sender, EventArgs e)
        {
            //validate form
            List<hourError> errors = ValidateHours(gbHours);
            //get error messages in string
            string err = GetErrorMsg();
            //print out error messages if found else continue code
            if (err != SUCCESS)
            {
                MessageBox.Show(err);
                tags[0].Focus();
                return;
            }

            //set working hours into hour Working hour class
            WorkingHour hour = new WorkingHour();
            hour.EmpID = empID;
            hour.Hours = double.Parse(txtHours.Text);
            hour.WorkDate = txtDate.Text;
            //return the result enum when attempting to insert into DB

            ResultEnum result = Insert(hour);

            if(result == ResultEnum.Success)
            {
               
                MessageBox.Show("Successfully entered Working Hours");
            }
            else
            {
                MessageBox.Show("An Unexpected Error Occured");
            }
            
        }
        #endregion

        #region db Insert
        private ResultEnum Insert(WorkingHour hour)
        {
            EmpHourController controller = new EmpHourController();
            return controller.Insert(hour);
        }
        #endregion

        #region validation
        private static List<hourError> ValidateHours(GroupBox gb)
        {
            errors = new List<hourError>();
            tags = new List<TextBox>();
           
            foreach (Control tb in gb.Controls)
            {
                if (!(tb is TextBox))
                {
                    continue;
                }
                if (string.IsNullOrWhiteSpace(tb.Text))
                {
                    errors.Add(hourError.nullError);
                    tags.Add(tb as TextBox);
                    continue;
                }
                if (tb.Text.Contains(" "))
                {
                    errors.Add(hourError.spaceError);
                    tags.Add(tb as TextBox);
                    continue;

                }
                switch (tb.Tag)
                {
                    case "Date":
                        DateTime date;
                        if (DateTime.TryParse(tb.Text, out date) == false)
                        {
                            errors.Add(hourError.dateError);
                            tags.Add(tb as TextBox);
                        }
                        else
                        {
                            errors.Add(hourError.Success);
                        }
                        break;
                    case "Hours":
                        double x;
                        if(double.TryParse(tb.Text, out x) == false)
                        {
                            errors.Add(hourError.dateError);
                            tags.Add(tb as TextBox);
                        }
                        else
                        {
                            errors.Add(hourError.Success);
                        }
                        break;

                }
              
            }
            return errors;

        }

        private static string GetErrorMsg()
        {
            int i = 0;
            string err = SUCCESS;

            foreach(hourError error in errors)
            {
                switch (error)
                {
                    case hourError.nullError:
                        err += "TextBox cannot Contain null values at: " + tags[i].Tag.ToString() + "\n";
                       
                        break;
                    case hourError.spaceError:
                       err += "Text Box cannot contain spaces at: " + tags[i].Tag.ToString() + "\n";
                        break;
                    case hourError.dateError:
                        err += "Invalid Date added!" + "\n";
                        break;
                    case hourError.hourError:
                        err += "Hours Must me numeric!";
                        break;
                    default:
                        err = SUCCESS;
                        continue;
                }
                i++;
            }
            return err;
        }

        #endregion

        #region exit view
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Owner.Visible = true;
          
        }

        protected override void OnClosed(EventArgs e)
        {
            this.Owner.Visible = true;
            base.OnClosed(e);
        }
        #endregion
    }
}
