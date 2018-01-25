using System.Collections.Generic;
using System.ServiceModel;

namespace ContactServiceLibrary.Interfaces
{
    [ServiceContract]
    public interface IContactService<T, TKey> where T : IContactType<TKey>
    {
        [OperationContract]
        TKey CreateContact(T contact);

        [OperationContract]
        IEnumerable<T> GetAllContacts();

        [OperationContract]
        void DeleteContact(TKey Id);
    }

}