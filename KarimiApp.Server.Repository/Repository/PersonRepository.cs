using KarimiApp.Interface.Server;
using KarimiApp.Model;

namespace KarimiApp.Server.Repository.Repository
{
    internal class PersonRepository : MainRepository<PersonModel>,IPerson
    {
        private IPerson repository;
        public PersonRepository(IPerson repository) : base(repository)
        {
            this.repository = repository;
        }

        string IPerson.Settle(PersonModel person)
        {
            var result = this.repository.Settle(person);
            return result;
        }
    }
}
