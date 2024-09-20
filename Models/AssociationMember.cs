using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.OpenApi;
using Microsoft.EntityFrameworkCore;
using swanapi.Data;

namespace swanapi.Models;

public partial class AssociationMember
{
    public Guid AssociationMembersId { get; set; }

    public Guid? AssociationId { get; set; }

    public string? ProfilePicture { get; set; }

    public string? MemberNumber { get; set; }

    public string? DistrictName { get; set; }

    public string? Name { get; set; }

    public string? Address { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? Zip { get; set; }

    public string? Email { get; set; }

    public string? Phone { get; set; }

    public bool? Accreditations { get; set; }

    public string? Type { get; set; }

    public string? TshirtSize { get; set; }

    public string? MealRequirements { get; set; }

    public bool? IsActive { get; set; }

    public Guid? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public string? Leaid { get; set; }

    public bool? IsFigDistrict { get; set; }

    public Guid? UserId { get; set; }
}


public static class AssociationMemberEndpoints
{
	public static void MapAssociationMemberEndpoints (this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/AssociationMember").WithTags(nameof(AssociationMember));

        group.MapGet("/", async (EventPlannerDbContext db) =>
        {
            return await db.AssociationMembers.ToListAsync();
        })
        .WithName("GetAllAssociationMembers")
        .WithOpenApi();

        group.MapGet("/{id}", async Task<Results<Ok<AssociationMember>, NotFound>> (Guid associationmembersid, EventPlannerDbContext db) =>
        {
            return await db.AssociationMembers.AsNoTracking()
                .FirstOrDefaultAsync(model => model.AssociationMembersId == associationmembersid)
                is AssociationMember model
                    ? TypedResults.Ok(model)
                    : TypedResults.NotFound();
        })
        .WithName("GetAssociationMemberById")
        .WithOpenApi();

        group.MapPut("/{id}", async Task<Results<Ok, NotFound>> (Guid associationmembersid, AssociationMember associationMember, EventPlannerDbContext db) =>
        {
            var affected = await db.AssociationMembers
                .Where(model => model.AssociationMembersId == associationmembersid)
                .ExecuteUpdateAsync(setters => setters
                  .SetProperty(m => m.AssociationMembersId, associationMember.AssociationMembersId)
                  .SetProperty(m => m.AssociationId, associationMember.AssociationId)
                  .SetProperty(m => m.ProfilePicture, associationMember.ProfilePicture)
                  .SetProperty(m => m.MemberNumber, associationMember.MemberNumber)
                  .SetProperty(m => m.DistrictName, associationMember.DistrictName)
                  .SetProperty(m => m.Name, associationMember.Name)
                  .SetProperty(m => m.Address, associationMember.Address)
                  .SetProperty(m => m.City, associationMember.City)
                  .SetProperty(m => m.State, associationMember.State)
                  .SetProperty(m => m.Zip, associationMember.Zip)
                  .SetProperty(m => m.Email, associationMember.Email)
                  .SetProperty(m => m.Phone, associationMember.Phone)
                  .SetProperty(m => m.Accreditations, associationMember.Accreditations)
                  .SetProperty(m => m.Type, associationMember.Type)
                  .SetProperty(m => m.TshirtSize, associationMember.TshirtSize)
                  .SetProperty(m => m.MealRequirements, associationMember.MealRequirements)
                  .SetProperty(m => m.IsActive, associationMember.IsActive)
                  .SetProperty(m => m.CreatedBy, associationMember.CreatedBy)
                  .SetProperty(m => m.CreatedOn, associationMember.CreatedOn)
                  .SetProperty(m => m.UpdatedBy, associationMember.UpdatedBy)
                  .SetProperty(m => m.UpdatedOn, associationMember.UpdatedOn)
                  .SetProperty(m => m.Leaid, associationMember.Leaid)
                  .SetProperty(m => m.IsFigDistrict, associationMember.IsFigDistrict)
                  .SetProperty(m => m.UserId, associationMember.UserId)
                  );
            return affected == 1 ? TypedResults.Ok() : TypedResults.NotFound();
        })
        .WithName("UpdateAssociationMember")
        .WithOpenApi();

        group.MapPost("/", async (AssociationMember associationMember, EventPlannerDbContext db) =>
        {
            db.AssociationMembers.Add(associationMember);
            await db.SaveChangesAsync();
            return TypedResults.Created($"/api/AssociationMember/{associationMember.AssociationMembersId}",associationMember);
        })
        .WithName("CreateAssociationMember")
        .WithOpenApi();

        group.MapDelete("/{id}", async Task<Results<Ok, NotFound>> (Guid associationmembersid, EventPlannerDbContext db) =>
        {
            var affected = await db.AssociationMembers
                .Where(model => model.AssociationMembersId == associationmembersid)
                .ExecuteDeleteAsync();
            return affected == 1 ? TypedResults.Ok() : TypedResults.NotFound();
        })
        .WithName("DeleteAssociationMember")
        .WithOpenApi();
    }
}
