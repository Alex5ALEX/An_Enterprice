namespace Enterprise_Server.Models;

public class CompaundEntity
{
    public double Weight { get; set; } = 0;

    public Guid Id_Material { get; set; }

    public MaterialEntity? Material { get; set; }


    public Guid Id_Product { get; set; }

    public ProductEntity? Product { get; set; }
}