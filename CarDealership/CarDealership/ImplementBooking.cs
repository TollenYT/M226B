using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealership
{
    public class ImplementBooking : IBooking
    {
        public event EventHandler<IDisplayEventArgs> buyCar;

        public void BookCar(Car car)
        {
            OnBooked(car);
        }

        private void OnBooked(Car car)
        {
            if (buyCar != null && car != null)
            {
                buyCar(this, new DisplayEventArgsImpl($"{car.Name} has been bought for {car.Cost}CHF!"));
            }
        }
    }
}
