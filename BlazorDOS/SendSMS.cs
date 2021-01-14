using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace BlazorDOS
{
    public class SendSMS
    {
        public string textMessage { get; set; }

        public void TextMsg(string textMessage)
        {
            // Find your Account Sid and Token at twilio.com/console
            // and set the environment variables. See http://twil.io/secure
            string accountSid = System.Environment.GetEnvironmentVariable("TWILIO_ACCOUNT_SID");
            string authToken = System.Environment.GetEnvironmentVariable("TWILIO_AUTH_TOKEN");
            string twilioNumber = System.Environment.GetEnvironmentVariable("TWILIO_NUMBER");
            string fryNumber = System.Environment.GetEnvironmentVariable("FRY_CELL_NUMBER");
            TwilioClient.Init(accountSid, authToken);

            var message = MessageResource.Create(
                body: textMessage,
                from: new Twilio.Types.PhoneNumber(twilioNumber),
                to: new Twilio.Types.PhoneNumber(fryNumber)
            );
        }
    }
}
