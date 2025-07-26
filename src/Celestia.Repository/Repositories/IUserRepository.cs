using Celestia.DataAccess.Entities;

namespace Celestia.Repository.Repositories;

public interface IUserRepository
{
    Task<long> InsertAsync(UserEntity user);
    Task<ICollection<UserEntity>> SelectAllAsync();

    Task<UserEntity?> SelectByIdAsync(long userId);

    Task<bool> CheckUserExistance(long userId);
    Task DeleteAsync(UserEntity user);
    Task UpdateAsync(UserEntity user);
}