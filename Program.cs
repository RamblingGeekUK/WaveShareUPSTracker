using System.Net;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("WaveShare") ?? "Data Source=WaveShareUPSTracker.db";
builder.Services.AddSqlite<WSDb>(connectionString);
builder.Services.AddDatabaseDeveloperPageExceptionFilter();
var app = builder.Build();

var reading = app.MapGroup("/data");

reading.MapPost("/", LogReading);
reading.MapGet("/",GetReadings);

static async Task<IResult> GetReadings(WSDb db)
{
    return TypedResults.Ok(await db.readings.Select(r=> new Reading(r)).ToArrayAsync());
}

static async Task<IResult> LogReading(Reading reading , WSDb db)
{
    var readingEntry = new Reading
    {
        //DateCreated = reading.DateCreated = DateTime.Now,
        LoadVoltage = reading.LoadVoltage,
        Current = reading.Current,
        Power = reading.Power,
        PercentRemaining = reading.PercentRemaining
    };

    db.readings.Add(readingEntry);
    await db.SaveChangesAsync();

    reading = new Reading(readingEntry);
    return TypedResults.Created($"/data/{readingEntry.Id}", reading);
}

app.Run();