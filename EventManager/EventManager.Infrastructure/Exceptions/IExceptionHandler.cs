using Microsoft.AspNetCore.Mvc;

namespace EventManager.Infrastructure.Exceptions
{
    public interface IExceptionHandler
    {
        IActionResult Handle(Exception exception);
    }
}
