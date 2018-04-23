/*
 * Redacts the text "Lorem" (not case sensitive) wherever it is found in the document.
 * Replaces the removed text with a red box instead of the default black box.
 */

namespace Sample
{
    class ChangeColors
    {
        public static void ChangeColor_()
        {
            string strPath;
            strPath = System.AppDomain.CurrentDomain.BaseDirectory + "\\";

            using (APRedactor.Redactor redact = new APRedactor.Redactor(strPath + "InputFiles\\LoremIpsumSample.pdf", null))
            {
                redact.ReplacementColor = new APRedactor.Color(255, 0, 0);
                redact.LiteralText = "Lorem";
                redact.TextMode = APRedactor.Redactor.TextRedactionMode.LiteralText;
                int redactionsPerformed = redact.Redact();
                redact.Save("OutPutFiles\\OutLoremIpsumOutPutRedacted.pdf");
            }
        }
    }
}
