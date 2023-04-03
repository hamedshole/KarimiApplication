using KarimiApp.Model;

namespace KarimiApp.Interface.Client
{
    public interface IPerson:IMainRepository<PersonModel>
    {
        void Settle(PersonModel person);
    }
}
