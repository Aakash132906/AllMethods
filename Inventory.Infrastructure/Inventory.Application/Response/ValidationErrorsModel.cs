using Microsoft.AspNetCore.Mvc.ModelBinding;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalWork.Application.Response
{
    public class ValidationErrorsModel
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> Errors { get; set; }



        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> Warnings { get; set; }



        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> Info { get; set; }



        public ValidationErrorsModel()
        {
            Errors = new List<string>();
            Warnings = new List<string>();
            Info = new List<string>();
        }
        public ValidationErrorsModel(IEnumerable<string> errors)
        {
            this.Errors = errors;
        }



        public static ValidationErrorsModel FromModelState(ModelStateDictionary modelState)
        {
            List<string> errors = new List<string>();
            foreach (var entry in modelState)
            {
                if (entry.Value.Errors != null)
                {
                    foreach (var error in entry.Value.Errors)
                    {
                        if (error.Exception != null)
                        {
                            errors.Add("Failed to parse property: " + entry.Key);
                        }
                        else if (!string.IsNullOrWhiteSpace(error.ErrorMessage))
                        {
                            errors.Add(error.ErrorMessage);
                        }
                    }
                }



            }
            return new ValidationErrorsModel { Errors = errors };
        }



        public static ValidationErrorsModel FromErrorString(string errorMessage)
        {
            return new ValidationErrorsModel
            {
                Errors = new string[] { errorMessage }
            };
        }
    }
}
