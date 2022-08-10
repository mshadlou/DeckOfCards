namespace DeckOfCards
{
    internal class Card
    {
        private Faces _face;
        private Names _name;

        #region Constructor
        public Card(Faces face, Names name)
        {
            this._face = face;
            this._name = name;
        }
        #endregion

        #region Propoerties
        public Faces face { 
            get { return _face;} 
            set { _face = value; }
        }
        public Names name
        {
            get { return _name;}
            set { _name = value; }
        }
        #endregion

        #region Overriding ToString
        public override string ToString()
        {
            return $"{_face} of {_name}";
        }
        #endregion

    }
}
