using BuilderPattern.CarExample.CarDocument;
using BuilderPattern.CarExample.CarDocument.EngineDocument;

namespace BuilderPattern.CarExample.BuilderDocument
{
    /// <summary>
    /// 汽車手冊 Builder
    /// </summary>
    public class CarManualBuilder : IBuilder
    {
        private CarManual carManul;

        public CarManualBuilder()
        {
            this.carManul = new CarManual();
        }

        public void Reset()
        {
            this.carManul = new CarManual();
        }

        public void SetEngine(EngineType engineType)
        {
            carManul.Engine = engineType;
        }

        public void SetGPS(bool toggle)
        {
            carManul.GPS = toggle;
        }

        public void SetSeats(int seatNum)
        {
            carManul.Seat = seatNum;
        }

        public void SetTripComputer(bool toggle)
        {
            carManul.TripComputer = toggle;
        }

        /// <summary>
        /// 回傳結果的方法不會被定義在 IBuilder 內
        /// 因為不同的 Builder 有不同的回傳值
        /// 就算我們建立 ICar 也不能保證未來不會有汽車以外的東西需要創建
        /// </summary>
        /// <returns></returns>
        public CarManual GetResult()
        {
            return carManul;
        }
    }
}
