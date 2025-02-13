using System;
using System.Runtime.Serialization;

namespace UserService
{
    [DataContract] 
    public class UserDto
    {
        [DataMember] public int Id { get; set; }
        [DataMember] public string FullName { get; set; }
        [DataMember] public string IdentificationNumber { get; set; }
        [DataMember] public string Email { get; set; }
        [DataMember] public string Phone { get; set; }
        [DataMember] public DateTime CreatedAt { get; set; }
        [DataMember] public DateTime? UpdatedAt { get; set; }
    }
}
