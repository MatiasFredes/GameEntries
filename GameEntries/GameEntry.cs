using System;
using System.Collections.Generic;
using System.Text;

namespace GameEntries
{
    public class GameEntry
    {
        public int Score { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return $"Name: {Name} - Score: {Score}";
        }
    }
}
