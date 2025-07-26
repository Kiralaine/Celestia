using Celestia.DataAccess;
using Celestia.DataAccess.Entities;
using Celestia.DataAcess;
using Microsoft.EntityFrameworkCore;

namespace Celestia.Repository.Repositories;
public class UserRepository : IUserRepository
{
    private readonly MainContext MainContext;
    public UserRepository(MainContext mainContext)
    {
        MainContext = mainContext;
    }
    
    public async Task<bool> CheckUserExistance(long userId)
    {
        return await MainContext.Users.AnyAsync(x => x.UserId == userId);
    }

    public async Task DeleteAsync(UserEntity user)
    {
        MainContext.Users.Remove(user);
        await MainContext.SaveChangesAsync();
    }

    public async Task<long> InsertAsync(UserEntity user)
    {
        await MainContext.Users.AddAsync(user);
        await MainContext.SaveChangesAsync();
        return user.UserId;
    }

    public async Task<ICollection<UserEntity>> SelectAllAsync()
    {
        var users = await MainContext.Users.ToListAsync();

        return users;
    }

    public async Task<UserEntity?> SelectByIdAsync(long userId)
    {
        var user = await MainContext.Users.FirstOrDefaultAsync(u => u.UserId == userId);

        if(user == null)
        {
            return user;
        }

        return user;
    }

    public async  Task UpdateAsync(UserEntity user)
    {
        MainContext.Users.Update(user);
        await MainContext.SaveChangesAsync();

    }
}
