using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L2PCourseApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Field level constants
        const string CSHARP_COURSE_1 = "C# Fundamental", CSHARP_COURSE_2 = "C# Basic for Beginners", CSHARP_COURSE_3 = "C# Intermediate", 
            CSHARP_COURSE_4 = "C# Advanced Topics", CSHARP_COURSE_5 = "ASP.NET with C# Part A", CSHARP_COURSE_6 = "ASP.NET with C# Part A";

        const string LOCATION1 = "Belmullet", LOCATION2 = "Clifden", LOCATION3 = "Cork", LOCATION4 = "Dublin",
            LOCATION5 = "Kilarney", LOCATION6 = "Letterkenny", LOCATION7 = "Sligo";

        const int DAYS_2 = 2, DAYS_4 = 4, DAYS_5 = 5; 

        const decimal COURSE_1_FEES = 900m, COURSE_2_FEES = 1500m,
            COURSE_3_FEES = 1800m, COURSE_4_FEES = 2300m, COURSE_5_6_FEES = 1250m;

        const decimal BELMULLET_FEE = 219.99m, CLIFDEN_FEE = 119.99m, CORK_FEE = 149.99m, DUBLIN_FEE = 179.99m,
            KILARNEY_FEE = 149.99m, LETTERKENNEY_FEE = 89.99m, SLIGO_FEE = 119.99m;

        const decimal MASTER_UPGRADE_PRICE = 99.99m, EXECUTIVE_UPGRADE_PRICE = 69.99m, JUNIOR_UPGRADE_PRICE = 49.99m, 
            DIGI_CERT_PRICE = 39.99m, DISCOUNT = 0.075m;

        // Field level variables
        int TotalBookings = 0, TotalDiscountedBookings = 0, TotalAttendees = 0;
        decimal TotalBookingValue = 0, TotalEnrollmentFees = 0, TotalLodgingFees= 0, TotalOptionsValue = 0;

        // Display button variables for bookiing
        string Location = "", Course = ""; int TrainingDays = 0;
        int CourseIndex, LocationIndex, Attendees;
        decimal PerCourseFees = 0, PerDayLodgingFees = 0, LodgingFees = 0, OptionalCost = 0, BookingValue = 0, EnrollmentCost = 0;
        Boolean IsDiscountApplied = false; int DicountedBooking = 0;


        private void Form1_Load(object sender, EventArgs e)
        {
            BookButton.Enabled = false;
            SummaryButton.Enabled = false;
        }

        private void DisplayButton_Click(object sender, EventArgs e)
        {

            if (CourseListBox.SelectedIndex != -1)
            {
                if (LocationsListBox.SelectedIndex != -1)
                {
                    CourseIndex = CourseListBox.SelectedIndex;
                    LocationIndex = CourseListBox.SelectedIndex;

                    try
                    {
                        Attendees = int.Parse(AttendeesTextBox.Text);
                        switch(CourseIndex)
                        {
                            case 0: 
                                Course = CSHARP_COURSE_1;
                                TrainingDays = DAYS_2;
                                PerCourseFees = COURSE_1_FEES;
                                break;
                            case 1:
                                Course = CSHARP_COURSE_2;
                                TrainingDays = DAYS_4;
                                PerCourseFees = COURSE_2_FEES;
                                break;
                            case 2:
                                Course = CSHARP_COURSE_3;
                                TrainingDays = DAYS_4;
                                PerCourseFees = COURSE_3_FEES;
                                break;
                            case 3:
                                Course = CSHARP_COURSE_4;
                                TrainingDays = DAYS_2;
                                PerCourseFees = COURSE_4_FEES;
                                break;
                            case 4:
                                Course = CSHARP_COURSE_5;
                                TrainingDays = DAYS_5;
                                PerCourseFees = COURSE_5_6_FEES;
                                break;
                            case 5:
                                Course = CSHARP_COURSE_6;
                                TrainingDays = DAYS_5;
                                PerCourseFees = COURSE_5_6_FEES;
                                break;
                        }

                        switch (LocationIndex)
                        {
                            case 0:
                                Location = LOCATION1;
                                PerDayLodgingFees = BELMULLET_FEE;
                                break;
                            case 1:
                                Location = LOCATION2;
                                PerDayLodgingFees = CLIFDEN_FEE;
                                break;
                            case 2:
                                Location = LOCATION3;
                                PerDayLodgingFees = CORK_FEE;
                                break;
                            case 3:
                                Location = LOCATION4;
                                PerDayLodgingFees = DUBLIN_FEE;
                                break;
                            case 4:
                                Location = LOCATION5;
                                PerDayLodgingFees = KILARNEY_FEE;
                                break;
                            case 5:
                                Location = LOCATION6;
                                PerDayLodgingFees = LETTERKENNEY_FEE;
                                break;
                            case 6:
                                Location = LOCATION6;
                                PerDayLodgingFees = SLIGO_FEE;
                                break;
                        }

                        //Course cost calculation
                        EnrollmentCost = Attendees * PerCourseFees;
                        LodgingFees = Attendees * TrainingDays * PerDayLodgingFees;

                        // Check for Optional cost
                        decimal UpgradeCost = IsRadioButtonClicked();
                        OptionalCost = Attendees * UpgradeCost;

                        if (Attendees >= 3 && UpgradeCost > 0)
                        {
                            IsDiscountApplied = true;
                        }


                        //Total booking value computation
                        if (IsDiscountApplied)
                        {
                            BookingValue = (EnrollmentCost + (Attendees * PerDayLodgingFees * TrainingDays) + OptionalCost) - 
                                ((EnrollmentCost + (Attendees * PerDayLodgingFees * TrainingDays) + OptionalCost) * DISCOUNT);
                            DicountedBooking += 1;
                            DiscountedPriceLabel.Text = "Applicable discount on Booking value:" + "7.5%";
                            IsDiscountApplied = false;
                        }
                        else
                        {
                            BookingValue = ((Attendees * PerCourseFees) + (Attendees * PerDayLodgingFees * TrainingDays) + OptionalCost);
                        }

                        // Certificate check
                        if (DigiCertCheckBox.Checked == true)
                        {
                            BookingValue += Attendees * DIGI_CERT_PRICE;
                        }

                        DetailPanel.Enabled = false;
                        BookButton.Enabled = true;
                        DisplayButton.Enabled = false;

                        ResultLabel.Text = "\n" + "Selected Course : " + Course + "\n" + "Location: " + Location + "\n" + "Training Duration : " +
                        TrainingDays + "\n" + "Enrollment Cost: " + "€" + EnrollmentCost.ToString() + "\n" + "Lodging Cost for booking : "
                        + "€" + LodgingFees + "\n" + "Number Of Attendands: " + Attendees + "\n" + "Additional upgrades (Suite Upgrade/Certificate): " + "€" +
                        OptionalCost + "\n" + "Total Cost: " + "€" + BookingValue;
                    }
                    catch
                    {
                        MessageBox.Show("Please enter a numerical value for attendees", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        AttendeesTextBox.Focus();
                    }
                }else
                {
                    MessageBox.Show("Please select a Location to continue", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    LocationsListBox.Focus();
                }
            }else
            {
                MessageBox.Show("Please select a Course to continue", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CourseListBox.Focus();
            }
        }

        private void BookButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to confirm the booking?", "User confirmation", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("Selected Course : " + Course + "\n" + "Selected Location : " + Location + "\n" + "Total Booking value : " + BookingValue, "Booking Confirmed!!", MessageBoxButtons.OK);
                
                TotalBookings += 1; TotalBookingValue += BookingValue; TotalEnrollmentFees += EnrollmentCost; TotalLodgingFees += LodgingFees;
                TotalOptionsValue += OptionalCost; TotalDiscountedBookings += DicountedBooking; TotalAttendees += Attendees;
                ClearButton.PerformClick();
                SummaryButton.Enabled = true;
                
            }
            else
            {
                Location = ""; Course = ""; TrainingDays = 0;
                CourseIndex = 0; LocationIndex = 0; Attendees = 0;
                PerCourseFees = 0; PerDayLodgingFees = 0; LodgingFees = 0; OptionalCost = 0; BookingValue = 0; EnrollmentCost = 0;
                IsDiscountApplied = false; DicountedBooking = 0;
                ClearButton.PerformClick();
            }

            DetailPanel.Enabled = true;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ResultLabel.Text = "";
            DiscountedPriceLabel.Text = "";
            AttendeesTextBox.Text = "";
            DigiCertCheckBox.Checked = false;
            MasterSuiteRB.Checked = false;
            ExecutiveSuiteRB.Checked = false;
            JuniorSuiteRB.Checked = false;
            CourseListBox.SelectedIndex = -1;
            LocationsListBox.SelectedIndex = -1;
            BookButton.Enabled = false;
            DetailPanel.Enabled = true;
            DisplayButton.Enabled = true;
        }

        private void SummaryButton_Click(object sender, EventArgs e)
        {
            ResultLabel.Text = "\n" + "Total Bookings Count : " + TotalBookings + "\n" + "Total Fees after Enrollment : " + TotalEnrollmentFees + "\n" + "Total Lodging Fees : " +
                        TotalLodgingFees + "\n" + "Total value of Options sold: " + "€" + OptionalCost.ToString() + "\n" + "Number of group Discounts given : "
                        + TotalDiscountedBookings + "\n" + "Total Number of Attendees : " + TotalAttendees + "\n" + "Additional upgrades (Suite Upgrade/Certificate) sold: " + "€" +
                        OptionalCost + "\n" + "Total Cost: " + "€" + BookingValue;
        }

        private decimal IsRadioButtonClicked()
        {
            if (MasterSuiteRB.Checked == true)
            {
                return MASTER_UPGRADE_PRICE;
            }
            else if (ExecutiveSuiteRB.Checked == true)
            {
                return EXECUTIVE_UPGRADE_PRICE;
            }
            else if (JuniorSuiteRB.Checked == true)
            {
                return JUNIOR_UPGRADE_PRICE;
            }
            return 0;
        }

    }
}
