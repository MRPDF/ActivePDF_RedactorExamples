/*
 * Redacts the text "Hello, world!" (not case sensitive) from pages 5-10 only.
 */

using System.Diagnostics;

namespace Sample
{
    class RedactRangeOfPages
    {
        public static void RedactRangeOfPage_()
        {
            string strPath;
            strPath = System.AppDomain.CurrentDomain.BaseDirectory + "\\";

            using (APRedactor.Redactor redact = new APRedactor.Redactor(strPath + "InputFiles\\LoremIpsumSample.pdf", null))
            {
                redact.LiteralText = "Lorem";
                redact.TextMode = APRedactor.Redactor.TextRedactionMode.LiteralText;
                Debug.Assert(redact.PageTotal >= 10);
                redact.FirstPage = 5;
                redact.LastPage = 10;
                int redactionsPerformed = redact.Redact();
                redact.Save(strPath + "OutPutFiles\\RangeOfPagesOutput.pdf");
            }
        }
    }
}
