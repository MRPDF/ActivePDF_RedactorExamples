/*
 * Redacts all images in the document.
 */

namespace Sample
{
    class RedactImages
    {
        static void Example()
        {
            using (APRedactor.Redactor redact = new APRedactor.Redactor("Example.pdf", null))
            {
                redact.ImageMode = APRedactor.Redactor.ImageRedactionMode.Unconditional;
                int redactionsPerformed = redact.Redact();
                redact.Save("RedactedExample.pdf");
            }
        }
    }
}
