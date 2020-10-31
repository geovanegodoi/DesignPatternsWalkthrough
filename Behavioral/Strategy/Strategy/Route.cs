using System;
namespace Strategy.Strategy
{
    public class Route
    {
        public int Distance { get; set; }

        public int Time { get; set; }

        public decimal Value { get; set; }

        public Route(int distance, int time, decimal value)
        {
            Distance = distance;
            Time = time;
            Value = value;
        }

        public override string ToString()
        {
            return $"Distance .: {Distance}\r\n"+
                   $"Time .....: {Time}\r\n"+
                   $"Value ....: {Value}\r\n";
        }
    }
}
