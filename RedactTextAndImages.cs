/*
 * Removes all text and images from the document.
 */

namespace Sample
{
    class RedactTextAndImages
    {
        static void Example()
        {
            using (APRedactor.Redactor redact = new APRedactor.Redactor("Example.pdf", null))
            {
                redact.TextMode = APRedactor.Redactor.TextRedactionMode.Unconditional;
                redact.ImageMode = APRedactor.Redactor.ImageRedactionMode.Unconditional;
                int redactionsPerformed = redact.Redact();
                redact.Save("RedactedExample.pdf");
            }
        }
    }
}
