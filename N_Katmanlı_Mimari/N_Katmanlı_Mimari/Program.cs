using BussinessLayer.Abstract;
using BussinessLayer.Conrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Conrete;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Scope Interface and Implementation
builder.Services.AddScoped<IProductService, ProductManager>();
builder.Services.AddScoped<IProductDal, EfProductDal>();
builder.Services.AddScoped<IUserService, UserManager>();
builder.Services.AddScoped<IUserDal, EfUserDal>();
builder.Services.AddScoped<IReservationUserService, ReservationUserManager>();
builder.Services.AddScoped<IReservationUserDal, EfReservationUserDal>();
builder.Services.AddScoped<IHomePageService, HomePageManager>();
builder.Services.AddScoped<IHomePageDal, EfHomePageDal>();
builder.Services.AddScoped<IRoomService, RoomManager>();
builder.Services.AddScoped<IRoomDal,EfRoomDal >();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

// Configure the route
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Account}/{action=Login}/{id?}");

app.Run();
