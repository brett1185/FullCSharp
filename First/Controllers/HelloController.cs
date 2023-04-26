using Microsoft.AspNetCore.Mvc;
namespace First.Controllers;
public class HelloController : Controller{
    [HttpGet]
    [Route("")]
    public string Index(){
        return "Hello World from HelloController!";
    }
}