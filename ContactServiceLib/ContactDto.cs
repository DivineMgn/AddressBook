using System.Runtime.Serialization;
using System.ServiceModel;

namespace ContactServiceLib
{
    [ServiceContract]
    public class ContactDto
    {
        [DataMember(IsRequired = false)]
        public long Id { get; set; }

        [DataMember(IsRequired = true)]
        public string FirstName { get; set; }

        [DataMember(IsRequired = true)]
        public string LastName { get; set; }

        [DataMember(IsRequired = false)]
        public string SecondName { get; set; }

        [DataMember(IsRequired = true)]
        public string Email { get; set; }
    }
}