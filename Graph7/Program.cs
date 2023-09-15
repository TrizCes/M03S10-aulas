using Graph7;
using Microsoft.AspNetCore.Components.Web;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services
    .AddGraphQLServer()
    .AddDocumentFromString(@"
    type Query{
            book(title: string): Book
            books: [Book]
            author: Author
        }
        type Book{
            title: String,
            author: String
        }
        type Author{
            name: String
        }
    ")
    .BindRuntimeType<Query>()
    .BindRuntimeType<Book>()
    .BindRuntimeType<Author>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapGraphQL();

app.Run();
