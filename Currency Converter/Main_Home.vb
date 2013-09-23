Public Class Main_Home

    Public Sub Currency_Convertor()

        ' User Personsal Information (Input Value)
        Dim userForename As String
        Dim userSurname As String
        Dim userDateOfBirth As Date
        Dim userNationalInsuranceNumber As String
        Dim userHouseNumber As String
        Dim userAddress As String
        Dim userPostcode As String

        ' Booleans
        Dim denominations As Boolean

        ' Setting Variables
        userForename = txtuserFirstName.Text
        userSurname = txtuserSurname.Text
        userDateOfBirth = dtpDOB.Text
        userNationalInsuranceNumber = txtNIN.Text
        userHouseNumber = txtHouseNumber.Text
        userAddress = txtStreetName.Text + txtTownCity.Text
        userPostcode = txtPostcode.Text

    End Sub

    Public Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click

        ' Currency Variable
        Dim exchangePoundEuro As Single = "1.19"
        Dim exchangeEuroPound As Single = "0.84"
        Dim exchangePoundDollar As Single = "1.6"
        Dim exchangeDollarPound As Single = "0.62"

        ' Companies Commision Value
        Dim commision As String = 5
        Dim sum As String

        ' Input Variables For Conversion
        Dim inputAmount As Single

        ' Output Values
        Dim outputBasic As Single
        Dim outputCommission As Single
        Dim outputLoss As Single

        ' Set Variables

        If txtInputAmount.Text = "" Then
            MsgBox("Please enter a value to contine!")
        Else
            inputAmount = txtInputAmount.Text
        End If

        ' Perform the calculations / Set Outputs
        If rbPoundEuro.Checked = True Then

            outputBasic = inputAmount * exchangePoundEuro
            sum = inputAmount / 100 * commision
            outputCommission = inputAmount * exchangePoundEuro - sum

            outputLoss = sum
            txtLoss.Text = Format("£" & outputLoss)

        ElseIf rbEuroPound.Checked Then

            outputBasic = inputAmount * exchangeEuroPound
            sum = inputAmount / 100 * commision
            outputCommission = inputAmount * exchangeEuroPound - sum

            outputLoss = sum
            txtLoss.Text = Format("€" & outputLoss)

        ElseIf rbPoundDollar.Checked Then

            outputBasic = inputAmount * exchangePoundDollar
            sum = inputAmount / 100 * commision
            outputCommission = inputAmount * exchangePoundDollar - sum

            outputLoss = sum
            txtLoss.Text = Format("£" & outputLoss)

        ElseIf rbDollarPound.Checked Then

            outputBasic = inputAmount * exchangeDollarPound
            sum = inputAmount / 100 * commision
            outputCommission = inputAmount * exchangeDollarPound - sum

            outputLoss = sum
            txtLoss.Text = Format("$" & outputLoss)

        End If

        ' Set Outputs
        txtOuputBeforeCommission.Text = outputBasic
        txtOutputAfterCommission.Text = outputCommission

    End Sub

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click

        Application.Exit()

    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click

        Application.Restart()

    End Sub

End Class
