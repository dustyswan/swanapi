using Microsoft.EntityFrameworkCore;
using swanapi.Data;
using swanapi.Models; // Make sure this is the correct namespace for your DbContext
using swanapi;

namespace swanapi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllers();

            // Add DbContext for EventPlanner
            builder.Services.AddDbContext<EventPlannerDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("EventPlannerProductionDatabase")));

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            // Configure CORS policy
            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowSpecificOrigin", policy =>
                    policy.WithOrigins(
                        "http://localhost:5000",
                        "http://localhost:5001",
                        "http://localhost:5002",
                        "http://localhost:5003",
                        "http://localhost:5004",
                        "http://localhost:5005",
                        "http://localhost:5006",
                        "http://localhost:5007",
                        "http://localhost:5008",
                        "http://localhost:5009",
                        "http://localhost:5010")
                        .AllowAnyHeader()
                        .AllowAnyMethod());
            });


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            // Enable CORS
            app.UseCors("AllowSpecificOrigin");  // Use the CORS policy

            app.MapControllers();

            // Example of mapping custom endpoints
            app.MapUserMstEndpoints();  // Assuming you have custom endpoints like this

        

            app.MapExhibitorAttendeeInvoiceEndpoints();

            app.MapAssociationEndpoints();

            app.MapCompanyEndpoints();

            app.Run();
        }
    }
}
