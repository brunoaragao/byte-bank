namespace ByteBank.Infrastructure.Data.Repositories;

public class ClienteRepository : GenericRepository<Cliente>, IClienteRepository
{
    public ClienteRepository(ByteBankContext context, IUnitOfWork unitOfWork)
        : base(context, unitOfWork)
    {
    }
}