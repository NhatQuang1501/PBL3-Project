using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PBL3_Project.Models;
using PBL3_Project.Data;
using Microsoft.AspNetCore.Identity;
using System;
using static System.Formats.Asn1.AsnWriter;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<PBL3_ProjectContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("PBL3_ProjectContext")));
builder.Services.AddDbContext<AuthDbContext>(options => 
    options.UseSqlServer(builder.Configuration.GetConnectionString("PBL3_ProjectContext")));

builder.Services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<AuthDbContext>();

//builder.Services.AddAuthorization(options =>
//{
//    options.AddPolicy("RequireAdminRole",
//        policy => policy.RequireRole("Admin"));
//});
//builder.Services.AddAuthorization(options =>
//{
//    options.AddPolicy("RequireTutorRole",
//        policy => policy.RequireRole("Gia sư"));
//});
//builder.Services.AddAuthorization(options =>
//{
//    options.AddPolicy("RequireParentRole",
//        policy => policy.RequireRole("Phụ huynh"));
//});


var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
