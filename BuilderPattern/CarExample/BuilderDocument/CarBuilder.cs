using BuilderPattern.CarExample.CarDocument;
using BuilderPattern.CarExample.CarDocument.EngineDocument;

namespace BuilderPattern.CarExample.BuilderDocument
{
    /// <summary>
    /// 汽車 Builder
    /// </summary>
    public class CarBuilder : IBuilder
    {
        private Car car;

        public CarBuilder()
        {
            this.car = new Car();
        }

        public void Reset()
        {
            car = new Car();
        }

        public void SetEngine(EngineType engineType)
        {
            car.Engine = engineType;
        }

        public void SetGPS(bool toggle)
        {
            car.GPS = toggle;
        }

        public void SetSeats(int seatNum)
        {
            car.Seat = seatNum;
        }

        public void SetTripComputer(bool toggle)
        {
            car.TripComputer = toggle;
        }

        /// <summary>
        /// 回傳結果的方法不會被定義在 IBuilder 內
        /// 因為不同的 Builder 有不同的回傳值
        /// 就算我們建立 ICar 也不能保證未來不會有汽車以外的東西需要創建
        /// </summary>
        /// <returns></returns>
        public Car GetResult()
        {
            return car;
        }
    }
}
