using eShopSolution.ViewModels.Catalog.System.Users;
using eShopSolution.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShopSolution.AdminApp.Services
{
    public interface IUserApiClient
    {
        public Task<string> Authenticate(LoginRequest request);

        Task<PagedResult<UserViewModel>> GetUsersPagings(GetUserPagingRequest request);
    }
}
