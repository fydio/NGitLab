using System.Collections.Generic;
using NGitLab.Models;

namespace NGitLab.Impl
{
    internal class MemberClient : IMemberClient
    {
        private readonly API _api;
        private readonly int _groupId;
        private readonly string _url;

        public MemberClient(API api, int groupId)
        {
            _api = api;
            _groupId = groupId;

            _url = Namespace.Url + "/" + _groupId + "/members";
        }

        public IEnumerable<Member> Accessible
        {
            get
            {
                return _api.Get().GetAll<Member>(_url);
            }
        }

        public Member Add(MemberUpsert member)
        {
            return _api.Post().With(member).To<Member>(_url);
        }

        public Member Edit(MemberUpsert member)
        {
            return _api.Put().With(member).To<Member>(_url);
        }

        public void Delete(int userId)
        {
            _api.Delete().To<Member>(_url + "/" + userId);
        }
    }
}
