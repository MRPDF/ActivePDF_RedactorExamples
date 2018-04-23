/*
 * Redacts all instances of US dollars found in the document using a Regular Expression.
 */

namespace Sample
{
    class RedactMoney
    {
        static void Example()
        {
            using (APRedactor.Redactor redact = new APRedactor.Redactor("Example.pdf", null))
            {
                redact.TextMode = APRedactor.Redactor.TextRedactionMode.Regex;
                redact.RegularExpression = APRedactor.RegexPresets.USD;
                int redactionsPerformed = redact.Redact();
                redact.Save("RedactedExample.pdf");
            }
        }
    }
}
