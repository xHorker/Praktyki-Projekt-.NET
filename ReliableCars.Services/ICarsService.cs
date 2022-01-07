using System.Collections.Generic;
namespace ReliableCars.Services

    public interface ICarsService
    {
    public List<Car> GetAllCars();
    public void AddCar(Car car);
    public void DeleteBook(int carId);

    }
}
