/*
 * Redacts all images in the document.
 */

namespace Sample
{
    class RedactImages
    {
        public static void RedactImage_()
        {
            string strPath;
            strPath = System.AppDomain.CurrentDomain.BaseDirectory + "\\";

            using (APRedactor.Redactor redact = new APRedactor.Redactor(strPath + "InputFiles\\1pageWithImage.pdf", null))
            {
                redact.ImageMode = APRedactor.Redactor.ImageRedactionMode.Unconditional;
                int redactionsPerformed = redact.Redact();
                redact.Save(strPath + "OutPutFiles\\RedactedImagesOutput.pdf");
            }
        }
    }
}
