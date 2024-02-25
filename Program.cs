

using FinancialTamkeen_BlogAPI.App;

var builder = WebApplication.CreateBuilder(args);

var config = Config.build(builder);


var app = config.Build();

var bootstrap = Bootstrap.start(app);

bootstrap.Run();
