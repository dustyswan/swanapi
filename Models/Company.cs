using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.OpenApi;
using Microsoft.EntityFrameworkCore;
using swanapi.Data;

namespace swanapi.Models;

public partial class Company
{
    public Guid CompanyId { get; set; }

    public string? CompanyName { get; set; }

    public string? ContactName { get; set; }

    public string? Email { get; set; }

    public string? Password { get; set; }

    public string? PhoneNumber { get; set; }

    public string? AlternateContactName { get; set; }

    public string? AlternateEmailId { get; set; }

    public string? AlternatePhoneNumber { get; set; }

    public string? Address1 { get; set; }

    public string? Address2 { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? Zip { get; set; }

    public string? CoverImage { get; set; }

    public string? Website { get; set; }

    public string? IsApproved { get; set; }

    public DateTime? ApprovedDate { get; set; }

    public Guid? ApprovedBy { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedBy { get; set; }

    public DateTime? LastUpdatedOn { get; set; }

    public Guid? LastUpdatedBy { get; set; }

    public string? Glnnumber { get; set; }

    public string? CompanyType { get; set; }

    public string? CompanyProductCategory { get; set; }

    public string? ProfilePhoto { get; set; }

    public Guid? ParentCompanyId { get; set; }

    public string? Title { get; set; }
}


public static class CompanyEndpoints
{
	public static void MapCompanyEndpoints (this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Company").WithTags(nameof(Company));

        group.MapGet("/", async (EventPlannerDbContext db) =>
        {
            return await db.Companies.ToListAsync();
        })
        .WithName("GetAllCompanies")
        .WithOpenApi();

        group.MapGet("/{id}", async Task<Results<Ok<Company>, NotFound>> (Guid companyid, EventPlannerDbContext db) =>
        {
            return await db.Companies.AsNoTracking()
                .FirstOrDefaultAsync(model => model.CompanyId == companyid)
                is Company model
                    ? TypedResults.Ok(model)
                    : TypedResults.NotFound();
        })
        .WithName("GetCompanyById")
        .WithOpenApi();

        group.MapPut("/{id}", async Task<Results<Ok, NotFound>> (Guid companyid, Company company, EventPlannerDbContext db) =>
        {
            var affected = await db.Companies
                .Where(model => model.CompanyId == companyid)
                .ExecuteUpdateAsync(setters => setters
                  .SetProperty(m => m.CompanyId, company.CompanyId)
                  .SetProperty(m => m.CompanyName, company.CompanyName)
                  .SetProperty(m => m.ContactName, company.ContactName)
                  .SetProperty(m => m.Email, company.Email)
                  .SetProperty(m => m.Password, company.Password)
                  .SetProperty(m => m.PhoneNumber, company.PhoneNumber)
                  .SetProperty(m => m.AlternateContactName, company.AlternateContactName)
                  .SetProperty(m => m.AlternateEmailId, company.AlternateEmailId)
                  .SetProperty(m => m.AlternatePhoneNumber, company.AlternatePhoneNumber)
                  .SetProperty(m => m.Address1, company.Address1)
                  .SetProperty(m => m.Address2, company.Address2)
                  .SetProperty(m => m.City, company.City)
                  .SetProperty(m => m.State, company.State)
                  .SetProperty(m => m.Zip, company.Zip)
                  .SetProperty(m => m.CoverImage, company.CoverImage)
                  .SetProperty(m => m.Website, company.Website)
                  .SetProperty(m => m.IsApproved, company.IsApproved)
                  .SetProperty(m => m.ApprovedDate, company.ApprovedDate)
                  .SetProperty(m => m.ApprovedBy, company.ApprovedBy)
                  .SetProperty(m => m.IsActive, company.IsActive)
                  .SetProperty(m => m.CreatedOn, company.CreatedOn)
                  .SetProperty(m => m.CreatedBy, company.CreatedBy)
                  .SetProperty(m => m.LastUpdatedOn, company.LastUpdatedOn)
                  .SetProperty(m => m.LastUpdatedBy, company.LastUpdatedBy)
                  .SetProperty(m => m.Glnnumber, company.Glnnumber)
                  .SetProperty(m => m.CompanyType, company.CompanyType)
                  .SetProperty(m => m.CompanyProductCategory, company.CompanyProductCategory)
                  .SetProperty(m => m.ProfilePhoto, company.ProfilePhoto)
                  .SetProperty(m => m.ParentCompanyId, company.ParentCompanyId)
                  .SetProperty(m => m.Title, company.Title)
                  );
            return affected == 1 ? TypedResults.Ok() : TypedResults.NotFound();
        })
        .WithName("UpdateCompany")
        .WithOpenApi();

        group.MapPost("/", async (Company company, EventPlannerDbContext db) =>
        {
            db.Companies.Add(company);
            await db.SaveChangesAsync();
            return TypedResults.Created($"/api/Company/{company.CompanyId}",company);
        })
        .WithName("CreateCompany")
        .WithOpenApi();

        group.MapDelete("/{id}", async Task<Results<Ok, NotFound>> (Guid companyid, EventPlannerDbContext db) =>
        {
            var affected = await db.Companies
                .Where(model => model.CompanyId == companyid)
                .ExecuteDeleteAsync();
            return affected == 1 ? TypedResults.Ok() : TypedResults.NotFound();
        })
        .WithName("DeleteCompany")
        .WithOpenApi();
    }
}