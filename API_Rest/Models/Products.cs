using System.Text.Json.Serialization;
namespace API_Rest.Models
{
    public partial class Products
    {
        [JsonIgnore(Condition =JsonIgnoreCondition.Never)]
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Color { get; set; }
        [JsonIgnore(Condition=JsonIgnoreCondition.Never)]
        public decimal UnitPrice { get; set; }
        [JsonIgnore(Condition=JsonIgnoreCondition.Always)]
        public int AvailableQuantity { get; set; }
    }
}