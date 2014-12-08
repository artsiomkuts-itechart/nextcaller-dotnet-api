﻿using System;
using System.Text;


namespace NextCallerApi.Authorization
{
	internal class BasicAuthorization
	{

		private const string TokenTemplate = "Basic {0}";

		public static string GetToken(string username, string password)
		{
			Utility.EnsureParameterValid(!string.IsNullOrEmpty(username), "username");
			Utility.EnsureParameterValid(!string.IsNullOrEmpty(password), "password");

			string tokenValue = Convert.ToBase64String(Encoding.UTF8.GetBytes(username + ":" + password));

			return string.Format(TokenTemplate, tokenValue);
		}

	}
}