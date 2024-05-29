using Microsoft.Extensions.Options;
using MongoDB.Driver;

var builder = WebApplication.CreateBuilder(args);
// Fügen Sie diese beiden Zeilen hinzu, um die DatabaseSettings zu registrieren
var movieDatabaseConfigSection = builder.Configuration.GetSection("DatabaseSettings");
builder.Services.Configure<DatabaseSettings>(movieDatabaseConfigSection);

var app = builder.Build();

app.MapGet("/", () => "Minimal API Version 2");

// Ersetzen Sie die Methode zur Injection von DatabaseSettings
app.MapGet("/check",
(IOptions<DatabaseSettings> options) =>
{
try
{
            var mongoDbConnectionString = options.Value.ConnectionString;

           // Verbindung zur MongoDB herstellen
           var client = new MongoClient(mongoDbConnectionString);

           // Datenbanken abfragen
           var databases = client.ListDatabaseNames().ToList();
           var databaseNames = string.Join(", ", databases);

           return $"Zugriff auf MongoDB ok. Vorhandene DBs: {databaseNames}";
       }
       catch (Exception ex)
       {
           return $"Fehler beim Zugriff auf MongoDB: {ex.Message}";
       }
   });
app.Run();