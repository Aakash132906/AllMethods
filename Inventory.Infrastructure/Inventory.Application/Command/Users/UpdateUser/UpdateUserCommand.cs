using MediatR;
using PersonalWork.Domain.DBModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalWork.Application.Command.Users.UpdateUser
{
    public class UpdateUserCommand :   IRequest <User>
    {
        public int Id { get; set; }

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public string UserName { get; set; } = null!;

        public string EmailId { get; set; } = null!;

        public string Passwd { get; set; } = null!;

        public string PhoneNo { get; set; } = null!;

        public string UserToken { get; set; } = null!;

        public string? AccessToken { get; set; }

        public DateTime? TokenGeneratedOn { get; set; }

        public DateTime? TokenExpiredOn { get; set; }

        public decimal? MarkupPercent { get; set; }

        public decimal? MarkupAmount { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public bool IsActive { get; set; }

        public int RoleId { get; set; }
    }
}
