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

Imports System.Collections.Generic
Imports System.Configuration
Imports System.Windows.Forms
Imports SampleCode_Desktop.schemas.ipcommerce.com.Ipc.General.WCF.Contracts.Common.External.SvcInfo

Namespace SampleCode
    Partial Public Class ManageMerchantProfile
        Inherits Form
        Private _Add As Boolean = True
        Private _Language As TypeISOLanguageCodeA3
        Private _CountryCode As TypeISOCountryCodeA3
        Private _CurrencyCode As TypeISOCurrencyCodeA3
        Private _CustomerPresent As CustomerPresent
        Private _RequestACI As RequestACI
        Private _MerchantIndustryType As IndustryType
		Private _EntryMode As EntryMode
		Public _Dirty As Boolean
		Public Helper As New HelperMethods()
		'The following class performs many of the different operations needs for service information and trasaction processing
		Private _bcs As New BankcardService()
		Private _ecks As New ElectronicCheckingService()
		Private _svas As New StoredValueService()
		Private _strServiceID As String

        Protected _FaultHandler As New FaultHandler.FaultHandler()

        Public Sub New()
            InitializeComponent()
        End Sub

Private Sub showECKFields()
			txtProfileId.[ReadOnly] = False
			'MerchantData
			txtCustomerServiceInternet.[ReadOnly] = False
			txtCustomerServicePhone.[ReadOnly] = False
			txtMerchantId.[ReadOnly] = False
			lblMerchantId.Text = "OriginatorId"
			txtName.[ReadOnly] = False
			txtPhone.[ReadOnly] = False
			txtTaxId.[ReadOnly] = True
			'MerchantData.Address
			txtCity.[ReadOnly] = False
			txtPostalCode.[ReadOnly] = False
			txtStateProvince.[ReadOnly] = False
			txtStreetAddress1.[ReadOnly] = False
			txtStreetAddress2.[ReadOnly] = False
			'MerchantData.BankcardMerchantData
			txtABANumber.[ReadOnly] = True
			txtAcquirerBIN.[ReadOnly] = True
			txtAgentBank.[ReadOnly] = True
			txtAgentChain.[ReadOnly] = True
			txtClientNum.[ReadOnly] = True
			txtLocation.[ReadOnly] = True
			txtSecondaryTerminalId.[ReadOnly] = True
			txtSettlementAgent.[ReadOnly] = True
			txtSharingGroup.[ReadOnly] = True
			txtSIC.[ReadOnly] = False
			txtStoreId.[ReadOnly] = False
			lblStoreId.Text = "SiteId"
			txtSocketNum.[ReadOnly] = False
			lblTerminalId.Text = "ProductId"
			txtTimeZoneDifferential.[ReadOnly] = True
			txtReimbursementAttribute.[ReadOnly] = True
			txtClientNum.Text = ""

		End Sub

		Private Sub showSVAFields()
			txtProfileId.[ReadOnly] = False
			'MerchantData
			txtCustomerServiceInternet.[ReadOnly] = False
			txtCustomerServicePhone.[ReadOnly] = False
			txtMerchantId.[ReadOnly] = False
			txtName.[ReadOnly] = False
			txtPhone.[ReadOnly] = False
			txtTaxId.[ReadOnly] = False
			'MerchantData.Address
			txtCity.[ReadOnly] = False
			txtPostalCode.[ReadOnly] = False
			txtStateProvince.[ReadOnly] = False
			txtStreetAddress1.[ReadOnly] = False
			txtStreetAddress2.[ReadOnly] = False
			'MerchantData.BankcardMerchantData
			txtABANumber.[ReadOnly] = True
			txtAcquirerBIN.[ReadOnly] = True
			txtAgentBank.[ReadOnly] = True
			txtAgentChain.[ReadOnly] = False
			txtAgentChain.Text = "124423"
			txtClientNum.[ReadOnly] = False
			txtLocation.[ReadOnly] = True
			txtSecondaryTerminalId.[ReadOnly] = True
			txtSettlementAgent.[ReadOnly] = True
			txtSharingGroup.[ReadOnly] = True
			txtSIC.[ReadOnly] = False
			txtStoreId.[ReadOnly] = False
			txtSocketNum.[ReadOnly] = False
			txtTimeZoneDifferential.[ReadOnly] = True
			txtReimbursementAttribute.[ReadOnly] = True

		End Sub

		Private Sub showBCPFields()
			txtProfileId.[ReadOnly] = False
			'MerchantData
			txtCustomerServiceInternet.[ReadOnly] = False
			txtCustomerServicePhone.[ReadOnly] = False
			txtMerchantId.[ReadOnly] = False
			txtName.[ReadOnly] = False
			txtPhone.[ReadOnly] = False
			txtTaxId.[ReadOnly] = False
			'MerchantData.Address
			txtCity.[ReadOnly] = False
			txtPostalCode.[ReadOnly] = False
			txtStateProvince.[ReadOnly] = False
			txtStreetAddress1.[ReadOnly] = False
			txtStreetAddress2.[ReadOnly] = False
			'MerchantData.BankcardMerchantData
			txtABANumber.[ReadOnly] = True
			txtAcquirerBIN.[ReadOnly] = True
			txtAgentBank.[ReadOnly] = True
			txtAgentChain.[ReadOnly] = True
			txtClientNum.[ReadOnly] = False
			txtLocation.[ReadOnly] = True
			txtSecondaryTerminalId.[ReadOnly] = True
			txtSettlementAgent.[ReadOnly] = True
			txtSharingGroup.[ReadOnly] = True
			txtSIC.[ReadOnly] = False
			txtStoreId.[ReadOnly] = True
			txtStoreId.Text = ""
			txtSocketNum.[ReadOnly] = False
			txtTimeZoneDifferential.[ReadOnly] = True
			txtReimbursementAttribute.[ReadOnly] = True

		End Sub

		Private Sub showBCPExpandedFields()
			txtProfileId.[ReadOnly] = False
			'MerchantData
			txtCustomerServiceInternet.[ReadOnly] = False
			txtCustomerServicePhone.[ReadOnly] = False
			txtMerchantId.[ReadOnly] = False
			txtName.[ReadOnly] = False
			txtPhone.[ReadOnly] = False
			txtTaxId.[ReadOnly] = False
			'MerchantData.Address
			txtCity.[ReadOnly] = False
			txtPostalCode.[ReadOnly] = False
			txtStateProvince.[ReadOnly] = False
			txtStreetAddress1.[ReadOnly] = False
			txtStreetAddress2.[ReadOnly] = False
			'MerchantData.BankcardMerchantData
			txtABANumber.[ReadOnly] = False
			txtAcquirerBIN.[ReadOnly] = False
			txtAgentBank.[ReadOnly] = False
			txtAgentChain.[ReadOnly] = False
			txtClientNum.[ReadOnly] = False
			txtLocation.[ReadOnly] = False
			txtSecondaryTerminalId.[ReadOnly] = False
			txtSettlementAgent.[ReadOnly] = False
			txtSharingGroup.[ReadOnly] = False
			txtSIC.[ReadOnly] = False
			txtStoreId.[ReadOnly] = False
			txtSocketNum.[ReadOnly] = False
			txtTimeZoneDifferential.[ReadOnly] = False
			txtReimbursementAttribute.[ReadOnly] = False
		End Sub

		Private Sub hideAllFields()
			txtProfileId.[ReadOnly] = True
			'MerchantData
			txtCustomerServiceInternet.[ReadOnly] = True
			txtCustomerServicePhone.[ReadOnly] = True
			txtMerchantId.[ReadOnly] = True
			lblMerchantId.Text = "MerchantId"
			txtName.[ReadOnly] = True
			txtPhone.[ReadOnly] = True
			txtTaxId.[ReadOnly] = True
			'MerchantData.Address
			txtCity.[ReadOnly] = True
			txtPostalCode.[ReadOnly] = True
			txtStateProvince.[ReadOnly] = True
			txtStreetAddress1.[ReadOnly] = True
			txtStreetAddress2.[ReadOnly] = True
			'MerchantData.BankcardMerchantData
			txtABANumber.[ReadOnly] = True
			txtAcquirerBIN.[ReadOnly] = True
			txtAgentBank.[ReadOnly] = True
			txtAgentChain.[ReadOnly] = True
			txtClientNum.[ReadOnly] = True
			txtLocation.[ReadOnly] = True
			txtSecondaryTerminalId.[ReadOnly] = True
			txtSettlementAgent.[ReadOnly] = True
			txtSharingGroup.[ReadOnly] = True
			txtSIC.[ReadOnly] = True
			txtStoreId.[ReadOnly] = True
			lblStoreId.Text = "StoreId"
			txtSocketNum.[ReadOnly] = True
			lblTerminalId.Text = "TerminalId"
			txtTimeZoneDifferential.[ReadOnly] = True
			txtReimbursementAttribute.[ReadOnly] = True
		End Sub

		Private Sub showAllFields()
			txtProfileId.[ReadOnly] = False
			'MerchantData
			txtCustomerServiceInternet.[ReadOnly] = False
			txtCustomerServicePhone.[ReadOnly] = False
			txtMerchantId.[ReadOnly] = False
			lblMerchantId.Text = "MerchantId"
			txtName.[ReadOnly] = False
			txtPhone.[ReadOnly] = False
			txtTaxId.[ReadOnly] = False
			'MerchantData.Address
			txtCity.[ReadOnly] = False
			txtPostalCode.[ReadOnly] = False
			txtStateProvince.[ReadOnly] = False
			txtStreetAddress1.[ReadOnly] = False
			txtStreetAddress2.[ReadOnly] = False
			'MerchantData.BankcardMerchantData
			txtABANumber.[ReadOnly] = False
			txtAcquirerBIN.[ReadOnly] = False
			txtAgentBank.[ReadOnly] = False
			txtAgentChain.[ReadOnly] = False
			txtClientNum.[ReadOnly] = False
			txtLocation.[ReadOnly] = False
			txtSecondaryTerminalId.[ReadOnly] = False
			txtSettlementAgent.[ReadOnly] = False
			txtSharingGroup.[ReadOnly] = False
			txtSIC.[ReadOnly] = False
			txtStoreId.[ReadOnly] = False
			lblStoreId.Text = "StoreId"
			txtSocketNum.[ReadOnly] = False
			lblTerminalId.Text = "TerminalId"
			txtTimeZoneDifferential.[ReadOnly] = False
			txtReimbursementAttribute.[ReadOnly] = False
		End Sub
        Public Sub CallingForm(ByVal merchantProfile As MerchantProfile, ByVal blnNewProfile As Boolean, ByVal bcs As BankcardService, ByVal ecks As ElectronicCheckingService, ByVal svas As StoredValueService, ByVal serviceId As String)
            _bcs = bcs
            _ecks = ecks
            _svas = svas
            _strServiceID = serviceId

            hideAllFields()
            'Since MerchantProfile is saved at the serviceId level, display serviceId.
            txtMerchantProfileServiceId.Text = merchantProfile.ServiceId

            If blnNewProfile Then
                'New profile to add to CWS
                cmdAddUpdate.Text = "Add"

                'Populate combo boxes with the Enumeration
                cboCountryCode.Sorted = True
                cboCountryCode.DataSource = [Enum].GetValues(GetType(TypeISOCountryCodeA3))
                cboCountryCode.SelectedItem = TypeISOCountryCodeA3.NotSet

                cboLanguage.Sorted = True
                cboLanguage.DataSource = [Enum].GetValues(GetType(TypeISOLanguageCodeA3))
                cboLanguage.SelectedItem = TypeISOLanguageCodeA3.NotSet

                cboCurrencyCode.Sorted = True
                cboCurrencyCode.DataSource = [Enum].GetValues(GetType(TypeISOCurrencyCodeA3))
                cboCurrencyCode.SelectedItem = TypeISOCurrencyCodeA3.NotSet


                cboCustomerPresent.Sorted = True
                cboCustomerPresent.DataSource = [Enum].GetValues(GetType(CustomerPresent))
                cboCustomerPresent.SelectedItem = CustomerPresent.NotSet

                cboRequestACI.Sorted = True
                cboRequestACI.DataSource = [Enum].GetValues(GetType(RequestACI))
                cboRequestACI.SelectedItem = RequestACI.IsCPSMeritCapable

                cboEntryMode.Sorted = True
                cboEntryMode.DataSource = [Enum].GetValues(GetType(EntryMode))
                cboEntryMode.SelectedItem = EntryMode.NotSet
                cboMerchantIndustryType.Sorted = True
                cboMerchantIndustryType.DataSource = [Enum].GetValues(GetType(IndustryType))
                cboMerchantIndustryType.SelectedItem = IndustryType.NotSet

            Else
                'Existing Profile to Update
                'Note : items commented out are not use so no need to wire up a text box as well as add to 'SaveMerchantInformation()'
                txtProfileId.Text = merchantProfile.ProfileId
                txtProfileId.[ReadOnly] = True
                lblLastUpdated.Text = "Last Updated : " & Convert.ToString(merchantProfile.LastUpdated)
                'MerchantData
                'MerchantData.Address
                txtCity.Text = merchantProfile.MerchantData.Address.City
                txtPostalCode.Text = merchantProfile.MerchantData.Address.PostalCode
                txtStateProvince.Text = merchantProfile.MerchantData.Address.StateProvince.ToString()
                txtStreetAddress1.Text = merchantProfile.MerchantData.Address.Street1
                txtStreetAddress2.Text = merchantProfile.MerchantData.Address.Street2
                txtCustomerServiceInternet.Text = merchantProfile.MerchantData.CustomerServiceInternet
                txtCustomerServicePhone.Text = merchantProfile.MerchantData.CustomerServicePhone
                txtMerchantId.Text = merchantProfile.MerchantData.MerchantId
                txtName.Text = merchantProfile.MerchantData.Name
                txtPhone.Text = merchantProfile.MerchantData.Phone
                txtTaxId.Text = merchantProfile.MerchantData.TaxId
                If _bcs IsNot Nothing Then
                    'MerchantData.BankcardMerchantData
                    txtABANumber.Text = merchantProfile.MerchantData.BankcardMerchantData.ABANumber
                    txtAcquirerBIN.Text = merchantProfile.MerchantData.BankcardMerchantData.AcquirerBIN
                    txtAgentBank.Text = merchantProfile.MerchantData.BankcardMerchantData.AgentBank
                    txtAgentChain.Text = merchantProfile.MerchantData.BankcardMerchantData.AgentChain
                    txtClientNum.Text = merchantProfile.MerchantData.BankcardMerchantData.ClientNumber
                    txtLocation.Text = merchantProfile.MerchantData.BankcardMerchantData.Location
                    'txtTBD.Text = _MerchantProfile.MerchantData.BankcardMerchantData.PrintCustomerServicePhone == "";
                    txtSecondaryTerminalId.Text = merchantProfile.MerchantData.BankcardMerchantData.SecondaryTerminalId
                    txtSettlementAgent.Text = merchantProfile.MerchantData.BankcardMerchantData.SettlementAgent
                    txtSharingGroup.Text = merchantProfile.MerchantData.BankcardMerchantData.SharingGroup
                    txtSIC.Text = merchantProfile.MerchantData.BankcardMerchantData.SIC
                    txtStoreId.Text = merchantProfile.MerchantData.BankcardMerchantData.StoreId
                    txtSocketNum.Text = merchantProfile.MerchantData.BankcardMerchantData.TerminalId
                    txtTimeZoneDifferential.Text = merchantProfile.MerchantData.BankcardMerchantData.TimeZoneDifferential
                    txtReimbursementAttribute.Text = merchantProfile.MerchantData.BankcardMerchantData.ReimbursementAttribute
                End If
                If _svas IsNot Nothing Then
                    'MerchantData.StoredValueMerchantData
                    txtAgentChain.Text = merchantProfile.MerchantData.StoredValueMerchantData.AgentChain
                    txtClientNum.Text = merchantProfile.MerchantData.StoredValueMerchantData.ClientNumber
                    txtSIC.Text = merchantProfile.MerchantData.StoredValueMerchantData.SIC
                    txtStoreId.Text = merchantProfile.MerchantData.StoredValueMerchantData.StoreId
                    txtSocketNum.Text = merchantProfile.MerchantData.StoredValueMerchantData.TerminalId
                    _MerchantIndustryType = merchantProfile.MerchantData.StoredValueMerchantData.IndustryType
                End If
                If _ecks IsNot Nothing Then
                    'MerchantData.ElectronicCheckingMerchantData
                    txtMerchantId.Text = merchantProfile.MerchantData.ElectronicCheckingMerchantData.OrginatorId
                    txtStoreId.Text = merchantProfile.MerchantData.ElectronicCheckingMerchantData.SiteId
                    txtSocketNum.Text = merchantProfile.MerchantData.ElectronicCheckingMerchantData.ProductId
                End If

                'First Populate with the Enumeration
                cboCountryCode.DataSource = [Enum].GetValues(GetType(TypeISOCountryCodeA3))
                'Now select the index that matches
                If merchantProfile.MerchantData.Address.CountryCode.ToString().Length > 0 Then
                    cboCountryCode.SelectedItem = merchantProfile.MerchantData.Address.CountryCode
                    _CountryCode = DirectCast(cboCountryCode.SelectedItem, TypeISOCountryCodeA3)
                End If
                'First Populate with the Enumeration
                cboLanguage.DataSource = [Enum].GetValues(GetType(TypeISOLanguageCodeA3))
                'Now select the index that matches
                If merchantProfile.MerchantData.Language.ToString().Length > 0 Then
                    cboLanguage.SelectedItem = merchantProfile.MerchantData.Language
                    _Language = DirectCast(cboLanguage.SelectedItem, TypeISOLanguageCodeA3)
                End If
                'First Populate with the Enumeration
                cboCurrencyCode.DataSource = [Enum].GetValues(GetType(TypeISOCurrencyCodeA3))
                'Now select the index that matches
                If merchantProfile.MerchantData.Language.ToString().Length > 0 Then
                    cboCurrencyCode.SelectedItem = merchantProfile.TransactionData.BankcardTransactionDataDefaults.CurrencyCode
                    _CurrencyCode = DirectCast(cboCurrencyCode.SelectedItem, TypeISOCurrencyCodeA3)
                End If

                'First Populate with the Enumeration
                cboCustomerPresent.DataSource = [Enum].GetValues(GetType(CustomerPresent))
                'Now select the index that matches
                If merchantProfile.TransactionData.BankcardTransactionDataDefaults.CustomerPresent.ToString().Length > 0 Then
                    cboCustomerPresent.SelectedItem = merchantProfile.TransactionData.BankcardTransactionDataDefaults.CustomerPresent
                    _CustomerPresent = DirectCast(cboCustomerPresent.SelectedItem, CustomerPresent)
                End If

                'First Populate with the Enumeration
                cboRequestACI.DataSource = [Enum].GetValues(GetType(RequestACI))
                'Now select the index that matches
                If merchantProfile.TransactionData.BankcardTransactionDataDefaults.RequestACI.ToString().Length > 0 Then
                    cboRequestACI.SelectedItem = merchantProfile.TransactionData.BankcardTransactionDataDefaults.RequestACI
                    _RequestACI = DirectCast(cboRequestACI.SelectedItem, RequestACI)
                End If

                'First Populate with the Enumeration
                cboMerchantIndustryType.DataSource = [Enum].GetValues(GetType(IndustryType))
                If merchantProfile.MerchantData.BankcardMerchantData.IndustryType.ToString().Length > 0 Then
                    cboMerchantIndustryType.SelectedItem = merchantProfile.MerchantData.BankcardMerchantData.IndustryType
                    _MerchantIndustryType = DirectCast(cboMerchantIndustryType.SelectedItem, IndustryType)
                End If

                'First Populate with the Enumeration
                cboEntryMode.DataSource = [Enum].GetValues(GetType(EntryMode))
                If merchantProfile.TransactionData.BankcardTransactionDataDefaults.EntryMode.ToString().Length > 0 Then
                    cboEntryMode.SelectedItem = merchantProfile.TransactionData.BankcardTransactionDataDefaults.EntryMode
                    _EntryMode = DirectCast(cboEntryMode.SelectedItem, EntryMode)
                End If

                _Add = False
                'In this case it's an update and not an add
                cmdAddUpdate.Text = "Update"
            End If


            If _bcs IsNot Nothing Then
                If _strServiceID = "C82ED00001" OrElse _strServiceID = "71C8700001" OrElse _strServiceID = "88D9300001" OrElse _strServiceID = "B447F00001" OrElse _strServiceID = "D806000001" OrElse _strServiceID = "E88FD00001" Then
                    showBCPExpandedFields()
                ElseIf _strServiceID = "168511300C" OrElse _strServiceID = "9999999999" Then
                    showBCPExpandedFields()
                Else
                    showBCPFields()
                End If
            End If

            If _ecks IsNot Nothing Then
                showECKFields()
            End If
            If _svas IsNot Nothing Then
                showSVAFields()
            End If
        End Sub

		Private Sub SaveMerchantInformation()
			Dim MPList As New List(Of MerchantProfile)()
			Dim MerP As New MerchantProfile()

			MerP.ProfileId = txtProfileId.Text
			MerP.MerchantData = New MerchantProfileMerchantData()
			MerP.MerchantData.Address = New AddressInfo()
			'MerP.MerchantData.BankcardMerchantData = new BankcardMerchantData();

			MerP.TransactionData = New MerchantProfileTransactionData()


			MerP.MerchantData.Address.Street1 = txtStreetAddress1.Text
			MerP.MerchantData.Address.Street2 = txtStreetAddress2.Text
			MerP.MerchantData.Address.City = txtCity.Text
			Try
				MerP.MerchantData.Address.StateProvince = DirectCast([Enum].Parse(GetType(TypeStateProvince), txtStateProvince.Text), TypeStateProvince)
			Catch
			End Try
			MerP.MerchantData.Address.PostalCode = txtPostalCode.Text
			MerP.MerchantData.CustomerServicePhone = txtCustomerServicePhone.Text
			MerP.MerchantData.CustomerServiceInternet = txtCustomerServiceInternet.Text
			MerP.MerchantData.MerchantId = txtMerchantId.Text
			MerP.MerchantData.Name = txtName.Text
			MerP.MerchantData.Phone = txtPhone.Text
			MerP.MerchantData.TaxId = txtTaxId.Text
			MerP.MerchantData.Language = _Language
			MerP.MerchantData.Address.CountryCode = _CountryCode

			MerP.MerchantData.BankcardMerchantData = New BankcardMerchantData()

			If _bcs IsNot Nothing Then
				MerP.TransactionData.BankcardTransactionDataDefaults = New BankcardTransactionDataDefaults()
				MerP.MerchantData.BankcardMerchantData = New BankcardMerchantData()
				MerP.MerchantData.BankcardMerchantData.ClientNumber = txtClientNum.Text
				MerP.MerchantData.BankcardMerchantData.SIC = txtSIC.Text
				MerP.MerchantData.BankcardMerchantData.TerminalId = txtSocketNum.Text
				MerP.MerchantData.BankcardMerchantData.StoreId = txtStoreId.Text
				MerP.TransactionData.BankcardTransactionDataDefaults.CurrencyCode = _CurrencyCode
				MerP.TransactionData.BankcardTransactionDataDefaults.CustomerPresent = _CustomerPresent
				MerP.TransactionData.BankcardTransactionDataDefaults.RequestACI = _RequestACI
				MerP.TransactionData.BankcardTransactionDataDefaults.RequestAdvice = RequestAdvice.Capable
				MerP.TransactionData.BankcardTransactionDataDefaults.EntryMode = _EntryMode

				' Tsys Terminal Capture Siera
				MerP.MerchantData.BankcardMerchantData.ABANumber = txtABANumber.Text
				MerP.MerchantData.BankcardMerchantData.AcquirerBIN = txtAcquirerBIN.Text
				MerP.MerchantData.BankcardMerchantData.AgentBank = txtAgentBank.Text
				MerP.MerchantData.BankcardMerchantData.AgentChain = txtAgentChain.Text
				MerP.MerchantData.BankcardMerchantData.Location = txtLocation.Text
				MerP.MerchantData.BankcardMerchantData.SecondaryTerminalId = txtSecondaryTerminalId.Text
				MerP.MerchantData.BankcardMerchantData.SettlementAgent = txtSettlementAgent.Text
				MerP.MerchantData.BankcardMerchantData.SharingGroup = txtSharingGroup.Text
				MerP.MerchantData.BankcardMerchantData.TimeZoneDifferential = txtTimeZoneDifferential.Text
				MerP.MerchantData.BankcardMerchantData.ReimbursementAttribute = txtReimbursementAttribute.Text
				MerP.MerchantData.BankcardMerchantData.IndustryType = _MerchantIndustryType
			End If

			If _ecks IsNot Nothing Then
				MerP.MerchantData.ElectronicCheckingMerchantData = New ElectronicCheckingMerchantData()
				MerP.MerchantData.ElectronicCheckingMerchantData.OrginatorId = txtMerchantId.Text
				MerP.MerchantData.ElectronicCheckingMerchantData.ProductId = txtSocketNum.Text
				MerP.MerchantData.ElectronicCheckingMerchantData.SiteId = txtStoreId.Text
			End If
			If _svas IsNot Nothing Then
				MerP.MerchantData.StoredValueMerchantData = New StoredValueMerchantData()
				MerP.MerchantData.StoredValueMerchantData.AgentChain = txtAgentChain.Text
				MerP.MerchantData.StoredValueMerchantData.ClientNumber = txtClientNum.Text
				MerP.MerchantData.StoredValueMerchantData.SIC = txtSIC.Text
				MerP.MerchantData.StoredValueMerchantData.StoreId = txtStoreId.Text
				MerP.MerchantData.StoredValueMerchantData.TerminalId = txtSocketNum.Text

				MerP.MerchantData.StoredValueMerchantData.IndustryType = _MerchantIndustryType
			End If

			'Add the profile to a list of profiles. This is necessary to save the profile
			MPList.Add(MerP)
			'From the calling form
			DirectCast(Owner, SampleCode_DeskTop).Helper.CheckTokenExpire()
			Dim _strServiceID As String = DirectCast(Owner, SampleCode_DeskTop).Helper.ServiceID
			Dim _strSessionToken As String = DirectCast(Owner, SampleCode_DeskTop).Helper.SessionToken

			If ChkUseWorkFlowId.Checked Then
				DirectCast(Owner, SampleCode_DeskTop).Helper.Cwssic.SaveMerchantProfiles(_strSessionToken, DirectCast(Owner, SampleCode_DeskTop).Helper.WorkflowID, TenderType.Credit, MPList)
			Else
				DirectCast(Owner, SampleCode_DeskTop).Helper.Cwssic.SaveMerchantProfiles(_strSessionToken, _strServiceID, TenderType.Credit, MPList)
			End If
			
		End Sub


        Private Sub cmdClose_Click(ByVal sender As Object, ByVal e As EventArgs)
            Close()
        End Sub

#Region "Form Events"

        Private Sub cmdAddUpdate_Click(ByVal sender As Object, ByVal e As EventArgs)
            _Dirty = True
            Try
                'Unique MerchantProfileId should be used for all new MerchantProfiles added
                If _Add AndAlso txtProfileId.Text.Length < 1 Then
                    MessageBox.Show("MerchantProfileId required and cannot be empty")
                    txtProfileId.Focus()
                    Return
                End If
                If Not _Add AndAlso txtProfileId.Text.Length < 1 Then
                    MessageBox.Show("Detected Empty MerchantProfileId. The Sample will allow the update however an empty MerchantProfileId is not a recommended solution.")
                    txtProfileId.Focus()
                End If

                SaveMerchantInformation()
                If _Add Then
                    MessageBox.Show("Successfully Added a new Profile")
                Else
                    MessageBox.Show("Successfully Updated a Profile")
                End If
                Close()
            Catch generatedExceptionName As System.ServiceModel.EndpointNotFoundException
                'In this case the SvcEndpoint was not available. Try the same logic again with the alternate Endpoint
                Try
                    DirectCast(Owner, SampleCode_DeskTop).Helper.SetSvcEndpoint()
                    'Change the endpoint to use the backup.
                    SaveMerchantInformation()
                    If _Add Then
                        MessageBox.Show("Successfully Added a new Profile")
                    Else
                        MessageBox.Show("Successfully Updated a Profile")
                    End If
                    Close()
                Catch generatedExceptionNameDuplicate As System.ServiceModel.EndpointNotFoundException
                    MessageBox.Show("Neither the primary or secondary endpoints are available. Unable to process.")
                Catch ex As Exception
                    MessageBox.Show(ex.Message.ToString())
                End Try
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
            Dim Result As DialogResult
            Dim profileId As String = txtProfileId.Text
            If profileId.Trim() = "" Then
                profileId = "<default>"
            End If
            Result = MessageBox.Show("The action will attempt to delete the profile " & vbCr & vbLf & vbCr & vbLf & "     '" & profileId & "' " & vbCr & vbLf & vbCr & vbLf & "Do you want to continue?", "Overwrite", MessageBoxButtons.OKCancel)
            If Result = DialogResult.Cancel Then
                Return
            End If

            'From the calling form
            DirectCast(Owner, SampleCode_DeskTop).Helper.CheckTokenExpire()
            Dim _strServiceID As String = DirectCast(Owner, SampleCode_DeskTop).Helper.ServiceID
            Dim _strSessionToken As String = DirectCast(Owner, SampleCode_DeskTop).Helper.SessionToken

            Try
                DirectCast(Owner, SampleCode_DeskTop).Helper.Cwssic.DeleteMerchantProfile(_strSessionToken, txtProfileId.Text, _strServiceID, TenderType.Credit)
            Catch ex As Exception
                Dim strErrorId As String
                Dim strErrorMessage As String
                If _FaultHandler.handleSvcInfoFault(ex, strErrorId, strErrorMessage) Then
                    MessageBox.Show(strErrorId & " : " & strErrorMessage)
                Else
                    MessageBox.Show(ex.Message)
                End If
            End Try
            'Since the profile no longer exists close the dialogue. 
            _Dirty = True
            Close()
        End Sub

      
		Private Sub cmdPopulateTestValues_Click(sender As Object, e As EventArgs)
			'Online Reference http://commercelab.ipcommerce.com/Docs/Documentation/1.17.12/CWS_API_Reference/ServiceInfoDataElements/BankcardMerchantData.aspx
			MessageBox.Show("Please note that the following values are generic. Depending on the scope of your integration the following values may change. Please contact your solution consultant with any questions.")

			'The following are typical settings please ask your solution consultant if you have any questions
			txtStreetAddress1.Text = "123 Merchant name"
			txtStreetAddress2.Text = ""
			txtCity.Text = "Pleasanton"
			txtStateProvince.Text = "CA"
			txtPostalCode.Text = "94566"
			txtCustomerServicePhone.Text = "303 5553232"
			' Must be of format “NNN NNNNNNN”
			txtMerchantId.Text = "123456789012"
			txtName.Text = "Test Merch"
			txtPhone.Text = "720 8881212"
			' Must be of format “NNN NNNNNNN”
			txtTaxId.Text = ""
			txtClientNum.Text = "1234"
			txtSIC.Text = "5999"
			txtStoreId.Text = "1234"
			txtSocketNum.Text = "001"
			txtCustomerServiceInternet.Text = "test@test.com

			'The following fields are used by Tsys Terminal Capture Siera and are part of the additional items
			If _strServiceID = "C82ED00001" OrElse _strServiceID = "71C8700001" OrElse _strServiceID = "88D9300001" OrElse _strServiceID = "B447F00001" OrElse _strServiceID = "D806000001" OrElse _strServiceID = "E88FD00001" Then
				'Tsys/Vantiv Terminal Capture ServiceId
				txtStoreId.Text = "1234"
				'Used only for RBS and Tsys
				txtABANumber.Text = "987654321"
				txtAcquirerBIN.Text = "654321"
				txtAgentBank.Text = "123456"
				txtAgentChain.Text = "645231"
				txtLocation.Text = "12345"
				txtSecondaryTerminalId.Text = "12345678"
				txtSettlementAgent.Text = "12AB"
				txtSharingGroup.Text = "123ABC"
				txtTimeZoneDifferential.Text = "005"
				txtReimbursementAttribute.Text = "A"
				txtSocketNum.Text = "0001"
			End If

			Try
				Try
					cboMerchantIndustryType.SelectedItem = DirectCast([Enum].Parse(GetType(IndustryType), ConfigurationSettings.AppSettings("IndustryType")), IndustryType)
				Catch
				End Try
				cboLanguage.SelectedItem = TypeISOLanguageCodeA3.ENG
				cboCountryCode.SelectedItem = TypeISOCountryCodeA3.USA
				cboCurrencyCode.SelectedItem = TypeISOCurrencyCodeA3.USD
				Try
					cboCustomerPresent.SelectedItem = DirectCast([Enum].Parse(GetType(CustomerPresent), ConfigurationSettings.AppSettings("CustomerPresent")), CustomerPresent)
				' [Ecommerce : Ecommerce] [MOTO : MOTO] [Retail/Restaurant : Present]
				Catch
				End Try
				Try
					cboRequestACI.SelectedItem = DirectCast([Enum].Parse(GetType(RequestACI), ConfigurationSettings.AppSettings("RequestACI")), RequestACI)
				'In general default to "IsCPSMeritCapable"
				Catch
				End Try
				Try
					cboEntryMode.SelectedItem = DirectCast([Enum].Parse(GetType(EntryMode), ConfigurationSettings.AppSettings("EntryMode")), EntryMode)
				'[Keyed : TrackDataFromMSR ]
				Catch
				End Try
			Catch
			End Try
			If _bcs IsNot Nothing Then
				If _strServiceID = "C82ED00001" OrElse _strServiceID = "71C8700001" OrElse _strServiceID = "88D9300001" OrElse _strServiceID = "B447F00001" OrElse _strServiceID = "D806000001" OrElse _strServiceID = "E88FD00001" Then
					showBCPExpandedFields()
				ElseIf _strServiceID = "168511300C" OrElse _strServiceID = "9999999999" Then
					showBCPExpandedFields()
				Else
					showBCPFields()
				End If
			End If

			If _ecks IsNot Nothing Then
				showECKFields()
			End If
			If _svas IsNot Nothing Then
				showSVAFields()
			End If
		End Sub

		Private Sub ChkEnableAllMerchantFields_CheckedChanged(sender As Object, e As EventArgs)
			If ChkEnableAllMerchantFields.Checked Then
				showAllFields()
			Else
				hideAllFields()
			End If
		End Sub

		#Region "ComboBox Events"
		Private Sub cboCountryCode_SelectedIndexChanged(sender As Object, e As EventArgs)
			_CountryCode = DirectCast(cboCountryCode.SelectedItem, TypeISOCountryCodeA3)
		End Sub

		Private Sub cboLanguage_SelectedIndexChanged(sender As Object, e As EventArgs)
			_Language = DirectCast(cboLanguage.SelectedItem, TypeISOLanguageCodeA3)
		End Sub

		Private Sub cboCurrencyCode_SelectedIndexChanged(sender As Object, e As EventArgs)
			_CurrencyCode = DirectCast(cboCurrencyCode.SelectedItem, TypeISOCurrencyCodeA3)
		End Sub

		Private Sub cboCustomerPresent_SelectedIndexChanged(sender As Object, e As EventArgs)
			_CustomerPresent = DirectCast(cboCustomerPresent.SelectedItem, CustomerPresent)
		End Sub

		Private Sub cboRequestACI_SelectedIndexChanged(sender As Object, e As EventArgs)
			_RequestACI = DirectCast(cboRequestACI.SelectedItem, RequestACI)
		End Sub

		Private Sub cboMerchantIndustryType_SelectedIndexChanged(sender As Object, e As EventArgs)
			_MerchantIndustryType = DirectCast(cboMerchantIndustryType.SelectedItem, IndustryType)
		End Sub

		Private Sub cboEntryMode_SelectedIndexChanged(sender As Object, e As EventArgs)
			_EntryMode = DirectCast(cboEntryMode.SelectedItem, EntryMode)
		End Sub

		#End Region

		#End Region


	End Class

End Namespace
