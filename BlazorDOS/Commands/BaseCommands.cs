using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace BlazorDOS.Commands
{
    public class BaseCommands
    {
        public string CommandInput { get; set; }
        public string textMessage { get; set; }

        public string ExecuteInput(string CommandInput)
        {
            string componentTag;
            switch(CommandInput)
               { 
                  case "help":
                    {
                        componentTag = "< HelpComponent ></ HelpComponent >";
                        
                    }
                    break;
                    default:
                    {
                        componentTag = "";
                    }
                    break;
               }
            return componentTag;
        }

        public void TextMsg(string textMessage)
        {
            // Find your Account Sid and Token at twilio.com/console
            // and set the environment variables. See http://twil.io/secure
            string accountSid = "ACa6c79dc7bf6ddbb56132219f24f3346b";
            string authToken = "49d494df7513bebac55ac9d0842d0c97";

            TwilioClient.Init(accountSid, authToken);

            var message = MessageResource.Create(
                body: textMessage,
                from: new Twilio.Types.PhoneNumber("+6178307112"),
                to: new Twilio.Types.PhoneNumber("+6142149306")
            );
        }
    }
}
