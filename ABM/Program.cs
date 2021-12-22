var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

var teams = new List<Team>();

var index = 1;
var team1 = new Team("River Plate");
team1.Id = index;
index++;
var team2 = new Team("Independiente");
team2.Id = index;
teams.Add(team1);
teams.Add(team2);

//Get All
app.MapGet("/api/teams", () => teams);

//Get
app.MapGet("/api/teams/{id}", (int id) =>
{
    var team = teams.FirstOrDefault(x => x.Id == id);
    return team;
});

//Create
app.MapPost("/api/teams", (Team teamInput) =>
{
    var exist = teams.FirstOrDefault(x => x.Name.ToLower() == teamInput.Name.ToLower());
    if (exist != null) return false;

    teamInput.Id = ++index;
    teams.Add(teamInput);
    return true;
});

//Edit
app.MapPut("/api/teams", (Team teamInput) =>
{
    var team = teams.FirstOrDefault(x => x.Id == teamInput.Id);
    if (team == null) return false;

    teams.Remove(team);
    teams.Add(teamInput);
    return true;
});

//Delete
app.MapDelete("/api/teams/{id}", (int id) =>
{
    var team = teams.FirstOrDefault(x => x.Id == id);
    if (team == null) return false;

    teams.Remove(team);
    return true;
});

app.Run();
