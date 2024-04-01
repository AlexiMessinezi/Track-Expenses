using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    
    public partial class MainWindow : Window
    {
        Boolean buying = false;
        Boolean saving = false;
        Boolean rent = false;
        double vehicleAmount = 0;
        double totalSave = 0;
        double finalAmount;

        public MainWindow()
        {
            InitializeComponent();

        }

        private void tbGMI(object sender, TextChangedEventArgs e)
        {

        }

        private void tbTax(object sender, TextChangedEventArgs e)
        {

        }


        private void tbGroceries(object sender, TextChangedEventArgs e)
        {

        }

        private void tbLights(object sender, TextChangedEventArgs e)
        {

        }

        private void tbTravel(object sender, TextChangedEventArgs e)
        {

        }

        private void tbTelephone(object sender, TextChangedEventArgs e)
        {

        }

        private void tbOtherExpenses(object sender, TextChangedEventArgs e)
        {

        }


        private void tbModelMake(object sender, TextChangedEventArgs e)
        {

        }


        private void tbPremiumPrice(object sender, TextChangedEventArgs e)
        {

        }

        private void tbInterestRate(object sender, TextChangedEventArgs e)
        {

        }

        private void tbDepositPrice(object sender, TextChangedEventArgs e)
        {

        }

        private void tbPriceOfVehicle(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_Yes(object sender, RoutedEventArgs e)
        {

            buying = true;
            //Makes selected text boxes and labels visible
            lblCar.Visibility = Visibility.Visible;
            txtCar.Visibility = Visibility.Visible;
            lblCarPrice.Visibility = Visibility.Visible;
            txtCarPrice.Visibility = Visibility.Visible;
            lblCarDeposit.Visibility = Visibility.Visible;
            txtCarDeposit.Visibility = Visibility.Visible;
            lblCarInterest.Visibility = Visibility.Visible;
            txtCarInterest.Visibility = Visibility.Visible;
            lblCarPremium.Visibility = Visibility.Visible;
            txtCarPremium.Visibility = Visibility.Visible;
        }

        private void Button_Click_No(object sender, RoutedEventArgs e)
        {
            Boolean buying = false;
            //Makes selected text boxes and labels hidden
            lblCar.Visibility = Visibility.Hidden;
            txtCar.Visibility = Visibility.Hidden;
            lblCarPrice.Visibility = Visibility.Hidden;
            txtCarPrice.Visibility = Visibility.Hidden;
            lblCarDeposit.Visibility = Visibility.Hidden;
            txtCarDeposit.Visibility = Visibility.Hidden;
            lblCarInterest.Visibility = Visibility.Hidden;
            txtCarInterest.Visibility = Visibility.Hidden;
            lblCarPremium.Visibility = Visibility.Hidden;
            txtCarPremium.Visibility = Visibility.Hidden;
        }
        
        private void Button_Click_Rent(object sender, RoutedEventArgs e)
        {
            rent = true;
            //Makes selected text boxes and labels visible
            txtRentalPrice.Visibility = Visibility.Visible;
            lblRentPrice.Visibility = Visibility.Visible;

            //Makes selected text boxes and labels hidden
            txtPurchasePrice.Visibility = Visibility.Hidden;
            lblPurchasePrice.Visibility = Visibility.Hidden;
            txtDepositPriceProperty.Visibility = Visibility.Hidden;
            lblDepositPricePoperty.Visibility = Visibility.Hidden;
            txtInterestProperty.Visibility = Visibility.Hidden;
            lblInterestRateProperty.Visibility = Visibility.Hidden;
            txtRepay.Visibility = Visibility.Hidden;
            lblRepay.Visibility = Visibility.Hidden;
        }

        private void Button_Click_Buy(object sender, RoutedEventArgs e)
        {
            rent = false;
            //Makes selected text boxes and labels hidden
            txtRentalPrice.Visibility = Visibility.Hidden;
            lblRentPrice.Visibility = Visibility.Hidden;

            //Makes selected text boxes and labels visible
            txtPurchasePrice.Visibility = Visibility.Visible;
            lblPurchasePrice.Visibility = Visibility.Visible;
            txtDepositPriceProperty.Visibility = Visibility.Visible;
            lblDepositPricePoperty.Visibility = Visibility.Visible;
            txtInterestProperty.Visibility = Visibility.Visible;
            lblInterestRateProperty.Visibility = Visibility.Visible;
            txtRepay.Visibility = Visibility.Visible;
            lblRepay.Visibility = Visibility.Visible;

        }

        private void tbPurchasePrice(object sender, TextChangedEventArgs e)
        {


        }

        private void tbDepositPriceProperty(object sender, TextChangedEventArgs e)
        {

        }

        private void tbRepay(object sender, TextChangedEventArgs e)
        {

        }

        private void SaveButton_Click_Yes(object sender, RoutedEventArgs e)
        {
            saving = true;
            //Makes all text boxes and labels visible
            lblSave.Visibility = Visibility.Visible;
            txtSave.Visibility = Visibility.Visible;
            lblYearSave.Visibility = Visibility.Visible;
            txtYearSave.Visibility = Visibility.Visible;
            lblSaveInterest.Visibility = Visibility.Visible;
            txtSaveInterest.Visibility = Visibility.Visible;
        }

        private void SaveButton_Click_No(object sender, RoutedEventArgs e)
        {
            saving = false;
            //Makes all text boxes and labels hidden
            lblSave.Visibility = Visibility.Hidden;
            txtSave.Visibility = Visibility.Hidden;
            lblYearSave.Visibility = Visibility.Hidden;
            txtYearSave.Visibility = Visibility.Hidden;
            lblSaveInterest.Visibility = Visibility.Hidden;
            txtSaveInterest.Visibility = Visibility.Hidden;
        }

        private void tbSave(object sender, TextChangedEventArgs e)
        {

        }

        private void tbSaveYears(object sender, TextChangedEventArgs e)
        {

        }

        private void tbSavingsInterest(object sender, TextChangedEventArgs e)
        {

        }

        private void tbRentalPrice(object sender, TextChangedEventArgs e)
        {

        }

        private void tbInterestProperty(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ResetButton(object sender, RoutedEventArgs e)
        {
            //Clearing all text boxes of any values
            txtCar.Text = String.Empty;
            txtCarDeposit.Text = String.Empty;
            txtCarInterest.Text = String.Empty;
            txtCarPremium.Text = String.Empty;
            txtCarPrice.Text = String.Empty;

            txtDepositPriceProperty.Text = String.Empty;
            txtInterestProperty.Text = String.Empty;
            txtPurchasePrice.Text = String.Empty;
            txtRentalPrice.Text = String.Empty;
            txtRepay.Text = String.Empty;

            txtGross.Text = String.Empty;
            txtGroceries.Text = String.Empty;
            txtTax.Text = String.Empty;
            txtTelephone.Text = String.Empty;
            txtLights.Text = String.Empty;
            txtTravel.Text = String.Empty;
            txtOtherPrices.Text = String.Empty;

            txtSave.Text = String.Empty;
            txtSaveInterest.Text = String.Empty;
            txtYearSave.Text = String.Empty;

            txtOutput.Text = String.Empty;



            //After program reset all text boxes and labels are hidden
            lblCar.Visibility = Visibility.Hidden;
            txtCar.Visibility = Visibility.Hidden;
            lblCarPrice.Visibility = Visibility.Hidden;
            txtCarPrice.Visibility = Visibility.Hidden;
            lblCarDeposit.Visibility = Visibility.Hidden;
            txtCarDeposit.Visibility = Visibility.Hidden;
            lblCarInterest.Visibility = Visibility.Hidden;
            txtCarInterest.Visibility = Visibility.Hidden;
            lblCarPremium.Visibility = Visibility.Hidden;
            txtCarPremium.Visibility = Visibility.Hidden;

            txtPurchasePrice.Visibility = Visibility.Hidden;
            lblPurchasePrice.Visibility = Visibility.Hidden;
            txtDepositPriceProperty.Visibility = Visibility.Hidden;
            lblDepositPricePoperty.Visibility = Visibility.Hidden;
            txtInterestProperty.Visibility = Visibility.Hidden;
            lblInterestRateProperty.Visibility = Visibility.Hidden;
            txtRepay.Visibility = Visibility.Hidden;
            lblRepay.Visibility = Visibility.Hidden;

            txtRentalPrice.Visibility = Visibility.Hidden;
            lblRentPrice.Visibility = Visibility.Hidden;

            lblSave.Visibility = Visibility.Hidden;
            txtSave.Visibility = Visibility.Hidden;
            lblYearSave.Visibility = Visibility.Hidden;
            txtYearSave.Visibility = Visibility.Hidden;
            lblSaveInterest.Visibility = Visibility.Hidden;
            txtSaveInterest.Visibility = Visibility.Hidden;

            txtSave.Visibility = Visibility.Hidden;
            lblSave.Visibility = Visibility.Hidden;
            txtSaveInterest.Visibility = Visibility.Hidden;
            lblSaveInterest.Visibility = Visibility.Hidden;
            txtYearSave.Visibility = Visibility.Hidden;
            lblYearSave.Visibility = Visibility.Hidden;



            

        }

        private void CloseButton(object sender, RoutedEventArgs e)
        {
            //closes the program
            this.Close();
        }

        private void CalculateButton(object sender, RoutedEventArgs e)
        {


            //Data validation for Taxes and Expenses
            
            if (txtGross.Text == string.Empty)
            {
                MessageBox.Show("Please enter a value to Gross!");
                return;
            }
            else if (txtTax.Text == string.Empty)
            {
                MessageBox.Show("Please enter a value for Tax!");
                return;
            }
            else if (txtGroceries.Text == String.Empty)
            {
                MessageBox.Show("Please enter a value to Groceries!");
                return;
            }
            else if (txtLights.Text == string.Empty)
            {
                MessageBox.Show("Please enter a value to Lights and water!");
                return;
            }
            else if (txtTravel.Text == string.Empty)
            {
                MessageBox.Show("Please enter a value for Travel!");
                return;
            }
            else if (txtTelephone.Text == string.Empty)
            {
                MessageBox.Show("Please enter a value for Phone!");
                return;
            }
            else if (txtOtherPrices.Text == string.Empty)
            {
                MessageBox.Show("Please enter a value for other expenses!");
                return;
            }


            //Data validation for buying a car
            if (buying == true)
            {
                if (txtCar.Text == string.Empty)
                {
                    MessageBox.Show("Please enter a name for the car!");
                    return;
                }
                else if (txtCarPrice.Text == string.Empty)
                {
                    MessageBox.Show("Please enter the price of the car!");
                    return;
                }
                else if (txtCarDeposit.Text == string.Empty)
                {
                    MessageBox.Show("Please enter a deposit for the car!");
                    return;
                }
                else if (txtCarInterest.Text == string.Empty)
                {
                    MessageBox.Show("Please enter the interest rate in percentage!");
                    return;
                }
                else if (txtCarPremium.Text == string.Empty)
                {
                    MessageBox.Show("Please enter the cars Premium!");
                    return;
                }
            }


            //Data validation for Purchasing a house

            if (rent == false)
            {


                if (txtPurchasePrice.Text == string.Empty)
                {
                    MessageBox.Show("Please enter Purchase price of preperty!");
                    return;
                }
                else if (txtDepositPriceProperty.Text == string.Empty)
                {
                    MessageBox.Show("Please enter the property deposit price!");
                    return;
                }
                else if (txtInterestProperty.Text == string.Empty)
                {
                    MessageBox.Show("Please enter the property interest!");
                    return;
                }
                else if (txtRepay.Text == string.Empty)
                {
                    MessageBox.Show("Please enter an amount of months 240-360!");
                    return;
                }
            }


            //Data validation for Saving
            if (saving == true)
            {


                if (txtSave.Text == string.Empty)
                {
                    MessageBox.Show("Please enter a value to Save!");
                    return;
                }
                else if (txtYearSave.Text == string.Empty)
                {
                    MessageBox.Show("Please enter the amount of years you would like to save for!");
                    return;
                }
                else if (txtSaveInterest.Text == string.Empty)
                {
                    MessageBox.Show("Please enter a value in percentage!");
                    return;
                }
            }
            
            //Calculating income after deducations
            double FinalGross = double.Parse(txtGross.Text) - double.Parse(txtGroceries.Text) - double.Parse(txtLights.Text) - double.Parse(txtTax.Text) - double.Parse(txtTelephone.Text) - double.Parse(txtTelephone.Text) - double.Parse(txtOtherPrices.Text);
            //Printing The amount
            txtOutput.Text ="Your Monthly Income after deductions will be R"+ Convert.ToString(FinalGross);

            //Creating variables and converting string to double for vehicle
            if (buying == true)
            {

                double vehiclePrice = double.Parse(txtCarPrice.Text);
                double vehicleInterestRate = double.Parse(txtCarInterest.Text);
                double premium = double.Parse(txtCarPremium.Text);
                double vehicleRepay = 5;
                double vehicleDeposit = double.Parse(txtCarDeposit.Text);

                vehiclePrice = vehiclePrice - vehicleDeposit; // Calculating price with deposit
                vehicleInterestRate = vehicleInterestRate / 100;  // Converting interest rate percentage to double


                vehicleAmount = vehiclePrice * (1 + vehicleInterestRate * vehicleRepay); //Calculating the amount it will cost excluding premium
                vehicleAmount = vehicleAmount + premium;    //Calculating the amount it will cost including premium
                vehicleAmount = vehicleAmount / (vehicleRepay * 12);  // Calculating the monthly price

                


            }
            //Creating variables and converting string to double for house
            if (rent == false)
            {


                double propertyPrice = double.Parse(txtPurchasePrice.Text);
                double totalDep = double.Parse(txtDepositPriceProperty.Text);
                double InterestRate = double.Parse(txtInterestProperty.Text);
                double repay = double.Parse(txtRepay.Text);
                

                propertyPrice = propertyPrice - totalDep; // Calculating price with deposit
                InterestRate = InterestRate / 100;  // Converting interest rate percentage to double
                repay = repay / 12; // Converting months to years

                finalAmount = propertyPrice * (1 + InterestRate * repay); //Calculating Simple interest 

                finalAmount = finalAmount / (repay * 12); // Calculating repayment amount per months
            }

            //Creating variables and converting string to double for savings
            if (saving == true)
            {

                double SavingAmount = double.Parse(txtSave.Text);
                double SavingYears = double.Parse(txtYearSave.Text);
                double SavingInterest = double.Parse(txtSaveInterest.Text);
                

                SavingInterest = SavingInterest / 100;
                totalSave = SavingAmount * (1 + SavingInterest * SavingYears); //Calculating the amount it will cost excluding premium
                totalSave = totalSave / (SavingYears * 12);  // Calculating the monthly price
                
            }



            


            //Rounding off to two decimal places
            vehicleAmount = Math.Round(vehicleAmount, 2);
            totalSave = Math.Round(totalSave, 2);
            finalAmount = Math.Round(finalAmount, 2);

            



            //Continuing Output
            txtOutput.Text = "Your Monthly Income after deductions will be R" + Convert.ToString(FinalGross);
            txtOutput.Text += "\nThe Price for your Car will cost R" + Convert.ToString(vehicleAmount) + " per month";
            txtOutput.Text += "\nThe house will cost R" + Convert.ToString(finalAmount) + " per month";

            //Creating if statement to tell user if there approval for home is likely or unlikely
            if (finalAmount > FinalGross / 3)
            {
                txtOutput.Text += "\nApproval for home is unlikely";
            }
            else
            {
                txtOutput.Text += "\nCongratulations you have been approved";
            }

            //Continuing output
            txtOutput.Text += "\nYou would have to save up R" + totalSave + " a month";


            
            
        }

        private void Output(object sender, TextChangedEventArgs e)
        {

        }
    }
}
