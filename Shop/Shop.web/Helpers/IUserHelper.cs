﻿
namespace Shop.web.Helpers
{
	using System.Threading.Tasks;
	using Data.Entities;
	using Microsoft.AspNetCore.Identity;
    using Shop.web.Models;

    public interface IUserHelper
	{
		Task<User> GetUserByEmailAsync(string email);

		Task<IdentityResult> AddUserAsync(User user, string password);

		Task<SignInResult> LoginAsync(LoginViewModel model);

		Task LogoutAsync();

	}

}
