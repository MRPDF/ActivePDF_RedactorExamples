/*
 * Uses a regular expression to find and redact phone numbers in the document, 
 * but excludes the number "(555) 555-5555" whenever it is found, leaving it unredacted.
 */

namespace Sample
{
    class RegexExclusions
    {
        public static void RegexExclusion_()
        {
            string strPath;
            strPath = System.AppDomain.CurrentDomain.BaseDirectory + "\\";

            using (APRedactor.Redactor redact = new APRedactor.Redactor(strPath + "InputFiles//PhoneNumberPDF.pdf", null))
            {
                redact.TextMode = APRedactor.Redactor.TextRedactionMode.Regex;
                redact.RegularExpression = APRedactor.RegexPresets.PhoneNumber;
                redact.RegexExclusionList = new string[] { "(555) 555-5555" };
                int redactionsPerformed = redact.Redact();
                redact.Save(strPath + "OutPutFiles\\RegexExclusionOutput.pdf");
            }
        }
    }
}
