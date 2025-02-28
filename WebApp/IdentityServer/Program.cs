using IdentityServer.Fillter;
using IdentityServer.Middleware;
using Infratructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers(option =>
{
    option.Filters.Add<ErrorHandlingFilterAttribute>();
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDI();
//builder.Services.AddIdentityServer(options =>
//{
//    options.Events.RaiseErrorEvents = true;
//    options.Events.RaiseInformationEvents = true;
//    options.Events.RaiseFailureEvents = true; 
//    options.Events.RaiseSuccessEvents = true;
//    options.EmitStaticAudienceClaim = true;
//}).AddAspNetIdentity<Users>();
//builder.Services.addJwt
var app = builder.Build();
//app.UseMiddleware<ErrorHandlingMiddleware>();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();
app.UseIdentityServer();
app.UseAuthorization();

app.MapControllers();

app.Run();
