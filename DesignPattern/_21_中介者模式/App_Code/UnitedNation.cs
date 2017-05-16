namespace _21_中介者模式.App_Code
{
    public class UnitedNation : Mediator
    {
        private Country _country1;

        public Country Country1 { set => _country1 = value; }
        private Country _country2;
        public Country Country2 { set => _country2 = value; }


        public override void Send(string msg, Country country)
        {
            if (country == _country1)
            {
                _country2.Notify(msg);
            }
            else
            {
                _country1.Notify(msg);
            }
        }
    }
}