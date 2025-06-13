namespace BTON2.Models
{
    public class Assignment
    {
        public int Id { get; set; }
        public int DeviceId { get; set; }
        public int ServiceId { get; set; }
        public int AssignedNumber { get; set; }
        public DateTime AssignedDate { get; set; }
        public bool Used { get; set; }
    }
}
