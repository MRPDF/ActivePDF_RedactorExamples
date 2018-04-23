/*
 * Redacts the text "hello, world!" (not case sensitive) wherever it is found in the document.
 * Also uses the bitwise-or operator to combine many different options for how the document
 * should be saved before saving it, resulting in a compressed, optimized, fast-web-view enabled file.
 */

namespace Sample
{
    class SaveOptions
    {
        static void Example()
        {
            using (APRedactor.Redactor redact = new APRedactor.Redactor("Example.pdf", null))
            {
                APRedactor.Redactor.SaveOptions options =
                    APRedactor.Redactor.SaveOptions.CleanContentStreams |
                    APRedactor.Redactor.SaveOptions.CompressFonts |
                    APRedactor.Redactor.SaveOptions.CompressImages |
                    APRedactor.Redactor.SaveOptions.CompressStreams |
                    APRedactor.Redactor.SaveOptions.GarbageCollectDeDuplicate |
                    APRedactor.Redactor.SaveOptions.Linearize |
                    APRedactor.Redactor.SaveOptions.SanitizeContentStreams;

                redact.LiteralText = "Hello, world!";
                redact.TextMode = APRedactor.Redactor.TextRedactionMode.LiteralText;
                int redactionsPerformed = redact.Redact();
                redact.Save("RedactedExample.pdf", options);
            }
        }
    }
}
