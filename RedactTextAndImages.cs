/*
 * Removes all text and images from the document.
 */

namespace Sample
{
    class RedactTextAndImages
    {
        public static void RedactTextAndImage_()
        {
            string strPath;
            strPath = System.AppDomain.CurrentDomain.BaseDirectory + "\\";

            using (APRedactor.Redactor redact = new APRedactor.Redactor(strPath + "InputFiles\\1pageWithImage.pdf", null))
            {
                redact.TextMode = APRedactor.Redactor.TextRedactionMode.Unconditional;
                redact.ImageMode = APRedactor.Redactor.ImageRedactionMode.Unconditional;
                int redactionsPerformed = redact.Redact();
                redact.Save(strPath + "OutPutFiles\\RedactTextandImagesOutput.pdf");
            }
        }
    }
}
