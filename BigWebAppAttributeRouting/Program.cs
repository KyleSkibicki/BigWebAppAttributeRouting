var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews(options => options.EnableEndpointRouting = false);

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

//app.UseRouting();

app.UseAuthorization();

app.UseMvc(routes =>
{
    routes.MapRoute("default", "{area}/{controller}/{action}/{id?}");
//    routes.MapRoute("other", "{controller=Home}/{action=Index}/{id?}");
});


//Test url: https://localhost:7177/Area0001/Cntlr0001/Act0001

app.Run();