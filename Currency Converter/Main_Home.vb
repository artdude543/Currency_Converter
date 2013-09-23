Public Class Main_Home

    Sub Currency_Convertor()

        ' User Personsal Information (Input Value)
        Dim userForename As String
        Dim userSurname As String
        Dim userDateOfBirth As Date
        Dim userNationalInsuranceNumber As String
        Dim userHouseNumber As String
        Dim userAddress As String
        Dim userPostcode As String

        ' Currency Values
        Dim exchangePoundEuro As String
        Dim exchangeEuroPound As String
        Dim exchangePoundDollar As String
        Dim exchangeDollarPound As String

        ' Companies Commision Value
        Dim commision As String = 5

        ' Output Values
        Dim outputBasic As Single
        Dim outputCommission As Single
        Dim outputFinal As Single

    End Sub

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click

        Application.Exit()

    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click

        Application.Restart()

    End Sub

    Private Sub Main_Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
