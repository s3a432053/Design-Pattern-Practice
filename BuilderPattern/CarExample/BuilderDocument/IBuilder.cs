using BuilderPattern.CarExample.CarDocument.EngineDocument;

namespace BuilderPattern.CarExample.BuilderDocument
{
    /// <summary>
    /// Builder 介面
    /// 定義 汽車的建置需要哪些流程
    /// </summary>
    public interface IBuilder
    {
        public void Reset();
        public void SetSeats(int number);
        public void SetEngine(EngineType engineType);
        public void SetTripComputer(bool toggle);
        public void SetGPS(bool toggle);
    }
}
