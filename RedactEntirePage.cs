/*
 * Removes all text from the entire document, and draws a black box on each page.
 */

namespace Sample
{
    class RedactEntirePages
    {
        public static void RedactEntirePage_()
        {
            string strPath;
            strPath = System.AppDomain.CurrentDomain.BaseDirectory + "\\";

            using (APRedactor.Redactor redact = new APRedactor.Redactor(strPath + "InputFiles\\1page.pdf", null))
            {
                redact.TextMode = APRedactor.Redactor.TextRedactionMode.Unconditional;
                int redactionsPerformed = redact.Redact();
                redact.Save(strPath + "OutPutFiles\\RedactedEntirePageOutput.pdf");
            }
        }
    }
}
