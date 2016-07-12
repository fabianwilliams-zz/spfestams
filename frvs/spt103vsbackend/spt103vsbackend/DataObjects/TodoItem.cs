using Microsoft.Azure.Mobile.Server;

namespace spt103vsbackend.DataObjects
{
    public class TodoItem : EntityData
    {
        public string Text { get; set; }
        public double SessionGrade { get; set; }
        public string AttendeeFullName { get; set; }
        public string AttendeeEmail { get; set; }
        public bool Complete { get; set; }
    }
}