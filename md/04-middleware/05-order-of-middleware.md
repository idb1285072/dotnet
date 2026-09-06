## Order of Middleware

- ExceptionHandling
- HSTS
- HttpsRedirection
- Static Files
- Routing
- CORS
- Authentication
- Authorization
- Custom Middleware
- Endpoint

## Example

```cs
app.UseExceptionHandler("/Error");
app.UseHsts();
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseCors();
app.UseAuthentication();
app.UseAuthorization();
app.UseSession();
app.MapControllers();
// add your custom middlewares
app.Run();
```
