using System.Runtime.Serialization;

namespace NGitLab.Models
{
    [DataContract]
    public class MemberUpsert
    {
        [DataMember(Name = "id")]
        public int Id;

        [DataMember(Name = "user_id")]
        public int UserId;

        [DataMember(Name = "access_level")]
        public int AccessLevel;
    }
}
