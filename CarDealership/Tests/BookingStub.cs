using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    internal class BookingStub : IBooking
    {
        public event EventHandler<IDisplayEventArgs> buyCar;

        private double _value;
        public int GetValueRequestCounter { get; private set; }

        public BookingStub()
        {
            _value = 10;
            GetValueRequestCounter = 0;
        }

        public double GetValue()
        {
            GetValueRequestCounter++;
            return _value;
        }

        public void BookCar(Car car)
        {
            throw new NotImplementedException();
        }
    }
}
