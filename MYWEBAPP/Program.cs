var builder = WebApplication.CreateBuilder(args);

// Thêm dòng này để cấu hình port HTTPS
builder.WebHost.UseUrls("http://localhost:5182", "https://localhost:7182");

// Thêm các dịch vụ vào container
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Cấu hình pipeline HTTP request
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
