using System;
using System.Collections.Generic;
using System.Linq;

namespace UsersWcfService
{
    using System.ServiceModel.Web;

    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "UsersService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select UsersService.svc or UsersService.svc.cs at the Solution Explorer and start debugging.
    public class UsersService : IUsersService
    {
        private Entities ome;

        public UsersService()
        {
            ome = new Entities();
        }

        public List<WcfUser> GetWcfUsers()
        {
            var qry = (from u in ome.Users
                select new
                {
                    u.UserId,
                    u.Name,
                    u.Address,
                    u.ContactNo
                }).ToList();

            List<WcfUser> users = new List<WcfUser>();

            qry.ToList().ForEach(rec => users.Add(new WcfUser
            {
                UserId = rec.UserId,
                Address = rec.Address,
                ContactNo = rec.ContactNo,
                Name = rec.Name
            }));

            return users;
        }
    }
}
