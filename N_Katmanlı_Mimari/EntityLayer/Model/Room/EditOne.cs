

namespace EntityLayer.Model.Room
{
    public class EditOne
    {
        public int RoomId { get; set; }
        public int RoomNumber { get; set; }
        public string RoomType { get; set; }
        public int Stock { get; set; }
        public bool IsActive { get; set; } = false;
    }
}
