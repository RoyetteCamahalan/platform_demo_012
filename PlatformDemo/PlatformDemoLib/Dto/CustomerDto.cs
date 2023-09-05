namespace PlatformDemoLib.Dto
{
    public class CustomerDto
    {
        public long Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string ContactNo { get; set; } = string.Empty;
        public decimal TotalOrder { get; set; }
    }
}
