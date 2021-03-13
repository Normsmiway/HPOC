﻿using App.Domains.ValueObjects;
using System;
using System.Threading.Tasks;

namespace App.Applications.UseCases.FundWallets
{
    public interface IFundWallet
    {
        Task<FundingResult> Execute(Guid walletId, Amount amount);
        Task<FundingResult> Execute(string walletNumber, Amount amount);
    }
}
