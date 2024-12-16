namespace Enterprise_Server.Models;

public class MaterialCompaund
{
    public double Weight { get; set; } = 0;

    //links

    public Guid Id_Product { get; set; }

    public Product? Product { get; set; }


    public Guid Id_Material {  get; set; }
    
    public Material? Material { get; set; }
}