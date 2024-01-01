using System.Text;
using System.Text.Json.Serialization;
using Fashion_e.BL.Services.CategoryService;
using Fashion_e.BL.Services.ColorProductService;
using Fashion_e.BL.Services.CustomerService;
using Fashion_e.BL.Services.EmployeeService;
using Fashion_e.BL.Services.FeedbackService;
using Fashion_e.BL.Services.GalleryService;
using Fashion_e.BL.Services.OrderDetailService;
using Fashion_e.BL.Services.OrderService;
using Fashion_e.BL.Services.PhotoService;
using Fashion_e.BL.Services.ProductService;
using Fashion_e.BL.Services.ShipperService;
using Fashion_e.BL.Services.SizeColorProductService;
using Fashion_e.BL.Services.SizeProductService;
using Fashion_e.Common.Models;
using Fashion_e.DL.Constracts;
using Fashion_e.DL.Context;
using Fashion_e.DL.Repositories;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Filters;

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
// cors
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(
        policy =>
        {
            policy.WithOrigins("http://localhost:3000")
                .AllowAnyHeader()
                .AllowAnyMethod();
        });
});

// add authentication
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(options =>
{
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = false,
        ValidateAudience = false,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("my top secret key"))
    };
});


// config swagger to provide jwt
builder.Services.AddSwaggerGen(option =>
{
    option.AddSecurityDefinition("oauth2", new OpenApiSecurityScheme
    {
        In = ParameterLocation.Header,
        Name = "Authorization",
        Type = SecuritySchemeType.ApiKey
    });

    option.OperationFilter<SecurityRequirementsOperationFilter>();
});

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

// customer
builder.Services.AddScoped<ICustomerService, CustomerService>();
builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();

// employee
builder.Services.AddScoped<IEmployeeService,  EmployeeService>();
builder.Services.AddScoped<IEmployeeRepository,  EmployeeRepository>();

// shipper
builder.Services.AddScoped<IShipperService,  ShipperService>();
builder.Services.AddScoped<IShipperRepository,  ShipperRepository>();

// order
builder.Services.AddScoped<IOrderService, OrderService>();
builder.Services.AddScoped<IOrderRepository, OrderRepository>();

// order detail
builder.Services.AddScoped<IOrderDetailService,  OrderDetailService>();
builder.Services.AddScoped<IOrderDetailRepository,  OrderDetailRepository>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

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

app.UseCors();

app.Run();
