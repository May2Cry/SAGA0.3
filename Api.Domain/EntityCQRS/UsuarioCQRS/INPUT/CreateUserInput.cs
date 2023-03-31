using Microsoft.EntityFrameworkCore;
using SAGA0._3.Api.Domain.Models;
using SAGA0._3.Api.InfraEstructura.Context;

namespace SAGA0._3.Api.Domain.EntityCQRS.UsuarioCQRS.INPUT
{
    public class CreateUserInput
    {
        private readonly BootcampG6Context _context;
    public CreateUserInput(BootcampG6Context context)
    {
        _context = context;
    }

    public async Task<bool> CreateUser(Usuario user)
    {
        try
        {
            await _context.Usuario.AddAsync(user);

            await _context.SaveChangesAsync();

            return true;
        }
        catch (Exception)
        {
            throw;
        }
    }
}
}
