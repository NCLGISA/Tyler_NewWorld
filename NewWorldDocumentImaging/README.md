# Logos to New World
This is Randolph County's integration of Logos to Laserfiche using the 'paperclip' functionality inside of Logos.

daniel.shue'at'randolphcountync.gov

You'll need to modify C:\Program Files (x86)\New World Systems\Logos.Net\Services\Suite\ExternalLinks.config


	<!-- Templates -->
		<externalLinks>
			<!--
				<add type="" template=""/>
				"type" is the string representation of the enumeration value in 
						NewWorld.Logos.Common.Enumerations.enExternalLinkType, NOT the description
				"template" is the javascript onclick function for the external link icon on the page
						it also contains the columns that need to be replaced by the stored
						procedure call (the column name is between "{{" and "}}",
						escape any special chars for javascript
						Example:
									template="alert('Value: /&quot;{{ColumnName}}/&quot');"
								will render as:
									onclick="alert('Value: /&quot;ColumnValue/&quot;');"
								will show an alert window with the message: (the string the script sees is:  Value: "ColumnValue"  )
									Value: "ColumnValue"
			-->
			
			<!-- Test (shows all data columns in an alert) -->
				 <!-- <add type="Check" template="alert(&quot;ExternalLinkType:Check\nTransactionNumber:{{TransactionNumber}}\nTransactionDate:{{TransactionDate}}&quot;);" /> -->
				 <add type="Check" template="window.open('http://weblink.yourdomain.com/WebLink8/search.aspx?dbid=0&amp;searchcommand={[AD - General]:[Check Number]={{TransactionNumber}}}');" />
				 <!-- <add type="Check" template="window.open('http://weblink.yourdomain.com/weblink8/search.apsx?dbid=0&ampsearchcommand=');" /> -->
				 <!-- <add type="AccountsPayableInvoice" template="alert(&quot;ExternalLinkType:AccountsPayableInvoice\nInvoiceNumber:{{InvoiceNumber}}\nVendorNumber:{{VendorNumber}}&quot;);" /> -->
				 <!-- <add type="Employee" template="alert(&quot;ExternalLinkType:Employee\nSSN:{{SSN}}\nNumber:{{EmployeeNumber}}\nLastName:{{LastName}}\nFirstName:{{FirstName}}&quot;);" /> -->
				 <!-- <add type="Journal" template="alert(&quot;ExternalLinkType:Journal\nJournalNumber:{{JournalNumber}}&quot;);" /> -->
				 <!-- <add type="PurchaseOrder" template="alert(&quot;ExternalLinkType:PurchaseOrder\nPONumber:{{PONumber}}&quot;);" /> -->
				 <!-- <add type="Requisition" template="alert(&quot;ExternalLinkType:Requisition\nRequisitionNumber:{{RequisitionNumber}}&quot;);" /> -->
				 <!-- <add type="RevenueCollectionsReceipt" template="alert(&quot;ExternalLinkType:RevenueCollectionsReceipt\nReceiptNumber:{{ReceiptNumber}}&quot;);" /> --> 
				 <!-- <add type="MBInvoice" template="alert(&quot;ExternalLinkType:MBInvoice\nCustomerNumber:{{CustomerNumber}}\nInvoiceType:{{InvoiceTypeCode}}\nInvoiceNumber:{{InvoiceNumber}}&quot;);" /> --> 
				 <!-- <add type="Parcel" template="alert(&quot;ExternalLinkType:Parcel\nParcelNumber:{{ParcelNumber}}\nJurisdiction:{{JurisdictionCode}}&quot;);" /> --> 
				 <add type="Parcel" template="window.open('http://weblink.yourdomain.com/NewWorldDoc/Parcel.aspx?ParcelNumber={{ParcelNumber}}','_blank','height=300,width=300,location=no,menubar=no,resizable=no,scrollbars=no,status=no,toolbar=no');" />
				 <!-- <add type="Permit" template="alert(&quot;ExternalLinkType:Permit\nPermitNumber:{{PermitNumber}}\nPermitTypeCode:{{PermitTypeCode}}&quot;);" /> -->
				 <add type="Permit" template="window.open('http://weblink.yourdomain.com/NewWorldDoc/Default.aspx?PermitNumber={{PermitNumber}}&amp;PermitType={{PermitTypeCode}}','_blank','height=300,width=300,location=no,menubar=no,resizable=no,scrollbars=no,status=no,toolbar=no');" />
				 <!-- <add type="License" template="alert(&quot;ExternalLinkType:License\nLicenseNumber:{{LicenseNumber}}\nLicenseTypeCode:{{LicenseTypeCode}}&quot;);" /> -->
				 <add type="License" template="window.open('http://weblink.yourdomain.com/NewWorldDoc/License.aspx?LicenseNumber={{LicenseNumber}}&amp;LicenseType={{LicenseTypeCode}}','_blank','height=300,width=310,location=no,menubar=no,resizable=no,scrollbars=no,status=no,toolbar=no');" />
				 <!-- <add type="ProjectPlanning" template="alert(&quot;ExternalLinkType:ProjectPlanning\nProjectNumber:{{ProjectNumber}}\nProjectType:{{ProjectTypeDescription}}&quot;);" /> -->
				 <add type="ProjectPlanning" template="window.open('http://weblink.yourdomain.com/NewWorldDoc/Project.aspx?ProjectNumber={{ProjectNumber}}&amp;ProjectType={{ProjectTypeDescription}}','_blank','height=300,width=300,location=no,menubar=no,resizable=no,scrollbars=no,status=no,toolbar=no');" />
				 <!-- <add type="Inspections" template="alert(&quot;ExternalLinkType:Inspections\nInspectionNumber:{{InspectionNumber}}\nInspectionTypeCode:{{InspectionTypeCode}}&quot;);" /> -->
				 <!-- <add type="CodeEnforcementCase" template="alert(&quot;ExternalLinkType:Case\nCaseNumber:{{CaseNumber}}\nCaseTypeCode:{{Code}}&quot;);" /> -->
				 <add type="CodeEnforcementCase" template="window.open('http://weblink.yourdomain.com/NewWorldDoc/Code.aspx?CodeNumber={{CaseNumber}}','_blank','height=300,width=300,location=no,menubar=no,resizable=no,scrollbars=no,status=no,toolbar=no');" />
				 <!-- <add type="RequestForAction" template="alert(&quot;ExternalLinkType:Request\nRequestNumber:{{CaseRequestNumber}}\nRequestType:{{Code}}&quot;);" /> -->
				 <add type="RequestForAction" template="window.open('http://weblink.yourdomain.com/NewWorldDoc/RFS.aspx?RFSNumber={{CaseRequestNumber}}','_blank','height=300,width=300,location=no,menubar=no,resizable=no,scrollbars=no,status=no,toolbar=no');" />
				 <!-- <add type="UtilityAccounts" template="alert(&quot;ExternalLinkType:Accounts\nAccountNumber:{{FullAccountNumber}}&quot;);" /> -->
				 <!-- <add type="WorkOrder" template="alert(&quot;ExternalLinkType:WorkOrder\nWorkOrderNumber:{{WorkOrderNumber}}\nWorkOrderTypeCode:{{WorkOrderCode}}&quot;);" /> -->
				 <!-- <add type="Asset" template="alert(&quot;ExternalLinkType:Asset\nAssetNumber:{{AssetNumber}}\nBarcodeNumber:{{BarcodeNumber}}&quot;);" /> -->
				 <!-- <add type="Bid" template="alert(&quot;ExternalLinkType:Bid\nBidNumber:{{BidNumber}}\nBidType:{{BidType}}&quot;);" /> -->
				 <!-- <add type="Contracts" template="alert(&quot;ExternalLinkType:Contract\nContractNumber:{{ContractNumber}}&quot;);" /> -->
				 <!-- <add type="Grants" template="alert(&quot;ExternalLinkType:Grants\nGrantNumber:{{GrantNumber}}&quot;);" /> -->
				 <!-- <add type="Projects" template="alert(&quot;ExternalLinkType:Projects\nProjectCode:{{ProjectCode}}\nSubProjectCode:{{SubProjectCode}}\nProjectDetailCode:{{ProjectDetailCode}}\nConcatenatedFullProjectCode:{{ProjectDelimited}}&quot;);" /> -->
		</externalLinks>
	<!-- END Templates -->
