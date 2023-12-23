using BuilderPattern.CarExample.BuilderDocument;
using BuilderPattern.CarExample.CarDocument.EngineDocument;

namespace BuilderPattern.CarExample
{
    /// <summary>
    /// Director 負責定義 Builder 的執行順序
    /// </summary>
    public class Director
    {
        public void ConstructSportsCar(IBuilder builder)
        {
            builder.Reset();
            builder.SetSeats(2);
            builder.SetEngine(EngineType.EngineA);
            builder.SetTripComputer(true);
            builder.SetGPS(true);
        }

        public void ConstructSUV(IBuilder builder)
        {
            builder.Reset();
            builder.SetSeats(4);
            builder.SetEngine(EngineType.EngineB);
            builder.SetTripComputer(false);
            builder.SetGPS(true);
        }
    }
}
