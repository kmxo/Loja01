using System.Collections;



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
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

class Test : IEnumerable
{
    Test[] Items = null;
    int freeIndex = 0;
    public String Name { get; set; }
    public string Surname { get; set; }
    public Test()
    {
        Items = new Test[10];
    }
    public void Add(Test item)
    {
        Items[freeIndex] = item;
        freeIndex++;
    }
    // IEnumerable Member  
    public IEnumerator GetEnumerator()
    {
        foreach (object o in Items)
        {
            if (o == null)
            {
                break;
            }
            yield return o;
        }
    }
}