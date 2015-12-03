using System.Collections.Generic;

namespace NGitLab.Models
{
    public interface IMemberClient
    {
        IEnumerable<Member> Accessible { get; }

//        Member this[int id] { get; }

        Member Add(MemberUpsert member);
        Member Edit(MemberUpsert member);
        void Delete(int userId);
    }
}
