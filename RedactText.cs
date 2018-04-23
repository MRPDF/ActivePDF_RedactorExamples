/*
 * Redacts the text "hello, world!" (not case sensitive) wherever it is found in the document.
 */

namespace Sample
{
    class RedactText
    {
        static void Example()
        {
            using (APRedactor.Redactor redact = new APRedactor.Redactor("Example.pdf", null))
            {
                redact.LiteralText = "hello, world!";
                redact.TextMode = APRedactor.Redactor.TextRedactionMode.LiteralText;
                int redactionsPerformed = redact.Redact();
                redact.Save("RedactedExample.pdf");
            }
        }
    }
}
