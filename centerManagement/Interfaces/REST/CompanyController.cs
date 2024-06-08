using System.Net.Mime;
using CenterManagement.centerManagement.Domain.Model.Commands;
using CenterManagement.centerManagement.Domain.Model.Queries;
using CenterManagement.centerManagement.Domain.Services;
using CenterManagement.centerManagement.Interfaces.REST.Resources;
using CenterManagement.centerManagement.Interfaces.REST.Transform;
using Microsoft.AspNetCore.Mvc;

namespace CenterManagement.centerManagement.Interfaces.REST;

[ApiController]
[Route("/[controller]")]
[Produces(MediaTypeNames.Application.Json)]
public class CompanyController(ICompanyCommandService companyCommandService, ICompanyQueryService companyQueryService) : ControllerBase
{
    [HttpPost]
    public async Task<ActionResult> CreateCompany([FromBody] CreateCompanyResource resource)
    {
        var createCompanyCommand = CreateCompanyCommandFromResourceAssembler.ToCommandFromResource(resource);
        var result = await companyCommandService.Handle(createCompanyCommand);
        if (result is null) return BadRequest();
        return CreatedAtAction(nameof(GetCompanyById), new { id = result.Id },
            CompanyResourceFromEntityAssembler.ToResourceFromEntity(result));
    }

    [HttpGet("{id}")]
    public async Task<ActionResult> GetCompanyById(int id)
    {
        var getCompanyByIdQuery = new GetCompanyByIdQuery(id);
        var result = await companyQueryService.Handle(getCompanyByIdQuery);
        if (result is null) return NotFound();
        var resource = CompanyResourceFromEntityAssembler.ToResourceFromEntity(result);
        return Ok(resource);
    }

    [HttpGet]
    public async Task<ActionResult> GetAllCompanies()
    {
        var getAllCompanysQuery = new GetAllCompanysQuery();
        var companies = await companyQueryService.Handle(getAllCompanysQuery);
        var resources = companies.Select(CompanyResourceFromEntityAssembler.ToResourceFromEntity);
        return Ok(resources);
    }

    [HttpGet("place/{idPlace}")]
    public async Task<ActionResult> GetCompanyByPlaceId(int idPlace)
    {
        var getCompanyByPlaceIdQuery = new GetCompanyByPlaceIdQuery(idPlace);
        var companies = await companyQueryService.Handle(getCompanyByPlaceIdQuery);
        var resources = companies.Select(CompanyResourceFromEntityAssembler.ToResourceFromEntity);
        return Ok(resources);
    }
}