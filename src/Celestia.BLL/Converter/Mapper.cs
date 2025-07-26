using Celestia.BLL.Dtos.UserDto;
using Celestia.DataAccess.Entities;
namespace Celestia.BLL.Converter
{
    public class Mapper
    {
        public static UserGetDto ConvertToUserGetDto(UserEntity user)
        {
            return new UserGetDto()
            {
                UserId = user.UserId,
                Username = user.Username,
                FirstName = user.FirstName,
                LastName = user.LastName
            };
        }
        public static UserEntity  ConvertToUser(UserCreateDto userCreateDto)
        {
            return new UserEntity() 
            { 
                FirstName = userCreateDto.FirstName,
                LastName = userCreateDto.LastName,
                Email = userCreateDto.Email,
                Password = userCreateDto.Password,
                Username = userCreateDto.UserName
            };
        } 
    }
}
