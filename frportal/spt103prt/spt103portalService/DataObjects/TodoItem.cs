using Microsoft.Azure.Mobile.Server;

namespace spt103portalService.DataObjects
{
    public class TodoItem : EntityData
    {
        public string Text { get; set; }
        public string AssignedTo { get; set; }
        public string EmailAddr { get; set; }
        public bool Complete { get; set; }
    }
}