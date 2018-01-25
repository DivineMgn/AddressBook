using System.Runtime.Serialization;

namespace ContactServiceLibrary.Interfaces
{
    //[DataContract]
    public interface IContactType<TKey>  
    {
        [IgnoreDataMember]
        TKey Id { get; set; }

        [DataMember(IsRequired =true, Order =1)]
        string FirstName { get; set; }

        [DataMember(IsRequired = true, Order = 2)]
        string LastName { get; set; }

        [DataMember(IsRequired = false, Order = 3)]
        string SecondName { get; set; }

        [DataMember(IsRequired = true, Order = 4)]
        string Email { get; set; }
    }
}