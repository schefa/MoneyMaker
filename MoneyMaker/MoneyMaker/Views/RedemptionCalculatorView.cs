using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MoneyMaker.Views.Tables;
using MoneyMaker.Libraries.Navigation;
using MoneyMaker.Helpers;
using MoneyMaker.Models;
using MoneyMaker.ViewModels;
using MoneyMaker.Controls;

namespace MoneyMaker.Views
{
    public partial class RedemptionCalculatorView : FinancingView
    {
        private RedemptionData currentItem;
        private RedemptionModel model;

        public RedemptionCalculatorView(RedemptionData item = null)
        {
            InitializeComponent();
            mainForm.setHeadline("Tilgungsrechner");
            setDefaultCurrencyInLabel();

            model = new RedemptionModel(mainForm.User);

            if (item != null)
            {
                this.currentItem = item;
                fillTextboxesAndFields();
            }
            else currentItem = new RedemptionData();

            setDefaultCurrencyInLabel();
        }

        private void fillTextboxesAndFields()
        {
            tbTitle.Text = currentItem.redemptionName;
            tbLoanAmount.Text = currentItem.loanAmount.ToString();
            tbInterestRate.Text = currentItem.interestRate.ToString();
            if (currentItem.interestRateInterval == RedemptionData.InterestRateInterval.Annually) cbInterestRateIntervall.SelectedIndex = 3;
            else if (currentItem.interestRateInterval == RedemptionData.InterestRateInterval.Biannually) cbInterestRateIntervall.SelectedIndex = 2;
            else if (currentItem.interestRateInterval == RedemptionData.InterestRateInterval.Quarterly) cbInterestRateIntervall.SelectedIndex = 1;
            else if (currentItem.interestRateInterval == RedemptionData.InterestRateInterval.Monthly) cbInterestRateIntervall.SelectedIndex = 0;
            tbRedemptionRate.Text = currentItem.redemptionRate.ToString();
            if (currentItem.redemptionRateInterval == RedemptionData.RedemptionRateInterval.Annually) cbRedemptionRateIntervall.SelectedIndex = 3;
            else if (currentItem.redemptionRateInterval == RedemptionData.RedemptionRateInterval.Biannually) cbRedemptionRateIntervall.SelectedIndex = 2;
            else if (currentItem.redemptionRateInterval == RedemptionData.RedemptionRateInterval.Quarterly) cbRedemptionRateIntervall.SelectedIndex = 1;
            else if (currentItem.redemptionRateInterval == RedemptionData.RedemptionRateInterval.Monthly) cbRedemptionRateIntervall.SelectedIndex = 0;
            tbRedemptionDuration.Text = currentItem.redemptionDuration.ToString();
            if (currentItem.redemptionDurationMode == RedemptionData.RedemptionDurationMode.Years) cbRedemptionDurationMode.SelectedIndex = 1;
            else if (currentItem.redemptionDurationMode == RedemptionData.RedemptionDurationMode.Months) cbRedemptionDurationMode.SelectedIndex = 0;
            tbRemainingDebt.Text = currentItem.remainingDebt.ToString();
            lblTotalExpense.Text = currentItem.totalExpense.ToString();
            lblTotalInterest.Text = (currentItem.totalExpense - (currentItem.loanAmount - currentItem.remainingDebt)).ToString();
        }

        private void btnShowTable_Click(object sender, EventArgs e)
        {
            var values = new List<RedemptionTableRow>();
            values = TableCalculator.ToRedemptionTable(currentItem).redemptionRowList;
            Form table = new RedemptionCalculatorTable(values);
            table.Show();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Get data
                Double.TryParse(tbLoanAmount.Text, out currentItem.loanAmount);
                Double.TryParse(tbInterestRate.Text, out currentItem.interestRate);
                Double.TryParse(tbRedemptionRate.Text, out currentItem.redemptionRate);
                Double.TryParse(tbRedemptionDuration.Text, out currentItem.redemptionDuration);
                Double.TryParse(tbRemainingDebt.Text, out currentItem.remainingDebt);
                switch (cbRedemptionRateIntervall.SelectedItem.ToString())
                {
                    case "jährlich":
                        currentItem.redemptionRateInterval = RedemptionData.RedemptionRateInterval.Annually;
                        break;
                    case "halbjährlich":
                        currentItem.redemptionRateInterval = RedemptionData.RedemptionRateInterval.Biannually;
                        break;
                    case "vierteljährlich":
                        currentItem.redemptionRateInterval = RedemptionData.RedemptionRateInterval.Quarterly;
                        break;
                    case "monatlich":
                        currentItem.redemptionRateInterval = RedemptionData.RedemptionRateInterval.Monthly;
                        break;
                    default:
                        throw new NotImplementedException();
                }
                switch (cbRedemptionDurationMode.SelectedItem.ToString())
                {
                    case "Monate":
                        currentItem.redemptionDurationMode = RedemptionData.RedemptionDurationMode.Months;
                        break;
                    case "Jahre":
                        currentItem.redemptionDurationMode = RedemptionData.RedemptionDurationMode.Years;
                        break;
                    default:
                        throw new NotImplementedException();
                }
                switch (cbInterestRateIntervall.SelectedItem.ToString())
                {
                    case "jährlich":
                        currentItem.interestRateInterval = RedemptionData.InterestRateInterval.Annually;
                        break;
                    case "halbjährlich":
                        currentItem.interestRateInterval = RedemptionData.InterestRateInterval.Biannually;
                        break;
                    case "vierteljährlich":
                        currentItem.interestRateInterval = RedemptionData.InterestRateInterval.Quarterly;
                        break;
                    case "monatlich":
                        currentItem.interestRateInterval = RedemptionData.InterestRateInterval.Monthly;
                        break;
                    default:
                        throw new NotImplementedException();
                }
                if (rbLoanAmount.Checked == true) currentItem.calculateOption = RedemptionData.CalculateOption.LoanAmount;
                else if (rbRedemption.Checked == true) currentItem.calculateOption = RedemptionData.CalculateOption.RedemptionRate;
                else if (rbRedemptionDuration.Checked == true) currentItem.calculateOption = RedemptionData.CalculateOption.RedemptionDuration;
                else if (rbRemainingDebt.Checked == true) currentItem.calculateOption = RedemptionData.CalculateOption.RemainingDebt;
                // Calculate
                RedemptionCalculator.Calculate(currentItem);
                // Fill fields
                if (rbLoanAmount.Checked == true) tbLoanAmount.Text = currentItem.loanAmount.ToString();
                else if (rbRedemption.Checked == true) tbRedemptionRate.Text = currentItem.redemptionRate.ToString();
                else if (rbRedemptionDuration.Checked == true) tbRedemptionDuration.Text = currentItem.redemptionDuration.ToString();
                else if (rbRemainingDebt.Checked == true) tbRemainingDebt.Text = currentItem.remainingDebt.ToString();
                lblTotalExpense.Text = currentItem.totalExpense.ToString("0.00");
                lblTotalInterest.Text = (currentItem.totalExpense - currentItem.loanAmount).ToString("0.00");
                btnShowTable.Visible = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Unzureichende oder falsche Eingaben für diese Berechnung. Es darf nur das zu berechnende Feld freigelasen werden.");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            btnCalculate_Click(sender, e);
            try
            {
                if (currentItem.loanAmount != 0 && currentItem.redemptionRate != 0 &&
                    currentItem.redemptionDuration != 0 && currentItem.redemptionDurationMode.ToString() != "" &&
                    currentItem.redemptionRateInterval.ToString() != "" && currentItem.totalExpense != 0)
                {
                    RedemptionData itemToSave = currentItem;
                    if (tbTitle.Text.Length < 1) itemToSave.redemptionName = "Unbenannt";
                    else itemToSave.redemptionName = tbTitle.Text;
                    itemToSave.UserID = mainForm.User.UserID;
                    if (itemToSave.RedemptionID > 0) model.updateItem(itemToSave);
                    else model.createItem(itemToSave);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Fehler beim Speichern. Bitte Eingabefelder prüfen und neu berechnen");
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            Parent.Controls.Add(NavigationFactory.create(NavigationType.Redemptions));
            Parent.Controls.Remove(this);
        }

        private void textboxCheckDigital(object sender, KeyPressEventArgs e)
        {
            MoneyMakerHelper.textboxCheckDigital(ref sender, ref e);
        }

        private void rbLoanAmount_CheckedChanged(object sender, EventArgs e)
        {
            tbLoanAmount .ReadOnly = (rbLoanAmount.Checked) ? true : false;
        }

        private void rbRedemption_CheckedChanged(object sender, EventArgs e)
        {
            tbRedemptionRate.ReadOnly = (rbRedemption.Checked) ? true : false;
        }

        private void rbRedemptionDuration_CheckedChanged(object sender, EventArgs e)
        {
            tbRedemptionDuration.ReadOnly = (rbRedemptionDuration.Checked) ? true : false;
        }

        private void rbRemainingDebt_CheckedChanged(object sender, EventArgs e)
        {
            tbRemainingDebt.ReadOnly = (rbRemainingDebt.Checked) ? true : false;
        }
    }
}
