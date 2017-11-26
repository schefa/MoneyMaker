using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MoneyMaker.Views.Tables;
using MoneyMaker.Libraries.Navigation;
using MoneyMaker.ViewModels;
using MoneyMaker.Models;
using MoneyMaker.Helpers;
using MoneyMaker.Controls;

namespace MoneyMaker.Views
{
    public partial class LoanCalculatorView : FinancingView
    {
        private LoanData currentItem;
        private LoanModel model;
        
        public LoanCalculatorView(LoanData item = null)
        {
            InitializeComponent();
            model = new LoanModel(mainForm.User);

            if (item != null)
            {
                this.currentItem = item;
                fillTextboxesAndFields();
            }
            else currentItem = new LoanData();

            setDefaultCurrencyInLabel();
            mainForm.setHeadline("Kreditrechner");
        }

        private void fillTextboxesAndFields()
        {
            tbLoanName.Text = currentItem.loanName;
            tbDuration.Text = currentItem.duration.ToString();
            tbInterestRate.Text = currentItem.interestRate.ToString();
            tbLoanAmount.Text = currentItem.loanAmount.ToString();
            tbRepaymentRate.Text = currentItem.repaymentRate.ToString();
            if (currentItem.durationMode == LoanData.DurationMode.Years) cbDurationMode.SelectedIndex = 1;
            else if (currentItem.durationMode == LoanData.DurationMode.Months) cbDurationMode.SelectedIndex = 0;
            if (currentItem.repaymentRateInterval == LoanData.RepaymentRateInterval.Annually) cbRepaymentInterval.SelectedIndex = 3;
            else if (currentItem.repaymentRateInterval == LoanData.RepaymentRateInterval.Biannually) cbRepaymentInterval.SelectedIndex = 2;
            else if (currentItem.repaymentRateInterval == LoanData.RepaymentRateInterval.Quarterly) cbRepaymentInterval.SelectedIndex = 1;
            else if (currentItem.repaymentRateInterval == LoanData.RepaymentRateInterval.Monthly) cbRepaymentInterval.SelectedIndex = 0;
            lbltotalExpense.Text = currentItem.totalExpense.ToString();
            lblFees.Text = (currentItem.totalExpense - currentItem.loanAmount).ToString();
        }

        /// <summary>
        /// Fills the internal LoanData of this instance, calls the LoanCalculator and fills the calculated fields.
        /// </summary>
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Get data
                Double.TryParse(tbLoanAmount.Text, out currentItem.loanAmount);
                Double.TryParse(tbInterestRate.Text, out currentItem.interestRate);
                Double.TryParse(tbDuration.Text, out currentItem.duration);
                Double.TryParse(tbRepaymentRate.Text, out currentItem.repaymentRate);
                if (rbDuration.Checked == true) currentItem.calculateOption = LoanData.CalculateOption.Duration;
                else if (rbLoanAmount.Checked == true) currentItem.calculateOption = LoanData.CalculateOption.LoanAmount;
                else if (rbRepaymentMode.Checked == true) currentItem.calculateOption = LoanData.CalculateOption.RepaymentRate;
                switch (cbDurationMode.SelectedItem.ToString())
                {
                    case "Monate":
                        currentItem.durationMode = LoanData.DurationMode.Months;
                        break;
                    case "Jahre":
                        currentItem.durationMode = LoanData.DurationMode.Years;
                        break;
                    default:
                        throw new NotImplementedException();
                }
                switch (cbRepaymentInterval.SelectedItem.ToString())
                {
                    case "jährlich":
                        currentItem.repaymentRateInterval = LoanData.RepaymentRateInterval.Annually;
                        break;
                    case "halbjährlich":
                        currentItem.repaymentRateInterval = LoanData.RepaymentRateInterval.Biannually;
                        break;
                    case "vierteljährlich":
                        currentItem.repaymentRateInterval = LoanData.RepaymentRateInterval.Quarterly;
                        break;
                    case "monatlich":
                        currentItem.repaymentRateInterval = LoanData.RepaymentRateInterval.Monthly;
                        break;
                    default:
                        throw new NotImplementedException();
                }
                // Calculate
                currentItem = LoanCalculator.Calculate(currentItem);
                // Fill fields
                if (rbDuration.Checked == true) tbDuration.Text = currentItem.duration.ToString();
                else if (rbLoanAmount.Checked == true) tbLoanAmount.Text = currentItem.loanAmount.ToString();
                else if (rbRepaymentMode.Checked == true) tbRepaymentRate.Text = currentItem.repaymentRate.ToString();
                lbltotalExpense.Text = currentItem.totalExpense.ToString("0.00");
                lblFees.Text = (currentItem.totalExpense - currentItem.loanAmount).ToString("0.00");
                btnShowTable.Visible = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Unzureichende oder falsche Eingaben für diese Berechnung. Es darf nur das zu berechnende Feld freigelasen werden.");
            }
        }

        private void btnShowTable_Click(object sender, EventArgs e)
        {
            var values = new List<LoanTableRow>();
            values = TableCalculator.ToLoanTable(currentItem).loanRowList;
            Form table = new LoanCalculatorTable(values);
            table.Show();
        }
        
        private void tbnShowAll_Click(object sender, EventArgs e)
        {
            Parent.Controls.Add(NavigationFactory.create(NavigationType.Loans));
            Parent.Controls.Remove(this);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            btnCalculate_Click(sender, e);
            try
            {
                if (currentItem.loanAmount != 0 && currentItem.repaymentRate != 0 && 
                    currentItem.duration != 0 && currentItem.durationMode.ToString() != "" &&
                    currentItem.repaymentRateInterval.ToString() != "" && currentItem.totalExpense != 0)
                {
                    LoanData itemToSave = currentItem;
                    if (tbLoanName.Text.Length < 1) itemToSave.loanName = "Unbenannt";
                    else itemToSave.loanName = tbLoanName.Text;
                    itemToSave.UserID = mainForm.User.UserID;
                        if (itemToSave.LoanID > 0) model.updateItem(itemToSave);
                        else model.createItem(itemToSave);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Fehler beim Speichern. Bitte Eingabefelder prüfen und neu berechnen");
            }
        }

        private void textboxCheckDigital(object sender, KeyPressEventArgs e)
        {
            MoneyMakerHelper.textboxCheckDigital(ref sender,ref e);
        }


        private void rbLoanAmount_CheckedChanged(object sender, EventArgs e)
        {
            tbLoanAmount.ReadOnly = (rbLoanAmount.Checked) ? true : false;
        }

        private void rbRepaymentMode_CheckedChanged(object sender, EventArgs e)
        {
            tbRepaymentRate.ReadOnly = (rbRepaymentMode.Checked) ? true : false;
        }

        private void rbDuration_CheckedChanged(object sender, EventArgs e)
        {
            tbDuration.ReadOnly = (rbDuration.Checked) ? true : false;
        }
    }
}
