﻿namespace Ghiran_Andrei_Project.Models
{
    public class Platform
    {
        public int ID { get; set; }
        public string PlatformName { get; set; }
        public ICollection<Game>? Games { get; set; }

    }
}
