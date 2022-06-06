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
           //put code hurrrr
        }
    }
}
