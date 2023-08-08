using System;
namespace DigiCash.Models
{
    public class History
    {
        public string processName { get; set; }
        public string oldBalance = null;
        public string newBalance = null;
        public DateTime DateTime { get; set; }
        public History()
        {
            DateTime = DateTime.Now;
        }
    }
}

