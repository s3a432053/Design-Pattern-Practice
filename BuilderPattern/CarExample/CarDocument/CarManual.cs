using BuilderPattern.CarExample.CarDocument.EngineDocument;

namespace BuilderPattern.CarExample.CarDocument
{
    /// <summary>
    /// 汽車手冊
    /// </summary>
    public class CarManual
    {
        public int Seat { get; set; }
        public EngineType Engine { get; set; }
        public bool TripComputer { get; set; }
        public bool GPS { get; set; }
    }
}
