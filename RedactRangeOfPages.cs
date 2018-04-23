/*
 * Redacts the text "Hello, world!" (not case sensitive) from pages 5-10 only.
 */

using System.Diagnostics;

namespace Sample
{
    class RedactRangeOfPages
    {
        static void Example()
        {
            using (APRedactor.Redactor redact = new APRedactor.Redactor(@"C:\Example.pdf", null))
            {
                redact.LiteralText = "Hello, world!";
                redact.TextMode = APRedactor.Redactor.TextRedactionMode.LiteralText;
                Debug.Assert(redact.PageTotal >= 10);
                redact.FirstPage = 5;
                redact.LastPage = 10;
                int redactionsPerformed = redact.Redact();
                redact.Save("RedactedExample.pdf");
            }
        }
    }
}
