using System.Runtime.Serialization;

namespace NGitLab.Models
{
    [DataContract]
    public class Member
    {
        [DataMember(Name = "id")]
        public int Id;

        [DataMember(Name = "username")]
        public string Username;

        [DataMember(Name = "name")]
        public string Name;

        [DataMember(Name = "state")]
        public string State;

        [DataMember(Name = "avatar_url")]
        public string AvatarUrl;

        [DataMember(Name = "access_level")]
        public int AccessLevel;
    }
}
