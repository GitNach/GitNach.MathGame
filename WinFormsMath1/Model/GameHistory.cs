using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsMath1.Model
{
    public  class GameHistory
    {
        public enum GameType { Addition, Subtraction, Multiplication, Division }
        public GameType Type { get; set; }

        public DateTime Date { get; set; }

        public int Score { get; set; }


    }
}
