using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using bank.Models;
using bank.Repository;

namespace bank.Controllers;

public class TransactionController : Controller
{
    ITransactionRepository Transactionrepository;
    public TransactionController(ITransactionRepository accountRepository)
    {
        Transactionrepository = accountRepository;
    }

    public IActionResult Index()
    {
        return View(Transactionrepository.GetAll());
    }

    // GET: /Transaction/Deposit/1
    public IActionResult Deposit(int id)
    {
        var account = Accountrepository.GetById(id);
        if (account == null)
        {
            TempData["Error"] = "Account not found.";
            return RedirectToAction("Index");
        }
        return View(account);
    }

}
