using System;
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
            string accountSid = "ACa6c79dc7bf6ddbb56132219f24f3346b";
            string authToken = "49d494df7513bebac55ac9d0842d0c97";
            string drewNumber = "13308012990";
            string fryNumber = "16142149306";
            TwilioClient.Init(accountSid, authToken);

            var message = MessageResource.Create(
                body: textMessage,
                from: new Twilio.Types.PhoneNumber("+16178307112"),
                to: new Twilio.Types.PhoneNumber(drewNumber)
            );
        }
    }
}
