using QuantumShop.Models;

namespace QuantumShop.Data.Repositories
{
    public interface IDeviceRepository
    {
        Device GetDevice(int Id);
        Device AddDevice(Device dev);
        Device DeleteDevice(Device dev);

    }
}