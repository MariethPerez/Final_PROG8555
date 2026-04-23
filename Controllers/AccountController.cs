using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using bank.Models;
using bank.Repository;

namespace bank.Controllers;

public class AccountController : Controller
{
    IAccountRepository Accountrepository;
    public AccountController(IAccountRepository accountRepository)
    {
        Accountrepository = accountRepository;
    }

    public IActionResult Index()
    {
        return View(Accountrepository.GetAll());
    }

    public IActionResult Add() 
    {
        return View();
    }

    [HttpPost]
    public IActionResult SaveAdd(Account obj)
    {
        Accountrepository.Add(obj);
        Accountrepository.Save();
        return RedirectToAction("Index");
        
    }

    // GET: /Account/Details/1
    public async Task<IActionResult> Details(int id)
    {
        var account = Accountrepository.GetAccountById(id);
        if (account == null)
        {
            TempData["Error"] = "Account not found.";
            return RedirectToAction("Index");
        }
        return View(account);
    }

}
