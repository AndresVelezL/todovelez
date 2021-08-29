using System;

namespace todovelez.Common.Models
{
    public class Todo
    {
        public DateTime dateTime { get; set; }

        public string TaskDescription { get; set; }

        public bool IsCompleted { get; set; }

    }
}
