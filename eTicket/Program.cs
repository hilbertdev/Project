using Presentation;
using Project.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

var configuration = builder.Configuration;
builder.Services.AddSwaggerGen();
builder.Services.AddApplicationServices()
.AddInfrastructureServices(configuration)
.AddPresentationServices();

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseHttpsRedirection();
app.MapControllers();
app.Run();


/*{
  "id": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
  "eventName": "My First Attempt",
  "eventType": 1,
  "venueId": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
  "eventDescription": "This is strictly a test event",
  "eventOrganizerEmail": {
    "Address": "hilbertmuna@gmail.com"
},
  "eventOrganizerContact": "0634714182",
  "organizerId": "3fa85f64-5717-4562-b3fc-2c963f66afa6"
}*/