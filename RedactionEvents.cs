/*
 * Redacts all instances of "Hello, world!" (not case sensitive) in the document.
 * Logs status messages to the console as the redaction process runs.
 */

using System;
using System.Diagnostics;

namespace Sample
{
    class RedactionEvents
    {
        static void Example()
        {
            using (APRedactor.Redactor redact = new APRedactor.Redactor("Example.pdf", null))
            {
                redact.TextMode = APRedactor.Redactor.TextRedactionMode.LiteralText;
                redact.LiteralText = "Hello, world!";
                redact.PageBegin += RedactorEvent;
                redact.PageComplete += RedactorEvent;
                int redactionsPerformed = redact.Redact();
                redact.Save("RedactedExample.pdf");
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
