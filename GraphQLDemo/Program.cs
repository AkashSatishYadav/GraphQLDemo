using GraphQL;
using GraphQLDemo.DbAcess;
using GraphQLDemo.Extensions;
using GraphQLDemo.GraphQlSchema;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<UserDbContext>(op =>
{
    op.UseNpgsql(builder.Configuration["ConnectionStrings:DefaultConnection"]);
}, ServiceLifetime.Singleton);
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
