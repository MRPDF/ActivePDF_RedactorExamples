/*
 * Redacts the text "hello, world!" (not case sensitive) wherever it is found in the document.
 */

namespace Sample
{
    class RedactTexts
    {
       public static void RedactText_()
        {
            string strPath;
            strPath = System.AppDomain.CurrentDomain.BaseDirectory + "\\";

            using (APRedactor.Redactor redact = new APRedactor.Redactor(strPath + "InputFiles\\5pageLoremIpsum.pdf", null))
            {

                redact.LiteralText = "Lorem";
                redact.TextMode = APRedactor.Redactor.TextRedactionMode.LiteralText;
                int redactionsPerformed = redact.Redact();
                redact.Save(strPath + "OutPutFiles\\RedactTextOutPut.pdf");
            }
        }
    }
}
