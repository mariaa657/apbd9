using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using api.Models;
using IRepository;
using Microsoft.AspNetCore.Http.HttpResults;
using Repository;

namespace api.Controllers;
[Route("api/accounts")]
[ApiController ]
public class AccountsController : ControllerBase
{
    private IAccountAndCartRepository _repository;
    [HttpGet("{id:int}")]
    public IActionResult GetAccountAndCart(int id)
    {
        return Ok(_repository.GetAccounWithCart(id));
    }

}