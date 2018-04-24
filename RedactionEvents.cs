/*
 * Redacts all instances of "Lorem" (not case sensitive) in the document.
 * Logs status messages to the console as the redaction process runs.
 * You would want to use something like this to confirm redactor is not crashing on a large file.
 */

using System;
using System.Diagnostics;

namespace Sample
{
    class RedactionEvents
    {
        public static void RedactionEvent_()
        {
            string strPath;
            strPath = System.AppDomain.CurrentDomain.BaseDirectory + "\\";

            using (APRedactor.Redactor redact = new APRedactor.Redactor(strPath + "InputFiles\\1page.pdf", null))
            {
                redact.TextMode = APRedactor.Redactor.TextRedactionMode.LiteralText;
                redact.LiteralText = "Lorem";
                redact.PageBegin += RedactorEvent;
                redact.PageComplete += RedactorEvent;
                int redactionsPerformed = redact.Redact();
                redact.Save(strPath + "OutPutFiles\\RedactionEventsOutput.pdf");
            }
        }

        static void RedactorEvent(object sender, APRedactor.RedactEventArgs args)
        {
            APRedactor.Redactor redact = sender as APRedactor.Redactor;
            Debug.Assert(redact != null);
            string eventType = "";
            if(args.EventType == APRedactor.RedactEventArgs.PageEventType.Start)
            {
                eventType = "Started";
            }
            else if(args.EventType == APRedactor.RedactEventArgs.PageEventType.End)
            {
                eventType = "Completed";
            }
            Console.WriteLine("{0} processing page {1} of {2}.", eventType, args.PageNumber, redact.Filename);
        }
    }
}
