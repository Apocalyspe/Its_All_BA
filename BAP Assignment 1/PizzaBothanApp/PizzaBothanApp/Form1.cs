/*  Author :  Harsh Kulkarni
 *  UoG    :  22221739
 *  Module :  Business Application Programming (MS806)
 *  Project:  Pizza Order Application
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaBothanApp
{
    public partial class PizzaBothanForm : Form
    {

        public PizzaBothanForm()
        {
            InitializeComponent();

        }

        // Field level variables
        int TotalCompanyOrders = 0;
        string ServerName;
        int TotalPizzaOrdered = 0;
        decimal TotalCompanyReceipts;
        decimal AvgTransactionReceipt = 0.00m;
        int TotalHamPizzas, TotalPepperoniPizzas, TotalPineapplePizzas, TotalCalzoniPizzas;
        
        // Field level Constants (Pizza Prices)
        const decimal HAM_PIZZA_PRICE = 7.99m, PEPPERONI_PIZZA_PRICE = 8.99m,
            PINEAPPLE_PIZZA_PRICE = 9.99m, CALZONI_PIZZA_PRICE = 11.99m;

        private void OnPizzaBothanFormLoad(object sender, EventArgs e)
        {
            OrderPanel.Visible = false;
            TotalPizzaSoldGroupBox.Visible = false;
            if (TotalCompanyOrders > 0)
            {
                SummaryButton.Enabled = true;
            }
            
           
        }

        /* 
         * Event handler to handle START button click event
         */
        private void StartButtonClick(object sender, EventArgs e)
        {
            // Getting input server name and table number and setting while order screen
            string TableNumber;
            ServerName = ServerNameTextBox.Text;
            TableNumber = TableNumberTextBox.Text;
            this.Text = ServerName + " @ Table " + TableNumber;

            // Toggling visibility
            TotalPizzaSoldGroupBox.Visible = false;
            OrderPanel.Visible = true;
            MenuGroupBox.Enabled = true;
            LoginCredsPanel.Visible = false;
            HamPizzaTextBox.Focus();
          
        }

        /* 
         * Event handler to handle ORDER button click event
         */
        private void OrderButtonClick(object sender, EventArgs e)
        {

            try
            {
                //Local Variables
                int HamPizzaCount, PepperoniPizzaCount,
                    PineapplePizzaCount, CalzoniPizzaCount;
                decimal TotalTableReceipt, TotalPineapplePizzaCost,
                    TotalHamPizzaCost, TotalCalzoniPizzaCost,
                    TotalPepperoniPizzaCost;
                int TotalPizzaCount;

                // User input for number of Ham Pizza
                HamPizzaCount = int.Parse(HamPizzaTextBox.Text);

                try
                {
                    // User input for number of Pepperoni Pizza
                    PepperoniPizzaCount = int.Parse(PepperoniPizzaTextBox.Text);

                    try
                    {
                        // User input for number of Pineapple Pizza
                        PineapplePizzaCount = int.Parse (PineapplePizzaTextBox.Text);

                        try
                        {
                            // User input for number of Calzoni Pizza
                            CalzoniPizzaCount = int.Parse(CalzoniPizzaTextBox.Text);
                            try
                            {
                                // Calculation for total pizza count
                                TotalPizzaCount = PineapplePizzaCount + PepperoniPizzaCount
                                    + CalzoniPizzaCount + HamPizzaCount;
                                
                                // Calculation for total pizza cost
                                TotalHamPizzaCost = HamPizzaCount * HAM_PIZZA_PRICE;
                                TotalPepperoniPizzaCost = PepperoniPizzaCount * PEPPERONI_PIZZA_PRICE;
                                TotalPineapplePizzaCost = PineapplePizzaCount * PINEAPPLE_PIZZA_PRICE;
                                TotalCalzoniPizzaCost = CalzoniPizzaCount * CALZONI_PIZZA_PRICE;

                                // Calculation for total table receipt
                                TotalTableReceipt = TotalHamPizzaCost + TotalPepperoniPizzaCost
                                    + TotalPineapplePizzaCost + TotalCalzoniPizzaCost;


                                // Table Order Summary Group Box Computation
                                TableOrderServerName.Text = ServerName;
                                TableOrderNumberPizzas.Text = (TotalPizzaCount).ToString();
                                TableOrderReceipts.Text = (TotalTableReceipt).ToString("C");

                                // Incrementing Total Company Orders
                                TotalCompanyOrders += 1;

                                // Local Private method to Update Total Company Summary data
                                UpdateTotalCompanySummary(TotalCompanyOrders,
                                    TotalTableReceipt,
                                    TotalPizzaCount,
                                    HamPizzaCount, PepperoniPizzaCount,
                                    PineapplePizzaCount, CalzoniPizzaCount);

                                // Toggling visiblity and setting form text
                                MenuGroupBox.Enabled = false;
                                OrderButton.Enabled = false;
                                SummaryButton.Enabled = true;
                                TableOrderSummaryGroupBox.Visible = true;
                                this.Text = "Table Summary";

                            }
                            catch
                            {
                                MessageBox.Show("System Error", "Input Error", 
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                        catch
                        {
                            MessageBox.Show("Please enter numerical data for Calzoni Pizza", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                            CalzoniPizzaTextBox.Focus();
                            CalzoniPizzaTextBox.SelectAll();
                        }

                    }catch
                    {
                        MessageBox.Show("Please enter numerical data for Pineapple Pizza", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        PineapplePizzaTextBox.Focus();
                        PineapplePizzaTextBox.SelectAll();
                    }

                }catch
                {
                    MessageBox.Show("Please enter numerical data for Pepperoni Pizza", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    PepperoniPizzaTextBox.Focus();
                    PepperoniPizzaTextBox.SelectAll();
                }

            }catch
            {
                MessageBox.Show("Please enter numerical data for Ham Pizza", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                HamPizzaTextBox.Focus();
                HamPizzaTextBox.SelectAll();
            }
            

        }

        /* 
         * Event handler to handle CLEAR button click event
         */
        private void ClearButtonClick(object sender, EventArgs e)
        {
            // Toggling visibility and asthetics
            this.Text = "Welcome to PizzaBothan";
            CompanySummaryGroupBox.Visible = false;
            TableOrderSummaryGroupBox.Visible = false;
            LoginCredsPanel.Visible = true;
            OrderPanel.Visible = false;
            OrderButton.Enabled = true;
            HamPizzaTextBox.Focus();
            HamPizzaTextBox.SelectAll();

            // Setting up default values as per requirement
            HamPizzaTextBox.Text = "0";
            PineapplePizzaTextBox.Text = "0";
            PepperoniPizzaTextBox.Text = "0";
            CalzoniPizzaTextBox.Text = "0";
            ServerNameTextBox.Text = "";
            TableNumberTextBox.Text = "";

        }

        /* 
         * Event handler to handle SUMMARY button click event
         */
        private void SummaryButtonClick(object sender, EventArgs e)
        {
            // Toggling visibility and asthetics
            this.Text = "Company Summary Data";
            OrderButton.Enabled = false;
            CompanySummaryGroupBox.Visible = true;
            TableOrderSummaryGroupBox.Visible = false;
            TotalPizzaSoldGroupBox.Visible = true;

            // Setting the values to the respective groupBox
            CompSummaryHamPizza.Text = TotalHamPizzas.ToString();
            CompSummaryPeppoPizza.Text = TotalPepperoniPizzas.ToString();
            CompSummaryPinePizza.Text = TotalPineapplePizzas.ToString();
            CompSummaryCalzPizza.Text = TotalCalzoniPizzas.ToString();
            
            CompSummaryTransactionLabel.Text = TotalCompanyOrders.ToString();
            CompSummaryTotalPizzaLabel.Text = TotalPizzaOrdered.ToString();
            CompSummaryTotalReceiptLabel.Text = TotalCompanyReceipts.ToString();
            CompSummaryAvgTransactionLabel.Text = AvgTransactionReceipt.ToString();

        }

        /* 
         * Event handler to handle EXIT button click event
         */
        private void ExitButtonClick(object sender, EventArgs e)
        {
            this.Close();
        }

        // Private function to update total company summary data and update the field level variables
        private void UpdateTotalCompanySummary(int TotalCompanyOrders, decimal TableOrderTotalReceiptOutput,
            int TableOrderNumberPizzaOutput, int HamPizzaCount, int PepperoniPizzaCount,
            int PineapplePizzaCount, int CalzoniPizzaCount)
        {
            // Computing field level values for company summary data 
            TotalPizzaOrdered += TableOrderNumberPizzaOutput;
            TotalCompanyReceipts += TableOrderTotalReceiptOutput;
            if (TotalCompanyOrders > 0)
            {
                AvgTransactionReceipt = TotalCompanyReceipts / TotalCompanyOrders;
            }

            TotalHamPizzas += HamPizzaCount;
            TotalPepperoniPizzas += PepperoniPizzaCount;
            TotalPineapplePizzas += PineapplePizzaCount;
            TotalCalzoniPizzas += CalzoniPizzaCount;
        }
    }
}
