using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalWork.Application.Response
{
    public class BaseResponseModel
    {
        public Acknowledgement Ack { get; set; }
        public ValidationErrorsModel Messages { get; set; }



        public BaseResponseModel()
        {
            Messages = new ValidationErrorsModel();
        }
    }
    public enum Acknowledgement
    {
        Success, Failure, Unauthorized
    }
}

