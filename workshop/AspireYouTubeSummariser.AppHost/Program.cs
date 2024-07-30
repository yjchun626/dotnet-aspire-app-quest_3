var builder = DistributedApplication.CreateBuilder(args);
var apiapp = builder.AddProject<Projects.AspireYouTubeSummariser_ApiApp>("apiapp");
var cache = builder.AddRedis("cache");

builder.AddProject<Projects.AspireYouTubeSummariser_WebApp>("webapp")
       .WithReference(cache)
       .WithReference(apiapp);
builder.Build().Run();
