#Region "DISCLAIMER"
' Copyright (c) 2014 NAB, LLC. - All Rights Reserved.
' *
' * This software and documentation is subject to and made
' * available only pursuant to the terms of an executed license
' * agreement, and may be used only in accordance with the terms
' * of said agreement. This software may not, in whole or in part,
' * be copied, photocopied, reproduced, translated, or reduced to
' * any electronic medium or machine-readable form without
' * prior consent, in writing, from NAB, LLC.
' *
' * Use, duplication or disclosure by the U.S. Government is subject
' * to restrictions set forth in an executed license agreement
' * and in subparagraph (c)(1) of the Commercial Computer
' * Software-Restricted Rights Clause at FAR 52.227-19; subparagraph
' * (c)(1)(ii) of the Rights in Technical Data and Computer Software
' * clause at DFARS 252.227-7013, subparagraph (d) of the Commercial
' * Computer Software--Licensing clause at NASA FAR supplement
' * 16-52.227-86; or their equivalent.
' *
' * Information in this software is subject to change without notice
' * and does not represent a commitment on the part of NAB.
' * 
' * Sample Code is for reference Only and is intended to be used for educational purposes. It's the responsibility of 
' * the software company to properly integrate into thier solution code that best meets thier production needs. 
'

#End Region

Imports System.Configuration
Imports System.Windows.Forms
Imports SampleCode_Desktop.schemas.ipcommerce.com.Ipc.General.WCF.Contracts.Common.External.SvcInfo

Namespace SampleCode
    Partial Public Class ManageApplicationData
        Inherits Form
        Private _ApplicationLocation As ApplicationLocation
        Private _HardwareType As HardwareType
        Private _PINCapability As PINCapability
        Private _ReadCapability As ReadCapability
	Private _EncryptionType As EncryptionType
        Private _Helper As New HelperMethods()
        Private _FaultHandler As New FaultHandler.FaultHandler()
        Public SaveSuccess As Boolean

        Public Sub New()
            InitializeComponent()

            'Populate drop downs with enumerated values
            cboApplicationAttended.Items.Add(True)
            cboApplicationAttended.Items.Add(False)

			cboApplicationLocation.Sorted = True
			cboApplicationLocation.DataSource = [Enum].GetValues(GetType(ApplicationLocation))
			cboApplicationLocation.SelectedItem = ApplicationLocation.NotSet

			CboEncryptionType.Sorted = True
			CboEncryptionType.DataSource = [Enum].GetValues(GetType(EncryptionType))
			CboEncryptionType.SelectedItem = EncryptionType.NotSet

            cboHardwareType.Sorted = True
            cboHardwareType.DataSource = [Enum].GetValues(GetType(HardwareType))
            cboHardwareType.SelectedItem = HardwareType.NotSet

            cboPINCapability.Sorted = True
            cboPINCapability.DataSource = [Enum].GetValues(GetType(PINCapability))
            cboPINCapability.SelectedItem = PINCapability.NotSet

            cboReadCapability.Sorted = True
            cboReadCapability.DataSource = [Enum].GetValues(GetType(ReadCapability))
            cboReadCapability.SelectedItem = ReadCapability.NotSet
        End Sub

        Public Sub CallingForm(ByVal helper As HelperMethods)
            _Helper = helper
        End Sub

        Private Sub ManageApplicationData_Load(ByVal sender As Object, ByVal e As EventArgs)
            GetApplicationData()
        End Sub

        Private Sub GetApplicationData()
            'Set Values from the calling form
            txtPTLSSocketId.Text = DirectCast(Owner, SampleCode_DeskTop).PtlsSocketId

            If _Helper.ApplicationProfileId.Length < 1 Then
                Return
            End If
            txtApplicationProfileId.Text = _Helper.ApplicationProfileId.Trim()

            'Call GetApplicationData if a previous applicationProfileId exists
            Dim AD As New ApplicationData()
            'From the calling form
            Dim _strSessionToken As String = DirectCast(Owner, SampleCode_DeskTop).Helper.SessionToken
            Try
                DirectCast(Owner, SampleCode_DeskTop).Helper.CheckTokenExpire()
                AD = DirectCast(Owner, SampleCode_DeskTop).Helper.Cwssic.GetApplicationData(_strSessionToken, txtApplicationProfileId.Text)
            Catch
                MessageBox.Show("Unable to pull application data for persisted ApplicationProfileId in the file '[SK]_applicationProfileId.config'")
                txtApplicationProfileId.Text = ""
                Return
            End Try

			'If an ApplicationData was returned set all of the values.
			cboApplicationAttended.SelectedItem = AD.ApplicationAttended
			'Select the index that matches
			If AD.ApplicationAttended Or Not AD.ApplicationAttended Then
				cboApplicationAttended.SelectedItem = AD.ApplicationAttended
			End If
			'Select the index that matches
			If AD.ApplicationLocation.ToString().Length > 0 Then
				cboApplicationLocation.SelectedItem = AD.ApplicationLocation
			End If
			txtApplicationName.Text = AD.ApplicationName
			txtDeveloperId.Text = AD.DeveloperId
			TxtDeviceSerialNumber.Text = AD.DeviceSerialNumber
			'Select the index that matches
			If AD.EncryptionType.ToString().Length > 0 Then
				CboEncryptionType.SelectedItem = AD.EncryptionType
			End If
			'Select the index that matches
			If AD.HardwareType.ToString().Length > 0 Then
				cboHardwareType.SelectedItem = AD.HardwareType
			End If
			'Select the index that matches
			If AD.PINCapability.ToString().Length > 0 Then
				cboPINCapability.SelectedItem = AD.PINCapability
			End If
			txtPTLSSocketId.Text = AD.PTLSSocketId
			'Select the index that matches
			If AD.ReadCapability.ToString().Length > 0 Then
				cboReadCapability.SelectedItem = AD.ReadCapability
			End If
			txtSerialNumber.Text = AD.SerialNumber
			txtSoftwareVersion.Text = AD.SoftwareVersion
			txtSoftwareVersionDate.Text = AD.SoftwareVersionDate.ToString()
			txtVendorId.Text = AD.VendorId
		End Sub

        Private Sub cmdSave_Click(ByVal sender As Object, ByVal e As EventArgs)
            If txtApplicationProfileId.Text.Length > 0 Then
                Dim Result As DialogResult
                Result = MessageBox.Show("The following will attempt to overwrite an existing ApplicationProfileId. Do you want to continue?", "Overwrite", MessageBoxButtons.OKCancel)
                If Result = DialogResult.Cancel Then
                    Return
                End If
            End If

            If Not checkRequiredValues() Then
                MessageBox.Show("You are missing required values")
                Return
            End If

            Try
                Dim AD As New ApplicationData()

                'From the calling form
                DirectCast(Owner, SampleCode_DeskTop).Helper.CheckTokenExpire()
                Dim _strSessionToken As String = DirectCast(Owner, SampleCode_DeskTop).Helper.SessionToken

				AD.ApplicationAttended = Convert.ToBoolean(cboApplicationAttended.SelectedItem)
				AD.ApplicationLocation = _ApplicationLocation
				AD.ApplicationName = txtApplicationName.Text
				AD.DeveloperId = txtDeveloperId.Text
				AD.DeviceSerialNumber = TxtDeviceSerialNumber.Text
				AD.EncryptionType = _EncryptionType
				AD.HardwareType = _HardwareType
				AD.PINCapability = _PINCapability
				AD.PTLSSocketId = txtPTLSSocketId.Text.Trim()
				'Always remove beginning and end spaces as well as CrLF 
				AD.ReadCapability = _ReadCapability
				AD.SerialNumber = txtSerialNumber.Text
				AD.SoftwareVersion = txtSoftwareVersion.Text
				'ToDo probably need a better way
				AD.SoftwareVersionDate = Convert.ToDateTime(txtSoftwareVersionDate.Text).ToUniversalTime()
				AD.VendorId = txtVendorId.Text

                Dim strApplicationProfileId As String = DirectCast(Owner, SampleCode_DeskTop).Helper.Cwssic.SaveApplicationData(_strSessionToken, AD)
                txtApplicationProfileId.Text = strApplicationProfileId
                DirectCast(Owner, SampleCode_DeskTop).Helper.ApplicationProfileId = strApplicationProfileId.Trim()
                MessageBox.Show("ApplicationData successfully saved. Your application should persist and cache the ApplicationProfileId returned. " & "This ApplicationProfileID will be used for all subsequent transaction processing. " & vbCr & vbLf & vbCr & vbLf & "For now, the values have been saved in a text file, which is located" & " in the same folder as the executing application '[SK]_applicationProfileId.config'")
                SaveSuccess = True
                Me.Close()
            Catch ex As Exception
                Dim strErrorId As String
                Dim strErrorMessage As String
                If _FaultHandler.handleSvcInfoFault(ex, strErrorId, strErrorMessage) Then
                    MessageBox.Show(strErrorId & " : " & strErrorMessage)
                Else
                    MessageBox.Show(ex.Message)
                End If
            End Try
        End Sub

        Private Sub cmdDelete_Click(ByVal sender As Object, ByVal e As EventArgs)
            If txtApplicationProfileId.Text.Length < 1 Then
                MessageBox.Show("Please enter a valid ApplicationProfileId in order to delete the ApplicationData")
                Return
            End If

            'From the calling form
            DirectCast(Owner, SampleCode_DeskTop).Helper.CheckTokenExpire()
            Dim _strSessionToken As String = DirectCast(Owner, SampleCode_DeskTop).Helper.SessionToken
            Try
                DirectCast(Owner, SampleCode_DeskTop).Helper.Cwssic.DeleteApplicationData(_strSessionToken, txtApplicationProfileId.Text)
                MessageBox.Show("Successfully deleted " + txtApplicationProfileId.Text)
                Close()
            Catch ex As Exception
                Dim strErrorId As String
                Dim strErrorMessage As String
                If _FaultHandler.handleSvcInfoFault(ex, strErrorId, strErrorMessage) Then
                    MessageBox.Show(strErrorId & " : " & strErrorMessage)
                Else
                    MessageBox.Show(ex.Message)
                End If
            End Try
        End Sub

        Private Function checkRequiredValues() As Boolean
            Try
                Convert.ToBoolean(cboApplicationAttended.SelectedItem)
            Catch
                Return False
            End Try
            If _ApplicationLocation.ToString() = "NotSet" Then
                Return False
            End If
            If txtApplicationName.Text.Length = 0 Then
                Return False
            End If
            'if(txtDeveloperId.Text.Length == 0)return false; //CONDITIONAL SO NO CHECK
            If _HardwareType.ToString() = "NotSet" Then
                Return False
            End If
            If _PINCapability.ToString() = "NotSet" Then
                Return False
            End If
            If txtPTLSSocketId.Text.Length = 0 Then
                Return False
            End If
            If _ReadCapability.ToString() = "NotSet" Then
                Return False
            End If
            If txtSerialNumber.Text.Length = 0 Then
                Return False
            End If
            If txtSoftwareVersion.Text.Length = 0 Then
                Return False
            End If
            Try
                Convert.ToDateTime(txtSoftwareVersionDate.Text).ToUniversalTime()
            Catch
                Return False
            End Try
            'if (txtVendorId.Text.Length == 0) return false; //CONDITIONAL SO NO CHECK

            Return True
        End Function

#Region "Combo Form Events"

        Private Sub cboApplicationLocation_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            _ApplicationLocation = DirectCast(cboApplicationLocation.SelectedItem, ApplicationLocation)
        End Sub

        Private Sub cboHardwareType_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            _HardwareType = DirectCast(cboHardwareType.SelectedItem, HardwareType)
        End Sub
	Private Sub CboEncryptionType_SelectedIndexChanged(sender As Object, e As EventArgs)
			_EncryptionType = DirectCast(CboEncryptionType.SelectedItem, EncryptionType)
		End Sub

        Private Sub cboPINCapability_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            _PINCapability = DirectCast(cboPINCapability.SelectedItem, PINCapability)
        End Sub

        Private Sub cboReadCapability_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            _ReadCapability = DirectCast(cboReadCapability.SelectedItem, ReadCapability)
        End Sub

#End Region

        Private Sub cmdClose_Click(ByVal sender As Object, ByVal e As EventArgs)
            Close()
        End Sub

        Private Sub cmdPopulateTestValues_Click(ByVal sender As Object, ByVal e As EventArgs)
            MessageBox.Show("Please note that the following values are generic. Depending on the scope of your integration the following values may change. Please contact your solution consultant with any questions.")
            txtPTLSSocketId.Text = DirectCast(Owner, SampleCode_DeskTop).PtlsSocketId
            Try
                cboApplicationAttended.SelectedItem = Convert.ToBoolean(ConfigurationSettings.AppSettings("ApplicationAttended"))
            Catch
            End Try
            Try
                cboApplicationLocation.SelectedItem = DirectCast([Enum].Parse(GetType(ApplicationLocation), ConfigurationSettings.AppSettings("ApplicationLocation")), ApplicationLocation)
            Catch
            End Try
            txtApplicationName.Text = "MyTestApp"
            '
            txtDeveloperId.Text = "TPP123"
            'Only used for First Data
	TxtDeviceSerialNumber.Text = ""
			cboHardwareType.SelectedItem = HardwareType.PC
			Try
				CboEncryptionType.SelectedItem = DirectCast([Enum].Parse(GetType(EncryptionType), ConfigurationSettings.AppSettings("EncryptionType")), EncryptionType)
			Catch
			End Try
            cboHardwareType.SelectedItem = HardwareType.PC
            Try
                cboPINCapability.SelectedItem = DirectCast([Enum].Parse(GetType(PINCapability), ConfigurationSettings.AppSettings("PINCapability")), PINCapability)
            Catch
            End Try
            Try
                cboReadCapability.SelectedItem = DirectCast([Enum].Parse(GetType(ReadCapability), ConfigurationSettings.AppSettings("ReadCapability")), ReadCapability)
            Catch
            End Try
            txtSerialNumber.Text = "208093707"
            txtSoftwareVersion.Text = "1.0"
            txtSoftwareVersionDate.Text = "2010/05/10"
        End Sub
    End Class
End Namespace
