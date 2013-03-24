using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;

using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApplication3
{
    public partial class SchedulerForm : Form
    {
        WindowsServiceMonitor nuMON =
            new WindowsServiceMonitor();

        public SchedulerForm()
        {

           
                InitializeComponent();

               // POP();
                Thread T = new Thread(nuMON.StartMonitor);
                T.Start();
                //nuMON.StartMonitor();
                //Console.ReadLine();
                //System.Threading.Thread.Sleep(10000);
                //System.Windows.Forms.MessageBox.Show("sadasd");

        

        }



        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
           // this.nuMON.Dispose();
        }
        CustomProgressForm frm = new CustomProgressForm();
        //NotificationSplash notSplashForm = new NotificationSplash();

        public void POP()
        {
            WindowsServiceMonitor nuMON =
              new WindowsServiceMonitor();

            while (true)
            {
                nuMON.StartMonitor();
                //Console.ReadLine();
                //System.Threading.Thread.Sleep(10000);
                System.Windows.Forms.MessageBox.Show("sadasd");

            }

        }

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

            //MessageBox.Show("Date : " + dateTimePickerText + " " + "\nTime : " + dateTimePickerTimeText + "\nSchedule Chosen : " + checkedRadioButton.ToUpper());
            Schedule.Text = "Date : " + dateTimePickerText + " " + "  Time : " + dateTimePickerTimeText + "\n\nSchedule Chosen :" + checkedRadioButton.ToUpper();


            for (int i = 0; i <= 100; i++)
            {

                frm.UpdateProgressBar(i);
            }

        }

        private void SchedulerForm_Load(object sender, EventArgs e)
        {
            //nuMON.StartMonitor();
           
        }


    }
}

