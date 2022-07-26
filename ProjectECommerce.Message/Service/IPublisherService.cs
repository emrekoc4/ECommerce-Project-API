
namespace ProjectECommerce.Message.Service
{
    public interface IPublisherService
    {
        Task PublishAsync(int id, string email);
    }
}
