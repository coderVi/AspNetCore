//Pipeline

var builder = WebApplication.CreateBuilder(args);
// Servis tanýmlamalarý
builder.Services.AddControllersWithViews();

var app = builder.Build();
//Middele Ware (ara katman)
//Çalýþma zamanýnda uygulamaya eklenecek uygulamalar
app.UseRouting(); // Rotalama özelleðini çalýþtýr
app.UseStaticFiles(); // Uygulamada ki Statik (HTML,Css ve js gibi) dosyalarý kullanýma aç
app.UseHttpsRedirection(); //https redirect et

app.MapControllerRoute(name:"default",pattern:"{controller=Home}/{action=Index}/{id?}");

app.Run();
