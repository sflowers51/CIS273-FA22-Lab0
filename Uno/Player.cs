using System;
using System.Drawing;

namespace Uno
{

	public class Player
	{
		public string Name { get; set; }

        public List<Card> Hand { get; set; }


        public Player()

        {
            Name = "";
            Hand = new List<Card>();
        }

        public bool HasPlayableCard(Card card)
		{
			
			foreach(object cards in Hand)
			{
				if ( cards == card)
				{
					return true;	 		
				}
				else
				{
					return false;
				}
            }
			if (cards = true)
			{
				return true;
			}

			else 
			{
				return	false;
			}

		}
		
        public Card GetFirstPlayableCard(Card card)
		{

			return new Card();

        }
		
        public Color MostCommonColor()
		{
			return Color.Blue;
		}



    }
}

