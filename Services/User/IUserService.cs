using System;

namespace GolfScoreStoringWebApplication.Services.User
{
    public interface IUserService
    {
        Guid GetCurrentUserId();
    }
}
