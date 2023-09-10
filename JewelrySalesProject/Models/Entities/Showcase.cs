using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace JewelrySalesProject.Models.Entities
{
    public class Showcase
    {
        public Showcase(string code, DateTime initialDate)
        {
            Code = code;
            InitialDate = initialDate;

            SetFinalDate();
        }

        [Key]
        public Guid Id { get; set; }
        public string Code { get; set; }
        public DateTime InitialDate { get; set; }
        public DateTime FinalDate { get; private set; }
        public double TotalSaleValue { get; private set; }
        public double CommissionPercentage { get; private set; }
        public double TotalProfit { get; private set; }
        public double TotalInvestiment { get; private set; }
        public List<Sale>? Sales { get; set; }

        private void SetFinalDate()
        {
            FinalDate = InitialDate.AddDays(30);
        }

        private void CalculateTotalSaleValue()
        {
            foreach (var sale in Sales)
            {
                TotalSaleValue += sale.TotalValue;
            }
        }

        private void CalculateCommissionPercentage()
        {
            if (TotalSaleValue <= 499)
                CommissionPercentage = 0.2;
            else if (TotalSaleValue <= 999)
                CommissionPercentage = 0.3;
            else if (TotalSaleValue <= 7999)
                CommissionPercentage = 0.4;
            else
                CommissionPercentage = 0.5;
        }

        private void CalculateTotalProfit()
        {
            TotalProfit = TotalSaleValue * CommissionPercentage;
        }

        private void CalculateTotalInvestiment()
        {
            TotalInvestiment = TotalSaleValue - TotalProfit;
        }

        public void MakeArrangementSales()
        {
            CalculateTotalSaleValue();
            CalculateCommissionPercentage();
            CalculateTotalProfit();
            CalculateTotalInvestiment();
        }
    }
}
