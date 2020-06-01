using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameEntries
{
    public class Scoreboard
    {
        public Scoreboard(int capacity)
        {
            Board = new GameEntry[capacity];
            NumEntries = 0;
        }

        public int Capacity { get; set; }
        public int NumEntries { get; private set; }
        public GameEntry[] Board { get; set; }

        public void AddEntry(GameEntry gameEntry)
        {
            if (Board.IsNullOrEmpty())
            {
                Board[0] = gameEntry;
                NumEntries++;
            }
                
            int newScore = gameEntry.Score;
            if (Board.Length < Capacity || Board[NumEntries - 1].Score < newScore)
            {
                if (Board.Length < Capacity)
                {
                    for (int index = 0; index <= NumEntries; index++)
                    {
                        if (Board[index].Score > newScore)
                        {
                            Board.InsertInto(Board[index], index);
                            break;
                        }
                    }
                    
                    NumEntries++;
                }
                else
                {
                    if (Board.Last().Score < gameEntry.Score)
                        Board[NumEntries - 1] = gameEntry;
                }
            }
        }
    }
}
