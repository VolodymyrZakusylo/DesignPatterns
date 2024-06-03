namespace ClassLibrary1
{
    public abstract class Money
    {
        public int WholePart { get; set; }
        public int CoinPart { get; set; }

        public Money(int wholePart, int coinPart)
        {
            setMoney(wholePart, coinPart);
        }
        
        public void setMoney(int wholePart, int coinPart)
        {
            if (wholePart < 0 || coinPart < 0)
                throw new ArgumentException("Гроші не можуть бути від'ємним числом");
            if (coinPart > 100)
                throw new ArgumentException("Копійок не може бути більше 100");
            WholePart = wholePart;
            CoinPart = coinPart;
        }
        public virtual string showMoney()
        {
            return $"{WholePart}.{CoinPart}";
        }
        public override string ToString()
        {
            return showMoney();
        }
    }
}