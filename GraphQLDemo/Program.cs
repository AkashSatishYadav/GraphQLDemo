using GraphQL;
using GraphQLDemo.Contacts;
using GraphQLDemo.Context;
using GraphQLDemo.Extensions;
using GraphQLDemo.GraphQlSchema;
using GraphQLDemo.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ApplicationContext>(op =>
{
    op.UseNpgsql(builder.Configuration["ConnectionStrings:DefaultConnection"]);
}, ServiceLifetime.Singleton);
builder.Services.AddSingleton<IUserRepository, UserRepository>();
builder.Services.AddSingleton<IAccountRepository, AccountRepository>();
builder.Services.AddScoped<GraphSchema>();
builder.Services.AddGraphQL(options => {
    options.AddSystemTextJson();
    options.AddGraphTypes();
});
        

var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();
app.UseGraphQL<GraphSchema>();
app.UseGraphQLPlayground();
app.MapControllers();
app.EnsurePopulated();
app.Run();
