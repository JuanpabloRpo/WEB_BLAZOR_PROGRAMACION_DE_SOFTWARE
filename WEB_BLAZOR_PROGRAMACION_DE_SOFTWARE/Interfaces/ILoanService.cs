﻿using WEB_BLAZOR_PROGRAMACION_DE_SOFTWARE.Entities;

namespace WEB_BLAZOR_PROGRAMACION_DE_SOFTWARE.Interfaces
{
    public interface ILoanService
    {/*
        Task<List<Loan>> ListLoans();
        Task<Loan> GetLoan(int loanId);
        Task<Boolean> CreateLoan(int reservationId, int userId);
        Task<Boolean> ReturnLoan(int loanId, int userId);
        Task<Boolean> CancelLoan(int loanId, int userId);
        Task<Boolean> DeleteLoan(int loanId);*/
        Task<List<Loan>> GetLoansUser(int UserId);
    }
}
