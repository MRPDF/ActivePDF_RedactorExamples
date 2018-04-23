/*
 * Redacts both text and images that are contained the middle third of each page.
 * Because each page of a document can be a different size, it is necessary to 
 * fetch the size of a page, and perform the redaction operation, one page at a time.
 */

namespace Sample
{
    class RedactByRegions
    {
        static void RedactByRegion()
        {
            using (APRedactor.Redactor redact = new APRedactor.Redactor("Example.pdf", null))
            {
                redact.TextMode = APRedactor.Redactor.TextRedactionMode.Region;
                redact.ImageMode = APRedactor.Redactor.ImageRedactionMode.Region;

                for(int pageNumber = 1; pageNumber <= redact.PageTotal; pageNumber++)
                {
                    redact.FirstPage = pageNumber;
                    redact.LastPage = pageNumber;
                    float pageWidth, pageHeight;
                    redact.GetPageSize(pageNumber, out pageWidth, out pageHeight);
                    APRedactor.RedactRegion[] regions = new APRedactor.RedactRegion[] 
                    {
                        new APRedactor.RedactRegion(pageNumber, 
                            new APRedactor.Rectangle(pageWidth / 3, pageHeight / 3, pageWidth / 3, pageHeight / 3, 
                                APRedactor.Rectangle.CoordinateFrame.TopDown))
                    };
                    redact.TextRegions = regions;
                    redact.ImageRegions = regions;
                    int redactionsPerformed = redact.Redact();
                }

                redact.Save("RedactedExample.pdf");
            }
        }
    }
}
