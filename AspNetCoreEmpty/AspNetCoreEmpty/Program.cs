//Pipeline

var builder = WebApplication.CreateBuilder(args);
// Servis tan�mlamalar�
builder.Services.AddControllersWithViews();

var app = builder.Build();
//Middele Ware (ara katman)
//�al��ma zaman�nda uygulamaya eklenecek uygulamalar
app.UseRouting(); // Rotalama �zelle�ini �al��t�r
app.UseStaticFiles(); // Uygulamada ki Statik (HTML,Css ve js gibi) dosyalar� kullan�ma a�
app.UseHttpsRedirection(); //https redirect et

app.MapControllerRoute(name:"default",pattern:"{controller=Home}/{action=Index}/{id?}");

app.Run();
