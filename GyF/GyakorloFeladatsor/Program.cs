var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger().UseSwaggerUI();
}
app.UseDefaultFiles().UseStaticFiles().UseHttpsRedirection().UseAuthorization();
app.MapControllers();
app.Run();
