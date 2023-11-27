using System.Text.Json.Serialization;
using Fashion_e.BL.Services.CategoryService;
using Fashion_e.BL.Services.ColorProductService;
using Fashion_e.BL.Services.FeedbackService;
using Fashion_e.BL.Services.GalleryService;
using Fashion_e.BL.Services.PhotoService;
using Fashion_e.BL.Services.ProductService;
using Fashion_e.BL.Services.SizeColorProductService;
using Fashion_e.BL.Services.SizeProductService;
using Fashion_e.Common.Models;
using Fashion_e.DL.Constracts;
using Fashion_e.DL.Context;
using Fashion_e.DL.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// ignore cycles
builder.Services.AddControllers()
    .AddJsonOptions(options =>
        options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

// auto mapper
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

// cloudinary setting
builder.Services.Configure<CloudinarySettings>(
    builder.Configuration.GetSection("CloudinarySettings")
);

// Add services to the container.
// category
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();

// size
builder.Services.AddScoped<ISizeProductService, SizeProductService>();
builder.Services.AddScoped<ISizeProductRepository, SizeProductRepository>();

// color
builder.Services.AddScoped<IColorProductService, ColorProductService>();
builder.Services.AddScoped<IColorProductRepository, ColorProductRepository>();

// product
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IProductService, ProductService>();

// gallery
builder.Services.AddScoped<IGalleryRepository, GalleryRepository>();
builder.Services.AddScoped<IGallerySevice, GalleryService>();

// sizeColorProduct
builder.Services.AddScoped<ISizeColorProductRepository, SizeColorProductRepository>();
builder.Services.AddScoped<ISizeColorProductService, SizeColorProductService>();

// feedback
builder.Services.AddScoped<IFeedbackRepository, FeedbackRepository>();
builder.Services.AddScoped<IFeedbackService, FeedbackService>();

// photo service
builder.Services.AddScoped<IPhotoService, PhotoService>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<DataContext>(
    options => options.UseSqlServer("name=Connection")
);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
