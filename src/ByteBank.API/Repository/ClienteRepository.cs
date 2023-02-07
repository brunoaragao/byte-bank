﻿using ByteBank.API.Base;
using ByteBank.API.Data;
using ByteBank.API.Interface;
using ByteBank.API.Models;

namespace ByteBank.API.Repository;

public class ClienteRepository : BaseRepository<Cliente>, IClienteRepository
{
    private ByteBankContext _context;
    public ClienteRepository(ByteBankContext context) : base(context)
    {
        _context = context;
    }
}