﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Areas.Manage.Controllers
{
	[Area("Manage")]
	[Authorize]
	public class AccountController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
