namespace Domain.Customers
{
    public interface ICustomerRepository
    {
        Task<Customer> GetByIdAsync(Guid id);
        Task Add(Customer customer);
    }
}
