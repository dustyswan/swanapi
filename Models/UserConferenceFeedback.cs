using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.OpenApi;
using Microsoft.EntityFrameworkCore;
using swanapi.Data;

namespace swanapi.Models;

public partial class UserConferenceFeedback
{
    public Guid UserConferenceFeedbackId { get; set; }

    public Guid? SubmittedId { get; set; }

    public Guid? ConferenceId { get; set; }

    public Guid? UserId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Email { get; set; }

    public bool? IsActive { get; set; }

    public Guid? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }
}


public static class UserMstEndpoints
{
	public static void MapUserMstEndpoints (this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/UserMst").WithTags(nameof(UserMst));

        group.MapGet("/", async (EventPlannerDbContext db) =>
        {
            return await db.UserMsts.ToListAsync();
        })
        .WithName("GetAllUserMsts")
        .WithOpenApi();

        group.MapGet("/{id}", async Task<Results<Ok<UserMst>, NotFound>> (Guid userid, EventPlannerDbContext db) =>
        {
            return await db.UserMsts.AsNoTracking()
                .FirstOrDefaultAsync(model => model.UserId == userid)
                is UserMst model
                    ? TypedResults.Ok(model)
                    : TypedResults.NotFound();
        })
        .WithName("GetUserMstById")
        .WithOpenApi();

        group.MapPut("/{id}", async Task<Results<Ok, NotFound>> (Guid userid, UserMst userMst, EventPlannerDbContext db) =>
        {
            var affected = await db.UserMsts
                .Where(model => model.UserId == userid)
                .ExecuteUpdateAsync(setters => setters
                  .SetProperty(m => m.UserId, userMst.UserId)
                  .SetProperty(m => m.RoleId, userMst.RoleId)
                  .SetProperty(m => m.FirstName, userMst.FirstName)
                  .SetProperty(m => m.LastName, userMst.LastName)
                  .SetProperty(m => m.Email, userMst.Email)
                  .SetProperty(m => m.Password, userMst.Password)
                  .SetProperty(m => m.Phone, userMst.Phone)
                  .SetProperty(m => m.DateOfBirth, userMst.DateOfBirth)
                  .SetProperty(m => m.IsRequestedPassword, userMst.IsRequestedPassword)
                  .SetProperty(m => m.ResetPasswordPin, userMst.ResetPasswordPin)
                  .SetProperty(m => m.IsActive, userMst.IsActive)
                  .SetProperty(m => m.CreatedOn, userMst.CreatedOn)
                  .SetProperty(m => m.CreatedBy, userMst.CreatedBy)
                  .SetProperty(m => m.LastUpdatedOn, userMst.LastUpdatedOn)
                  .SetProperty(m => m.LastUpdatedBy, userMst.LastUpdatedBy)
                  .SetProperty(m => m.CompanyId, userMst.CompanyId)
                  .SetProperty(m => m.ProfileImage, userMst.ProfileImage)
                  .SetProperty(m => m.UserType, userMst.UserType)
                  .SetProperty(m => m.EmailConfirm, userMst.EmailConfirm)
                  .SetProperty(m => m.IsCompleteProfile, userMst.IsCompleteProfile)
                  .SetProperty(m => m.JobTitle, userMst.JobTitle)
                  .SetProperty(m => m.WorkEmail, userMst.WorkEmail)
                  .SetProperty(m => m.WorkPhone, userMst.WorkPhone)
                  .SetProperty(m => m.Title, userMst.Title)
                  .SetProperty(m => m.AboutMe, userMst.AboutMe)
                  .SetProperty(m => m.IsFigCreated, userMst.IsFigCreated)
                  .SetProperty(m => m.IsFigUser, userMst.IsFigUser)
                  .SetProperty(m => m.DistrictName, userMst.DistrictName)
                  .SetProperty(m => m.FigUserId, userMst.FigUserId)
                  .SetProperty(m => m.IsExternalUser, userMst.IsExternalUser)
                  .SetProperty(m => m.CoverPhoto, userMst.CoverPhoto)
                  .SetProperty(m => m.IsReceivePushNotification, userMst.IsReceivePushNotification)
                  .SetProperty(m => m.FigupdateFlag, userMst.FigupdateFlag)
                  );
            return affected == 1 ? TypedResults.Ok() : TypedResults.NotFound();
        })
        .WithName("UpdateUserMst")
        .WithOpenApi();

        group.MapPost("/", async (UserMst userMst, EventPlannerDbContext db) =>
        {
            db.UserMsts.Add(userMst);
            await db.SaveChangesAsync();
            return TypedResults.Created($"/api/UserMst/{userMst.UserId}",userMst);
        })
        .WithName("CreateUserMst")
        .WithOpenApi();

        group.MapDelete("/{id}", async Task<Results<Ok, NotFound>> (Guid userid, EventPlannerDbContext db) =>
        {
            var affected = await db.UserMsts
                .Where(model => model.UserId == userid)
                .ExecuteDeleteAsync();
            return affected == 1 ? TypedResults.Ok() : TypedResults.NotFound();
        })
        .WithName("DeleteUserMst")
        .WithOpenApi();
    }
}