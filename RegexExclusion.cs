/*
 * Uses a regular expression to find and redact phone numbers in the document, 
 * but excludes the number "(555) 555-5555" whenever it is found, leaving it unredacted.
 */

namespace Sample
{
    class RegexExclusion
    {
        static void Example()
        {
            using (APRedactor.Redactor redact = new APRedactor.Redactor(@"C:\Example.pdf", null))
            {
                redact.TextMode = APRedactor.Redactor.TextRedactionMode.Regex;
                redact.RegularExpression = APRedactor.RegexPresets.PhoneNumber;
                redact.RegexExclusionList = new string[] { "(555) 555-5555" };
                int redactionsPerformed = redact.Redact();
                redact.Save("RedactedExample.pdf");
            }
        }
    }
}
