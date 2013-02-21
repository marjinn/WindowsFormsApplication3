using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class SchedulerForm : Form
    {
        public SchedulerForm()
        {
            InitializeComponent();
        }

       

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
        CustomProgressForm frm = new CustomProgressForm();
        //NotificationSplash notSplashForm = new NotificationSplash();



        private void Save_Schedule_Click(object sender, EventArgs e)
        {
            try
            {
                frm.Show();
                //notSplashForm.ShowDialog();

            }
            catch (System.ObjectDisposedException)
            {
                CustomProgressForm frm = new CustomProgressForm();
                frm.ShowDialog();
            }

            finally
            {

            }
            string dateTimePickerText = dateTimePicker1.Text.ToString();
            string dateTimePickerTimeText = dateTimePicker2.Text.ToString();
            string checkedRadioButton = "";
            if (radioButtonMonthly.Checked == true)
            {
                checkedRadioButton = radioButtonMonthly.Text;
            }



            if (radioButtonWeekly.Checked == true)
            {
                checkedRadioButton = radioButtonWeekly.Text;
            }



            if (radioButtonDaily.Checked == true)
            {
                checkedRadioButton = radioButtonDaily.Text;
            }



            if (radioButtonDateOfChoice.Checked == true)
            {
                checkedRadioButton = radioButtonDateOfChoice.Text;
            }

            MessageBox.Show("Date : " + dateTimePickerText + " " + "\nTime : " + dateTimePickerTimeText + "\nSchedule Chosen : " + checkedRadioButton.ToUpper());
            Schedule.Text = "Date : " + dateTimePickerText + " " + "\t\t\t\t  Time : " + dateTimePickerTimeText + "\n\nSchedule Chosen :" + checkedRadioButton.ToUpper();

        }
    }
}
