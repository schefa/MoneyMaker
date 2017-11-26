using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MoneyMaker.Views.Tables;
using MoneyMaker.Libraries.Navigation;
using MoneyMaker.Helpers;
using MoneyMaker.ViewModels;
using MoneyMaker.Models;
using MoneyMaker.Controls;

namespace MoneyMaker.Views
{
    public partial class LeasingCalculatorView : FinancingView
    {
        private LeasingData leasing;
        private LeasingModel model;

        public LeasingCalculatorView(LeasingData leasing = null)
        {
            InitializeComponent();
            model = new LeasingModel(mainForm.User);

            if (leasing != null)
            {
                this.leasing = leasing;
                fillTextboxesAndFields();
            }
            else this.leasing = new LeasingData();

            mainForm.setHeadline("Leasingrechner");
            setDefaultCurrencyInLabel();
        }

        private void fillTextboxesAndFields()
        {
            tbLeasingName.Text = leasing.leasingName;
            tbStartValue.Text = leasing.startValue.ToString();
            tbDeposit.Text = leasing.deposit.ToString();
            tbInterestRate.Text = leasing.interestRate.ToString();
            tbLeasingRate.Text = leasing.leasingRate.ToString();
            if (leasing.leasingRateInterval == LeasingData.LeasingRateInterval.Annually) cbLeasingRateIntervall.SelectedIndex = 3;
            else if (leasing.leasingRateInterval == LeasingData.LeasingRateInterval.Biannually) cbLeasingRateIntervall.SelectedIndex = 2;
            else if (leasing.leasingRateInterval == LeasingData.LeasingRateInterval.Quarterly) cbLeasingRateIntervall.SelectedIndex = 1;
            else if (leasing.leasingRateInterval == LeasingData.LeasingRateInterval.Monthly) cbLeasingRateIntervall.SelectedIndex = 0;
            tbDuration.Text = leasing.duration.ToString();
            if (leasing.durationMode == LeasingData.DurationMode.Years) cbDurationMode.SelectedIndex = 1;
            else if (leasing.durationMode == LeasingData.DurationMode.Months) cbDurationMode.SelectedIndex = 0;
            tbRecoveryValue.Text = leasing.recoveryValue.ToString();
            lblTotalExpense.Text = leasing.totalExpense.ToString();
            lblTotalInterest.Text = leasing.totalInterest.ToString();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Get data
                Double.TryParse(tbStartValue.Text, out leasing.startValue);
                Double.TryParse(tbDeposit.Text, out leasing.deposit);
                Double.TryParse(tbInterestRate.Text, out leasing.interestRate);
                Double.TryParse(tbLeasingRate.Text, out leasing.leasingRate);
                Double.TryParse(tbDuration.Text, out leasing.duration);
                Double.TryParse(tbRecoveryValue.Text, out leasing.recoveryValue);
                switch (cbDurationMode.SelectedItem.ToString())
                {
                    case "Monate":
                        leasing.durationMode = LeasingData.DurationMode.Months;
                        break;
                    case "Jahre":
                        leasing.durationMode = LeasingData.DurationMode.Years;
                        break;
                }
                switch (cbLeasingRateIntervall.SelectedItem.ToString())
                {
                    case "jährlich":
                        leasing.leasingRateInterval = LeasingData.LeasingRateInterval.Annually;
                        break;
                    case "halbjährlich":
                        leasing.leasingRateInterval = LeasingData.LeasingRateInterval.Biannually;
                        break;
                    case "vierteljährlich":
                        leasing.leasingRateInterval = LeasingData.LeasingRateInterval.Quarterly;
                        break;
                    case "monatlich":
                        leasing.leasingRateInterval = LeasingData.LeasingRateInterval.Monthly;
                        break;
                    default:
                        throw new NotImplementedException();
                }
                // Calculate
                LeasingCalculator.Calculate(leasing);
                // Fill fields
                lblTotalExpense.Text = leasing.totalExpense.ToString("0.00");
                lblTotalInterest.Text = leasing.totalInterest.ToString("0.00");
                btnShowTable.Visible = true;
            }
            catch (NotImplementedException)
            {
                MessageBox.Show("Unzureichende oder falsche Eingaben für diese Berechnung.");
            }
        }

        private void btnShowTable_Click(object sender, EventArgs e)
        {
            var values = new List<LeasingTableRow>();
            values = TableCalculator.ToLeasingTable(leasing).leasingRowList;
            Form table = new LeasingCalculatorTable(values);
            table.Show();
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        { 
            Parent.Controls.Add(NavigationFactory.create(NavigationType.Leasings));
            Parent.Controls.Remove(this);
        }

        private void textboxCheckDigital(object sender, KeyPressEventArgs e)
        {
            MoneyMakerHelper.textboxCheckDigital(ref sender, ref e);
        }

        private void tbnShowAll_Click(object sender, EventArgs e)
        {
            Parent.Controls.Add(NavigationFactory.create(NavigationType.Leasings));
            Parent.Controls.Remove(this);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            btnCalculate_Click(sender, e);
            try
            {
                if (leasing.startValue != 0 && leasing.leasingRate != 0 &&
                    leasing.duration != 0 && leasing.durationMode.ToString() != "" &&
                    leasing.leasingRateInterval.ToString() != "" && leasing.totalExpense != 0)
                {
                    LeasingData itemToSave = leasing;
                    if (tbLeasingName.Text.Length < 1) itemToSave.leasingName = "Unbenannt";
                    else itemToSave.leasingName = tbLeasingName.Text;
                    itemToSave.UserID = mainForm.User.UserID;
                    if (itemToSave.LeasingID > 0) model.updateItem(itemToSave);
                    else model.createItem(itemToSave);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Fehler beim Speichern. Bitte Eingabefelder prüfen und neu berechnen");
            }
        }
    }
}
