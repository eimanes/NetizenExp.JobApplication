using Microsoft.AspNetCore.Mvc;

namespace NetizenExp.JobApplication.Api.controllers
{
    public static class Credential
    {
        public const string EMAIL = "eimansalleh.5@gmail.com";
    }

    public static class Message
    {
        public const string EMAIL_NULL = "Email parameter is required.";
        public const string EMAIL_FALSE = "Invalid email. Please provide the same email as the one used in your job application.";
        public const string EMAIL_TRUE = "Further instructions will be sent to your email.";
    }

    public class EmailResponse
    {
        public bool Success { get; set; }
        public string Message { get; set; }
    }

    [ApiController]
    [Route("api/checkEmail")]
    public class Controller : ControllerBase
    {
        [HttpGet]
        public IActionResult Get([FromQuery] string email)
        {
            // Validate the email parameter
            if (string.IsNullOrEmpty(email))
            {
                var response = new EmailResponse
                {
                    Success = false,
                    Message = Message.EMAIL_NULL
                };
                return BadRequest(response);
            }

            // Check if the email matches the one used in the job application
            if (email != Credential.EMAIL)
            {
                var response = new EmailResponse
                {
                    Success = false,
                    Message = Message.EMAIL_FALSE
                };
                return BadRequest(response);
            }

            var finalResponse = new EmailResponse
            {
                Success = true,
                Message = Message.EMAIL_TRUE
            };

            return Ok(finalResponse);
        }
    }
}
