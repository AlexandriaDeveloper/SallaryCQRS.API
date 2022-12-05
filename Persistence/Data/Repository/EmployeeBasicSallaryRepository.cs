using Application.Interfaces;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Data.Repository
{
    internal class EmployeeBasicSallaryRepository : Repository<EmployeeBasicSallary>, IEmployeeBasicSallaryRepository
    {
        private readonly SallaryCQRSAppContext _context;
        private readonly IAuthService _authService;

        public EmployeeBasicSallaryRepository(SallaryCQRSAppContext context, IAuthService authService) : base(context, authService)
        {
            this._context = context;
            this._authService = authService;
        }

        public async Task<EmployeeBasicSallary> EmployeeGetRaise(Guid lasyEmployeeSallaryId
            ,Guid newFinancialYear,
            decimal? wazifiPercentage,
            decimal? wazifiAmount,
            decimal? wazifiMinAmount,
            decimal? wazifiMaxAmount,
            decimal? mokamelPercentage,
            decimal? mokamelAmount,
            decimal? mokamelMinAmount,
            decimal? mokamelMaxAmount
            )
        {
            //Get Existing Employee Sallary Data 
            EmployeeBasicSallary lastSallary= await _context.EmployeeBasicSallaries.OrderBy(x  => x.CreatedDate) .LastOrDefaultAsync(x => x.EmployeeId == lasyEmployeeSallaryId);

            EmployeeBasicSallary newSallary = new EmployeeBasicSallary();
            newSallary.EmployeeId = lastSallary!.EmployeeId;
            newSallary.FinancialYearId = newFinancialYear;
            newSallary.Ta3widi=lastSallary.Ta3widi;
            newSallary.BasicSallary = lastSallary.BasicSallary;
            if(wazifiPercentage!= null )
            {
              newSallary.Wazifi= await  CaluclateRaiseByPercentage(lastSallary.Wazifi,wazifiPercentage,wazifiMinAmount,wazifiMaxAmount); 
            }

            if (wazifiAmount != null)
            {
                newSallary.Wazifi = await CaluclateRaiseByFixedAmount(lastSallary.Wazifi, wazifiAmount);
            }

            if (mokamelPercentage != null)
            {
                newSallary.Mokamel = await CaluclateRaiseByPercentage(lastSallary.Mokamel, mokamelPercentage, mokamelMinAmount, mokamelMaxAmount);
            }
            if (mokamelAmount != null)
            {
                newSallary.Mokamel = await CaluclateRaiseByFixedAmount(lastSallary.Mokamel, mokamelAmount);
            }

            if (mokamelMaxAmount != null)
            {
                newSallary.Mokamel = await CaluclateRaiseByFixedAmount(lastSallary.Mokamel, mokamelAmount);
            }
            // var existingEmployeeData = _context.

            //
            return newSallary;
        
        
        }

        public async Task<EmployeeBasicSallary?> GetLastEmployeeBasicSallaryAsync(Guid employeeId) => await _context.EmployeeBasicSallaries.OrderBy(x => x.CreatedDate).LastOrDefaultAsync();
        public async Task<EmployeeBasicSallary?> GetEmployeeBasicSallaryByFinancialIdAsync(Guid employeeId,Guid financialYearId) => await _context.EmployeeBasicSallaries.OrderBy(x => x.CreatedDate).LastOrDefaultAsync( x=> x.EmployeeId==employeeId&& x.FinancialYearId==financialYearId);

        private async Task<decimal?> CaluclateRaiseByPercentage(decimal? AmountBefor ,decimal? Percentage,decimal? HasMin,decimal? HasMax) {
            
            if (!AmountBefor.HasValue) { return null; }

            decimal? amountAfter=null;
            if (!AmountBefor.HasValue ||! Percentage.HasValue)
            {
               return null;
            }

           decimal incresedAmount = Math.Round(AmountBefor.Value * Percentage.Value/100, 2);
              
            if(HasMin.HasValue)
            {
                incresedAmount = CheckMin(incresedAmount, HasMin.Value);
            }
            if (HasMax.HasValue)
            {
                incresedAmount = checkMax(incresedAmount, HasMax.Value);
            }

            amountAfter = Math.Round(AmountBefor.Value + incresedAmount , 2);

            return amountAfter;
        }
        private async Task<decimal?> CaluclateRaiseByFixedAmount(decimal? AmountBefor, decimal? Amount)
        {

            if (!AmountBefor.HasValue) { return null; }


            decimal? amountAfter=null;
            if (!AmountBefor.HasValue ||  !Amount.HasValue)
                return null;

            


                amountAfter = Math.Round(AmountBefor.Value + Amount.Value, 2);
            return amountAfter;
        }

        private decimal CheckMin(decimal currentRaise, decimal minRaise) {
            return minRaise >currentRaise ? minRaise : currentRaise;
        }
        private decimal checkMax(decimal currentRaise, decimal maxRais)
        {
            return currentRaise > maxRais ? maxRais : currentRaise;
        }
    }
}
