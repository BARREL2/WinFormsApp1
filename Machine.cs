namespace WinFormsApp1
{
    public class Instrument1 : IInstrument
    {
        public string Measure()
        {
            // Instrument1での計測処理をここに実装
            return "Instrument1: Measurement Result";
        }
    }

    public class Instrument2 : IInstrument
    {
        public string Measure()
        {
            // Instrument2での計測処理をここに実装
            return "Instrument2: Measurement Result";
        }
    }
}