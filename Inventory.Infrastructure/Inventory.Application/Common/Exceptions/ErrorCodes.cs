using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalWork.Application.Common.Exceptions
{
    public class ErrorCodes
    {
        public static string EmailNotValid = "Email address is not valid";
        public static string EmailAlreadyExists = "Email address already exists";
        public static string PasswordsNotMatch = "Passwords don't match";
        public static string IncorrectCredentials = "Email or password is incorrect";
        public static string UserNotExists = "User don't exist";
        public static string FolderNotExists = "Folder with provided id not exists";
        public static string Forbidden = "You don't have access to this resource";
        public static string InvalidPhoneNumber = "Phone number is invalid";



        public static string VaultNotExists = "Vault don't exist";
        public static string VaultIsBlocked = "Vault is blocked, please try again later";
        public static string InvalidParameters = "Invalid Parameters";
        public static string VaultAlreadyExists = "Vault with this name already exists";
        public static string InvalidBase64 = "Invalid Base64 was provided";



        public static string FolderNotFound = "Folder not found";



        public static string AmazonProfileNotExists = "Amazon Profile don't exist";
        public static string AmazonKeywordNotExists = "Amazon Keyword don't exist";
        public static string AmazonAdGroupNotExists = "Amazon AdGroup don't exist";
        public static string AmazonCampaignNotExists = "Amazon Campaign don't exist";
        public static string AmazonReportNotExists = "Amazon Report don't exist";
        public static string AmazonProductAdNotExists = "Amazon Product Ad don't exist";
        public static string AmazonTargetNotExists = "Amazon Target don't exist";
        public static string InvalidDateRange = "Invalid Day Range (Amazon Max Limit Past 60 Days)";



        public static string CategoryNotExists = "Caregoy don't exist";
        public static string InternalServerError = "Something went wrong, please try again later";
        public static string FileNotUploaded = "File not uploaded";
        public static string InvalidFilter = "Invalid filter";
    }
}
