Public Class frmMain

    Private Sub btnDisplayAccountSummary_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplayAccountSummary.Click

        Dim sr As IO.StreamReader = IO.File.OpenText("..\..\data.txt")
        Dim acctNum As String
        Dim pastDueNum As Double
        Dim paymentNum As Double
        Dim purchasesNum As Double
        Dim currentNum As Double
        Dim dblFinCharg As Double
        Dim fmtStr As String = "{0,-10}{1,8}{2,11}{3,12}{4,10}{5,13}"

        'Read Each Record from File
        acctNum = sr.ReadLine
        pastDueNum = sr.ReadLine
        paymentNum = sr.ReadLine
        purchasesNum = sr.ReadLine

        'Calculate
        dblFinCharg = (pastDueNum - paymentNum) * 0.015
        currentNum = pastDueNum - paymentNum + purchasesNum + dblFinCharg

        'Print Heading in Listbox
        lstAccountSummary.Items.Add(String.Format(fmtStr, "Account", "Past Due", "", "", "Finance", "Current"))
        lstAccountSummary.Items.Add(String.Format(fmtStr, "Number", "Amount", "Payments", " Purchases", "Charges", "Amt Due"))

        'Output results in zones
        lstAccountSummary.Items.Add(String.Format(fmtStr, acctNum, FormatCurrency(pastDueNum), FormatCurrency(paymentNum), FormatCurrency(purchasesNum), FormatCurrency(dblFinCharg), FormatCurrency(currentNum)))

        'Read Each Record from File
        acctNum = sr.ReadLine
        pastDueNum = sr.ReadLine
        paymentNum = sr.ReadLine
        purchasesNum = sr.ReadLine

        'Calculate
        dblFinCharg = (pastDueNum - paymentNum) * 0.015
        currentNum = pastDueNum - paymentNum + purchasesNum + dblFinCharg

        'Output results in zones
        lstAccountSummary.Items.Add(String.Format(fmtStr, acctNum, FormatCurrency(pastDueNum), FormatCurrency(paymentNum), FormatCurrency(purchasesNum), FormatCurrency(dblFinCharg), FormatCurrency(currentNum)))



    End Sub
End Class
