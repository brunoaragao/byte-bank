namespace ByteBank.Infrastructure.Data.ByteBank.EntityConfigurations;

public class ClienteJuridicoEntityTypeConfiguration
    : IEntityTypeConfiguration<ClienteJuridico>
{
    public void Configure(EntityTypeBuilder<ClienteJuridico> builder)
    {
        builder.Property(cj => cj.Cnpj);
    }
}