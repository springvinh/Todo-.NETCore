using Microsoft.AspNetCore.Mvc;
using Todo.Models;

namespace Todo.Controllers;

public class TodoController : Controller {
    
    public IActionResult Index() {

        return View();
    }

    public IActionResult TodoForm() => View();

}