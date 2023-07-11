namespace Jotform;

public partial class PostFormReports
{
    public Task PostUserRegisterAsync(string username, string password, string email, CancellationToken cancellationToken = default) 
        => throw new NotSupportedException();
}