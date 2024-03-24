using Microsoft.AspNetCore.Mvc;

namespace Server.Controllers;

public class ExampleController : ControllerBase
{
    /// <summary>
    /// Use (ActionResult) instead of (IActionResult) 
    /// because you can select your retrun value
    /// </summary>

    [HttpGet("GetSomething")] // HttpGet => Because return a string
    public ActionResult<string> GetSomething()
    {
        var result = "Hello World !";

        return result;
    }

    [HttpPost("PostSomething")]
    public ActionResult<int> PostSomething(int id)
    {
        // your code with => id

        var statusCode = 200; // 200 => Success

        return statusCode;
    }

    [HttpPut("EditSomething")]
    public ActionResult<object> EditSomething(int id)
    {
        // your code with => id

        var result = new
        {
            StatusCode = 200,
            IsSuccess = true,
        };

        return result;
    }

    [HttpDelete("DeleteSomething")]
    public ActionResult<bool> DeleteSomething(int id)
    {
        // your code with => id

        return true;
    }

    // for writing a async http method 

    public async Task<ActionResult<string>> GetSomethingAsync()
    {
        // your code with => await  

        var result = "Hello World !";

        return result;
    }
}
