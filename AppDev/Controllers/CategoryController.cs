﻿using AppDev.Data;
using AppDev.Models;
using Microsoft.AspNetCore.Mvc;

namespace AppDev.Controllers
{
	public class CategoryController : Controller
	{
		private readonly ApplicationDBContext _dbContext;
		public CategoryController(ApplicationDBContext applicationDBContext)
		{
			_dbContext = applicationDBContext;
		}
		public IActionResult Index()
		{
			List<Category> categories = _dbContext.Categories.ToList();
			return View(categories);
		}
		public IActionResult Details()
		{
			return View();
		}
		public IActionResult Create()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Create(Category category)
		{

			if (ModelState.IsValid)
			{
				_dbContext.Categories.Add(category);
				_dbContext.SaveChanges();
				TempData["success"] = "Category Created successfully";
			}
			return RedirectToAction("Index");

		}
	}
}
