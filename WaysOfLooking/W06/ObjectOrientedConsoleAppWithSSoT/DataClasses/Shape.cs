namespace TWOLAT.RPS.Lib
{                   
    public partial class Shape 
    {
        public Shape(string name, char playerCode, char oppCode, char winsAgainst, int score)
        {
            this.Name = name;
            this.PlayerCode = $"{playerCode}";
            this.OppCode = $"{oppCode}";
            this.WinsAgainst = $"{winsAgainst}";
            this.Score = score;
        }

        internal bool WinsTo(Shape opponentShape)
        {
            return this.WinsAgainst == opponentShape.OppCode;
        }

        internal bool LosesTo(Shape opponentShape)
        {
            return opponentShape.WinsAgainst == this.OppCode;
        }
    }
}