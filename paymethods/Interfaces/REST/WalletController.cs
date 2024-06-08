using System.Net.Mime;
using Microsoft.AspNetCore.Mvc;
using Paymethods.paymethods.Domain.Model.Queries;
using Paymethods.paymethods.Domain.Services;
using Paymethods.paymethods.Interfaces.REST.Resources;
using Paymethods.paymethods.Interfaces.REST.Transform;

namespace Paymethods.paymethods.Interfaces.REST;

[ApiController]
[Route("/[controller]")]
[Produces(MediaTypeNames.Application.Json)]

public class WalletController(IWalletCommandService walletCommandService, IWalletQueryService walletQueryService): ControllerBase 
{
    [HttpPost]
    public async Task<ActionResult> CreateWallet([FromBody] CreateWalletResource resource)
    {
        var createWalletCommand = CreateWalletCommandFromResourceAssembler.ToCommandFromResource(resource);
        var result = await walletCommandService.Handle(createWalletCommand);
        if (result is null) return BadRequest();
        return CreatedAtAction(nameof(GetWalletById), new { id = result.Id }, WalletResourceFromEntityAssembler.ToResourceFromEntity(result));
    }
    [HttpGet("{id}")]
    public async Task<ActionResult> GetWalletById(int id)
    {
        var getWalletByIdQuery = new GetWalletByIdQuery(id);
        var result = await walletQueryService.Handle(getWalletByIdQuery);
        if (result is null) return NotFound();
        var resource = WalletResourceFromEntityAssembler.ToResourceFromEntity(result);
        return Ok(resource);
    }

    [HttpGet("user/{userId}")]
    public async Task<ActionResult> GetWalletByUserId(int userId)
    {
        var getWalletByUserIdQuery = new GetWalletsByUserIdQuery(userId);
        var wallet = await walletQueryService.Handle(getWalletByUserIdQuery);
        var resources = wallet.Select(WalletResourceFromEntityAssembler.ToResourceFromEntity);
        return Ok(resources);
    }

    [HttpGet]
    public async Task<ActionResult> GetAllWallets()
    {
        var getAllWalletsQuery = new GetAllWalletsQuery();
        var wallet = await walletQueryService.Handle(getAllWalletsQuery);
        var resources = wallet.Select(WalletResourceFromEntityAssembler.ToResourceFromEntity);
        return Ok(resources);
    }
}