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
public class CardController(ICardCommandService cardCommandService, ICardQueryService cardQueryService): ControllerBase 
{
    [HttpPost]
    public async Task<ActionResult> CreateCard([FromBody] CreateCardResource resource)
    {
        var createCardCommand = CreateCardCommandFromResourceAssembler.ToCommandFromResource(resource);
        var result = await cardCommandService.Handle(createCardCommand);
        if (result is null) return BadRequest();
        return CreatedAtAction(nameof(GetCardById), new { id = result.Id }, CardResourceFromEntityAssembler.ToResourceFromEntity(result));
    }

    [HttpGet("{id}")]
    public async Task<ActionResult> GetCardById(int id)
    {
        var getCardByIdQuery = new GetCardByIdQuery(id);
        var result = await cardQueryService.Handle(getCardByIdQuery);
        if (result is null) return NotFound();
        var resource = CardResourceFromEntityAssembler.ToResourceFromEntity(result);
        return Ok(resource);
    }

    [HttpGet("wallets/{walletId}")]
    public async Task<ActionResult> GetCardByWalletId(int walletId)
    {
        var getCardByWalletIdQuery = new GetCardByWalletIdQuery(walletId);
        var card = await cardQueryService.Handle(getCardByWalletIdQuery);
        var resources = card.Select(CardResourceFromEntityAssembler.ToResourceFromEntity);
        return Ok(resources);
    }

    [HttpGet]
    public async Task<ActionResult> GetAllCards()
    {
        var getAllCardsQuery = new GetAllCardQuery();
        var card = await cardQueryService.Handle(getAllCardsQuery);
        var resources = card.Select(CardResourceFromEntityAssembler.ToResourceFromEntity);
        return Ok(resources);
    }
    
}
