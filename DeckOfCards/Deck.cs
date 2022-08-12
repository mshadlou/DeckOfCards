using System;

namespace DeckOfCards
{
    internal class Deck
    {
        private Card[] _deck;
        private int TopCard;
        private Random rand;
        
        #region Constructor
        public Deck() {
            int No_of_names = Enum.GetNames(typeof(Names)).Length;
            int No_of_faces = Enum.GetNames(typeof(Faces)).Length;
            int No_of_cards = No_of_faces * No_of_names;

            _deck = new Card[No_of_cards];

            rand = new Random();
            TopCard = 0;
            for (int count=0; count < _deck.Length; count++)
            {
                _deck[count] = new Card((Faces)(count % No_of_faces), (Names)(count / No_of_faces));
            }
        }
        #endregion

        #region Properties
        public Card[] deck { 
            get { return _deck; }
            set { _deck = value; }
        }
        #endregion

        #region Methods
        /*
         Mathod: Shuffle the Deck
        */
        public void Shuffle()
        {
            _deck = _deck.OrderBy(x => rand.Next()).ToArray();
        }
        /*
         Mathod: Sort The usine the name of the first cards and then from King to Ace
         */
        public void Sort()
        {
            _deck = _deck
                .GroupBy(x => x.name)
                .OrderByDescending(y => y.Count())
                .SelectMany(z => z.OrderByDescending(c => c.face)).ToArray();
        }
        /*
         Mathod: Deal the top card
        */
        public Card DealTopCard()
        {
            return _deck[TopCard];
        }
        /*
         Mathod: Deal any card by setting the index/position as the input parameter
        */
        public Card DealAnyCard(int index)
        {
            if (index >= _deck.Length - TopCard || index < TopCard)
            {
                throw new IndexOutOfRangeException("Choosen position of card is out of range");
            }
            else
            {
                return _deck[TopCard + index];
            }
        }
        #endregion
    }
}
