using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Seq.Apps;
using Seq.Apps.LogEvents;

namespace TwilioSeqApp
{
    [SeqApp("SmsNotifierApp",
        Description = "Uses Twilio to send events as SMS messages")]
    public class SmsNotifierApp : SeqApp
    {

        [SeqAppSetting(
           DisplayName = "Twilio account sid",
           HelpText = "Twilio account sid.")]
        public String AccountSid { get; set; }

        [SeqAppSetting(
           DisplayName = "Twilio auth token",
           HelpText = "Twilio auth token.")]
        public String AuthToken { get; set; }

        [SeqAppSetting(
          DisplayName = "Sender phone number",
          HelpText = "Sender phone number.")]
        public String SenderPhone { get; set; }

        [SeqAppSetting(
          DisplayName = "Receiver phone numbers",
          HelpText = "Receiver phone numbers separated by comma.")]
        public String ReceiverPhoneNumbers { get; set; }

        [SeqAppSetting(
          DisplayName = "Sms message",
          HelpText = "Sms message. Event Id and level will be added to this.")]
        public String SmsMessage { get; set; }

        public void On(Event<LogEventData> evt)
        {
            
            var eventData = evt.Data;
            
            

        }

        private string FormatSmsMessageString(string msg, LogEventData data)
        {
            //TODO: Figure out how to get the "name" property from LogEventData
            var smsMessage = $"{msg}. ID : {data.Id}, level: {data.Level.ToString()}. ";

            return smsMessage;
        }

    }
}
