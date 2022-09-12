using System;
namespace Uno
{
<<<<<<< HEAD
    public class Player
    {
        public string Name { get; set; }
=======
	public class Player
	{
		public string Name { get; set; }
>>>>>>> 3d5323698de550429ace8c78d039be1d57391eb5
        public List<Card> Hand { get; set; }


        public Player()
<<<<<<< HEAD
        {
            Name = "";
            Hand = new List<Card>();
        }

        public bool HasPlayableCard(Card card)
        {
            return false;
        }

        public Card GetFirstPlayableCard(Card card)
        {
            return new Card();
        }

        // TODO
        public Color MostCommonColor()
        {
            return Color.Blue;
        }
=======
		{
			Name = "";
			Hand = new List<Card>();
		}

        public bool HasPlayableCard(Card card)
		{
			return false;
		}

        public Card GetFirstPlayableCard(Card card)
		{
			return new Card();
		}

        public Color MostCommonColor()
		{
			return Color.Blue;
		}
>>>>>>> 3d5323698de550429ace8c78d039be1d57391eb5


    }
}

