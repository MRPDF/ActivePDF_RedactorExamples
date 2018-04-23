/*
 * Removes all text from the entire document, and draws a black box on each page.
 */

namespace Sample
{
    class RedactEntirePage
    {
        static void Example()
        {
            using (APRedactor.Redactor redact = new APRedactor.Redactor("Example.pdf", null))
            {
                redact.TextMode = APRedactor.Redactor.TextRedactionMode.Unconditional;
                int redactionsPerformed = redact.Redact();
                redact.Save("RedactedExample.pdf");
            }
        }
    }
}
