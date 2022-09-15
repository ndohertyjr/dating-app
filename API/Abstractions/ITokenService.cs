using API.Entities;

namespace API.Abstractions;

public interface ITokenService
{ 
    string CreateToken(AppUser user);
    
}