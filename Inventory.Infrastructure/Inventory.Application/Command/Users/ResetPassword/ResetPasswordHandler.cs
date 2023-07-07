using AutoMapper;
using MediatR;
using PersonalWork.Application.Abstractions.Repositories;
using PersonalWork.Application.Common.Exceptions;
using PersonalWork.Domain.DBModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace PersonalWork.Application.Command.Users.ResetPassword
{
    public class ResetPasswordHandler : IRequestHandler<ResetPasswordCommand>
    {
        public IUnitOfWork UnitOfWork;
        public IMapper mapper;
        public IEmailService _emailService;
        public ResetPasswordHandler(IUnitOfWork UnitOfWork, IMapper mapper)
        {
            this.UnitOfWork = UnitOfWork;
            this.mapper = mapper;
        }
        public async Task<Unit> Handle(ResetPasswordCommand request, CancellationToken cancellationToken)
        {
            var user = await UnitOfWork.GetReposiotory<User>().GetByAsync(x => x.EmailId == request.EmailId);

            if (user != null)
            {
                throw new BadRequestException(ErrorCodes.UserNotExists);
            }
            else
            {
                string otp = GenerateOTP();

                SaveOTPInDatabase(user.EmailId, otp);

                SendOTPViaEmail(user.EmailId, otp, user.UserName);

            }

            return Unit.Value;
        }
        public string  GenerateOTP()
        {
            Random random = new Random();
            int otpNumber = random.Next(100000, 999999);
            return otpNumber.ToString();
        }
       public void SaveOTPInDatabase(string EmailId, string otp)
        {

        }
        public async void SendOTPViaEmail(string EmailId,string otp,string UserName)
        {
            EmailMessage passwordResetEmail = new EmailMessage();
            passwordResetEmail.ToName = UserName;
            passwordResetEmail.ToAddress = EmailId;
            passwordResetEmail.Subject = "Password Reset OTP";
            passwordResetEmail.HtmlBody = "This Is Your OTP." + otp;
            passwordResetEmail.TextBody = "This Is Your OTP." + otp;
            await _emailService.SendEmailAsync(passwordResetEmail);
        }
        public interface IEmailService
        {
            Task SendEmailAsync(EmailMessage emailMessage);
        }
        public class EmailMessage
        {
            public string ToName { get; set; }
            public string ToAddress { get; set; }
            public string Subject { get; set; }
            public string HtmlBody { get; set; }
            public string TextBody { get; set; }
        }
    }
}
