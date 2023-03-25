namespace P230_Pronia.Entities
{
    public class PlantCategory:BaseEntity
    {
        public int PlantId { get; set; }
        public int CategoryId { get; set; }
        public Plant Plant { get; set; }
        public Category Category { get; set; }
    }
}
