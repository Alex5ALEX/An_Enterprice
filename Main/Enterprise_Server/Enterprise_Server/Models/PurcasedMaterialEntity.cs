namespace Enterprise_Server.Models;

public class PurcasedMaterialEntity
{

    public Guid Id { get; set; }

    public double Weight { get; set; } = 0;

    public DateTime Data { get; set; } = DateTime.MinValue;


    public Guid Id_Provider {  get; set; }

    public ProviderEntity Provider { get; set; }


    public Guid Id_Material { get; set; }

    public MaterialEntity? Material { get; set; }
}