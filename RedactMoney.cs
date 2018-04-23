/*
 * Redacts all instances of US dollars found in the document using a Regular Expression.
 */

namespace Sample
{
    class RedactMoneys
    {
        public static void RedactMoney_()
        {
            string strPath;
            strPath = System.AppDomain.CurrentDomain.BaseDirectory + "\\";
            
            
            using (APRedactor.Redactor redact = new APRedactor.Redactor(strPath + "InputFiles\\fw4.pdf", null))
            {
                redact.TextMode = APRedactor.Redactor.TextRedactionMode.Regex;
                redact.RegularExpression = APRedactor.RegexPresets.USD;
                int redactionsPerformed = redact.Redact();
                redact.Save(strPath + "OutPutFiles\\RedactMoneyOutput.pdf");
            }
        }
    }
}
