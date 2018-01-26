using System.Collections.Generic;
using System.ServiceModel;

namespace ContactServiceLib
{
    [ServiceContract]
    public interface IContactService
    {
        [OperationContract]
        long CreateContact(ContactDto contact);

        [OperationContract]
        IEnumerable<ContactDto> GetAllContacts();

        [OperationContract]
        void DeleteContact(long Id);

        [OperationContract]
        ContactDto GetContactDetails(long id);
    }
}
