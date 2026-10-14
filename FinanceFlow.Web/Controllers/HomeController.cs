using Microsoft.AspNetCore.Mvc;
namespace FinanceFlow.Web.Controllers;
public class HomeController : Controller { public IActionResult Index() => View(); public IActionResult Privacy() => View(); }