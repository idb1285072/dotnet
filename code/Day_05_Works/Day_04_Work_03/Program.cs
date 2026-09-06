// Route Constraints
/*
decimal
int 
bool
guid
datetime
minlength(value)
maxlength(value)
length(min,max)
length(value)
min(value)
max(value)
range(min, max)
alpha
regex(expression)
*/
using Day_05_Work_03.CustomConstraint;

var builder = WebApplication.CreateBuilder(args);

// Register Custom Constraint
builder.Services.AddRouting(options =>
{
    options.ConstraintMap.Add("months", typeof(MonthCustomConstraint));
});

var app = builder.Build();

// GET: product/details/{id}
app.Map("product/details/{id:int:min(1):max(100)?}", async (HttpContext context) =>
{
    if (context.Request.RouteValues.ContainsKey("id"))
    {

        int id = Convert.ToInt32(context.Request.RouteValues["id"]);
        await context.Response.WriteAsync($"Product Details - {id}");
    }
    else
    {
        await context.Response.WriteAsync("Product Details - No id is supplied");
    }
});

// GET: daily-digest-report/{reportDate}
app.Map("daily-digest-report/{reportDate:datetime}", async (HttpContext context) =>
{
    DateTime reportDate = Convert.ToDateTime(context.Request.RouteValues["reportDate"]);
    await context.Response.WriteAsync($"In daily-digest-report: {reportDate.ToShortDateString()}");
});

// GET: cities/{cityId}
// GUID: CD408577-38C7-4C1A-8355-200BC7419156
app.Map("cities/{cityId:guid}", async (HttpContext context) =>
{
    Guid cityId = Guid.Parse(Convert.ToString       (context.Request.RouteValues["cityId"])!);
    await context.Response.WriteAsync($"In City: {cityId}");
});

// GET: /employee/profile/{employeeName}
app.Map("employee/profile/{employeeName:alpha:minlength(3):maxlength(8)=scott}", async (HttpContext context) =>
{
    string? employeeName = Convert.ToString(context.Request.RouteValues["employeeName"]);
    await context.Response.WriteAsync($"{employeeName}");
});

// GET: sales-report/{year}/{month}
app.Map("sales-report/{year:int:min(1900)}/{month:months}", async (HttpContext context) =>
{
    int year = Convert.ToInt32(context.Request.RouteValues["year"]);
    string? month = Convert.ToString(context.Request.RouteValues["month"]);
    await context.Response.WriteAsync($"Sales report: {year} {month}");
});

// GET: sales-report/2024/jan
app.Map("sales-report/2024/jan", async (HttpContext context) =>
{
    await context.Response.WriteAsync("Sales report exclusively exclusively for 2024 - jan");
});

app.MapFallback(async (HttpContext context) =>
{
    await context.Response.WriteAsync($"The path is: {context.Request.Path}");
});

app.Run();
