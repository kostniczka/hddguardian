﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla nell'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim MenuItem4 As System.Windows.Forms.MenuItem
        Dim MenuItem2 As System.Windows.Forms.MenuItem
        Dim MenuItem5 As System.Windows.Forms.MenuItem
        Dim tlpRibbonMenu As System.Windows.Forms.TableLayoutPanel
        Dim RibbonHorizontalSeparator2 As hdd_guardian.RibbonHorizontalSeparator
        Dim flwWarnings As System.Windows.Forms.FlowLayoutPanel
        Dim tlpAam As System.Windows.Forms.TableLayoutPanel
        Dim tlpAamLoud As System.Windows.Forms.TableLayoutPanel
        Dim tlpApm As System.Windows.Forms.TableLayoutPanel
        Dim tlpStandby As System.Windows.Forms.TableLayoutPanel
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Dim ListViewGroup1 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Phisycal", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup2 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("External", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup3 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Virtual", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim DataPoint1 As System.Windows.Forms.DataVisualization.Charting.DataPoint = New System.Windows.Forms.DataVisualization.Charting.DataPoint(0.0R, 0.0R)
        Dim DataPoint2 As System.Windows.Forms.DataVisualization.Charting.DataPoint = New System.Windows.Forms.DataVisualization.Charting.DataPoint(0.0R, 5.0R)
        Dim DataPoint3 As System.Windows.Forms.DataVisualization.Charting.DataPoint = New System.Windows.Forms.DataVisualization.Charting.DataPoint(0.0R, 10.0R)
        Dim DataPoint4 As System.Windows.Forms.DataVisualization.Charting.DataPoint = New System.Windows.Forms.DataVisualization.Charting.DataPoint(0.0R, 30.0R)
        Dim DataPoint5 As System.Windows.Forms.DataVisualization.Charting.DataPoint = New System.Windows.Forms.DataVisualization.Charting.DataPoint(0.0R, 25.0R)
        Dim DataPoint6 As System.Windows.Forms.DataVisualization.Charting.DataPoint = New System.Windows.Forms.DataVisualization.Charting.DataPoint(0.0R, 5.0R)
        Dim DataPoint7 As System.Windows.Forms.DataVisualization.Charting.DataPoint = New System.Windows.Forms.DataVisualization.Charting.DataPoint(0.0R, 20.0R)
        Dim DataPoint8 As System.Windows.Forms.DataVisualization.Charting.DataPoint = New System.Windows.Forms.DataVisualization.Charting.DataPoint(0.0R, 15.0R)
        Dim DataPoint9 As System.Windows.Forms.DataVisualization.Charting.DataPoint = New System.Windows.Forms.DataVisualization.Charting.DataPoint(0.0R, 20.0R)
        Dim DataPoint10 As System.Windows.Forms.DataVisualization.Charting.DataPoint = New System.Windows.Forms.DataVisualization.Charting.DataPoint(0.0R, 10.0R)
        Dim DataPoint11 As System.Windows.Forms.DataVisualization.Charting.DataPoint = New System.Windows.Forms.DataVisualization.Charting.DataPoint(0.0R, 60.0R)
        Me.rfiFile = New hdd_guardian.RibbonFileItem()
        Me.rmiOverview = New hdd_guardian.RibbonMenuItem()
        Me.rmiManage = New hdd_guardian.RibbonMenuItem()
        Me.rmiWmiDevices = New hdd_guardian.RibbonMenuItem()
        Me.tlpMessages = New System.Windows.Forms.TableLayoutPanel()
        Me.picAdmin = New System.Windows.Forms.PictureBox()
        Me.picNewVersion = New System.Windows.Forms.PictureBox()
        Me.rmiDebug = New hdd_guardian.RibbonMenuItem()
        Me.lblWarningValue = New System.Windows.Forms.Label()
        Me.lnkWeb1 = New hdd_guardian.NewLink()
        Me.lnkWeb2 = New hdd_guardian.NewLink()
        Me.lnkWeb3 = New hdd_guardian.NewLink()
        Me.lblAamValue = New System.Windows.Forms.Label()
        Me.lblAamRecommended = New System.Windows.Forms.Label()
        Me.lnkSetAam = New hdd_guardian.NewLink()
        Me.lnkSetRecommended = New hdd_guardian.NewLink()
        Me.lnkUndoAam = New hdd_guardian.NewLink()
        Me.lblQuiet = New System.Windows.Forms.Label()
        Me.lblLoudest = New System.Windows.Forms.Label()
        Me.lblApmValue = New System.Windows.Forms.Label()
        Me.lnkSetApm = New hdd_guardian.NewLink()
        Me.lnkUndoApm = New hdd_guardian.NewLink()
        Me.lnkSetStandby = New hdd_guardian.NewLink()
        Me.lblStandbyValue = New System.Windows.Forms.Label()
        Me.lnkUndoStandby = New hdd_guardian.NewLink()
        Me.imlAttr = New System.Windows.Forms.ImageList(Me.components)
        Me.ttMain = New System.Windows.Forms.ToolTip(Me.components)
        Me.niTrayIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.tmrRefresh = New System.Windows.Forms.Timer(Me.components)
        Me.mnuGuide = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuInfo = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmrFlushMem = New System.Windows.Forms.Timer(Me.components)
        Me.tmrTest = New System.Windows.Forms.Timer(Me.components)
        Me.imlDevice = New System.Windows.Forms.ImageList(Me.components)
        Me.imlLog = New System.Windows.Forms.ImageList(Me.components)
        Me.dlgFolder = New System.Windows.Forms.FolderBrowserDialog()
        Me.tmrRefreshExt = New System.Windows.Forms.Timer(Me.components)
        Me.tmrRefreshVirtual = New System.Windows.Forms.Timer(Me.components)
        Me.cmTrayIcon = New System.Windows.Forms.ContextMenu()
        Me.mnuRestoreTray = New System.Windows.Forms.MenuItem()
        Me.mnuExitTray = New System.Windows.Forms.MenuItem()
        Me.cmDevices = New System.Windows.Forms.ContextMenu()
        Me.mnuTitle = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.mnuRefreshSel = New System.Windows.Forms.MenuItem()
        Me.mnuRefreshAll = New System.Windows.Forms.MenuItem()
        Me.mnuSearchUsb = New System.Windows.Forms.MenuItem()
        Me.mnuAddVirtualDev = New System.Windows.Forms.MenuItem()
        Me.mnuRemoveVirtualDev = New System.Windows.Forms.MenuItem()
        Me.MenuItem6 = New System.Windows.Forms.MenuItem()
        Me.mnuTrayIcon = New System.Windows.Forms.MenuItem()
        Me.mnuTrayTemperature = New System.Windows.Forms.MenuItem()
        Me.mnuTrayLife = New System.Windows.Forms.MenuItem()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.mnuInfoPanel = New System.Windows.Forms.MenuItem()
        Me.mnuSharing = New System.Windows.Forms.MenuItem()
        Me.mnuShareThis = New System.Windows.Forms.MenuItem()
        Me.mnuSharingFolder = New System.Windows.Forms.MenuItem()
        Me.mnuXml = New System.Windows.Forms.MenuItem()
        Me.mnuXmlCreate = New System.Windows.Forms.MenuItem()
        Me.mnuXmlFolder = New System.Windows.Forms.MenuItem()
        Me.cmFile = New System.Windows.Forms.ContextMenu()
        Me.mnuReloadDevices = New System.Windows.Forms.MenuItem()
        Me.MenuItem10 = New System.Windows.Forms.MenuItem()
        Me.mnuUpdateDatabase = New System.Windows.Forms.MenuItem()
        Me.MenuItem8 = New System.Windows.Forms.MenuItem()
        Me.mnuSettings = New System.Windows.Forms.MenuItem()
        Me.mnuAbout = New System.Windows.Forms.MenuItem()
        Me.MenuItem7 = New System.Windows.Forms.MenuItem()
        Me.mnuExit = New System.Windows.Forms.MenuItem()
        Me.cmDeviceImage = New System.Windows.Forms.ContextMenu()
        Me.mnuProfessional = New System.Windows.Forms.MenuItem()
        Me.mnuGamer = New System.Windows.Forms.MenuItem()
        Me.mnuLaptop = New System.Windows.Forms.MenuItem()
        Me.htcMain = New hdd_guardian.HeadlessTabControl()
        Me.tpOverview = New System.Windows.Forms.TabPage()
        Me.lvwDevices = New System.Windows.Forms.ListView()
        Me.chName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chTemp = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chRemaningLife = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chType = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chSize = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tlpMenuItems = New System.Windows.Forms.TableLayoutPanel()
        Me.rbtUpdateAll = New hdd_guardian.RibbonButton()
        Me.rbtRescanUsb = New hdd_guardian.RibbonButton()
        Me.rbtAddVirtual = New hdd_guardian.RibbonButton()
        Me.picOverviewHelp = New System.Windows.Forms.PictureBox()
        Me.pnlInfo = New System.Windows.Forms.Panel()
        Me.picSeparator = New System.Windows.Forms.PictureBox()
        Me.tlpDeviceInfo = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpInfoPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.lblManufacturer = New System.Windows.Forms.Label()
        Me.lblDeviceName = New System.Windows.Forms.Label()
        Me.lblSerialNumber = New System.Windows.Forms.Label()
        Me.lblDeviceLocation = New System.Windows.Forms.Label()
        Me.lblDeviceSize = New System.Windows.Forms.Label()
        Me.lnkManufacturer = New System.Windows.Forms.LinkLabel()
        Me.lblSerialNumberValue = New System.Windows.Forms.Label()
        Me.lblFirmwareValue = New System.Windows.Forms.Label()
        Me.lblTempInfo = New System.Windows.Forms.Label()
        Me.lblTempInfoValue = New System.Windows.Forms.Label()
        Me.lblLife = New System.Windows.Forms.Label()
        Me.lblLifeValue = New System.Windows.Forms.Label()
        Me.lblAtaErrorsValue = New System.Windows.Forms.Label()
        Me.lblBadSectorsInfoValue = New System.Windows.Forms.Label()
        Me.lblHealthInfoValue = New System.Windows.Forms.Label()
        Me.lblHealthInfo = New System.Windows.Forms.Label()
        Me.lblBadSectorsInfo = New hdd_guardian.ExtendedLabel()
        Me.lblAtaErrors = New hdd_guardian.ExtendedLabel()
        Me.lblFirmware = New hdd_guardian.ExtendedLabel()
        Me.picReliability = New System.Windows.Forms.PictureBox()
        Me.lblReliability = New System.Windows.Forms.Label()
        Me.lblWorkTime = New System.Windows.Forms.Label()
        Me.lblWorkTimeValue = New System.Windows.Forms.Label()
        Me.picDeviceImage = New System.Windows.Forms.PictureBox()
        Me.tpManage = New System.Windows.Forms.TabPage()
        Me.htcManage = New hdd_guardian.HeadlessTabControl()
        Me.tpInfo = New System.Windows.Forms.TabPage()
        Me.htcInfo = New hdd_guardian.HeadlessTabControl()
        Me.tpAtaHealth = New System.Windows.Forms.TabPage()
        Me.tlpHealthStatus = New System.Windows.Forms.TableLayoutPanel()
        Me.lblRating4 = New System.Windows.Forms.Label()
        Me.lblRating3 = New System.Windows.Forms.Label()
        Me.lblRating2 = New System.Windows.Forms.Label()
        Me.lblRating1 = New System.Windows.Forms.Label()
        Me.lblBadSectors = New System.Windows.Forms.Label()
        Me.lblTempValue = New System.Windows.Forms.Label()
        Me.lblHealthStatus = New System.Windows.Forms.Label()
        Me.lblReliabilityRating = New System.Windows.Forms.Label()
        Me.lblTemperature = New System.Windows.Forms.Label()
        Me.lblHealth = New System.Windows.Forms.Label()
        Me.lblLastTest = New System.Windows.Forms.Label()
        Me.lblRemainingLife = New System.Windows.Forms.Label()
        Me.lblRemainingLifeValue = New System.Windows.Forms.Label()
        Me.lblLastTestValue = New System.Windows.Forms.Label()
        Me.lblHealthValue = New System.Windows.Forms.Label()
        Me.lblErrorsAta = New System.Windows.Forms.Label()
        Me.tlpRating1 = New System.Windows.Forms.TableLayoutPanel()
        Me.picRating1 = New System.Windows.Forms.PictureBox()
        Me.lblRating1Value = New System.Windows.Forms.Label()
        Me.tlpRating2 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblRating2Value = New System.Windows.Forms.Label()
        Me.picRating2 = New System.Windows.Forms.PictureBox()
        Me.tlpRating3 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblRating3Value = New System.Windows.Forms.Label()
        Me.picRating3 = New System.Windows.Forms.PictureBox()
        Me.tlpRating4 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblRating4Value = New System.Windows.Forms.Label()
        Me.picRating4 = New System.Windows.Forms.PictureBox()
        Me.lblLastUpdate = New System.Windows.Forms.Label()
        Me.lblLastUpdateValue = New System.Windows.Forms.Label()
        Me.lblAtaWorkTime = New System.Windows.Forms.Label()
        Me.lblAtaWorkTimeValue = New System.Windows.Forms.Label()
        Me.tpAtaInfo = New System.Windows.Forms.TabPage()
        Me.tlpAtaInfoPanels = New System.Windows.Forms.TableLayoutPanel()
        Me.picManufacturer = New System.Windows.Forms.PictureBox()
        Me.flwManufacturer = New System.Windows.Forms.FlowLayoutPanel()
        Me.lnkAtaManufacturer = New hdd_guardian.NewLink()
        Me.lblModel = New System.Windows.Forms.Label()
        Me.lblFamily = New System.Windows.Forms.Label()
        Me.lblDevice = New System.Windows.Forms.Label()
        Me.lblDatabase = New System.Windows.Forms.Label()
        Me.tlpDatabaseValue = New System.Windows.Forms.TableLayoutPanel()
        Me.lblInDatabase = New System.Windows.Forms.Label()
        Me.lnkUpdateDatabase = New hdd_guardian.NewLink()
        Me.tlpAtaDevice = New System.Windows.Forms.TableLayoutPanel()
        Me.lblSerial = New System.Windows.Forms.Label()
        Me.lblSmartStatus = New System.Windows.Forms.Label()
        Me.lblSataVersionValue = New System.Windows.Forms.Label()
        Me.lblWWN = New System.Windows.Forms.Label()
        Me.lblFirmwareInfo = New System.Windows.Forms.Label()
        Me.lblTotalSize = New System.Windows.Forms.Label()
        Me.lblSectorSize = New System.Windows.Forms.Label()
        Me.lblRotation = New System.Windows.Forms.Label()
        Me.lblAtaVersion = New System.Windows.Forms.Label()
        Me.lblSataVersion = New System.Windows.Forms.Label()
        Me.lblSerialValue = New System.Windows.Forms.Label()
        Me.lblWwnValue = New System.Windows.Forms.Label()
        Me.lblFirmwareInfoValue = New System.Windows.Forms.Label()
        Me.lblTotalSizeValue = New System.Windows.Forms.Label()
        Me.lblSectorSizeValue = New System.Windows.Forms.Label()
        Me.lblRotationValue = New System.Windows.Forms.Label()
        Me.lblAtaVersionValue = New System.Windows.Forms.Label()
        Me.lblSmartStatusValue = New System.Windows.Forms.Label()
        Me.lblForm = New System.Windows.Forms.Label()
        Me.lblFormValue = New System.Windows.Forms.Label()
        Me.lblWarnings = New System.Windows.Forms.Label()
        Me.tpAtaSmartAttributes = New System.Windows.Forms.TabPage()
        Me.tlpAttributes = New System.Windows.Forms.TableLayoutPanel()
        Me.lvwSmart = New System.Windows.Forms.ListView()
        Me.chStatus = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chAttribute = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chCurrent = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chWorst = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chThreshold = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chRawValue = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.pnlAttribuesInfo = New System.Windows.Forms.Panel()
        Me.tlpAttributeDetails = New System.Windows.Forms.TableLayoutPanel()
        Me.lblMeaning = New System.Windows.Forms.Label()
        Me.lblDataStructure = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.tlpGraph = New System.Windows.Forms.TableLayoutPanel()
        Me.lblThreshold = New System.Windows.Forms.Label()
        Me.lblCurValue = New System.Windows.Forms.Label()
        Me.fpbWorst = New hdd_guardian.FlatProgressBar()
        Me.lblWorst = New System.Windows.Forms.Label()
        Me.fpbCurValue = New hdd_guardian.FlatProgressBar()
        Me.fpbThreshold = New hdd_guardian.FlatProgressBar()
        Me.lblPrefailure = New System.Windows.Forms.Label()
        Me.lblOnline = New System.Windows.Forms.Label()
        Me.lblSpeed = New System.Windows.Forms.Label()
        Me.lblErrRate = New System.Windows.Forms.Label()
        Me.lblEvCount = New System.Windows.Forms.Label()
        Me.lblSelfPres = New System.Windows.Forms.Label()
        Me.lblFlags = New System.Windows.Forms.Label()
        Me.lblGraph = New System.Windows.Forms.Label()
        Me.tpScsiHealth = New System.Windows.Forms.TabPage()
        Me.tlpScsiHealth = New System.Windows.Forms.TableLayoutPanel()
        Me.lblScsiHealth = New System.Windows.Forms.Label()
        Me.lblScsiGrownDefects = New System.Windows.Forms.Label()
        Me.lblScsiOverallHealth = New System.Windows.Forms.Label()
        Me.lblScsiTempValue = New System.Windows.Forms.Label()
        Me.lblScsiTemp = New System.Windows.Forms.Label()
        Me.lblScsiLastTest = New System.Windows.Forms.Label()
        Me.lblScsiHealthValue = New System.Windows.Forms.Label()
        Me.lblScsiLastTestValue = New System.Windows.Forms.Label()
        Me.lblScsiErrors = New System.Windows.Forms.Label()
        Me.lblScsiLastUpdateValue = New System.Windows.Forms.Label()
        Me.lblScsiLastUpdate = New System.Windows.Forms.Label()
        Me.lblScsiWorkTime = New System.Windows.Forms.Label()
        Me.lblScsiWorkTimeValue = New System.Windows.Forms.Label()
        Me.tpScsiInfo = New System.Windows.Forms.TabPage()
        Me.tlpScsiInfoContainer = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpScsiInfo = New System.Windows.Forms.TableLayoutPanel()
        Me.lblScsiSmartStatusValue = New System.Windows.Forms.Label()
        Me.lblScsiProtocolValue = New System.Windows.Forms.Label()
        Me.lblScsiRotationValue = New System.Windows.Forms.Label()
        Me.lblScsiSmartStatus = New System.Windows.Forms.Label()
        Me.lblScsiBlockSizeValue = New System.Windows.Forms.Label()
        Me.lblScsiTotalSizeValue = New System.Windows.Forms.Label()
        Me.lblScsiUnitIdValue = New System.Windows.Forms.Label()
        Me.lblScsiSerialValue = New System.Windows.Forms.Label()
        Me.lblScsiRevisionValue = New System.Windows.Forms.Label()
        Me.lblScsiProtocol = New System.Windows.Forms.Label()
        Me.lblScsiRotation = New System.Windows.Forms.Label()
        Me.lblScsiUnitId = New System.Windows.Forms.Label()
        Me.lblScsiSerial = New System.Windows.Forms.Label()
        Me.lblScsiRevision = New System.Windows.Forms.Label()
        Me.lblScsiTotalSize = New System.Windows.Forms.Label()
        Me.lblScsiBlockSize = New System.Windows.Forms.Label()
        Me.flwScsiVendor = New System.Windows.Forms.FlowLayoutPanel()
        Me.lnkVendor = New hdd_guardian.NewLink()
        Me.lblScsiModel = New System.Windows.Forms.Label()
        Me.picScsiVendor = New System.Windows.Forms.PictureBox()
        Me.tpEventsLog = New System.Windows.Forms.TabPage()
        Me.tlpLogViewerContent = New System.Windows.Forms.TableLayoutPanel()
        Me.lvwLog = New System.Windows.Forms.ListView()
        Me.chAttrLog = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chTime = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chFrom = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chTo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chVariation = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tlpLogViewer = New System.Windows.Forms.TableLayoutPanel()
        Me.btnSaveLog = New System.Windows.Forms.Button()
        Me.btnCopy = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.dteLog = New System.Windows.Forms.DateTimePicker()
        Me.btnToday = New System.Windows.Forms.Button()
        Me.btnPrev = New System.Windows.Forms.Button()
        Me.btnReload = New System.Windows.Forms.Button()
        Me.lblLogItems = New System.Windows.Forms.Label()
        Me.tpEventsChart = New System.Windows.Forms.TabPage()
        Me.tlpChartContent = New System.Windows.Forms.TableLayoutPanel()
        Me.chrChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.lblChartCount = New System.Windows.Forms.Label()
        Me.lvwChart = New System.Windows.Forms.ListView()
        Me.chDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chFromGraph = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chToGraph = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chVariationGraph = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tlpChart = New System.Windows.Forms.TableLayoutPanel()
        Me.cboChartEvents = New System.Windows.Forms.ComboBox()
        Me.lblEvents = New System.Windows.Forms.Label()
        Me.tpTemperatures = New System.Windows.Forms.TabPage()
        Me.tlpTemperatures = New System.Windows.Forms.TableLayoutPanel()
        Me.lblAdminTemperatures = New System.Windows.Forms.Label()
        Me.HorizontalLine9 = New hdd_guardian.HorizontalLine()
        Me.tlpTempGraphs = New System.Windows.Forms.TableLayoutPanel()
        Me.lblLifeTimeMax = New System.Windows.Forms.Label()
        Me.lblCurrentTemp = New System.Windows.Forms.Label()
        Me.lblCycleMin = New System.Windows.Forms.Label()
        Me.lblMin = New System.Windows.Forms.Label()
        Me.lblMax = New System.Windows.Forms.Label()
        Me.lblCycleMax = New System.Windows.Forms.Label()
        Me.lblRecommendedMax = New System.Windows.Forms.Label()
        Me.lblLimitMax = New System.Windows.Forms.Label()
        Me.lblCycle = New System.Windows.Forms.Label()
        Me.lblLifeTime = New System.Windows.Forms.Label()
        Me.lblLifeTimeMin = New System.Windows.Forms.Label()
        Me.lblRecommendedMin = New System.Windows.Forms.Label()
        Me.lblLimitMin = New System.Windows.Forms.Label()
        Me.lblRecommended = New System.Windows.Forms.Label()
        Me.lblLimit = New System.Windows.Forms.Label()
        Me.lblCurrentTempValue = New System.Windows.Forms.Label()
        Me.tbCycle = New hdd_guardian.TemperaturesBar()
        Me.tbLifeTime = New hdd_guardian.TemperaturesBar()
        Me.tbRecommended = New hdd_guardian.TemperaturesBar()
        Me.tbLimit = New hdd_guardian.TemperaturesBar()
        Me.lblZero = New System.Windows.Forms.Label()
        Me.lblTempMeans = New System.Windows.Forms.Label()
        Me.tlpTempMeans = New System.Windows.Forms.TableLayoutPanel()
        Me.lblLimitValue = New System.Windows.Forms.Label()
        Me.lblLimitMean = New System.Windows.Forms.Label()
        Me.lblCycleMeans = New System.Windows.Forms.Label()
        Me.lblLifeTimeMean = New System.Windows.Forms.Label()
        Me.lblRecommendedMean = New System.Windows.Forms.Label()
        Me.lblCycleValue = New System.Windows.Forms.Label()
        Me.lblLifeTimeValue = New System.Windows.Forms.Label()
        Me.lblRecommendedValue = New System.Windows.Forms.Label()
        Me.tpSetup = New System.Windows.Forms.TabPage()
        Me.htcSetup = New hdd_guardian.HeadlessTabControl()
        Me.tpAtaSmartSetup = New System.Windows.Forms.TabPage()
        Me.tlpAtaSmart = New System.Windows.Forms.TableLayoutPanel()
        Me.lblSmart = New System.Windows.Forms.Label()
        Me.lblAdminSmart = New System.Windows.Forms.Label()
        Me.lblOfflineTest = New System.Windows.Forms.Label()
        Me.lblAttrAutosave = New System.Windows.Forms.Label()
        Me.chkEnableSmart = New System.Windows.Forms.CheckBox()
        Me.chkEnableOffline = New System.Windows.Forms.CheckBox()
        Me.chkEnableAutosave = New System.Windows.Forms.CheckBox()
        Me.HorizontalLine2 = New hdd_guardian.HorizontalLine()
        Me.tpScsiSmartSetup = New System.Windows.Forms.TabPage()
        Me.tlpScsiSmart = New System.Windows.Forms.TableLayoutPanel()
        Me.lblAdminScsiSmart = New System.Windows.Forms.Label()
        Me.lblScsiGltsd = New System.Windows.Forms.Label()
        Me.lblScsiRCache = New System.Windows.Forms.Label()
        Me.chkScsiRCache = New System.Windows.Forms.CheckBox()
        Me.chkScsiWCache = New System.Windows.Forms.CheckBox()
        Me.lblScsiWCache = New System.Windows.Forms.Label()
        Me.chkScsiSmart = New System.Windows.Forms.CheckBox()
        Me.chkScsiGltsd = New System.Windows.Forms.CheckBox()
        Me.lblScsiSmart = New System.Windows.Forms.Label()
        Me.HorizontalLine13 = New hdd_guardian.HorizontalLine()
        Me.tpAtaAam = New System.Windows.Forms.TabPage()
        Me.tlpAtaAam = New System.Windows.Forms.TableLayoutPanel()
        Me.trkAam = New System.Windows.Forms.TrackBar()
        Me.HorizontalLine3 = New hdd_guardian.HorizontalLine()
        Me.lblInfoAam = New System.Windows.Forms.Label()
        Me.tlpAamWaitMessage = New System.Windows.Forms.TableLayoutPanel()
        Me.lblAamWaitMessage = New System.Windows.Forms.Label()
        Me.picLoaderAam = New System.Windows.Forms.PictureBox()
        Me.tpAtaApm = New System.Windows.Forms.TabPage()
        Me.tlpApmContent = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpApmWaitMessage = New System.Windows.Forms.TableLayoutPanel()
        Me.lblApmWaitMessage = New System.Windows.Forms.Label()
        Me.picLoaderApm = New System.Windows.Forms.PictureBox()
        Me.trkApm = New System.Windows.Forms.TrackBar()
        Me.HorizontalLine4 = New hdd_guardian.HorizontalLine()
        Me.lblInfoApm = New System.Windows.Forms.Label()
        Me.tpAtaStandby = New System.Windows.Forms.TabPage()
        Me.tlpStandbyContent = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpStandbyWaitMessage = New System.Windows.Forms.TableLayoutPanel()
        Me.lblStandbyWaitMessage = New System.Windows.Forms.Label()
        Me.picLoaderStandby = New System.Windows.Forms.PictureBox()
        Me.trkStandby = New System.Windows.Forms.TrackBar()
        Me.HorizontalLine5 = New hdd_guardian.HorizontalLine()
        Me.lblInfoStandby = New System.Windows.Forms.Label()
        Me.tpAtaReadWrite = New System.Windows.Forms.TabPage()
        Me.tlpOtherContent = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpWaitRWMessage = New System.Windows.Forms.TableLayoutPanel()
        Me.lblWaitRWMessage = New System.Windows.Forms.Label()
        Me.picLoaderRW = New System.Windows.Forms.PictureBox()
        Me.flwOtherFeatures = New System.Windows.Forms.FlowLayoutPanel()
        Me.chkCache = New System.Windows.Forms.CheckBox()
        Me.lblCacheInfo = New System.Windows.Forms.Label()
        Me.chkCacheReorder = New System.Windows.Forms.CheckBox()
        Me.lblCacheReorderInfo = New System.Windows.Forms.Label()
        Me.chkLookAhead = New System.Windows.Forms.CheckBox()
        Me.lblLookAheadInfo = New System.Windows.Forms.Label()
        Me.lblAdminOther = New System.Windows.Forms.Label()
        Me.HorizontalLine6 = New hdd_guardian.HorizontalLine()
        Me.tpErrorsTests = New System.Windows.Forms.TabPage()
        Me.htcErrorsTests = New hdd_guardian.HeadlessTabControl()
        Me.tpAtaErrors = New System.Windows.Forms.TabPage()
        Me.tlpAtaErrorsContent = New System.Windows.Forms.TableLayoutPanel()
        Me.lblErrLogVer = New System.Windows.Forms.Label()
        Me.flwError = New System.Windows.Forms.FlowLayoutPanel()
        Me.flwErrorLog = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblErrorLog = New System.Windows.Forms.Label()
        Me.optError1 = New System.Windows.Forms.RadioButton()
        Me.optError2 = New System.Windows.Forms.RadioButton()
        Me.optError3 = New System.Windows.Forms.RadioButton()
        Me.optError4 = New System.Windows.Forms.RadioButton()
        Me.optError5 = New System.Windows.Forms.RadioButton()
        Me.lblAdminErrors = New System.Windows.Forms.Label()
        Me.HorizontalLine7 = New hdd_guardian.HorizontalLine()
        Me.tabErrors = New System.Windows.Forms.TabControl()
        Me.tpErrorDescription = New System.Windows.Forms.TabPage()
        Me.tlpErrorDescription = New System.Windows.Forms.TableLayoutPanel()
        Me.lblErrorNumber = New System.Windows.Forms.Label()
        Me.lblErrorNumberValue = New System.Windows.Forms.Label()
        Me.lblErrorSectorsValue = New System.Windows.Forms.Label()
        Me.lblErrorDescriptionValue = New System.Windows.Forms.Label()
        Me.lblErrorElapsedValue = New System.Windows.Forms.Label()
        Me.lblErrorDescription = New System.Windows.Forms.Label()
        Me.lblErrorElapsed = New System.Windows.Forms.Label()
        Me.lblErrorLba = New System.Windows.Forms.Label()
        Me.lblErrorSectors = New System.Windows.Forms.Label()
        Me.lblErrorLbaValue = New System.Windows.Forms.Label()
        Me.lblErrorStatus = New System.Windows.Forms.Label()
        Me.lblErrorStatusValue = New System.Windows.Forms.Label()
        Me.tpErrorDetail = New System.Windows.Forms.TabPage()
        Me.tlpErrorDetail = New System.Windows.Forms.TableLayoutPanel()
        Me.lblPowerOn = New System.Windows.Forms.Label()
        Me.cpCommands = New hdd_guardian.CommandsPanel()
        Me.lblRegisters = New System.Windows.Forms.Label()
        Me.lblDeviceStatus = New System.Windows.Forms.Label()
        Me.lblCommands = New System.Windows.Forms.Label()
        Me.rpRegisters = New hdd_guardian.RegistersPanel()
        Me.tpAtaTests = New System.Windows.Forms.TabPage()
        Me.tlpTestsContent = New System.Windows.Forms.TableLayoutPanel()
        Me.lblAdminTests = New System.Windows.Forms.Label()
        Me.lvwSelective = New System.Windows.Forms.ListView()
        Me.chSpan = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chLbaMin = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chLbaMax = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chCurTestStatus = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvwSelfTest = New System.Windows.Forms.ListView()
        Me.chNum = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chTestType = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chTestStatus = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chRemaining = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chAge = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chFirstError = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tlpSelfTests = New System.Windows.Forms.TableLayoutPanel()
        Me.lblNoSelfTests = New System.Windows.Forms.Label()
        Me.lblSelfTests = New System.Windows.Forms.Label()
        Me.HorizontalLine1 = New hdd_guardian.HorizontalLine()
        Me.tlpSelective = New System.Windows.Forms.TableLayoutPanel()
        Me.lblNoSelective = New System.Windows.Forms.Label()
        Me.lblSelective = New System.Windows.Forms.Label()
        Me.tpAtaRunTest = New System.Windows.Forms.TabPage()
        Me.tlpAtaTestContent = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpTestProgress = New System.Windows.Forms.TableLayoutPanel()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.pnlProgress = New System.Windows.Forms.Panel()
        Me.lblExtimatedEnd = New System.Windows.Forms.Label()
        Me.prbTestProgress = New System.Windows.Forms.ProgressBar()
        Me.lblProgress = New System.Windows.Forms.Label()
        Me.lblInfoTest = New System.Windows.Forms.Label()
        Me.tlpTest = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpTestDetails = New System.Windows.Forms.TableLayoutPanel()
        Me.lblTestInfo = New System.Windows.Forms.Label()
        Me.tlpSelectTest = New System.Windows.Forms.TableLayoutPanel()
        Me.cboTest = New System.Windows.Forms.ComboBox()
        Me.lblSelectTest = New System.Windows.Forms.Label()
        Me.btnRun = New System.Windows.Forms.Button()
        Me.lblDuration = New System.Windows.Forms.Label()
        Me.HorizontalLine8 = New hdd_guardian.HorizontalLine()
        Me.tpScsiErrors = New System.Windows.Forms.TabPage()
        Me.tlpScsiErrorsContent = New System.Windows.Forms.TableLayoutPanel()
        Me.lblScsiNoErrors = New System.Windows.Forms.Label()
        Me.tvwScsiErrors = New System.Windows.Forms.TreeView()
        Me.tpScsiTests = New System.Windows.Forms.TabPage()
        Me.tlpScsiTestsContent = New System.Windows.Forms.TableLayoutPanel()
        Me.lblScsiTestCounter = New System.Windows.Forms.Label()
        Me.lvwScsiTests = New System.Windows.Forms.ListView()
        Me.chScsiNum = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chScsiTest = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chScsiStatus = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chScsiSegment = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chScsiLifetime = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chScsiFirstErr = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chScsiSK = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chScsiASK = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chScsiASQ = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tpScsiRunTest = New System.Windows.Forms.TabPage()
        Me.tlpScsiTestContent = New System.Windows.Forms.TableLayoutPanel()
        Me.lblScsiInfoTest = New System.Windows.Forms.Label()
        Me.tlpScsiTest = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlScsiTestRun = New System.Windows.Forms.Panel()
        Me.lblScsiExtimatedEnd = New System.Windows.Forms.Label()
        Me.prbScsiTestProgress = New System.Windows.Forms.ProgressBar()
        Me.lblScsiProgress = New System.Windows.Forms.Label()
        Me.lblScsiTest = New System.Windows.Forms.Label()
        Me.btnScsiRun = New System.Windows.Forms.Button()
        Me.btnScsiStop = New System.Windows.Forms.Button()
        Me.HorizontalLine14 = New hdd_guardian.HorizontalLine()
        Me.tpSmartctl = New System.Windows.Forms.TabPage()
        Me.htcSmartctl = New hdd_guardian.HeadlessTabControl()
        Me.tpOutput = New System.Windows.Forms.TabPage()
        Me.tlpOutput = New System.Windows.Forms.TableLayoutPanel()
        Me.txtReport = New System.Windows.Forms.TextBox()
        Me.btnSaveOutput = New System.Windows.Forms.Button()
        Me.tpAdvanced = New System.Windows.Forms.TabPage()
        Me.tlpAdvanced = New System.Windows.Forms.TableLayoutPanel()
        Me.HorizontalLine12 = New hdd_guardian.HorizontalLine()
        Me.lblAdminAdvanced = New System.Windows.Forms.Label()
        Me.tabAdvanced = New System.Windows.Forms.TabControl()
        Me.tpPower = New System.Windows.Forms.TabPage()
        Me.tlpPowerModeContent = New System.Windows.Forms.TableLayoutPanel()
        Me.flwPowerMode = New System.Windows.Forms.FlowLayoutPanel()
        Me.rbNever = New System.Windows.Forms.RadioButton()
        Me.lblNever = New System.Windows.Forms.Label()
        Me.rbSleep = New System.Windows.Forms.RadioButton()
        Me.lblSleep = New System.Windows.Forms.Label()
        Me.rbStandby = New System.Windows.Forms.RadioButton()
        Me.lblStandby = New System.Windows.Forms.Label()
        Me.rbIdle = New System.Windows.Forms.RadioButton()
        Me.lblIdle = New System.Windows.Forms.Label()
        Me.lblPowerInfo = New System.Windows.Forms.Label()
        Me.chkPowerMode = New System.Windows.Forms.CheckBox()
        Me.tpRemap = New System.Windows.Forms.TabPage()
        Me.tlpRemapContent = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlAttributes = New System.Windows.Forms.Panel()
        Me.lvwAttrFormat = New System.Windows.Forms.ListView()
        Me.chAttrID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chAttrFormat = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chAttrName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tlpButtons = New System.Windows.Forms.TableLayoutPanel()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.lblRemapInfo = New System.Windows.Forms.Label()
        Me.chkAttributes = New System.Windows.Forms.CheckBox()
        Me.tpFirmware = New System.Windows.Forms.TabPage()
        Me.tlpFirmwareContent = New System.Windows.Forms.TableLayoutPanel()
        Me.flwFirmware = New System.Windows.Forms.FlowLayoutPanel()
        Me.cboFirmware = New System.Windows.Forms.ComboBox()
        Me.lblFirmwareDebug = New System.Windows.Forms.Label()
        Me.chkFixSwap = New System.Windows.Forms.CheckBox()
        Me.lblFixSwap = New System.Windows.Forms.Label()
        Me.chkNoLogDir = New System.Windows.Forms.CheckBox()
        Me.lblNoLogDir = New System.Windows.Forms.Label()
        Me.chkXErrorLba = New System.Windows.Forms.CheckBox()
        Me.lblXErrorLba = New System.Windows.Forms.Label()
        Me.lblFirmwareDebugInfo = New System.Windows.Forms.Label()
        Me.chkFirmware = New System.Windows.Forms.CheckBox()
        Me.RibbonHorizontalSeparator4 = New hdd_guardian.RibbonHorizontalSeparator()
        Me.tlpManageMenuContent = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpSmartctl = New System.Windows.Forms.TableLayoutPanel()
        Me.robOutput = New hdd_guardian.RibbonOptionButton()
        Me.robAdvanced = New hdd_guardian.RibbonOptionButton()
        Me.tlpSetup = New System.Windows.Forms.TableLayoutPanel()
        Me.robSmartSetup = New hdd_guardian.RibbonOptionButton()
        Me.robAam = New hdd_guardian.RibbonOptionButton()
        Me.robApm = New hdd_guardian.RibbonOptionButton()
        Me.robStandby = New hdd_guardian.RibbonOptionButton()
        Me.robReadWrite = New hdd_guardian.RibbonOptionButton()
        Me.tlpErrorsTests = New System.Windows.Forms.TableLayoutPanel()
        Me.robErrorsLog = New hdd_guardian.RibbonOptionButton()
        Me.robTestsLog = New hdd_guardian.RibbonOptionButton()
        Me.robRunTest = New hdd_guardian.RibbonOptionButton()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.lblSetup = New System.Windows.Forms.Label()
        Me.lblErrorsTests = New System.Windows.Forms.Label()
        Me.lblSmartctl = New System.Windows.Forms.Label()
        Me.RibbonVerticalSeparator1 = New hdd_guardian.RibbonVerticalSeparator()
        Me.RibbonVerticalSeparator2 = New hdd_guardian.RibbonVerticalSeparator()
        Me.RibbonVerticalSeparator3 = New hdd_guardian.RibbonVerticalSeparator()
        Me.RibbonVerticalSeparator4 = New hdd_guardian.RibbonVerticalSeparator()
        Me.RibbonVerticalSeparator5 = New hdd_guardian.RibbonVerticalSeparator()
        Me.RibbonVerticalSeparator6 = New hdd_guardian.RibbonVerticalSeparator()
        Me.tlpInfo = New System.Windows.Forms.TableLayoutPanel()
        Me.robAttributes = New hdd_guardian.RibbonOptionButton()
        Me.robEventsLog = New hdd_guardian.RibbonOptionButton()
        Me.robEventsChart = New hdd_guardian.RibbonOptionButton()
        Me.robInfo = New hdd_guardian.RibbonOptionButton()
        Me.robHealth = New hdd_guardian.RibbonOptionButton()
        Me.robTemperatures = New hdd_guardian.RibbonOptionButton()
        Me.RibbonVerticalSeparator8 = New hdd_guardian.RibbonVerticalSeparator()
        Me.RibbonVerticalSeparator9 = New hdd_guardian.RibbonVerticalSeparator()
        Me.RibbonHorizontalSeparator3 = New hdd_guardian.RibbonHorizontalSeparator()
        Me.tlpSelDevice = New System.Windows.Forms.TableLayoutPanel()
        Me.lblSelDevice = New System.Windows.Forms.Label()
        Me.btnReloadDevice = New System.Windows.Forms.Button()
        Me.pnlComboBorder = New System.Windows.Forms.Panel()
        Me.cboDevices = New System.Windows.Forms.ComboBox()
        Me.picManageHelp = New System.Windows.Forms.PictureBox()
        Me.tpWmiDevices = New System.Windows.Forms.TabPage()
        Me.tvwComputer = New System.Windows.Forms.TreeView()
        Me.pnlWmiInfo = New System.Windows.Forms.Panel()
        Me.picWmiSeparator = New System.Windows.Forms.PictureBox()
        Me.tlpWmiInfo = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpWmiDetails = New System.Windows.Forms.TableLayoutPanel()
        Me.lblInfo1 = New System.Windows.Forms.Label()
        Me.lblInfo8Value = New System.Windows.Forms.Label()
        Me.lblInfo7Value = New System.Windows.Forms.Label()
        Me.lblInfo6Value = New System.Windows.Forms.Label()
        Me.lblInfo5Value = New System.Windows.Forms.Label()
        Me.lblInfo5 = New System.Windows.Forms.Label()
        Me.lblInfo6 = New System.Windows.Forms.Label()
        Me.lblInfo7 = New System.Windows.Forms.Label()
        Me.lblInfo8 = New System.Windows.Forms.Label()
        Me.lblInfo4Value = New System.Windows.Forms.Label()
        Me.lblInfo3Value = New System.Windows.Forms.Label()
        Me.lblInfo2Value = New System.Windows.Forms.Label()
        Me.lblInfo1Value = New System.Windows.Forms.Label()
        Me.lblInfo4 = New System.Windows.Forms.Label()
        Me.lblInfo3 = New System.Windows.Forms.Label()
        Me.lblInfo2 = New System.Windows.Forms.Label()
        Me.picWmi = New System.Windows.Forms.PictureBox()
        Me.RibbonHorizontalSeparator6 = New hdd_guardian.RibbonHorizontalSeparator()
        Me.tlpWmiMenuItems = New System.Windows.Forms.TableLayoutPanel()
        Me.rbtRefresh = New hdd_guardian.RibbonButton()
        Me.picWmiDevicesHelp = New System.Windows.Forms.PictureBox()
        Me.tlpLoadWmi = New System.Windows.Forms.TableLayoutPanel()
        Me.lblLoadWmi = New System.Windows.Forms.Label()
        Me.picLoadWmi = New System.Windows.Forms.PictureBox()
        Me.tpDebug = New System.Windows.Forms.TabPage()
        Me.tlpDebug = New System.Windows.Forms.TableLayoutPanel()
        Me.lvwProgLog = New System.Windows.Forms.ListView()
        Me.chLogDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chEvent = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tlpDebugMenu = New System.Windows.Forms.TableLayoutPanel()
        Me.rbtSaveDebug = New hdd_guardian.RibbonButton()
        Me.rbtClean = New hdd_guardian.RibbonButton()
        Me.RibbonHorizontalSeparator5 = New hdd_guardian.RibbonHorizontalSeparator()
        Me.RibbonHorizontalSeparator1 = New hdd_guardian.RibbonHorizontalSeparator()
        MenuItem4 = New System.Windows.Forms.MenuItem()
        MenuItem2 = New System.Windows.Forms.MenuItem()
        MenuItem5 = New System.Windows.Forms.MenuItem()
        tlpRibbonMenu = New System.Windows.Forms.TableLayoutPanel()
        RibbonHorizontalSeparator2 = New hdd_guardian.RibbonHorizontalSeparator()
        flwWarnings = New System.Windows.Forms.FlowLayoutPanel()
        tlpAam = New System.Windows.Forms.TableLayoutPanel()
        tlpAamLoud = New System.Windows.Forms.TableLayoutPanel()
        tlpApm = New System.Windows.Forms.TableLayoutPanel()
        tlpStandby = New System.Windows.Forms.TableLayoutPanel()
        tlpRibbonMenu.SuspendLayout()
        Me.tlpMessages.SuspendLayout()
        CType(Me.picAdmin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picNewVersion, System.ComponentModel.ISupportInitialize).BeginInit()
        flwWarnings.SuspendLayout()
        tlpAam.SuspendLayout()
        tlpAamLoud.SuspendLayout()
        tlpApm.SuspendLayout()
        tlpStandby.SuspendLayout()
        Me.htcMain.SuspendLayout()
        Me.tpOverview.SuspendLayout()
        Me.tlpMenuItems.SuspendLayout()
        CType(Me.picOverviewHelp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlInfo.SuspendLayout()
        CType(Me.picSeparator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpDeviceInfo.SuspendLayout()
        Me.tlpInfoPanel.SuspendLayout()
        CType(Me.picReliability, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDeviceImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpManage.SuspendLayout()
        Me.htcManage.SuspendLayout()
        Me.tpInfo.SuspendLayout()
        Me.htcInfo.SuspendLayout()
        Me.tpAtaHealth.SuspendLayout()
        Me.tlpHealthStatus.SuspendLayout()
        Me.tlpRating1.SuspendLayout()
        CType(Me.picRating1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpRating2.SuspendLayout()
        CType(Me.picRating2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpRating3.SuspendLayout()
        CType(Me.picRating3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpRating4.SuspendLayout()
        CType(Me.picRating4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpAtaInfo.SuspendLayout()
        Me.tlpAtaInfoPanels.SuspendLayout()
        CType(Me.picManufacturer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.flwManufacturer.SuspendLayout()
        Me.tlpDatabaseValue.SuspendLayout()
        Me.tlpAtaDevice.SuspendLayout()
        Me.tpAtaSmartAttributes.SuspendLayout()
        Me.tlpAttributes.SuspendLayout()
        Me.pnlAttribuesInfo.SuspendLayout()
        Me.tlpAttributeDetails.SuspendLayout()
        Me.tlpGraph.SuspendLayout()
        Me.tpScsiHealth.SuspendLayout()
        Me.tlpScsiHealth.SuspendLayout()
        Me.tpScsiInfo.SuspendLayout()
        Me.tlpScsiInfoContainer.SuspendLayout()
        Me.tlpScsiInfo.SuspendLayout()
        Me.flwScsiVendor.SuspendLayout()
        CType(Me.picScsiVendor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpEventsLog.SuspendLayout()
        Me.tlpLogViewerContent.SuspendLayout()
        Me.tlpLogViewer.SuspendLayout()
        Me.tpEventsChart.SuspendLayout()
        Me.tlpChartContent.SuspendLayout()
        CType(Me.chrChart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpChart.SuspendLayout()
        Me.tpTemperatures.SuspendLayout()
        Me.tlpTemperatures.SuspendLayout()
        CType(Me.HorizontalLine9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpTempGraphs.SuspendLayout()
        Me.tlpTempMeans.SuspendLayout()
        Me.tpSetup.SuspendLayout()
        Me.htcSetup.SuspendLayout()
        Me.tpAtaSmartSetup.SuspendLayout()
        Me.tlpAtaSmart.SuspendLayout()
        CType(Me.HorizontalLine2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpScsiSmartSetup.SuspendLayout()
        Me.tlpScsiSmart.SuspendLayout()
        CType(Me.HorizontalLine13, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpAtaAam.SuspendLayout()
        Me.tlpAtaAam.SuspendLayout()
        CType(Me.trkAam, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HorizontalLine3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpAamWaitMessage.SuspendLayout()
        CType(Me.picLoaderAam, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpAtaApm.SuspendLayout()
        Me.tlpApmContent.SuspendLayout()
        Me.tlpApmWaitMessage.SuspendLayout()
        CType(Me.picLoaderApm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trkApm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HorizontalLine4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpAtaStandby.SuspendLayout()
        Me.tlpStandbyContent.SuspendLayout()
        Me.tlpStandbyWaitMessage.SuspendLayout()
        CType(Me.picLoaderStandby, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trkStandby, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HorizontalLine5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpAtaReadWrite.SuspendLayout()
        Me.tlpOtherContent.SuspendLayout()
        Me.tlpWaitRWMessage.SuspendLayout()
        CType(Me.picLoaderRW, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.flwOtherFeatures.SuspendLayout()
        CType(Me.HorizontalLine6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpErrorsTests.SuspendLayout()
        Me.htcErrorsTests.SuspendLayout()
        Me.tpAtaErrors.SuspendLayout()
        Me.tlpAtaErrorsContent.SuspendLayout()
        Me.flwError.SuspendLayout()
        Me.flwErrorLog.SuspendLayout()
        CType(Me.HorizontalLine7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabErrors.SuspendLayout()
        Me.tpErrorDescription.SuspendLayout()
        Me.tlpErrorDescription.SuspendLayout()
        Me.tpErrorDetail.SuspendLayout()
        Me.tlpErrorDetail.SuspendLayout()
        Me.tpAtaTests.SuspendLayout()
        Me.tlpTestsContent.SuspendLayout()
        Me.tlpSelfTests.SuspendLayout()
        CType(Me.HorizontalLine1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpSelective.SuspendLayout()
        Me.tpAtaRunTest.SuspendLayout()
        Me.tlpAtaTestContent.SuspendLayout()
        Me.tlpTestProgress.SuspendLayout()
        Me.pnlProgress.SuspendLayout()
        Me.tlpTest.SuspendLayout()
        Me.tlpTestDetails.SuspendLayout()
        Me.tlpSelectTest.SuspendLayout()
        CType(Me.HorizontalLine8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpScsiErrors.SuspendLayout()
        Me.tlpScsiErrorsContent.SuspendLayout()
        Me.tpScsiTests.SuspendLayout()
        Me.tlpScsiTestsContent.SuspendLayout()
        Me.tpScsiRunTest.SuspendLayout()
        Me.tlpScsiTestContent.SuspendLayout()
        Me.tlpScsiTest.SuspendLayout()
        Me.pnlScsiTestRun.SuspendLayout()
        CType(Me.HorizontalLine14, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpSmartctl.SuspendLayout()
        Me.htcSmartctl.SuspendLayout()
        Me.tpOutput.SuspendLayout()
        Me.tlpOutput.SuspendLayout()
        Me.tpAdvanced.SuspendLayout()
        Me.tlpAdvanced.SuspendLayout()
        CType(Me.HorizontalLine12, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabAdvanced.SuspendLayout()
        Me.tpPower.SuspendLayout()
        Me.tlpPowerModeContent.SuspendLayout()
        Me.flwPowerMode.SuspendLayout()
        Me.tpRemap.SuspendLayout()
        Me.tlpRemapContent.SuspendLayout()
        Me.pnlAttributes.SuspendLayout()
        Me.tlpButtons.SuspendLayout()
        Me.tpFirmware.SuspendLayout()
        Me.tlpFirmwareContent.SuspendLayout()
        Me.flwFirmware.SuspendLayout()
        Me.tlpManageMenuContent.SuspendLayout()
        Me.tlpSmartctl.SuspendLayout()
        Me.tlpSetup.SuspendLayout()
        Me.tlpErrorsTests.SuspendLayout()
        Me.tlpInfo.SuspendLayout()
        Me.tlpSelDevice.SuspendLayout()
        Me.pnlComboBorder.SuspendLayout()
        CType(Me.picManageHelp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpWmiDevices.SuspendLayout()
        Me.pnlWmiInfo.SuspendLayout()
        CType(Me.picWmiSeparator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpWmiInfo.SuspendLayout()
        Me.tlpWmiDetails.SuspendLayout()
        CType(Me.picWmi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpWmiMenuItems.SuspendLayout()
        CType(Me.picWmiDevicesHelp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpLoadWmi.SuspendLayout()
        CType(Me.picLoadWmi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpDebug.SuspendLayout()
        Me.tlpDebug.SuspendLayout()
        Me.tlpDebugMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuItem4
        '
        MenuItem4.Index = 1
        MenuItem4.Text = "-"
        '
        'MenuItem2
        '
        MenuItem2.Index = 4
        MenuItem2.Text = "-"
        '
        'MenuItem5
        '
        MenuItem5.Index = 6
        MenuItem5.Text = "-"
        '
        'tlpRibbonMenu
        '
        tlpRibbonMenu.AutoSize = True
        tlpRibbonMenu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        tlpRibbonMenu.BackColor = System.Drawing.Color.Transparent
        tlpRibbonMenu.ColumnCount = 6
        tlpRibbonMenu.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        tlpRibbonMenu.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        tlpRibbonMenu.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        tlpRibbonMenu.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        tlpRibbonMenu.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        tlpRibbonMenu.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        tlpRibbonMenu.Controls.Add(Me.rfiFile, 0, 0)
        tlpRibbonMenu.Controls.Add(Me.rmiOverview, 1, 0)
        tlpRibbonMenu.Controls.Add(Me.rmiManage, 2, 0)
        tlpRibbonMenu.Controls.Add(Me.rmiWmiDevices, 3, 0)
        tlpRibbonMenu.Controls.Add(Me.tlpMessages, 5, 0)
        tlpRibbonMenu.Controls.Add(Me.rmiDebug, 4, 0)
        tlpRibbonMenu.Dock = System.Windows.Forms.DockStyle.Top
        tlpRibbonMenu.Location = New System.Drawing.Point(0, 0)
        tlpRibbonMenu.Name = "tlpRibbonMenu"
        tlpRibbonMenu.RowCount = 1
        tlpRibbonMenu.RowStyles.Add(New System.Windows.Forms.RowStyle())
        tlpRibbonMenu.Size = New System.Drawing.Size(892, 31)
        tlpRibbonMenu.TabIndex = 39
        '
        'rfiFile
        '
        Me.rfiFile.AutoSize = True
        Me.rfiFile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.rfiFile.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.rfiFile.Location = New System.Drawing.Point(2, 2)
        Me.rfiFile.Margin = New System.Windows.Forms.Padding(2)
        Me.rfiFile.Name = "rfiFile"
        Me.rfiFile.Size = New System.Drawing.Size(41, 27)
        Me.rfiFile.TabIndex = 0
        Me.rfiFile.Text = "rfiFile"
        '
        'rmiOverview
        '
        Me.rmiOverview.AutoSize = True
        Me.rmiOverview.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.rmiOverview.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rmiOverview.ForeColor = System.Drawing.Color.Black
        Me.rmiOverview.Location = New System.Drawing.Point(47, 2)
        Me.rmiOverview.Margin = New System.Windows.Forms.Padding(2)
        Me.rmiOverview.Name = "rmiOverview"
        Me.rmiOverview.Size = New System.Drawing.Size(75, 27)
        Me.rmiOverview.TabIndex = 5
        Me.rmiOverview.Text = "rmiOverview"
        '
        'rmiManage
        '
        Me.rmiManage.AutoSize = True
        Me.rmiManage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.rmiManage.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rmiManage.ForeColor = System.Drawing.Color.Black
        Me.rmiManage.Location = New System.Drawing.Point(126, 2)
        Me.rmiManage.Margin = New System.Windows.Forms.Padding(2)
        Me.rmiManage.Name = "rmiManage"
        Me.rmiManage.Size = New System.Drawing.Size(67, 27)
        Me.rmiManage.TabIndex = 6
        Me.rmiManage.Text = "rmiManage"
        '
        'rmiWmiDevices
        '
        Me.rmiWmiDevices.AutoSize = True
        Me.rmiWmiDevices.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.rmiWmiDevices.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rmiWmiDevices.ForeColor = System.Drawing.Color.Black
        Me.rmiWmiDevices.Location = New System.Drawing.Point(197, 2)
        Me.rmiWmiDevices.Margin = New System.Windows.Forms.Padding(2)
        Me.rmiWmiDevices.Name = "rmiWmiDevices"
        Me.rmiWmiDevices.Size = New System.Drawing.Size(86, 27)
        Me.rmiWmiDevices.TabIndex = 7
        Me.rmiWmiDevices.Text = "rmiWmiDevices"
        '
        'tlpMessages
        '
        Me.tlpMessages.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.tlpMessages.AutoSize = True
        Me.tlpMessages.ColumnCount = 2
        Me.tlpMessages.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMessages.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMessages.Controls.Add(Me.picAdmin, 0, 0)
        Me.tlpMessages.Controls.Add(Me.picNewVersion, 1, 0)
        Me.tlpMessages.Location = New System.Drawing.Point(845, 4)
        Me.tlpMessages.Name = "tlpMessages"
        Me.tlpMessages.RowCount = 1
        Me.tlpMessages.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMessages.Size = New System.Drawing.Size(44, 22)
        Me.tlpMessages.TabIndex = 3
        '
        'picAdmin
        '
        Me.picAdmin.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.picAdmin.Location = New System.Drawing.Point(3, 3)
        Me.picAdmin.Name = "picAdmin"
        Me.picAdmin.Size = New System.Drawing.Size(16, 16)
        Me.picAdmin.TabIndex = 8
        Me.picAdmin.TabStop = False
        '
        'picNewVersion
        '
        Me.picNewVersion.Location = New System.Drawing.Point(25, 3)
        Me.picNewVersion.Name = "picNewVersion"
        Me.picNewVersion.Size = New System.Drawing.Size(16, 16)
        Me.picNewVersion.TabIndex = 9
        Me.picNewVersion.TabStop = False
        '
        'rmiDebug
        '
        Me.rmiDebug.AutoSize = True
        Me.rmiDebug.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.rmiDebug.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rmiDebug.ForeColor = System.Drawing.Color.Black
        Me.rmiDebug.Location = New System.Drawing.Point(287, 2)
        Me.rmiDebug.Margin = New System.Windows.Forms.Padding(2)
        Me.rmiDebug.Name = "rmiDebug"
        Me.rmiDebug.Size = New System.Drawing.Size(60, 27)
        Me.rmiDebug.TabIndex = 8
        Me.rmiDebug.Text = "rmiDebug"
        '
        'RibbonHorizontalSeparator2
        '
        RibbonHorizontalSeparator2.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(220, Byte), Integer))
        RibbonHorizontalSeparator2.Dock = System.Windows.Forms.DockStyle.Top
        RibbonHorizontalSeparator2.Location = New System.Drawing.Point(0, 78)
        RibbonHorizontalSeparator2.MaximumSize = New System.Drawing.Size(0, 1)
        RibbonHorizontalSeparator2.MinimumSize = New System.Drawing.Size(80, 1)
        RibbonHorizontalSeparator2.Name = "RibbonHorizontalSeparator2"
        RibbonHorizontalSeparator2.Size = New System.Drawing.Size(884, 1)
        RibbonHorizontalSeparator2.TabIndex = 25
        '
        'flwWarnings
        '
        flwWarnings.AutoSize = True
        flwWarnings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        flwWarnings.Controls.Add(Me.lblWarningValue)
        flwWarnings.Controls.Add(Me.lnkWeb1)
        flwWarnings.Controls.Add(Me.lnkWeb2)
        flwWarnings.Controls.Add(Me.lnkWeb3)
        flwWarnings.Location = New System.Drawing.Point(176, 308)
        flwWarnings.Margin = New System.Windows.Forms.Padding(0)
        flwWarnings.Name = "flwWarnings"
        flwWarnings.Size = New System.Drawing.Size(143, 64)
        flwWarnings.TabIndex = 50
        '
        'lblWarningValue
        '
        Me.lblWarningValue.AutoSize = True
        flwWarnings.SetFlowBreak(Me.lblWarningValue, True)
        Me.lblWarningValue.ForeColor = System.Drawing.Color.Black
        Me.lblWarningValue.Location = New System.Drawing.Point(3, 0)
        Me.lblWarningValue.Name = "lblWarningValue"
        Me.lblWarningValue.Size = New System.Drawing.Size(83, 13)
        Me.lblWarningValue.TabIndex = 14
        Me.lblWarningValue.Text = "lblWarningValue"
        '
        'lnkWeb1
        '
        Me.lnkWeb1.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lnkWeb1.AutoSize = True
        flwWarnings.SetFlowBreak(Me.lnkWeb1, True)
        Me.lnkWeb1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lnkWeb1.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lnkWeb1.Location = New System.Drawing.Point(3, 16)
        Me.lnkWeb1.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.lnkWeb1.Name = "lnkWeb1"
        Me.lnkWeb1.Size = New System.Drawing.Size(48, 13)
        Me.lnkWeb1.TabIndex = 45
        Me.lnkWeb1.TabStop = True
        Me.lnkWeb1.Text = "lnkWeb1"
        '
        'lnkWeb2
        '
        Me.lnkWeb2.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lnkWeb2.AutoSize = True
        flwWarnings.SetFlowBreak(Me.lnkWeb2, True)
        Me.lnkWeb2.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lnkWeb2.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lnkWeb2.Location = New System.Drawing.Point(3, 32)
        Me.lnkWeb2.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.lnkWeb2.Name = "lnkWeb2"
        Me.lnkWeb2.Size = New System.Drawing.Size(48, 13)
        Me.lnkWeb2.TabIndex = 46
        Me.lnkWeb2.TabStop = True
        Me.lnkWeb2.Text = "lnkWeb2"
        '
        'lnkWeb3
        '
        Me.lnkWeb3.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lnkWeb3.AutoSize = True
        Me.lnkWeb3.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lnkWeb3.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lnkWeb3.Location = New System.Drawing.Point(3, 48)
        Me.lnkWeb3.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.lnkWeb3.Name = "lnkWeb3"
        Me.lnkWeb3.Size = New System.Drawing.Size(48, 13)
        Me.lnkWeb3.TabIndex = 47
        Me.lnkWeb3.TabStop = True
        Me.lnkWeb3.Text = "lnkWeb3"
        '
        'tlpAam
        '
        tlpAam.AutoSize = True
        tlpAam.ColumnCount = 2
        tlpAam.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        tlpAam.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        tlpAam.Controls.Add(Me.lblAamValue, 0, 0)
        tlpAam.Controls.Add(Me.lblAamRecommended, 0, 1)
        tlpAam.Controls.Add(Me.lnkSetAam, 1, 0)
        tlpAam.Controls.Add(Me.lnkSetRecommended, 1, 1)
        tlpAam.Controls.Add(Me.lnkUndoAam, 1, 2)
        tlpAam.Dock = System.Windows.Forms.DockStyle.Top
        tlpAam.Location = New System.Drawing.Point(0, 118)
        tlpAam.Margin = New System.Windows.Forms.Padding(0, 3, 3, 3)
        tlpAam.Name = "tlpAam"
        tlpAam.RowCount = 3
        tlpAam.RowStyles.Add(New System.Windows.Forms.RowStyle())
        tlpAam.RowStyles.Add(New System.Windows.Forms.RowStyle())
        tlpAam.RowStyles.Add(New System.Windows.Forms.RowStyle())
        tlpAam.Size = New System.Drawing.Size(865, 57)
        tlpAam.TabIndex = 32
        '
        'lblAamValue
        '
        Me.lblAamValue.AutoSize = True
        Me.lblAamValue.ForeColor = System.Drawing.Color.Black
        Me.lblAamValue.Location = New System.Drawing.Point(3, 3)
        Me.lblAamValue.Margin = New System.Windows.Forms.Padding(3)
        Me.lblAamValue.Name = "lblAamValue"
        Me.lblAamValue.Size = New System.Drawing.Size(64, 13)
        Me.lblAamValue.TabIndex = 27
        Me.lblAamValue.Text = "lblAamValue"
        '
        'lblAamRecommended
        '
        Me.lblAamRecommended.AutoSize = True
        Me.lblAamRecommended.ForeColor = System.Drawing.Color.Black
        Me.lblAamRecommended.Location = New System.Drawing.Point(3, 22)
        Me.lblAamRecommended.Margin = New System.Windows.Forms.Padding(3)
        Me.lblAamRecommended.Name = "lblAamRecommended"
        Me.lblAamRecommended.Size = New System.Drawing.Size(108, 13)
        Me.lblAamRecommended.TabIndex = 29
        Me.lblAamRecommended.Text = "lblAamRecommended"
        '
        'lnkSetAam
        '
        Me.lnkSetAam.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lnkSetAam.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lnkSetAam.AutoSize = True
        Me.lnkSetAam.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lnkSetAam.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lnkSetAam.Location = New System.Drawing.Point(805, 3)
        Me.lnkSetAam.Margin = New System.Windows.Forms.Padding(3)
        Me.lnkSetAam.Name = "lnkSetAam"
        Me.lnkSetAam.Size = New System.Drawing.Size(57, 13)
        Me.lnkSetAam.TabIndex = 1
        Me.lnkSetAam.TabStop = True
        Me.lnkSetAam.Text = "lnkSetAam"
        '
        'lnkSetRecommended
        '
        Me.lnkSetRecommended.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lnkSetRecommended.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lnkSetRecommended.AutoSize = True
        Me.lnkSetRecommended.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lnkSetRecommended.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lnkSetRecommended.Location = New System.Drawing.Point(756, 22)
        Me.lnkSetRecommended.Margin = New System.Windows.Forms.Padding(3)
        Me.lnkSetRecommended.Name = "lnkSetRecommended"
        Me.lnkSetRecommended.Size = New System.Drawing.Size(106, 13)
        Me.lnkSetRecommended.TabIndex = 2
        Me.lnkSetRecommended.TabStop = True
        Me.lnkSetRecommended.Text = "lnkSetRecommended"
        '
        'lnkUndoAam
        '
        Me.lnkUndoAam.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lnkUndoAam.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lnkUndoAam.AutoSize = True
        Me.lnkUndoAam.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lnkUndoAam.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lnkUndoAam.Location = New System.Drawing.Point(796, 41)
        Me.lnkUndoAam.Margin = New System.Windows.Forms.Padding(3)
        Me.lnkUndoAam.Name = "lnkUndoAam"
        Me.lnkUndoAam.Size = New System.Drawing.Size(66, 13)
        Me.lnkUndoAam.TabIndex = 3
        Me.lnkUndoAam.TabStop = True
        Me.lnkUndoAam.Text = "lnkUndoAam"
        '
        'tlpAamLoud
        '
        tlpAamLoud.ColumnCount = 2
        tlpAamLoud.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        tlpAamLoud.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        tlpAamLoud.Controls.Add(Me.lblQuiet, 0, 0)
        tlpAamLoud.Controls.Add(Me.lblLoudest, 1, 0)
        tlpAamLoud.Dock = System.Windows.Forms.DockStyle.Fill
        tlpAamLoud.Location = New System.Drawing.Point(0, 45)
        tlpAamLoud.Margin = New System.Windows.Forms.Padding(0, 3, 3, 3)
        tlpAamLoud.Name = "tlpAamLoud"
        tlpAamLoud.RowCount = 1
        tlpAamLoud.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        tlpAamLoud.Size = New System.Drawing.Size(865, 16)
        tlpAamLoud.TabIndex = 29
        '
        'lblQuiet
        '
        Me.lblQuiet.AutoSize = True
        Me.lblQuiet.ForeColor = System.Drawing.Color.DimGray
        Me.lblQuiet.Location = New System.Drawing.Point(3, 0)
        Me.lblQuiet.Name = "lblQuiet"
        Me.lblQuiet.Size = New System.Drawing.Size(43, 13)
        Me.lblQuiet.TabIndex = 0
        Me.lblQuiet.Text = "lblQuiet"
        '
        'lblLoudest
        '
        Me.lblLoudest.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLoudest.AutoSize = True
        Me.lblLoudest.ForeColor = System.Drawing.Color.DimGray
        Me.lblLoudest.Location = New System.Drawing.Point(807, 0)
        Me.lblLoudest.Name = "lblLoudest"
        Me.lblLoudest.Size = New System.Drawing.Size(55, 13)
        Me.lblLoudest.TabIndex = 1
        Me.lblLoudest.Text = "lblLoudest"
        Me.lblLoudest.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'tlpApm
        '
        tlpApm.AutoSize = True
        tlpApm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        tlpApm.ColumnCount = 2
        tlpApm.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        tlpApm.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        tlpApm.Controls.Add(Me.lblApmValue, 0, 0)
        tlpApm.Controls.Add(Me.lnkSetApm, 1, 0)
        tlpApm.Controls.Add(Me.lnkUndoApm, 1, 1)
        tlpApm.Dock = System.Windows.Forms.DockStyle.Top
        tlpApm.Location = New System.Drawing.Point(0, 96)
        tlpApm.Margin = New System.Windows.Forms.Padding(0, 3, 3, 3)
        tlpApm.Name = "tlpApm"
        tlpApm.RowCount = 2
        tlpApm.RowStyles.Add(New System.Windows.Forms.RowStyle())
        tlpApm.RowStyles.Add(New System.Windows.Forms.RowStyle())
        tlpApm.Size = New System.Drawing.Size(865, 38)
        tlpApm.TabIndex = 32
        '
        'lblApmValue
        '
        Me.lblApmValue.AutoSize = True
        Me.lblApmValue.ForeColor = System.Drawing.Color.Black
        Me.lblApmValue.Location = New System.Drawing.Point(3, 3)
        Me.lblApmValue.Margin = New System.Windows.Forms.Padding(3)
        Me.lblApmValue.Name = "lblApmValue"
        Me.lblApmValue.Size = New System.Drawing.Size(64, 13)
        Me.lblApmValue.TabIndex = 27
        Me.lblApmValue.Text = "lblApmValue"
        '
        'lnkSetApm
        '
        Me.lnkSetApm.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lnkSetApm.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lnkSetApm.AutoSize = True
        Me.lnkSetApm.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lnkSetApm.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lnkSetApm.Location = New System.Drawing.Point(805, 3)
        Me.lnkSetApm.Margin = New System.Windows.Forms.Padding(3)
        Me.lnkSetApm.Name = "lnkSetApm"
        Me.lnkSetApm.Size = New System.Drawing.Size(57, 13)
        Me.lnkSetApm.TabIndex = 1
        Me.lnkSetApm.TabStop = True
        Me.lnkSetApm.Text = "lnkSetApm"
        '
        'lnkUndoApm
        '
        Me.lnkUndoApm.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lnkUndoApm.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lnkUndoApm.AutoSize = True
        Me.lnkUndoApm.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lnkUndoApm.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lnkUndoApm.Location = New System.Drawing.Point(796, 22)
        Me.lnkUndoApm.Margin = New System.Windows.Forms.Padding(3)
        Me.lnkUndoApm.Name = "lnkUndoApm"
        Me.lnkUndoApm.Size = New System.Drawing.Size(66, 13)
        Me.lnkUndoApm.TabIndex = 2
        Me.lnkUndoApm.TabStop = True
        Me.lnkUndoApm.Text = "lnkUndoApm"
        '
        'tlpStandby
        '
        tlpStandby.AutoSize = True
        tlpStandby.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        tlpStandby.ColumnCount = 2
        tlpStandby.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        tlpStandby.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        tlpStandby.Controls.Add(Me.lnkSetStandby, 1, 0)
        tlpStandby.Controls.Add(Me.lblStandbyValue, 0, 0)
        tlpStandby.Controls.Add(Me.lnkUndoStandby, 1, 1)
        tlpStandby.Dock = System.Windows.Forms.DockStyle.Top
        tlpStandby.Location = New System.Drawing.Point(0, 96)
        tlpStandby.Margin = New System.Windows.Forms.Padding(0, 3, 3, 3)
        tlpStandby.Name = "tlpStandby"
        tlpStandby.RowCount = 2
        tlpStandby.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        tlpStandby.RowStyles.Add(New System.Windows.Forms.RowStyle())
        tlpStandby.Size = New System.Drawing.Size(865, 39)
        tlpStandby.TabIndex = 32
        '
        'lnkSetStandby
        '
        Me.lnkSetStandby.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lnkSetStandby.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lnkSetStandby.AutoSize = True
        Me.lnkSetStandby.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lnkSetStandby.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lnkSetStandby.Location = New System.Drawing.Point(786, 3)
        Me.lnkSetStandby.Margin = New System.Windows.Forms.Padding(3)
        Me.lnkSetStandby.Name = "lnkSetStandby"
        Me.lnkSetStandby.Size = New System.Drawing.Size(76, 13)
        Me.lnkSetStandby.TabIndex = 1
        Me.lnkSetStandby.TabStop = True
        Me.lnkSetStandby.Text = "lnkSetStandby"
        '
        'lblStandbyValue
        '
        Me.lblStandbyValue.AutoSize = True
        Me.lblStandbyValue.ForeColor = System.Drawing.Color.Black
        Me.lblStandbyValue.Location = New System.Drawing.Point(3, 3)
        Me.lblStandbyValue.Margin = New System.Windows.Forms.Padding(3)
        Me.lblStandbyValue.Name = "lblStandbyValue"
        Me.lblStandbyValue.Size = New System.Drawing.Size(83, 13)
        Me.lblStandbyValue.TabIndex = 27
        Me.lblStandbyValue.Text = "lblStandbyValue"
        '
        'lnkUndoStandby
        '
        Me.lnkUndoStandby.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lnkUndoStandby.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lnkUndoStandby.AutoSize = True
        Me.lnkUndoStandby.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lnkUndoStandby.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lnkUndoStandby.Location = New System.Drawing.Point(777, 23)
        Me.lnkUndoStandby.Margin = New System.Windows.Forms.Padding(3)
        Me.lnkUndoStandby.Name = "lnkUndoStandby"
        Me.lnkUndoStandby.Size = New System.Drawing.Size(85, 13)
        Me.lnkUndoStandby.TabIndex = 2
        Me.lnkUndoStandby.TabStop = True
        Me.lnkUndoStandby.Text = "lnkUndoStandby"
        '
        'imlAttr
        '
        Me.imlAttr.ImageStream = CType(resources.GetObject("imlAttr.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imlAttr.TransparentColor = System.Drawing.Color.Transparent
        Me.imlAttr.Images.SetKeyName(0, "mechanic")
        Me.imlAttr.Images.SetKeyName(1, "old")
        '
        'niTrayIcon
        '
        Me.niTrayIcon.Icon = CType(resources.GetObject("niTrayIcon.Icon"), System.Drawing.Icon)
        Me.niTrayIcon.Text = "HDD Guardian"
        '
        'tmrRefresh
        '
        '
        'mnuGuide
        '
        Me.mnuGuide.Name = "mnuGuide"
        Me.mnuGuide.ShowShortcutKeys = False
        Me.mnuGuide.Size = New System.Drawing.Size(123, 22)
        Me.mnuGuide.Text = "mnuGuide"
        Me.mnuGuide.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mnuGuide.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(120, 6)
        '
        'mnuInfo
        '
        Me.mnuInfo.Name = "mnuInfo"
        Me.mnuInfo.ShowShortcutKeys = False
        Me.mnuInfo.Size = New System.Drawing.Size(123, 22)
        Me.mnuInfo.Text = "mnuInfo"
        Me.mnuInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mnuInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        '
        'tmrFlushMem
        '
        Me.tmrFlushMem.Enabled = True
        Me.tmrFlushMem.Interval = 60000
        '
        'tmrTest
        '
        '
        'imlDevice
        '
        Me.imlDevice.ImageStream = CType(resources.GetObject("imlDevice.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imlDevice.TransparentColor = System.Drawing.Color.Transparent
        Me.imlDevice.Images.SetKeyName(0, "error")
        Me.imlDevice.Images.SetKeyName(1, "ok")
        '
        'imlLog
        '
        Me.imlLog.ImageStream = CType(resources.GetObject("imlLog.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imlLog.TransparentColor = System.Drawing.Color.Transparent
        Me.imlLog.Images.SetKeyName(0, "ok")
        Me.imlLog.Images.SetKeyName(1, "warning")
        '
        'tmrRefreshExt
        '
        '
        'tmrRefreshVirtual
        '
        '
        'cmTrayIcon
        '
        Me.cmTrayIcon.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuRestoreTray, MenuItem4, Me.mnuExitTray})
        '
        'mnuRestoreTray
        '
        Me.mnuRestoreTray.Index = 0
        Me.mnuRestoreTray.Text = "mnuRestoreTray"
        '
        'mnuExitTray
        '
        Me.mnuExitTray.Index = 2
        Me.mnuExitTray.Text = "mnuExitTray"
        '
        'cmDevices
        '
        Me.cmDevices.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuTitle, Me.MenuItem3, Me.mnuRefreshSel, Me.mnuRefreshAll, MenuItem2, Me.mnuSearchUsb, MenuItem5, Me.mnuAddVirtualDev, Me.mnuRemoveVirtualDev, Me.MenuItem6, Me.mnuTrayIcon, Me.mnuSharing, Me.mnuXml})
        '
        'mnuTitle
        '
        Me.mnuTitle.Enabled = False
        Me.mnuTitle.Index = 0
        Me.mnuTitle.Text = "mnuTitle"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 1
        Me.MenuItem3.Text = "-"
        '
        'mnuRefreshSel
        '
        Me.mnuRefreshSel.Index = 2
        Me.mnuRefreshSel.Text = "mnuRefreshSel"
        '
        'mnuRefreshAll
        '
        Me.mnuRefreshAll.Index = 3
        Me.mnuRefreshAll.Text = "mnuRefreshAll"
        '
        'mnuSearchUsb
        '
        Me.mnuSearchUsb.Index = 5
        Me.mnuSearchUsb.Text = "mnuSearchUsb"
        '
        'mnuAddVirtualDev
        '
        Me.mnuAddVirtualDev.Index = 7
        Me.mnuAddVirtualDev.Text = "mnuAddVirtualDev"
        '
        'mnuRemoveVirtualDev
        '
        Me.mnuRemoveVirtualDev.Index = 8
        Me.mnuRemoveVirtualDev.Text = "mnuRemoveVirtualDev"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 9
        Me.MenuItem6.Text = "-"
        '
        'mnuTrayIcon
        '
        Me.mnuTrayIcon.Index = 10
        Me.mnuTrayIcon.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuTrayTemperature, Me.mnuTrayLife, Me.MenuItem1, Me.mnuInfoPanel})
        Me.mnuTrayIcon.Text = "mnuTrayIcon"
        '
        'mnuTrayTemperature
        '
        Me.mnuTrayTemperature.Index = 0
        Me.mnuTrayTemperature.Text = "mnuTrayTemperature"
        '
        'mnuTrayLife
        '
        Me.mnuTrayLife.Index = 1
        Me.mnuTrayLife.Text = "mnuTrayLife"
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 2
        Me.MenuItem1.Text = "-"
        '
        'mnuInfoPanel
        '
        Me.mnuInfoPanel.Index = 3
        Me.mnuInfoPanel.Text = "mnuInfoPanel"
        '
        'mnuSharing
        '
        Me.mnuSharing.Index = 11
        Me.mnuSharing.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuShareThis, Me.mnuSharingFolder})
        Me.mnuSharing.Text = "mnuSharing"
        '
        'mnuShareThis
        '
        Me.mnuShareThis.Index = 0
        Me.mnuShareThis.Text = "mnuShareThis"
        '
        'mnuSharingFolder
        '
        Me.mnuSharingFolder.Index = 1
        Me.mnuSharingFolder.Text = "mnuSharingFolder"
        '
        'mnuXml
        '
        Me.mnuXml.Index = 12
        Me.mnuXml.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuXmlCreate, Me.mnuXmlFolder})
        Me.mnuXml.Text = "mnuXml"
        '
        'mnuXmlCreate
        '
        Me.mnuXmlCreate.Index = 0
        Me.mnuXmlCreate.Text = "mnuXmlCreate"
        '
        'mnuXmlFolder
        '
        Me.mnuXmlFolder.Index = 1
        Me.mnuXmlFolder.Text = "mnuXmlFolder"
        '
        'cmFile
        '
        Me.cmFile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuReloadDevices, Me.MenuItem10, Me.mnuUpdateDatabase, Me.MenuItem8, Me.mnuSettings, Me.mnuAbout, Me.MenuItem7, Me.mnuExit})
        '
        'mnuReloadDevices
        '
        Me.mnuReloadDevices.Index = 0
        Me.mnuReloadDevices.Text = "mnuReloadDevices"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 1
        Me.MenuItem10.Text = "-"
        '
        'mnuUpdateDatabase
        '
        Me.mnuUpdateDatabase.Index = 2
        Me.mnuUpdateDatabase.Text = "mnuUpdateDatabase"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 3
        Me.MenuItem8.Text = "-"
        '
        'mnuSettings
        '
        Me.mnuSettings.Index = 4
        Me.mnuSettings.Text = "mnuSettings"
        '
        'mnuAbout
        '
        Me.mnuAbout.Index = 5
        Me.mnuAbout.Text = "mnuAbout"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 6
        Me.MenuItem7.Text = "-"
        '
        'mnuExit
        '
        Me.mnuExit.Index = 7
        Me.mnuExit.Text = "mnuExit"
        '
        'cmDeviceImage
        '
        Me.cmDeviceImage.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuProfessional, Me.mnuGamer, Me.mnuLaptop})
        '
        'mnuProfessional
        '
        Me.mnuProfessional.Index = 0
        Me.mnuProfessional.Text = "mnuProfessional"
        '
        'mnuGamer
        '
        Me.mnuGamer.Index = 1
        Me.mnuGamer.Text = "mnuGamer"
        '
        'mnuLaptop
        '
        Me.mnuLaptop.Index = 2
        Me.mnuLaptop.Text = "mnuLaptop"
        '
        'htcMain
        '
        Me.htcMain.Controls.Add(Me.tpOverview)
        Me.htcMain.Controls.Add(Me.tpManage)
        Me.htcMain.Controls.Add(Me.tpWmiDevices)
        Me.htcMain.Controls.Add(Me.tpDebug)
        Me.htcMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.htcMain.Location = New System.Drawing.Point(0, 32)
        Me.htcMain.Margin = New System.Windows.Forms.Padding(0)
        Me.htcMain.Name = "htcMain"
        Me.htcMain.SelectedIndex = 0
        Me.htcMain.Size = New System.Drawing.Size(892, 490)
        Me.htcMain.TabIndex = 42
        '
        'tpOverview
        '
        Me.tpOverview.BackColor = System.Drawing.Color.White
        Me.tpOverview.Controls.Add(Me.lvwDevices)
        Me.tpOverview.Controls.Add(RibbonHorizontalSeparator2)
        Me.tpOverview.Controls.Add(Me.tlpMenuItems)
        Me.tpOverview.Controls.Add(Me.pnlInfo)
        Me.tpOverview.Location = New System.Drawing.Point(4, 22)
        Me.tpOverview.Name = "tpOverview"
        Me.tpOverview.Size = New System.Drawing.Size(884, 464)
        Me.tpOverview.TabIndex = 0
        Me.tpOverview.Text = "tpOverview"
        '
        'lvwDevices
        '
        Me.lvwDevices.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lvwDevices.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chName, Me.chTemp, Me.chRemaningLife, Me.chType, Me.chSize})
        Me.lvwDevices.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvwDevices.FullRowSelect = True
        ListViewGroup1.Header = "Phisycal"
        ListViewGroup1.Name = "grpPhisycal"
        ListViewGroup2.Header = "External"
        ListViewGroup2.Name = "grpExternal"
        ListViewGroup3.Header = "Virtual"
        ListViewGroup3.Name = "grpVirtual"
        Me.lvwDevices.Groups.AddRange(New System.Windows.Forms.ListViewGroup() {ListViewGroup1, ListViewGroup2, ListViewGroup3})
        Me.lvwDevices.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvwDevices.HideSelection = False
        Me.lvwDevices.Location = New System.Drawing.Point(0, 79)
        Me.lvwDevices.Margin = New System.Windows.Forms.Padding(0)
        Me.lvwDevices.MultiSelect = False
        Me.lvwDevices.Name = "lvwDevices"
        Me.lvwDevices.Size = New System.Drawing.Size(884, 275)
        Me.lvwDevices.TabIndex = 0
        Me.lvwDevices.UseCompatibleStateImageBehavior = False
        Me.lvwDevices.View = System.Windows.Forms.View.Details
        '
        'chName
        '
        Me.chName.Text = "chName"
        '
        'chTemp
        '
        Me.chTemp.Text = "chTemp"
        Me.chTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'chRemaningLife
        '
        Me.chRemaningLife.Text = "chRemaningLife"
        Me.chRemaningLife.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'chType
        '
        Me.chType.Text = "chType"
        Me.chType.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'chSize
        '
        Me.chSize.Text = "chSize"
        Me.chSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tlpMenuItems
        '
        Me.tlpMenuItems.AutoSize = True
        Me.tlpMenuItems.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlpMenuItems.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.tlpMenuItems.ColumnCount = 4
        Me.tlpMenuItems.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMenuItems.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMenuItems.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMenuItems.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpMenuItems.Controls.Add(Me.rbtUpdateAll, 0, 0)
        Me.tlpMenuItems.Controls.Add(Me.rbtRescanUsb, 1, 0)
        Me.tlpMenuItems.Controls.Add(Me.rbtAddVirtual, 2, 0)
        Me.tlpMenuItems.Controls.Add(Me.picOverviewHelp, 3, 0)
        Me.tlpMenuItems.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpMenuItems.Location = New System.Drawing.Point(0, 0)
        Me.tlpMenuItems.Name = "tlpMenuItems"
        Me.tlpMenuItems.RowCount = 1
        Me.tlpMenuItems.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMenuItems.Size = New System.Drawing.Size(884, 78)
        Me.tlpMenuItems.TabIndex = 24
        '
        'rbtUpdateAll
        '
        Me.rbtUpdateAll.AutoSize = True
        Me.rbtUpdateAll.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.rbtUpdateAll.BackColor = System.Drawing.Color.Transparent
        Me.rbtUpdateAll.ButtonStyle = hdd_guardian.RibbonButton.Style.Big
        Me.rbtUpdateAll.Icon = Nothing
        Me.rbtUpdateAll.Location = New System.Drawing.Point(5, 5)
        Me.rbtUpdateAll.Margin = New System.Windows.Forms.Padding(5, 5, 2, 5)
        Me.rbtUpdateAll.MaximumSize = New System.Drawing.Size(150, 68)
        Me.rbtUpdateAll.MinimumSize = New System.Drawing.Size(0, 68)
        Me.rbtUpdateAll.Name = "rbtUpdateAll"
        Me.rbtUpdateAll.Size = New System.Drawing.Size(69, 68)
        Me.rbtUpdateAll.TabIndex = 0
        Me.rbtUpdateAll.Text = "rbtUpdateAll"
        '
        'rbtRescanUsb
        '
        Me.rbtRescanUsb.AutoSize = True
        Me.rbtRescanUsb.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.rbtRescanUsb.BackColor = System.Drawing.Color.Transparent
        Me.rbtRescanUsb.ButtonStyle = hdd_guardian.RibbonButton.Style.Big
        Me.rbtRescanUsb.Icon = Nothing
        Me.rbtRescanUsb.Location = New System.Drawing.Point(78, 5)
        Me.rbtRescanUsb.Margin = New System.Windows.Forms.Padding(2, 5, 2, 5)
        Me.rbtRescanUsb.MaximumSize = New System.Drawing.Size(150, 68)
        Me.rbtRescanUsb.MinimumSize = New System.Drawing.Size(0, 68)
        Me.rbtRescanUsb.Name = "rbtRescanUsb"
        Me.rbtRescanUsb.Size = New System.Drawing.Size(76, 68)
        Me.rbtRescanUsb.TabIndex = 1
        Me.rbtRescanUsb.Text = "rbtRescanUsb"
        '
        'rbtAddVirtual
        '
        Me.rbtAddVirtual.AutoSize = True
        Me.rbtAddVirtual.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.rbtAddVirtual.BackColor = System.Drawing.Color.Transparent
        Me.rbtAddVirtual.ButtonStyle = hdd_guardian.RibbonButton.Style.Big
        Me.rbtAddVirtual.Icon = Nothing
        Me.rbtAddVirtual.Location = New System.Drawing.Point(158, 5)
        Me.rbtAddVirtual.Margin = New System.Windows.Forms.Padding(2, 5, 5, 5)
        Me.rbtAddVirtual.MaximumSize = New System.Drawing.Size(150, 68)
        Me.rbtAddVirtual.MinimumSize = New System.Drawing.Size(0, 68)
        Me.rbtAddVirtual.Name = "rbtAddVirtual"
        Me.rbtAddVirtual.Size = New System.Drawing.Size(72, 68)
        Me.rbtAddVirtual.TabIndex = 2
        Me.rbtAddVirtual.Text = "rbtAddVirtual"
        '
        'picOverviewHelp
        '
        Me.picOverviewHelp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picOverviewHelp.Location = New System.Drawing.Point(863, 5)
        Me.picOverviewHelp.Margin = New System.Windows.Forms.Padding(3, 5, 5, 3)
        Me.picOverviewHelp.Name = "picOverviewHelp"
        Me.picOverviewHelp.Size = New System.Drawing.Size(16, 16)
        Me.picOverviewHelp.TabIndex = 3
        Me.picOverviewHelp.TabStop = False
        '
        'pnlInfo
        '
        Me.pnlInfo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlInfo.Controls.Add(Me.picSeparator)
        Me.pnlInfo.Controls.Add(Me.tlpDeviceInfo)
        Me.pnlInfo.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlInfo.Location = New System.Drawing.Point(0, 354)
        Me.pnlInfo.Name = "pnlInfo"
        Me.pnlInfo.Size = New System.Drawing.Size(884, 110)
        Me.pnlInfo.TabIndex = 23
        '
        'picSeparator
        '
        Me.picSeparator.BackgroundImage = CType(resources.GetObject("picSeparator.BackgroundImage"), System.Drawing.Image)
        Me.picSeparator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picSeparator.Dock = System.Windows.Forms.DockStyle.Top
        Me.picSeparator.Location = New System.Drawing.Point(0, 0)
        Me.picSeparator.Name = "picSeparator"
        Me.picSeparator.Size = New System.Drawing.Size(884, 9)
        Me.picSeparator.TabIndex = 23
        Me.picSeparator.TabStop = False
        '
        'tlpDeviceInfo
        '
        Me.tlpDeviceInfo.AutoSize = True
        Me.tlpDeviceInfo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlpDeviceInfo.ColumnCount = 2
        Me.tlpDeviceInfo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpDeviceInfo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpDeviceInfo.Controls.Add(Me.tlpInfoPanel, 1, 0)
        Me.tlpDeviceInfo.Controls.Add(Me.picDeviceImage, 0, 0)
        Me.tlpDeviceInfo.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tlpDeviceInfo.Location = New System.Drawing.Point(0, 4)
        Me.tlpDeviceInfo.Name = "tlpDeviceInfo"
        Me.tlpDeviceInfo.RowCount = 1
        Me.tlpDeviceInfo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpDeviceInfo.Size = New System.Drawing.Size(884, 106)
        Me.tlpDeviceInfo.TabIndex = 22
        '
        'tlpInfoPanel
        '
        Me.tlpInfoPanel.AutoSize = True
        Me.tlpInfoPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlpInfoPanel.ColumnCount = 5
        Me.tlpInfoPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpInfoPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpInfoPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpInfoPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpInfoPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpInfoPanel.Controls.Add(Me.lblManufacturer, 1, 0)
        Me.tlpInfoPanel.Controls.Add(Me.lblDeviceName, 0, 0)
        Me.tlpInfoPanel.Controls.Add(Me.lblSerialNumber, 1, 1)
        Me.tlpInfoPanel.Controls.Add(Me.lblDeviceLocation, 0, 1)
        Me.tlpInfoPanel.Controls.Add(Me.lblDeviceSize, 0, 2)
        Me.tlpInfoPanel.Controls.Add(Me.lnkManufacturer, 2, 0)
        Me.tlpInfoPanel.Controls.Add(Me.lblSerialNumberValue, 2, 1)
        Me.tlpInfoPanel.Controls.Add(Me.lblFirmwareValue, 2, 2)
        Me.tlpInfoPanel.Controls.Add(Me.lblTempInfo, 3, 0)
        Me.tlpInfoPanel.Controls.Add(Me.lblTempInfoValue, 4, 0)
        Me.tlpInfoPanel.Controls.Add(Me.lblLife, 3, 1)
        Me.tlpInfoPanel.Controls.Add(Me.lblLifeValue, 4, 1)
        Me.tlpInfoPanel.Controls.Add(Me.lblAtaErrorsValue, 4, 4)
        Me.tlpInfoPanel.Controls.Add(Me.lblBadSectorsInfoValue, 4, 3)
        Me.tlpInfoPanel.Controls.Add(Me.lblHealthInfoValue, 4, 2)
        Me.tlpInfoPanel.Controls.Add(Me.lblHealthInfo, 3, 2)
        Me.tlpInfoPanel.Controls.Add(Me.lblBadSectorsInfo, 3, 3)
        Me.tlpInfoPanel.Controls.Add(Me.lblAtaErrors, 3, 4)
        Me.tlpInfoPanel.Controls.Add(Me.lblFirmware, 1, 2)
        Me.tlpInfoPanel.Controls.Add(Me.picReliability, 2, 4)
        Me.tlpInfoPanel.Controls.Add(Me.lblReliability, 1, 4)
        Me.tlpInfoPanel.Controls.Add(Me.lblWorkTime, 1, 3)
        Me.tlpInfoPanel.Controls.Add(Me.lblWorkTimeValue, 2, 3)
        Me.tlpInfoPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpInfoPanel.Location = New System.Drawing.Point(106, 8)
        Me.tlpInfoPanel.Margin = New System.Windows.Forms.Padding(0, 8, 8, 8)
        Me.tlpInfoPanel.Name = "tlpInfoPanel"
        Me.tlpInfoPanel.RowCount = 5
        Me.tlpInfoPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18.0!))
        Me.tlpInfoPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18.0!))
        Me.tlpInfoPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18.0!))
        Me.tlpInfoPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18.0!))
        Me.tlpInfoPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18.0!))
        Me.tlpInfoPanel.Size = New System.Drawing.Size(770, 90)
        Me.tlpInfoPanel.TabIndex = 2
        '
        'lblManufacturer
        '
        Me.lblManufacturer.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblManufacturer.AutoSize = True
        Me.lblManufacturer.ForeColor = System.Drawing.Color.DimGray
        Me.lblManufacturer.Location = New System.Drawing.Point(109, 5)
        Me.lblManufacturer.Margin = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.lblManufacturer.Name = "lblManufacturer"
        Me.lblManufacturer.Size = New System.Drawing.Size(82, 13)
        Me.lblManufacturer.TabIndex = 0
        Me.lblManufacturer.Tag = "Grayed"
        Me.lblManufacturer.Text = "lblManufacturer"
        '
        'lblDeviceName
        '
        Me.lblDeviceName.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblDeviceName.AutoSize = True
        Me.lblDeviceName.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDeviceName.ForeColor = System.Drawing.Color.Black
        Me.lblDeviceName.Location = New System.Drawing.Point(3, 4)
        Me.lblDeviceName.Name = "lblDeviceName"
        Me.lblDeviceName.Size = New System.Drawing.Size(93, 14)
        Me.lblDeviceName.TabIndex = 1
        Me.lblDeviceName.Tag = "Normal"
        Me.lblDeviceName.Text = "lblDeviceName"
        '
        'lblSerialNumber
        '
        Me.lblSerialNumber.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSerialNumber.AutoSize = True
        Me.lblSerialNumber.ForeColor = System.Drawing.Color.DimGray
        Me.lblSerialNumber.Location = New System.Drawing.Point(111, 23)
        Me.lblSerialNumber.Margin = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.lblSerialNumber.Name = "lblSerialNumber"
        Me.lblSerialNumber.Size = New System.Drawing.Size(80, 13)
        Me.lblSerialNumber.TabIndex = 1
        Me.lblSerialNumber.Tag = "Grayed"
        Me.lblSerialNumber.Text = "lblSerialNumber"
        '
        'lblDeviceLocation
        '
        Me.lblDeviceLocation.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblDeviceLocation.AutoSize = True
        Me.lblDeviceLocation.ForeColor = System.Drawing.Color.DimGray
        Me.lblDeviceLocation.Location = New System.Drawing.Point(3, 23)
        Me.lblDeviceLocation.Name = "lblDeviceLocation"
        Me.lblDeviceLocation.Size = New System.Drawing.Size(89, 13)
        Me.lblDeviceLocation.TabIndex = 3
        Me.lblDeviceLocation.Tag = "Grayed"
        Me.lblDeviceLocation.Text = "lblDeviceLocation"
        '
        'lblDeviceSize
        '
        Me.lblDeviceSize.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblDeviceSize.AutoSize = True
        Me.lblDeviceSize.ForeColor = System.Drawing.Color.DimGray
        Me.lblDeviceSize.Location = New System.Drawing.Point(3, 41)
        Me.lblDeviceSize.Name = "lblDeviceSize"
        Me.lblDeviceSize.Size = New System.Drawing.Size(68, 13)
        Me.lblDeviceSize.TabIndex = 4
        Me.lblDeviceSize.Tag = "Grayed"
        Me.lblDeviceSize.Text = "lblDeviceSize"
        '
        'lnkManufacturer
        '
        Me.lnkManufacturer.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lnkManufacturer.AutoSize = True
        Me.lnkManufacturer.Location = New System.Drawing.Point(191, 5)
        Me.lnkManufacturer.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.lnkManufacturer.Name = "lnkManufacturer"
        Me.lnkManufacturer.Size = New System.Drawing.Size(85, 13)
        Me.lnkManufacturer.TabIndex = 5
        Me.lnkManufacturer.TabStop = True
        Me.lnkManufacturer.Text = "lnkManufacturer"
        '
        'lblSerialNumberValue
        '
        Me.lblSerialNumberValue.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblSerialNumberValue.AutoSize = True
        Me.lblSerialNumberValue.ForeColor = System.Drawing.Color.Black
        Me.lblSerialNumberValue.Location = New System.Drawing.Point(191, 23)
        Me.lblSerialNumberValue.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.lblSerialNumberValue.Name = "lblSerialNumberValue"
        Me.lblSerialNumberValue.Size = New System.Drawing.Size(106, 13)
        Me.lblSerialNumberValue.TabIndex = 6
        Me.lblSerialNumberValue.Tag = "Normal"
        Me.lblSerialNumberValue.Text = "lblSerialNumberValue"
        '
        'lblFirmwareValue
        '
        Me.lblFirmwareValue.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblFirmwareValue.AutoSize = True
        Me.lblFirmwareValue.ForeColor = System.Drawing.Color.Black
        Me.lblFirmwareValue.Location = New System.Drawing.Point(191, 41)
        Me.lblFirmwareValue.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.lblFirmwareValue.Name = "lblFirmwareValue"
        Me.lblFirmwareValue.Size = New System.Drawing.Size(87, 13)
        Me.lblFirmwareValue.TabIndex = 7
        Me.lblFirmwareValue.Tag = "Normal"
        Me.lblFirmwareValue.Text = "lblFirmwareValue"
        '
        'lblTempInfo
        '
        Me.lblTempInfo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTempInfo.AutoSize = True
        Me.lblTempInfo.ForeColor = System.Drawing.Color.DimGray
        Me.lblTempInfo.Location = New System.Drawing.Point(338, 5)
        Me.lblTempInfo.Margin = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.lblTempInfo.Name = "lblTempInfo"
        Me.lblTempInfo.Size = New System.Drawing.Size(63, 13)
        Me.lblTempInfo.TabIndex = 8
        Me.lblTempInfo.Tag = "Grayed"
        Me.lblTempInfo.Text = "lblTempInfo"
        '
        'lblTempInfoValue
        '
        Me.lblTempInfoValue.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblTempInfoValue.AutoSize = True
        Me.lblTempInfoValue.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lblTempInfoValue.Location = New System.Drawing.Point(401, 5)
        Me.lblTempInfoValue.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.lblTempInfoValue.Name = "lblTempInfoValue"
        Me.lblTempInfoValue.Size = New System.Drawing.Size(89, 13)
        Me.lblTempInfoValue.TabIndex = 11
        Me.lblTempInfoValue.Text = "lblTempInfoValue"
        '
        'lblLife
        '
        Me.lblLife.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLife.AutoSize = True
        Me.lblLife.ForeColor = System.Drawing.Color.DimGray
        Me.lblLife.Location = New System.Drawing.Point(367, 23)
        Me.lblLife.Margin = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.lblLife.Name = "lblLife"
        Me.lblLife.Size = New System.Drawing.Size(34, 13)
        Me.lblLife.TabIndex = 13
        Me.lblLife.Tag = "Grayed"
        Me.lblLife.Text = "lblLife"
        '
        'lblLifeValue
        '
        Me.lblLifeValue.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblLifeValue.AutoSize = True
        Me.lblLifeValue.ForeColor = System.Drawing.Color.LimeGreen
        Me.lblLifeValue.Location = New System.Drawing.Point(401, 23)
        Me.lblLifeValue.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.lblLifeValue.Name = "lblLifeValue"
        Me.lblLifeValue.Size = New System.Drawing.Size(60, 13)
        Me.lblLifeValue.TabIndex = 16
        Me.lblLifeValue.Text = "lblLifeValue"
        '
        'lblAtaErrorsValue
        '
        Me.lblAtaErrorsValue.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblAtaErrorsValue.AutoSize = True
        Me.lblAtaErrorsValue.ForeColor = System.Drawing.Color.Black
        Me.lblAtaErrorsValue.Location = New System.Drawing.Point(401, 77)
        Me.lblAtaErrorsValue.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.lblAtaErrorsValue.Name = "lblAtaErrorsValue"
        Me.lblAtaErrorsValue.Size = New System.Drawing.Size(89, 13)
        Me.lblAtaErrorsValue.TabIndex = 18
        Me.lblAtaErrorsValue.Tag = "Normal"
        Me.lblAtaErrorsValue.Text = "lblAtaErrorsValue"
        '
        'lblBadSectorsInfoValue
        '
        Me.lblBadSectorsInfoValue.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblBadSectorsInfoValue.AutoSize = True
        Me.lblBadSectorsInfoValue.ForeColor = System.Drawing.Color.Black
        Me.lblBadSectorsInfoValue.Location = New System.Drawing.Point(401, 59)
        Me.lblBadSectorsInfoValue.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.lblBadSectorsInfoValue.Name = "lblBadSectorsInfoValue"
        Me.lblBadSectorsInfoValue.Size = New System.Drawing.Size(117, 13)
        Me.lblBadSectorsInfoValue.TabIndex = 17
        Me.lblBadSectorsInfoValue.Tag = "Normal"
        Me.lblBadSectorsInfoValue.Text = "lblBadSectorsInfoValue"
        '
        'lblHealthInfoValue
        '
        Me.lblHealthInfoValue.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblHealthInfoValue.AutoSize = True
        Me.lblHealthInfoValue.ForeColor = System.Drawing.Color.Black
        Me.lblHealthInfoValue.Location = New System.Drawing.Point(401, 41)
        Me.lblHealthInfoValue.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.lblHealthInfoValue.Name = "lblHealthInfoValue"
        Me.lblHealthInfoValue.Size = New System.Drawing.Size(94, 13)
        Me.lblHealthInfoValue.TabIndex = 20
        Me.lblHealthInfoValue.Tag = "Normal"
        Me.lblHealthInfoValue.Text = "lblHealthInfoValue"
        '
        'lblHealthInfo
        '
        Me.lblHealthInfo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblHealthInfo.AutoSize = True
        Me.lblHealthInfo.ForeColor = System.Drawing.Color.DimGray
        Me.lblHealthInfo.Location = New System.Drawing.Point(333, 41)
        Me.lblHealthInfo.Margin = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.lblHealthInfo.Name = "lblHealthInfo"
        Me.lblHealthInfo.Size = New System.Drawing.Size(68, 13)
        Me.lblHealthInfo.TabIndex = 19
        Me.lblHealthInfo.Tag = "Grayed"
        Me.lblHealthInfo.Text = "lblHealthInfo"
        '
        'lblBadSectorsInfo
        '
        Me.lblBadSectorsInfo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblBadSectorsInfo.AtaText = Nothing
        Me.lblBadSectorsInfo.AutoSize = True
        Me.lblBadSectorsInfo.ForeColor = System.Drawing.Color.DimGray
        Me.lblBadSectorsInfo.Location = New System.Drawing.Point(310, 59)
        Me.lblBadSectorsInfo.Margin = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.lblBadSectorsInfo.Name = "lblBadSectorsInfo"
        Me.lblBadSectorsInfo.ScsiText = Nothing
        Me.lblBadSectorsInfo.Size = New System.Drawing.Size(91, 13)
        Me.lblBadSectorsInfo.TabIndex = 21
        Me.lblBadSectorsInfo.Tag = "Greyed"
        Me.lblBadSectorsInfo.Text = "lblBadSectorsInfo"
        '
        'lblAtaErrors
        '
        Me.lblAtaErrors.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAtaErrors.AtaText = Nothing
        Me.lblAtaErrors.AutoSize = True
        Me.lblAtaErrors.ForeColor = System.Drawing.Color.DimGray
        Me.lblAtaErrors.Location = New System.Drawing.Point(338, 77)
        Me.lblAtaErrors.Margin = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.lblAtaErrors.Name = "lblAtaErrors"
        Me.lblAtaErrors.ScsiText = Nothing
        Me.lblAtaErrors.Size = New System.Drawing.Size(63, 13)
        Me.lblAtaErrors.TabIndex = 22
        Me.lblAtaErrors.Tag = "Greyed"
        Me.lblAtaErrors.Text = "lblAtaErrors"
        '
        'lblFirmware
        '
        Me.lblFirmware.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFirmware.AtaText = Nothing
        Me.lblFirmware.AutoSize = True
        Me.lblFirmware.ForeColor = System.Drawing.Color.DimGray
        Me.lblFirmware.Location = New System.Drawing.Point(130, 41)
        Me.lblFirmware.Margin = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.lblFirmware.Name = "lblFirmware"
        Me.lblFirmware.ScsiText = Nothing
        Me.lblFirmware.Size = New System.Drawing.Size(61, 13)
        Me.lblFirmware.TabIndex = 23
        Me.lblFirmware.Tag = "Greyed"
        Me.lblFirmware.Text = "lblFirmware"
        '
        'picReliability
        '
        Me.picReliability.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.picReliability.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.picReliability.Location = New System.Drawing.Point(194, 80)
        Me.picReliability.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.picReliability.Name = "picReliability"
        Me.picReliability.Size = New System.Drawing.Size(100, 10)
        Me.picReliability.TabIndex = 12
        Me.picReliability.TabStop = False
        '
        'lblReliability
        '
        Me.lblReliability.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblReliability.AutoSize = True
        Me.lblReliability.ForeColor = System.Drawing.Color.DimGray
        Me.lblReliability.Location = New System.Drawing.Point(129, 77)
        Me.lblReliability.Margin = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.lblReliability.Name = "lblReliability"
        Me.lblReliability.Size = New System.Drawing.Size(62, 13)
        Me.lblReliability.TabIndex = 9
        Me.lblReliability.Tag = "Grayed"
        Me.lblReliability.Text = "lblReliability"
        '
        'lblWorkTime
        '
        Me.lblWorkTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblWorkTime.AutoSize = True
        Me.lblWorkTime.ForeColor = System.Drawing.Color.DimGray
        Me.lblWorkTime.Location = New System.Drawing.Point(127, 59)
        Me.lblWorkTime.Margin = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.lblWorkTime.Name = "lblWorkTime"
        Me.lblWorkTime.Size = New System.Drawing.Size(64, 13)
        Me.lblWorkTime.TabIndex = 24
        Me.lblWorkTime.Tag = "Grayed"
        Me.lblWorkTime.Text = "lblWorkTime"
        '
        'lblWorkTimeValue
        '
        Me.lblWorkTimeValue.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblWorkTimeValue.AutoSize = True
        Me.lblWorkTimeValue.Location = New System.Drawing.Point(191, 59)
        Me.lblWorkTimeValue.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.lblWorkTimeValue.Name = "lblWorkTimeValue"
        Me.lblWorkTimeValue.Size = New System.Drawing.Size(90, 13)
        Me.lblWorkTimeValue.TabIndex = 25
        Me.lblWorkTimeValue.Tag = "Normal"
        Me.lblWorkTimeValue.Text = "lblWorkTimeValue"
        '
        'picDeviceImage
        '
        Me.picDeviceImage.BackColor = System.Drawing.Color.Transparent
        Me.picDeviceImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picDeviceImage.Location = New System.Drawing.Point(8, 8)
        Me.picDeviceImage.Margin = New System.Windows.Forms.Padding(8)
        Me.picDeviceImage.MinimumSize = New System.Drawing.Size(90, 90)
        Me.picDeviceImage.Name = "picDeviceImage"
        Me.picDeviceImage.Size = New System.Drawing.Size(90, 90)
        Me.picDeviceImage.TabIndex = 0
        Me.picDeviceImage.TabStop = False
        '
        'tpManage
        '
        Me.tpManage.BackColor = System.Drawing.Color.White
        Me.tpManage.Controls.Add(Me.htcManage)
        Me.tpManage.Controls.Add(Me.RibbonHorizontalSeparator4)
        Me.tpManage.Controls.Add(Me.tlpManageMenuContent)
        Me.tpManage.Controls.Add(Me.RibbonHorizontalSeparator3)
        Me.tpManage.Controls.Add(Me.tlpSelDevice)
        Me.tpManage.Location = New System.Drawing.Point(4, 22)
        Me.tpManage.Name = "tpManage"
        Me.tpManage.Size = New System.Drawing.Size(884, 464)
        Me.tpManage.TabIndex = 1
        Me.tpManage.Text = "tpManage"
        '
        'htcManage
        '
        Me.htcManage.Controls.Add(Me.tpInfo)
        Me.htcManage.Controls.Add(Me.tpSetup)
        Me.htcManage.Controls.Add(Me.tpErrorsTests)
        Me.htcManage.Controls.Add(Me.tpSmartctl)
        Me.htcManage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.htcManage.Location = New System.Drawing.Point(0, 138)
        Me.htcManage.Name = "htcManage"
        Me.htcManage.SelectedIndex = 0
        Me.htcManage.Size = New System.Drawing.Size(884, 326)
        Me.htcManage.TabIndex = 30
        Me.htcManage.TabStop = False
        '
        'tpInfo
        '
        Me.tpInfo.BackColor = System.Drawing.Color.White
        Me.tpInfo.Controls.Add(Me.htcInfo)
        Me.tpInfo.Location = New System.Drawing.Point(4, 22)
        Me.tpInfo.Name = "tpInfo"
        Me.tpInfo.Size = New System.Drawing.Size(876, 300)
        Me.tpInfo.TabIndex = 0
        Me.tpInfo.Text = "tpInfo"
        '
        'htcInfo
        '
        Me.htcInfo.Controls.Add(Me.tpAtaHealth)
        Me.htcInfo.Controls.Add(Me.tpAtaInfo)
        Me.htcInfo.Controls.Add(Me.tpAtaSmartAttributes)
        Me.htcInfo.Controls.Add(Me.tpScsiHealth)
        Me.htcInfo.Controls.Add(Me.tpScsiInfo)
        Me.htcInfo.Controls.Add(Me.tpEventsLog)
        Me.htcInfo.Controls.Add(Me.tpEventsChart)
        Me.htcInfo.Controls.Add(Me.tpTemperatures)
        Me.htcInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.htcInfo.Location = New System.Drawing.Point(0, 0)
        Me.htcInfo.Name = "htcInfo"
        Me.htcInfo.SelectedIndex = 0
        Me.htcInfo.Size = New System.Drawing.Size(876, 300)
        Me.htcInfo.TabIndex = 0
        Me.htcInfo.TabStop = False
        '
        'tpAtaHealth
        '
        Me.tpAtaHealth.AutoScroll = True
        Me.tpAtaHealth.BackColor = System.Drawing.Color.White
        Me.tpAtaHealth.Controls.Add(Me.tlpHealthStatus)
        Me.tpAtaHealth.Location = New System.Drawing.Point(4, 22)
        Me.tpAtaHealth.Name = "tpAtaHealth"
        Me.tpAtaHealth.Size = New System.Drawing.Size(868, 274)
        Me.tpAtaHealth.TabIndex = 5
        Me.tpAtaHealth.Text = "tpAtaHealth"
        '
        'tlpHealthStatus
        '
        Me.tlpHealthStatus.AutoSize = True
        Me.tlpHealthStatus.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlpHealthStatus.ColumnCount = 3
        Me.tlpHealthStatus.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpHealthStatus.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpHealthStatus.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpHealthStatus.Controls.Add(Me.lblRating4, 1, 12)
        Me.tlpHealthStatus.Controls.Add(Me.lblRating3, 1, 11)
        Me.tlpHealthStatus.Controls.Add(Me.lblRating2, 1, 10)
        Me.tlpHealthStatus.Controls.Add(Me.lblRating1, 1, 9)
        Me.tlpHealthStatus.Controls.Add(Me.lblBadSectors, 2, 4)
        Me.tlpHealthStatus.Controls.Add(Me.lblTempValue, 2, 0)
        Me.tlpHealthStatus.Controls.Add(Me.lblHealthStatus, 0, 0)
        Me.tlpHealthStatus.Controls.Add(Me.lblReliabilityRating, 0, 9)
        Me.tlpHealthStatus.Controls.Add(Me.lblTemperature, 1, 0)
        Me.tlpHealthStatus.Controls.Add(Me.lblHealth, 1, 3)
        Me.tlpHealthStatus.Controls.Add(Me.lblLastTest, 1, 2)
        Me.tlpHealthStatus.Controls.Add(Me.lblRemainingLife, 1, 1)
        Me.tlpHealthStatus.Controls.Add(Me.lblRemainingLifeValue, 2, 1)
        Me.tlpHealthStatus.Controls.Add(Me.lblLastTestValue, 2, 2)
        Me.tlpHealthStatus.Controls.Add(Me.lblHealthValue, 2, 3)
        Me.tlpHealthStatus.Controls.Add(Me.lblErrorsAta, 2, 5)
        Me.tlpHealthStatus.Controls.Add(Me.tlpRating1, 2, 9)
        Me.tlpHealthStatus.Controls.Add(Me.tlpRating2, 2, 10)
        Me.tlpHealthStatus.Controls.Add(Me.tlpRating3, 2, 11)
        Me.tlpHealthStatus.Controls.Add(Me.tlpRating4, 2, 12)
        Me.tlpHealthStatus.Controls.Add(Me.lblLastUpdate, 1, 7)
        Me.tlpHealthStatus.Controls.Add(Me.lblLastUpdateValue, 2, 7)
        Me.tlpHealthStatus.Controls.Add(Me.lblAtaWorkTime, 1, 6)
        Me.tlpHealthStatus.Controls.Add(Me.lblAtaWorkTimeValue, 2, 6)
        Me.tlpHealthStatus.Location = New System.Drawing.Point(0, 5)
        Me.tlpHealthStatus.Name = "tlpHealthStatus"
        Me.tlpHealthStatus.RowCount = 13
        Me.tlpHealthStatus.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpHealthStatus.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpHealthStatus.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpHealthStatus.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpHealthStatus.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpHealthStatus.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpHealthStatus.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpHealthStatus.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpHealthStatus.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpHealthStatus.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpHealthStatus.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpHealthStatus.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpHealthStatus.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpHealthStatus.Size = New System.Drawing.Size(322, 212)
        Me.tlpHealthStatus.TabIndex = 2
        '
        'lblRating4
        '
        Me.lblRating4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblRating4.AutoEllipsis = True
        Me.lblRating4.AutoSize = True
        Me.lblRating4.ForeColor = System.Drawing.Color.Black
        Me.lblRating4.Location = New System.Drawing.Point(96, 196)
        Me.lblRating4.Margin = New System.Windows.Forms.Padding(0, 0, 3, 3)
        Me.lblRating4.Name = "lblRating4"
        Me.lblRating4.Size = New System.Drawing.Size(54, 13)
        Me.lblRating4.TabIndex = 5
        Me.lblRating4.Text = "lblRating4"
        '
        'lblRating3
        '
        Me.lblRating3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblRating3.AutoEllipsis = True
        Me.lblRating3.AutoSize = True
        Me.lblRating3.ForeColor = System.Drawing.Color.Black
        Me.lblRating3.Location = New System.Drawing.Point(96, 180)
        Me.lblRating3.Margin = New System.Windows.Forms.Padding(0, 0, 3, 3)
        Me.lblRating3.Name = "lblRating3"
        Me.lblRating3.Size = New System.Drawing.Size(54, 13)
        Me.lblRating3.TabIndex = 4
        Me.lblRating3.Text = "lblRating3"
        '
        'lblRating2
        '
        Me.lblRating2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblRating2.AutoEllipsis = True
        Me.lblRating2.AutoSize = True
        Me.lblRating2.ForeColor = System.Drawing.Color.Black
        Me.lblRating2.Location = New System.Drawing.Point(96, 164)
        Me.lblRating2.Margin = New System.Windows.Forms.Padding(0, 0, 3, 3)
        Me.lblRating2.Name = "lblRating2"
        Me.lblRating2.Size = New System.Drawing.Size(54, 13)
        Me.lblRating2.TabIndex = 3
        Me.lblRating2.Text = "lblRating2"
        '
        'lblRating1
        '
        Me.lblRating1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblRating1.AutoEllipsis = True
        Me.lblRating1.AutoSize = True
        Me.lblRating1.ForeColor = System.Drawing.Color.Black
        Me.lblRating1.Location = New System.Drawing.Point(96, 148)
        Me.lblRating1.Margin = New System.Windows.Forms.Padding(0, 0, 3, 3)
        Me.lblRating1.Name = "lblRating1"
        Me.lblRating1.Size = New System.Drawing.Size(54, 13)
        Me.lblRating1.TabIndex = 1
        Me.lblRating1.Text = "lblRating1"
        '
        'lblBadSectors
        '
        Me.lblBadSectors.AutoSize = True
        Me.lblBadSectors.ForeColor = System.Drawing.Color.Black
        Me.lblBadSectors.Location = New System.Drawing.Point(185, 64)
        Me.lblBadSectors.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.lblBadSectors.Name = "lblBadSectors"
        Me.lblBadSectors.Size = New System.Drawing.Size(71, 13)
        Me.lblBadSectors.TabIndex = 5
        Me.lblBadSectors.Text = "lblBadSectors"
        '
        'lblTempValue
        '
        Me.lblTempValue.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblTempValue.AutoSize = True
        Me.lblTempValue.ForeColor = System.Drawing.Color.Black
        Me.lblTempValue.Location = New System.Drawing.Point(185, 0)
        Me.lblTempValue.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.lblTempValue.Name = "lblTempValue"
        Me.lblTempValue.Size = New System.Drawing.Size(69, 13)
        Me.lblTempValue.TabIndex = 1
        Me.lblTempValue.Text = "lblTempValue"
        '
        'lblHealthStatus
        '
        Me.lblHealthStatus.AutoSize = True
        Me.lblHealthStatus.ForeColor = System.Drawing.Color.DimGray
        Me.lblHealthStatus.Location = New System.Drawing.Point(0, 0)
        Me.lblHealthStatus.Margin = New System.Windows.Forms.Padding(0, 0, 3, 3)
        Me.lblHealthStatus.Name = "lblHealthStatus"
        Me.lblHealthStatus.Size = New System.Drawing.Size(79, 13)
        Me.lblHealthStatus.TabIndex = 50
        Me.lblHealthStatus.Tag = "Grayed"
        Me.lblHealthStatus.Text = "lblHealthStatus"
        '
        'lblReliabilityRating
        '
        Me.lblReliabilityRating.AutoSize = True
        Me.lblReliabilityRating.ForeColor = System.Drawing.Color.DimGray
        Me.lblReliabilityRating.Location = New System.Drawing.Point(0, 148)
        Me.lblReliabilityRating.Margin = New System.Windows.Forms.Padding(0, 0, 3, 3)
        Me.lblReliabilityRating.Name = "lblReliabilityRating"
        Me.lblReliabilityRating.Size = New System.Drawing.Size(93, 13)
        Me.lblReliabilityRating.TabIndex = 51
        Me.lblReliabilityRating.Tag = "Grayed"
        Me.lblReliabilityRating.Text = "lblReliabilityRating"
        '
        'lblTemperature
        '
        Me.lblTemperature.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblTemperature.AutoSize = True
        Me.lblTemperature.ForeColor = System.Drawing.Color.Black
        Me.lblTemperature.Location = New System.Drawing.Point(96, 0)
        Me.lblTemperature.Margin = New System.Windows.Forms.Padding(0, 0, 3, 3)
        Me.lblTemperature.Name = "lblTemperature"
        Me.lblTemperature.Size = New System.Drawing.Size(79, 13)
        Me.lblTemperature.TabIndex = 0
        Me.lblTemperature.Text = "lblTemperature"
        '
        'lblHealth
        '
        Me.lblHealth.AutoSize = True
        Me.lblHealth.ForeColor = System.Drawing.Color.Black
        Me.lblHealth.Location = New System.Drawing.Point(96, 48)
        Me.lblHealth.Margin = New System.Windows.Forms.Padding(0, 0, 3, 3)
        Me.lblHealth.Name = "lblHealth"
        Me.lblHealth.Size = New System.Drawing.Size(48, 13)
        Me.lblHealth.TabIndex = 9
        Me.lblHealth.Text = "lblHealth"
        '
        'lblLastTest
        '
        Me.lblLastTest.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblLastTest.AutoSize = True
        Me.lblLastTest.ForeColor = System.Drawing.Color.Black
        Me.lblLastTest.Location = New System.Drawing.Point(96, 32)
        Me.lblLastTest.Margin = New System.Windows.Forms.Padding(0, 0, 3, 3)
        Me.lblLastTest.Name = "lblLastTest"
        Me.lblLastTest.Size = New System.Drawing.Size(58, 13)
        Me.lblLastTest.TabIndex = 6
        Me.lblLastTest.Text = "lblLastTest"
        '
        'lblRemainingLife
        '
        Me.lblRemainingLife.AutoSize = True
        Me.lblRemainingLife.ForeColor = System.Drawing.Color.Black
        Me.lblRemainingLife.Location = New System.Drawing.Point(96, 16)
        Me.lblRemainingLife.Margin = New System.Windows.Forms.Padding(0, 0, 3, 3)
        Me.lblRemainingLife.Name = "lblRemainingLife"
        Me.lblRemainingLife.Size = New System.Drawing.Size(83, 13)
        Me.lblRemainingLife.TabIndex = 37
        Me.lblRemainingLife.Text = "lblRemainingLife"
        '
        'lblRemainingLifeValue
        '
        Me.lblRemainingLifeValue.AutoSize = True
        Me.lblRemainingLifeValue.ForeColor = System.Drawing.Color.Black
        Me.lblRemainingLifeValue.Location = New System.Drawing.Point(185, 16)
        Me.lblRemainingLifeValue.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.lblRemainingLifeValue.Name = "lblRemainingLifeValue"
        Me.lblRemainingLifeValue.Size = New System.Drawing.Size(109, 13)
        Me.lblRemainingLifeValue.TabIndex = 38
        Me.lblRemainingLifeValue.Text = "lblRemainingLifeValue"
        '
        'lblLastTestValue
        '
        Me.lblLastTestValue.AutoSize = True
        Me.lblLastTestValue.ForeColor = System.Drawing.Color.Black
        Me.lblLastTestValue.Location = New System.Drawing.Point(185, 32)
        Me.lblLastTestValue.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.lblLastTestValue.Name = "lblLastTestValue"
        Me.lblLastTestValue.Size = New System.Drawing.Size(84, 13)
        Me.lblLastTestValue.TabIndex = 8
        Me.lblLastTestValue.Text = "lblLastTestValue"
        '
        'lblHealthValue
        '
        Me.lblHealthValue.AutoSize = True
        Me.lblHealthValue.ForeColor = System.Drawing.Color.Black
        Me.lblHealthValue.Location = New System.Drawing.Point(185, 48)
        Me.lblHealthValue.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.lblHealthValue.Name = "lblHealthValue"
        Me.lblHealthValue.Size = New System.Drawing.Size(74, 13)
        Me.lblHealthValue.TabIndex = 11
        Me.lblHealthValue.Text = "lblHealthValue"
        '
        'lblErrorsAta
        '
        Me.lblErrorsAta.AutoSize = True
        Me.lblErrorsAta.ForeColor = System.Drawing.Color.Black
        Me.lblErrorsAta.Location = New System.Drawing.Point(185, 80)
        Me.lblErrorsAta.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.lblErrorsAta.Name = "lblErrorsAta"
        Me.lblErrorsAta.Size = New System.Drawing.Size(63, 13)
        Me.lblErrorsAta.TabIndex = 12
        Me.lblErrorsAta.Text = "lblErrorsAta"
        '
        'tlpRating1
        '
        Me.tlpRating1.AutoSize = True
        Me.tlpRating1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlpRating1.ColumnCount = 2
        Me.tlpRating1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpRating1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpRating1.Controls.Add(Me.picRating1, 0, 0)
        Me.tlpRating1.Controls.Add(Me.lblRating1Value, 1, 0)
        Me.tlpRating1.Location = New System.Drawing.Point(182, 148)
        Me.tlpRating1.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpRating1.Name = "tlpRating1"
        Me.tlpRating1.RowCount = 1
        Me.tlpRating1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpRating1.Size = New System.Drawing.Size(140, 14)
        Me.tlpRating1.TabIndex = 52
        '
        'picRating1
        '
        Me.picRating1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.picRating1.Location = New System.Drawing.Point(3, 3)
        Me.picRating1.Name = "picRating1"
        Me.picRating1.Size = New System.Drawing.Size(48, 8)
        Me.picRating1.TabIndex = 12
        Me.picRating1.TabStop = False
        '
        'lblRating1Value
        '
        Me.lblRating1Value.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblRating1Value.AutoEllipsis = True
        Me.lblRating1Value.AutoSize = True
        Me.lblRating1Value.ForeColor = System.Drawing.Color.Black
        Me.lblRating1Value.Location = New System.Drawing.Point(57, 0)
        Me.lblRating1Value.Name = "lblRating1Value"
        Me.lblRating1Value.Size = New System.Drawing.Size(80, 13)
        Me.lblRating1Value.TabIndex = 22
        Me.lblRating1Value.Text = "lblRating1Value"
        '
        'tlpRating2
        '
        Me.tlpRating2.AutoSize = True
        Me.tlpRating2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlpRating2.ColumnCount = 2
        Me.tlpRating2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpRating2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpRating2.Controls.Add(Me.lblRating2Value, 1, 0)
        Me.tlpRating2.Controls.Add(Me.picRating2, 0, 0)
        Me.tlpRating2.Location = New System.Drawing.Point(182, 164)
        Me.tlpRating2.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpRating2.Name = "tlpRating2"
        Me.tlpRating2.RowCount = 1
        Me.tlpRating2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpRating2.Size = New System.Drawing.Size(140, 14)
        Me.tlpRating2.TabIndex = 53
        '
        'lblRating2Value
        '
        Me.lblRating2Value.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblRating2Value.AutoEllipsis = True
        Me.lblRating2Value.AutoSize = True
        Me.lblRating2Value.ForeColor = System.Drawing.Color.Black
        Me.lblRating2Value.Location = New System.Drawing.Point(57, 0)
        Me.lblRating2Value.Name = "lblRating2Value"
        Me.lblRating2Value.Size = New System.Drawing.Size(80, 13)
        Me.lblRating2Value.TabIndex = 23
        Me.lblRating2Value.Text = "lblRating2Value"
        '
        'picRating2
        '
        Me.picRating2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.picRating2.Location = New System.Drawing.Point(3, 3)
        Me.picRating2.Name = "picRating2"
        Me.picRating2.Size = New System.Drawing.Size(48, 8)
        Me.picRating2.TabIndex = 13
        Me.picRating2.TabStop = False
        '
        'tlpRating3
        '
        Me.tlpRating3.AutoSize = True
        Me.tlpRating3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlpRating3.ColumnCount = 2
        Me.tlpRating3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpRating3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpRating3.Controls.Add(Me.lblRating3Value, 1, 0)
        Me.tlpRating3.Controls.Add(Me.picRating3, 0, 0)
        Me.tlpRating3.Location = New System.Drawing.Point(182, 180)
        Me.tlpRating3.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpRating3.Name = "tlpRating3"
        Me.tlpRating3.RowCount = 1
        Me.tlpRating3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpRating3.Size = New System.Drawing.Size(140, 14)
        Me.tlpRating3.TabIndex = 54
        '
        'lblRating3Value
        '
        Me.lblRating3Value.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblRating3Value.AutoEllipsis = True
        Me.lblRating3Value.AutoSize = True
        Me.lblRating3Value.ForeColor = System.Drawing.Color.Black
        Me.lblRating3Value.Location = New System.Drawing.Point(57, 0)
        Me.lblRating3Value.Name = "lblRating3Value"
        Me.lblRating3Value.Size = New System.Drawing.Size(80, 13)
        Me.lblRating3Value.TabIndex = 24
        Me.lblRating3Value.Text = "lblRating3Value"
        '
        'picRating3
        '
        Me.picRating3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.picRating3.Location = New System.Drawing.Point(3, 3)
        Me.picRating3.Name = "picRating3"
        Me.picRating3.Size = New System.Drawing.Size(48, 8)
        Me.picRating3.TabIndex = 14
        Me.picRating3.TabStop = False
        '
        'tlpRating4
        '
        Me.tlpRating4.AutoSize = True
        Me.tlpRating4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlpRating4.ColumnCount = 2
        Me.tlpRating4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpRating4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpRating4.Controls.Add(Me.lblRating4Value, 1, 0)
        Me.tlpRating4.Controls.Add(Me.picRating4, 0, 0)
        Me.tlpRating4.Location = New System.Drawing.Point(182, 196)
        Me.tlpRating4.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpRating4.Name = "tlpRating4"
        Me.tlpRating4.RowCount = 1
        Me.tlpRating4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpRating4.Size = New System.Drawing.Size(140, 14)
        Me.tlpRating4.TabIndex = 55
        '
        'lblRating4Value
        '
        Me.lblRating4Value.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblRating4Value.AutoEllipsis = True
        Me.lblRating4Value.AutoSize = True
        Me.lblRating4Value.ForeColor = System.Drawing.Color.Black
        Me.lblRating4Value.Location = New System.Drawing.Point(57, 0)
        Me.lblRating4Value.Name = "lblRating4Value"
        Me.lblRating4Value.Size = New System.Drawing.Size(80, 13)
        Me.lblRating4Value.TabIndex = 25
        Me.lblRating4Value.Text = "lblRating4Value"
        '
        'picRating4
        '
        Me.picRating4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.picRating4.Location = New System.Drawing.Point(3, 3)
        Me.picRating4.Name = "picRating4"
        Me.picRating4.Size = New System.Drawing.Size(48, 8)
        Me.picRating4.TabIndex = 15
        Me.picRating4.TabStop = False
        '
        'lblLastUpdate
        '
        Me.lblLastUpdate.AutoSize = True
        Me.lblLastUpdate.ForeColor = System.Drawing.Color.Black
        Me.lblLastUpdate.Location = New System.Drawing.Point(96, 112)
        Me.lblLastUpdate.Margin = New System.Windows.Forms.Padding(0, 0, 3, 3)
        Me.lblLastUpdate.Name = "lblLastUpdate"
        Me.lblLastUpdate.Size = New System.Drawing.Size(72, 13)
        Me.lblLastUpdate.TabIndex = 56
        Me.lblLastUpdate.Text = "lblLastUpdate"
        '
        'lblLastUpdateValue
        '
        Me.lblLastUpdateValue.AutoSize = True
        Me.lblLastUpdateValue.ForeColor = System.Drawing.Color.Black
        Me.lblLastUpdateValue.Location = New System.Drawing.Point(185, 112)
        Me.lblLastUpdateValue.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.lblLastUpdateValue.Name = "lblLastUpdateValue"
        Me.lblLastUpdateValue.Size = New System.Drawing.Size(98, 13)
        Me.lblLastUpdateValue.TabIndex = 57
        Me.lblLastUpdateValue.Text = "lblLastUpdateValue"
        '
        'lblAtaWorkTime
        '
        Me.lblAtaWorkTime.AutoSize = True
        Me.lblAtaWorkTime.ForeColor = System.Drawing.Color.Black
        Me.lblAtaWorkTime.Location = New System.Drawing.Point(96, 96)
        Me.lblAtaWorkTime.Margin = New System.Windows.Forms.Padding(0, 0, 3, 3)
        Me.lblAtaWorkTime.Name = "lblAtaWorkTime"
        Me.lblAtaWorkTime.Size = New System.Drawing.Size(81, 13)
        Me.lblAtaWorkTime.TabIndex = 58
        Me.lblAtaWorkTime.Text = "lblAtaWorkTime"
        '
        'lblAtaWorkTimeValue
        '
        Me.lblAtaWorkTimeValue.AutoSize = True
        Me.lblAtaWorkTimeValue.ForeColor = System.Drawing.Color.Black
        Me.lblAtaWorkTimeValue.Location = New System.Drawing.Point(185, 96)
        Me.lblAtaWorkTimeValue.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.lblAtaWorkTimeValue.Name = "lblAtaWorkTimeValue"
        Me.lblAtaWorkTimeValue.Size = New System.Drawing.Size(107, 13)
        Me.lblAtaWorkTimeValue.TabIndex = 59
        Me.lblAtaWorkTimeValue.Text = "lblAtaWorkTimeValue"
        '
        'tpAtaInfo
        '
        Me.tpAtaInfo.AutoScroll = True
        Me.tpAtaInfo.BackColor = System.Drawing.Color.White
        Me.tpAtaInfo.Controls.Add(Me.tlpAtaInfoPanels)
        Me.tpAtaInfo.Location = New System.Drawing.Point(4, 22)
        Me.tpAtaInfo.Name = "tpAtaInfo"
        Me.tpAtaInfo.Size = New System.Drawing.Size(868, 274)
        Me.tpAtaInfo.TabIndex = 0
        Me.tpAtaInfo.Text = "tpAtaInfo"
        '
        'tlpAtaInfoPanels
        '
        Me.tlpAtaInfoPanels.AutoSize = True
        Me.tlpAtaInfoPanels.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlpAtaInfoPanels.ColumnCount = 2
        Me.tlpAtaInfoPanels.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpAtaInfoPanels.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpAtaInfoPanels.Controls.Add(Me.picManufacturer, 0, 0)
        Me.tlpAtaInfoPanels.Controls.Add(Me.flwManufacturer, 1, 0)
        Me.tlpAtaInfoPanels.Controls.Add(Me.lblDevice, 0, 2)
        Me.tlpAtaInfoPanels.Controls.Add(flwWarnings, 1, 6)
        Me.tlpAtaInfoPanels.Controls.Add(Me.lblDatabase, 0, 4)
        Me.tlpAtaInfoPanels.Controls.Add(Me.tlpDatabaseValue, 1, 4)
        Me.tlpAtaInfoPanels.Controls.Add(Me.tlpAtaDevice, 1, 2)
        Me.tlpAtaInfoPanels.Controls.Add(Me.lblWarnings, 0, 6)
        Me.tlpAtaInfoPanels.Location = New System.Drawing.Point(0, 0)
        Me.tlpAtaInfoPanels.Name = "tlpAtaInfoPanels"
        Me.tlpAtaInfoPanels.RowCount = 7
        Me.tlpAtaInfoPanels.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpAtaInfoPanels.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpAtaInfoPanels.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpAtaInfoPanels.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpAtaInfoPanels.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpAtaInfoPanels.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpAtaInfoPanels.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpAtaInfoPanels.Size = New System.Drawing.Size(376, 372)
        Me.tlpAtaInfoPanels.TabIndex = 51
        '
        'picManufacturer
        '
        Me.picManufacturer.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.picManufacturer.Location = New System.Drawing.Point(3, 3)
        Me.picManufacturer.MaximumSize = New System.Drawing.Size(170, 50)
        Me.picManufacturer.MinimumSize = New System.Drawing.Size(170, 50)
        Me.picManufacturer.Name = "picManufacturer"
        Me.picManufacturer.Size = New System.Drawing.Size(170, 50)
        Me.picManufacturer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picManufacturer.TabIndex = 9
        Me.picManufacturer.TabStop = False
        '
        'flwManufacturer
        '
        Me.flwManufacturer.AutoSize = True
        Me.flwManufacturer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.flwManufacturer.Controls.Add(Me.lnkAtaManufacturer)
        Me.flwManufacturer.Controls.Add(Me.lblModel)
        Me.flwManufacturer.Controls.Add(Me.lblFamily)
        Me.flwManufacturer.Location = New System.Drawing.Point(176, 0)
        Me.flwManufacturer.Margin = New System.Windows.Forms.Padding(0)
        Me.flwManufacturer.Name = "flwManufacturer"
        Me.flwManufacturer.Size = New System.Drawing.Size(159, 51)
        Me.flwManufacturer.TabIndex = 46
        '
        'lnkAtaManufacturer
        '
        Me.lnkAtaManufacturer.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lnkAtaManufacturer.AutoSize = True
        Me.flwManufacturer.SetFlowBreak(Me.lnkAtaManufacturer, True)
        Me.lnkAtaManufacturer.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lnkAtaManufacturer.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lnkAtaManufacturer.Location = New System.Drawing.Point(3, 3)
        Me.lnkAtaManufacturer.Margin = New System.Windows.Forms.Padding(3)
        Me.lnkAtaManufacturer.Name = "lnkAtaManufacturer"
        Me.lnkAtaManufacturer.Size = New System.Drawing.Size(102, 13)
        Me.lnkAtaManufacturer.TabIndex = 3
        Me.lnkAtaManufacturer.TabStop = True
        Me.lnkAtaManufacturer.Text = "lnkAtaManufacturer"
        '
        'lblModel
        '
        Me.lblModel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblModel.AutoSize = True
        Me.flwManufacturer.SetFlowBreak(Me.lblModel, True)
        Me.lblModel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModel.ForeColor = System.Drawing.Color.Black
        Me.lblModel.Location = New System.Drawing.Point(3, 19)
        Me.lblModel.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.lblModel.Name = "lblModel"
        Me.lblModel.Size = New System.Drawing.Size(45, 13)
        Me.lblModel.TabIndex = 2
        Me.lblModel.Text = "lblModel"
        '
        'lblFamily
        '
        Me.lblFamily.AutoSize = True
        Me.flwManufacturer.SetFlowBreak(Me.lblFamily, True)
        Me.lblFamily.ForeColor = System.Drawing.Color.Black
        Me.lblFamily.Location = New System.Drawing.Point(3, 35)
        Me.lblFamily.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.lblFamily.Name = "lblFamily"
        Me.lblFamily.Size = New System.Drawing.Size(47, 13)
        Me.lblFamily.TabIndex = 4
        Me.lblFamily.Text = "lblFamily"
        '
        'lblDevice
        '
        Me.lblDevice.AutoSize = True
        Me.lblDevice.ForeColor = System.Drawing.Color.DimGray
        Me.lblDevice.Location = New System.Drawing.Point(0, 76)
        Me.lblDevice.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.lblDevice.Name = "lblDevice"
        Me.lblDevice.Size = New System.Drawing.Size(49, 13)
        Me.lblDevice.TabIndex = 25
        Me.lblDevice.Text = "lblDevice"
        '
        'lblDatabase
        '
        Me.lblDatabase.AutoSize = True
        Me.lblDatabase.ForeColor = System.Drawing.Color.DimGray
        Me.lblDatabase.Location = New System.Drawing.Point(0, 256)
        Me.lblDatabase.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.lblDatabase.Name = "lblDatabase"
        Me.lblDatabase.Size = New System.Drawing.Size(63, 13)
        Me.lblDatabase.TabIndex = 26
        Me.lblDatabase.Text = "lblDatabase"
        '
        'tlpDatabaseValue
        '
        Me.tlpDatabaseValue.AutoSize = True
        Me.tlpDatabaseValue.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlpDatabaseValue.ColumnCount = 1
        Me.tlpDatabaseValue.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpDatabaseValue.Controls.Add(Me.lblInDatabase, 0, 0)
        Me.tlpDatabaseValue.Controls.Add(Me.lnkUpdateDatabase, 0, 1)
        Me.tlpDatabaseValue.Location = New System.Drawing.Point(176, 256)
        Me.tlpDatabaseValue.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpDatabaseValue.Name = "tlpDatabaseValue"
        Me.tlpDatabaseValue.RowCount = 2
        Me.tlpDatabaseValue.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpDatabaseValue.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpDatabaseValue.Size = New System.Drawing.Size(107, 32)
        Me.tlpDatabaseValue.TabIndex = 48
        '
        'lblInDatabase
        '
        Me.lblInDatabase.AutoSize = True
        Me.lblInDatabase.ForeColor = System.Drawing.Color.Black
        Me.lblInDatabase.Location = New System.Drawing.Point(3, 0)
        Me.lblInDatabase.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.lblInDatabase.Name = "lblInDatabase"
        Me.lblInDatabase.Size = New System.Drawing.Size(73, 13)
        Me.lblInDatabase.TabIndex = 20
        Me.lblInDatabase.Text = "lblInDatabase"
        '
        'lnkUpdateDatabase
        '
        Me.lnkUpdateDatabase.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lnkUpdateDatabase.AutoSize = True
        Me.lnkUpdateDatabase.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lnkUpdateDatabase.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lnkUpdateDatabase.Location = New System.Drawing.Point(3, 16)
        Me.lnkUpdateDatabase.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.lnkUpdateDatabase.Name = "lnkUpdateDatabase"
        Me.lnkUpdateDatabase.Size = New System.Drawing.Size(101, 13)
        Me.lnkUpdateDatabase.TabIndex = 21
        Me.lnkUpdateDatabase.TabStop = True
        Me.lnkUpdateDatabase.Text = "lnkUpdateDatabase"
        '
        'tlpAtaDevice
        '
        Me.tlpAtaDevice.AutoSize = True
        Me.tlpAtaDevice.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlpAtaDevice.ColumnCount = 2
        Me.tlpAtaDevice.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpAtaDevice.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpAtaDevice.Controls.Add(Me.lblSerial, 0, 0)
        Me.tlpAtaDevice.Controls.Add(Me.lblSmartStatus, 0, 9)
        Me.tlpAtaDevice.Controls.Add(Me.lblSataVersionValue, 1, 8)
        Me.tlpAtaDevice.Controls.Add(Me.lblWWN, 0, 1)
        Me.tlpAtaDevice.Controls.Add(Me.lblFirmwareInfo, 0, 2)
        Me.tlpAtaDevice.Controls.Add(Me.lblTotalSize, 0, 3)
        Me.tlpAtaDevice.Controls.Add(Me.lblSectorSize, 0, 4)
        Me.tlpAtaDevice.Controls.Add(Me.lblRotation, 0, 5)
        Me.tlpAtaDevice.Controls.Add(Me.lblAtaVersion, 0, 7)
        Me.tlpAtaDevice.Controls.Add(Me.lblSataVersion, 0, 8)
        Me.tlpAtaDevice.Controls.Add(Me.lblSerialValue, 1, 0)
        Me.tlpAtaDevice.Controls.Add(Me.lblWwnValue, 1, 1)
        Me.tlpAtaDevice.Controls.Add(Me.lblFirmwareInfoValue, 1, 2)
        Me.tlpAtaDevice.Controls.Add(Me.lblTotalSizeValue, 1, 3)
        Me.tlpAtaDevice.Controls.Add(Me.lblSectorSizeValue, 1, 4)
        Me.tlpAtaDevice.Controls.Add(Me.lblRotationValue, 1, 5)
        Me.tlpAtaDevice.Controls.Add(Me.lblAtaVersionValue, 1, 7)
        Me.tlpAtaDevice.Controls.Add(Me.lblSmartStatusValue, 1, 9)
        Me.tlpAtaDevice.Controls.Add(Me.lblForm, 0, 6)
        Me.tlpAtaDevice.Controls.Add(Me.lblFormValue, 1, 6)
        Me.tlpAtaDevice.Location = New System.Drawing.Point(176, 76)
        Me.tlpAtaDevice.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpAtaDevice.Name = "tlpAtaDevice"
        Me.tlpAtaDevice.RowCount = 10
        Me.tlpAtaDevice.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpAtaDevice.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpAtaDevice.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpAtaDevice.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpAtaDevice.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpAtaDevice.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpAtaDevice.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpAtaDevice.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpAtaDevice.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpAtaDevice.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpAtaDevice.Size = New System.Drawing.Size(200, 160)
        Me.tlpAtaDevice.TabIndex = 46
        '
        'lblSerial
        '
        Me.lblSerial.AutoSize = True
        Me.lblSerial.ForeColor = System.Drawing.Color.Black
        Me.lblSerial.Location = New System.Drawing.Point(3, 0)
        Me.lblSerial.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.lblSerial.Name = "lblSerial"
        Me.lblSerial.Size = New System.Drawing.Size(43, 13)
        Me.lblSerial.TabIndex = 2
        Me.lblSerial.Text = "lblSerial"
        Me.lblSerial.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblSmartStatus
        '
        Me.lblSmartStatus.AutoSize = True
        Me.lblSmartStatus.ForeColor = System.Drawing.Color.Black
        Me.lblSmartStatus.Location = New System.Drawing.Point(3, 144)
        Me.lblSmartStatus.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.lblSmartStatus.Name = "lblSmartStatus"
        Me.lblSmartStatus.Size = New System.Drawing.Size(76, 13)
        Me.lblSmartStatus.TabIndex = 23
        Me.lblSmartStatus.Text = "lblSmartStatus"
        Me.lblSmartStatus.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblSataVersionValue
        '
        Me.lblSataVersionValue.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblSataVersionValue.AutoSize = True
        Me.lblSataVersionValue.ForeColor = System.Drawing.Color.Black
        Me.lblSataVersionValue.Location = New System.Drawing.Point(90, 128)
        Me.lblSataVersionValue.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.lblSataVersionValue.Name = "lblSataVersionValue"
        Me.lblSataVersionValue.Size = New System.Drawing.Size(100, 13)
        Me.lblSataVersionValue.TabIndex = 22
        Me.lblSataVersionValue.Text = "lblSataVersionValue"
        '
        'lblWWN
        '
        Me.lblWWN.AutoSize = True
        Me.lblWWN.ForeColor = System.Drawing.Color.Black
        Me.lblWWN.Location = New System.Drawing.Point(3, 16)
        Me.lblWWN.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.lblWWN.Name = "lblWWN"
        Me.lblWWN.Size = New System.Drawing.Size(44, 13)
        Me.lblWWN.TabIndex = 3
        Me.lblWWN.Text = "lblWWN"
        Me.lblWWN.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblFirmwareInfo
        '
        Me.lblFirmwareInfo.AutoSize = True
        Me.lblFirmwareInfo.ForeColor = System.Drawing.Color.Black
        Me.lblFirmwareInfo.Location = New System.Drawing.Point(3, 32)
        Me.lblFirmwareInfo.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.lblFirmwareInfo.Name = "lblFirmwareInfo"
        Me.lblFirmwareInfo.Size = New System.Drawing.Size(81, 13)
        Me.lblFirmwareInfo.TabIndex = 4
        Me.lblFirmwareInfo.Text = "lblFirmwareInfo"
        Me.lblFirmwareInfo.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblTotalSize
        '
        Me.lblTotalSize.AutoSize = True
        Me.lblTotalSize.ForeColor = System.Drawing.Color.Black
        Me.lblTotalSize.Location = New System.Drawing.Point(3, 48)
        Me.lblTotalSize.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.lblTotalSize.Name = "lblTotalSize"
        Me.lblTotalSize.Size = New System.Drawing.Size(60, 13)
        Me.lblTotalSize.TabIndex = 5
        Me.lblTotalSize.Text = "lblTotalSize"
        Me.lblTotalSize.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblSectorSize
        '
        Me.lblSectorSize.AutoSize = True
        Me.lblSectorSize.ForeColor = System.Drawing.Color.Black
        Me.lblSectorSize.Location = New System.Drawing.Point(3, 64)
        Me.lblSectorSize.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.lblSectorSize.Name = "lblSectorSize"
        Me.lblSectorSize.Size = New System.Drawing.Size(67, 13)
        Me.lblSectorSize.TabIndex = 6
        Me.lblSectorSize.Text = "lblSectorSize"
        Me.lblSectorSize.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblRotation
        '
        Me.lblRotation.AutoSize = True
        Me.lblRotation.ForeColor = System.Drawing.Color.Black
        Me.lblRotation.Location = New System.Drawing.Point(3, 80)
        Me.lblRotation.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.lblRotation.Name = "lblRotation"
        Me.lblRotation.Size = New System.Drawing.Size(58, 13)
        Me.lblRotation.TabIndex = 7
        Me.lblRotation.Text = "lblRotation"
        Me.lblRotation.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblAtaVersion
        '
        Me.lblAtaVersion.AutoSize = True
        Me.lblAtaVersion.ForeColor = System.Drawing.Color.Black
        Me.lblAtaVersion.Location = New System.Drawing.Point(3, 112)
        Me.lblAtaVersion.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.lblAtaVersion.Name = "lblAtaVersion"
        Me.lblAtaVersion.Size = New System.Drawing.Size(69, 13)
        Me.lblAtaVersion.TabIndex = 9
        Me.lblAtaVersion.Text = "lblAtaVersion"
        Me.lblAtaVersion.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblSataVersion
        '
        Me.lblSataVersion.AutoSize = True
        Me.lblSataVersion.ForeColor = System.Drawing.Color.Black
        Me.lblSataVersion.Location = New System.Drawing.Point(3, 128)
        Me.lblSataVersion.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.lblSataVersion.Name = "lblSataVersion"
        Me.lblSataVersion.Size = New System.Drawing.Size(74, 13)
        Me.lblSataVersion.TabIndex = 10
        Me.lblSataVersion.Text = "lblSataVersion"
        Me.lblSataVersion.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblSerialValue
        '
        Me.lblSerialValue.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblSerialValue.AutoSize = True
        Me.lblSerialValue.ForeColor = System.Drawing.Color.Black
        Me.lblSerialValue.Location = New System.Drawing.Point(90, 0)
        Me.lblSerialValue.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.lblSerialValue.Name = "lblSerialValue"
        Me.lblSerialValue.Size = New System.Drawing.Size(69, 13)
        Me.lblSerialValue.TabIndex = 14
        Me.lblSerialValue.Text = "lblSerialValue"
        '
        'lblWwnValue
        '
        Me.lblWwnValue.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblWwnValue.AutoSize = True
        Me.lblWwnValue.ForeColor = System.Drawing.Color.Black
        Me.lblWwnValue.Location = New System.Drawing.Point(90, 16)
        Me.lblWwnValue.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.lblWwnValue.Name = "lblWwnValue"
        Me.lblWwnValue.Size = New System.Drawing.Size(67, 13)
        Me.lblWwnValue.TabIndex = 15
        Me.lblWwnValue.Text = "lblWwnValue"
        '
        'lblFirmwareInfoValue
        '
        Me.lblFirmwareInfoValue.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblFirmwareInfoValue.AutoSize = True
        Me.lblFirmwareInfoValue.ForeColor = System.Drawing.Color.Black
        Me.lblFirmwareInfoValue.Location = New System.Drawing.Point(90, 32)
        Me.lblFirmwareInfoValue.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.lblFirmwareInfoValue.Name = "lblFirmwareInfoValue"
        Me.lblFirmwareInfoValue.Size = New System.Drawing.Size(107, 13)
        Me.lblFirmwareInfoValue.TabIndex = 16
        Me.lblFirmwareInfoValue.Text = "lblFirmwareInfoValue"
        '
        'lblTotalSizeValue
        '
        Me.lblTotalSizeValue.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblTotalSizeValue.AutoSize = True
        Me.lblTotalSizeValue.ForeColor = System.Drawing.Color.Black
        Me.lblTotalSizeValue.Location = New System.Drawing.Point(90, 48)
        Me.lblTotalSizeValue.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.lblTotalSizeValue.Name = "lblTotalSizeValue"
        Me.lblTotalSizeValue.Size = New System.Drawing.Size(86, 13)
        Me.lblTotalSizeValue.TabIndex = 17
        Me.lblTotalSizeValue.Text = "lblTotalSizeValue"
        '
        'lblSectorSizeValue
        '
        Me.lblSectorSizeValue.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblSectorSizeValue.AutoSize = True
        Me.lblSectorSizeValue.ForeColor = System.Drawing.Color.Black
        Me.lblSectorSizeValue.Location = New System.Drawing.Point(90, 64)
        Me.lblSectorSizeValue.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.lblSectorSizeValue.Name = "lblSectorSizeValue"
        Me.lblSectorSizeValue.Size = New System.Drawing.Size(93, 13)
        Me.lblSectorSizeValue.TabIndex = 18
        Me.lblSectorSizeValue.Text = "lblSectorSizeValue"
        '
        'lblRotationValue
        '
        Me.lblRotationValue.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblRotationValue.AutoSize = True
        Me.lblRotationValue.ForeColor = System.Drawing.Color.Black
        Me.lblRotationValue.Location = New System.Drawing.Point(90, 80)
        Me.lblRotationValue.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.lblRotationValue.Name = "lblRotationValue"
        Me.lblRotationValue.Size = New System.Drawing.Size(84, 13)
        Me.lblRotationValue.TabIndex = 19
        Me.lblRotationValue.Text = "lblRotationValue"
        '
        'lblAtaVersionValue
        '
        Me.lblAtaVersionValue.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblAtaVersionValue.AutoSize = True
        Me.lblAtaVersionValue.ForeColor = System.Drawing.Color.Black
        Me.lblAtaVersionValue.Location = New System.Drawing.Point(90, 112)
        Me.lblAtaVersionValue.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.lblAtaVersionValue.Name = "lblAtaVersionValue"
        Me.lblAtaVersionValue.Size = New System.Drawing.Size(95, 13)
        Me.lblAtaVersionValue.TabIndex = 21
        Me.lblAtaVersionValue.Text = "lblAtaVersionValue"
        '
        'lblSmartStatusValue
        '
        Me.lblSmartStatusValue.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblSmartStatusValue.AutoSize = True
        Me.lblSmartStatusValue.ForeColor = System.Drawing.Color.Black
        Me.lblSmartStatusValue.Location = New System.Drawing.Point(90, 144)
        Me.lblSmartStatusValue.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.lblSmartStatusValue.Name = "lblSmartStatusValue"
        Me.lblSmartStatusValue.Size = New System.Drawing.Size(102, 13)
        Me.lblSmartStatusValue.TabIndex = 24
        Me.lblSmartStatusValue.Text = "lblSmartStatusValue"
        '
        'lblForm
        '
        Me.lblForm.AutoSize = True
        Me.lblForm.ForeColor = System.Drawing.Color.Black
        Me.lblForm.Location = New System.Drawing.Point(3, 96)
        Me.lblForm.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.lblForm.Name = "lblForm"
        Me.lblForm.Size = New System.Drawing.Size(41, 13)
        Me.lblForm.TabIndex = 25
        Me.lblForm.Text = "lblForm"
        '
        'lblFormValue
        '
        Me.lblFormValue.AutoSize = True
        Me.lblFormValue.ForeColor = System.Drawing.Color.Black
        Me.lblFormValue.Location = New System.Drawing.Point(90, 96)
        Me.lblFormValue.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.lblFormValue.Name = "lblFormValue"
        Me.lblFormValue.Size = New System.Drawing.Size(67, 13)
        Me.lblFormValue.TabIndex = 26
        Me.lblFormValue.Text = "lblFormValue"
        '
        'lblWarnings
        '
        Me.lblWarnings.AutoSize = True
        Me.lblWarnings.ForeColor = System.Drawing.Color.DimGray
        Me.lblWarnings.Location = New System.Drawing.Point(0, 308)
        Me.lblWarnings.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.lblWarnings.Name = "lblWarnings"
        Me.lblWarnings.Size = New System.Drawing.Size(62, 13)
        Me.lblWarnings.TabIndex = 49
        Me.lblWarnings.Text = "lblWarnings"
        '
        'tpAtaSmartAttributes
        '
        Me.tpAtaSmartAttributes.BackColor = System.Drawing.Color.White
        Me.tpAtaSmartAttributes.Controls.Add(Me.tlpAttributes)
        Me.tpAtaSmartAttributes.Location = New System.Drawing.Point(4, 22)
        Me.tpAtaSmartAttributes.Name = "tpAtaSmartAttributes"
        Me.tpAtaSmartAttributes.Padding = New System.Windows.Forms.Padding(3)
        Me.tpAtaSmartAttributes.Size = New System.Drawing.Size(868, 274)
        Me.tpAtaSmartAttributes.TabIndex = 4
        Me.tpAtaSmartAttributes.Text = "tpAtaSmartAttributes"
        '
        'tlpAttributes
        '
        Me.tlpAttributes.ColumnCount = 2
        Me.tlpAttributes.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpAttributes.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250.0!))
        Me.tlpAttributes.Controls.Add(Me.lvwSmart, 0, 0)
        Me.tlpAttributes.Controls.Add(Me.pnlAttribuesInfo, 1, 0)
        Me.tlpAttributes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpAttributes.Location = New System.Drawing.Point(3, 3)
        Me.tlpAttributes.Margin = New System.Windows.Forms.Padding(0, 0, 3, 3)
        Me.tlpAttributes.Name = "tlpAttributes"
        Me.tlpAttributes.RowCount = 1
        Me.tlpAttributes.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpAttributes.Size = New System.Drawing.Size(862, 268)
        Me.tlpAttributes.TabIndex = 27
        '
        'lvwSmart
        '
        Me.lvwSmart.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chStatus, Me.chID, Me.chAttribute, Me.chCurrent, Me.chWorst, Me.chThreshold, Me.chRawValue})
        Me.lvwSmart.Cursor = System.Windows.Forms.Cursors.Default
        Me.lvwSmart.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvwSmart.FullRowSelect = True
        Me.lvwSmart.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvwSmart.Location = New System.Drawing.Point(0, 0)
        Me.lvwSmart.Margin = New System.Windows.Forms.Padding(0)
        Me.lvwSmart.MultiSelect = False
        Me.lvwSmart.Name = "lvwSmart"
        Me.lvwSmart.Size = New System.Drawing.Size(612, 268)
        Me.lvwSmart.TabIndex = 0
        Me.lvwSmart.UseCompatibleStateImageBehavior = False
        Me.lvwSmart.View = System.Windows.Forms.View.Details
        '
        'chStatus
        '
        Me.chStatus.Text = "chStatus"
        '
        'chID
        '
        Me.chID.Text = "chID"
        Me.chID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'chAttribute
        '
        Me.chAttribute.Text = "chAttribute"
        Me.chAttribute.Width = 75
        '
        'chCurrent
        '
        Me.chCurrent.Text = "chCurrent"
        Me.chCurrent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'chWorst
        '
        Me.chWorst.Text = "chWorst"
        Me.chWorst.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'chThreshold
        '
        Me.chThreshold.Text = "chThreshold"
        Me.chThreshold.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.chThreshold.Width = 71
        '
        'chRawValue
        '
        Me.chRawValue.Text = "chRawValue"
        Me.chRawValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.chRawValue.Width = 74
        '
        'pnlAttribuesInfo
        '
        Me.pnlAttribuesInfo.AutoScroll = True
        Me.pnlAttribuesInfo.Controls.Add(Me.tlpAttributeDetails)
        Me.pnlAttribuesInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlAttribuesInfo.Location = New System.Drawing.Point(612, 0)
        Me.pnlAttribuesInfo.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlAttribuesInfo.Name = "pnlAttribuesInfo"
        Me.pnlAttribuesInfo.Size = New System.Drawing.Size(250, 268)
        Me.pnlAttribuesInfo.TabIndex = 1
        '
        'tlpAttributeDetails
        '
        Me.tlpAttributeDetails.AutoSize = True
        Me.tlpAttributeDetails.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlpAttributeDetails.ColumnCount = 1
        Me.tlpAttributeDetails.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpAttributeDetails.Controls.Add(Me.lblMeaning, 0, 3)
        Me.tlpAttributeDetails.Controls.Add(Me.lblDataStructure, 0, 0)
        Me.tlpAttributeDetails.Controls.Add(Me.lblTitle, 0, 2)
        Me.tlpAttributeDetails.Controls.Add(Me.tlpGraph, 0, 14)
        Me.tlpAttributeDetails.Controls.Add(Me.lblPrefailure, 0, 6)
        Me.tlpAttributeDetails.Controls.Add(Me.lblOnline, 0, 7)
        Me.tlpAttributeDetails.Controls.Add(Me.lblSpeed, 0, 8)
        Me.tlpAttributeDetails.Controls.Add(Me.lblErrRate, 0, 9)
        Me.tlpAttributeDetails.Controls.Add(Me.lblEvCount, 0, 10)
        Me.tlpAttributeDetails.Controls.Add(Me.lblSelfPres, 0, 11)
        Me.tlpAttributeDetails.Controls.Add(Me.lblFlags, 0, 5)
        Me.tlpAttributeDetails.Controls.Add(Me.lblGraph, 0, 13)
        Me.tlpAttributeDetails.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpAttributeDetails.Location = New System.Drawing.Point(0, 0)
        Me.tlpAttributeDetails.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.tlpAttributeDetails.Name = "tlpAttributeDetails"
        Me.tlpAttributeDetails.RowCount = 16
        Me.tlpAttributeDetails.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpAttributeDetails.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.tlpAttributeDetails.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpAttributeDetails.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpAttributeDetails.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.tlpAttributeDetails.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpAttributeDetails.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpAttributeDetails.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpAttributeDetails.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpAttributeDetails.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpAttributeDetails.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpAttributeDetails.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpAttributeDetails.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.tlpAttributeDetails.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpAttributeDetails.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpAttributeDetails.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.tlpAttributeDetails.Size = New System.Drawing.Size(233, 282)
        Me.tlpAttributeDetails.TabIndex = 28
        '
        'lblMeaning
        '
        Me.lblMeaning.AutoSize = True
        Me.lblMeaning.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblMeaning.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMeaning.ForeColor = System.Drawing.Color.Black
        Me.lblMeaning.Location = New System.Drawing.Point(3, 45)
        Me.lblMeaning.Margin = New System.Windows.Forms.Padding(3)
        Me.lblMeaning.Name = "lblMeaning"
        Me.lblMeaning.Size = New System.Drawing.Size(227, 13)
        Me.lblMeaning.TabIndex = 6
        Me.lblMeaning.Text = "lblMeaning"
        '
        'lblDataStructure
        '
        Me.lblDataStructure.AutoSize = True
        Me.lblDataStructure.ForeColor = System.Drawing.Color.Black
        Me.lblDataStructure.Location = New System.Drawing.Point(0, 0)
        Me.lblDataStructure.Margin = New System.Windows.Forms.Padding(0)
        Me.lblDataStructure.MinimumSize = New System.Drawing.Size(0, 16)
        Me.lblDataStructure.Name = "lblDataStructure"
        Me.lblDataStructure.Size = New System.Drawing.Size(85, 16)
        Me.lblDataStructure.TabIndex = 13
        Me.lblDataStructure.Text = "lblDataStructure"
        Me.lblDataStructure.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(0, 26)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTitle.MinimumSize = New System.Drawing.Size(0, 16)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(37, 16)
        Me.lblTitle.TabIndex = 6
        Me.lblTitle.Tag = "Group"
        Me.lblTitle.Text = "lblTitle"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpGraph
        '
        Me.tlpGraph.AutoSize = True
        Me.tlpGraph.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlpGraph.ColumnCount = 2
        Me.tlpGraph.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpGraph.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpGraph.Controls.Add(Me.lblThreshold, 0, 0)
        Me.tlpGraph.Controls.Add(Me.lblCurValue, 0, 1)
        Me.tlpGraph.Controls.Add(Me.fpbWorst, 1, 2)
        Me.tlpGraph.Controls.Add(Me.lblWorst, 0, 2)
        Me.tlpGraph.Controls.Add(Me.fpbCurValue, 1, 1)
        Me.tlpGraph.Controls.Add(Me.fpbThreshold, 1, 0)
        Me.tlpGraph.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpGraph.Location = New System.Drawing.Point(3, 212)
        Me.tlpGraph.Name = "tlpGraph"
        Me.tlpGraph.RowCount = 3
        Me.tlpGraph.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpGraph.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpGraph.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpGraph.Size = New System.Drawing.Size(227, 57)
        Me.tlpGraph.TabIndex = 8
        '
        'lblThreshold
        '
        Me.lblThreshold.AutoSize = True
        Me.lblThreshold.ForeColor = System.Drawing.Color.Black
        Me.lblThreshold.Location = New System.Drawing.Point(0, 0)
        Me.lblThreshold.Margin = New System.Windows.Forms.Padding(0)
        Me.lblThreshold.MinimumSize = New System.Drawing.Size(0, 16)
        Me.lblThreshold.Name = "lblThreshold"
        Me.lblThreshold.Size = New System.Drawing.Size(64, 16)
        Me.lblThreshold.TabIndex = 0
        Me.lblThreshold.Text = "lblThreshold"
        Me.lblThreshold.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCurValue
        '
        Me.lblCurValue.AutoSize = True
        Me.lblCurValue.ForeColor = System.Drawing.Color.Black
        Me.lblCurValue.Location = New System.Drawing.Point(0, 19)
        Me.lblCurValue.Margin = New System.Windows.Forms.Padding(0)
        Me.lblCurValue.MinimumSize = New System.Drawing.Size(0, 16)
        Me.lblCurValue.Name = "lblCurValue"
        Me.lblCurValue.Size = New System.Drawing.Size(60, 16)
        Me.lblCurValue.TabIndex = 1
        Me.lblCurValue.Text = "lblCurValue"
        Me.lblCurValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'fpbWorst
        '
        Me.fpbWorst.BackColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.fpbWorst.Barcolor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.fpbWorst.Dock = System.Windows.Forms.DockStyle.Top
        Me.fpbWorst.Location = New System.Drawing.Point(67, 38)
        Me.fpbWorst.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.fpbWorst.Name = "fpbWorst"
        Me.fpbWorst.Padding = New System.Windows.Forms.Padding(1)
        Me.fpbWorst.Size = New System.Drawing.Size(157, 16)
        Me.fpbWorst.TabIndex = 6
        Me.fpbWorst.Value = 50
        '
        'lblWorst
        '
        Me.lblWorst.AutoSize = True
        Me.lblWorst.ForeColor = System.Drawing.Color.Black
        Me.lblWorst.Location = New System.Drawing.Point(0, 38)
        Me.lblWorst.Margin = New System.Windows.Forms.Padding(0)
        Me.lblWorst.MinimumSize = New System.Drawing.Size(0, 16)
        Me.lblWorst.Name = "lblWorst"
        Me.lblWorst.Size = New System.Drawing.Size(46, 16)
        Me.lblWorst.TabIndex = 2
        Me.lblWorst.Text = "lblWorst"
        Me.lblWorst.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'fpbCurValue
        '
        Me.fpbCurValue.BackColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.fpbCurValue.Barcolor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.fpbCurValue.Dock = System.Windows.Forms.DockStyle.Top
        Me.fpbCurValue.Location = New System.Drawing.Point(67, 19)
        Me.fpbCurValue.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.fpbCurValue.Name = "fpbCurValue"
        Me.fpbCurValue.Padding = New System.Windows.Forms.Padding(1)
        Me.fpbCurValue.Size = New System.Drawing.Size(157, 16)
        Me.fpbCurValue.TabIndex = 5
        Me.fpbCurValue.Value = 50
        '
        'fpbThreshold
        '
        Me.fpbThreshold.BackColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.fpbThreshold.Barcolor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.fpbThreshold.Dock = System.Windows.Forms.DockStyle.Top
        Me.fpbThreshold.Location = New System.Drawing.Point(67, 0)
        Me.fpbThreshold.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.fpbThreshold.Name = "fpbThreshold"
        Me.fpbThreshold.Padding = New System.Windows.Forms.Padding(1)
        Me.fpbThreshold.Size = New System.Drawing.Size(157, 16)
        Me.fpbThreshold.TabIndex = 4
        Me.fpbThreshold.Value = 50
        '
        'lblPrefailure
        '
        Me.lblPrefailure.AutoSize = True
        Me.lblPrefailure.ForeColor = System.Drawing.Color.Black
        Me.lblPrefailure.Location = New System.Drawing.Point(3, 87)
        Me.lblPrefailure.Margin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.lblPrefailure.MinimumSize = New System.Drawing.Size(0, 16)
        Me.lblPrefailure.Name = "lblPrefailure"
        Me.lblPrefailure.Size = New System.Drawing.Size(63, 16)
        Me.lblPrefailure.TabIndex = 0
        Me.lblPrefailure.Text = "lblPrefailure"
        Me.lblPrefailure.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblOnline
        '
        Me.lblOnline.AutoSize = True
        Me.lblOnline.ForeColor = System.Drawing.Color.Black
        Me.lblOnline.Location = New System.Drawing.Point(3, 103)
        Me.lblOnline.Margin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.lblOnline.MinimumSize = New System.Drawing.Size(0, 16)
        Me.lblOnline.Name = "lblOnline"
        Me.lblOnline.Size = New System.Drawing.Size(47, 16)
        Me.lblOnline.TabIndex = 1
        Me.lblOnline.Text = "lblOnline"
        Me.lblOnline.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSpeed
        '
        Me.lblSpeed.AutoSize = True
        Me.lblSpeed.ForeColor = System.Drawing.Color.Black
        Me.lblSpeed.Location = New System.Drawing.Point(3, 119)
        Me.lblSpeed.Margin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.lblSpeed.MinimumSize = New System.Drawing.Size(0, 16)
        Me.lblSpeed.Name = "lblSpeed"
        Me.lblSpeed.Size = New System.Drawing.Size(47, 16)
        Me.lblSpeed.TabIndex = 2
        Me.lblSpeed.Text = "lblSpeed"
        Me.lblSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblErrRate
        '
        Me.lblErrRate.AutoSize = True
        Me.lblErrRate.ForeColor = System.Drawing.Color.Black
        Me.lblErrRate.Location = New System.Drawing.Point(3, 135)
        Me.lblErrRate.Margin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.lblErrRate.MinimumSize = New System.Drawing.Size(0, 16)
        Me.lblErrRate.Name = "lblErrRate"
        Me.lblErrRate.Size = New System.Drawing.Size(54, 16)
        Me.lblErrRate.TabIndex = 3
        Me.lblErrRate.Text = "lblErrRate"
        Me.lblErrRate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblEvCount
        '
        Me.lblEvCount.AutoSize = True
        Me.lblEvCount.ForeColor = System.Drawing.Color.Black
        Me.lblEvCount.Location = New System.Drawing.Point(3, 151)
        Me.lblEvCount.Margin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.lblEvCount.MinimumSize = New System.Drawing.Size(0, 16)
        Me.lblEvCount.Name = "lblEvCount"
        Me.lblEvCount.Size = New System.Drawing.Size(58, 16)
        Me.lblEvCount.TabIndex = 4
        Me.lblEvCount.Text = "lblEvCount"
        Me.lblEvCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSelfPres
        '
        Me.lblSelfPres.AutoSize = True
        Me.lblSelfPres.ForeColor = System.Drawing.Color.Black
        Me.lblSelfPres.Location = New System.Drawing.Point(3, 167)
        Me.lblSelfPres.Margin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.lblSelfPres.MinimumSize = New System.Drawing.Size(0, 16)
        Me.lblSelfPres.Name = "lblSelfPres"
        Me.lblSelfPres.Size = New System.Drawing.Size(56, 16)
        Me.lblSelfPres.TabIndex = 5
        Me.lblSelfPres.Text = "lblSelfPres"
        Me.lblSelfPres.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFlags
        '
        Me.lblFlags.AutoSize = True
        Me.lblFlags.ForeColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblFlags.Location = New System.Drawing.Point(0, 71)
        Me.lblFlags.Margin = New System.Windows.Forms.Padding(0)
        Me.lblFlags.MinimumSize = New System.Drawing.Size(0, 16)
        Me.lblFlags.Name = "lblFlags"
        Me.lblFlags.Size = New System.Drawing.Size(42, 16)
        Me.lblFlags.TabIndex = 6
        Me.lblFlags.Tag = "Group"
        Me.lblFlags.Text = "lblFlags"
        Me.lblFlags.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblGraph
        '
        Me.lblGraph.AutoSize = True
        Me.lblGraph.ForeColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblGraph.Location = New System.Drawing.Point(0, 193)
        Me.lblGraph.Margin = New System.Windows.Forms.Padding(0)
        Me.lblGraph.MinimumSize = New System.Drawing.Size(0, 16)
        Me.lblGraph.Name = "lblGraph"
        Me.lblGraph.Size = New System.Drawing.Size(46, 16)
        Me.lblGraph.TabIndex = 7
        Me.lblGraph.Tag = "Group"
        Me.lblGraph.Text = "lblGraph"
        Me.lblGraph.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tpScsiHealth
        '
        Me.tpScsiHealth.BackColor = System.Drawing.Color.White
        Me.tpScsiHealth.Controls.Add(Me.tlpScsiHealth)
        Me.tpScsiHealth.Location = New System.Drawing.Point(4, 22)
        Me.tpScsiHealth.Name = "tpScsiHealth"
        Me.tpScsiHealth.Size = New System.Drawing.Size(868, 274)
        Me.tpScsiHealth.TabIndex = 6
        Me.tpScsiHealth.Text = "tpScsiHealth"
        '
        'tlpScsiHealth
        '
        Me.tlpScsiHealth.AutoSize = True
        Me.tlpScsiHealth.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlpScsiHealth.ColumnCount = 3
        Me.tlpScsiHealth.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpScsiHealth.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpScsiHealth.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpScsiHealth.Controls.Add(Me.lblScsiHealth, 0, 0)
        Me.tlpScsiHealth.Controls.Add(Me.lblScsiGrownDefects, 2, 3)
        Me.tlpScsiHealth.Controls.Add(Me.lblScsiOverallHealth, 1, 2)
        Me.tlpScsiHealth.Controls.Add(Me.lblScsiTempValue, 2, 0)
        Me.tlpScsiHealth.Controls.Add(Me.lblScsiTemp, 1, 0)
        Me.tlpScsiHealth.Controls.Add(Me.lblScsiLastTest, 1, 1)
        Me.tlpScsiHealth.Controls.Add(Me.lblScsiHealthValue, 2, 2)
        Me.tlpScsiHealth.Controls.Add(Me.lblScsiLastTestValue, 2, 1)
        Me.tlpScsiHealth.Controls.Add(Me.lblScsiErrors, 2, 4)
        Me.tlpScsiHealth.Controls.Add(Me.lblScsiLastUpdateValue, 2, 6)
        Me.tlpScsiHealth.Controls.Add(Me.lblScsiLastUpdate, 1, 6)
        Me.tlpScsiHealth.Controls.Add(Me.lblScsiWorkTime, 1, 5)
        Me.tlpScsiHealth.Controls.Add(Me.lblScsiWorkTimeValue, 2, 5)
        Me.tlpScsiHealth.Location = New System.Drawing.Point(0, 5)
        Me.tlpScsiHealth.Name = "tlpScsiHealth"
        Me.tlpScsiHealth.RowCount = 7
        Me.tlpScsiHealth.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpScsiHealth.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpScsiHealth.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpScsiHealth.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpScsiHealth.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpScsiHealth.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpScsiHealth.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpScsiHealth.Size = New System.Drawing.Size(294, 112)
        Me.tlpScsiHealth.TabIndex = 2
        '
        'lblScsiHealth
        '
        Me.lblScsiHealth.AutoSize = True
        Me.lblScsiHealth.ForeColor = System.Drawing.Color.DimGray
        Me.lblScsiHealth.Location = New System.Drawing.Point(0, 0)
        Me.lblScsiHealth.Margin = New System.Windows.Forms.Padding(0, 0, 3, 3)
        Me.lblScsiHealth.Name = "lblScsiHealth"
        Me.lblScsiHealth.Size = New System.Drawing.Size(66, 13)
        Me.lblScsiHealth.TabIndex = 51
        Me.lblScsiHealth.Tag = "Grayed"
        Me.lblScsiHealth.Text = "lblScsiHealth"
        '
        'lblScsiGrownDefects
        '
        Me.lblScsiGrownDefects.AutoSize = True
        Me.lblScsiGrownDefects.ForeColor = System.Drawing.Color.Black
        Me.lblScsiGrownDefects.Location = New System.Drawing.Point(175, 48)
        Me.lblScsiGrownDefects.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.lblScsiGrownDefects.Name = "lblScsiGrownDefects"
        Me.lblScsiGrownDefects.Size = New System.Drawing.Size(103, 13)
        Me.lblScsiGrownDefects.TabIndex = 5
        Me.lblScsiGrownDefects.Text = "lblScsiGrownDefects"
        '
        'lblScsiOverallHealth
        '
        Me.lblScsiOverallHealth.AutoSize = True
        Me.lblScsiOverallHealth.ForeColor = System.Drawing.Color.Black
        Me.lblScsiOverallHealth.Location = New System.Drawing.Point(69, 32)
        Me.lblScsiOverallHealth.Margin = New System.Windows.Forms.Padding(0, 0, 3, 3)
        Me.lblScsiOverallHealth.Name = "lblScsiOverallHealth"
        Me.lblScsiOverallHealth.Size = New System.Drawing.Size(100, 13)
        Me.lblScsiOverallHealth.TabIndex = 9
        Me.lblScsiOverallHealth.Text = "lblScsiOverallHealth"
        '
        'lblScsiTempValue
        '
        Me.lblScsiTempValue.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblScsiTempValue.AutoSize = True
        Me.lblScsiTempValue.ForeColor = System.Drawing.Color.Black
        Me.lblScsiTempValue.Location = New System.Drawing.Point(175, 0)
        Me.lblScsiTempValue.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.lblScsiTempValue.Name = "lblScsiTempValue"
        Me.lblScsiTempValue.Size = New System.Drawing.Size(87, 13)
        Me.lblScsiTempValue.TabIndex = 1
        Me.lblScsiTempValue.Text = "lblScsiTempValue"
        '
        'lblScsiTemp
        '
        Me.lblScsiTemp.AutoSize = True
        Me.lblScsiTemp.ForeColor = System.Drawing.Color.Black
        Me.lblScsiTemp.Location = New System.Drawing.Point(69, 0)
        Me.lblScsiTemp.Margin = New System.Windows.Forms.Padding(0, 0, 3, 3)
        Me.lblScsiTemp.Name = "lblScsiTemp"
        Me.lblScsiTemp.Size = New System.Drawing.Size(61, 13)
        Me.lblScsiTemp.TabIndex = 0
        Me.lblScsiTemp.Text = "lblScsiTemp"
        '
        'lblScsiLastTest
        '
        Me.lblScsiLastTest.AutoSize = True
        Me.lblScsiLastTest.ForeColor = System.Drawing.Color.Black
        Me.lblScsiLastTest.Location = New System.Drawing.Point(69, 16)
        Me.lblScsiLastTest.Margin = New System.Windows.Forms.Padding(0, 0, 3, 3)
        Me.lblScsiLastTest.Name = "lblScsiLastTest"
        Me.lblScsiLastTest.Size = New System.Drawing.Size(76, 13)
        Me.lblScsiLastTest.TabIndex = 6
        Me.lblScsiLastTest.Text = "lblScsiLastTest"
        '
        'lblScsiHealthValue
        '
        Me.lblScsiHealthValue.AutoSize = True
        Me.lblScsiHealthValue.ForeColor = System.Drawing.Color.Black
        Me.lblScsiHealthValue.Location = New System.Drawing.Point(175, 32)
        Me.lblScsiHealthValue.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.lblScsiHealthValue.Name = "lblScsiHealthValue"
        Me.lblScsiHealthValue.Size = New System.Drawing.Size(92, 13)
        Me.lblScsiHealthValue.TabIndex = 11
        Me.lblScsiHealthValue.Text = "lblScsiHealthValue"
        '
        'lblScsiLastTestValue
        '
        Me.lblScsiLastTestValue.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblScsiLastTestValue.AutoSize = True
        Me.lblScsiLastTestValue.ForeColor = System.Drawing.Color.Black
        Me.lblScsiLastTestValue.Location = New System.Drawing.Point(175, 16)
        Me.lblScsiLastTestValue.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.lblScsiLastTestValue.Name = "lblScsiLastTestValue"
        Me.lblScsiLastTestValue.Size = New System.Drawing.Size(102, 13)
        Me.lblScsiLastTestValue.TabIndex = 8
        Me.lblScsiLastTestValue.Text = "lblScsiLastTestValue"
        '
        'lblScsiErrors
        '
        Me.lblScsiErrors.AutoSize = True
        Me.lblScsiErrors.ForeColor = System.Drawing.Color.Black
        Me.lblScsiErrors.Location = New System.Drawing.Point(175, 64)
        Me.lblScsiErrors.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.lblScsiErrors.Name = "lblScsiErrors"
        Me.lblScsiErrors.Size = New System.Drawing.Size(64, 13)
        Me.lblScsiErrors.TabIndex = 12
        Me.lblScsiErrors.Text = "lblScsiErrors"
        '
        'lblScsiLastUpdateValue
        '
        Me.lblScsiLastUpdateValue.AutoSize = True
        Me.lblScsiLastUpdateValue.ForeColor = System.Drawing.Color.Black
        Me.lblScsiLastUpdateValue.Location = New System.Drawing.Point(175, 96)
        Me.lblScsiLastUpdateValue.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.lblScsiLastUpdateValue.Name = "lblScsiLastUpdateValue"
        Me.lblScsiLastUpdateValue.Size = New System.Drawing.Size(116, 13)
        Me.lblScsiLastUpdateValue.TabIndex = 59
        Me.lblScsiLastUpdateValue.Text = "lblScsiLastUpdateValue"
        '
        'lblScsiLastUpdate
        '
        Me.lblScsiLastUpdate.AutoSize = True
        Me.lblScsiLastUpdate.ForeColor = System.Drawing.Color.Black
        Me.lblScsiLastUpdate.Location = New System.Drawing.Point(69, 96)
        Me.lblScsiLastUpdate.Margin = New System.Windows.Forms.Padding(0, 0, 3, 3)
        Me.lblScsiLastUpdate.Name = "lblScsiLastUpdate"
        Me.lblScsiLastUpdate.Size = New System.Drawing.Size(90, 13)
        Me.lblScsiLastUpdate.TabIndex = 58
        Me.lblScsiLastUpdate.Text = "lblScsiLastUpdate"
        '
        'lblScsiWorkTime
        '
        Me.lblScsiWorkTime.AutoSize = True
        Me.lblScsiWorkTime.ForeColor = System.Drawing.Color.Black
        Me.lblScsiWorkTime.Location = New System.Drawing.Point(69, 80)
        Me.lblScsiWorkTime.Margin = New System.Windows.Forms.Padding(0, 0, 3, 3)
        Me.lblScsiWorkTime.Name = "lblScsiWorkTime"
        Me.lblScsiWorkTime.Size = New System.Drawing.Size(82, 13)
        Me.lblScsiWorkTime.TabIndex = 60
        Me.lblScsiWorkTime.Text = "lblScsiWorkTime"
        '
        'lblScsiWorkTimeValue
        '
        Me.lblScsiWorkTimeValue.AutoSize = True
        Me.lblScsiWorkTimeValue.ForeColor = System.Drawing.Color.Black
        Me.lblScsiWorkTimeValue.Location = New System.Drawing.Point(175, 80)
        Me.lblScsiWorkTimeValue.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.lblScsiWorkTimeValue.Name = "lblScsiWorkTimeValue"
        Me.lblScsiWorkTimeValue.Size = New System.Drawing.Size(108, 13)
        Me.lblScsiWorkTimeValue.TabIndex = 61
        Me.lblScsiWorkTimeValue.Text = "lblScsiWorkTimeValue"
        '
        'tpScsiInfo
        '
        Me.tpScsiInfo.BackColor = System.Drawing.Color.White
        Me.tpScsiInfo.Controls.Add(Me.tlpScsiInfoContainer)
        Me.tpScsiInfo.Location = New System.Drawing.Point(4, 22)
        Me.tpScsiInfo.Name = "tpScsiInfo"
        Me.tpScsiInfo.Size = New System.Drawing.Size(868, 274)
        Me.tpScsiInfo.TabIndex = 1
        Me.tpScsiInfo.Text = "tpScsiInfo"
        '
        'tlpScsiInfoContainer
        '
        Me.tlpScsiInfoContainer.AutoSize = True
        Me.tlpScsiInfoContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlpScsiInfoContainer.ColumnCount = 2
        Me.tlpScsiInfoContainer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpScsiInfoContainer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpScsiInfoContainer.Controls.Add(Me.tlpScsiInfo, 1, 2)
        Me.tlpScsiInfoContainer.Controls.Add(Me.flwScsiVendor, 1, 0)
        Me.tlpScsiInfoContainer.Controls.Add(Me.picScsiVendor, 0, 0)
        Me.tlpScsiInfoContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpScsiInfoContainer.Location = New System.Drawing.Point(0, 0)
        Me.tlpScsiInfoContainer.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpScsiInfoContainer.Name = "tlpScsiInfoContainer"
        Me.tlpScsiInfoContainer.RowCount = 3
        Me.tlpScsiInfoContainer.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpScsiInfoContainer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpScsiInfoContainer.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpScsiInfoContainer.Size = New System.Drawing.Size(868, 274)
        Me.tlpScsiInfoContainer.TabIndex = 8
        '
        'tlpScsiInfo
        '
        Me.tlpScsiInfo.AutoSize = True
        Me.tlpScsiInfo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlpScsiInfo.ColumnCount = 2
        Me.tlpScsiInfo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpScsiInfo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpScsiInfo.Controls.Add(Me.lblScsiSmartStatusValue, 1, 7)
        Me.tlpScsiInfo.Controls.Add(Me.lblScsiProtocolValue, 1, 6)
        Me.tlpScsiInfo.Controls.Add(Me.lblScsiRotationValue, 1, 5)
        Me.tlpScsiInfo.Controls.Add(Me.lblScsiSmartStatus, 0, 7)
        Me.tlpScsiInfo.Controls.Add(Me.lblScsiBlockSizeValue, 1, 4)
        Me.tlpScsiInfo.Controls.Add(Me.lblScsiTotalSizeValue, 1, 3)
        Me.tlpScsiInfo.Controls.Add(Me.lblScsiUnitIdValue, 1, 2)
        Me.tlpScsiInfo.Controls.Add(Me.lblScsiSerialValue, 1, 1)
        Me.tlpScsiInfo.Controls.Add(Me.lblScsiRevisionValue, 1, 0)
        Me.tlpScsiInfo.Controls.Add(Me.lblScsiProtocol, 0, 6)
        Me.tlpScsiInfo.Controls.Add(Me.lblScsiRotation, 0, 5)
        Me.tlpScsiInfo.Controls.Add(Me.lblScsiUnitId, 0, 2)
        Me.tlpScsiInfo.Controls.Add(Me.lblScsiSerial, 0, 1)
        Me.tlpScsiInfo.Controls.Add(Me.lblScsiRevision, 0, 0)
        Me.tlpScsiInfo.Controls.Add(Me.lblScsiTotalSize, 0, 3)
        Me.tlpScsiInfo.Controls.Add(Me.lblScsiBlockSize, 0, 4)
        Me.tlpScsiInfo.Location = New System.Drawing.Point(176, 79)
        Me.tlpScsiInfo.Margin = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.tlpScsiInfo.Name = "tlpScsiInfo"
        Me.tlpScsiInfo.RowCount = 8
        Me.tlpScsiInfo.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpScsiInfo.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpScsiInfo.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpScsiInfo.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpScsiInfo.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpScsiInfo.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpScsiInfo.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpScsiInfo.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpScsiInfo.Size = New System.Drawing.Size(226, 128)
        Me.tlpScsiInfo.TabIndex = 1
        '
        'lblScsiSmartStatusValue
        '
        Me.lblScsiSmartStatusValue.AutoSize = True
        Me.lblScsiSmartStatusValue.ForeColor = System.Drawing.Color.Black
        Me.lblScsiSmartStatusValue.Location = New System.Drawing.Point(103, 112)
        Me.lblScsiSmartStatusValue.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.lblScsiSmartStatusValue.Name = "lblScsiSmartStatusValue"
        Me.lblScsiSmartStatusValue.Size = New System.Drawing.Size(120, 13)
        Me.lblScsiSmartStatusValue.TabIndex = 23
        Me.lblScsiSmartStatusValue.Text = "lblScsiSmartStatusValue"
        '
        'lblScsiProtocolValue
        '
        Me.lblScsiProtocolValue.AutoSize = True
        Me.lblScsiProtocolValue.ForeColor = System.Drawing.Color.Black
        Me.lblScsiProtocolValue.Location = New System.Drawing.Point(103, 96)
        Me.lblScsiProtocolValue.Name = "lblScsiProtocolValue"
        Me.lblScsiProtocolValue.Size = New System.Drawing.Size(100, 13)
        Me.lblScsiProtocolValue.TabIndex = 21
        Me.lblScsiProtocolValue.Text = "lblScsiProtocolValue"
        '
        'lblScsiRotationValue
        '
        Me.lblScsiRotationValue.AutoSize = True
        Me.lblScsiRotationValue.ForeColor = System.Drawing.Color.Black
        Me.lblScsiRotationValue.Location = New System.Drawing.Point(103, 80)
        Me.lblScsiRotationValue.Name = "lblScsiRotationValue"
        Me.lblScsiRotationValue.Size = New System.Drawing.Size(102, 13)
        Me.lblScsiRotationValue.TabIndex = 19
        Me.lblScsiRotationValue.Text = "lblScsiRotationValue"
        '
        'lblScsiSmartStatus
        '
        Me.lblScsiSmartStatus.AutoSize = True
        Me.lblScsiSmartStatus.ForeColor = System.Drawing.Color.Black
        Me.lblScsiSmartStatus.Location = New System.Drawing.Point(3, 112)
        Me.lblScsiSmartStatus.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.lblScsiSmartStatus.Name = "lblScsiSmartStatus"
        Me.lblScsiSmartStatus.Size = New System.Drawing.Size(94, 13)
        Me.lblScsiSmartStatus.TabIndex = 11
        Me.lblScsiSmartStatus.Text = "lblScsiSmartStatus"
        '
        'lblScsiBlockSizeValue
        '
        Me.lblScsiBlockSizeValue.AutoSize = True
        Me.lblScsiBlockSizeValue.ForeColor = System.Drawing.Color.Black
        Me.lblScsiBlockSizeValue.Location = New System.Drawing.Point(103, 64)
        Me.lblScsiBlockSizeValue.Name = "lblScsiBlockSizeValue"
        Me.lblScsiBlockSizeValue.Size = New System.Drawing.Size(104, 13)
        Me.lblScsiBlockSizeValue.TabIndex = 18
        Me.lblScsiBlockSizeValue.Text = "lblScsiBlockSizeValue"
        '
        'lblScsiTotalSizeValue
        '
        Me.lblScsiTotalSizeValue.AutoSize = True
        Me.lblScsiTotalSizeValue.ForeColor = System.Drawing.Color.Black
        Me.lblScsiTotalSizeValue.Location = New System.Drawing.Point(103, 48)
        Me.lblScsiTotalSizeValue.Name = "lblScsiTotalSizeValue"
        Me.lblScsiTotalSizeValue.Size = New System.Drawing.Size(104, 13)
        Me.lblScsiTotalSizeValue.TabIndex = 17
        Me.lblScsiTotalSizeValue.Text = "lblScsiTotalSizeValue"
        '
        'lblScsiUnitIdValue
        '
        Me.lblScsiUnitIdValue.AutoSize = True
        Me.lblScsiUnitIdValue.ForeColor = System.Drawing.Color.Black
        Me.lblScsiUnitIdValue.Location = New System.Drawing.Point(103, 32)
        Me.lblScsiUnitIdValue.Name = "lblScsiUnitIdValue"
        Me.lblScsiUnitIdValue.Size = New System.Drawing.Size(90, 13)
        Me.lblScsiUnitIdValue.TabIndex = 16
        Me.lblScsiUnitIdValue.Text = "lblScsiUnitIdValue"
        '
        'lblScsiSerialValue
        '
        Me.lblScsiSerialValue.AutoSize = True
        Me.lblScsiSerialValue.ForeColor = System.Drawing.Color.Black
        Me.lblScsiSerialValue.Location = New System.Drawing.Point(103, 16)
        Me.lblScsiSerialValue.Name = "lblScsiSerialValue"
        Me.lblScsiSerialValue.Size = New System.Drawing.Size(87, 13)
        Me.lblScsiSerialValue.TabIndex = 15
        Me.lblScsiSerialValue.Text = "lblScsiSerialValue"
        '
        'lblScsiRevisionValue
        '
        Me.lblScsiRevisionValue.AutoSize = True
        Me.lblScsiRevisionValue.ForeColor = System.Drawing.Color.Black
        Me.lblScsiRevisionValue.Location = New System.Drawing.Point(103, 0)
        Me.lblScsiRevisionValue.Name = "lblScsiRevisionValue"
        Me.lblScsiRevisionValue.Size = New System.Drawing.Size(101, 13)
        Me.lblScsiRevisionValue.TabIndex = 14
        Me.lblScsiRevisionValue.Text = "lblScsiRevisionValue"
        '
        'lblScsiProtocol
        '
        Me.lblScsiProtocol.AutoSize = True
        Me.lblScsiProtocol.ForeColor = System.Drawing.Color.Black
        Me.lblScsiProtocol.Location = New System.Drawing.Point(3, 96)
        Me.lblScsiProtocol.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.lblScsiProtocol.Name = "lblScsiProtocol"
        Me.lblScsiProtocol.Size = New System.Drawing.Size(74, 13)
        Me.lblScsiProtocol.TabIndex = 9
        Me.lblScsiProtocol.Text = "lblScsiProtocol"
        '
        'lblScsiRotation
        '
        Me.lblScsiRotation.AutoSize = True
        Me.lblScsiRotation.ForeColor = System.Drawing.Color.Black
        Me.lblScsiRotation.Location = New System.Drawing.Point(3, 80)
        Me.lblScsiRotation.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.lblScsiRotation.Name = "lblScsiRotation"
        Me.lblScsiRotation.Size = New System.Drawing.Size(76, 13)
        Me.lblScsiRotation.TabIndex = 7
        Me.lblScsiRotation.Text = "lblScsiRotation"
        '
        'lblScsiUnitId
        '
        Me.lblScsiUnitId.AutoSize = True
        Me.lblScsiUnitId.ForeColor = System.Drawing.Color.Black
        Me.lblScsiUnitId.Location = New System.Drawing.Point(3, 32)
        Me.lblScsiUnitId.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.lblScsiUnitId.Name = "lblScsiUnitId"
        Me.lblScsiUnitId.Size = New System.Drawing.Size(64, 13)
        Me.lblScsiUnitId.TabIndex = 4
        Me.lblScsiUnitId.Text = "lblScsiUnitId"
        '
        'lblScsiSerial
        '
        Me.lblScsiSerial.AutoSize = True
        Me.lblScsiSerial.ForeColor = System.Drawing.Color.Black
        Me.lblScsiSerial.Location = New System.Drawing.Point(3, 16)
        Me.lblScsiSerial.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.lblScsiSerial.Name = "lblScsiSerial"
        Me.lblScsiSerial.Size = New System.Drawing.Size(61, 13)
        Me.lblScsiSerial.TabIndex = 3
        Me.lblScsiSerial.Text = "lblScsiSerial"
        '
        'lblScsiRevision
        '
        Me.lblScsiRevision.AutoSize = True
        Me.lblScsiRevision.ForeColor = System.Drawing.Color.Black
        Me.lblScsiRevision.Location = New System.Drawing.Point(3, 0)
        Me.lblScsiRevision.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.lblScsiRevision.Name = "lblScsiRevision"
        Me.lblScsiRevision.Size = New System.Drawing.Size(75, 13)
        Me.lblScsiRevision.TabIndex = 2
        Me.lblScsiRevision.Text = "lblScsiRevision"
        '
        'lblScsiTotalSize
        '
        Me.lblScsiTotalSize.AutoSize = True
        Me.lblScsiTotalSize.ForeColor = System.Drawing.Color.Black
        Me.lblScsiTotalSize.Location = New System.Drawing.Point(3, 48)
        Me.lblScsiTotalSize.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.lblScsiTotalSize.Name = "lblScsiTotalSize"
        Me.lblScsiTotalSize.Size = New System.Drawing.Size(78, 13)
        Me.lblScsiTotalSize.TabIndex = 5
        Me.lblScsiTotalSize.Text = "lblScsiTotalSize"
        '
        'lblScsiBlockSize
        '
        Me.lblScsiBlockSize.AutoSize = True
        Me.lblScsiBlockSize.ForeColor = System.Drawing.Color.Black
        Me.lblScsiBlockSize.Location = New System.Drawing.Point(3, 64)
        Me.lblScsiBlockSize.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.lblScsiBlockSize.Name = "lblScsiBlockSize"
        Me.lblScsiBlockSize.Size = New System.Drawing.Size(78, 13)
        Me.lblScsiBlockSize.TabIndex = 6
        Me.lblScsiBlockSize.Text = "lblScsiBlockSize"
        '
        'flwScsiVendor
        '
        Me.flwScsiVendor.AutoSize = True
        Me.flwScsiVendor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.flwScsiVendor.Controls.Add(Me.lnkVendor)
        Me.flwScsiVendor.Controls.Add(Me.lblScsiModel)
        Me.flwScsiVendor.Location = New System.Drawing.Point(176, 0)
        Me.flwScsiVendor.Margin = New System.Windows.Forms.Padding(0)
        Me.flwScsiVendor.Name = "flwScsiVendor"
        Me.flwScsiVendor.Size = New System.Drawing.Size(129, 35)
        Me.flwScsiVendor.TabIndex = 45
        '
        'lnkVendor
        '
        Me.lnkVendor.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lnkVendor.AutoSize = True
        Me.flwScsiVendor.SetFlowBreak(Me.lnkVendor, True)
        Me.lnkVendor.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lnkVendor.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lnkVendor.Location = New System.Drawing.Point(3, 3)
        Me.lnkVendor.Margin = New System.Windows.Forms.Padding(3)
        Me.lnkVendor.Name = "lnkVendor"
        Me.lnkVendor.Size = New System.Drawing.Size(54, 13)
        Me.lnkVendor.TabIndex = 2
        Me.lnkVendor.TabStop = True
        Me.lnkVendor.Text = "lnkVendor"
        '
        'lblScsiModel
        '
        Me.lblScsiModel.AutoSize = True
        Me.flwScsiVendor.SetFlowBreak(Me.lblScsiModel, True)
        Me.lblScsiModel.ForeColor = System.Drawing.Color.Black
        Me.lblScsiModel.Location = New System.Drawing.Point(3, 19)
        Me.lblScsiModel.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.lblScsiModel.Name = "lblScsiModel"
        Me.lblScsiModel.Size = New System.Drawing.Size(63, 13)
        Me.lblScsiModel.TabIndex = 1
        Me.lblScsiModel.Text = "lblScsiModel"
        '
        'picScsiVendor
        '
        Me.picScsiVendor.Location = New System.Drawing.Point(3, 3)
        Me.picScsiVendor.MaximumSize = New System.Drawing.Size(170, 50)
        Me.picScsiVendor.MinimumSize = New System.Drawing.Size(170, 50)
        Me.picScsiVendor.Name = "picScsiVendor"
        Me.picScsiVendor.Size = New System.Drawing.Size(170, 50)
        Me.picScsiVendor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picScsiVendor.TabIndex = 7
        Me.picScsiVendor.TabStop = False
        '
        'tpEventsLog
        '
        Me.tpEventsLog.BackColor = System.Drawing.Color.White
        Me.tpEventsLog.Controls.Add(Me.tlpLogViewerContent)
        Me.tpEventsLog.Location = New System.Drawing.Point(4, 22)
        Me.tpEventsLog.Name = "tpEventsLog"
        Me.tpEventsLog.Size = New System.Drawing.Size(868, 274)
        Me.tpEventsLog.TabIndex = 2
        Me.tpEventsLog.Text = "tpEventsLog"
        '
        'tlpLogViewerContent
        '
        Me.tlpLogViewerContent.AutoSize = True
        Me.tlpLogViewerContent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlpLogViewerContent.ColumnCount = 1
        Me.tlpLogViewerContent.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpLogViewerContent.Controls.Add(Me.lvwLog, 0, 2)
        Me.tlpLogViewerContent.Controls.Add(Me.tlpLogViewer, 0, 0)
        Me.tlpLogViewerContent.Controls.Add(Me.lblLogItems, 0, 1)
        Me.tlpLogViewerContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpLogViewerContent.Location = New System.Drawing.Point(0, 0)
        Me.tlpLogViewerContent.Name = "tlpLogViewerContent"
        Me.tlpLogViewerContent.RowCount = 3
        Me.tlpLogViewerContent.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpLogViewerContent.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpLogViewerContent.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpLogViewerContent.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpLogViewerContent.Size = New System.Drawing.Size(868, 274)
        Me.tlpLogViewerContent.TabIndex = 24
        '
        'lvwLog
        '
        Me.lvwLog.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chAttrLog, Me.chTime, Me.chFrom, Me.chTo, Me.chVariation})
        Me.lvwLog.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvwLog.FullRowSelect = True
        Me.lvwLog.Location = New System.Drawing.Point(3, 62)
        Me.lvwLog.MinimumSize = New System.Drawing.Size(4, 200)
        Me.lvwLog.MultiSelect = False
        Me.lvwLog.Name = "lvwLog"
        Me.lvwLog.Size = New System.Drawing.Size(862, 209)
        Me.lvwLog.TabIndex = 7
        Me.lvwLog.UseCompatibleStateImageBehavior = False
        Me.lvwLog.View = System.Windows.Forms.View.Details
        '
        'chAttrLog
        '
        Me.chAttrLog.Text = "chAttrLog"
        '
        'chTime
        '
        Me.chTime.Text = "chTime"
        '
        'chFrom
        '
        Me.chFrom.Text = "chFrom"
        Me.chFrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'chTo
        '
        Me.chTo.Text = "chTo"
        Me.chTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'chVariation
        '
        Me.chVariation.Text = "chVariation"
        Me.chVariation.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tlpLogViewer
        '
        Me.tlpLogViewer.AutoSize = True
        Me.tlpLogViewer.ColumnCount = 7
        Me.tlpLogViewer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpLogViewer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpLogViewer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpLogViewer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpLogViewer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpLogViewer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpLogViewer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpLogViewer.Controls.Add(Me.btnSaveLog, 6, 0)
        Me.tlpLogViewer.Controls.Add(Me.btnCopy, 5, 0)
        Me.tlpLogViewer.Controls.Add(Me.btnNext, 3, 0)
        Me.tlpLogViewer.Controls.Add(Me.dteLog, 0, 0)
        Me.tlpLogViewer.Controls.Add(Me.btnToday, 2, 0)
        Me.tlpLogViewer.Controls.Add(Me.btnPrev, 1, 0)
        Me.tlpLogViewer.Controls.Add(Me.btnReload, 4, 0)
        Me.tlpLogViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpLogViewer.Location = New System.Drawing.Point(3, 3)
        Me.tlpLogViewer.Name = "tlpLogViewer"
        Me.tlpLogViewer.RowCount = 1
        Me.tlpLogViewer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpLogViewer.Size = New System.Drawing.Size(862, 30)
        Me.tlpLogViewer.TabIndex = 23
        '
        'btnSaveLog
        '
        Me.btnSaveLog.Location = New System.Drawing.Point(835, 3)
        Me.btnSaveLog.Name = "btnSaveLog"
        Me.btnSaveLog.Size = New System.Drawing.Size(24, 24)
        Me.btnSaveLog.TabIndex = 6
        Me.btnSaveLog.UseVisualStyleBackColor = True
        '
        'btnCopy
        '
        Me.btnCopy.Location = New System.Drawing.Point(805, 3)
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(24, 24)
        Me.btnCopy.TabIndex = 5
        Me.btnCopy.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(274, 3)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(24, 24)
        Me.btnNext.TabIndex = 3
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'dteLog
        '
        Me.dteLog.Location = New System.Drawing.Point(0, 3)
        Me.dteLog.Margin = New System.Windows.Forms.Padding(0, 3, 3, 3)
        Me.dteLog.MinimumSize = New System.Drawing.Size(4, 24)
        Me.dteLog.Name = "dteLog"
        Me.dteLog.Size = New System.Drawing.Size(208, 24)
        Me.dteLog.TabIndex = 0
        '
        'btnToday
        '
        Me.btnToday.Location = New System.Drawing.Point(244, 3)
        Me.btnToday.Name = "btnToday"
        Me.btnToday.Size = New System.Drawing.Size(24, 24)
        Me.btnToday.TabIndex = 2
        Me.btnToday.UseVisualStyleBackColor = True
        '
        'btnPrev
        '
        Me.btnPrev.Location = New System.Drawing.Point(214, 3)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(24, 24)
        Me.btnPrev.TabIndex = 1
        Me.btnPrev.UseVisualStyleBackColor = True
        '
        'btnReload
        '
        Me.btnReload.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnReload.Location = New System.Drawing.Point(775, 3)
        Me.btnReload.MinimumSize = New System.Drawing.Size(24, 24)
        Me.btnReload.Name = "btnReload"
        Me.btnReload.Size = New System.Drawing.Size(24, 24)
        Me.btnReload.TabIndex = 4
        Me.btnReload.UseVisualStyleBackColor = True
        '
        'lblLogItems
        '
        Me.lblLogItems.AutoSize = True
        Me.lblLogItems.ForeColor = System.Drawing.Color.Black
        Me.lblLogItems.Location = New System.Drawing.Point(3, 36)
        Me.lblLogItems.MinimumSize = New System.Drawing.Size(0, 23)
        Me.lblLogItems.Name = "lblLogItems"
        Me.lblLogItems.Size = New System.Drawing.Size(61, 23)
        Me.lblLogItems.TabIndex = 22
        Me.lblLogItems.Text = "lblLogItems"
        Me.lblLogItems.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tpEventsChart
        '
        Me.tpEventsChart.BackColor = System.Drawing.Color.White
        Me.tpEventsChart.Controls.Add(Me.tlpChartContent)
        Me.tpEventsChart.Location = New System.Drawing.Point(4, 22)
        Me.tpEventsChart.Name = "tpEventsChart"
        Me.tpEventsChart.Size = New System.Drawing.Size(868, 274)
        Me.tpEventsChart.TabIndex = 3
        Me.tpEventsChart.Text = "tpEventsChart"
        '
        'tlpChartContent
        '
        Me.tlpChartContent.AutoSize = True
        Me.tlpChartContent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlpChartContent.ColumnCount = 1
        Me.tlpChartContent.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpChartContent.Controls.Add(Me.chrChart, 0, 3)
        Me.tlpChartContent.Controls.Add(Me.lblChartCount, 0, 1)
        Me.tlpChartContent.Controls.Add(Me.lvwChart, 0, 2)
        Me.tlpChartContent.Controls.Add(Me.tlpChart, 0, 0)
        Me.tlpChartContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpChartContent.Location = New System.Drawing.Point(0, 0)
        Me.tlpChartContent.Name = "tlpChartContent"
        Me.tlpChartContent.RowCount = 4
        Me.tlpChartContent.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpChartContent.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpChartContent.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpChartContent.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpChartContent.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpChartContent.Size = New System.Drawing.Size(868, 274)
        Me.tlpChartContent.TabIndex = 24
        '
        'chrChart
        '
        Me.chrChart.BorderlineColor = System.Drawing.Color.Empty
        Me.chrChart.BorderSkin.BorderColor = System.Drawing.Color.LightGray
        ChartArea1.Area3DStyle.Inclination = 0
        ChartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount
        ChartArea1.AxisX.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number
        ChartArea1.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number
        ChartArea1.AxisX.IsLabelAutoFit = False
        ChartArea1.AxisX.IsMarginVisible = False
        ChartArea1.AxisX.LabelAutoFitMaxFontSize = 7
        ChartArea1.AxisX.LabelAutoFitMinFontSize = 7
        ChartArea1.AxisX.LabelStyle.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.LightGray
        ChartArea1.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash
        ChartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.DimGray
        ChartArea1.AxisX.ScaleBreakStyle.Enabled = True
        ChartArea1.AxisX.ScaleBreakStyle.StartFromZero = System.Windows.Forms.DataVisualization.Charting.StartFromZero.Yes
        ChartArea1.AxisX.ScaleView.MinSize = 30.0R
        ChartArea1.AxisX.ScaleView.MinSizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number
        ChartArea1.AxisX.ScaleView.SmallScrollMinSizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number
        ChartArea1.AxisX.ScaleView.SmallScrollSizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number
        ChartArea1.AxisX.TitleFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea1.AxisX2.LineColor = System.Drawing.Color.Empty
        ChartArea1.AxisX2.TitleFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea1.AxisY.IsLabelAutoFit = False
        ChartArea1.AxisY.LabelAutoFitMaxFontSize = 7
        ChartArea1.AxisY.LabelAutoFitMinFontSize = 7
        ChartArea1.AxisY.LabelStyle.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray
        ChartArea1.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash
        ChartArea1.AxisY.TitleFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea1.AxisY2.LineColor = System.Drawing.Color.Empty
        ChartArea1.AxisY2.TitleFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea1.BackColor = System.Drawing.Color.Transparent
        ChartArea1.BorderColor = System.Drawing.Color.Empty
        ChartArea1.Name = "ChartArea1"
        Me.chrChart.ChartAreas.Add(ChartArea1)
        Me.chrChart.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chrChart.Location = New System.Drawing.Point(3, 169)
        Me.chrChart.MinimumSize = New System.Drawing.Size(0, 100)
        Me.chrChart.Name = "chrChart"
        Me.chrChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None
        Me.chrChart.PaletteCustomColors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))}
        Series1.BorderWidth = 2
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area
        Series1.LabelForeColor = System.Drawing.Color.Empty
        Series1.MarkerBorderColor = System.Drawing.Color.Transparent
        Series1.MarkerSize = 0
        Series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle
        Series1.Name = "Series1"
        DataPoint1.BackSecondaryColor = System.Drawing.Color.Transparent
        DataPoint1.BorderColor = System.Drawing.Color.Transparent
        DataPoint1.LabelBackColor = System.Drawing.Color.Transparent
        DataPoint1.LabelBorderColor = System.Drawing.Color.Transparent
        DataPoint1.LabelForeColor = System.Drawing.Color.Transparent
        DataPoint1.LabelToolTip = "0"
        DataPoint1.MarkerBorderColor = System.Drawing.Color.Transparent
        DataPoint1.MarkerBorderWidth = 1
        DataPoint2.BackSecondaryColor = System.Drawing.Color.Transparent
        DataPoint2.BorderColor = System.Drawing.Color.Transparent
        DataPoint2.IsValueShownAsLabel = True
        DataPoint2.LabelBackColor = System.Drawing.Color.Transparent
        DataPoint2.LabelBorderColor = System.Drawing.Color.Transparent
        DataPoint2.LabelForeColor = System.Drawing.Color.Transparent
        DataPoint2.LabelToolTip = "5"
        DataPoint2.MarkerBorderColor = System.Drawing.Color.Transparent
        DataPoint2.MarkerBorderWidth = 1
        DataPoint2.MarkerColor = System.Drawing.Color.Empty
        DataPoint2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle
        DataPoint2.ToolTip = "5"
        DataPoint3.BackSecondaryColor = System.Drawing.Color.Transparent
        DataPoint3.BorderColor = System.Drawing.Color.Transparent
        DataPoint3.LabelBackColor = System.Drawing.Color.Transparent
        DataPoint3.LabelBorderColor = System.Drawing.Color.Transparent
        DataPoint3.LabelForeColor = System.Drawing.Color.Transparent
        DataPoint3.LabelToolTip = "10"
        DataPoint3.MarkerBorderColor = System.Drawing.Color.Transparent
        DataPoint3.MarkerBorderWidth = 1
        DataPoint3.ToolTip = "10"
        DataPoint4.BackSecondaryColor = System.Drawing.Color.Transparent
        DataPoint4.BorderColor = System.Drawing.Color.Transparent
        DataPoint4.LabelBackColor = System.Drawing.Color.Transparent
        DataPoint4.LabelBorderColor = System.Drawing.Color.Transparent
        DataPoint4.LabelForeColor = System.Drawing.Color.Transparent
        DataPoint4.LabelToolTip = "30"
        DataPoint4.MarkerBorderColor = System.Drawing.Color.Transparent
        DataPoint4.MarkerBorderWidth = 1
        DataPoint4.ToolTip = "30"
        DataPoint5.BackSecondaryColor = System.Drawing.Color.Transparent
        DataPoint5.BorderColor = System.Drawing.Color.Transparent
        DataPoint5.LabelBackColor = System.Drawing.Color.Transparent
        DataPoint5.LabelBorderColor = System.Drawing.Color.Transparent
        DataPoint5.LabelForeColor = System.Drawing.Color.Transparent
        DataPoint5.LabelToolTip = "25"
        DataPoint5.MarkerBorderColor = System.Drawing.Color.Transparent
        DataPoint5.MarkerBorderWidth = 1
        DataPoint5.ToolTip = "25"
        DataPoint6.BackSecondaryColor = System.Drawing.Color.Transparent
        DataPoint6.BorderColor = System.Drawing.Color.Transparent
        DataPoint6.LabelBackColor = System.Drawing.Color.Transparent
        DataPoint6.LabelBorderColor = System.Drawing.Color.Transparent
        DataPoint6.LabelForeColor = System.Drawing.Color.Transparent
        DataPoint6.LabelToolTip = "5"
        DataPoint6.MarkerBorderColor = System.Drawing.Color.Transparent
        DataPoint6.MarkerBorderWidth = 1
        DataPoint6.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle
        DataPoint6.ToolTip = "5"
        DataPoint7.BackSecondaryColor = System.Drawing.Color.Transparent
        DataPoint7.BorderColor = System.Drawing.Color.Transparent
        DataPoint7.LabelBackColor = System.Drawing.Color.Transparent
        DataPoint7.LabelBorderColor = System.Drawing.Color.Transparent
        DataPoint7.LabelForeColor = System.Drawing.Color.Transparent
        DataPoint7.LabelToolTip = "20"
        DataPoint7.MarkerBorderColor = System.Drawing.Color.Transparent
        DataPoint7.MarkerBorderWidth = 1
        DataPoint7.ToolTip = "20"
        DataPoint8.BackSecondaryColor = System.Drawing.Color.Transparent
        DataPoint8.BorderColor = System.Drawing.Color.Transparent
        DataPoint8.LabelBackColor = System.Drawing.Color.Transparent
        DataPoint8.LabelBorderColor = System.Drawing.Color.Transparent
        DataPoint8.LabelForeColor = System.Drawing.Color.Transparent
        DataPoint8.LabelToolTip = "15"
        DataPoint8.MarkerBorderColor = System.Drawing.Color.Transparent
        DataPoint8.MarkerBorderWidth = 1
        DataPoint8.ToolTip = "15"
        DataPoint9.BackSecondaryColor = System.Drawing.Color.Transparent
        DataPoint9.BorderColor = System.Drawing.Color.Transparent
        DataPoint9.LabelBackColor = System.Drawing.Color.Transparent
        DataPoint9.LabelBorderColor = System.Drawing.Color.Transparent
        DataPoint9.LabelForeColor = System.Drawing.Color.Transparent
        DataPoint9.LabelToolTip = "20"
        DataPoint9.MarkerBorderColor = System.Drawing.Color.Transparent
        DataPoint9.MarkerBorderWidth = 1
        DataPoint9.ToolTip = "20"
        DataPoint10.BackSecondaryColor = System.Drawing.Color.Transparent
        DataPoint10.BorderColor = System.Drawing.Color.Transparent
        DataPoint10.LabelBackColor = System.Drawing.Color.Transparent
        DataPoint10.LabelBorderColor = System.Drawing.Color.Transparent
        DataPoint10.LabelForeColor = System.Drawing.Color.Transparent
        DataPoint10.LabelToolTip = "10"
        DataPoint10.MarkerBorderColor = System.Drawing.Color.Transparent
        DataPoint10.MarkerBorderWidth = 1
        DataPoint10.ToolTip = "10"
        DataPoint11.BackSecondaryColor = System.Drawing.Color.Transparent
        DataPoint11.BorderColor = System.Drawing.Color.Transparent
        DataPoint11.LabelBackColor = System.Drawing.Color.Transparent
        DataPoint11.LabelBorderColor = System.Drawing.Color.Transparent
        DataPoint11.LabelForeColor = System.Drawing.Color.Transparent
        DataPoint11.LabelToolTip = "60"
        DataPoint11.MarkerBorderColor = System.Drawing.Color.Transparent
        DataPoint11.MarkerBorderWidth = 1
        DataPoint11.ToolTip = "60"
        Series1.Points.Add(DataPoint1)
        Series1.Points.Add(DataPoint2)
        Series1.Points.Add(DataPoint3)
        Series1.Points.Add(DataPoint4)
        Series1.Points.Add(DataPoint5)
        Series1.Points.Add(DataPoint6)
        Series1.Points.Add(DataPoint7)
        Series1.Points.Add(DataPoint8)
        Series1.Points.Add(DataPoint9)
        Series1.Points.Add(DataPoint10)
        Series1.Points.Add(DataPoint11)
        Me.chrChart.Series.Add(Series1)
        Me.chrChart.Size = New System.Drawing.Size(862, 102)
        Me.chrChart.TabIndex = 20
        Me.chrChart.Text = "Chart1"
        '
        'lblChartCount
        '
        Me.lblChartCount.AutoSize = true
        Me.lblChartCount.ForeColor = System.Drawing.Color.Black
        Me.lblChartCount.Location = New System.Drawing.Point(3, 36)
        Me.lblChartCount.MinimumSize = New System.Drawing.Size(0, 23)
        Me.lblChartCount.Name = "lblChartCount"
        Me.lblChartCount.Size = New System.Drawing.Size(73, 23)
        Me.lblChartCount.TabIndex = 26
        Me.lblChartCount.Text = "lblChartCount"
        Me.lblChartCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lvwChart
        '
        Me.lvwChart.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chDate, Me.chFromGraph, Me.chToGraph, Me.chVariationGraph})
        Me.lvwChart.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvwChart.FullRowSelect = true
        Me.lvwChart.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvwChart.HideSelection = false
        Me.lvwChart.Location = New System.Drawing.Point(3, 62)
        Me.lvwChart.MinimumSize = New System.Drawing.Size(4, 100)
        Me.lvwChart.Name = "lvwChart"
        Me.lvwChart.Size = New System.Drawing.Size(862, 101)
        Me.lvwChart.TabIndex = 1
        Me.lvwChart.UseCompatibleStateImageBehavior = false
        Me.lvwChart.View = System.Windows.Forms.View.Details
        '
        'chDate
        '
        Me.chDate.Text = "chDate"
        '
        'chFromGraph
        '
        Me.chFromGraph.Text = "chFromGraph"
        Me.chFromGraph.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'chToGraph
        '
        Me.chToGraph.Text = "chToGraph"
        Me.chToGraph.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'chVariationGraph
        '
        Me.chVariationGraph.Text = "chVariationGraph"
        Me.chVariationGraph.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tlpChart
        '
        Me.tlpChart.ColumnCount = 2
        Me.tlpChart.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.tlpChart.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.tlpChart.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20!))
        Me.tlpChart.Controls.Add(Me.cboChartEvents, 0, 0)
        Me.tlpChart.Controls.Add(Me.lblEvents, 1, 0)
        Me.tlpChart.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpChart.Location = New System.Drawing.Point(3, 3)
        Me.tlpChart.Name = "tlpChart"
        Me.tlpChart.RowCount = 1
        Me.tlpChart.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tlpChart.Size = New System.Drawing.Size(862, 30)
        Me.tlpChart.TabIndex = 15
        '
        'cboChartEvents
        '
        Me.cboChartEvents.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cboChartEvents.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboChartEvents.FormattingEnabled = true
        Me.cboChartEvents.Location = New System.Drawing.Point(0, 4)
        Me.cboChartEvents.Margin = New System.Windows.Forms.Padding(0, 4, 3, 3)
        Me.cboChartEvents.Name = "cboChartEvents"
        Me.cboChartEvents.Size = New System.Drawing.Size(428, 21)
        Me.cboChartEvents.TabIndex = 0
        '
        'lblEvents
        '
        Me.lblEvents.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblEvents.AutoSize = true
        Me.lblEvents.ForeColor = System.Drawing.Color.Black
        Me.lblEvents.Location = New System.Drawing.Point(434, 8)
        Me.lblEvents.Name = "lblEvents"
        Me.lblEvents.Size = New System.Drawing.Size(50, 13)
        Me.lblEvents.TabIndex = 20
        Me.lblEvents.Text = "lblEvents"
        '
        'tpTemperatures
        '
        Me.tpTemperatures.AutoScroll = true
        Me.tpTemperatures.Controls.Add(Me.tlpTemperatures)
        Me.tpTemperatures.Location = New System.Drawing.Point(4, 22)
        Me.tpTemperatures.Name = "tpTemperatures"
        Me.tpTemperatures.Size = New System.Drawing.Size(868, 274)
        Me.tpTemperatures.TabIndex = 7
        Me.tpTemperatures.Text = "tpTemperatures"
        Me.tpTemperatures.UseVisualStyleBackColor = true
        '
        'tlpTemperatures
        '
        Me.tlpTemperatures.AutoSize = true
        Me.tlpTemperatures.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlpTemperatures.ColumnCount = 1
        Me.tlpTemperatures.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tlpTemperatures.Controls.Add(Me.lblAdminTemperatures, 0, 0)
        Me.tlpTemperatures.Controls.Add(Me.HorizontalLine9, 0, 1)
        Me.tlpTemperatures.Controls.Add(Me.tlpTempGraphs, 0, 2)
        Me.tlpTemperatures.Controls.Add(Me.lblTempMeans, 0, 4)
        Me.tlpTemperatures.Controls.Add(Me.tlpTempMeans, 0, 5)
        Me.tlpTemperatures.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpTemperatures.Location = New System.Drawing.Point(0, 0)
        Me.tlpTemperatures.Name = "tlpTemperatures"
        Me.tlpTemperatures.RowCount = 6
        Me.tlpTemperatures.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpTemperatures.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpTemperatures.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpTemperatures.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20!))
        Me.tlpTemperatures.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpTemperatures.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpTemperatures.Size = New System.Drawing.Size(851, 288)
        Me.tlpTemperatures.TabIndex = 25
        '
        'lblAdminTemperatures
        '
        Me.lblAdminTemperatures.AutoSize = true
        Me.lblAdminTemperatures.ForeColor = System.Drawing.Color.DimGray
        Me.lblAdminTemperatures.Location = New System.Drawing.Point(3, 7)
        Me.lblAdminTemperatures.Margin = New System.Windows.Forms.Padding(3, 7, 3, 3)
        Me.lblAdminTemperatures.Name = "lblAdminTemperatures"
        Me.lblAdminTemperatures.Size = New System.Drawing.Size(113, 13)
        Me.lblAdminTemperatures.TabIndex = 3
        Me.lblAdminTemperatures.Tag = "Grayed"
        Me.lblAdminTemperatures.Text = "lblAdminTemperatures"
        '
        'HorizontalLine9
        '
        Me.HorizontalLine9.BackColor = System.Drawing.Color.Silver
        Me.HorizontalLine9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HorizontalLine9.Location = New System.Drawing.Point(3, 32)
        Me.HorizontalLine9.Margin = New System.Windows.Forms.Padding(3, 9, 3, 9)
        Me.HorizontalLine9.MaximumSize = New System.Drawing.Size(0, 1)
        Me.HorizontalLine9.Name = "HorizontalLine9"
        Me.HorizontalLine9.Size = New System.Drawing.Size(845, 1)
        Me.HorizontalLine9.TabIndex = 4
        Me.HorizontalLine9.TabStop = false
        '
        'tlpTempGraphs
        '
        Me.tlpTempGraphs.AutoSize = true
        Me.tlpTempGraphs.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlpTempGraphs.ColumnCount = 4
        Me.tlpTempGraphs.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpTempGraphs.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpTempGraphs.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpTempGraphs.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpTempGraphs.Controls.Add(Me.lblLifeTimeMax, 3, 4)
        Me.tlpTempGraphs.Controls.Add(Me.lblCurrentTemp, 0, 0)
        Me.tlpTempGraphs.Controls.Add(Me.lblCycleMin, 1, 3)
        Me.tlpTempGraphs.Controls.Add(Me.lblMin, 1, 2)
        Me.tlpTempGraphs.Controls.Add(Me.lblMax, 3, 2)
        Me.tlpTempGraphs.Controls.Add(Me.lblCycleMax, 3, 3)
        Me.tlpTempGraphs.Controls.Add(Me.lblRecommendedMax, 3, 5)
        Me.tlpTempGraphs.Controls.Add(Me.lblLimitMax, 3, 6)
        Me.tlpTempGraphs.Controls.Add(Me.lblCycle, 0, 3)
        Me.tlpTempGraphs.Controls.Add(Me.lblLifeTime, 0, 4)
        Me.tlpTempGraphs.Controls.Add(Me.lblLifeTimeMin, 1, 4)
        Me.tlpTempGraphs.Controls.Add(Me.lblRecommendedMin, 1, 5)
        Me.tlpTempGraphs.Controls.Add(Me.lblLimitMin, 1, 6)
        Me.tlpTempGraphs.Controls.Add(Me.lblRecommended, 0, 5)
        Me.tlpTempGraphs.Controls.Add(Me.lblLimit, 0, 6)
        Me.tlpTempGraphs.Controls.Add(Me.lblCurrentTempValue, 1, 0)
        Me.tlpTempGraphs.Controls.Add(Me.tbCycle, 2, 3)
        Me.tlpTempGraphs.Controls.Add(Me.tbLifeTime, 2, 4)
        Me.tlpTempGraphs.Controls.Add(Me.tbRecommended, 2, 5)
        Me.tlpTempGraphs.Controls.Add(Me.tbLimit, 2, 6)
        Me.tlpTempGraphs.Controls.Add(Me.lblZero, 2, 2)
        Me.tlpTempGraphs.Location = New System.Drawing.Point(3, 45)
        Me.tlpTempGraphs.Name = "tlpTempGraphs"
        Me.tlpTempGraphs.RowCount = 7
        Me.tlpTempGraphs.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpTempGraphs.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20!))
        Me.tlpTempGraphs.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpTempGraphs.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpTempGraphs.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpTempGraphs.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpTempGraphs.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpTempGraphs.Size = New System.Drawing.Size(717, 128)
        Me.tlpTempGraphs.TabIndex = 3
        '
        'lblLifeTimeMax
        '
        Me.lblLifeTimeMax.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblLifeTimeMax.AutoSize = true
        Me.lblLifeTimeMax.ForeColor = System.Drawing.Color.Black
        Me.lblLifeTimeMax.Location = New System.Drawing.Point(607, 72)
        Me.lblLifeTimeMax.Margin = New System.Windows.Forms.Padding(0, 0, 3, 3)
        Me.lblLifeTimeMax.Name = "lblLifeTimeMax"
        Me.lblLifeTimeMax.Size = New System.Drawing.Size(76, 13)
        Me.lblLifeTimeMax.TabIndex = 5
        Me.lblLifeTimeMax.Text = "lblLifeTimeMax"
        '
        'lblCurrentTemp
        '
        Me.lblCurrentTemp.AutoSize = true
        Me.lblCurrentTemp.ForeColor = System.Drawing.Color.DimGray
        Me.lblCurrentTemp.Location = New System.Drawing.Point(0, 0)
        Me.lblCurrentTemp.Margin = New System.Windows.Forms.Padding(0, 0, 3, 3)
        Me.lblCurrentTemp.Name = "lblCurrentTemp"
        Me.lblCurrentTemp.Size = New System.Drawing.Size(80, 13)
        Me.lblCurrentTemp.TabIndex = 50
        Me.lblCurrentTemp.Tag = "Grayed"
        Me.lblCurrentTemp.Text = "lblCurrentTemp"
        '
        'lblCycleMin
        '
        Me.lblCycleMin.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblCycleMin.AutoSize = true
        Me.lblCycleMin.ForeColor = System.Drawing.Color.Black
        Me.lblCycleMin.Location = New System.Drawing.Point(137, 53)
        Me.lblCycleMin.Margin = New System.Windows.Forms.Padding(0, 0, 3, 3)
        Me.lblCycleMin.Name = "lblCycleMin"
        Me.lblCycleMin.Size = New System.Drawing.Size(59, 13)
        Me.lblCycleMin.TabIndex = 9
        Me.lblCycleMin.Text = "lblCycleMin"
        '
        'lblMin
        '
        Me.lblMin.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblMin.AutoSize = true
        Me.lblMin.ForeColor = System.Drawing.Color.Black
        Me.lblMin.Location = New System.Drawing.Point(139, 36)
        Me.lblMin.Margin = New System.Windows.Forms.Padding(0, 0, 3, 3)
        Me.lblMin.Name = "lblMin"
        Me.lblMin.Size = New System.Drawing.Size(57, 13)
        Me.lblMin.TabIndex = 6
        Me.lblMin.Text = "lblMinimum"
        '
        'lblMax
        '
        Me.lblMax.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblMax.AutoSize = true
        Me.lblMax.ForeColor = System.Drawing.Color.Black
        Me.lblMax.Location = New System.Drawing.Point(607, 36)
        Me.lblMax.Margin = New System.Windows.Forms.Padding(0, 0, 3, 3)
        Me.lblMax.Name = "lblMax"
        Me.lblMax.Size = New System.Drawing.Size(61, 13)
        Me.lblMax.TabIndex = 8
        Me.lblMax.Text = "lblMaximum"
        '
        'lblCycleMax
        '
        Me.lblCycleMax.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblCycleMax.AutoSize = true
        Me.lblCycleMax.ForeColor = System.Drawing.Color.Black
        Me.lblCycleMax.Location = New System.Drawing.Point(607, 53)
        Me.lblCycleMax.Margin = New System.Windows.Forms.Padding(0, 0, 3, 3)
        Me.lblCycleMax.Name = "lblCycleMax"
        Me.lblCycleMax.Size = New System.Drawing.Size(63, 13)
        Me.lblCycleMax.TabIndex = 11
        Me.lblCycleMax.Text = "lblCycleMax"
        '
        'lblRecommendedMax
        '
        Me.lblRecommendedMax.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblRecommendedMax.AutoSize = true
        Me.lblRecommendedMax.ForeColor = System.Drawing.Color.Black
        Me.lblRecommendedMax.Location = New System.Drawing.Point(607, 91)
        Me.lblRecommendedMax.Margin = New System.Windows.Forms.Padding(0, 0, 3, 3)
        Me.lblRecommendedMax.Name = "lblRecommendedMax"
        Me.lblRecommendedMax.Size = New System.Drawing.Size(107, 13)
        Me.lblRecommendedMax.TabIndex = 12
        Me.lblRecommendedMax.Text = "lblRecommendedMax"
        '
        'lblLimitMax
        '
        Me.lblLimitMax.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblLimitMax.AutoSize = true
        Me.lblLimitMax.ForeColor = System.Drawing.Color.Black
        Me.lblLimitMax.Location = New System.Drawing.Point(607, 110)
        Me.lblLimitMax.Margin = New System.Windows.Forms.Padding(0, 0, 3, 3)
        Me.lblLimitMax.Name = "lblLimitMax"
        Me.lblLimitMax.Size = New System.Drawing.Size(58, 13)
        Me.lblLimitMax.TabIndex = 59
        Me.lblLimitMax.Text = "lblLimitMax"
        '
        'lblCycle
        '
        Me.lblCycle.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblCycle.AutoSize = true
        Me.lblCycle.ForeColor = System.Drawing.Color.DimGray
        Me.lblCycle.Location = New System.Drawing.Point(0, 53)
        Me.lblCycle.Margin = New System.Windows.Forms.Padding(0, 0, 3, 3)
        Me.lblCycle.Name = "lblCycle"
        Me.lblCycle.Size = New System.Drawing.Size(43, 13)
        Me.lblCycle.TabIndex = 37
        Me.lblCycle.Tag = "Grayed"
        Me.lblCycle.Text = "lblCycle"
        '
        'lblLifeTime
        '
        Me.lblLifeTime.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblLifeTime.AutoSize = true
        Me.lblLifeTime.ForeColor = System.Drawing.Color.DimGray
        Me.lblLifeTime.Location = New System.Drawing.Point(0, 72)
        Me.lblLifeTime.Margin = New System.Windows.Forms.Padding(0, 0, 3, 3)
        Me.lblLifeTime.Name = "lblLifeTime"
        Me.lblLifeTime.Size = New System.Drawing.Size(56, 13)
        Me.lblLifeTime.TabIndex = 38
        Me.lblLifeTime.Tag = "Grayed"
        Me.lblLifeTime.Text = "lblLifeTime"
        '
        'lblLifeTimeMin
        '
        Me.lblLifeTimeMin.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblLifeTimeMin.AutoSize = true
        Me.lblLifeTimeMin.ForeColor = System.Drawing.Color.Black
        Me.lblLifeTimeMin.Location = New System.Drawing.Point(124, 72)
        Me.lblLifeTimeMin.Margin = New System.Windows.Forms.Padding(0, 0, 3, 3)
        Me.lblLifeTimeMin.Name = "lblLifeTimeMin"
        Me.lblLifeTimeMin.Size = New System.Drawing.Size(72, 13)
        Me.lblLifeTimeMin.TabIndex = 0
        Me.lblLifeTimeMin.Text = "lblLifeTimeMin"
        '
        'lblRecommendedMin
        '
        Me.lblRecommendedMin.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblRecommendedMin.AutoSize = true
        Me.lblRecommendedMin.ForeColor = System.Drawing.Color.Black
        Me.lblRecommendedMin.Location = New System.Drawing.Point(93, 91)
        Me.lblRecommendedMin.Margin = New System.Windows.Forms.Padding(0, 0, 3, 3)
        Me.lblRecommendedMin.Name = "lblRecommendedMin"
        Me.lblRecommendedMin.Size = New System.Drawing.Size(103, 13)
        Me.lblRecommendedMin.TabIndex = 58
        Me.lblRecommendedMin.Text = "lblRecommendedMin"
        '
        'lblLimitMin
        '
        Me.lblLimitMin.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblLimitMin.AutoSize = true
        Me.lblLimitMin.ForeColor = System.Drawing.Color.Black
        Me.lblLimitMin.Location = New System.Drawing.Point(142, 110)
        Me.lblLimitMin.Margin = New System.Windows.Forms.Padding(0, 0, 3, 3)
        Me.lblLimitMin.Name = "lblLimitMin"
        Me.lblLimitMin.Size = New System.Drawing.Size(54, 13)
        Me.lblLimitMin.TabIndex = 56
        Me.lblLimitMin.Text = "lblLimitMin"
        '
        'lblRecommended
        '
        Me.lblRecommended.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblRecommended.AutoSize = true
        Me.lblRecommended.ForeColor = System.Drawing.Color.DimGray
        Me.lblRecommended.Location = New System.Drawing.Point(0, 91)
        Me.lblRecommended.Margin = New System.Windows.Forms.Padding(0, 0, 3, 3)
        Me.lblRecommended.Name = "lblRecommended"
        Me.lblRecommended.Size = New System.Drawing.Size(87, 13)
        Me.lblRecommended.TabIndex = 51
        Me.lblRecommended.Tag = "Grayed"
        Me.lblRecommended.Text = "lblRecommended"
        '
        'lblLimit
        '
        Me.lblLimit.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblLimit.AutoEllipsis = true
        Me.lblLimit.AutoSize = true
        Me.lblLimit.ForeColor = System.Drawing.Color.DimGray
        Me.lblLimit.Location = New System.Drawing.Point(0, 110)
        Me.lblLimit.Margin = New System.Windows.Forms.Padding(0, 0, 3, 3)
        Me.lblLimit.Name = "lblLimit"
        Me.lblLimit.Size = New System.Drawing.Size(38, 13)
        Me.lblLimit.TabIndex = 1
        Me.lblLimit.Tag = "Grayed"
        Me.lblLimit.Text = "lblLimit"
        '
        'lblCurrentTempValue
        '
        Me.lblCurrentTempValue.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblCurrentTempValue.AutoSize = true
        Me.lblCurrentTempValue.ForeColor = System.Drawing.Color.Black
        Me.lblCurrentTempValue.Location = New System.Drawing.Point(90, 0)
        Me.lblCurrentTempValue.Margin = New System.Windows.Forms.Padding(0, 0, 3, 3)
        Me.lblCurrentTempValue.Name = "lblCurrentTempValue"
        Me.lblCurrentTempValue.Size = New System.Drawing.Size(106, 13)
        Me.lblCurrentTempValue.TabIndex = 1
        Me.lblCurrentTempValue.Text = "lblCurrentTempValue"
        '
        'tbCycle
        '
        Me.tbCycle.BackColor = System.Drawing.Color.FromArgb(CType(CType(188,Byte),Integer), CType(CType(188,Byte),Integer), CType(CType(188,Byte),Integer))
        Me.tbCycle.Barcolor = System.Drawing.Color.MediumAquamarine
        Me.tbCycle.Location = New System.Drawing.Point(202, 55)
        Me.tbCycle.Name = "tbCycle"
        Me.tbCycle.Padding = New System.Windows.Forms.Padding(1)
        Me.tbCycle.Size = New System.Drawing.Size(402, 13)
        Me.tbCycle.TabIndex = 60
        '
        'tbLifeTime
        '
        Me.tbLifeTime.BackColor = System.Drawing.Color.FromArgb(CType(CType(188,Byte),Integer), CType(CType(188,Byte),Integer), CType(CType(188,Byte),Integer))
        Me.tbLifeTime.Barcolor = System.Drawing.Color.MediumSeaGreen
        Me.tbLifeTime.Location = New System.Drawing.Point(202, 74)
        Me.tbLifeTime.Name = "tbLifeTime"
        Me.tbLifeTime.Padding = New System.Windows.Forms.Padding(1)
        Me.tbLifeTime.Size = New System.Drawing.Size(402, 13)
        Me.tbLifeTime.TabIndex = 61
        '
        'tbRecommended
        '
        Me.tbRecommended.BackColor = System.Drawing.Color.FromArgb(CType(CType(188,Byte),Integer), CType(CType(188,Byte),Integer), CType(CType(188,Byte),Integer))
        Me.tbRecommended.Barcolor = System.Drawing.Color.DodgerBlue
        Me.tbRecommended.Location = New System.Drawing.Point(202, 93)
        Me.tbRecommended.Name = "tbRecommended"
        Me.tbRecommended.Padding = New System.Windows.Forms.Padding(1)
        Me.tbRecommended.Size = New System.Drawing.Size(402, 13)
        Me.tbRecommended.TabIndex = 62
        '
        'tbLimit
        '
        Me.tbLimit.BackColor = System.Drawing.Color.FromArgb(CType(CType(188,Byte),Integer), CType(CType(188,Byte),Integer), CType(CType(188,Byte),Integer))
        Me.tbLimit.Barcolor = System.Drawing.Color.Red
        Me.tbLimit.Location = New System.Drawing.Point(202, 112)
        Me.tbLimit.Name = "tbLimit"
        Me.tbLimit.Padding = New System.Windows.Forms.Padding(1)
        Me.tbLimit.Size = New System.Drawing.Size(402, 13)
        Me.tbLimit.TabIndex = 63
        '
        'lblZero
        '
        Me.lblZero.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblZero.ForeColor = System.Drawing.Color.Black
        Me.lblZero.Location = New System.Drawing.Point(199, 36)
        Me.lblZero.Margin = New System.Windows.Forms.Padding(0)
        Me.lblZero.Name = "lblZero"
        Me.lblZero.Size = New System.Drawing.Size(408, 16)
        Me.lblZero.TabIndex = 64
        Me.lblZero.Text = "lblZero"
        Me.lblZero.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblTempMeans
        '
        Me.lblTempMeans.AutoSize = true
        Me.lblTempMeans.ForeColor = System.Drawing.Color.FromArgb(CType(CType(29,Byte),Integer), CType(CType(174,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.lblTempMeans.Location = New System.Drawing.Point(3, 199)
        Me.lblTempMeans.Margin = New System.Windows.Forms.Padding(3)
        Me.lblTempMeans.MinimumSize = New System.Drawing.Size(0, 16)
        Me.lblTempMeans.Name = "lblTempMeans"
        Me.lblTempMeans.Size = New System.Drawing.Size(74, 16)
        Me.lblTempMeans.TabIndex = 7
        Me.lblTempMeans.Tag = "Group"
        Me.lblTempMeans.Text = "lblTempMeans"
        Me.lblTempMeans.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpTempMeans
        '
        Me.tlpTempMeans.AutoSize = true
        Me.tlpTempMeans.ColumnCount = 2
        Me.tlpTempMeans.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpTempMeans.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tlpTempMeans.Controls.Add(Me.lblLimitValue, 1, 3)
        Me.tlpTempMeans.Controls.Add(Me.lblLimitMean, 0, 3)
        Me.tlpTempMeans.Controls.Add(Me.lblCycleMeans, 0, 0)
        Me.tlpTempMeans.Controls.Add(Me.lblLifeTimeMean, 0, 1)
        Me.tlpTempMeans.Controls.Add(Me.lblRecommendedMean, 0, 2)
        Me.tlpTempMeans.Controls.Add(Me.lblCycleValue, 1, 0)
        Me.tlpTempMeans.Controls.Add(Me.lblLifeTimeValue, 1, 1)
        Me.tlpTempMeans.Controls.Add(Me.lblRecommendedValue, 1, 2)
        Me.tlpTempMeans.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpTempMeans.Location = New System.Drawing.Point(3, 221)
        Me.tlpTempMeans.Name = "tlpTempMeans"
        Me.tlpTempMeans.RowCount = 4
        Me.tlpTempMeans.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpTempMeans.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpTempMeans.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpTempMeans.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpTempMeans.Size = New System.Drawing.Size(845, 64)
        Me.tlpTempMeans.TabIndex = 8
        '
        'lblLimitValue
        '
        Me.lblLimitValue.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblLimitValue.AutoSize = true
        Me.lblLimitValue.ForeColor = System.Drawing.Color.Black
        Me.lblLimitValue.Location = New System.Drawing.Point(116, 48)
        Me.lblLimitValue.Margin = New System.Windows.Forms.Padding(0, 0, 3, 3)
        Me.lblLimitValue.Name = "lblLimitValue"
        Me.lblLimitValue.Size = New System.Drawing.Size(64, 13)
        Me.lblLimitValue.TabIndex = 45
        Me.lblLimitValue.Text = "lblLimitValue"
        '
        'lblLimitMean
        '
        Me.lblLimitMean.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblLimitMean.AutoSize = true
        Me.lblLimitMean.ForeColor = System.Drawing.Color.DimGray
        Me.lblLimitMean.Location = New System.Drawing.Point(0, 48)
        Me.lblLimitMean.Margin = New System.Windows.Forms.Padding(0, 0, 3, 3)
        Me.lblLimitMean.Name = "lblLimitMean"
        Me.lblLimitMean.Size = New System.Drawing.Size(64, 13)
        Me.lblLimitMean.TabIndex = 41
        Me.lblLimitMean.Tag = "Grayed"
        Me.lblLimitMean.Text = "lblLimitMean"
        '
        'lblCycleMeans
        '
        Me.lblCycleMeans.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblCycleMeans.AutoSize = true
        Me.lblCycleMeans.ForeColor = System.Drawing.Color.DimGray
        Me.lblCycleMeans.Location = New System.Drawing.Point(0, 0)
        Me.lblCycleMeans.Margin = New System.Windows.Forms.Padding(0, 0, 3, 3)
        Me.lblCycleMeans.Name = "lblCycleMeans"
        Me.lblCycleMeans.Size = New System.Drawing.Size(69, 13)
        Me.lblCycleMeans.TabIndex = 38
        Me.lblCycleMeans.Tag = "Grayed"
        Me.lblCycleMeans.Text = "lblCycleMean"
        '
        'lblLifeTimeMean
        '
        Me.lblLifeTimeMean.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblLifeTimeMean.AutoSize = true
        Me.lblLifeTimeMean.ForeColor = System.Drawing.Color.DimGray
        Me.lblLifeTimeMean.Location = New System.Drawing.Point(0, 16)
        Me.lblLifeTimeMean.Margin = New System.Windows.Forms.Padding(0, 0, 3, 3)
        Me.lblLifeTimeMean.Name = "lblLifeTimeMean"
        Me.lblLifeTimeMean.Size = New System.Drawing.Size(82, 13)
        Me.lblLifeTimeMean.TabIndex = 39
        Me.lblLifeTimeMean.Tag = "Grayed"
        Me.lblLifeTimeMean.Text = "lblLifeTimeMean"
        '
        'lblRecommendedMean
        '
        Me.lblRecommendedMean.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblRecommendedMean.AutoSize = true
        Me.lblRecommendedMean.ForeColor = System.Drawing.Color.DimGray
        Me.lblRecommendedMean.Location = New System.Drawing.Point(0, 32)
        Me.lblRecommendedMean.Margin = New System.Windows.Forms.Padding(0, 0, 3, 3)
        Me.lblRecommendedMean.Name = "lblRecommendedMean"
        Me.lblRecommendedMean.Size = New System.Drawing.Size(113, 13)
        Me.lblRecommendedMean.TabIndex = 40
        Me.lblRecommendedMean.Tag = "Grayed"
        Me.lblRecommendedMean.Text = "lblRecommendedMean"
        '
        'lblCycleValue
        '
        Me.lblCycleValue.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblCycleValue.AutoSize = true
        Me.lblCycleValue.ForeColor = System.Drawing.Color.Black
        Me.lblCycleValue.Location = New System.Drawing.Point(116, 0)
        Me.lblCycleValue.Margin = New System.Windows.Forms.Padding(0, 0, 3, 3)
        Me.lblCycleValue.Name = "lblCycleValue"
        Me.lblCycleValue.Size = New System.Drawing.Size(69, 13)
        Me.lblCycleValue.TabIndex = 42
        Me.lblCycleValue.Text = "lblCycleValue"
        '
        'lblLifeTimeValue
        '
        Me.lblLifeTimeValue.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblLifeTimeValue.AutoSize = true
        Me.lblLifeTimeValue.ForeColor = System.Drawing.Color.Black
        Me.lblLifeTimeValue.Location = New System.Drawing.Point(116, 16)
        Me.lblLifeTimeValue.Margin = New System.Windows.Forms.Padding(0, 0, 3, 3)
        Me.lblLifeTimeValue.Name = "lblLifeTimeValue"
        Me.lblLifeTimeValue.Size = New System.Drawing.Size(82, 13)
        Me.lblLifeTimeValue.TabIndex = 43
        Me.lblLifeTimeValue.Text = "lblLifeTimeValue"
        '
        'lblRecommendedValue
        '
        Me.lblRecommendedValue.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblRecommendedValue.AutoSize = true
        Me.lblRecommendedValue.ForeColor = System.Drawing.Color.Black
        Me.lblRecommendedValue.Location = New System.Drawing.Point(116, 32)
        Me.lblRecommendedValue.Margin = New System.Windows.Forms.Padding(0, 0, 3, 3)
        Me.lblRecommendedValue.Name = "lblRecommendedValue"
        Me.lblRecommendedValue.Size = New System.Drawing.Size(113, 13)
        Me.lblRecommendedValue.TabIndex = 44
        Me.lblRecommendedValue.Text = "lblRecommendedValue"
        '
        'tpSetup
        '
        Me.tpSetup.BackColor = System.Drawing.Color.White
        Me.tpSetup.Controls.Add(Me.htcSetup)
        Me.tpSetup.Location = New System.Drawing.Point(4, 22)
        Me.tpSetup.Name = "tpSetup"
        Me.tpSetup.Size = New System.Drawing.Size(876, 300)
        Me.tpSetup.TabIndex = 1
        Me.tpSetup.Text = "tpSetup"
        '
        'htcSetup
        '
        Me.htcSetup.Controls.Add(Me.tpAtaSmartSetup)
        Me.htcSetup.Controls.Add(Me.tpScsiSmartSetup)
        Me.htcSetup.Controls.Add(Me.tpAtaAam)
        Me.htcSetup.Controls.Add(Me.tpAtaApm)
        Me.htcSetup.Controls.Add(Me.tpAtaStandby)
        Me.htcSetup.Controls.Add(Me.tpAtaReadWrite)
        Me.htcSetup.Dock = System.Windows.Forms.DockStyle.Fill
        Me.htcSetup.Location = New System.Drawing.Point(0, 0)
        Me.htcSetup.Name = "htcSetup"
        Me.htcSetup.SelectedIndex = 0
        Me.htcSetup.Size = New System.Drawing.Size(876, 300)
        Me.htcSetup.TabIndex = 0
        Me.htcSetup.TabStop = false
        '
        'tpAtaSmartSetup
        '
        Me.tpAtaSmartSetup.BackColor = System.Drawing.Color.White
        Me.tpAtaSmartSetup.Controls.Add(Me.tlpAtaSmart)
        Me.tpAtaSmartSetup.Location = New System.Drawing.Point(4, 22)
        Me.tpAtaSmartSetup.Name = "tpAtaSmartSetup"
        Me.tpAtaSmartSetup.Size = New System.Drawing.Size(868, 274)
        Me.tpAtaSmartSetup.TabIndex = 0
        Me.tpAtaSmartSetup.Text = "tpAtaSmartSetup"
        '
        'tlpAtaSmart
        '
        Me.tlpAtaSmart.AutoSize = true
        Me.tlpAtaSmart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlpAtaSmart.ColumnCount = 1
        Me.tlpAtaSmart.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tlpAtaSmart.Controls.Add(Me.lblSmart, 0, 3)
        Me.tlpAtaSmart.Controls.Add(Me.lblAdminSmart, 0, 0)
        Me.tlpAtaSmart.Controls.Add(Me.lblOfflineTest, 0, 5)
        Me.tlpAtaSmart.Controls.Add(Me.lblAttrAutosave, 0, 7)
        Me.tlpAtaSmart.Controls.Add(Me.chkEnableSmart, 0, 2)
        Me.tlpAtaSmart.Controls.Add(Me.chkEnableOffline, 0, 4)
        Me.tlpAtaSmart.Controls.Add(Me.chkEnableAutosave, 0, 6)
        Me.tlpAtaSmart.Controls.Add(Me.HorizontalLine2, 0, 1)
        Me.tlpAtaSmart.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpAtaSmart.Location = New System.Drawing.Point(0, 0)
        Me.tlpAtaSmart.Name = "tlpAtaSmart"
        Me.tlpAtaSmart.RowCount = 8
        Me.tlpAtaSmart.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpAtaSmart.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpAtaSmart.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpAtaSmart.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpAtaSmart.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpAtaSmart.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpAtaSmart.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpAtaSmart.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpAtaSmart.Size = New System.Drawing.Size(868, 150)
        Me.tlpAtaSmart.TabIndex = 15
        '
        'lblSmart
        '
        Me.lblSmart.AutoSize = true
        Me.lblSmart.ForeColor = System.Drawing.Color.DimGray
        Me.lblSmart.Location = New System.Drawing.Point(20, 60)
        Me.lblSmart.Margin = New System.Windows.Forms.Padding(20, 1, 3, 5)
        Me.lblSmart.Name = "lblSmart"
        Me.lblSmart.Size = New System.Drawing.Size(45, 13)
        Me.lblSmart.TabIndex = 1
        Me.lblSmart.Tag = "Grayed"
        Me.lblSmart.Text = "lblSmart"
        '
        'lblAdminSmart
        '
        Me.lblAdminSmart.AutoSize = true
        Me.lblAdminSmart.ForeColor = System.Drawing.Color.DimGray
        Me.lblAdminSmart.Location = New System.Drawing.Point(3, 7)
        Me.lblAdminSmart.Margin = New System.Windows.Forms.Padding(3, 7, 3, 3)
        Me.lblAdminSmart.Name = "lblAdminSmart"
        Me.lblAdminSmart.Size = New System.Drawing.Size(74, 13)
        Me.lblAdminSmart.TabIndex = 18
        Me.lblAdminSmart.Tag = "Grayed"
        Me.lblAdminSmart.Text = "lblAdminSmart"
        '
        'lblOfflineTest
        '
        Me.lblOfflineTest.AutoSize = true
        Me.lblOfflineTest.ForeColor = System.Drawing.Color.DimGray
        Me.lblOfflineTest.Location = New System.Drawing.Point(20, 96)
        Me.lblOfflineTest.Margin = New System.Windows.Forms.Padding(20, 1, 3, 5)
        Me.lblOfflineTest.Name = "lblOfflineTest"
        Me.lblOfflineTest.Size = New System.Drawing.Size(70, 13)
        Me.lblOfflineTest.TabIndex = 3
        Me.lblOfflineTest.Tag = "Grayed"
        Me.lblOfflineTest.Text = "lblOfflineTest"
        '
        'lblAttrAutosave
        '
        Me.lblAttrAutosave.AutoSize = true
        Me.lblAttrAutosave.ForeColor = System.Drawing.Color.DimGray
        Me.lblAttrAutosave.Location = New System.Drawing.Point(20, 132)
        Me.lblAttrAutosave.Margin = New System.Windows.Forms.Padding(20, 1, 3, 5)
        Me.lblAttrAutosave.Name = "lblAttrAutosave"
        Me.lblAttrAutosave.Size = New System.Drawing.Size(82, 13)
        Me.lblAttrAutosave.TabIndex = 5
        Me.lblAttrAutosave.Tag = "Grayed"
        Me.lblAttrAutosave.Text = "lblAttrAutosave"
        '
        'chkEnableSmart
        '
        Me.chkEnableSmart.AutoSize = true
        Me.chkEnableSmart.ForeColor = System.Drawing.Color.Black
        Me.chkEnableSmart.Location = New System.Drawing.Point(3, 42)
        Me.chkEnableSmart.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.chkEnableSmart.Name = "chkEnableSmart"
        Me.chkEnableSmart.Size = New System.Drawing.Size(102, 17)
        Me.chkEnableSmart.TabIndex = 0
        Me.chkEnableSmart.Text = "chkEnableSmart"
        Me.chkEnableSmart.UseVisualStyleBackColor = true
        '
        'chkEnableOffline
        '
        Me.chkEnableOffline.AutoSize = true
        Me.chkEnableOffline.ForeColor = System.Drawing.Color.Black
        Me.chkEnableOffline.Location = New System.Drawing.Point(3, 78)
        Me.chkEnableOffline.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.chkEnableOffline.Name = "chkEnableOffline"
        Me.chkEnableOffline.Size = New System.Drawing.Size(106, 17)
        Me.chkEnableOffline.TabIndex = 1
        Me.chkEnableOffline.Text = "chkEnableOffline"
        Me.chkEnableOffline.UseVisualStyleBackColor = true
        '
        'chkEnableAutosave
        '
        Me.chkEnableAutosave.AutoSize = true
        Me.chkEnableAutosave.ForeColor = System.Drawing.Color.Black
        Me.chkEnableAutosave.Location = New System.Drawing.Point(3, 114)
        Me.chkEnableAutosave.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.chkEnableAutosave.Name = "chkEnableAutosave"
        Me.chkEnableAutosave.Size = New System.Drawing.Size(120, 17)
        Me.chkEnableAutosave.TabIndex = 2
        Me.chkEnableAutosave.Text = "chkEnableAutosave"
        Me.chkEnableAutosave.UseVisualStyleBackColor = true
        '
        'HorizontalLine2
        '
        Me.HorizontalLine2.BackColor = System.Drawing.Color.Silver
        Me.HorizontalLine2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HorizontalLine2.Location = New System.Drawing.Point(3, 32)
        Me.HorizontalLine2.Margin = New System.Windows.Forms.Padding(3, 9, 3, 9)
        Me.HorizontalLine2.MaximumSize = New System.Drawing.Size(0, 1)
        Me.HorizontalLine2.Name = "HorizontalLine2"
        Me.HorizontalLine2.Size = New System.Drawing.Size(862, 1)
        Me.HorizontalLine2.TabIndex = 24
        Me.HorizontalLine2.TabStop = false
        '
        'tpScsiSmartSetup
        '
        Me.tpScsiSmartSetup.BackColor = System.Drawing.Color.White
        Me.tpScsiSmartSetup.Controls.Add(Me.tlpScsiSmart)
        Me.tpScsiSmartSetup.Location = New System.Drawing.Point(4, 22)
        Me.tpScsiSmartSetup.Margin = New System.Windows.Forms.Padding(0)
        Me.tpScsiSmartSetup.Name = "tpScsiSmartSetup"
        Me.tpScsiSmartSetup.Size = New System.Drawing.Size(868, 274)
        Me.tpScsiSmartSetup.TabIndex = 1
        Me.tpScsiSmartSetup.Text = "tpScsiSmartSetup"
        '
        'tlpScsiSmart
        '
        Me.tlpScsiSmart.AutoSize = true
        Me.tlpScsiSmart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlpScsiSmart.ColumnCount = 1
        Me.tlpScsiSmart.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tlpScsiSmart.Controls.Add(Me.lblAdminScsiSmart, 0, 0)
        Me.tlpScsiSmart.Controls.Add(Me.lblScsiGltsd, 0, 5)
        Me.tlpScsiSmart.Controls.Add(Me.lblScsiRCache, 0, 9)
        Me.tlpScsiSmart.Controls.Add(Me.chkScsiRCache, 0, 8)
        Me.tlpScsiSmart.Controls.Add(Me.chkScsiWCache, 0, 6)
        Me.tlpScsiSmart.Controls.Add(Me.lblScsiWCache, 0, 7)
        Me.tlpScsiSmart.Controls.Add(Me.chkScsiSmart, 0, 2)
        Me.tlpScsiSmart.Controls.Add(Me.chkScsiGltsd, 0, 4)
        Me.tlpScsiSmart.Controls.Add(Me.lblScsiSmart, 0, 3)
        Me.tlpScsiSmart.Controls.Add(Me.HorizontalLine13, 0, 1)
        Me.tlpScsiSmart.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpScsiSmart.Location = New System.Drawing.Point(0, 0)
        Me.tlpScsiSmart.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpScsiSmart.Name = "tlpScsiSmart"
        Me.tlpScsiSmart.RowCount = 10
        Me.tlpScsiSmart.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpScsiSmart.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpScsiSmart.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpScsiSmart.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpScsiSmart.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpScsiSmart.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpScsiSmart.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpScsiSmart.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpScsiSmart.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpScsiSmart.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpScsiSmart.Size = New System.Drawing.Size(868, 186)
        Me.tlpScsiSmart.TabIndex = 16
        '
        'lblAdminScsiSmart
        '
        Me.lblAdminScsiSmart.AutoSize = true
        Me.lblAdminScsiSmart.ForeColor = System.Drawing.Color.DimGray
        Me.lblAdminScsiSmart.Location = New System.Drawing.Point(3, 7)
        Me.lblAdminScsiSmart.Margin = New System.Windows.Forms.Padding(3, 7, 3, 3)
        Me.lblAdminScsiSmart.Name = "lblAdminScsiSmart"
        Me.lblAdminScsiSmart.Size = New System.Drawing.Size(92, 13)
        Me.lblAdminScsiSmart.TabIndex = 28
        Me.lblAdminScsiSmart.Tag = "Grayed"
        Me.lblAdminScsiSmart.Text = "lblAdminScsiSmart"
        '
        'lblScsiGltsd
        '
        Me.lblScsiGltsd.AutoSize = true
        Me.lblScsiGltsd.ForeColor = System.Drawing.Color.DimGray
        Me.lblScsiGltsd.Location = New System.Drawing.Point(20, 96)
        Me.lblScsiGltsd.Margin = New System.Windows.Forms.Padding(20, 1, 3, 5)
        Me.lblScsiGltsd.Name = "lblScsiGltsd"
        Me.lblScsiGltsd.Size = New System.Drawing.Size(59, 13)
        Me.lblScsiGltsd.TabIndex = 5
        Me.lblScsiGltsd.Tag = "Grayed"
        Me.lblScsiGltsd.Text = "lblScsiGltsd"
        '
        'lblScsiRCache
        '
        Me.lblScsiRCache.AutoSize = true
        Me.lblScsiRCache.ForeColor = System.Drawing.Color.DimGray
        Me.lblScsiRCache.Location = New System.Drawing.Point(20, 168)
        Me.lblScsiRCache.Margin = New System.Windows.Forms.Padding(20, 1, 3, 5)
        Me.lblScsiRCache.Name = "lblScsiRCache"
        Me.lblScsiRCache.Size = New System.Drawing.Size(72, 13)
        Me.lblScsiRCache.TabIndex = 27
        Me.lblScsiRCache.Tag = "Grayed"
        Me.lblScsiRCache.Text = "lblScsiRCache"
        '
        'chkScsiRCache
        '
        Me.chkScsiRCache.AutoSize = true
        Me.chkScsiRCache.ForeColor = System.Drawing.Color.Black
        Me.chkScsiRCache.Location = New System.Drawing.Point(3, 150)
        Me.chkScsiRCache.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.chkScsiRCache.Name = "chkScsiRCache"
        Me.chkScsiRCache.Size = New System.Drawing.Size(97, 17)
        Me.chkScsiRCache.TabIndex = 3
        Me.chkScsiRCache.Text = "chkScsiRCache"
        Me.chkScsiRCache.UseVisualStyleBackColor = true
        '
        'chkScsiWCache
        '
        Me.chkScsiWCache.AutoSize = true
        Me.chkScsiWCache.ForeColor = System.Drawing.Color.Black
        Me.chkScsiWCache.Location = New System.Drawing.Point(3, 114)
        Me.chkScsiWCache.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.chkScsiWCache.Name = "chkScsiWCache"
        Me.chkScsiWCache.Size = New System.Drawing.Size(100, 17)
        Me.chkScsiWCache.TabIndex = 2
        Me.chkScsiWCache.Text = "chkScsiWCache"
        Me.chkScsiWCache.UseVisualStyleBackColor = true
        '
        'lblScsiWCache
        '
        Me.lblScsiWCache.AutoSize = true
        Me.lblScsiWCache.ForeColor = System.Drawing.Color.DimGray
        Me.lblScsiWCache.Location = New System.Drawing.Point(20, 132)
        Me.lblScsiWCache.Margin = New System.Windows.Forms.Padding(20, 1, 3, 5)
        Me.lblScsiWCache.Name = "lblScsiWCache"
        Me.lblScsiWCache.Size = New System.Drawing.Size(75, 13)
        Me.lblScsiWCache.TabIndex = 26
        Me.lblScsiWCache.Tag = "Grayed"
        Me.lblScsiWCache.Text = "lblScsiWCache"
        '
        'chkScsiSmart
        '
        Me.chkScsiSmart.AutoSize = true
        Me.chkScsiSmart.ForeColor = System.Drawing.Color.Black
        Me.chkScsiSmart.Location = New System.Drawing.Point(3, 42)
        Me.chkScsiSmart.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.chkScsiSmart.Name = "chkScsiSmart"
        Me.chkScsiSmart.Size = New System.Drawing.Size(88, 17)
        Me.chkScsiSmart.TabIndex = 0
        Me.chkScsiSmart.Text = "chkScsiSmart"
        Me.chkScsiSmart.UseVisualStyleBackColor = true
        '
        'chkScsiGltsd
        '
        Me.chkScsiGltsd.AutoSize = true
        Me.chkScsiGltsd.ForeColor = System.Drawing.Color.Black
        Me.chkScsiGltsd.Location = New System.Drawing.Point(3, 78)
        Me.chkScsiGltsd.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.chkScsiGltsd.Name = "chkScsiGltsd"
        Me.chkScsiGltsd.Size = New System.Drawing.Size(84, 17)
        Me.chkScsiGltsd.TabIndex = 1
        Me.chkScsiGltsd.Text = "chkScsiGltsd"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)
        Me.chkScsiGltsd.UseVisualStyleBackColor = true
        '
        'lblScsiSmart
        '
        Me.lblScsiSmart.AutoSize = true
        Me.lblScsiSmart.ForeColor = System.Drawing.Color.DimGray
        Me.lblScsiSmart.Location = New System.Drawing.Point(20, 60)
        Me.lblScsiSmart.Margin = New System.Windows.Forms.Padding(20, 1, 3, 5)
        Me.lblScsiSmart.Name = "lblScsiSmart"
        Me.lblScsiSmart.Size = New System.Drawing.Size(63, 13)
        Me.lblScsiSmart.TabIndex = 1
        Me.lblScsiSmart.Tag = "Grayed"
        Me.lblScsiSmart.Text = "lblScsiSmart"
        '
        'HorizontalLine13
        '
        Me.HorizontalLine13.BackColor = System.Drawing.Color.Silver
        Me.HorizontalLine13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HorizontalLine13.Location = New System.Drawing.Point(3, 32)
        Me.HorizontalLine13.Margin = New System.Windows.Forms.Padding(3, 9, 3, 9)
        Me.HorizontalLine13.MaximumSize = New System.Drawing.Size(0, 1)
        Me.HorizontalLine13.Name = "HorizontalLine13"
        Me.HorizontalLine13.Size = New System.Drawing.Size(862, 1)
        Me.HorizontalLine13.TabIndex = 29
        Me.HorizontalLine13.TabStop = false
        '
        'tpAtaAam
        '
        Me.tpAtaAam.AutoScroll = true
        Me.tpAtaAam.BackColor = System.Drawing.Color.White
        Me.tpAtaAam.Controls.Add(Me.tlpAtaAam)
        Me.tpAtaAam.Location = New System.Drawing.Point(4, 22)
        Me.tpAtaAam.Name = "tpAtaAam"
        Me.tpAtaAam.Size = New System.Drawing.Size(868, 274)
        Me.tpAtaAam.TabIndex = 2
        Me.tpAtaAam.Text = "tpAtaAam"
        '
        'tlpAtaAam
        '
        Me.tlpAtaAam.AutoSize = true
        Me.tlpAtaAam.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlpAtaAam.ColumnCount = 1
        Me.tlpAtaAam.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tlpAtaAam.Controls.Add(tlpAam, 0, 4)
        Me.tlpAtaAam.Controls.Add(Me.trkAam, 0, 3)
        Me.tlpAtaAam.Controls.Add(tlpAamLoud, 0, 2)
        Me.tlpAtaAam.Controls.Add(Me.HorizontalLine3, 0, 1)
        Me.tlpAtaAam.Controls.Add(Me.lblInfoAam, 0, 0)
        Me.tlpAtaAam.Controls.Add(Me.tlpAamWaitMessage, 0, 6)
        Me.tlpAtaAam.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpAtaAam.Location = New System.Drawing.Point(0, 0)
        Me.tlpAtaAam.Name = "tlpAtaAam"
        Me.tlpAtaAam.RowCount = 7
        Me.tlpAtaAam.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpAtaAam.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpAtaAam.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpAtaAam.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpAtaAam.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpAtaAam.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20!))
        Me.tlpAtaAam.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpAtaAam.Size = New System.Drawing.Size(868, 226)
        Me.tlpAtaAam.TabIndex = 3
        '
        'trkAam
        '
        Me.trkAam.BackColor = System.Drawing.Color.White
        Me.trkAam.Dock = System.Windows.Forms.DockStyle.Fill
        Me.trkAam.Location = New System.Drawing.Point(0, 67)
        Me.trkAam.Margin = New System.Windows.Forms.Padding(0, 3, 3, 3)
        Me.trkAam.Maximum = 254
        Me.trkAam.Name = "trkAam"
        Me.trkAam.Size = New System.Drawing.Size(865, 45)
        Me.trkAam.TabIndex = 0
        Me.trkAam.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'HorizontalLine3
        '
        Me.HorizontalLine3.BackColor = System.Drawing.Color.Silver
        Me.HorizontalLine3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HorizontalLine3.Location = New System.Drawing.Point(3, 32)
        Me.HorizontalLine3.Margin = New System.Windows.Forms.Padding(3, 9, 3, 9)
        Me.HorizontalLine3.MaximumSize = New System.Drawing.Size(0, 1)
        Me.HorizontalLine3.Name = "HorizontalLine3"
        Me.HorizontalLine3.Size = New System.Drawing.Size(862, 1)
        Me.HorizontalLine3.TabIndex = 34
        Me.HorizontalLine3.TabStop = false
        '
        'lblInfoAam
        '
        Me.lblInfoAam.AutoSize = true
        Me.lblInfoAam.ForeColor = System.Drawing.Color.DimGray
        Me.lblInfoAam.Location = New System.Drawing.Point(3, 7)
        Me.lblInfoAam.Margin = New System.Windows.Forms.Padding(3, 7, 3, 3)
        Me.lblInfoAam.Name = "lblInfoAam"
        Me.lblInfoAam.Size = New System.Drawing.Size(58, 13)
        Me.lblInfoAam.TabIndex = 3
        Me.lblInfoAam.Text = "lblInfoAam"
        '
        'tlpAamWaitMessage
        '
        Me.tlpAamWaitMessage.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tlpAamWaitMessage.AutoSize = true
        Me.tlpAamWaitMessage.ColumnCount = 2
        Me.tlpAamWaitMessage.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpAamWaitMessage.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpAamWaitMessage.Controls.Add(Me.lblAamWaitMessage, 1, 0)
        Me.tlpAamWaitMessage.Controls.Add(Me.picLoaderAam, 0, 0)
        Me.tlpAamWaitMessage.Location = New System.Drawing.Point(369, 201)
        Me.tlpAamWaitMessage.Name = "tlpAamWaitMessage"
        Me.tlpAamWaitMessage.RowCount = 1
        Me.tlpAamWaitMessage.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpAamWaitMessage.Size = New System.Drawing.Size(130, 22)
        Me.tlpAamWaitMessage.TabIndex = 4
        '
        'lblAamWaitMessage
        '
        Me.lblAamWaitMessage.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblAamWaitMessage.AutoSize = true
        Me.lblAamWaitMessage.ForeColor = System.Drawing.Color.Black
        Me.lblAamWaitMessage.Location = New System.Drawing.Point(25, 4)
        Me.lblAamWaitMessage.Name = "lblAamWaitMessage"
        Me.lblAamWaitMessage.Size = New System.Drawing.Size(102, 13)
        Me.lblAamWaitMessage.TabIndex = 0
        Me.lblAamWaitMessage.Text = "lblAamWaitMessage"
        '
        'picLoaderAam
        '
        Me.picLoaderAam.Image = Global.hdd_guardian.My.Resources.Resources.loader
        Me.picLoaderAam.Location = New System.Drawing.Point(3, 3)
        Me.picLoaderAam.MaximumSize = New System.Drawing.Size(16, 16)
        Me.picLoaderAam.Name = "picLoaderAam"
        Me.picLoaderAam.Size = New System.Drawing.Size(16, 16)
        Me.picLoaderAam.TabIndex = 1
        Me.picLoaderAam.TabStop = false
        '
        'tpAtaApm
        '
        Me.tpAtaApm.AutoScroll = true
        Me.tpAtaApm.BackColor = System.Drawing.Color.White
        Me.tpAtaApm.Controls.Add(Me.tlpApmContent)
        Me.tpAtaApm.Location = New System.Drawing.Point(4, 22)
        Me.tpAtaApm.Name = "tpAtaApm"
        Me.tpAtaApm.Size = New System.Drawing.Size(868, 274)
        Me.tpAtaApm.TabIndex = 3
        Me.tpAtaApm.Text = "tpAtaApm"
        '
        'tlpApmContent
        '
        Me.tlpApmContent.AutoSize = true
        Me.tlpApmContent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlpApmContent.ColumnCount = 1
        Me.tlpApmContent.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tlpApmContent.Controls.Add(Me.tlpApmWaitMessage, 0, 5)
        Me.tlpApmContent.Controls.Add(Me.trkApm, 0, 2)
        Me.tlpApmContent.Controls.Add(tlpApm, 0, 3)
        Me.tlpApmContent.Controls.Add(Me.HorizontalLine4, 0, 1)
        Me.tlpApmContent.Controls.Add(Me.lblInfoApm, 0, 0)
        Me.tlpApmContent.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpApmContent.Location = New System.Drawing.Point(0, 0)
        Me.tlpApmContent.Name = "tlpApmContent"
        Me.tlpApmContent.RowCount = 6
        Me.tlpApmContent.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpApmContent.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpApmContent.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpApmContent.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpApmContent.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20!))
        Me.tlpApmContent.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpApmContent.Size = New System.Drawing.Size(868, 185)
        Me.tlpApmContent.TabIndex = 4
        '
        'tlpApmWaitMessage
        '
        Me.tlpApmWaitMessage.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tlpApmWaitMessage.AutoSize = true
        Me.tlpApmWaitMessage.ColumnCount = 2
        Me.tlpApmWaitMessage.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpApmWaitMessage.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpApmWaitMessage.Controls.Add(Me.lblApmWaitMessage, 1, 0)
        Me.tlpApmWaitMessage.Controls.Add(Me.picLoaderApm, 0, 0)
        Me.tlpApmWaitMessage.Location = New System.Drawing.Point(369, 160)
        Me.tlpApmWaitMessage.Name = "tlpApmWaitMessage"
        Me.tlpApmWaitMessage.RowCount = 1
        Me.tlpApmWaitMessage.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpApmWaitMessage.Size = New System.Drawing.Size(130, 22)
        Me.tlpApmWaitMessage.TabIndex = 35
        '
        'lblApmWaitMessage
        '
        Me.lblApmWaitMessage.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblApmWaitMessage.AutoSize = true
        Me.lblApmWaitMessage.ForeColor = System.Drawing.Color.Black
        Me.lblApmWaitMessage.Location = New System.Drawing.Point(25, 4)
        Me.lblApmWaitMessage.Name = "lblApmWaitMessage"
        Me.lblApmWaitMessage.Size = New System.Drawing.Size(102, 13)
        Me.lblApmWaitMessage.TabIndex = 0
        Me.lblApmWaitMessage.Text = "lblApmWaitMessage"
        '
        'picLoaderApm
        '
        Me.picLoaderApm.Image = Global.hdd_guardian.My.Resources.Resources.loader
        Me.picLoaderApm.Location = New System.Drawing.Point(3, 3)
        Me.picLoaderApm.MaximumSize = New System.Drawing.Size(16, 16)
        Me.picLoaderApm.Name = "picLoaderApm"
        Me.picLoaderApm.Size = New System.Drawing.Size(16, 16)
        Me.picLoaderApm.TabIndex = 1
        Me.picLoaderApm.TabStop = false
        '
        'trkApm
        '
        Me.trkApm.BackColor = System.Drawing.SystemColors.Window
        Me.trkApm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.trkApm.Location = New System.Drawing.Point(0, 45)
        Me.trkApm.Margin = New System.Windows.Forms.Padding(0, 3, 3, 3)
        Me.trkApm.Maximum = 254
        Me.trkApm.Name = "trkApm"
        Me.trkApm.Size = New System.Drawing.Size(865, 45)
        Me.trkApm.TabIndex = 0
        Me.trkApm.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'HorizontalLine4
        '
        Me.HorizontalLine4.BackColor = System.Drawing.Color.Silver
        Me.HorizontalLine4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HorizontalLine4.Location = New System.Drawing.Point(3, 32)
        Me.HorizontalLine4.Margin = New System.Windows.Forms.Padding(3, 9, 3, 9)
        Me.HorizontalLine4.MaximumSize = New System.Drawing.Size(0, 1)
        Me.HorizontalLine4.Name = "HorizontalLine4"
        Me.HorizontalLine4.Size = New System.Drawing.Size(862, 1)
        Me.HorizontalLine4.TabIndex = 34
        Me.HorizontalLine4.TabStop = false
        '
        'lblInfoApm
        '
        Me.lblInfoApm.AutoSize = true
        Me.lblInfoApm.ForeColor = System.Drawing.Color.DimGray
        Me.lblInfoApm.Location = New System.Drawing.Point(3, 7)
        Me.lblInfoApm.Margin = New System.Windows.Forms.Padding(3, 7, 3, 3)
        Me.lblInfoApm.Name = "lblInfoApm"
        Me.lblInfoApm.Size = New System.Drawing.Size(58, 13)
        Me.lblInfoApm.TabIndex = 3
        Me.lblInfoApm.Text = "lblInfoApm"
        '
        'tpAtaStandby
        '
        Me.tpAtaStandby.AutoScroll = true
        Me.tpAtaStandby.BackColor = System.Drawing.Color.White
        Me.tpAtaStandby.Controls.Add(Me.tlpStandbyContent)
        Me.tpAtaStandby.Location = New System.Drawing.Point(4, 22)
        Me.tpAtaStandby.Name = "tpAtaStandby"
        Me.tpAtaStandby.Size = New System.Drawing.Size(868, 274)
        Me.tpAtaStandby.TabIndex = 4
        Me.tpAtaStandby.Text = "tpAtaStandby"
        '
        'tlpStandbyContent
        '
        Me.tlpStandbyContent.AutoSize = true
        Me.tlpStandbyContent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlpStandbyContent.ColumnCount = 1
        Me.tlpStandbyContent.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tlpStandbyContent.Controls.Add(Me.tlpStandbyWaitMessage, 0, 5)
        Me.tlpStandbyContent.Controls.Add(tlpStandby, 0, 3)
        Me.tlpStandbyContent.Controls.Add(Me.trkStandby, 0, 2)
        Me.tlpStandbyContent.Controls.Add(Me.HorizontalLine5, 0, 1)
        Me.tlpStandbyContent.Controls.Add(Me.lblInfoStandby, 0, 0)
        Me.tlpStandbyContent.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpStandbyContent.Location = New System.Drawing.Point(0, 0)
        Me.tlpStandbyContent.Name = "tlpStandbyContent"
        Me.tlpStandbyContent.RowCount = 6
        Me.tlpStandbyContent.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpStandbyContent.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpStandbyContent.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpStandbyContent.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpStandbyContent.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20!))
        Me.tlpStandbyContent.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpStandbyContent.Size = New System.Drawing.Size(868, 186)
        Me.tlpStandbyContent.TabIndex = 5
        '
        'tlpStandbyWaitMessage
        '
        Me.tlpStandbyWaitMessage.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tlpStandbyWaitMessage.AutoSize = true
        Me.tlpStandbyWaitMessage.ColumnCount = 2
        Me.tlpStandbyWaitMessage.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpStandbyWaitMessage.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpStandbyWaitMessage.Controls.Add(Me.lblStandbyWaitMessage, 1, 0)
        Me.tlpStandbyWaitMessage.Controls.Add(Me.picLoaderStandby, 0, 0)
        Me.tlpStandbyWaitMessage.Location = New System.Drawing.Point(359, 161)
        Me.tlpStandbyWaitMessage.Name = "tlpStandbyWaitMessage"
        Me.tlpStandbyWaitMessage.RowCount = 1
        Me.tlpStandbyWaitMessage.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpStandbyWaitMessage.Size = New System.Drawing.Size(149, 22)
        Me.tlpStandbyWaitMessage.TabIndex = 36
        '
        'lblStandbyWaitMessage
        '
        Me.lblStandbyWaitMessage.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblStandbyWaitMessage.AutoSize = true
        Me.lblStandbyWaitMessage.ForeColor = System.Drawing.Color.Black
        Me.lblStandbyWaitMessage.Location = New System.Drawing.Point(25, 4)
        Me.lblStandbyWaitMessage.Name = "lblStandbyWaitMessage"
        Me.lblStandbyWaitMessage.Size = New System.Drawing.Size(121, 13)
        Me.lblStandbyWaitMessage.TabIndex = 0
        Me.lblStandbyWaitMessage.Text = "lblStandbyWaitMessage"
        '
        'picLoaderStandby
        '
        Me.picLoaderStandby.Image = Global.hdd_guardian.My.Resources.Resources.loader
        Me.picLoaderStandby.Location = New System.Drawing.Point(3, 3)
        Me.picLoaderStandby.MaximumSize = New System.Drawing.Size(16, 16)
        Me.picLoaderStandby.Name = "picLoaderStandby"
        Me.picLoaderStandby.Size = New System.Drawing.Size(16, 16)
        Me.picLoaderStandby.TabIndex = 1
        Me.picLoaderStandby.TabStop = false
        '
        'trkStandby
        '
        Me.trkStandby.BackColor = System.Drawing.SystemColors.Window
        Me.trkStandby.Dock = System.Windows.Forms.DockStyle.Fill
        Me.trkStandby.Location = New System.Drawing.Point(0, 45)
        Me.trkStandby.Margin = New System.Windows.Forms.Padding(0, 3, 3, 3)
        Me.trkStandby.Maximum = 255
        Me.trkStandby.Name = "trkStandby"
        Me.trkStandby.Size = New System.Drawing.Size(865, 45)
        Me.trkStandby.TabIndex = 0
        Me.trkStandby.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'HorizontalLine5
        '
        Me.HorizontalLine5.BackColor = System.Drawing.Color.Silver
        Me.HorizontalLine5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HorizontalLine5.Location = New System.Drawing.Point(3, 32)
        Me.HorizontalLine5.Margin = New System.Windows.Forms.Padding(3, 9, 3, 9)
        Me.HorizontalLine5.MaximumSize = New System.Drawing.Size(0, 1)
        Me.HorizontalLine5.Name = "HorizontalLine5"
        Me.HorizontalLine5.Size = New System.Drawing.Size(862, 1)
        Me.HorizontalLine5.TabIndex = 34
        Me.HorizontalLine5.TabStop = false
        '
        'lblInfoStandby
        '
        Me.lblInfoStandby.AutoSize = true
        Me.lblInfoStandby.ForeColor = System.Drawing.Color.DimGray
        Me.lblInfoStandby.Location = New System.Drawing.Point(3, 7)
        Me.lblInfoStandby.Margin = New System.Windows.Forms.Padding(3, 7, 3, 3)
        Me.lblInfoStandby.Name = "lblInfoStandby"
        Me.lblInfoStandby.Size = New System.Drawing.Size(77, 13)
        Me.lblInfoStandby.TabIndex = 3
        Me.lblInfoStandby.Text = "lblInfoStandby"
        '
        'tpAtaReadWrite
        '
        Me.tpAtaReadWrite.AutoScroll = true
        Me.tpAtaReadWrite.BackColor = System.Drawing.Color.White
        Me.tpAtaReadWrite.Controls.Add(Me.tlpOtherContent)
        Me.tpAtaReadWrite.Location = New System.Drawing.Point(4, 22)
        Me.tpAtaReadWrite.Name = "tpAtaReadWrite"
        Me.tpAtaReadWrite.Size = New System.Drawing.Size(868, 274)
        Me.tpAtaReadWrite.TabIndex = 5
        Me.tpAtaReadWrite.Text = "tpAtaReadWrite"
        '
        'tlpOtherContent
        '
        Me.tlpOtherContent.AutoSize = true
        Me.tlpOtherContent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlpOtherContent.ColumnCount = 1
        Me.tlpOtherContent.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tlpOtherContent.Controls.Add(Me.tlpWaitRWMessage, 0, 4)
        Me.tlpOtherContent.Controls.Add(Me.flwOtherFeatures, 0, 2)
        Me.tlpOtherContent.Controls.Add(Me.lblAdminOther, 0, 0)
        Me.tlpOtherContent.Controls.Add(Me.HorizontalLine6, 0, 1)
        Me.tlpOtherContent.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpOtherContent.Location = New System.Drawing.Point(0, 0)
        Me.tlpOtherContent.Name = "tlpOtherContent"
        Me.tlpOtherContent.RowCount = 5
        Me.tlpOtherContent.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpOtherContent.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpOtherContent.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpOtherContent.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20!))
        Me.tlpOtherContent.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpOtherContent.Size = New System.Drawing.Size(868, 216)
        Me.tlpOtherContent.TabIndex = 24
        '
        'tlpWaitRWMessage
        '
        Me.tlpWaitRWMessage.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tlpWaitRWMessage.AutoSize = true
        Me.tlpWaitRWMessage.ColumnCount = 2
        Me.tlpWaitRWMessage.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpWaitRWMessage.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpWaitRWMessage.Controls.Add(Me.lblWaitRWMessage, 1, 0)
        Me.tlpWaitRWMessage.Controls.Add(Me.picLoaderRW, 0, 0)
        Me.tlpWaitRWMessage.Location = New System.Drawing.Point(371, 191)
        Me.tlpWaitRWMessage.Name = "tlpWaitRWMessage"
        Me.tlpWaitRWMessage.RowCount = 1
        Me.tlpWaitRWMessage.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpWaitRWMessage.Size = New System.Drawing.Size(126, 22)
        Me.tlpWaitRWMessage.TabIndex = 36
        '
        'lblWaitRWMessage
        '
        Me.lblWaitRWMessage.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblWaitRWMessage.AutoSize = true
        Me.lblWaitRWMessage.ForeColor = System.Drawing.Color.Black
        Me.lblWaitRWMessage.Location = New System.Drawing.Point(25, 4)
        Me.lblWaitRWMessage.Name = "lblWaitRWMessage"
        Me.lblWaitRWMessage.Size = New System.Drawing.Size(98, 13)
        Me.lblWaitRWMessage.TabIndex = 0
        Me.lblWaitRWMessage.Text = "lblWaitRWMessage"
        '
        'picLoaderRW
        '
        Me.picLoaderRW.Image = Global.hdd_guardian.My.Resources.Resources.loader
        Me.picLoaderRW.Location = New System.Drawing.Point(3, 3)
        Me.picLoaderRW.MaximumSize = New System.Drawing.Size(16, 16)
        Me.picLoaderRW.Name = "picLoaderRW"
        Me.picLoaderRW.Size = New System.Drawing.Size(16, 16)
        Me.picLoaderRW.TabIndex = 1
        Me.picLoaderRW.TabStop = false
        '
        'flwOtherFeatures
        '
        Me.flwOtherFeatures.AutoSize = true
        Me.flwOtherFeatures.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.flwOtherFeatures.Controls.Add(Me.chkCache)
        Me.flwOtherFeatures.Controls.Add(Me.lblCacheInfo)
        Me.flwOtherFeatures.Controls.Add(Me.chkCacheReorder)
        Me.flwOtherFeatures.Controls.Add(Me.lblCacheReorderInfo)
        Me.flwOtherFeatures.Controls.Add(Me.chkLookAhead)
        Me.flwOtherFeatures.Controls.Add(Me.lblLookAheadInfo)
        Me.flwOtherFeatures.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flwOtherFeatures.Location = New System.Drawing.Point(0, 45)
        Me.flwOtherFeatures.Margin = New System.Windows.Forms.Padding(0, 3, 3, 3)
        Me.flwOtherFeatures.Name = "flwOtherFeatures"
        Me.flwOtherFeatures.Size = New System.Drawing.Size(865, 120)
        Me.flwOtherFeatures.TabIndex = 0
        '
        'chkCache
        '
        Me.chkCache.AutoSize = true
        Me.flwOtherFeatures.SetFlowBreak(Me.chkCache, true)
        Me.chkCache.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkCache.ForeColor = System.Drawing.Color.Black
        Me.chkCache.Location = New System.Drawing.Point(3, 0)
        Me.chkCache.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.chkCache.MinimumSize = New System.Drawing.Size(0, 16)
        Me.chkCache.Name = "chkCache"
        Me.chkCache.Size = New System.Drawing.Size(72, 17)
        Me.chkCache.TabIndex = 0
        Me.chkCache.Text = "chkCache"
        Me.chkCache.UseVisualStyleBackColor = true
        '
        'lblCacheInfo
        '
        Me.lblCacheInfo.AutoSize = true
        Me.flwOtherFeatures.SetFlowBreak(Me.lblCacheInfo, true)
        Me.lblCacheInfo.ForeColor = System.Drawing.Color.DimGray
        Me.lblCacheInfo.Location = New System.Drawing.Point(20, 20)
        Me.lblCacheInfo.Margin = New System.Windows.Forms.Padding(20, 0, 3, 7)
        Me.lblCacheInfo.Name = "lblCacheInfo"
        Me.lblCacheInfo.Size = New System.Drawing.Size(67, 13)
        Me.lblCacheInfo.TabIndex = 23
        Me.lblCacheInfo.Tag = "Grayed"
        Me.lblCacheInfo.Text = "lblCacheInfo"
        '
        'chkCacheReorder
        '
        Me.chkCacheReorder.AutoSize = true
        Me.flwOtherFeatures.SetFlowBreak(Me.chkCacheReorder, true)
        Me.chkCacheReorder.ForeColor = System.Drawing.Color.Black
        Me.chkCacheReorder.Location = New System.Drawing.Point(3, 40)
        Me.chkCacheReorder.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.chkCacheReorder.Name = "chkCacheReorder"
        Me.chkCacheReorder.Size = New System.Drawing.Size(111, 17)
        Me.chkCacheReorder.TabIndex = 1
        Me.chkCacheReorder.Text = "chkCacheReorder"
        Me.chkCacheReorder.UseVisualStyleBackColor = true
        '
        'lblCacheReorderInfo
        '
        Me.lblCacheReorderInfo.AutoSize = true
        Me.flwOtherFeatures.SetFlowBreak(Me.lblCacheReorderInfo, true)
        Me.lblCacheReorderInfo.ForeColor = System.Drawing.Color.DimGray
        Me.lblCacheReorderInfo.Location = New System.Drawing.Point(20, 60)
        Me.lblCacheReorderInfo.Margin = New System.Windows.Forms.Padding(20, 0, 3, 7)
        Me.lblCacheReorderInfo.Name = "lblCacheReorderInfo"
        Me.lblCacheReorderInfo.Size = New System.Drawing.Size(106, 13)
        Me.lblCacheReorderInfo.TabIndex = 26
        Me.lblCacheReorderInfo.Tag = "Grayed"
        Me.lblCacheReorderInfo.Text = "lblCacheReorderInfo"
        '
        'chkLookAhead
        '
        Me.chkLookAhead.AutoSize = true
        Me.flwOtherFeatures.SetFlowBreak(Me.chkLookAhead, true)
        Me.chkLookAhead.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkLookAhead.ForeColor = System.Drawing.Color.Black
        Me.chkLookAhead.Location = New System.Drawing.Point(3, 80)
        Me.chkLookAhead.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.chkLookAhead.MinimumSize = New System.Drawing.Size(0, 16)
        Me.chkLookAhead.Name = "chkLookAhead"
        Me.chkLookAhead.Size = New System.Drawing.Size(95, 17)
        Me.chkLookAhead.TabIndex = 2
        Me.chkLookAhead.Text = "chkLookAhead"
        Me.chkLookAhead.UseVisualStyleBackColor = true
        '
        'lblLookAheadInfo
        '
        Me.lblLookAheadInfo.AutoSize = true
        Me.flwOtherFeatures.SetFlowBreak(Me.lblLookAheadInfo, true)
        Me.lblLookAheadInfo.ForeColor = System.Drawing.Color.DimGray
        Me.lblLookAheadInfo.Location = New System.Drawing.Point(20, 100)
        Me.lblLookAheadInfo.Margin = New System.Windows.Forms.Padding(20, 0, 3, 7)
        Me.lblLookAheadInfo.Name = "lblLookAheadInfo"
        Me.lblLookAheadInfo.Size = New System.Drawing.Size(90, 13)
        Me.lblLookAheadInfo.TabIndex = 24
        Me.lblLookAheadInfo.Tag = "Grayed"
        Me.lblLookAheadInfo.Text = "lblLookAheadInfo"
        '
        'lblAdminOther
        '
        Me.lblAdminOther.AutoSize = true
        Me.lblAdminOther.ForeColor = System.Drawing.Color.DimGray
        Me.lblAdminOther.Location = New System.Drawing.Point(3, 7)
        Me.lblAdminOther.Margin = New System.Windows.Forms.Padding(3, 7, 3, 3)
        Me.lblAdminOther.Name = "lblAdminOther"
        Me.lblAdminOther.Size = New System.Drawing.Size(74, 13)
        Me.lblAdminOther.TabIndex = 3
        Me.lblAdminOther.Text = "lblAdminOther"
        '
        'HorizontalLine6
        '
        Me.HorizontalLine6.BackColor = System.Drawing.Color.Silver
        Me.HorizontalLine6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HorizontalLine6.Location = New System.Drawing.Point(3, 32)
        Me.HorizontalLine6.Margin = New System.Windows.Forms.Padding(3, 9, 3, 9)
        Me.HorizontalLine6.MaximumSize = New System.Drawing.Size(0, 1)
        Me.HorizontalLine6.Name = "HorizontalLine6"
        Me.HorizontalLine6.Size = New System.Drawing.Size(862, 1)
        Me.HorizontalLine6.TabIndex = 4
        Me.HorizontalLine6.TabStop = false
        '
        'tpErrorsTests
        '
        Me.tpErrorsTests.BackColor = System.Drawing.Color.White
        Me.tpErrorsTests.Controls.Add(Me.htcErrorsTests)
        Me.tpErrorsTests.Location = New System.Drawing.Point(4, 22)
        Me.tpErrorsTests.Name = "tpErrorsTests"
        Me.tpErrorsTests.Size = New System.Drawing.Size(876, 300)
        Me.tpErrorsTests.TabIndex = 2
        Me.tpErrorsTests.Text = "tpErrorsTests"
        '
        'htcErrorsTests
        '
        Me.htcErrorsTests.Controls.Add(Me.tpAtaErrors)
        Me.htcErrorsTests.Controls.Add(Me.tpAtaTests)
        Me.htcErrorsTests.Controls.Add(Me.tpAtaRunTest)
        Me.htcErrorsTests.Controls.Add(Me.tpScsiErrors)
        Me.htcErrorsTests.Controls.Add(Me.tpScsiTests)
        Me.htcErrorsTests.Controls.Add(Me.tpScsiRunTest)
        Me.htcErrorsTests.Dock = System.Windows.Forms.DockStyle.Fill
        Me.htcErrorsTests.Location = New System.Drawing.Point(0, 0)
        Me.htcErrorsTests.Name = "htcErrorsTests"
        Me.htcErrorsTests.SelectedIndex = 0
        Me.htcErrorsTests.Size = New System.Drawing.Size(876, 300)
        Me.htcErrorsTests.TabIndex = 0
        Me.htcErrorsTests.TabStop = false
        '
        'tpAtaErrors
        '
        Me.tpAtaErrors.AutoScroll = true
        Me.tpAtaErrors.BackColor = System.Drawing.Color.White
        Me.tpAtaErrors.Controls.Add(Me.tlpAtaErrorsContent)
        Me.tpAtaErrors.Location = New System.Drawing.Point(4, 22)
        Me.tpAtaErrors.Name = "tpAtaErrors"
        Me.tpAtaErrors.Size = New System.Drawing.Size(868, 274)
        Me.tpAtaErrors.TabIndex = 0
        Me.tpAtaErrors.Text = "tpAtaErrors"
        '
        'tlpAtaErrorsContent
        '
        Me.tlpAtaErrorsContent.AutoSize = true
        Me.tlpAtaErrorsContent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlpAtaErrorsContent.ColumnCount = 1
        Me.tlpAtaErrorsContent.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tlpAtaErrorsContent.Controls.Add(Me.lblErrLogVer, 0, 2)
        Me.tlpAtaErrorsContent.Controls.Add(Me.flwError, 0, 3)
        Me.tlpAtaErrorsContent.Controls.Add(Me.lblAdminErrors, 0, 0)
        Me.tlpAtaErrorsContent.Controls.Add(Me.HorizontalLine7, 0, 1)
        Me.tlpAtaErrorsContent.Controls.Add(Me.tabErrors, 0, 4)
        Me.tlpAtaErrorsContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpAtaErrorsContent.Location = New System.Drawing.Point(0, 0)
        Me.tlpAtaErrorsContent.Name = "tlpAtaErrorsContent"
        Me.tlpAtaErrorsContent.RowCount = 5
        Me.tlpAtaErrorsContent.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpAtaErrorsContent.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpAtaErrorsContent.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpAtaErrorsContent.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpAtaErrorsContent.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tlpAtaErrorsContent.Size = New System.Drawing.Size(868, 274)
        Me.tlpAtaErrorsContent.TabIndex = 24
        '
        'lblErrLogVer
        '
        Me.lblErrLogVer.AutoSize = true
        Me.lblErrLogVer.ForeColor = System.Drawing.Color.Black
        Me.lblErrLogVer.Location = New System.Drawing.Point(3, 42)
        Me.lblErrLogVer.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.lblErrLogVer.Name = "lblErrLogVer"
        Me.lblErrLogVer.Size = New System.Drawing.Size(64, 13)
        Me.lblErrLogVer.TabIndex = 20
        Me.lblErrLogVer.Text = "lblErrLogVer"
        '
        'flwError
        '
        Me.flwError.AutoSize = true
        Me.flwError.Controls.Add(Me.flwErrorLog)
        Me.flwError.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flwError.Location = New System.Drawing.Point(0, 58)
        Me.flwError.Margin = New System.Windows.Forms.Padding(0)
        Me.flwError.Name = "flwError"
        Me.flwError.Size = New System.Drawing.Size(868, 23)
        Me.flwError.TabIndex = 1
        '
        'flwErrorLog
        '
        Me.flwErrorLog.AutoSize = true
        Me.flwErrorLog.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.flwErrorLog.Controls.Add(Me.lblErrorLog)
        Me.flwErrorLog.Controls.Add(Me.optError1)
        Me.flwErrorLog.Controls.Add(Me.optError2)
        Me.flwErrorLog.Controls.Add(Me.optError3)
        Me.flwErrorLog.Controls.Add(Me.optError4)
        Me.flwErrorLog.Controls.Add(Me.optError5)
        Me.flwError.SetFlowBreak(Me.flwErrorLog, true)
        Me.flwErrorLog.Location = New System.Drawing.Point(0, 0)
        Me.flwErrorLog.Margin = New System.Windows.Forms.Padding(0)
        Me.flwErrorLog.Name = "flwErrorLog"
        Me.flwErrorLog.Size = New System.Drawing.Size(176, 23)
        Me.flwErrorLog.TabIndex = 0
        '
        'lblErrorLog
        '
        Me.lblErrorLog.AutoSize = true
        Me.lblErrorLog.ForeColor = System.Drawing.Color.Black
        Me.lblErrorLog.Location = New System.Drawing.Point(3, 0)
        Me.lblErrorLog.Margin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.lblErrorLog.MinimumSize = New System.Drawing.Size(0, 23)
        Me.lblErrorLog.Name = "lblErrorLog"
        Me.lblErrorLog.Size = New System.Drawing.Size(58, 23)
        Me.lblErrorLog.TabIndex = 0
        Me.lblErrorLog.Text = "lblErrorLog"
        Me.lblErrorLog.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'optError1
        '
        Me.optError1.Appearance = System.Windows.Forms.Appearance.Button
        Me.optError1.AutoSize = true
        Me.optError1.Location = New System.Drawing.Point(61, 0)
        Me.optError1.Margin = New System.Windows.Forms.Padding(0)
        Me.optError1.Name = "optError1"
        Me.optError1.Size = New System.Drawing.Size(23, 23)
        Me.optError1.TabIndex = 0
        Me.optError1.TabStop = true
        Me.optError1.Text = "5"
        Me.optError1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.optError1.UseVisualStyleBackColor = true
        '
        'optError2
        '
        Me.optError2.Appearance = System.Windows.Forms.Appearance.Button
        Me.optError2.AutoSize = true
        Me.optError2.Location = New System.Drawing.Point(84, 0)
        Me.optError2.Margin = New System.Windows.Forms.Padding(0)
        Me.optError2.Name = "optError2"
        Me.optError2.Size = New System.Drawing.Size(23, 23)
        Me.optError2.TabIndex = 1
        Me.optError2.TabStop = true
        Me.optError2.Text = "4"
        Me.optError2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.optError2.UseVisualStyleBackColor = true
        '
        'optError3
        '
        Me.optError3.Appearance = System.Windows.Forms.Appearance.Button
        Me.optError3.AutoSize = true
        Me.optError3.Location = New System.Drawing.Point(107, 0)
        Me.optError3.Margin = New System.Windows.Forms.Padding(0)
        Me.optError3.Name = "optError3"
        Me.optError3.Size = New System.Drawing.Size(23, 23)
        Me.optError3.TabIndex = 2
        Me.optError3.TabStop = true
        Me.optError3.Text = "3"
        Me.optError3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.optError3.UseVisualStyleBackColor = true
        '
        'optError4
        '
        Me.optError4.Appearance = System.Windows.Forms.Appearance.Button
        Me.optError4.AutoSize = true
        Me.optError4.Location = New System.Drawing.Point(130, 0)
        Me.optError4.Margin = New System.Windows.Forms.Padding(0)
        Me.optError4.Name = "optError4"
        Me.optError4.Size = New System.Drawing.Size(23, 23)
        Me.optError4.TabIndex = 3
        Me.optError4.TabStop = true
        Me.optError4.Text = "2"
        Me.optError4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.optError4.UseVisualStyleBackColor = true
        '
        'optError5
        '
        Me.optError5.Appearance = System.Windows.Forms.Appearance.Button
        Me.optError5.AutoSize = true
        Me.optError5.Location = New System.Drawing.Point(153, 0)
        Me.optError5.Margin = New System.Windows.Forms.Padding(0)
        Me.optError5.Name = "optError5"
        Me.optError5.Size = New System.Drawing.Size(23, 23)
        Me.optError5.TabIndex = 4
        Me.optError5.TabStop = true
        Me.optError5.Text = "1"
        Me.optError5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.optError5.UseVisualStyleBackColor = true
        '
        'lblAdminErrors
        '
        Me.lblAdminErrors.AutoSize = true
        Me.lblAdminErrors.ForeColor = System.Drawing.Color.DimGray
        Me.lblAdminErrors.Location = New System.Drawing.Point(3, 7)
        Me.lblAdminErrors.Margin = New System.Windows.Forms.Padding(3, 7, 3, 3)
        Me.lblAdminErrors.Name = "lblAdminErrors"
        Me.lblAdminErrors.Size = New System.Drawing.Size(75, 13)
        Me.lblAdminErrors.TabIndex = 22
        Me.lblAdminErrors.Text = "lblAdminErrors"
        '
        'HorizontalLine7
        '
        Me.HorizontalLine7.BackColor = System.Drawing.Color.Silver
        Me.HorizontalLine7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HorizontalLine7.Location = New System.Drawing.Point(3, 32)
        Me.HorizontalLine7.Margin = New System.Windows.Forms.Padding(3, 9, 3, 9)
        Me.HorizontalLine7.MaximumSize = New System.Drawing.Size(0, 1)
        Me.HorizontalLine7.Name = "HorizontalLine7"
        Me.HorizontalLine7.Size = New System.Drawing.Size(862, 1)
        Me.HorizontalLine7.TabIndex = 21
        Me.HorizontalLine7.TabStop = false
        '
        'tabErrors
        '
        Me.tabErrors.Controls.Add(Me.tpErrorDescription)
        Me.tabErrors.Controls.Add(Me.tpErrorDetail)
        Me.tabErrors.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabErrors.Location = New System.Drawing.Point(3, 84)
        Me.tabErrors.Name = "tabErrors"
        Me.tabErrors.SelectedIndex = 0
        Me.tabErrors.Size = New System.Drawing.Size(862, 187)
        Me.tabErrors.TabIndex = 23
        '
        'tpErrorDescription
        '
        Me.tpErrorDescription.Controls.Add(Me.tlpErrorDescription)
        Me.tpErrorDescription.Location = New System.Drawing.Point(4, 22)
        Me.tpErrorDescription.Name = "tpErrorDescription"
        Me.tpErrorDescription.Size = New System.Drawing.Size(854, 161)
        Me.tpErrorDescription.TabIndex = 0
        Me.tpErrorDescription.Text = "tpErrorDescription"
        Me.tpErrorDescription.UseVisualStyleBackColor = true
        '
        'tlpErrorDescription
        '
        Me.tlpErrorDescription.AutoSize = true
        Me.tlpErrorDescription.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlpErrorDescription.ColumnCount = 2
        Me.tlpErrorDescription.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpErrorDescription.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tlpErrorDescription.Controls.Add(Me.lblErrorNumber, 0, 0)
        Me.tlpErrorDescription.Controls.Add(Me.lblErrorNumberValue, 1, 0)
        Me.tlpErrorDescription.Controls.Add(Me.lblErrorSectorsValue, 1, 4)
        Me.tlpErrorDescription.Controls.Add(Me.lblErrorDescriptionValue, 1, 3)
        Me.tlpErrorDescription.Controls.Add(Me.lblErrorElapsedValue, 1, 1)
        Me.tlpErrorDescription.Controls.Add(Me.lblErrorDescription, 0, 3)
        Me.tlpErrorDescription.Controls.Add(Me.lblErrorElapsed, 0, 1)
        Me.tlpErrorDescription.Controls.Add(Me.lblErrorLba, 0, 5)
        Me.tlpErrorDescription.Controls.Add(Me.lblErrorSectors, 0, 4)
        Me.tlpErrorDescription.Controls.Add(Me.lblErrorLbaValue, 1, 5)
        Me.tlpErrorDescription.Controls.Add(Me.lblErrorStatus, 0, 2)
        Me.tlpErrorDescription.Controls.Add(Me.lblErrorStatusValue, 1, 2)
        Me.tlpErrorDescription.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpErrorDescription.Location = New System.Drawing.Point(0, 0)
        Me.tlpErrorDescription.MaximumSize = New System.Drawing.Size(800, 0)
        Me.tlpErrorDescription.Name = "tlpErrorDescription"
        Me.tlpErrorDescription.RowCount = 7
        Me.tlpErrorDescription.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpErrorDescription.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpErrorDescription.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpErrorDescription.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpErrorDescription.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpErrorDescription.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpErrorDescription.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpErrorDescription.Size = New System.Drawing.Size(800, 114)
        Me.tlpErrorDescription.TabIndex = 3
        '
        'lblErrorNumber
        '
        Me.lblErrorNumber.AutoSize = true
        Me.lblErrorNumber.ForeColor = System.Drawing.Color.DimGray
        Me.lblErrorNumber.Location = New System.Drawing.Point(0, 3)
        Me.lblErrorNumber.Margin = New System.Windows.Forms.Padding(0, 3, 3, 3)
        Me.lblErrorNumber.Name = "lblErrorNumber"
        Me.lblErrorNumber.Size = New System.Drawing.Size(78, 13)
        Me.lblErrorNumber.TabIndex = 50
        Me.lblErrorNumber.Tag = "Grayed"
        Me.lblErrorNumber.Text = "lblErrorNumber"
        '
        'lblErrorNumberValue
        '
        Me.lblErrorNumberValue.AutoSize = true
        Me.lblErrorNumberValue.ForeColor = System.Drawing.Color.Black
        Me.lblErrorNumberValue.Location = New System.Drawing.Point(100, 3)
        Me.lblErrorNumberValue.Margin = New System.Windows.Forms.Padding(3)
        Me.lblErrorNumberValue.Name = "lblErrorNumberValue"
        Me.lblErrorNumberValue.Size = New System.Drawing.Size(104, 13)
        Me.lblErrorNumberValue.TabIndex = 0
        Me.lblErrorNumberValue.Text = "lblErrorNumberValue"
        '
        'lblErrorSectorsValue
        '
        Me.lblErrorSectorsValue.AutoSize = true
        Me.lblErrorSectorsValue.ForeColor = System.Drawing.Color.Black
        Me.lblErrorSectorsValue.Location = New System.Drawing.Point(100, 79)
        Me.lblErrorSectorsValue.Margin = New System.Windows.Forms.Padding(3)
        Me.lblErrorSectorsValue.Name = "lblErrorSectorsValue"
        Me.lblErrorSectorsValue.Size = New System.Drawing.Size(103, 13)
        Me.lblErrorSectorsValue.TabIndex = 9
        Me.lblErrorSectorsValue.Text = "lblErrorSectorsValue"
        '
        'lblErrorDescriptionValue
        '
        Me.lblErrorDescriptionValue.AutoSize = true
        Me.lblErrorDescriptionValue.ForeColor = System.Drawing.Color.Black
        Me.lblErrorDescriptionValue.Location = New System.Drawing.Point(100, 60)
        Me.lblErrorDescriptionValue.Margin = New System.Windows.Forms.Padding(3)
        Me.lblErrorDescriptionValue.Name = "lblErrorDescriptionValue"
        Me.lblErrorDescriptionValue.Size = New System.Drawing.Size(120, 13)
        Me.lblErrorDescriptionValue.TabIndex = 6
        Me.lblErrorDescriptionValue.Text = "lblErrorDescriptionValue"
        '
        'lblErrorElapsedValue
        '
        Me.lblErrorElapsedValue.AutoSize = true
        Me.lblErrorElapsedValue.ForeColor = System.Drawing.Color.Black
        Me.lblErrorElapsedValue.Location = New System.Drawing.Point(100, 22)
        Me.lblErrorElapsedValue.Margin = New System.Windows.Forms.Padding(3)
        Me.lblErrorElapsedValue.Name = "lblErrorElapsedValue"
        Me.lblErrorElapsedValue.Size = New System.Drawing.Size(104, 13)
        Me.lblErrorElapsedValue.TabIndex = 37
        Me.lblErrorElapsedValue.Text = "lblErrorElapsedValue"
        '
        'lblErrorDescription
        '
        Me.lblErrorDescription.AutoSize = true
        Me.lblErrorDescription.ForeColor = System.Drawing.Color.DimGray
        Me.lblErrorDescription.Location = New System.Drawing.Point(0, 60)
        Me.lblErrorDescription.Margin = New System.Windows.Forms.Padding(0, 3, 3, 3)
        Me.lblErrorDescription.Name = "lblErrorDescription"
        Me.lblErrorDescription.Size = New System.Drawing.Size(94, 13)
        Me.lblErrorDescription.TabIndex = 1
        Me.lblErrorDescription.Tag = "Grayed"
        Me.lblErrorDescription.Text = "lblErrorDescription"
        '
        'lblErrorElapsed
        '
        Me.lblErrorElapsed.AutoSize = true
        Me.lblErrorElapsed.ForeColor = System.Drawing.Color.DimGray
        Me.lblErrorElapsed.Location = New System.Drawing.Point(0, 22)
        Me.lblErrorElapsed.Margin = New System.Windows.Forms.Padding(0, 3, 3, 3)
        Me.lblErrorElapsed.Name = "lblErrorElapsed"
        Me.lblErrorElapsed.Size = New System.Drawing.Size(78, 13)
        Me.lblErrorElapsed.TabIndex = 8
        Me.lblErrorElapsed.Tag = "Grayed"
        Me.lblErrorElapsed.Text = "lblErrorElapsed"
        '
        'lblErrorLba
        '
        Me.lblErrorLba.AutoSize = true
        Me.lblErrorLba.ForeColor = System.Drawing.Color.DimGray
        Me.lblErrorLba.Location = New System.Drawing.Point(0, 98)
        Me.lblErrorLba.Margin = New System.Windows.Forms.Padding(0, 3, 3, 3)
        Me.lblErrorLba.Name = "lblErrorLba"
        Me.lblErrorLba.Size = New System.Drawing.Size(58, 13)
        Me.lblErrorLba.TabIndex = 38
        Me.lblErrorLba.Tag = "Grayed"
        Me.lblErrorLba.Text = "lblErrorLba"
        '
        'lblErrorSectors
        '
        Me.lblErrorSectors.AutoSize = true
        Me.lblErrorSectors.ForeColor = System.Drawing.Color.DimGray
        Me.lblErrorSectors.Location = New System.Drawing.Point(0, 79)
        Me.lblErrorSectors.Margin = New System.Windows.Forms.Padding(0, 3, 3, 3)
        Me.lblErrorSectors.Name = "lblErrorSectors"
        Me.lblErrorSectors.Size = New System.Drawing.Size(77, 13)
        Me.lblErrorSectors.TabIndex = 11
        Me.lblErrorSectors.Tag = "Grayed"
        Me.lblErrorSectors.Text = "lblErrorSectors"
        '
        'lblErrorLbaValue
        '
        Me.lblErrorLbaValue.AutoSize = true
        Me.lblErrorLbaValue.ForeColor = System.Drawing.Color.Black
        Me.lblErrorLbaValue.Location = New System.Drawing.Point(100, 98)
        Me.lblErrorLbaValue.Margin = New System.Windows.Forms.Padding(3)
        Me.lblErrorLbaValue.Name = "lblErrorLbaValue"
        Me.lblErrorLbaValue.Size = New System.Drawing.Size(84, 13)
        Me.lblErrorLbaValue.TabIndex = 5
        Me.lblErrorLbaValue.Text = "lblErrorLbaValue"
        '
        'lblErrorStatus
        '
        Me.lblErrorStatus.AutoSize = true
        Me.lblErrorStatus.ForeColor = System.Drawing.Color.DimGray
        Me.lblErrorStatus.Location = New System.Drawing.Point(0, 41)
        Me.lblErrorStatus.Margin = New System.Windows.Forms.Padding(0, 3, 3, 3)
        Me.lblErrorStatus.Name = "lblErrorStatus"
        Me.lblErrorStatus.Size = New System.Drawing.Size(72, 13)
        Me.lblErrorStatus.TabIndex = 51
        Me.lblErrorStatus.Tag = "Grayed"
        Me.lblErrorStatus.Text = "lblErrorStatus"
        '
        'lblErrorStatusValue
        '
        Me.lblErrorStatusValue.AutoSize = true
        Me.lblErrorStatusValue.ForeColor = System.Drawing.Color.Black
        Me.lblErrorStatusValue.Location = New System.Drawing.Point(100, 41)
        Me.lblErrorStatusValue.Margin = New System.Windows.Forms.Padding(3)
        Me.lblErrorStatusValue.Name = "lblErrorStatusValue"
        Me.lblErrorStatusValue.Size = New System.Drawing.Size(98, 13)
        Me.lblErrorStatusValue.TabIndex = 52
        Me.lblErrorStatusValue.Text = "lblErrorStatusValue"
        '
        'tpErrorDetail
        '
        Me.tpErrorDetail.AutoScroll = true
        Me.tpErrorDetail.Controls.Add(Me.tlpErrorDetail)
        Me.tpErrorDetail.Location = New System.Drawing.Point(4, 22)
        Me.tpErrorDetail.Name = "tpErrorDetail"
        Me.tpErrorDetail.Size = New System.Drawing.Size(854, 161)
        Me.tpErrorDetail.TabIndex = 1
        Me.tpErrorDetail.Text = "tpErrorDetail"
        Me.tpErrorDetail.UseVisualStyleBackColor = true
        '
        'tlpErrorDetail
        '
        Me.tlpErrorDetail.AutoSize = true
        Me.tlpErrorDetail.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlpErrorDetail.ColumnCount = 1
        Me.tlpErrorDetail.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tlpErrorDetail.Controls.Add(Me.lblPowerOn, 0, 0)
        Me.tlpErrorDetail.Controls.Add(Me.cpCommands, 0, 5)
        Me.tlpErrorDetail.Controls.Add(Me.lblRegisters, 0, 2)
        Me.tlpErrorDetail.Controls.Add(Me.lblDeviceStatus, 0, 1)
        Me.tlpErrorDetail.Controls.Add(Me.lblCommands, 0, 4)
        Me.tlpErrorDetail.Controls.Add(Me.rpRegisters, 0, 3)
        Me.tlpErrorDetail.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpErrorDetail.Location = New System.Drawing.Point(0, 0)
        Me.tlpErrorDetail.Name = "tlpErrorDetail"
        Me.tlpErrorDetail.RowCount = 6
        Me.tlpErrorDetail.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpErrorDetail.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpErrorDetail.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpErrorDetail.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpErrorDetail.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpErrorDetail.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpErrorDetail.Size = New System.Drawing.Size(837, 212)
        Me.tlpErrorDetail.TabIndex = 0
        '
        'lblPowerOn
        '
        Me.lblPowerOn.AutoSize = true
        Me.lblPowerOn.ForeColor = System.Drawing.Color.Black
        Me.lblPowerOn.Location = New System.Drawing.Point(3, 5)
        Me.lblPowerOn.Margin = New System.Windows.Forms.Padding(3, 5, 3, 0)
        Me.lblPowerOn.Name = "lblPowerOn"
        Me.lblPowerOn.Size = New System.Drawing.Size(61, 13)
        Me.lblPowerOn.TabIndex = 0
        Me.lblPowerOn.Text = "lblPowerOn"
        '
        'cpCommands
        '
        Me.cpCommands.AutoSize = true
        Me.cpCommands.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.cpCommands.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cpCommands.Location = New System.Drawing.Point(3, 109)
        Me.cpCommands.MinimumSize = New System.Drawing.Size(554, 0)
        Me.cpCommands.Name = "cpCommands"
        Me.cpCommands.Size = New System.Drawing.Size(831, 100)
        Me.cpCommands.TabIndex = 5
        Me.cpCommands.TabStop = false
        '
        'lblRegisters
        '
        Me.lblRegisters.AutoSize = true
        Me.lblRegisters.ForeColor = System.Drawing.Color.Black
        Me.lblRegisters.Location = New System.Drawing.Point(3, 39)
        Me.lblRegisters.Margin = New System.Windows.Forms.Padding(3, 5, 3, 0)
        Me.lblRegisters.Name = "lblRegisters"
        Me.lblRegisters.Size = New System.Drawing.Size(62, 13)
        Me.lblRegisters.TabIndex = 2
        Me.lblRegisters.Text = "lblRegisters"
        '
        'lblDeviceStatus
        '
        Me.lblDeviceStatus.AutoSize = true
        Me.lblDeviceStatus.ForeColor = System.Drawing.Color.Black
        Me.lblDeviceStatus.Location = New System.Drawing.Point(3, 21)
        Me.lblDeviceStatus.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.lblDeviceStatus.Name = "lblDeviceStatus"
        Me.lblDeviceStatus.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.lblDeviceStatus.Size = New System.Drawing.Size(90, 13)
        Me.lblDeviceStatus.TabIndex = 1
        Me.lblDeviceStatus.Text = "lblDeviceStatus"
        '
        'lblCommands
        '
        Me.lblCommands.AutoSize = true
        Me.lblCommands.Location = New System.Drawing.Point(3, 93)
        Me.lblCommands.Margin = New System.Windows.Forms.Padding(3, 5, 3, 0)
        Me.lblCommands.Name = "lblCommands"
        Me.lblCommands.Size = New System.Drawing.Size(69, 13)
        Me.lblCommands.TabIndex = 4
        Me.lblCommands.Text = "lblCommands"
        '
        'rpRegisters
        '
        Me.rpRegisters.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rpRegisters.Location = New System.Drawing.Point(3, 55)
        Me.rpRegisters.MinimumSize = New System.Drawing.Size(554, 0)
        Me.rpRegisters.Name = "rpRegisters"
        Me.rpRegisters.Size = New System.Drawing.Size(831, 30)
        Me.rpRegisters.TabIndex = 3
        Me.rpRegisters.TabStop = false
        '
        'tpAtaTests
        '
        Me.tpAtaTests.BackColor = System.Drawing.Color.White
        Me.tpAtaTests.Controls.Add(Me.tlpTestsContent)
        Me.tpAtaTests.Location = New System.Drawing.Point(4, 22)
        Me.tpAtaTests.Name = "tpAtaTests"
        Me.tpAtaTests.Size = New System.Drawing.Size(868, 274)
        Me.tpAtaTests.TabIndex = 1
        Me.tpAtaTests.Text = "tpAtaTests"
        '
        'tlpTestsContent
        '
        Me.tlpTestsContent.AutoSize = true
        Me.tlpTestsContent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlpTestsContent.ColumnCount = 1
        Me.tlpTestsContent.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tlpTestsContent.Controls.Add(Me.lblAdminTests, 0, 0)
        Me.tlpTestsContent.Controls.Add(Me.lvwSelective, 0, 5)
        Me.tlpTestsContent.Controls.Add(Me.lvwSelfTest, 0, 3)
        Me.tlpTestsContent.Controls.Add(Me.tlpSelfTests, 0, 2)
        Me.tlpTestsContent.Controls.Add(Me.HorizontalLine1, 0, 1)
        Me.tlpTestsContent.Controls.Add(Me.tlpSelective, 0, 4)
        Me.tlpTestsContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpTestsContent.Location = New System.Drawing.Point(0, 0)
        Me.tlpTestsContent.Name = "tlpTestsContent"
        Me.tlpTestsContent.RowCount = 6
        Me.tlpTestsContent.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpTestsContent.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpTestsContent.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpTestsContent.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.tlpTestsContent.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpTestsContent.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.tlpTestsContent.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20!))
        Me.tlpTestsContent.Size = New System.Drawing.Size(868, 274)
        Me.tlpTestsContent.TabIndex = 24
        '
        'lblAdminTests
        '
        Me.lblAdminTests.AutoSize = true
        Me.lblAdminTests.ForeColor = System.Drawing.Color.DimGray
        Me.lblAdminTests.Location = New System.Drawing.Point(3, 7)
        Me.lblAdminTests.Margin = New System.Windows.Forms.Padding(3, 7, 3, 3)
        Me.lblAdminTests.Name = "lblAdminTests"
        Me.lblAdminTests.Size = New System.Drawing.Size(72, 13)
        Me.lblAdminTests.TabIndex = 8
        Me.lblAdminTests.Text = "lblAdminTests"
        '
        'lvwSelective
        '
        Me.lvwSelective.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chSpan, Me.chLbaMin, Me.chLbaMax, Me.chCurTestStatus})
        Me.lvwSelective.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvwSelective.FullRowSelect = true
        Me.lvwSelective.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvwSelective.Location = New System.Drawing.Point(3, 175)
        Me.lvwSelective.Name = "lvwSelective"
        Me.lvwSelective.Size = New System.Drawing.Size(862, 96)
        Me.lvwSelective.TabIndex = 2
        Me.lvwSelective.UseCompatibleStateImageBehavior = false
        Me.lvwSelective.View = System.Windows.Forms.View.Details
        '
        'chSpan
        '
        Me.chSpan.Text = "Span"
        '
        'chLbaMin
        '
        Me.chLbaMin.Text = "LBA Min"
        Me.chLbaMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'chLbaMax
        '
        Me.chLbaMax.Text = "LBA Max"
        Me.chLbaMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'chCurTestStatus
        '
        Me.chCurTestStatus.Text = "Current test status"
        Me.chCurTestStatus.Width = 114
        '
        'lvwSelfTest
        '
        Me.lvwSelfTest.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chNum, Me.chTestType, Me.chTestStatus, Me.chRemaining, Me.chAge, Me.chFirstError})
        Me.lvwSelfTest.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvwSelfTest.FullRowSelect = true
        Me.lvwSelfTest.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvwSelfTest.Location = New System.Drawing.Point(3, 58)
        Me.lvwSelfTest.Name = "lvwSelfTest"
        Me.lvwSelfTest.Size = New System.Drawing.Size(862, 95)
        Me.lvwSelfTest.TabIndex = 1
        Me.lvwSelfTest.UseCompatibleStateImageBehavior = false
        Me.lvwSelfTest.View = System.Windows.Forms.View.Details
        '
        'chNum
        '
        Me.chNum.Text = "Num"
        '
        'chTestType
        '
        Me.chTestType.Text = "Test Type"
        '
        'chTestStatus
        '
        Me.chTestStatus.Text = "Status"
        Me.chTestStatus.Width = 61
        '
        'chRemaining
        '
        Me.chRemaining.Text = "Remaining"
        Me.chRemaining.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.chRemaining.Width = 72
        '
        'chAge
        '
        Me.chAge.Text = "Device age"
        Me.chAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.chAge.Width = 73
        '
        'chFirstError
        '
        Me.chFirstError.Text = "LBA first error"
        Me.chFirstError.Width = 87
        '
        'tlpSelfTests
        '
        Me.tlpSelfTests.AutoSize = true
        Me.tlpSelfTests.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlpSelfTests.ColumnCount = 2
        Me.tlpSelfTests.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpSelfTests.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tlpSelfTests.Controls.Add(Me.lblNoSelfTests, 1, 0)
        Me.tlpSelfTests.Controls.Add(Me.lblSelfTests, 0, 0)
        Me.tlpSelfTests.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpSelfTests.Location = New System.Drawing.Point(0, 42)
        Me.tlpSelfTests.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpSelfTests.Name = "tlpSelfTests"
        Me.tlpSelfTests.RowCount = 1
        Me.tlpSelfTests.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tlpSelfTests.Size = New System.Drawing.Size(868, 13)
        Me.tlpSelfTests.TabIndex = 9
        '
        'lblNoSelfTests
        '
        Me.lblNoSelfTests.AutoSize = true
        Me.lblNoSelfTests.ForeColor = System.Drawing.Color.Black
        Me.lblNoSelfTests.Location = New System.Drawing.Point(67, 0)
        Me.lblNoSelfTests.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.lblNoSelfTests.Name = "lblNoSelfTests"
        Me.lblNoSelfTests.Size = New System.Drawing.Size(74, 13)
        Me.lblNoSelfTests.TabIndex = 6
        Me.lblNoSelfTests.Text = "lblNoSelfTests"
        '
        'lblSelfTests
        '
        Me.lblSelfTests.AutoSize = true
        Me.lblSelfTests.ForeColor = System.Drawing.Color.DimGray
        Me.lblSelfTests.Location = New System.Drawing.Point(3, 0)
        Me.lblSelfTests.Name = "lblSelfTests"
        Me.lblSelfTests.Size = New System.Drawing.Size(61, 13)
        Me.lblSelfTests.TabIndex = 7
        Me.lblSelfTests.Text = "lblSelfTests"
        '
        'HorizontalLine1
        '
        Me.HorizontalLine1.BackColor = System.Drawing.Color.Silver
        Me.HorizontalLine1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HorizontalLine1.Location = New System.Drawing.Point(3, 32)
        Me.HorizontalLine1.Margin = New System.Windows.Forms.Padding(3, 9, 3, 9)
        Me.HorizontalLine1.MaximumSize = New System.Drawing.Size(0, 1)
        Me.HorizontalLine1.Name = "HorizontalLine1"
        Me.HorizontalLine1.Size = New System.Drawing.Size(862, 1)
        Me.HorizontalLine1.TabIndex = 10
        Me.HorizontalLine1.TabStop = false
        '
        'tlpSelective
        '
        Me.tlpSelective.AutoSize = true
        Me.tlpSelective.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlpSelective.ColumnCount = 2
        Me.tlpSelective.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpSelective.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tlpSelective.Controls.Add(Me.lblNoSelective, 1, 0)
        Me.tlpSelective.Controls.Add(Me.lblSelective, 0, 0)
        Me.tlpSelective.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpSelective.Location = New System.Drawing.Point(0, 159)
        Me.tlpSelective.Margin = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.tlpSelective.Name = "tlpSelective"
        Me.tlpSelective.RowCount = 1
        Me.tlpSelective.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tlpSelective.Size = New System.Drawing.Size(868, 13)
        Me.tlpSelective.TabIndex = 11
        '
        'lblNoSelective
        '
        Me.lblNoSelective.AutoSize = true
        Me.lblNoSelective.ForeColor = System.Drawing.Color.Black
        Me.lblNoSelective.Location = New System.Drawing.Point(66, 0)
        Me.lblNoSelective.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.lblNoSelective.Name = "lblNoSelective"
        Me.lblNoSelective.Size = New System.Drawing.Size(73, 13)
        Me.lblNoSelective.TabIndex = 7
        Me.lblNoSelective.Text = "lblNoSelective"
        '
        'lblSelective
        '
        Me.lblSelective.AutoSize = true
        Me.lblSelective.ForeColor = System.Drawing.Color.DimGray
        Me.lblSelective.Location = New System.Drawing.Point(3, 0)
        Me.lblSelective.Name = "lblSelective"
        Me.lblSelective.Size = New System.Drawing.Size(60, 13)
        Me.lblSelective.TabIndex = 8
        Me.lblSelective.Text = "lblSelective"
        '
        'tpAtaRunTest
        '
        Me.tpAtaRunTest.BackColor = System.Drawing.Color.White
        Me.tpAtaRunTest.Controls.Add(Me.tlpAtaTestContent)
        Me.tpAtaRunTest.Location = New System.Drawing.Point(4, 22)
        Me.tpAtaRunTest.Name = "tpAtaRunTest"
        Me.tpAtaRunTest.Size = New System.Drawing.Size(868, 274)
        Me.tpAtaRunTest.TabIndex = 2
        Me.tpAtaRunTest.Text = "tpAtaRunTest"
        '
        'tlpAtaTestContent
        '
        Me.tlpAtaTestContent.AutoSize = true
        Me.tlpAtaTestContent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlpAtaTestContent.ColumnCount = 1
        Me.tlpAtaTestContent.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tlpAtaTestContent.Controls.Add(Me.tlpTestProgress, 0, 3)
        Me.tlpAtaTestContent.Controls.Add(Me.lblInfoTest, 0, 0)
        Me.tlpAtaTestContent.Controls.Add(Me.tlpTest, 0, 2)
        Me.tlpAtaTestContent.Controls.Add(Me.HorizontalLine8, 0, 1)
        Me.tlpAtaTestContent.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpAtaTestContent.Location = New System.Drawing.Point(0, 0)
        Me.tlpAtaTestContent.Name = "tlpAtaTestContent"
        Me.tlpAtaTestContent.RowCount = 4
        Me.tlpAtaTestContent.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpAtaTestContent.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20!))
        Me.tlpAtaTestContent.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpAtaTestContent.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpAtaTestContent.Size = New System.Drawing.Size(868, 166)
        Me.tlpAtaTestContent.TabIndex = 24
        '
        'tlpTestProgress
        '
        Me.tlpTestProgress.AutoSize = true
        Me.tlpTestProgress.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlpTestProgress.ColumnCount = 2
        Me.tlpTestProgress.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tlpTestProgress.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpTestProgress.Controls.Add(Me.btnStop, 1, 0)
        Me.tlpTestProgress.Controls.Add(Me.pnlProgress, 0, 0)
        Me.tlpTestProgress.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpTestProgress.Location = New System.Drawing.Point(3, 123)
        Me.tlpTestProgress.Name = "tlpTestProgress"
        Me.tlpTestProgress.RowCount = 1
        Me.tlpTestProgress.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpTestProgress.Size = New System.Drawing.Size(862, 40)
        Me.tlpTestProgress.TabIndex = 23
        '
        'btnStop
        '
        Me.btnStop.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnStop.Location = New System.Drawing.Point(779, 3)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(80, 23)
        Me.btnStop.TabIndex = 2
        Me.btnStop.Text = "btnStop"
        Me.btnStop.UseVisualStyleBackColor = true
        '
        'pnlProgress
        '
        Me.pnlProgress.AutoSize = true
        Me.pnlProgress.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pnlProgress.Controls.Add(Me.lblExtimatedEnd)
        Me.pnlProgress.Controls.Add(Me.prbTestProgress)
        Me.pnlProgress.Controls.Add(Me.lblProgress)
        Me.pnlProgress.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlProgress.Location = New System.Drawing.Point(0, 3)
        Me.pnlProgress.Margin = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.pnlProgress.Name = "pnlProgress"
        Me.pnlProgress.Size = New System.Drawing.Size(776, 37)
        Me.pnlProgress.TabIndex = 21
        '
        'lblExtimatedEnd
        '
        Me.lblExtimatedEnd.AutoSize = true
        Me.lblExtimatedEnd.ForeColor = System.Drawing.Color.Black
        Me.lblExtimatedEnd.Location = New System.Drawing.Point(0, 24)
        Me.lblExtimatedEnd.Name = "lblExtimatedEnd"
        Me.lblExtimatedEnd.Size = New System.Drawing.Size(83, 13)
        Me.lblExtimatedEnd.TabIndex = 2
        Me.lblExtimatedEnd.Text = "lblExtimatedEnd"
        '
        'prbTestProgress
        '
        Me.prbTestProgress.Location = New System.Drawing.Point(0, 0)
        Me.prbTestProgress.Name = "prbTestProgress"
        Me.prbTestProgress.Size = New System.Drawing.Size(288, 21)
        Me.prbTestProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.prbTestProgress.TabIndex = 16
        '
        'lblProgress
        '
        Me.lblProgress.AutoSize = true
        Me.lblProgress.ForeColor = System.Drawing.Color.Black
        Me.lblProgress.Location = New System.Drawing.Point(296, 0)
        Me.lblProgress.MinimumSize = New System.Drawing.Size(0, 21)
        Me.lblProgress.Name = "lblProgress"
        Me.lblProgress.Size = New System.Drawing.Size(59, 21)
        Me.lblProgress.TabIndex = 0
        Me.lblProgress.Text = "lblProgress"
        Me.lblProgress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblInfoTest
        '
        Me.lblInfoTest.AutoSize = true
        Me.lblInfoTest.ForeColor = System.Drawing.Color.DimGray
        Me.lblInfoTest.Location = New System.Drawing.Point(3, 7)
        Me.lblInfoTest.Margin = New System.Windows.Forms.Padding(3, 7, 3, 3)
        Me.lblInfoTest.Name = "lblInfoTest"
        Me.lblInfoTest.Size = New System.Drawing.Size(58, 13)
        Me.lblInfoTest.TabIndex = 3
        Me.lblInfoTest.Text = "lblInfoTest"
        '
        'tlpTest
        '
        Me.tlpTest.AutoSize = true
        Me.tlpTest.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlpTest.ColumnCount = 2
        Me.tlpTest.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tlpTest.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpTest.Controls.Add(Me.tlpTestDetails, 0, 2)
        Me.tlpTest.Controls.Add(Me.tlpSelectTest, 0, 0)
        Me.tlpTest.Controls.Add(Me.btnRun, 1, 0)
        Me.tlpTest.Controls.Add(Me.lblDuration, 0, 1)
        Me.tlpTest.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpTest.Location = New System.Drawing.Point(3, 46)
        Me.tlpTest.Name = "tlpTest"
        Me.tlpTest.RowCount = 3
        Me.tlpTest.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpTest.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpTest.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpTest.Size = New System.Drawing.Size(862, 71)
        Me.tlpTest.TabIndex = 23
        '
        'tlpTestDetails
        '
        Me.tlpTestDetails.AutoSize = true
        Me.tlpTestDetails.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlpTestDetails.BackColor = System.Drawing.Color.FromArgb(CType(CType(27,Byte),Integer), CType(CType(161,Byte),Integer), CType(CType(226,Byte),Integer))
        Me.tlpTestDetails.ColumnCount = 2
        Me.tlpTestDetails.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpTestDetails.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tlpTestDetails.Controls.Add(Me.lblTestInfo, 1, 0)
        Me.tlpTestDetails.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpTestDetails.Location = New System.Drawing.Point(15, 51)
        Me.tlpTestDetails.Margin = New System.Windows.Forms.Padding(15, 3, 3, 3)
        Me.tlpTestDetails.Name = "tlpTestDetails"
        Me.tlpTestDetails.RowCount = 1
        Me.tlpTestDetails.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tlpTestDetails.Size = New System.Drawing.Size(758, 17)
        Me.tlpTestDetails.TabIndex = 24
        '
        'lblTestInfo
        '
        Me.lblTestInfo.AutoSize = true
        Me.lblTestInfo.BackColor = System.Drawing.Color.White
        Me.lblTestInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTestInfo.ForeColor = System.Drawing.Color.DimGray
        Me.lblTestInfo.Location = New System.Drawing.Point(5, 0)
        Me.lblTestInfo.Margin = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.lblTestInfo.Name = "lblTestInfo"
        Me.lblTestInfo.Padding = New System.Windows.Forms.Padding(0, 2, 0, 2)
        Me.lblTestInfo.Size = New System.Drawing.Size(753, 17)
        Me.lblTestInfo.TabIndex = 1
        Me.lblTestInfo.Text = "lblTestInfo"
        Me.lblTestInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpSelectTest
        '
        Me.tlpSelectTest.AutoSize = true
        Me.tlpSelectTest.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlpSelectTest.ColumnCount = 2
        Me.tlpSelectTest.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpSelectTest.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tlpSelectTest.Controls.Add(Me.cboTest, 1, 0)
        Me.tlpSelectTest.Controls.Add(Me.lblSelectTest, 0, 0)
        Me.tlpSelectTest.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpSelectTest.Location = New System.Drawing.Point(0, 0)
        Me.tlpSelectTest.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.tlpSelectTest.Name = "tlpSelectTest"
        Me.tlpSelectTest.RowCount = 1
        Me.tlpSelectTest.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tlpSelectTest.Size = New System.Drawing.Size(773, 29)
        Me.tlpSelectTest.TabIndex = 24
        '
        'cboTest
        '
        Me.cboTest.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cboTest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTest.FormattingEnabled = true
        Me.cboTest.Location = New System.Drawing.Point(76, 4)
        Me.cboTest.MinimumSize = New System.Drawing.Size(300, 0)
        Me.cboTest.Name = "cboTest"
        Me.cboTest.Size = New System.Drawing.Size(300, 21)
        Me.cboTest.TabIndex = 0
        '
        'lblSelectTest
        '
        Me.lblSelectTest.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblSelectTest.AutoSize = true
        Me.lblSelectTest.ForeColor = System.Drawing.Color.Black
        Me.lblSelectTest.Location = New System.Drawing.Point(3, 9)
        Me.lblSelectTest.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.lblSelectTest.Name = "lblSelectTest"
        Me.lblSelectTest.Size = New System.Drawing.Size(67, 13)
        Me.lblSelectTest.TabIndex = 0
        Me.lblSelectTest.Text = "lblSelectTest"
        Me.lblSelectTest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnRun
        '
        Me.btnRun.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnRun.AutoSize = true
        Me.btnRun.Location = New System.Drawing.Point(779, 3)
        Me.btnRun.Name = "btnRun"
        Me.btnRun.Size = New System.Drawing.Size(80, 23)
        Me.btnRun.TabIndex = 1
        Me.btnRun.Text = "btnRun"
        Me.btnRun.UseVisualStyleBackColor = true
        '
        'lblDuration
        '
        Me.lblDuration.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblDuration.AutoSize = true
        Me.lblDuration.ForeColor = System.Drawing.Color.Black
        Me.lblDuration.Location = New System.Drawing.Point(3, 32)
        Me.lblDuration.Margin = New System.Windows.Forms.Padding(3)
        Me.lblDuration.Name = "lblDuration"
        Me.lblDuration.Size = New System.Drawing.Size(58, 13)
        Me.lblDuration.TabIndex = 2
        Me.lblDuration.Text = "lblDuration"
        Me.lblDuration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'HorizontalLine8
        '
        Me.HorizontalLine8.BackColor = System.Drawing.Color.Silver
        Me.HorizontalLine8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HorizontalLine8.Location = New System.Drawing.Point(3, 32)
        Me.HorizontalLine8.Margin = New System.Windows.Forms.Padding(3, 9, 3, 9)
        Me.HorizontalLine8.MaximumSize = New System.Drawing.Size(0, 1)
        Me.HorizontalLine8.Name = "HorizontalLine8"
        Me.HorizontalLine8.Size = New System.Drawing.Size(862, 1)
        Me.HorizontalLine8.TabIndex = 24
        Me.HorizontalLine8.TabStop = false
        '
        'tpScsiErrors
        '
        Me.tpScsiErrors.BackColor = System.Drawing.Color.White
        Me.tpScsiErrors.Controls.Add(Me.tlpScsiErrorsContent)
        Me.tpScsiErrors.Location = New System.Drawing.Point(4, 22)
        Me.tpScsiErrors.Name = "tpScsiErrors"
        Me.tpScsiErrors.Size = New System.Drawing.Size(868, 274)
        Me.tpScsiErrors.TabIndex = 3
        Me.tpScsiErrors.Text = "tpScsiErrors"
        '
        'tlpScsiErrorsContent
        '
        Me.tlpScsiErrorsContent.AutoSize = true
        Me.tlpScsiErrorsContent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlpScsiErrorsContent.ColumnCount = 1
        Me.tlpScsiErrorsContent.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tlpScsiErrorsContent.Controls.Add(Me.lblScsiNoErrors, 0, 0)
        Me.tlpScsiErrorsContent.Controls.Add(Me.tvwScsiErrors, 0, 1)
        Me.tlpScsiErrorsContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpScsiErrorsContent.Location = New System.Drawing.Point(0, 0)
        Me.tlpScsiErrorsContent.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpScsiErrorsContent.Name = "tlpScsiErrorsContent"
        Me.tlpScsiErrorsContent.RowCount = 2
        Me.tlpScsiErrorsContent.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpScsiErrorsContent.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tlpScsiErrorsContent.Size = New System.Drawing.Size(868, 274)
        Me.tlpScsiErrorsContent.TabIndex = 24
        '
        'lblScsiNoErrors
        '
        Me.lblScsiNoErrors.AutoSize = true
        Me.lblScsiNoErrors.ForeColor = System.Drawing.Color.Black
        Me.lblScsiNoErrors.Location = New System.Drawing.Point(3, 7)
        Me.lblScsiNoErrors.Margin = New System.Windows.Forms.Padding(3, 7, 3, 3)
        Me.lblScsiNoErrors.Name = "lblScsiNoErrors"
        Me.lblScsiNoErrors.Size = New System.Drawing.Size(77, 13)
        Me.lblScsiNoErrors.TabIndex = 1
        Me.lblScsiNoErrors.Text = "lblScsiNoErrors"
        '
        'tvwScsiErrors
        '
        Me.tvwScsiErrors.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tvwScsiErrors.Location = New System.Drawing.Point(3, 26)
        Me.tvwScsiErrors.Name = "tvwScsiErrors"
        Me.tvwScsiErrors.Size = New System.Drawing.Size(862, 245)
        Me.tvwScsiErrors.TabIndex = 0
        '
        'tpScsiTests
        '
        Me.tpScsiTests.BackColor = System.Drawing.Color.White
        Me.tpScsiTests.Controls.Add(Me.tlpScsiTestsContent)
        Me.tpScsiTests.Location = New System.Drawing.Point(4, 22)
        Me.tpScsiTests.Name = "tpScsiTests"
        Me.tpScsiTests.Size = New System.Drawing.Size(868, 274)
        Me.tpScsiTests.TabIndex = 4
        Me.tpScsiTests.Text = "tpScsiTests"
        '
        'tlpScsiTestsContent
        '
        Me.tlpScsiTestsContent.AutoSize = true
        Me.tlpScsiTestsContent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlpScsiTestsContent.ColumnCount = 1
        Me.tlpScsiTestsContent.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tlpScsiTestsContent.Controls.Add(Me.lblScsiTestCounter, 0, 0)
        Me.tlpScsiTestsContent.Controls.Add(Me.lvwScsiTests, 0, 1)
        Me.tlpScsiTestsContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpScsiTestsContent.Location = New System.Drawing.Point(0, 0)
        Me.tlpScsiTestsContent.Name = "tlpScsiTestsContent"
        Me.tlpScsiTestsContent.RowCount = 2
        Me.tlpScsiTestsContent.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpScsiTestsContent.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tlpScsiTestsContent.Size = New System.Drawing.Size(868, 274)
        Me.tlpScsiTestsContent.TabIndex = 24
        '
        'lblScsiTestCounter
        '
        Me.lblScsiTestCounter.AutoSize = true
        Me.lblScsiTestCounter.ForeColor = System.Drawing.Color.Black
        Me.lblScsiTestCounter.Location = New System.Drawing.Point(3, 7)
        Me.lblScsiTestCounter.Margin = New System.Windows.Forms.Padding(3, 7, 3, 3)
        Me.lblScsiTestCounter.Name = "lblScsiTestCounter"
        Me.lblScsiTestCounter.Size = New System.Drawing.Size(95, 13)
        Me.lblScsiTestCounter.TabIndex = 2
        Me.lblScsiTestCounter.Text = "lblScsiTestCounter"
        '
        'lvwScsiTests
        '
        Me.lvwScsiTests.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chScsiNum, Me.chScsiTest, Me.chScsiStatus, Me.chScsiSegment, Me.chScsiLifetime, Me.chScsiFirstErr, Me.chScsiSK, Me.chScsiASK, Me.chScsiASQ})
        Me.lvwScsiTests.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvwScsiTests.FullRowSelect = true
        Me.lvwScsiTests.Location = New System.Drawing.Point(3, 26)
        Me.lvwScsiTests.Name = "lvwScsiTests"
        Me.lvwScsiTests.Size = New System.Drawing.Size(862, 245)
        Me.lvwScsiTests.TabIndex = 3
        Me.lvwScsiTests.UseCompatibleStateImageBehavior = false
        Me.lvwScsiTests.View = System.Windows.Forms.View.Details
        '
        'chScsiNum
        '
        Me.chScsiNum.Text = "chScsiNum"
        '
        'chScsiTest
        '
        Me.chScsiTest.Text = "chScsiTest"
        '
        'chScsiStatus
        '
        Me.chScsiStatus.Text = "chScsiStatus"
        '
        'chScsiSegment
        '
        Me.chScsiSegment.Text = "chScsiSegment"
        Me.chScsiSegment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'chScsiLifetime
        '
        Me.chScsiLifetime.Text = "chScsiLifetime"
        Me.chScsiLifetime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'chScsiFirstErr
        '
        Me.chScsiFirstErr.Text = "chScsiFirstErr"
        Me.chScsiFirstErr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'chScsiSK
        '
        Me.chScsiSK.Text = "chScsiSK"
        Me.chScsiSK.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'chScsiASK
        '
        Me.chScsiASK.Text = "chScsiASK"
        Me.chScsiASK.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'chScsiASQ
        '
        Me.chScsiASQ.Text = "chScsiASQ"
        Me.chScsiASQ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tpScsiRunTest
        '
        Me.tpScsiRunTest.BackColor = System.Drawing.Color.White
        Me.tpScsiRunTest.Controls.Add(Me.tlpScsiTestContent)
        Me.tpScsiRunTest.Location = New System.Drawing.Point(4, 22)
        Me.tpScsiRunTest.Name = "tpScsiRunTest"
        Me.tpScsiRunTest.Size = New System.Drawing.Size(868, 274)
        Me.tpScsiRunTest.TabIndex = 5
        Me.tpScsiRunTest.Text = "tpScsiRunTest"
        '
        'tlpScsiTestContent
        '
        Me.tlpScsiTestContent.AutoSize = true
        Me.tlpScsiTestContent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlpScsiTestContent.ColumnCount = 1
        Me.tlpScsiTestContent.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tlpScsiTestContent.Controls.Add(Me.lblScsiInfoTest, 0, 0)
        Me.tlpScsiTestContent.Controls.Add(Me.tlpScsiTest, 0, 2)
        Me.tlpScsiTestContent.Controls.Add(Me.HorizontalLine14, 0, 1)
        Me.tlpScsiTestContent.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpScsiTestContent.Location = New System.Drawing.Point(0, 0)
        Me.tlpScsiTestContent.Name = "tlpScsiTestContent"
        Me.tlpScsiTestContent.RowCount = 3
        Me.tlpScsiTestContent.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpScsiTestContent.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20!))
        Me.tlpScsiTestContent.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpScsiTestContent.Size = New System.Drawing.Size(868, 115)
        Me.tlpScsiTestContent.TabIndex = 23
        '
        'lblScsiInfoTest
        '
        Me.lblScsiInfoTest.AutoSize = true
        Me.lblScsiInfoTest.ForeColor = System.Drawing.Color.DimGray
        Me.lblScsiInfoTest.Location = New System.Drawing.Point(3, 7)
        Me.lblScsiInfoTest.Margin = New System.Windows.Forms.Padding(3, 7, 3, 3)
        Me.lblScsiInfoTest.Name = "lblScsiInfoTest"
        Me.lblScsiInfoTest.Size = New System.Drawing.Size(76, 13)
        Me.lblScsiInfoTest.TabIndex = 4
        Me.lblScsiInfoTest.Text = "lblScsiInfoTest"
        '
        'tlpScsiTest
        '
        Me.tlpScsiTest.AutoSize = true
        Me.tlpScsiTest.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlpScsiTest.ColumnCount = 2
        Me.tlpScsiTest.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tlpScsiTest.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpScsiTest.Controls.Add(Me.pnlScsiTestRun, 0, 1)
        Me.tlpScsiTest.Controls.Add(Me.lblScsiTest, 0, 0)
        Me.tlpScsiTest.Controls.Add(Me.btnScsiRun, 1, 0)
        Me.tlpScsiTest.Controls.Add(Me.btnScsiStop, 1, 1)
        Me.tlpScsiTest.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpScsiTest.Location = New System.Drawing.Point(0, 43)
        Me.tlpScsiTest.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpScsiTest.Name = "tlpScsiTest"
        Me.tlpScsiTest.RowCount = 2
        Me.tlpScsiTest.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpScsiTest.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpScsiTest.Size = New System.Drawing.Size(868, 72)
        Me.tlpScsiTest.TabIndex = 22
        '
        'pnlScsiTestRun
        '
        Me.pnlScsiTestRun.AutoSize = true
        Me.pnlScsiTestRun.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pnlScsiTestRun.Controls.Add(Me.lblScsiExtimatedEnd)
        Me.pnlScsiTestRun.Controls.Add(Me.prbScsiTestProgress)
        Me.pnlScsiTestRun.Controls.Add(Me.lblScsiProgress)
        Me.pnlScsiTestRun.Location = New System.Drawing.Point(3, 32)
        Me.pnlScsiTestRun.Name = "pnlScsiTestRun"
        Me.pnlScsiTestRun.Size = New System.Drawing.Size(376, 37)
        Me.pnlScsiTestRun.TabIndex = 21
        '
        'lblScsiExtimatedEnd
        '
        Me.lblScsiExtimatedEnd.AutoSize = true
        Me.lblScsiExtimatedEnd.ForeColor = System.Drawing.Color.Black
        Me.lblScsiExtimatedEnd.Location = New System.Drawing.Point(0, 24)
        Me.lblScsiExtimatedEnd.Name = "lblScsiExtimatedEnd"
        Me.lblScsiExtimatedEnd.Size = New System.Drawing.Size(101, 13)
        Me.lblScsiExtimatedEnd.TabIndex = 2
        Me.lblScsiExtimatedEnd.Text = "lblScsiExtimatedEnd"
        '
        'prbScsiTestProgress
        '
        Me.prbScsiTestProgress.Location = New System.Drawing.Point(0, 0)
        Me.prbScsiTestProgress.Name = "prbScsiTestProgress"
        Me.prbScsiTestProgress.Size = New System.Drawing.Size(288, 21)
        Me.prbScsiTestProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.prbScsiTestProgress.TabIndex = 16
        '
        'lblScsiProgress
        '
        Me.lblScsiProgress.AutoSize = true
        Me.lblScsiProgress.ForeColor = System.Drawing.Color.Black
        Me.lblScsiProgress.Location = New System.Drawing.Point(296, 0)
        Me.lblScsiProgress.MinimumSize = New System.Drawing.Size(0, 21)
        Me.lblScsiProgress.Name = "lblScsiProgress"
        Me.lblScsiProgress.Size = New System.Drawing.Size(77, 21)
        Me.lblScsiProgress.TabIndex = 0
        Me.lblScsiProgress.Text = "lblScsiProgress"
        Me.lblScsiProgress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblScsiTest
        '
        Me.lblScsiTest.AutoSize = true
        Me.lblScsiTest.ForeColor = System.Drawing.Color.Black
        Me.lblScsiTest.Location = New System.Drawing.Point(3, 3)
        Me.lblScsiTest.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.lblScsiTest.MinimumSize = New System.Drawing.Size(0, 21)
        Me.lblScsiTest.Name = "lblScsiTest"
        Me.lblScsiTest.Size = New System.Drawing.Size(56, 21)
        Me.lblScsiTest.TabIndex = 0
        Me.lblScsiTest.Text = "lblScsiTest"
        Me.lblScsiTest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnScsiRun
        '
        Me.btnScsiRun.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnScsiRun.AutoSize = true
        Me.btnScsiRun.Location = New System.Drawing.Point(785, 3)
        Me.btnScsiRun.Name = "btnScsiRun"
        Me.btnScsiRun.Size = New System.Drawing.Size(80, 23)
        Me.btnScsiRun.TabIndex = 1
        Me.btnScsiRun.Text = "btnScsiRun"
        Me.btnScsiRun.UseVisualStyleBackColor = true
        '
        'btnScsiStop
        '
        Me.btnScsiStop.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnScsiStop.Location = New System.Drawing.Point(785, 32)
        Me.btnScsiStop.Name = "btnScsiStop"
        Me.btnScsiStop.Size = New System.Drawing.Size(80, 23)
        Me.btnScsiStop.TabIndex = 2
        Me.btnScsiStop.Text = "btnScsiStop"
        Me.btnScsiStop.UseVisualStyleBackColor = true
        '
        'HorizontalLine14
        '
        Me.HorizontalLine14.BackColor = System.Drawing.Color.Silver
        Me.HorizontalLine14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HorizontalLine14.Location = New System.Drawing.Point(3, 32)
        Me.HorizontalLine14.Margin = New System.Windows.Forms.Padding(3, 9, 3, 9)
        Me.HorizontalLine14.MaximumSize = New System.Drawing.Size(0, 1)
        Me.HorizontalLine14.Name = "HorizontalLine14"
        Me.HorizontalLine14.Size = New System.Drawing.Size(862, 1)
        Me.HorizontalLine14.TabIndex = 25
        Me.HorizontalLine14.TabStop = false
        '
        'tpSmartctl
        '
        Me.tpSmartctl.BackColor = System.Drawing.Color.White
        Me.tpSmartctl.Controls.Add(Me.htcSmartctl)
        Me.tpSmartctl.Location = New System.Drawing.Point(4, 22)
        Me.tpSmartctl.Name = "tpSmartctl"
        Me.tpSmartctl.Size = New System.Drawing.Size(876, 300)
        Me.tpSmartctl.TabIndex = 3
        Me.tpSmartctl.Text = "tpSmartctl"
        '
        'htcSmartctl
        '
        Me.htcSmartctl.Controls.Add(Me.tpOutput)
        Me.htcSmartctl.Controls.Add(Me.tpAdvanced)
        Me.htcSmartctl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.htcSmartctl.Location = New System.Drawing.Point(0, 0)
        Me.htcSmartctl.Name = "htcSmartctl"
        Me.htcSmartctl.SelectedIndex = 0
        Me.htcSmartctl.Size = New System.Drawing.Size(876, 300)
        Me.htcSmartctl.TabIndex = 0
        Me.htcSmartctl.TabStop = false
        '
        'tpOutput
        '
        Me.tpOutput.BackColor = System.Drawing.Color.Transparent
        Me.tpOutput.Controls.Add(Me.tlpOutput)
        Me.tpOutput.Location = New System.Drawing.Point(4, 22)
        Me.tpOutput.Name = "tpOutput"
        Me.tpOutput.Size = New System.Drawing.Size(868, 274)
        Me.tpOutput.TabIndex = 0
        Me.tpOutput.Text = "tpOutput"
        '
        'tlpOutput
        '
        Me.tlpOutput.AutoSize = true
        Me.tlpOutput.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlpOutput.ColumnCount = 1
        Me.tlpOutput.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tlpOutput.Controls.Add(Me.txtReport, 0, 0)
        Me.tlpOutput.Controls.Add(Me.btnSaveOutput, 0, 1)
        Me.tlpOutput.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpOutput.Location = New System.Drawing.Point(0, 0)
        Me.tlpOutput.Name = "tlpOutput"
        Me.tlpOutput.RowCount = 2
        Me.tlpOutput.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tlpOutput.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpOutput.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20!))
        Me.tlpOutput.Size = New System.Drawing.Size(868, 274)
        Me.tlpOutput.TabIndex = 24
        '
        'txtReport
        '
        Me.txtReport.BackColor = System.Drawing.Color.White
        Me.txtReport.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtReport.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtReport.ForeColor = System.Drawing.Color.Black
        Me.txtReport.Location = New System.Drawing.Point(3, 3)
        Me.txtReport.Multiline = true
        Me.txtReport.Name = "txtReport"
        Me.txtReport.ReadOnly = true
        Me.txtReport.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtReport.Size = New System.Drawing.Size(862, 239)
        Me.txtReport.TabIndex = 0
        Me.txtReport.WordWrap = false
        '
        'btnSaveOutput
        '
        Me.btnSaveOutput.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnSaveOutput.Location = New System.Drawing.Point(790, 248)
        Me.btnSaveOutput.Name = "btnSaveOutput"
        Me.btnSaveOutput.Size = New System.Drawing.Size(75, 23)
        Me.btnSaveOutput.TabIndex = 1
        Me.btnSaveOutput.Text = "btnSaveOutput"
        Me.btnSaveOutput.UseVisualStyleBackColor = true
        '
        'tpAdvanced
        '
        Me.tpAdvanced.Controls.Add(Me.tlpAdvanced)
        Me.tpAdvanced.Location = New System.Drawing.Point(4, 22)
        Me.tpAdvanced.Name = "tpAdvanced"
        Me.tpAdvanced.Size = New System.Drawing.Size(868, 274)
        Me.tpAdvanced.TabIndex = 4
        Me.tpAdvanced.Text = "tpAdvanced"
        Me.tpAdvanced.UseVisualStyleBackColor = true
        '
        'tlpAdvanced
        '
        Me.tlpAdvanced.AutoSize = true
        Me.tlpAdvanced.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlpAdvanced.ColumnCount = 1
        Me.tlpAdvanced.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tlpAdvanced.Controls.Add(Me.HorizontalLine12, 0, 1)
        Me.tlpAdvanced.Controls.Add(Me.lblAdminAdvanced, 0, 0)
        Me.tlpAdvanced.Controls.Add(Me.tabAdvanced, 0, 2)
        Me.tlpAdvanced.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpAdvanced.Location = New System.Drawing.Point(0, 0)
        Me.tlpAdvanced.Name = "tlpAdvanced"
        Me.tlpAdvanced.RowCount = 3
        Me.tlpAdvanced.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpAdvanced.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpAdvanced.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpAdvanced.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20!))
        Me.tlpAdvanced.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20!))
        Me.tlpAdvanced.Size = New System.Drawing.Size(868, 274)
        Me.tlpAdvanced.TabIndex = 0
        '
        'HorizontalLine12
        '
        Me.HorizontalLine12.BackColor = System.Drawing.Color.Silver
        Me.HorizontalLine12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HorizontalLine12.Location = New System.Drawing.Point(3, 32)
        Me.HorizontalLine12.Margin = New System.Windows.Forms.Padding(3, 9, 3, 9)
        Me.HorizontalLine12.MaximumSize = New System.Drawing.Size(0, 1)
        Me.HorizontalLine12.Name = "HorizontalLine12"
        Me.HorizontalLine12.Size = New System.Drawing.Size(862, 1)
        Me.HorizontalLine12.TabIndex = 9
        Me.HorizontalLine12.TabStop = false
        '
        'lblAdminAdvanced
        '
        Me.lblAdminAdvanced.AutoSize = true
        Me.lblAdminAdvanced.ForeColor = System.Drawing.Color.DimGray
        Me.lblAdminAdvanced.Location = New System.Drawing.Point(3, 7)
        Me.lblAdminAdvanced.Margin = New System.Windows.Forms.Padding(3, 7, 3, 3)
        Me.lblAdminAdvanced.Name = "lblAdminAdvanced"
        Me.lblAdminAdvanced.Size = New System.Drawing.Size(94, 13)
        Me.lblAdminAdvanced.TabIndex = 4
        Me.lblAdminAdvanced.Text = "lblAdminAdvanced"
        '
        'tabAdvanced
        '
        Me.tabAdvanced.Controls.Add(Me.tpPower)
        Me.tabAdvanced.Controls.Add(Me.tpRemap)
        Me.tabAdvanced.Controls.Add(Me.tpFirmware)
        Me.tabAdvanced.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabAdvanced.Location = New System.Drawing.Point(3, 42)
        Me.tabAdvanced.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.tabAdvanced.Name = "tabAdvanced"
        Me.tabAdvanced.SelectedIndex = 0
        Me.tabAdvanced.Size = New System.Drawing.Size(862, 229)
        Me.tabAdvanced.TabIndex = 29
        '
        'tpPower
        '
        Me.tpPower.Controls.Add(Me.tlpPowerModeContent)
        Me.tpPower.Location = New System.Drawing.Point(4, 22)
        Me.tpPower.Name = "tpPower"
        Me.tpPower.Size = New System.Drawing.Size(854, 203)
        Me.tpPower.TabIndex = 0
        Me.tpPower.Text = "tpPower"
        Me.tpPower.UseVisualStyleBackColor = true
        '
        'tlpPowerModeContent
        '
        Me.tlpPowerModeContent.AutoSize = true
        Me.tlpPowerModeContent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlpPowerModeContent.ColumnCount = 1
        Me.tlpPowerModeContent.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tlpPowerModeContent.Controls.Add(Me.flwPowerMode, 0, 2)
        Me.tlpPowerModeContent.Controls.Add(Me.lblPowerInfo, 0, 0)
        Me.tlpPowerModeContent.Controls.Add(Me.chkPowerMode, 0, 1)
        Me.tlpPowerModeContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpPowerModeContent.Location = New System.Drawing.Point(0, 0)
        Me.tlpPowerModeContent.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpPowerModeContent.Name = "tlpPowerModeContent"
        Me.tlpPowerModeContent.RowCount = 3
        Me.tlpPowerModeContent.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpPowerModeContent.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpPowerModeContent.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tlpPowerModeContent.Size = New System.Drawing.Size(854, 203)
        Me.tlpPowerModeContent.TabIndex = 28
        '
        'flwPowerMode
        '
        Me.flwPowerMode.AutoScroll = true
        Me.flwPowerMode.AutoSize = true
        Me.flwPowerMode.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.flwPowerMode.Controls.Add(Me.rbNever)
        Me.flwPowerMode.Controls.Add(Me.lblNever)
        Me.flwPowerMode.Controls.Add(Me.rbSleep)
        Me.flwPowerMode.Controls.Add(Me.lblSleep)
        Me.flwPowerMode.Controls.Add(Me.rbStandby)
        Me.flwPowerMode.Controls.Add(Me.lblStandby)
        Me.flwPowerMode.Controls.Add(Me.rbIdle)
        Me.flwPowerMode.Controls.Add(Me.lblIdle)
        Me.flwPowerMode.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flwPowerMode.Location = New System.Drawing.Point(16, 49)
        Me.flwPowerMode.Margin = New System.Windows.Forms.Padding(16, 3, 3, 3)
        Me.flwPowerMode.Name = "flwPowerMode"
        Me.flwPowerMode.Size = New System.Drawing.Size(835, 151)
        Me.flwPowerMode.TabIndex = 9
        '
        'rbNever
        '
        Me.rbNever.AutoSize = true
        Me.flwPowerMode.SetFlowBreak(Me.rbNever, true)
        Me.rbNever.ForeColor = System.Drawing.Color.Black
        Me.rbNever.Location = New System.Drawing.Point(3, 3)
        Me.rbNever.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.rbNever.Name = "rbNever"
        Me.rbNever.Size = New System.Drawing.Size(64, 17)
        Me.rbNever.TabIndex = 10
        Me.rbNever.TabStop = true
        Me.rbNever.Text = "rbNever"
        Me.rbNever.UseVisualStyleBackColor = true
        '
        'lblNever
        '
        Me.lblNever.AutoSize = true
        Me.flwPowerMode.SetFlowBreak(Me.lblNever, true)
        Me.lblNever.ForeColor = System.Drawing.Color.DimGray
        Me.lblNever.Location = New System.Drawing.Point(20, 20)
        Me.lblNever.Margin = New System.Windows.Forms.Padding(20, 0, 3, 3)
        Me.lblNever.MaximumSize = New System.Drawing.Size(800, 0)
        Me.lblNever.Name = "lblNever"
        Me.lblNever.Size = New System.Drawing.Size(46, 13)
        Me.lblNever.TabIndex = 1
        Me.lblNever.Tag = "Grayed"
        Me.lblNever.Text = "lblNever"
        '
        'rbSleep
        '
        Me.rbSleep.AutoSize = true
        Me.flwPowerMode.SetFlowBreak(Me.rbSleep, true)
        Me.rbSleep.ForeColor = System.Drawing.Color.Black
        Me.rbSleep.Location = New System.Drawing.Point(3, 37)
        Me.rbSleep.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.rbSleep.Name = "rbSleep"
        Me.rbSleep.Size = New System.Drawing.Size(61, 17)
        Me.rbSleep.TabIndex = 11
        Me.rbSleep.TabStop = true
        Me.rbSleep.Text = "rbSleep"
        Me.rbSleep.UseVisualStyleBackColor = true
        '
        'lblSleep
        '
        Me.lblSleep.AutoSize = true
        Me.flwPowerMode.SetFlowBreak(Me.lblSleep, true)
        Me.lblSleep.ForeColor = System.Drawing.Color.DimGray
        Me.lblSleep.Location = New System.Drawing.Point(20, 54)
        Me.lblSleep.Margin = New System.Windows.Forms.Padding(20, 0, 3, 3)
        Me.lblSleep.MaximumSize = New System.Drawing.Size(800, 0)
        Me.lblSleep.Name = "lblSleep"
        Me.lblSleep.Size = New System.Drawing.Size(43, 13)
        Me.lblSleep.TabIndex = 3
        Me.lblSleep.Tag = "Grayed"
        Me.lblSleep.Text = "lblSleep"
        '
        'rbStandby
        '
        Me.rbStandby.AutoSize = true
        Me.flwPowerMode.SetFlowBreak(Me.rbStandby, true)
        Me.rbStandby.ForeColor = System.Drawing.Color.Black
        Me.rbStandby.Location = New System.Drawing.Point(3, 71)
        Me.rbStandby.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.rbStandby.Name = "rbStandby"
        Me.rbStandby.Size = New System.Drawing.Size(75, 17)
        Me.rbStandby.TabIndex = 12
        Me.rbStandby.TabStop = true
        Me.rbStandby.Text = "rbStandby"
        Me.rbStandby.UseVisualStyleBackColor = true
        '
        'lblStandby
        '
        Me.lblStandby.AutoSize = true
        Me.flwPowerMode.SetFlowBreak(Me.lblStandby, true)
        Me.lblStandby.ForeColor = System.Drawing.Color.DimGray
        Me.lblStandby.Location = New System.Drawing.Point(20, 88)
        Me.lblStandby.Margin = New System.Windows.Forms.Padding(20, 0, 3, 3)
        Me.lblStandby.MaximumSize = New System.Drawing.Size(800, 0)
        Me.lblStandby.Name = "lblStandby"
        Me.lblStandby.Size = New System.Drawing.Size(57, 13)
        Me.lblStandby.TabIndex = 5
        Me.lblStandby.Tag = "Grayed"
        Me.lblStandby.Text = "lblStandby"
        '
        'rbIdle
        '
        Me.rbIdle.AutoSize = true
        Me.flwPowerMode.SetFlowBreak(Me.rbIdle, true)
        Me.rbIdle.ForeColor = System.Drawing.Color.Black
        Me.rbIdle.Location = New System.Drawing.Point(3, 105)
        Me.rbIdle.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.rbIdle.Name = "rbIdle"
        Me.rbIdle.Size = New System.Drawing.Size(53, 17)
        Me.rbIdle.TabIndex = 13
        Me.rbIdle.TabStop = true
        Me.rbIdle.Text = "rbIdle"
        Me.rbIdle.UseVisualStyleBackColor = true
        '
        'lblIdle
        '
        Me.lblIdle.AutoSize = true
        Me.lblIdle.ForeColor = System.Drawing.Color.DimGray
        Me.lblIdle.Location = New System.Drawing.Point(20, 122)
        Me.lblIdle.Margin = New System.Windows.Forms.Padding(20, 0, 3, 0)
        Me.lblIdle.MaximumSize = New System.Drawing.Size(800, 0)
        Me.lblIdle.Name = "lblIdle"
        Me.lblIdle.Size = New System.Drawing.Size(35, 13)
        Me.lblIdle.TabIndex = 7
        Me.lblIdle.Tag = "Grayed"
        Me.lblIdle.Text = "lblIdle"
        '
        'lblPowerInfo
        '
        Me.lblPowerInfo.AutoSize = true
        Me.lblPowerInfo.BackColor = System.Drawing.Color.Transparent
        Me.lblPowerInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblPowerInfo.ForeColor = System.Drawing.Color.DimGray
        Me.lblPowerInfo.Location = New System.Drawing.Point(0, 3)
        Me.lblPowerInfo.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.lblPowerInfo.Name = "lblPowerInfo"
        Me.lblPowerInfo.Padding = New System.Windows.Forms.Padding(0, 2, 0, 2)
        Me.lblPowerInfo.Size = New System.Drawing.Size(854, 17)
        Me.lblPowerInfo.TabIndex = 1
        Me.lblPowerInfo.Text = "lblPowerInfo"
        Me.lblPowerInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chkPowerMode
        '
        Me.chkPowerMode.AutoSize = true
        Me.chkPowerMode.ForeColor = System.Drawing.Color.Black
        Me.chkPowerMode.Location = New System.Drawing.Point(3, 26)
        Me.chkPowerMode.Name = "chkPowerMode"
        Me.chkPowerMode.Size = New System.Drawing.Size(98, 17)
        Me.chkPowerMode.TabIndex = 9
        Me.chkPowerMode.Text = "chkPowerMode"
        Me.chkPowerMode.UseVisualStyleBackColor = true
        '
        'tpRemap
        '
        Me.tpRemap.Controls.Add(Me.tlpRemapContent)
        Me.tpRemap.Location = New System.Drawing.Point(4, 22)
        Me.tpRemap.Name = "tpRemap"
        Me.tpRemap.Size = New System.Drawing.Size(854, 203)
        Me.tpRemap.TabIndex = 1
        Me.tpRemap.Text = "tpRemap"
        Me.tpRemap.UseVisualStyleBackColor = true
        '
        'tlpRemapContent
        '
        Me.tlpRemapContent.AutoSize = true
        Me.tlpRemapContent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlpRemapContent.ColumnCount = 1
        Me.tlpRemapContent.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tlpRemapContent.Controls.Add(Me.pnlAttributes, 0, 2)
        Me.tlpRemapContent.Controls.Add(Me.lblRemapInfo, 0, 0)
        Me.tlpRemapContent.Controls.Add(Me.chkAttributes, 0, 1)
        Me.tlpRemapContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpRemapContent.Location = New System.Drawing.Point(0, 0)
        Me.tlpRemapContent.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpRemapContent.Name = "tlpRemapContent"
        Me.tlpRemapContent.RowCount = 3
        Me.tlpRemapContent.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpRemapContent.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpRemapContent.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tlpRemapContent.Size = New System.Drawing.Size(854, 203)
        Me.tlpRemapContent.TabIndex = 26
        '
        'pnlAttributes
        '
        Me.pnlAttributes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pnlAttributes.Controls.Add(Me.lvwAttrFormat)
        Me.pnlAttributes.Controls.Add(Me.tlpButtons)
        Me.pnlAttributes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlAttributes.Location = New System.Drawing.Point(16, 49)
        Me.pnlAttributes.Margin = New System.Windows.Forms.Padding(16, 3, 3, 3)
        Me.pnlAttributes.Name = "pnlAttributes"
        Me.pnlAttributes.Size = New System.Drawing.Size(835, 151)
        Me.pnlAttributes.TabIndex = 7
        '
        'lvwAttrFormat
        '
        Me.lvwAttrFormat.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chAttrID, Me.chAttrFormat, Me.chAttrName})
        Me.lvwAttrFormat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvwAttrFormat.FullRowSelect = true
        Me.lvwAttrFormat.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvwAttrFormat.HideSelection = false
        Me.lvwAttrFormat.Location = New System.Drawing.Point(0, 0)
        Me.lvwAttrFormat.Name = "lvwAttrFormat"
        Me.lvwAttrFormat.Size = New System.Drawing.Size(751, 151)
        Me.lvwAttrFormat.TabIndex = 1
        Me.lvwAttrFormat.UseCompatibleStateImageBehavior = false
        Me.lvwAttrFormat.View = System.Windows.Forms.View.Details
        '
        'chAttrID
        '
        Me.chAttrID.Text = "chAttrID"
        '
        'chAttrFormat
        '
        Me.chAttrFormat.Text = "chAttrFormat"
        '
        'chAttrName
        '
        Me.chAttrName.Text = "chAttrName"
        '
        'tlpButtons
        '
        Me.tlpButtons.AutoSize = true
        Me.tlpButtons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlpButtons.ColumnCount = 1
        Me.tlpButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tlpButtons.Controls.Add(Me.btnAdd, 0, 0)
        Me.tlpButtons.Controls.Add(Me.btnRemove, 0, 1)
        Me.tlpButtons.Dock = System.Windows.Forms.DockStyle.Right
        Me.tlpButtons.Location = New System.Drawing.Point(751, 0)
        Me.tlpButtons.Name = "tlpButtons"
        Me.tlpButtons.RowCount = 2
        Me.tlpButtons.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpButtons.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpButtons.Size = New System.Drawing.Size(84, 151)
        Me.tlpButtons.TabIndex = 7
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(3, 0)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(78, 24)
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.Text = "btnAdd"
        Me.btnAdd.UseVisualStyleBackColor = true
        '
        'btnRemove
        '
        Me.btnRemove.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnRemove.Location = New System.Drawing.Point(3, 127)
        Me.btnRemove.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(78, 24)
        Me.btnRemove.TabIndex = 3
        Me.btnRemove.Text = "btnRemove"
        Me.btnRemove.UseVisualStyleBackColor = true
        '
        'lblRemapInfo
        '
        Me.lblRemapInfo.AutoSize = true
        Me.lblRemapInfo.BackColor = System.Drawing.Color.Transparent
        Me.lblRemapInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblRemapInfo.ForeColor = System.Drawing.Color.DimGray
        Me.lblRemapInfo.Location = New System.Drawing.Point(0, 3)
        Me.lblRemapInfo.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.lblRemapInfo.Name = "lblRemapInfo"
        Me.lblRemapInfo.Padding = New System.Windows.Forms.Padding(0, 2, 0, 2)
        Me.lblRemapInfo.Size = New System.Drawing.Size(854, 17)
        Me.lblRemapInfo.TabIndex = 1
        Me.lblRemapInfo.Text = "lblRemapInfo"
        Me.lblRemapInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chkAttributes
        '
        Me.chkAttributes.AutoSize = true
        Me.chkAttributes.ForeColor = System.Drawing.Color.Black
        Me.chkAttributes.Location = New System.Drawing.Point(3, 26)
        Me.chkAttributes.Name = "chkAttributes"
        Me.chkAttributes.Size = New System.Drawing.Size(90, 17)
        Me.chkAttributes.TabIndex = 0
        Me.chkAttributes.Text = "chkAttributes"
        Me.chkAttributes.UseVisualStyleBackColor = true
        '
        'tpFirmware
        '
        Me.tpFirmware.Controls.Add(Me.tlpFirmwareContent)
        Me.tpFirmware.Location = New System.Drawing.Point(4, 22)
        Me.tpFirmware.Name = "tpFirmware"
        Me.tpFirmware.Size = New System.Drawing.Size(854, 203)
        Me.tpFirmware.TabIndex = 2
        Me.tpFirmware.Text = "tpFirmware"
        Me.tpFirmware.UseVisualStyleBackColor = true
        '
        'tlpFirmwareContent
        '
        Me.tlpFirmwareContent.AutoSize = true
        Me.tlpFirmwareContent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlpFirmwareContent.ColumnCount = 1
        Me.tlpFirmwareContent.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tlpFirmwareContent.Controls.Add(Me.flwFirmware, 0, 2)
        Me.tlpFirmwareContent.Controls.Add(Me.lblFirmwareDebugInfo, 0, 0)
        Me.tlpFirmwareContent.Controls.Add(Me.chkFirmware, 0, 1)
        Me.tlpFirmwareContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpFirmwareContent.Location = New System.Drawing.Point(0, 0)
        Me.tlpFirmwareContent.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpFirmwareContent.Name = "tlpFirmwareContent"
        Me.tlpFirmwareContent.RowCount = 3
        Me.tlpFirmwareContent.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpFirmwareContent.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpFirmwareContent.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tlpFirmwareContent.Size = New System.Drawing.Size(854, 203)
        Me.tlpFirmwareContent.TabIndex = 27
        '
        'flwFirmware
        '
        Me.flwFirmware.AutoScroll = true
        Me.flwFirmware.AutoSize = true
        Me.flwFirmware.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.flwFirmware.Controls.Add(Me.cboFirmware)
        Me.flwFirmware.Controls.Add(Me.lblFirmwareDebug)
        Me.flwFirmware.Controls.Add(Me.chkFixSwap)
        Me.flwFirmware.Controls.Add(Me.lblFixSwap)
        Me.flwFirmware.Controls.Add(Me.chkNoLogDir)
        Me.flwFirmware.Controls.Add(Me.lblNoLogDir)
        Me.flwFirmware.Controls.Add(Me.chkXErrorLba)
        Me.flwFirmware.Controls.Add(Me.lblXErrorLba)
        Me.flwFirmware.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flwFirmware.Location = New System.Drawing.Point(16, 49)
        Me.flwFirmware.Margin = New System.Windows.Forms.Padding(16, 3, 3, 3)
        Me.flwFirmware.Name = "flwFirmware"
        Me.flwFirmware.Size = New System.Drawing.Size(835, 151)
        Me.flwFirmware.TabIndex = 25
        '
        'cboFirmware
        '
        Me.cboFirmware.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.flwFirmware.SetFlowBreak(Me.cboFirmware, true)
        Me.cboFirmware.FormattingEnabled = true
        Me.cboFirmware.Location = New System.Drawing.Point(3, 0)
        Me.cboFirmware.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.cboFirmware.Name = "cboFirmware"
        Me.cboFirmware.Size = New System.Drawing.Size(224, 21)
        Me.cboFirmware.TabIndex = 5
        '
        'lblFirmwareDebug
        '
        Me.lblFirmwareDebug.AutoSize = true
        Me.flwFirmware.SetFlowBreak(Me.lblFirmwareDebug, true)
        Me.lblFirmwareDebug.ForeColor = System.Drawing.Color.DimGray
        Me.lblFirmwareDebug.Location = New System.Drawing.Point(20, 24)
        Me.lblFirmwareDebug.Margin = New System.Windows.Forms.Padding(20, 2, 3, 7)
        Me.lblFirmwareDebug.Name = "lblFirmwareDebug"
        Me.lblFirmwareDebug.Size = New System.Drawing.Size(92, 13)
        Me.lblFirmwareDebug.TabIndex = 3
        Me.lblFirmwareDebug.Tag = "Grayed"
        Me.lblFirmwareDebug.Text = "lblFirmwareDebug"
        '
        'chkFixSwap
        '
        Me.chkFixSwap.AutoSize = true
        Me.flwFirmware.SetFlowBreak(Me.chkFixSwap, true)
        Me.chkFixSwap.ForeColor = System.Drawing.Color.Black
        Me.chkFixSwap.Location = New System.Drawing.Point(3, 44)
        Me.chkFixSwap.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.chkFixSwap.Name = "chkFixSwap"
        Me.chkFixSwap.Size = New System.Drawing.Size(82, 17)
        Me.chkFixSwap.TabIndex = 6
        Me.chkFixSwap.Text = "chkFixSwap"
        Me.chkFixSwap.UseVisualStyleBackColor = true
        '
        'lblFixSwap
        '
        Me.lblFixSwap.AutoSize = true
        Me.flwFirmware.SetFlowBreak(Me.lblFixSwap, true)
        Me.lblFixSwap.ForeColor = System.Drawing.Color.DimGray
        Me.lblFixSwap.Location = New System.Drawing.Point(20, 64)
        Me.lblFixSwap.Margin = New System.Windows.Forms.Padding(20, 0, 3, 7)
        Me.lblFixSwap.Name = "lblFixSwap"
        Me.lblFixSwap.Size = New System.Drawing.Size(57, 13)
        Me.lblFixSwap.TabIndex = 4
        Me.lblFixSwap.Tag = "Grayed"
        Me.lblFixSwap.Text = "lblFixSwap"
        '
        'chkNoLogDir
        '
        Me.chkNoLogDir.AutoSize = true
        Me.flwFirmware.SetFlowBreak(Me.chkNoLogDir, true)
        Me.chkNoLogDir.ForeColor = System.Drawing.Color.Black
        Me.chkNoLogDir.Location = New System.Drawing.Point(3, 84)
        Me.chkNoLogDir.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.chkNoLogDir.Name = "chkNoLogDir"
        Me.chkNoLogDir.Size = New System.Drawing.Size(85, 17)
        Me.chkNoLogDir.TabIndex = 7
        Me.chkNoLogDir.Text = "chkNoLogDir"
        Me.chkNoLogDir.UseVisualStyleBackColor = true
        '
        'lblNoLogDir
        '
        Me.lblNoLogDir.AutoSize = true
        Me.flwFirmware.SetFlowBreak(Me.lblNoLogDir, true)
        Me.lblNoLogDir.ForeColor = System.Drawing.Color.DimGray
        Me.lblNoLogDir.Location = New System.Drawing.Point(20, 104)
        Me.lblNoLogDir.Margin = New System.Windows.Forms.Padding(20, 0, 3, 7)
        Me.lblNoLogDir.Name = "lblNoLogDir"
        Me.lblNoLogDir.Size = New System.Drawing.Size(60, 13)
        Me.lblNoLogDir.TabIndex = 7
        Me.lblNoLogDir.Tag = "Grayed"
        Me.lblNoLogDir.Text = "lblNoLogDir"
        '
        'chkXErrorLba
        '
        Me.chkXErrorLba.AutoSize = true
        Me.flwFirmware.SetFlowBreak(Me.chkXErrorLba, true)
        Me.chkXErrorLba.ForeColor = System.Drawing.Color.Black
        Me.chkXErrorLba.Location = New System.Drawing.Point(3, 124)
        Me.chkXErrorLba.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.chkXErrorLba.Name = "chkXErrorLba"
        Me.chkXErrorLba.Size = New System.Drawing.Size(89, 17)
        Me.chkXErrorLba.TabIndex = 8
        Me.chkXErrorLba.Text = "chkXErrorLba"
        Me.chkXErrorLba.UseVisualStyleBackColor = true
        '
        'lblXErrorLba
        '
        Me.lblXErrorLba.AutoSize = true
        Me.flwFirmware.SetFlowBreak(Me.lblXErrorLba, true)
        Me.lblXErrorLba.ForeColor = System.Drawing.Color.DimGray
        Me.lblXErrorLba.Location = New System.Drawing.Point(20, 144)
        Me.lblXErrorLba.Margin = New System.Windows.Forms.Padding(20, 0, 3, 7)
        Me.lblXErrorLba.Name = "lblXErrorLba"
        Me.lblXErrorLba.Size = New System.Drawing.Size(64, 13)
        Me.lblXErrorLba.TabIndex = 9
        Me.lblXErrorLba.Tag = "Grayed"
        Me.lblXErrorLba.Text = "lblXErrorLba"
        '
        'lblFirmwareDebugInfo
        '
        Me.lblFirmwareDebugInfo.AutoSize = true
        Me.lblFirmwareDebugInfo.BackColor = System.Drawing.Color.Transparent
        Me.lblFirmwareDebugInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblFirmwareDebugInfo.ForeColor = System.Drawing.Color.DimGray
        Me.lblFirmwareDebugInfo.Location = New System.Drawing.Point(0, 3)
        Me.lblFirmwareDebugInfo.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.lblFirmwareDebugInfo.Name = "lblFirmwareDebugInfo"
        Me.lblFirmwareDebugInfo.Padding = New System.Windows.Forms.Padding(0, 2, 0, 2)
        Me.lblFirmwareDebugInfo.Size = New System.Drawing.Size(854, 17)
        Me.lblFirmwareDebugInfo.TabIndex = 1
        Me.lblFirmwareDebugInfo.Text = "lblFirmwareDebugInfo"
        Me.lblFirmwareDebugInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chkFirmware
        '
        Me.chkFirmware.AutoSize = true
        Me.chkFirmware.ForeColor = System.Drawing.Color.Black
        Me.chkFirmware.Location = New System.Drawing.Point(3, 26)
        Me.chkFirmware.Name = "chkFirmware"
        Me.chkFirmware.Size = New System.Drawing.Size(86, 17)
        Me.chkFirmware.TabIndex = 4
        Me.chkFirmware.Text = "chkFirmware"
        Me.chkFirmware.UseVisualStyleBackColor = true
        '
        'RibbonHorizontalSeparator4
        '
        Me.RibbonHorizontalSeparator4.BackColor = System.Drawing.Color.FromArgb(CType(CType(218,Byte),Integer), CType(CType(219,Byte),Integer), CType(CType(220,Byte),Integer))
        Me.RibbonHorizontalSeparator4.Dock = System.Windows.Forms.DockStyle.Top
        Me.RibbonHorizontalSeparator4.Location = New System.Drawing.Point(0, 137)
        Me.RibbonHorizontalSeparator4.MaximumSize = New System.Drawing.Size(0, 1)
        Me.RibbonHorizontalSeparator4.MinimumSize = New System.Drawing.Size(80, 1)
        Me.RibbonHorizontalSeparator4.Name = "RibbonHorizontalSeparator4"
        Me.RibbonHorizontalSeparator4.Size = New System.Drawing.Size(884, 1)
        Me.RibbonHorizontalSeparator4.TabIndex = 29
        '
        'tlpManageMenuContent
        '
        Me.tlpManageMenuContent.AutoSize = true
        Me.tlpManageMenuContent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlpManageMenuContent.BackColor = System.Drawing.Color.FromArgb(CType(CType(245,Byte),Integer), CType(CType(246,Byte),Integer), CType(CType(247,Byte),Integer))
        Me.tlpManageMenuContent.ColumnCount = 8
        Me.tlpManageMenuContent.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpManageMenuContent.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpManageMenuContent.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpManageMenuContent.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpManageMenuContent.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpManageMenuContent.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpManageMenuContent.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpManageMenuContent.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tlpManageMenuContent.Controls.Add(Me.tlpSmartctl, 6, 0)
        Me.tlpManageMenuContent.Controls.Add(Me.tlpSetup, 2, 0)
        Me.tlpManageMenuContent.Controls.Add(Me.tlpErrorsTests, 4, 0)
        Me.tlpManageMenuContent.Controls.Add(Me.lblInfo, 0, 1)
        Me.tlpManageMenuContent.Controls.Add(Me.lblSetup, 2, 1)
        Me.tlpManageMenuContent.Controls.Add(Me.lblErrorsTests, 4, 1)
        Me.tlpManageMenuContent.Controls.Add(Me.lblSmartctl, 6, 1)
        Me.tlpManageMenuContent.Controls.Add(Me.RibbonVerticalSeparator1, 1, 0)
        Me.tlpManageMenuContent.Controls.Add(Me.RibbonVerticalSeparator2, 1, 1)
        Me.tlpManageMenuContent.Controls.Add(Me.RibbonVerticalSeparator3, 3, 0)
        Me.tlpManageMenuContent.Controls.Add(Me.RibbonVerticalSeparator4, 3, 1)
        Me.tlpManageMenuContent.Controls.Add(Me.RibbonVerticalSeparator5, 5, 0)
        Me.tlpManageMenuContent.Controls.Add(Me.RibbonVerticalSeparator6, 5, 1)
        Me.tlpManageMenuContent.Controls.Add(Me.tlpInfo, 0, 0)
        Me.tlpManageMenuContent.Controls.Add(Me.RibbonVerticalSeparator8, 7, 0)
        Me.tlpManageMenuContent.Controls.Add(Me.RibbonVerticalSeparator9, 7, 1)
        Me.tlpManageMenuContent.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpManageMenuContent.Location = New System.Drawing.Point(0, 31)
        Me.tlpManageMenuContent.Name = "tlpManageMenuContent"
        Me.tlpManageMenuContent.Padding = New System.Windows.Forms.Padding(3)
        Me.tlpManageMenuContent.RowCount = 2
        Me.tlpManageMenuContent.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpManageMenuContent.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpManageMenuContent.Size = New System.Drawing.Size(884, 106)
        Me.tlpManageMenuContent.TabIndex = 28
        '
        'tlpSmartctl
        '
        Me.tlpSmartctl.AutoSize = true
        Me.tlpSmartctl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlpSmartctl.ColumnCount = 1
        Me.tlpSmartctl.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpSmartctl.Controls.Add(Me.robOutput, 0, 0)
        Me.tlpSmartctl.Controls.Add(Me.robAdvanced, 0, 1)
        Me.tlpSmartctl.Location = New System.Drawing.Point(521, 3)
        Me.tlpSmartctl.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpSmartctl.Name = "tlpSmartctl"
        Me.tlpSmartctl.RowCount = 2
        Me.tlpSmartctl.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpSmartctl.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpSmartctl.Size = New System.Drawing.Size(94, 48)
        Me.tlpSmartctl.TabIndex = 26
        '
        'robOutput
        '
        Me.robOutput.AutoSize = true
        Me.robOutput.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.robOutput.BackColor = System.Drawing.Color.Transparent
        Me.robOutput.Icon = Nothing
        Me.robOutput.Location = New System.Drawing.Point(2, 2)
        Me.robOutput.Margin = New System.Windows.Forms.Padding(2)
        Me.robOutput.Name = "robOutput"
        Me.robOutput.Size = New System.Drawing.Size(76, 20)
        Me.robOutput.TabIndex = 0
        Me.robOutput.Text = "robOutput"
        '
        'robAdvanced
        '
        Me.robAdvanced.AutoSize = true
        Me.robAdvanced.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.robAdvanced.BackColor = System.Drawing.Color.Transparent
        Me.robAdvanced.Icon = Nothing
        Me.robAdvanced.Location = New System.Drawing.Point(2, 26)
        Me.robAdvanced.Margin = New System.Windows.Forms.Padding(2)
        Me.robAdvanced.Name = "robAdvanced"
        Me.robAdvanced.Size = New System.Drawing.Size(90, 20)
        Me.robAdvanced.TabIndex = 2
        Me.robAdvanced.Text = "robAdvanced"
        '
        'tlpSetup
        '
        Me.tlpSetup.AutoSize = true
        Me.tlpSetup.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlpSetup.ColumnCount = 2
        Me.tlpSetup.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpSetup.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpSetup.Controls.Add(Me.robSmartSetup, 0, 0)
        Me.tlpSetup.Controls.Add(Me.robAam, 0, 1)
        Me.tlpSetup.Controls.Add(Me.robApm, 0, 2)
        Me.tlpSetup.Controls.Add(Me.robStandby, 1, 0)
        Me.tlpSetup.Controls.Add(Me.robReadWrite, 1, 1)
        Me.tlpSetup.Location = New System.Drawing.Point(218, 3)
        Me.tlpSetup.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpSetup.Name = "tlpSetup"
        Me.tlpSetup.RowCount = 3
        Me.tlpSetup.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpSetup.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpSetup.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpSetup.Size = New System.Drawing.Size(199, 72)
        Me.tlpSetup.TabIndex = 5
        '
        'robSmartSetup
        '
        Me.robSmartSetup.AutoSize = true
        Me.robSmartSetup.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.robSmartSetup.BackColor = System.Drawing.Color.Transparent
        Me.robSmartSetup.Icon = Nothing
        Me.robSmartSetup.Location = New System.Drawing.Point(2, 2)
        Me.robSmartSetup.Margin = New System.Windows.Forms.Padding(2)
        Me.robSmartSetup.Name = "robSmartSetup"
        Me.robSmartSetup.Size = New System.Drawing.Size(98, 20)
        Me.robSmartSetup.TabIndex = 0
        Me.robSmartSetup.Text = "robSmartSetup"
        '
        'robAam
        '
        Me.robAam.AutoSize = true
        Me.robAam.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.robAam.BackColor = System.Drawing.Color.Transparent
        Me.robAam.Icon = Nothing
        Me.robAam.Location = New System.Drawing.Point(2, 26)
        Me.robAam.Margin = New System.Windows.Forms.Padding(2)
        Me.robAam.Name = "robAam"
        Me.robAam.Size = New System.Drawing.Size(63, 20)
        Me.robAam.TabIndex = 1
        Me.robAam.Text = "robAam"
        '
        'robApm
        '
        Me.robApm.AutoSize = true
        Me.robApm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.robApm.BackColor = System.Drawing.Color.Transparent
        Me.robApm.Icon = Nothing
        Me.robApm.Location = New System.Drawing.Point(2, 50)
        Me.robApm.Margin = New System.Windows.Forms.Padding(2)
        Me.robApm.Name = "robApm"
        Me.robApm.Size = New System.Drawing.Size(63, 20)
        Me.robApm.TabIndex = 2
        Me.robApm.Text = "robApm"
        '
        'robStandby
        '
        Me.robStandby.AutoSize = true
        Me.robStandby.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.robStandby.BackColor = System.Drawing.Color.Transparent
        Me.robStandby.Icon = Nothing
        Me.robStandby.Location = New System.Drawing.Point(104, 2)
        Me.robStandby.Margin = New System.Windows.Forms.Padding(2)
        Me.robStandby.Name = "robStandby"
        Me.robStandby.Size = New System.Drawing.Size(82, 20)
        Me.robStandby.TabIndex = 3
        Me.robStandby.Text = "robStandby"
        '
        'robReadWrite
        '
        Me.robReadWrite.AutoSize = true
        Me.robReadWrite.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.robReadWrite.BackColor = System.Drawing.Color.Transparent
        Me.robReadWrite.Icon = Nothing
        Me.robReadWrite.Location = New System.Drawing.Point(104, 26)
        Me.robReadWrite.Margin = New System.Windows.Forms.Padding(2)
        Me.robReadWrite.Name = "robReadWrite"
        Me.robReadWrite.Size = New System.Drawing.Size(93, 20)
        Me.robReadWrite.TabIndex = 4
        Me.robReadWrite.Text = "robReadWrite"
        '
        'tlpErrorsTests
        '
        Me.tlpErrorsTests.AutoSize = true
        Me.tlpErrorsTests.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlpErrorsTests.ColumnCount = 1
        Me.tlpErrorsTests.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpErrorsTests.Controls.Add(Me.robErrorsLog, 0, 0)
        Me.tlpErrorsTests.Controls.Add(Me.robTestsLog, 0, 1)
        Me.tlpErrorsTests.Controls.Add(Me.robRunTest, 0, 2)
        Me.tlpErrorsTests.Location = New System.Drawing.Point(423, 3)
        Me.tlpErrorsTests.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpErrorsTests.Name = "tlpErrorsTests"
        Me.tlpErrorsTests.RowCount = 3
        Me.tlpErrorsTests.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpErrorsTests.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpErrorsTests.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpErrorsTests.Size = New System.Drawing.Size(92, 72)
        Me.tlpErrorsTests.TabIndex = 25
        '
        'robErrorsLog
        '
        Me.robErrorsLog.AutoSize = true
        Me.robErrorsLog.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.robErrorsLog.BackColor = System.Drawing.Color.Transparent
        Me.robErrorsLog.Icon = Nothing
        Me.robErrorsLog.Location = New System.Drawing.Point(2, 2)
        Me.robErrorsLog.Margin = New System.Windows.Forms.Padding(2)
        Me.robErrorsLog.Name = "robErrorsLog"
        Me.robErrorsLog.Size = New System.Drawing.Size(88, 20)
        Me.robErrorsLog.TabIndex = 0
        Me.robErrorsLog.Text = "robErrorsLog"
        '
        'robTestsLog
        '
        Me.robTestsLog.AutoSize = true
        Me.robTestsLog.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.robTestsLog.BackColor = System.Drawing.Color.Transparent
        Me.robTestsLog.Icon = Nothing
        Me.robTestsLog.Location = New System.Drawing.Point(2, 26)
        Me.robTestsLog.Margin = New System.Windows.Forms.Padding(2)
        Me.robTestsLog.Name = "robTestsLog"
        Me.robTestsLog.Size = New System.Drawing.Size(85, 20)
        Me.robTestsLog.TabIndex = 1
        Me.robTestsLog.Text = "robTestsLog"
        '
        'robRunTest
        '
        Me.robRunTest.AutoSize = true
        Me.robRunTest.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.robRunTest.BackColor = System.Drawing.Color.Transparent
        Me.robRunTest.Icon = Nothing
        Me.robRunTest.Location = New System.Drawing.Point(2, 50)
        Me.robRunTest.Margin = New System.Windows.Forms.Padding(2)
        Me.robRunTest.Name = "robRunTest"
        Me.robRunTest.Size = New System.Drawing.Size(82, 20)
        Me.robRunTest.TabIndex = 2
        Me.robRunTest.Text = "robRunTest"
        '
        'lblInfo
        '
        Me.lblInfo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblInfo.AutoSize = true
        Me.lblInfo.ForeColor = System.Drawing.Color.Silver
        Me.lblInfo.Location = New System.Drawing.Point(89, 87)
        Me.lblInfo.Margin = New System.Windows.Forms.Padding(3, 10, 3, 3)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(37, 13)
        Me.lblInfo.TabIndex = 26
        Me.lblInfo.Text = "lblInfo"
        '
        'lblSetup
        '
        Me.lblSetup.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblSetup.AutoSize = true
        Me.lblSetup.ForeColor = System.Drawing.Color.Silver
        Me.lblSetup.Location = New System.Drawing.Point(295, 87)
        Me.lblSetup.Margin = New System.Windows.Forms.Padding(3, 10, 3, 3)
        Me.lblSetup.Name = "lblSetup"
        Me.lblSetup.Size = New System.Drawing.Size(45, 13)
        Me.lblSetup.TabIndex = 27
        Me.lblSetup.Text = "lblSetup"
        '
        'lblErrorsTests
        '
        Me.lblErrorsTests.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblErrorsTests.AutoSize = true
        Me.lblErrorsTests.ForeColor = System.Drawing.Color.Silver
        Me.lblErrorsTests.Location = New System.Drawing.Point(433, 87)
        Me.lblErrorsTests.Margin = New System.Windows.Forms.Padding(3, 10, 3, 3)
        Me.lblErrorsTests.Name = "lblErrorsTests"
        Me.lblErrorsTests.Size = New System.Drawing.Size(72, 13)
        Me.lblErrorsTests.TabIndex = 28
        Me.lblErrorsTests.Text = "lblErrorsTests"
        '
        'lblSmartctl
        '
        Me.lblSmartctl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblSmartctl.AutoSize = true
        Me.lblSmartctl.ForeColor = System.Drawing.Color.Silver
        Me.lblSmartctl.Location = New System.Drawing.Point(540, 87)
        Me.lblSmartctl.Margin = New System.Windows.Forms.Padding(3, 10, 3, 3)
        Me.lblSmartctl.Name = "lblSmartctl"
        Me.lblSmartctl.Size = New System.Drawing.Size(56, 13)
        Me.lblSmartctl.TabIndex = 29
        Me.lblSmartctl.Text = "lblSmartctl"
        '
        'RibbonVerticalSeparator1
        '
        Me.RibbonVerticalSeparator1.AutoSize = true
        Me.RibbonVerticalSeparator1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.RibbonVerticalSeparator1.BackColor = System.Drawing.Color.FromArgb(CType(CType(218,Byte),Integer), CType(CType(219,Byte),Integer), CType(CType(220,Byte),Integer))
        Me.RibbonVerticalSeparator1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonVerticalSeparator1.Location = New System.Drawing.Point(215, 3)
        Me.RibbonVerticalSeparator1.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.RibbonVerticalSeparator1.MaximumSize = New System.Drawing.Size(1, 80)
        Me.RibbonVerticalSeparator1.Name = "RibbonVerticalSeparator1"
        Me.RibbonVerticalSeparator1.Size = New System.Drawing.Size(1, 74)
        Me.RibbonVerticalSeparator1.TabIndex = 30
        '
        'RibbonVerticalSeparator2
        '
        Me.RibbonVerticalSeparator2.AutoSize = true
        Me.RibbonVerticalSeparator2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.RibbonVerticalSeparator2.BackColor = System.Drawing.Color.FromArgb(CType(CType(218,Byte),Integer), CType(CType(219,Byte),Integer), CType(CType(220,Byte),Integer))
        Me.RibbonVerticalSeparator2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonVerticalSeparator2.Location = New System.Drawing.Point(215, 77)
        Me.RibbonVerticalSeparator2.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.RibbonVerticalSeparator2.MaximumSize = New System.Drawing.Size(1, 80)
        Me.RibbonVerticalSeparator2.Name = "RibbonVerticalSeparator2"
        Me.RibbonVerticalSeparator2.Size = New System.Drawing.Size(1, 26)
        Me.RibbonVerticalSeparator2.TabIndex = 31
        '
        'RibbonVerticalSeparator3
        '
        Me.RibbonVerticalSeparator3.AutoSize = true
        Me.RibbonVerticalSeparator3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.RibbonVerticalSeparator3.BackColor = System.Drawing.Color.FromArgb(CType(CType(218,Byte),Integer), CType(CType(219,Byte),Integer), CType(CType(220,Byte),Integer))
        Me.RibbonVerticalSeparator3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonVerticalSeparator3.Location = New System.Drawing.Point(420, 3)
        Me.RibbonVerticalSeparator3.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.RibbonVerticalSeparator3.MaximumSize = New System.Drawing.Size(1, 80)
        Me.RibbonVerticalSeparator3.Name = "RibbonVerticalSeparator3"
        Me.RibbonVerticalSeparator3.Size = New System.Drawing.Size(1, 74)
        Me.RibbonVerticalSeparator3.TabIndex = 32
        '
        'RibbonVerticalSeparator4
        '
        Me.RibbonVerticalSeparator4.AutoSize = true
        Me.RibbonVerticalSeparator4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.RibbonVerticalSeparator4.BackColor = System.Drawing.Color.FromArgb(CType(CType(218,Byte),Integer), CType(CType(219,Byte),Integer), CType(CType(220,Byte),Integer))
        Me.RibbonVerticalSeparator4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonVerticalSeparator4.Location = New System.Drawing.Point(420, 77)
        Me.RibbonVerticalSeparator4.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.RibbonVerticalSeparator4.MaximumSize = New System.Drawing.Size(1, 80)
        Me.RibbonVerticalSeparator4.Name = "RibbonVerticalSeparator4"
        Me.RibbonVerticalSeparator4.Size = New System.Drawing.Size(1, 26)
        Me.RibbonVerticalSeparator4.TabIndex = 33
        '
        'RibbonVerticalSeparator5
        '
        Me.RibbonVerticalSeparator5.AutoSize = true
        Me.RibbonVerticalSeparator5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.RibbonVerticalSeparator5.BackColor = System.Drawing.Color.FromArgb(CType(CType(218,Byte),Integer), CType(CType(219,Byte),Integer), CType(CType(220,Byte),Integer))
        Me.RibbonVerticalSeparator5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonVerticalSeparator5.Location = New System.Drawing.Point(518, 3)
        Me.RibbonVerticalSeparator5.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.RibbonVerticalSeparator5.MaximumSize = New System.Drawing.Size(1, 80)
        Me.RibbonVerticalSeparator5.Name = "RibbonVerticalSeparator5"
        Me.RibbonVerticalSeparator5.Size = New System.Drawing.Size(1, 74)
        Me.RibbonVerticalSeparator5.TabIndex = 34
        '
        'RibbonVerticalSeparator6
        '
        Me.RibbonVerticalSeparator6.AutoSize = true
        Me.RibbonVerticalSeparator6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.RibbonVerticalSeparator6.BackColor = System.Drawing.Color.FromArgb(CType(CType(218,Byte),Integer), CType(CType(219,Byte),Integer), CType(CType(220,Byte),Integer))
        Me.RibbonVerticalSeparator6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonVerticalSeparator6.Location = New System.Drawing.Point(518, 77)
        Me.RibbonVerticalSeparator6.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.RibbonVerticalSeparator6.MaximumSize = New System.Drawing.Size(1, 80)
        Me.RibbonVerticalSeparator6.Name = "RibbonVerticalSeparator6"
        Me.RibbonVerticalSeparator6.Size = New System.Drawing.Size(1, 26)
        Me.RibbonVerticalSeparator6.TabIndex = 35
        '
        'tlpInfo
        '
        Me.tlpInfo.AutoSize = true
        Me.tlpInfo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlpInfo.ColumnCount = 2
        Me.tlpInfo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpInfo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpInfo.Controls.Add(Me.robAttributes, 0, 2)
        Me.tlpInfo.Controls.Add(Me.robEventsLog, 1, 0)
        Me.tlpInfo.Controls.Add(Me.robEventsChart, 1, 1)
        Me.tlpInfo.Controls.Add(Me.robInfo, 0, 0)
        Me.tlpInfo.Controls.Add(Me.robHealth, 0, 1)
        Me.tlpInfo.Controls.Add(Me.robTemperatures, 1, 2)
        Me.tlpInfo.Location = New System.Drawing.Point(3, 3)
        Me.tlpInfo.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpInfo.Name = "tlpInfo"
        Me.tlpInfo.RowCount = 3
        Me.tlpInfo.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpInfo.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpInfo.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpInfo.Size = New System.Drawing.Size(209, 74)
        Me.tlpInfo.TabIndex = 22
        '
        'robAttributes
        '
        Me.robAttributes.AutoSize = true
        Me.robAttributes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.robAttributes.BackColor = System.Drawing.Color.Transparent
        Me.robAttributes.Icon = Nothing
        Me.robAttributes.Location = New System.Drawing.Point(2, 50)
        Me.robAttributes.Margin = New System.Windows.Forms.Padding(2)
        Me.robAttributes.Name = "robAttributes"
        Me.robAttributes.Size = New System.Drawing.Size(90, 20)
        Me.robAttributes.TabIndex = 0
        Me.robAttributes.Text = "robAttributes"
        '
        'robEventsLog
        '
        Me.robEventsLog.AutoSize = true
        Me.robEventsLog.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.robEventsLog.BackColor = System.Drawing.Color.Transparent
        Me.robEventsLog.Icon = Nothing
        Me.robEventsLog.Location = New System.Drawing.Point(96, 2)
        Me.robEventsLog.Margin = New System.Windows.Forms.Padding(2)
        Me.robEventsLog.Name = "robEventsLog"
        Me.robEventsLog.Size = New System.Drawing.Size(92, 20)
        Me.robEventsLog.TabIndex = 1
        Me.robEventsLog.Text = "robEventsLog"
        '
        'robEventsChart
        '
        Me.robEventsChart.AutoSize = true
        Me.robEventsChart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.robEventsChart.BackColor = System.Drawing.Color.Transparent
        Me.robEventsChart.Icon = Nothing
        Me.robEventsChart.Location = New System.Drawing.Point(96, 26)
        Me.robEventsChart.Margin = New System.Windows.Forms.Padding(2)
        Me.robEventsChart.Name = "robEventsChart"
        Me.robEventsChart.Size = New System.Drawing.Size(102, 20)
        Me.robEventsChart.TabIndex = 2
        Me.robEventsChart.Text = "robEventsChart"
        '
        'robInfo
        '
        Me.robInfo.AutoSize = true
        Me.robInfo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.robInfo.BackColor = System.Drawing.Color.Transparent
        Me.robInfo.Icon = Nothing
        Me.robInfo.Location = New System.Drawing.Point(2, 2)
        Me.robInfo.Margin = New System.Windows.Forms.Padding(2)
        Me.robInfo.Name = "robInfo"
        Me.robInfo.Size = New System.Drawing.Size(62, 20)
        Me.robInfo.TabIndex = 23
        Me.robInfo.Text = "robInfo"
        '
        'robHealth
        '
        Me.robHealth.AutoSize = true
        Me.robHealth.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.robHealth.BackColor = System.Drawing.Color.Transparent
        Me.robHealth.Icon = Nothing
        Me.robHealth.Location = New System.Drawing.Point(2, 26)
        Me.robHealth.Margin = New System.Windows.Forms.Padding(2)
        Me.robHealth.Name = "robHealth"
        Me.robHealth.Size = New System.Drawing.Size(73, 20)
        Me.robHealth.TabIndex = 24
        Me.robHealth.Text = "robHealth"
        '
        'robTemperatures
        '
        Me.robTemperatures.AutoSize = true
        Me.robTemperatures.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.robTemperatures.BackColor = System.Drawing.Color.Transparent
        Me.robTemperatures.Icon = Nothing
        Me.robTemperatures.Location = New System.Drawing.Point(97, 51)
        Me.robTemperatures.Name = "robTemperatures"
        Me.robTemperatures.Size = New System.Drawing.Size(109, 20)
        Me.robTemperatures.TabIndex = 25
        Me.robTemperatures.Text = "robTemperatures"
        '
        'RibbonVerticalSeparator8
        '
        Me.RibbonVerticalSeparator8.BackColor = System.Drawing.Color.FromArgb(CType(CType(218,Byte),Integer), CType(CType(219,Byte),Integer), CType(CType(220,Byte),Integer))
        Me.RibbonVerticalSeparator8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonVerticalSeparator8.Location = New System.Drawing.Point(618, 3)
        Me.RibbonVerticalSeparator8.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.RibbonVerticalSeparator8.MaximumSize = New System.Drawing.Size(1, 0)
        Me.RibbonVerticalSeparator8.Name = "RibbonVerticalSeparator8"
        Me.RibbonVerticalSeparator8.Size = New System.Drawing.Size(1, 74)
        Me.RibbonVerticalSeparator8.TabIndex = 36
        '
        'RibbonVerticalSeparator9
        '
        Me.RibbonVerticalSeparator9.BackColor = System.Drawing.Color.FromArgb(CType(CType(218,Byte),Integer), CType(CType(219,Byte),Integer), CType(CType(220,Byte),Integer))
        Me.RibbonVerticalSeparator9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonVerticalSeparator9.Location = New System.Drawing.Point(618, 77)
        Me.RibbonVerticalSeparator9.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.RibbonVerticalSeparator9.MaximumSize = New System.Drawing.Size(1, 0)
        Me.RibbonVerticalSeparator9.Name = "RibbonVerticalSeparator9"
        Me.RibbonVerticalSeparator9.Size = New System.Drawing.Size(1, 26)
        Me.RibbonVerticalSeparator9.TabIndex = 37
        '
        'RibbonHorizontalSeparator3
        '
        Me.RibbonHorizontalSeparator3.BackColor = System.Drawing.Color.FromArgb(CType(CType(218,Byte),Integer), CType(CType(219,Byte),Integer), CType(CType(220,Byte),Integer))
        Me.RibbonHorizontalSeparator3.Dock = System.Windows.Forms.DockStyle.Top
        Me.RibbonHorizontalSeparator3.Location = New System.Drawing.Point(0, 30)
        Me.RibbonHorizontalSeparator3.MaximumSize = New System.Drawing.Size(0, 1)
        Me.RibbonHorizontalSeparator3.MinimumSize = New System.Drawing.Size(80, 1)
        Me.RibbonHorizontalSeparator3.Name = "RibbonHorizontalSeparator3"
        Me.RibbonHorizontalSeparator3.Size = New System.Drawing.Size(884, 1)
        Me.RibbonHorizontalSeparator3.TabIndex = 27
        '
        'tlpSelDevice
        '
        Me.tlpSelDevice.AutoSize = true
        Me.tlpSelDevice.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlpSelDevice.BackColor = System.Drawing.Color.FromArgb(CType(CType(245,Byte),Integer), CType(CType(246,Byte),Integer), CType(CType(247,Byte),Integer))
        Me.tlpSelDevice.ColumnCount = 4
        Me.tlpSelDevice.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpSelDevice.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpSelDevice.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tlpSelDevice.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpSelDevice.Controls.Add(Me.lblSelDevice, 0, 0)
        Me.tlpSelDevice.Controls.Add(Me.btnReloadDevice, 2, 0)
        Me.tlpSelDevice.Controls.Add(Me.pnlComboBorder, 1, 0)
        Me.tlpSelDevice.Controls.Add(Me.picManageHelp, 3, 0)
        Me.tlpSelDevice.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpSelDevice.Location = New System.Drawing.Point(0, 0)
        Me.tlpSelDevice.Name = "tlpSelDevice"
        Me.tlpSelDevice.RowCount = 1
        Me.tlpSelDevice.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpSelDevice.Size = New System.Drawing.Size(884, 30)
        Me.tlpSelDevice.TabIndex = 26
        '
        'lblSelDevice
        '
        Me.lblSelDevice.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblSelDevice.AutoSize = true
        Me.lblSelDevice.ForeColor = System.Drawing.Color.Black
        Me.lblSelDevice.Location = New System.Drawing.Point(3, 8)
        Me.lblSelDevice.Name = "lblSelDevice"
        Me.lblSelDevice.Size = New System.Drawing.Size(63, 13)
        Me.lblSelDevice.TabIndex = 15
        Me.lblSelDevice.Text = "lblSelDevice"
        '
        'btnReloadDevice
        '
        Me.btnReloadDevice.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnReloadDevice.Location = New System.Drawing.Point(742, 3)
        Me.btnReloadDevice.Name = "btnReloadDevice"
        Me.btnReloadDevice.Size = New System.Drawing.Size(24, 24)
        Me.btnReloadDevice.TabIndex = 1
        Me.btnReloadDevice.UseVisualStyleBackColor = true
        '
        'pnlComboBorder
        '
        Me.pnlComboBorder.BackColor = System.Drawing.Color.FromArgb(CType(CType(217,Byte),Integer), CType(CType(217,Byte),Integer), CType(CType(217,Byte),Integer))
        Me.pnlComboBorder.Controls.Add(Me.cboDevices)
        Me.pnlComboBorder.Location = New System.Drawing.Point(72, 3)
        Me.pnlComboBorder.Name = "pnlComboBorder"
        Me.pnlComboBorder.Padding = New System.Windows.Forms.Padding(1)
        Me.pnlComboBorder.Size = New System.Drawing.Size(664, 24)
        Me.pnlComboBorder.TabIndex = 18
        '
        'cboDevices
        '
        Me.cboDevices.BackColor = System.Drawing.Color.White
        Me.cboDevices.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cboDevices.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDevices.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboDevices.FormattingEnabled = true
        Me.cboDevices.Location = New System.Drawing.Point(1, 1)
        Me.cboDevices.Name = "cboDevices"
        Me.cboDevices.Size = New System.Drawing.Size(662, 22)
        Me.cboDevices.TabIndex = 0
        '
        'picManageHelp
        '
        Me.picManageHelp.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.picManageHelp.Cursor = System.Windows.Forms.Cursors.Default
        Me.picManageHelp.Location = New System.Drawing.Point(865, 7)
        Me.picManageHelp.MaximumSize = New System.Drawing.Size(16, 16)
        Me.picManageHelp.MinimumSize = New System.Drawing.Size(16, 16)
        Me.picManageHelp.Name = "picManageHelp"
        Me.picManageHelp.Size = New System.Drawing.Size(16, 16)
        Me.picManageHelp.TabIndex = 19
        Me.picManageHelp.TabStop = false
        '
        'tpWmiDevices
        '
        Me.tpWmiDevices.BackColor = System.Drawing.Color.White
        Me.tpWmiDevices.Controls.Add(Me.tvwComputer)
        Me.tpWmiDevices.Controls.Add(Me.pnlWmiInfo)
        Me.tpWmiDevices.Controls.Add(Me.RibbonHorizontalSeparator6)
        Me.tpWmiDevices.Controls.Add(Me.tlpWmiMenuItems)
        Me.tpWmiDevices.Location = New System.Drawing.Point(4, 22)
        Me.tpWmiDevices.Name = "tpWmiDevices"
        Me.tpWmiDevices.Size = New System.Drawing.Size(884, 464)
        Me.tpWmiDevices.TabIndex = 2
        Me.tpWmiDevices.Text = "tpWmiDevices"
        '
        'tvwComputer
        '
        Me.tvwComputer.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tvwComputer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tvwComputer.HideSelection = false
        Me.tvwComputer.ItemHeight = 20
        Me.tvwComputer.Location = New System.Drawing.Point(0, 79)
        Me.tvwComputer.Margin = New System.Windows.Forms.Padding(0)
        Me.tvwComputer.Name = "tvwComputer"
        Me.tvwComputer.ShowRootLines = false
        Me.tvwComputer.Size = New System.Drawing.Size(884, 275)
        Me.tvwComputer.TabIndex = 28
        '
        'pnlWmiInfo
        '
        Me.pnlWmiInfo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlWmiInfo.Controls.Add(Me.picWmiSeparator)
        Me.pnlWmiInfo.Controls.Add(Me.tlpWmiInfo)
        Me.pnlWmiInfo.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlWmiInfo.Location = New System.Drawing.Point(0, 354)
        Me.pnlWmiInfo.Name = "pnlWmiInfo"
        Me.pnlWmiInfo.Size = New System.Drawing.Size(884, 110)
        Me.pnlWmiInfo.TabIndex = 27
        '
        'picWmiSeparator
        '
        Me.picWmiSeparator.BackgroundImage = CType(resources.GetObject("picWmiSeparator.BackgroundImage"),System.Drawing.Image)
        Me.picWmiSeparator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picWmiSeparator.Dock = System.Windows.Forms.DockStyle.Top
        Me.picWmiSeparator.Location = New System.Drawing.Point(0, 0)
        Me.picWmiSeparator.Name = "picWmiSeparator"
        Me.picWmiSeparator.Size = New System.Drawing.Size(884, 9)
        Me.picWmiSeparator.TabIndex = 23
        Me.picWmiSeparator.TabStop = false
        '
        'tlpWmiInfo
        '
        Me.tlpWmiInfo.AutoSize = true
        Me.tlpWmiInfo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlpWmiInfo.ColumnCount = 2
        Me.tlpWmiInfo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpWmiInfo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tlpWmiInfo.Controls.Add(Me.tlpWmiDetails, 1, 0)
        Me.tlpWmiInfo.Controls.Add(Me.picWmi, 0, 0)
        Me.tlpWmiInfo.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tlpWmiInfo.Location = New System.Drawing.Point(0, 4)
        Me.tlpWmiInfo.Name = "tlpWmiInfo"
        Me.tlpWmiInfo.RowCount = 1
        Me.tlpWmiInfo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tlpWmiInfo.Size = New System.Drawing.Size(884, 106)
        Me.tlpWmiInfo.TabIndex = 22
        '
        'tlpWmiDetails
        '
        Me.tlpWmiDetails.AutoSize = true
        Me.tlpWmiDetails.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlpWmiDetails.ColumnCount = 4
        Me.tlpWmiDetails.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpWmiDetails.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpWmiDetails.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpWmiDetails.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpWmiDetails.Controls.Add(Me.lblInfo1, 0, 0)
        Me.tlpWmiDetails.Controls.Add(Me.lblInfo8Value, 3, 3)
        Me.tlpWmiDetails.Controls.Add(Me.lblInfo7Value, 3, 2)
        Me.tlpWmiDetails.Controls.Add(Me.lblInfo6Value, 3, 1)
        Me.tlpWmiDetails.Controls.Add(Me.lblInfo5Value, 3, 0)
        Me.tlpWmiDetails.Controls.Add(Me.lblInfo5, 2, 0)
        Me.tlpWmiDetails.Controls.Add(Me.lblInfo6, 2, 1)
        Me.tlpWmiDetails.Controls.Add(Me.lblInfo7, 2, 2)
        Me.tlpWmiDetails.Controls.Add(Me.lblInfo8, 2, 3)
        Me.tlpWmiDetails.Controls.Add(Me.lblInfo4Value, 1, 3)
        Me.tlpWmiDetails.Controls.Add(Me.lblInfo3Value, 1, 2)
        Me.tlpWmiDetails.Controls.Add(Me.lblInfo2Value, 1, 1)
        Me.tlpWmiDetails.Controls.Add(Me.lblInfo1Value, 1, 0)
        Me.tlpWmiDetails.Controls.Add(Me.lblInfo4, 0, 3)
        Me.tlpWmiDetails.Controls.Add(Me.lblInfo3, 0, 2)
        Me.tlpWmiDetails.Controls.Add(Me.lblInfo2, 0, 1)
        Me.tlpWmiDetails.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpWmiDetails.Location = New System.Drawing.Point(106, 8)
        Me.tlpWmiDetails.Margin = New System.Windows.Forms.Padding(0, 8, 8, 8)
        Me.tlpWmiDetails.Name = "tlpWmiDetails"
        Me.tlpWmiDetails.RowCount = 5
        Me.tlpWmiDetails.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18!))
        Me.tlpWmiDetails.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18!))
        Me.tlpWmiDetails.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18!))
        Me.tlpWmiDetails.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18!))
        Me.tlpWmiDetails.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18!))
        Me.tlpWmiDetails.Size = New System.Drawing.Size(770, 90)
        Me.tlpWmiDetails.TabIndex = 2
        '
        'lblInfo1
        '
        Me.lblInfo1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.lblInfo1.AutoSize = true
        Me.lblInfo1.ForeColor = System.Drawing.Color.DimGray
        Me.lblInfo1.Location = New System.Drawing.Point(10, 5)
        Me.lblInfo1.Margin = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.lblInfo1.Name = "lblInfo1"
        Me.lblInfo1.Size = New System.Drawing.Size(43, 13)
        Me.lblInfo1.TabIndex = 0
        Me.lblInfo1.Tag = "Grayed"
        Me.lblInfo1.Text = "lblInfo1"
        Me.lblInfo1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblInfo8Value
        '
        Me.lblInfo8Value.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.lblInfo8Value.AutoSize = true
        Me.lblInfo8Value.ForeColor = System.Drawing.Color.Black
        Me.lblInfo8Value.Location = New System.Drawing.Point(178, 59)
        Me.lblInfo8Value.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.lblInfo8Value.Name = "lblInfo8Value"
        Me.lblInfo8Value.Size = New System.Drawing.Size(69, 13)
        Me.lblInfo8Value.TabIndex = 15
        Me.lblInfo8Value.Text = "lblInfo8Value"
        Me.lblInfo8Value.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'lblInfo7Value
        '
        Me.lblInfo7Value.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.lblInfo7Value.AutoSize = true
        Me.lblInfo7Value.ForeColor = System.Drawing.Color.Black
        Me.lblInfo7Value.Location = New System.Drawing.Point(178, 41)
        Me.lblInfo7Value.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.lblInfo7Value.Name = "lblInfo7Value"
        Me.lblInfo7Value.Size = New System.Drawing.Size(69, 13)
        Me.lblInfo7Value.TabIndex = 14
        Me.lblInfo7Value.Text = "lblInfo7Value"
        Me.lblInfo7Value.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'lblInfo6Value
        '
        Me.lblInfo6Value.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.lblInfo6Value.AutoSize = true
        Me.lblInfo6Value.ForeColor = System.Drawing.Color.Black
        Me.lblInfo6Value.Location = New System.Drawing.Point(178, 23)
        Me.lblInfo6Value.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.lblInfo6Value.Name = "lblInfo6Value"
        Me.lblInfo6Value.Size = New System.Drawing.Size(69, 13)
        Me.lblInfo6Value.TabIndex = 13
        Me.lblInfo6Value.Text = "lblInfo6Value"
        Me.lblInfo6Value.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'lblInfo5Value
        '
        Me.lblInfo5Value.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.lblInfo5Value.AutoSize = true
        Me.lblInfo5Value.ForeColor = System.Drawing.Color.Black
        Me.lblInfo5Value.Location = New System.Drawing.Point(178, 5)
        Me.lblInfo5Value.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.lblInfo5Value.Name = "lblInfo5Value"
        Me.lblInfo5Value.Size = New System.Drawing.Size(69, 13)
        Me.lblInfo5Value.TabIndex = 12
        Me.lblInfo5Value.Text = "lblInfo5Value"
        Me.lblInfo5Value.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'lblInfo5
        '
        Me.lblInfo5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.lblInfo5.AutoSize = true
        Me.lblInfo5.ForeColor = System.Drawing.Color.DimGray
        Me.lblInfo5.Location = New System.Drawing.Point(135, 5)
        Me.lblInfo5.Margin = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.lblInfo5.Name = "lblInfo5"
        Me.lblInfo5.Size = New System.Drawing.Size(43, 13)
        Me.lblInfo5.TabIndex = 8
        Me.lblInfo5.Tag = "Grayed"
        Me.lblInfo5.Text = "lblInfo5"
        Me.lblInfo5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblInfo6
        '
        Me.lblInfo6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.lblInfo6.AutoSize = true
        Me.lblInfo6.ForeColor = System.Drawing.Color.DimGray
        Me.lblInfo6.Location = New System.Drawing.Point(135, 23)
        Me.lblInfo6.Margin = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.lblInfo6.Name = "lblInfo6"
        Me.lblInfo6.Size = New System.Drawing.Size(43, 13)
        Me.lblInfo6.TabIndex = 9
        Me.lblInfo6.Tag = "Grayed"
        Me.lblInfo6.Text = "lblInfo6"
        Me.lblInfo6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblInfo7
        '
        Me.lblInfo7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.lblInfo7.AutoSize = true
        Me.lblInfo7.ForeColor = System.Drawing.Color.DimGray
        Me.lblInfo7.Location = New System.Drawing.Point(135, 41)
        Me.lblInfo7.Margin = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.lblInfo7.Name = "lblInfo7"
        Me.lblInfo7.Size = New System.Drawing.Size(43, 13)
        Me.lblInfo7.TabIndex = 10
        Me.lblInfo7.Tag = "Grayed"
        Me.lblInfo7.Text = "lblInfo7"
        Me.lblInfo7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblInfo8
        '
        Me.lblInfo8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.lblInfo8.AutoSize = true
        Me.lblInfo8.ForeColor = System.Drawing.Color.DimGray
        Me.lblInfo8.Location = New System.Drawing.Point(135, 59)
        Me.lblInfo8.Margin = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.lblInfo8.Name = "lblInfo8"
        Me.lblInfo8.Size = New System.Drawing.Size(43, 13)
        Me.lblInfo8.TabIndex = 11
        Me.lblInfo8.Tag = "Grayed"
        Me.lblInfo8.Text = "lblInfo8"
        Me.lblInfo8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblInfo4Value
        '
        Me.lblInfo4Value.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.lblInfo4Value.AutoSize = true
        Me.lblInfo4Value.ForeColor = System.Drawing.Color.Black
        Me.lblInfo4Value.Location = New System.Drawing.Point(53, 59)
        Me.lblInfo4Value.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.lblInfo4Value.Name = "lblInfo4Value"
        Me.lblInfo4Value.Size = New System.Drawing.Size(69, 13)
        Me.lblInfo4Value.TabIndex = 7
        Me.lblInfo4Value.Text = "lblInfo4Value"
        Me.lblInfo4Value.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'lblInfo3Value
        '
        Me.lblInfo3Value.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.lblInfo3Value.AutoSize = true
        Me.lblInfo3Value.ForeColor = System.Drawing.Color.Black
        Me.lblInfo3Value.Location = New System.Drawing.Point(53, 41)
        Me.lblInfo3Value.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.lblInfo3Value.Name = "lblInfo3Value"
        Me.lblInfo3Value.Size = New System.Drawing.Size(69, 13)
        Me.lblInfo3Value.TabIndex = 6
        Me.lblInfo3Value.Text = "lblInfo3Value"
        Me.lblInfo3Value.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'lblInfo2Value
        '
        Me.lblInfo2Value.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.lblInfo2Value.AutoSize = true
        Me.lblInfo2Value.ForeColor = System.Drawing.Color.Black
        Me.lblInfo2Value.Location = New System.Drawing.Point(53, 23)
        Me.lblInfo2Value.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.lblInfo2Value.Name = "lblInfo2Value"
        Me.lblInfo2Value.Size = New System.Drawing.Size(69, 13)
        Me.lblInfo2Value.TabIndex = 5
        Me.lblInfo2Value.Text = "lblInfo2Value"
        Me.lblInfo2Value.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'lblInfo1Value
        '
        Me.lblInfo1Value.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.lblInfo1Value.AutoSize = true
        Me.lblInfo1Value.ForeColor = System.Drawing.Color.Black
        Me.lblInfo1Value.Location = New System.Drawing.Point(53, 5)
        Me.lblInfo1Value.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.lblInfo1Value.Name = "lblInfo1Value"
        Me.lblInfo1Value.Size = New System.Drawing.Size(69, 13)
        Me.lblInfo1Value.TabIndex = 4
        Me.lblInfo1Value.Text = "lblInfo1Value"
        Me.lblInfo1Value.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'lblInfo4
        '
        Me.lblInfo4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.lblInfo4.AutoSize = true
        Me.lblInfo4.ForeColor = System.Drawing.Color.DimGray
        Me.lblInfo4.Location = New System.Drawing.Point(10, 59)
        Me.lblInfo4.Margin = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.lblInfo4.Name = "lblInfo4"
        Me.lblInfo4.Size = New System.Drawing.Size(43, 13)
        Me.lblInfo4.TabIndex = 3
        Me.lblInfo4.Tag = "Grayed"
        Me.lblInfo4.Text = "lblInfo4"
        Me.lblInfo4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblInfo3
        '
        Me.lblInfo3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.lblInfo3.AutoSize = true
        Me.lblInfo3.ForeColor = System.Drawing.Color.DimGray
        Me.lblInfo3.Location = New System.Drawing.Point(10, 41)
        Me.lblInfo3.Margin = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.lblInfo3.Name = "lblInfo3"
        Me.lblInfo3.Size = New System.Drawing.Size(43, 13)
        Me.lblInfo3.TabIndex = 2
        Me.lblInfo3.Tag = "Grayed"
        Me.lblInfo3.Text = "lblInfo3"
        Me.lblInfo3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblInfo2
        '
        Me.lblInfo2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.lblInfo2.AutoSize = true
        Me.lblInfo2.ForeColor = System.Drawing.Color.DimGray
        Me.lblInfo2.Location = New System.Drawing.Point(10, 23)
        Me.lblInfo2.Margin = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.lblInfo2.Name = "lblInfo2"
        Me.lblInfo2.Size = New System.Drawing.Size(43, 13)
        Me.lblInfo2.TabIndex = 1
        Me.lblInfo2.Tag = "Grayed"
        Me.lblInfo2.Text = "lblInfo2"
        Me.lblInfo2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'picWmi
        '
        Me.picWmi.BackColor = System.Drawing.Color.Transparent
        Me.picWmi.Location = New System.Drawing.Point(8, 8)
        Me.picWmi.Margin = New System.Windows.Forms.Padding(8)
        Me.picWmi.MinimumSize = New System.Drawing.Size(90, 90)
        Me.picWmi.Name = "picWmi"
        Me.picWmi.Size = New System.Drawing.Size(90, 90)
        Me.picWmi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picWmi.TabIndex = 0
        Me.picWmi.TabStop = false
        '
        'RibbonHorizontalSeparator6
        '
        Me.RibbonHorizontalSeparator6.BackColor = System.Drawing.Color.FromArgb(CType(CType(218,Byte),Integer), CType(CType(219,Byte),Integer), CType(CType(220,Byte),Integer))
        Me.RibbonHorizontalSeparator6.Dock = System.Windows.Forms.DockStyle.Top
        Me.RibbonHorizontalSeparator6.Location = New System.Drawing.Point(0, 78)
        Me.RibbonHorizontalSeparator6.MaximumSize = New System.Drawing.Size(0, 1)
        Me.RibbonHorizontalSeparator6.MinimumSize = New System.Drawing.Size(80, 1)
        Me.RibbonHorizontalSeparator6.Name = "RibbonHorizontalSeparator6"
        Me.RibbonHorizontalSeparator6.Size = New System.Drawing.Size(884, 1)
        Me.RibbonHorizontalSeparator6.TabIndex = 26
        '
        'tlpWmiMenuItems
        '
        Me.tlpWmiMenuItems.AutoSize = true
        Me.tlpWmiMenuItems.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlpWmiMenuItems.BackColor = System.Drawing.Color.FromArgb(CType(CType(245,Byte),Integer), CType(CType(246,Byte),Integer), CType(CType(247,Byte),Integer))
        Me.tlpWmiMenuItems.ColumnCount = 3
        Me.tlpWmiMenuItems.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpWmiMenuItems.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tlpWmiMenuItems.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpWmiMenuItems.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20!))
        Me.tlpWmiMenuItems.Controls.Add(Me.rbtRefresh, 0, 0)
        Me.tlpWmiMenuItems.Controls.Add(Me.picWmiDevicesHelp, 2, 0)
        Me.tlpWmiMenuItems.Controls.Add(Me.tlpLoadWmi, 1, 0)
        Me.tlpWmiMenuItems.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpWmiMenuItems.Location = New System.Drawing.Point(0, 0)
        Me.tlpWmiMenuItems.Name = "tlpWmiMenuItems"
        Me.tlpWmiMenuItems.RowCount = 1
        Me.tlpWmiMenuItems.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpWmiMenuItems.Size = New System.Drawing.Size(884, 78)
        Me.tlpWmiMenuItems.TabIndex = 25
        '
        'rbtRefresh
        '
        Me.rbtRefresh.AutoSize = true
        Me.rbtRefresh.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.rbtRefresh.BackColor = System.Drawing.Color.Transparent
        Me.rbtRefresh.ButtonStyle = hdd_guardian.RibbonButton.Style.Big
        Me.rbtRefresh.Icon = Nothing
        Me.rbtRefresh.Location = New System.Drawing.Point(5, 5)
        Me.rbtRefresh.Margin = New System.Windows.Forms.Padding(5, 5, 2, 5)
        Me.rbtRefresh.MaximumSize = New System.Drawing.Size(100, 68)
        Me.rbtRefresh.MinimumSize = New System.Drawing.Size(0, 68)
        Me.rbtRefresh.Name = "rbtRefresh"
        Me.rbtRefresh.Size = New System.Drawing.Size(61, 68)
        Me.rbtRefresh.TabIndex = 0
        Me.rbtRefresh.Text = "rbtRefresh"
        '
        'picWmiDevicesHelp
        '
        Me.picWmiDevicesHelp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.picWmiDevicesHelp.Location = New System.Drawing.Point(863, 5)
        Me.picWmiDevicesHelp.Margin = New System.Windows.Forms.Padding(3, 5, 5, 3)
        Me.picWmiDevicesHelp.Name = "picWmiDevicesHelp"
        Me.picWmiDevicesHelp.Size = New System.Drawing.Size(16, 16)
        Me.picWmiDevicesHelp.TabIndex = 5
        Me.picWmiDevicesHelp.TabStop = false
        '
        'tlpLoadWmi
        '
        Me.tlpLoadWmi.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tlpLoadWmi.AutoSize = true
        Me.tlpLoadWmi.ColumnCount = 2
        Me.tlpLoadWmi.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpLoadWmi.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpLoadWmi.Controls.Add(Me.lblLoadWmi, 1, 0)
        Me.tlpLoadWmi.Controls.Add(Me.picLoadWmi, 0, 0)
        Me.tlpLoadWmi.Location = New System.Drawing.Point(420, 28)
        Me.tlpLoadWmi.Name = "tlpLoadWmi"
        Me.tlpLoadWmi.RowCount = 1
        Me.tlpLoadWmi.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpLoadWmi.Size = New System.Drawing.Size(88, 22)
        Me.tlpLoadWmi.TabIndex = 6
        '
        'lblLoadWmi
        '
        Me.lblLoadWmi.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblLoadWmi.AutoSize = true
        Me.lblLoadWmi.ForeColor = System.Drawing.Color.Black
        Me.lblLoadWmi.Location = New System.Drawing.Point(25, 4)
        Me.lblLoadWmi.Name = "lblLoadWmi"
        Me.lblLoadWmi.Size = New System.Drawing.Size(60, 13)
        Me.lblLoadWmi.TabIndex = 0
        Me.lblLoadWmi.Text = "lblLoadWmi"
        '
        'picLoadWmi
        '
        Me.picLoadWmi.Image = Global.hdd_guardian.My.Resources.Resources.loader2
        Me.picLoadWmi.Location = New System.Drawing.Point(3, 3)
        Me.picLoadWmi.MaximumSize = New System.Drawing.Size(16, 16)
        Me.picLoadWmi.Name = "picLoadWmi"
        Me.picLoadWmi.Size = New System.Drawing.Size(16, 16)
        Me.picLoadWmi.TabIndex = 1
        Me.picLoadWmi.TabStop = false
        '
        'tpDebug
        '
        Me.tpDebug.BackColor = System.Drawing.Color.White
        Me.tpDebug.Controls.Add(Me.tlpDebug)
        Me.tpDebug.Location = New System.Drawing.Point(4, 22)
        Me.tpDebug.Name = "tpDebug"
        Me.tpDebug.Size = New System.Drawing.Size(884, 464)
        Me.tpDebug.TabIndex = 3
        Me.tpDebug.Text = "tpDebug"
        '
        'tlpDebug
        '
        Me.tlpDebug.ColumnCount = 1
        Me.tlpDebug.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tlpDebug.Controls.Add(Me.lvwProgLog, 0, 2)
        Me.tlpDebug.Controls.Add(Me.tlpDebugMenu, 0, 0)
        Me.tlpDebug.Controls.Add(Me.RibbonHorizontalSeparator5, 0, 1)
        Me.tlpDebug.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpDebug.Location = New System.Drawing.Point(0, 0)
        Me.tlpDebug.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpDebug.Name = "tlpDebug"
        Me.tlpDebug.RowCount = 3
        Me.tlpDebug.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpDebug.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpDebug.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tlpDebug.Size = New System.Drawing.Size(884, 464)
        Me.tlpDebug.TabIndex = 2
        '
        'lvwProgLog
        '
        Me.lvwProgLog.BackColor = System.Drawing.Color.White
        Me.lvwProgLog.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lvwProgLog.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chLogDate, Me.chEvent})
        Me.lvwProgLog.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvwProgLog.ForeColor = System.Drawing.Color.Black
        Me.lvwProgLog.FullRowSelect = true
        Me.lvwProgLog.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvwProgLog.Location = New System.Drawing.Point(0, 79)
        Me.lvwProgLog.Margin = New System.Windows.Forms.Padding(0)
        Me.lvwProgLog.MultiSelect = false
        Me.lvwProgLog.Name = "lvwProgLog"
        Me.lvwProgLog.Size = New System.Drawing.Size(884, 385)
        Me.lvwProgLog.TabIndex = 1
        Me.lvwProgLog.UseCompatibleStateImageBehavior = false
        Me.lvwProgLog.View = System.Windows.Forms.View.Details
        '
        'chLogDate
        '
        Me.chLogDate.Text = "chLogDate"
        Me.chLogDate.Width = 150
        '
        'chEvent
        '
        Me.chEvent.Text = "chEvent"
        Me.chEvent.Width = 600
        '
        'tlpDebugMenu
        '
        Me.tlpDebugMenu.AutoSize = true
        Me.tlpDebugMenu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlpDebugMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(245,Byte),Integer), CType(CType(246,Byte),Integer), CType(CType(247,Byte),Integer))
        Me.tlpDebugMenu.ColumnCount = 2
        Me.tlpDebugMenu.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpDebugMenu.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tlpDebugMenu.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20!))
        Me.tlpDebugMenu.Controls.Add(Me.rbtSaveDebug, 0, 0)
        Me.tlpDebugMenu.Controls.Add(Me.rbtClean, 1, 0)
        Me.tlpDebugMenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpDebugMenu.Location = New System.Drawing.Point(0, 0)
        Me.tlpDebugMenu.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpDebugMenu.Name = "tlpDebugMenu"
        Me.tlpDebugMenu.RowCount = 1
        Me.tlpDebugMenu.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpDebugMenu.Size = New System.Drawing.Size(884, 78)
        Me.tlpDebugMenu.TabIndex = 26
        '
        'rbtSaveDebug
        '
        Me.rbtSaveDebug.AutoSize = true
        Me.rbtSaveDebug.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.rbtSaveDebug.BackColor = System.Drawing.Color.Transparent
        Me.rbtSaveDebug.ButtonStyle = hdd_guardian.RibbonButton.Style.Big
        Me.rbtSaveDebug.Icon = Nothing
        Me.rbtSaveDebug.Location = New System.Drawing.Point(5, 5)
        Me.rbtSaveDebug.Margin = New System.Windows.Forms.Padding(5, 5, 2, 5)
        Me.rbtSaveDebug.MaximumSize = New System.Drawing.Size(100, 68)
        Me.rbtSaveDebug.MinimumSize = New System.Drawing.Size(0, 68)
        Me.rbtSaveDebug.Name = "rbtSaveDebug"
        Me.rbtSaveDebug.Size = New System.Drawing.Size(78, 68)
        Me.rbtSaveDebug.TabIndex = 0
        Me.rbtSaveDebug.Text = "rbtSaveDebug"
        '
        'rbtClean
        '
        Me.rbtClean.AutoSize = true
        Me.rbtClean.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.rbtClean.BackColor = System.Drawing.Color.Transparent
        Me.rbtClean.ButtonStyle = hdd_guardian.RibbonButton.Style.Big
        Me.rbtClean.Icon = Nothing
        Me.rbtClean.Location = New System.Drawing.Point(87, 5)
        Me.rbtClean.Margin = New System.Windows.Forms.Padding(2, 5, 2, 5)
        Me.rbtClean.MaximumSize = New System.Drawing.Size(150, 68)
        Me.rbtClean.MinimumSize = New System.Drawing.Size(0, 68)
        Me.rbtClean.Name = "rbtClean"
        Me.rbtClean.Size = New System.Drawing.Size(50, 68)
        Me.rbtClean.TabIndex = 1
        Me.rbtClean.Text = "rbtClean"
        '
        'RibbonHorizontalSeparator5
        '
        Me.RibbonHorizontalSeparator5.BackColor = System.Drawing.Color.FromArgb(CType(CType(218,Byte),Integer), CType(CType(219,Byte),Integer), CType(CType(220,Byte),Integer))
        Me.RibbonHorizontalSeparator5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonHorizontalSeparator5.Location = New System.Drawing.Point(0, 78)
        Me.RibbonHorizontalSeparator5.Margin = New System.Windows.Forms.Padding(0)
        Me.RibbonHorizontalSeparator5.MaximumSize = New System.Drawing.Size(0, 1)
        Me.RibbonHorizontalSeparator5.MinimumSize = New System.Drawing.Size(80, 1)
        Me.RibbonHorizontalSeparator5.Name = "RibbonHorizontalSeparator5"
        Me.RibbonHorizontalSeparator5.Size = New System.Drawing.Size(884, 1)
        Me.RibbonHorizontalSeparator5.TabIndex = 27
        '
        'RibbonHorizontalSeparator1
        '
        Me.RibbonHorizontalSeparator1.BackColor = System.Drawing.Color.FromArgb(CType(CType(218,Byte),Integer), CType(CType(219,Byte),Integer), CType(CType(220,Byte),Integer))
        Me.RibbonHorizontalSeparator1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RibbonHorizontalSeparator1.Location = New System.Drawing.Point(0, 31)
        Me.RibbonHorizontalSeparator1.MaximumSize = New System.Drawing.Size(0, 1)
        Me.RibbonHorizontalSeparator1.MinimumSize = New System.Drawing.Size(80, 1)
        Me.RibbonHorizontalSeparator1.Name = "RibbonHorizontalSeparator1"
        Me.RibbonHorizontalSeparator1.Size = New System.Drawing.Size(892, 1)
        Me.RibbonHorizontalSeparator1.TabIndex = 40
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(892, 522)
        Me.Controls.Add(Me.htcMain)
        Me.Controls.Add(Me.RibbonHorizontalSeparator1)
        Me.Controls.Add(tlpRibbonMenu)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.KeyPreview = true
        Me.MinimumSize = New System.Drawing.Size(900, 480)
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HDD Guardian"
        tlpRibbonMenu.ResumeLayout(false)
        tlpRibbonMenu.PerformLayout
        Me.tlpMessages.ResumeLayout(false)
        CType(Me.picAdmin,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.picNewVersion,System.ComponentModel.ISupportInitialize).EndInit
        flwWarnings.ResumeLayout(false)
        flwWarnings.PerformLayout
        tlpAam.ResumeLayout(false)
        tlpAam.PerformLayout
        tlpAamLoud.ResumeLayout(false)
        tlpAamLoud.PerformLayout
        tlpApm.ResumeLayout(false)
        tlpApm.PerformLayout
        tlpStandby.ResumeLayout(false)
        tlpStandby.PerformLayout
        Me.htcMain.ResumeLayout(false)
        Me.tpOverview.ResumeLayout(false)
        Me.tpOverview.PerformLayout
        Me.tlpMenuItems.ResumeLayout(false)
        Me.tlpMenuItems.PerformLayout
        CType(Me.picOverviewHelp,System.ComponentModel.ISupportInitialize).EndInit
        Me.pnlInfo.ResumeLayout(false)
        Me.pnlInfo.PerformLayout
        CType(Me.picSeparator,System.ComponentModel.ISupportInitialize).EndInit
        Me.tlpDeviceInfo.ResumeLayout(false)
        Me.tlpDeviceInfo.PerformLayout
        Me.tlpInfoPanel.ResumeLayout(false)
        Me.tlpInfoPanel.PerformLayout
        CType(Me.picReliability,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.picDeviceImage,System.ComponentModel.ISupportInitialize).EndInit
        Me.tpManage.ResumeLayout(false)
        Me.tpManage.PerformLayout
        Me.htcManage.ResumeLayout(false)
        Me.tpInfo.ResumeLayout(false)
        Me.htcInfo.ResumeLayout(false)
        Me.tpAtaHealth.ResumeLayout(false)
        Me.tpAtaHealth.PerformLayout
        Me.tlpHealthStatus.ResumeLayout(false)
        Me.tlpHealthStatus.PerformLayout
        Me.tlpRating1.ResumeLayout(false)
        Me.tlpRating1.PerformLayout
        CType(Me.picRating1,System.ComponentModel.ISupportInitialize).EndInit
        Me.tlpRating2.ResumeLayout(false)
        Me.tlpRating2.PerformLayout
        CType(Me.picRating2,System.ComponentModel.ISupportInitialize).EndInit
        Me.tlpRating3.ResumeLayout(false)
        Me.tlpRating3.PerformLayout
        CType(Me.picRating3,System.ComponentModel.ISupportInitialize).EndInit
        Me.tlpRating4.ResumeLayout(false)
        Me.tlpRating4.PerformLayout
        CType(Me.picRating4,System.ComponentModel.ISupportInitialize).EndInit
        Me.tpAtaInfo.ResumeLayout(false)
        Me.tpAtaInfo.PerformLayout
        Me.tlpAtaInfoPanels.ResumeLayout(false)
        Me.tlpAtaInfoPanels.PerformLayout
        CType(Me.picManufacturer,System.ComponentModel.ISupportInitialize).EndInit
        Me.flwManufacturer.ResumeLayout(false)
        Me.flwManufacturer.PerformLayout
        Me.tlpDatabaseValue.ResumeLayout(false)
        Me.tlpDatabaseValue.PerformLayout
        Me.tlpAtaDevice.ResumeLayout(false)
        Me.tlpAtaDevice.PerformLayout
        Me.tpAtaSmartAttributes.ResumeLayout(false)
        Me.tlpAttributes.ResumeLayout(false)
        Me.pnlAttribuesInfo.ResumeLayout(false)
        Me.pnlAttribuesInfo.PerformLayout
        Me.tlpAttributeDetails.ResumeLayout(false)
        Me.tlpAttributeDetails.PerformLayout
        Me.tlpGraph.ResumeLayout(false)
        Me.tlpGraph.PerformLayout
        Me.tpScsiHealth.ResumeLayout(false)
        Me.tpScsiHealth.PerformLayout
        Me.tlpScsiHealth.ResumeLayout(false)
        Me.tlpScsiHealth.PerformLayout
        Me.tpScsiInfo.ResumeLayout(false)
        Me.tpScsiInfo.PerformLayout
        Me.tlpScsiInfoContainer.ResumeLayout(false)
        Me.tlpScsiInfoContainer.PerformLayout
        Me.tlpScsiInfo.ResumeLayout(false)
        Me.tlpScsiInfo.PerformLayout
        Me.flwScsiVendor.ResumeLayout(false)
        Me.flwScsiVendor.PerformLayout
        CType(Me.picScsiVendor,System.ComponentModel.ISupportInitialize).EndInit
        Me.tpEventsLog.ResumeLayout(false)
        Me.tpEventsLog.PerformLayout
        Me.tlpLogViewerContent.ResumeLayout(false)
        Me.tlpLogViewerContent.PerformLayout
        Me.tlpLogViewer.ResumeLayout(false)
        Me.tpEventsChart.ResumeLayout(false)
        Me.tpEventsChart.PerformLayout
        Me.tlpChartContent.ResumeLayout(false)
        Me.tlpChartContent.PerformLayout
        CType(Me.chrChart,System.ComponentModel.ISupportInitialize).EndInit
        Me.tlpChart.ResumeLayout(false)
        Me.tlpChart.PerformLayout
        Me.tpTemperatures.ResumeLayout(false)
        Me.tpTemperatures.PerformLayout
        Me.tlpTemperatures.ResumeLayout(false)
        Me.tlpTemperatures.PerformLayout
        CType(Me.HorizontalLine9,System.ComponentModel.ISupportInitialize).EndInit
        Me.tlpTempGraphs.ResumeLayout(false)
        Me.tlpTempGraphs.PerformLayout
        Me.tlpTempMeans.ResumeLayout(false)
        Me.tlpTempMeans.PerformLayout
        Me.tpSetup.ResumeLayout(false)
        Me.htcSetup.ResumeLayout(false)
        Me.tpAtaSmartSetup.ResumeLayout(false)
        Me.tpAtaSmartSetup.PerformLayout
        Me.tlpAtaSmart.ResumeLayout(false)
        Me.tlpAtaSmart.PerformLayout
        CType(Me.HorizontalLine2,System.ComponentModel.ISupportInitialize).EndInit
        Me.tpScsiSmartSetup.ResumeLayout(false)
        Me.tpScsiSmartSetup.PerformLayout
        Me.tlpScsiSmart.ResumeLayout(false)
        Me.tlpScsiSmart.PerformLayout
        CType(Me.HorizontalLine13,System.ComponentModel.ISupportInitialize).EndInit
        Me.tpAtaAam.ResumeLayout(false)
        Me.tpAtaAam.PerformLayout
        Me.tlpAtaAam.ResumeLayout(false)
        Me.tlpAtaAam.PerformLayout
        CType(Me.trkAam,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.HorizontalLine3,System.ComponentModel.ISupportInitialize).EndInit
        Me.tlpAamWaitMessage.ResumeLayout(false)
        Me.tlpAamWaitMessage.PerformLayout
        CType(Me.picLoaderAam,System.ComponentModel.ISupportInitialize).EndInit
        Me.tpAtaApm.ResumeLayout(false)
        Me.tpAtaApm.PerformLayout
        Me.tlpApmContent.ResumeLayout(false)
        Me.tlpApmContent.PerformLayout
        Me.tlpApmWaitMessage.ResumeLayout(false)
        Me.tlpApmWaitMessage.PerformLayout
        CType(Me.picLoaderApm,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.trkApm,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.HorizontalLine4,System.ComponentModel.ISupportInitialize).EndInit
        Me.tpAtaStandby.ResumeLayout(false)
        Me.tpAtaStandby.PerformLayout
        Me.tlpStandbyContent.ResumeLayout(false)
        Me.tlpStandbyContent.PerformLayout
        Me.tlpStandbyWaitMessage.ResumeLayout(false)
        Me.tlpStandbyWaitMessage.PerformLayout
        CType(Me.picLoaderStandby,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.trkStandby,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.HorizontalLine5,System.ComponentModel.ISupportInitialize).EndInit
        Me.tpAtaReadWrite.ResumeLayout(false)
        Me.tpAtaReadWrite.PerformLayout
        Me.tlpOtherContent.ResumeLayout(false)
        Me.tlpOtherContent.PerformLayout
        Me.tlpWaitRWMessage.ResumeLayout(false)
        Me.tlpWaitRWMessage.PerformLayout
        CType(Me.picLoaderRW,System.ComponentModel.ISupportInitialize).EndInit
        Me.flwOtherFeatures.ResumeLayout(false)
        Me.flwOtherFeatures.PerformLayout
        CType(Me.HorizontalLine6,System.ComponentModel.ISupportInitialize).EndInit
        Me.tpErrorsTests.ResumeLayout(false)
        Me.htcErrorsTests.ResumeLayout(false)
        Me.tpAtaErrors.ResumeLayout(false)
        Me.tpAtaErrors.PerformLayout
        Me.tlpAtaErrorsContent.ResumeLayout(false)
        Me.tlpAtaErrorsContent.PerformLayout
        Me.flwError.ResumeLayout(false)
        Me.flwError.PerformLayout
        Me.flwErrorLog.ResumeLayout(false)
        Me.flwErrorLog.PerformLayout
        CType(Me.HorizontalLine7,System.ComponentModel.ISupportInitialize).EndInit
        Me.tabErrors.ResumeLayout(false)
        Me.tpErrorDescription.ResumeLayout(false)
        Me.tpErrorDescription.PerformLayout
        Me.tlpErrorDescription.ResumeLayout(false)
        Me.tlpErrorDescription.PerformLayout
        Me.tpErrorDetail.ResumeLayout(false)
        Me.tpErrorDetail.PerformLayout
        Me.tlpErrorDetail.ResumeLayout(false)
        Me.tlpErrorDetail.PerformLayout
        Me.tpAtaTests.ResumeLayout(false)
        Me.tpAtaTests.PerformLayout
        Me.tlpTestsContent.ResumeLayout(false)
        Me.tlpTestsContent.PerformLayout
        Me.tlpSelfTests.ResumeLayout(false)
        Me.tlpSelfTests.PerformLayout
        CType(Me.HorizontalLine1,System.ComponentModel.ISupportInitialize).EndInit
        Me.tlpSelective.ResumeLayout(false)
        Me.tlpSelective.PerformLayout
        Me.tpAtaRunTest.ResumeLayout(false)
        Me.tpAtaRunTest.PerformLayout
        Me.tlpAtaTestContent.ResumeLayout(false)
        Me.tlpAtaTestContent.PerformLayout
        Me.tlpTestProgress.ResumeLayout(false)
        Me.tlpTestProgress.PerformLayout
        Me.pnlProgress.ResumeLayout(false)
        Me.pnlProgress.PerformLayout
        Me.tlpTest.ResumeLayout(false)
        Me.tlpTest.PerformLayout
        Me.tlpTestDetails.ResumeLayout(false)
        Me.tlpTestDetails.PerformLayout
        Me.tlpSelectTest.ResumeLayout(false)
        Me.tlpSelectTest.PerformLayout
        CType(Me.HorizontalLine8,System.ComponentModel.ISupportInitialize).EndInit
        Me.tpScsiErrors.ResumeLayout(false)
        Me.tpScsiErrors.PerformLayout
        Me.tlpScsiErrorsContent.ResumeLayout(false)
        Me.tlpScsiErrorsContent.PerformLayout
        Me.tpScsiTests.ResumeLayout(false)
        Me.tpScsiTests.PerformLayout
        Me.tlpScsiTestsContent.ResumeLayout(false)
        Me.tlpScsiTestsContent.PerformLayout
        Me.tpScsiRunTest.ResumeLayout(false)
        Me.tpScsiRunTest.PerformLayout
        Me.tlpScsiTestContent.ResumeLayout(false)
        Me.tlpScsiTestContent.PerformLayout
        Me.tlpScsiTest.ResumeLayout(false)
        Me.tlpScsiTest.PerformLayout
        Me.pnlScsiTestRun.ResumeLayout(false)
        Me.pnlScsiTestRun.PerformLayout
        CType(Me.HorizontalLine14,System.ComponentModel.ISupportInitialize).EndInit
        Me.tpSmartctl.ResumeLayout(false)
        Me.htcSmartctl.ResumeLayout(false)
        Me.tpOutput.ResumeLayout(false)
        Me.tpOutput.PerformLayout
        Me.tlpOutput.ResumeLayout(false)
        Me.tlpOutput.PerformLayout
        Me.tpAdvanced.ResumeLayout(false)
        Me.tpAdvanced.PerformLayout
        Me.tlpAdvanced.ResumeLayout(false)
        Me.tlpAdvanced.PerformLayout
        CType(Me.HorizontalLine12,System.ComponentModel.ISupportInitialize).EndInit
        Me.tabAdvanced.ResumeLayout(false)
        Me.tpPower.ResumeLayout(false)
        Me.tpPower.PerformLayout
        Me.tlpPowerModeContent.ResumeLayout(false)
        Me.tlpPowerModeContent.PerformLayout
        Me.flwPowerMode.ResumeLayout(false)
        Me.flwPowerMode.PerformLayout
        Me.tpRemap.ResumeLayout(false)
        Me.tpRemap.PerformLayout
        Me.tlpRemapContent.ResumeLayout(false)
        Me.tlpRemapContent.PerformLayout
        Me.pnlAttributes.ResumeLayout(false)
        Me.pnlAttributes.PerformLayout
        Me.tlpButtons.ResumeLayout(false)
        Me.tpFirmware.ResumeLayout(false)
        Me.tpFirmware.PerformLayout
        Me.tlpFirmwareContent.ResumeLayout(false)
        Me.tlpFirmwareContent.PerformLayout
        Me.flwFirmware.ResumeLayout(false)
        Me.flwFirmware.PerformLayout
        Me.tlpManageMenuContent.ResumeLayout(false)
        Me.tlpManageMenuContent.PerformLayout
        Me.tlpSmartctl.ResumeLayout(false)
        Me.tlpSmartctl.PerformLayout
        Me.tlpSetup.ResumeLayout(false)
        Me.tlpSetup.PerformLayout
        Me.tlpErrorsTests.ResumeLayout(false)
        Me.tlpErrorsTests.PerformLayout
        Me.tlpInfo.ResumeLayout(false)
        Me.tlpInfo.PerformLayout
        Me.tlpSelDevice.ResumeLayout(false)
        Me.tlpSelDevice.PerformLayout
        Me.pnlComboBorder.ResumeLayout(false)
        CType(Me.picManageHelp,System.ComponentModel.ISupportInitialize).EndInit
        Me.tpWmiDevices.ResumeLayout(false)
        Me.tpWmiDevices.PerformLayout
        Me.pnlWmiInfo.ResumeLayout(false)
        Me.pnlWmiInfo.PerformLayout
        CType(Me.picWmiSeparator,System.ComponentModel.ISupportInitialize).EndInit
        Me.tlpWmiInfo.ResumeLayout(false)
        Me.tlpWmiInfo.PerformLayout
        Me.tlpWmiDetails.ResumeLayout(false)
        Me.tlpWmiDetails.PerformLayout
        CType(Me.picWmi,System.ComponentModel.ISupportInitialize).EndInit
        Me.tlpWmiMenuItems.ResumeLayout(false)
        Me.tlpWmiMenuItems.PerformLayout
        CType(Me.picWmiDevicesHelp,System.ComponentModel.ISupportInitialize).EndInit
        Me.tlpLoadWmi.ResumeLayout(false)
        Me.tlpLoadWmi.PerformLayout
        CType(Me.picLoadWmi,System.ComponentModel.ISupportInitialize).EndInit
        Me.tpDebug.ResumeLayout(false)
        Me.tlpDebug.ResumeLayout(false)
        Me.tlpDebug.PerformLayout
        Me.tlpDebugMenu.ResumeLayout(false)
        Me.tlpDebugMenu.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents ttMain As System.Windows.Forms.ToolTip
    Friend WithEvents imlAttr As System.Windows.Forms.ImageList
    Friend WithEvents niTrayIcon As System.Windows.Forms.NotifyIcon
    Friend WithEvents tmrRefresh As System.Windows.Forms.Timer
    Friend WithEvents tmrFlushMem As System.Windows.Forms.Timer
    Friend WithEvents tmrTest As System.Windows.Forms.Timer
    Friend WithEvents mnuGuide As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuInfo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents imlDevice As System.Windows.Forms.ImageList
    'Friend WithEvents tipTest As hddguardian.TipPanel
    'Friend WithEvents tipTolerance As hddguardian.TipPanel
    'Friend WithEvents tipAttributes As hddguardian.TipPanel
    'Friend WithEvents tipFirmware As hddguardian.TipPanel
    Friend WithEvents imlLog As System.Windows.Forms.ImageList
    Friend WithEvents dlgFolder As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents tmrRefreshExt As System.Windows.Forms.Timer
    Friend WithEvents tmrRefreshVirtual As System.Windows.Forms.Timer
    Friend WithEvents cmTrayIcon As System.Windows.Forms.ContextMenu
    Friend WithEvents mnuRestoreTray As System.Windows.Forms.MenuItem
    Friend WithEvents mnuExitTray As System.Windows.Forms.MenuItem
    Friend WithEvents cmDevices As System.Windows.Forms.ContextMenu
    Friend WithEvents mnuRefreshSel As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRefreshAll As System.Windows.Forms.MenuItem
    Friend WithEvents mnuSearchUsb As System.Windows.Forms.MenuItem
    Friend WithEvents mnuAddVirtualDev As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRemoveVirtualDev As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuTrayIcon As System.Windows.Forms.MenuItem
    Friend WithEvents mnuTrayTemperature As System.Windows.Forms.MenuItem
    Friend WithEvents mnuTrayLife As System.Windows.Forms.MenuItem
    Friend WithEvents mnuSharing As System.Windows.Forms.MenuItem
    Friend WithEvents mnuShareThis As System.Windows.Forms.MenuItem
    Friend WithEvents mnuSharingFolder As System.Windows.Forms.MenuItem
    Friend WithEvents mnuXml As System.Windows.Forms.MenuItem
    Friend WithEvents mnuXmlCreate As System.Windows.Forms.MenuItem
    Friend WithEvents mnuXmlFolder As System.Windows.Forms.MenuItem
    Friend WithEvents rfiFile As hdd_guardian.RibbonFileItem
    Friend WithEvents rmiOverview As hdd_guardian.RibbonMenuItem
    Friend WithEvents rmiManage As hdd_guardian.RibbonMenuItem
    Friend WithEvents rmiWmiDevices As hdd_guardian.RibbonMenuItem
    Friend WithEvents RibbonHorizontalSeparator1 As hdd_guardian.RibbonHorizontalSeparator
    Friend WithEvents htcMain As hdd_guardian.HeadlessTabControl
    Friend WithEvents tpOverview As System.Windows.Forms.TabPage
    Friend WithEvents tpManage As System.Windows.Forms.TabPage
    Friend WithEvents tpWmiDevices As System.Windows.Forms.TabPage
    Friend WithEvents picSeparator As System.Windows.Forms.PictureBox
    Friend WithEvents tlpDeviceInfo As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tlpInfoPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblManufacturer As System.Windows.Forms.Label
    Friend WithEvents lblDeviceName As System.Windows.Forms.Label
    Friend WithEvents lblSerialNumber As System.Windows.Forms.Label
    Friend WithEvents lblDeviceLocation As System.Windows.Forms.Label
    Friend WithEvents lblDeviceSize As System.Windows.Forms.Label
    Friend WithEvents lnkManufacturer As System.Windows.Forms.LinkLabel
    Friend WithEvents lblSerialNumberValue As System.Windows.Forms.Label
    Friend WithEvents lblFirmwareValue As System.Windows.Forms.Label
    Friend WithEvents lblTempInfo As System.Windows.Forms.Label
    Friend WithEvents lblTempInfoValue As System.Windows.Forms.Label
    Friend WithEvents lblReliability As System.Windows.Forms.Label
    Friend WithEvents picReliability As System.Windows.Forms.PictureBox
    Friend WithEvents lblLife As System.Windows.Forms.Label
    Friend WithEvents lblLifeValue As System.Windows.Forms.Label
    Friend WithEvents lblAtaErrorsValue As System.Windows.Forms.Label
    Friend WithEvents lblBadSectorsInfoValue As System.Windows.Forms.Label
    Friend WithEvents lblHealthInfoValue As System.Windows.Forms.Label
    Friend WithEvents lblHealthInfo As System.Windows.Forms.Label
    Friend WithEvents lblBadSectorsInfo As hdd_guardian.ExtendedLabel
    Friend WithEvents lblAtaErrors As hdd_guardian.ExtendedLabel
    Friend WithEvents lblFirmware As hdd_guardian.ExtendedLabel
    Friend WithEvents picDeviceImage As System.Windows.Forms.PictureBox
    Friend WithEvents tlpMenuItems As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents rbtUpdateAll As hdd_guardian.RibbonButton
    Friend WithEvents rbtRescanUsb As hdd_guardian.RibbonButton
    Friend WithEvents rbtAddVirtual As hdd_guardian.RibbonButton
    Friend WithEvents lvwDevices As System.Windows.Forms.ListView
    Friend WithEvents chName As System.Windows.Forms.ColumnHeader
    Friend WithEvents chTemp As System.Windows.Forms.ColumnHeader
    Friend WithEvents chRemaningLife As System.Windows.Forms.ColumnHeader
    Friend WithEvents chType As System.Windows.Forms.ColumnHeader
    Friend WithEvents chSize As System.Windows.Forms.ColumnHeader
    Friend WithEvents tlpSelDevice As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblSelDevice As System.Windows.Forms.Label
    Friend WithEvents pnlComboBorder As System.Windows.Forms.Panel
    Friend WithEvents cboDevices As System.Windows.Forms.ComboBox
    Friend WithEvents RibbonHorizontalSeparator3 As hdd_guardian.RibbonHorizontalSeparator
    Friend WithEvents tlpManageMenuContent As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tlpSmartctl As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents robOutput As hdd_guardian.RibbonOptionButton
    Friend WithEvents robAdvanced As hdd_guardian.RibbonOptionButton
    Friend WithEvents tlpSetup As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents robSmartSetup As hdd_guardian.RibbonOptionButton
    Friend WithEvents robAam As hdd_guardian.RibbonOptionButton
    Friend WithEvents robApm As hdd_guardian.RibbonOptionButton
    Friend WithEvents robStandby As hdd_guardian.RibbonOptionButton
    Friend WithEvents robReadWrite As hdd_guardian.RibbonOptionButton
    Friend WithEvents tlpErrorsTests As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents robErrorsLog As hdd_guardian.RibbonOptionButton
    Friend WithEvents robTestsLog As hdd_guardian.RibbonOptionButton
    Friend WithEvents robRunTest As hdd_guardian.RibbonOptionButton
    Friend WithEvents tlpInfo As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents robAttributes As hdd_guardian.RibbonOptionButton
    Friend WithEvents robEventsLog As hdd_guardian.RibbonOptionButton
    Friend WithEvents robEventsChart As hdd_guardian.RibbonOptionButton
    Friend WithEvents robInfo As hdd_guardian.RibbonOptionButton
    Friend WithEvents lblInfo As System.Windows.Forms.Label
    Friend WithEvents lblSetup As System.Windows.Forms.Label
    Friend WithEvents lblErrorsTests As System.Windows.Forms.Label
    Friend WithEvents lblSmartctl As System.Windows.Forms.Label
    Friend WithEvents RibbonVerticalSeparator1 As hdd_guardian.RibbonVerticalSeparator
    Friend WithEvents RibbonVerticalSeparator2 As hdd_guardian.RibbonVerticalSeparator
    Friend WithEvents RibbonVerticalSeparator3 As hdd_guardian.RibbonVerticalSeparator
    Friend WithEvents RibbonVerticalSeparator4 As hdd_guardian.RibbonVerticalSeparator
    Friend WithEvents RibbonVerticalSeparator5 As hdd_guardian.RibbonVerticalSeparator
    Friend WithEvents RibbonVerticalSeparator6 As hdd_guardian.RibbonVerticalSeparator
    Friend WithEvents htcManage As hdd_guardian.HeadlessTabControl
    Friend WithEvents tpInfo As System.Windows.Forms.TabPage
    Friend WithEvents htcInfo As hdd_guardian.HeadlessTabControl
    Friend WithEvents tpAtaInfo As System.Windows.Forms.TabPage
    Friend WithEvents tpScsiInfo As System.Windows.Forms.TabPage
    Friend WithEvents tpEventsLog As System.Windows.Forms.TabPage
    Friend WithEvents tpEventsChart As System.Windows.Forms.TabPage
    Friend WithEvents tpSetup As System.Windows.Forms.TabPage
    Friend WithEvents htcSetup As hdd_guardian.HeadlessTabControl
    Friend WithEvents tpAtaSmartSetup As System.Windows.Forms.TabPage
    Friend WithEvents tpScsiSmartSetup As System.Windows.Forms.TabPage
    Friend WithEvents tpAtaAam As System.Windows.Forms.TabPage
    Friend WithEvents tpAtaApm As System.Windows.Forms.TabPage
    Friend WithEvents tpAtaStandby As System.Windows.Forms.TabPage
    Friend WithEvents tpAtaReadWrite As System.Windows.Forms.TabPage
    Friend WithEvents tpErrorsTests As System.Windows.Forms.TabPage
    Friend WithEvents htcErrorsTests As hdd_guardian.HeadlessTabControl
    Friend WithEvents tpAtaErrors As System.Windows.Forms.TabPage
    Friend WithEvents tpAtaTests As System.Windows.Forms.TabPage
    Friend WithEvents tpAtaRunTest As System.Windows.Forms.TabPage
    Friend WithEvents tpScsiErrors As System.Windows.Forms.TabPage
    Friend WithEvents tpScsiTests As System.Windows.Forms.TabPage
    Friend WithEvents tpScsiRunTest As System.Windows.Forms.TabPage
    Friend WithEvents tpSmartctl As System.Windows.Forms.TabPage
    Friend WithEvents htcSmartctl As hdd_guardian.HeadlessTabControl
    Friend WithEvents tpOutput As System.Windows.Forms.TabPage
    Friend WithEvents RibbonHorizontalSeparator4 As hdd_guardian.RibbonHorizontalSeparator
    Friend WithEvents tlpAtaSmart As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblSmart As System.Windows.Forms.Label
    Friend WithEvents lblAdminSmart As System.Windows.Forms.Label
    Friend WithEvents lblOfflineTest As System.Windows.Forms.Label
    Friend WithEvents lblAttrAutosave As System.Windows.Forms.Label
    Friend WithEvents chkEnableSmart As System.Windows.Forms.CheckBox
    Friend WithEvents chkEnableOffline As System.Windows.Forms.CheckBox
    Friend WithEvents chkEnableAutosave As System.Windows.Forms.CheckBox
    Friend WithEvents HorizontalLine2 As hdd_guardian.HorizontalLine
    Friend WithEvents tlpAtaAam As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblAamValue As System.Windows.Forms.Label
    Friend WithEvents lblAamRecommended As System.Windows.Forms.Label
    Friend WithEvents lnkSetAam As hdd_guardian.NewLink
    Friend WithEvents lnkSetRecommended As hdd_guardian.NewLink
    Friend WithEvents lnkUndoAam As hdd_guardian.NewLink
    Friend WithEvents trkAam As System.Windows.Forms.TrackBar
    Friend WithEvents lblQuiet As System.Windows.Forms.Label
    Friend WithEvents lblLoudest As System.Windows.Forms.Label
    Friend WithEvents HorizontalLine3 As hdd_guardian.HorizontalLine
    Friend WithEvents lblInfoAam As System.Windows.Forms.Label
    Friend WithEvents tlpApmContent As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents trkApm As System.Windows.Forms.TrackBar
    Friend WithEvents lblApmValue As System.Windows.Forms.Label
    Friend WithEvents lnkSetApm As hdd_guardian.NewLink
    Friend WithEvents lnkUndoApm As hdd_guardian.NewLink
    Friend WithEvents HorizontalLine4 As hdd_guardian.HorizontalLine
    Friend WithEvents lblInfoApm As System.Windows.Forms.Label
    Friend WithEvents tlpStandbyContent As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lnkSetStandby As hdd_guardian.NewLink
    Friend WithEvents lblStandbyValue As System.Windows.Forms.Label
    Friend WithEvents lnkUndoStandby As hdd_guardian.NewLink
    Friend WithEvents trkStandby As System.Windows.Forms.TrackBar
    Friend WithEvents HorizontalLine5 As hdd_guardian.HorizontalLine
    Friend WithEvents lblInfoStandby As System.Windows.Forms.Label
    Friend WithEvents tlpOtherContent As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents chkCache As System.Windows.Forms.CheckBox
    Friend WithEvents lblCacheInfo As System.Windows.Forms.Label
    Friend WithEvents chkLookAhead As System.Windows.Forms.CheckBox
    Friend WithEvents lblLookAheadInfo As System.Windows.Forms.Label
    Friend WithEvents lblAdminOther As System.Windows.Forms.Label
    Friend WithEvents HorizontalLine6 As hdd_guardian.HorizontalLine
    Friend WithEvents tpAtaSmartAttributes As System.Windows.Forms.TabPage
    Friend WithEvents tlpAttributes As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lvwSmart As System.Windows.Forms.ListView
    Friend WithEvents chStatus As System.Windows.Forms.ColumnHeader
    Friend WithEvents chID As System.Windows.Forms.ColumnHeader
    Friend WithEvents chAttribute As System.Windows.Forms.ColumnHeader
    Friend WithEvents chCurrent As System.Windows.Forms.ColumnHeader
    Friend WithEvents chWorst As System.Windows.Forms.ColumnHeader
    Friend WithEvents chThreshold As System.Windows.Forms.ColumnHeader
    Friend WithEvents chRawValue As System.Windows.Forms.ColumnHeader
    Friend WithEvents pnlAttribuesInfo As System.Windows.Forms.Panel
    Friend WithEvents tlpAttributeDetails As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblMeaning As System.Windows.Forms.Label
    Friend WithEvents lblDataStructure As System.Windows.Forms.Label
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents tlpGraph As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblThreshold As System.Windows.Forms.Label
    Friend WithEvents lblCurValue As System.Windows.Forms.Label
    Friend WithEvents fpbWorst As hdd_guardian.FlatProgressBar
    Friend WithEvents lblWorst As System.Windows.Forms.Label
    Friend WithEvents fpbCurValue As hdd_guardian.FlatProgressBar
    Friend WithEvents fpbThreshold As hdd_guardian.FlatProgressBar
    Friend WithEvents lblPrefailure As System.Windows.Forms.Label
    Friend WithEvents lblOnline As System.Windows.Forms.Label
    Friend WithEvents lblSpeed As System.Windows.Forms.Label
    Friend WithEvents lblErrRate As System.Windows.Forms.Label
    Friend WithEvents lblEvCount As System.Windows.Forms.Label
    Friend WithEvents lblSelfPres As System.Windows.Forms.Label
    Friend WithEvents lblFlags As System.Windows.Forms.Label
    Friend WithEvents lblGraph As System.Windows.Forms.Label
    Friend WithEvents tlpAtaErrorsContent As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblErrLogVer As System.Windows.Forms.Label
    Friend WithEvents cpCommands As hdd_guardian.CommandsPanel
    Friend WithEvents flwError As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents flwErrorLog As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents lblErrorLog As System.Windows.Forms.Label
    Friend WithEvents optError1 As System.Windows.Forms.RadioButton
    Friend WithEvents optError2 As System.Windows.Forms.RadioButton
    Friend WithEvents optError3 As System.Windows.Forms.RadioButton
    Friend WithEvents optError4 As System.Windows.Forms.RadioButton
    Friend WithEvents optError5 As System.Windows.Forms.RadioButton
    Friend WithEvents lblPowerOn As System.Windows.Forms.Label
    Friend WithEvents lblDeviceStatus As System.Windows.Forms.Label
    Friend WithEvents lblRegisters As System.Windows.Forms.Label
    Friend WithEvents lblCommands As System.Windows.Forms.Label
    Friend WithEvents lblAdminErrors As System.Windows.Forms.Label
    Friend WithEvents rpRegisters As hdd_guardian.RegistersPanel
    Friend WithEvents HorizontalLine7 As hdd_guardian.HorizontalLine
    Friend WithEvents tlpTestsContent As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblAdminTests As System.Windows.Forms.Label
    Friend WithEvents lblNoSelective As System.Windows.Forms.Label
    Friend WithEvents lvwSelective As System.Windows.Forms.ListView
    Friend WithEvents chSpan As System.Windows.Forms.ColumnHeader
    Friend WithEvents chLbaMin As System.Windows.Forms.ColumnHeader
    Friend WithEvents chLbaMax As System.Windows.Forms.ColumnHeader
    Friend WithEvents chCurTestStatus As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblNoSelfTests As System.Windows.Forms.Label
    Friend WithEvents lvwSelfTest As System.Windows.Forms.ListView
    Friend WithEvents chNum As System.Windows.Forms.ColumnHeader
    Friend WithEvents chTestType As System.Windows.Forms.ColumnHeader
    Friend WithEvents chTestStatus As System.Windows.Forms.ColumnHeader
    Friend WithEvents chRemaining As System.Windows.Forms.ColumnHeader
    Friend WithEvents chAge As System.Windows.Forms.ColumnHeader
    Friend WithEvents chFirstError As System.Windows.Forms.ColumnHeader
    Friend WithEvents tlpAtaTestContent As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tlpTestProgress As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnStop As System.Windows.Forms.Button
    Friend WithEvents pnlProgress As System.Windows.Forms.Panel
    Friend WithEvents lblExtimatedEnd As System.Windows.Forms.Label
    Friend WithEvents prbTestProgress As System.Windows.Forms.ProgressBar
    Friend WithEvents lblProgress As System.Windows.Forms.Label
    Friend WithEvents lblInfoTest As System.Windows.Forms.Label
    Friend WithEvents tlpTest As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tlpTestDetails As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblTestInfo As System.Windows.Forms.Label
    Friend WithEvents tlpSelectTest As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents cboTest As System.Windows.Forms.ComboBox
    Friend WithEvents lblSelectTest As System.Windows.Forms.Label
    Friend WithEvents btnRun As System.Windows.Forms.Button
    Friend WithEvents lblDuration As System.Windows.Forms.Label
    Friend WithEvents HorizontalLine8 As hdd_guardian.HorizontalLine
    Friend WithEvents flwManufacturer As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents lblModel As System.Windows.Forms.Label
    Friend WithEvents lnkAtaManufacturer As hdd_guardian.NewLink
    Friend WithEvents lblFamily As System.Windows.Forms.Label
    Friend WithEvents picManufacturer As System.Windows.Forms.PictureBox
    Friend WithEvents tpAtaHealth As System.Windows.Forms.TabPage
    Friend WithEvents lblRating1 As System.Windows.Forms.Label
    Friend WithEvents lblRating2 As System.Windows.Forms.Label
    Friend WithEvents lblRating3 As System.Windows.Forms.Label
    Friend WithEvents lblRating4 As System.Windows.Forms.Label
    Friend WithEvents picRating1 As System.Windows.Forms.PictureBox
    Friend WithEvents picRating2 As System.Windows.Forms.PictureBox
    Friend WithEvents picRating3 As System.Windows.Forms.PictureBox
    Friend WithEvents picRating4 As System.Windows.Forms.PictureBox
    Friend WithEvents lblRating1Value As System.Windows.Forms.Label
    Friend WithEvents lblRating2Value As System.Windows.Forms.Label
    Friend WithEvents lblRating3Value As System.Windows.Forms.Label
    Friend WithEvents lblRating4Value As System.Windows.Forms.Label
    Friend WithEvents lblLastTestValue As System.Windows.Forms.Label
    Friend WithEvents lblHealthValue As System.Windows.Forms.Label
    Friend WithEvents lblBadSectors As System.Windows.Forms.Label
    Friend WithEvents lblTempValue As System.Windows.Forms.Label
    Friend WithEvents lblTemperature As System.Windows.Forms.Label
    Friend WithEvents lblHealth As System.Windows.Forms.Label
    Friend WithEvents lblLastTest As System.Windows.Forms.Label
    Friend WithEvents lblRemainingLife As System.Windows.Forms.Label
    Friend WithEvents lblRemainingLifeValue As System.Windows.Forms.Label
    Friend WithEvents lblErrorsAta As System.Windows.Forms.Label
    Friend WithEvents robHealth As hdd_guardian.RibbonOptionButton
    Friend WithEvents tpScsiHealth As System.Windows.Forms.TabPage
    Friend WithEvents tlpScsiInfoContainer As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents flwScsiVendor As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents picScsiVendor As System.Windows.Forms.PictureBox
    Friend WithEvents lnkVendor As hdd_guardian.NewLink
    Friend WithEvents lblScsiModel As System.Windows.Forms.Label
    Friend WithEvents tlpScsiInfo As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblScsiSmartStatusValue As System.Windows.Forms.Label
    Friend WithEvents lblScsiProtocolValue As System.Windows.Forms.Label
    Friend WithEvents lblScsiRotationValue As System.Windows.Forms.Label
    Friend WithEvents lblScsiBlockSizeValue As System.Windows.Forms.Label
    Friend WithEvents lblScsiTotalSizeValue As System.Windows.Forms.Label
    Friend WithEvents lblScsiUnitIdValue As System.Windows.Forms.Label
    Friend WithEvents lblScsiSerialValue As System.Windows.Forms.Label
    Friend WithEvents lblScsiRevisionValue As System.Windows.Forms.Label
    Friend WithEvents lblScsiSmartStatus As System.Windows.Forms.Label
    Friend WithEvents lblScsiProtocol As System.Windows.Forms.Label
    Friend WithEvents lblScsiRotation As System.Windows.Forms.Label
    Friend WithEvents lblScsiUnitId As System.Windows.Forms.Label
    Friend WithEvents lblScsiSerial As System.Windows.Forms.Label
    Friend WithEvents lblScsiRevision As System.Windows.Forms.Label
    Friend WithEvents lblScsiTotalSize As System.Windows.Forms.Label
    Friend WithEvents lblScsiBlockSize As System.Windows.Forms.Label
    Friend WithEvents tlpScsiHealth As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblScsiGrownDefects As System.Windows.Forms.Label
    Friend WithEvents lblScsiOverallHealth As System.Windows.Forms.Label
    Friend WithEvents lblScsiTempValue As System.Windows.Forms.Label
    Friend WithEvents lblScsiTemp As System.Windows.Forms.Label
    Friend WithEvents lblScsiLastTest As System.Windows.Forms.Label
    Friend WithEvents lblScsiHealthValue As System.Windows.Forms.Label
    Friend WithEvents lblScsiLastTestValue As System.Windows.Forms.Label
    Friend WithEvents lblScsiErrors As System.Windows.Forms.Label
    Friend WithEvents tlpScsiSmart As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblScsiGltsd As System.Windows.Forms.Label
    Friend WithEvents lblScsiRCache As System.Windows.Forms.Label
    Friend WithEvents chkScsiRCache As System.Windows.Forms.CheckBox
    Friend WithEvents chkScsiWCache As System.Windows.Forms.CheckBox
    Friend WithEvents lblScsiWCache As System.Windows.Forms.Label
    Friend WithEvents chkScsiSmart As System.Windows.Forms.CheckBox
    Friend WithEvents chkScsiGltsd As System.Windows.Forms.CheckBox
    Friend WithEvents lblScsiSmart As System.Windows.Forms.Label
    Friend WithEvents tlpScsiErrorsContent As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblScsiNoErrors As System.Windows.Forms.Label
    Friend WithEvents tvwScsiErrors As System.Windows.Forms.TreeView
    Friend WithEvents tlpScsiTestsContent As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblScsiTestCounter As System.Windows.Forms.Label
    Friend WithEvents lvwScsiTests As System.Windows.Forms.ListView
    Friend WithEvents chScsiNum As System.Windows.Forms.ColumnHeader
    Friend WithEvents chScsiTest As System.Windows.Forms.ColumnHeader
    Friend WithEvents chScsiStatus As System.Windows.Forms.ColumnHeader
    Friend WithEvents chScsiSegment As System.Windows.Forms.ColumnHeader
    Friend WithEvents chScsiLifetime As System.Windows.Forms.ColumnHeader
    Friend WithEvents chScsiFirstErr As System.Windows.Forms.ColumnHeader
    Friend WithEvents chScsiSK As System.Windows.Forms.ColumnHeader
    Friend WithEvents chScsiASK As System.Windows.Forms.ColumnHeader
    Friend WithEvents chScsiASQ As System.Windows.Forms.ColumnHeader
    Friend WithEvents tlpScsiTest As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pnlScsiTestRun As System.Windows.Forms.Panel
    Friend WithEvents lblScsiExtimatedEnd As System.Windows.Forms.Label
    Friend WithEvents prbScsiTestProgress As System.Windows.Forms.ProgressBar
    Friend WithEvents lblScsiProgress As System.Windows.Forms.Label
    Friend WithEvents lblScsiTest As System.Windows.Forms.Label
    Friend WithEvents btnScsiRun As System.Windows.Forms.Button
    Friend WithEvents btnScsiStop As System.Windows.Forms.Button
    Friend WithEvents tlpLogViewerContent As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lvwLog As System.Windows.Forms.ListView
    Friend WithEvents chAttrLog As System.Windows.Forms.ColumnHeader
    Friend WithEvents chTime As System.Windows.Forms.ColumnHeader
    Friend WithEvents chFrom As System.Windows.Forms.ColumnHeader
    Friend WithEvents chTo As System.Windows.Forms.ColumnHeader
    Friend WithEvents chVariation As System.Windows.Forms.ColumnHeader
    Friend WithEvents tlpLogViewer As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnSaveLog As System.Windows.Forms.Button
    Friend WithEvents btnCopy As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents dteLog As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnToday As System.Windows.Forms.Button
    Friend WithEvents btnPrev As System.Windows.Forms.Button
    Friend WithEvents btnReload As System.Windows.Forms.Button
    Friend WithEvents lblLogItems As System.Windows.Forms.Label
    Friend WithEvents tlpChartContent As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents chrChart As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents lblChartCount As System.Windows.Forms.Label
    Friend WithEvents lvwChart As System.Windows.Forms.ListView
    Friend WithEvents chDate As System.Windows.Forms.ColumnHeader
    Friend WithEvents chFromGraph As System.Windows.Forms.ColumnHeader
    Friend WithEvents chToGraph As System.Windows.Forms.ColumnHeader
    Friend WithEvents chVariationGraph As System.Windows.Forms.ColumnHeader
    Friend WithEvents tlpChart As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents cboChartEvents As System.Windows.Forms.ComboBox
    Friend WithEvents btnReloadDevice As System.Windows.Forms.Button
    Friend WithEvents lblEvents As System.Windows.Forms.Label
    Friend WithEvents tlpOutput As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents txtReport As System.Windows.Forms.TextBox
    Friend WithEvents btnSaveOutput As System.Windows.Forms.Button
    Friend WithEvents lblInfo1 As System.Windows.Forms.Label
    Friend WithEvents lblInfo2 As System.Windows.Forms.Label
    Friend WithEvents lblInfo3 As System.Windows.Forms.Label
    Friend WithEvents lblInfo4 As System.Windows.Forms.Label
    Friend WithEvents lblInfo1Value As System.Windows.Forms.Label
    Friend WithEvents lblInfo2Value As System.Windows.Forms.Label
    Friend WithEvents lblInfo3Value As System.Windows.Forms.Label
    Friend WithEvents lblInfo4Value As System.Windows.Forms.Label
    Friend WithEvents lblInfo5 As System.Windows.Forms.Label
    Friend WithEvents lblInfo5Value As System.Windows.Forms.Label
    Friend WithEvents lblInfo6 As System.Windows.Forms.Label
    Friend WithEvents lblInfo6Value As System.Windows.Forms.Label
    Friend WithEvents lblInfo7 As System.Windows.Forms.Label
    Friend WithEvents lblInfo7Value As System.Windows.Forms.Label
    Friend WithEvents lblInfo8 As System.Windows.Forms.Label
    Friend WithEvents lblInfo8Value As System.Windows.Forms.Label
    Protected WithEvents lblWarningValue As System.Windows.Forms.Label
    Friend WithEvents lnkWeb1 As hdd_guardian.NewLink
    Friend WithEvents lnkWeb2 As hdd_guardian.NewLink
    Friend WithEvents lnkWeb3 As hdd_guardian.NewLink
    Friend WithEvents tlpDatabaseValue As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblInDatabase As System.Windows.Forms.Label
    Friend WithEvents lnkUpdateDatabase As hdd_guardian.NewLink
    Friend WithEvents tlpAtaDevice As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblSmartStatusValue As System.Windows.Forms.Label
    Friend WithEvents lblSmartStatus As System.Windows.Forms.Label
    Friend WithEvents lblSerial As System.Windows.Forms.Label
    Friend WithEvents lblWWN As System.Windows.Forms.Label
    Friend WithEvents lblFirmwareInfo As System.Windows.Forms.Label
    Friend WithEvents lblTotalSize As System.Windows.Forms.Label
    Friend WithEvents lblSectorSize As System.Windows.Forms.Label
    Friend WithEvents lblRotation As System.Windows.Forms.Label
    Friend WithEvents lblAtaVersion As System.Windows.Forms.Label
    Friend WithEvents lblSataVersion As System.Windows.Forms.Label
    Friend WithEvents lblSerialValue As System.Windows.Forms.Label
    Friend WithEvents lblWwnValue As System.Windows.Forms.Label
    Friend WithEvents lblFirmwareInfoValue As System.Windows.Forms.Label
    Friend WithEvents lblTotalSizeValue As System.Windows.Forms.Label
    Friend WithEvents lblSectorSizeValue As System.Windows.Forms.Label
    Friend WithEvents lblRotationValue As System.Windows.Forms.Label
    Friend WithEvents lblAtaVersionValue As System.Windows.Forms.Label
    Friend WithEvents lblSataVersionValue As System.Windows.Forms.Label
    Friend WithEvents picWmiSeparator As System.Windows.Forms.PictureBox
    Friend WithEvents tlpWmiInfo As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tlpWmiDetails As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents picWmi As System.Windows.Forms.PictureBox
    Friend WithEvents RibbonHorizontalSeparator6 As hdd_guardian.RibbonHorizontalSeparator
    Friend WithEvents tlpWmiMenuItems As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents rbtRefresh As hdd_guardian.RibbonButton
    Friend WithEvents RibbonVerticalSeparator8 As hdd_guardian.RibbonVerticalSeparator
    Friend WithEvents RibbonVerticalSeparator9 As hdd_guardian.RibbonVerticalSeparator
    Friend WithEvents tvwComputer As System.Windows.Forms.TreeView
    Friend WithEvents lblAdminScsiSmart As System.Windows.Forms.Label
    Friend WithEvents HorizontalLine13 As hdd_guardian.HorizontalLine
    Friend WithEvents picManageHelp As System.Windows.Forms.PictureBox
    Friend WithEvents cmFile As System.Windows.Forms.ContextMenu
    Friend WithEvents mnuSettings As System.Windows.Forms.MenuItem
    Friend WithEvents mnuAbout As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuExit As System.Windows.Forms.MenuItem
    Friend WithEvents tlpScsiTestContent As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblScsiInfoTest As System.Windows.Forms.Label
    Friend WithEvents HorizontalLine14 As hdd_guardian.HorizontalLine
    Friend WithEvents lblHealthStatus As System.Windows.Forms.Label
    Friend WithEvents lblReliabilityRating As System.Windows.Forms.Label
    Friend WithEvents tlpRating1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tlpRating2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tlpRating3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tlpRating4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblLastUpdate As System.Windows.Forms.Label
    Friend WithEvents lblLastUpdateValue As System.Windows.Forms.Label
    Friend WithEvents tlpAtaInfoPanels As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblDevice As System.Windows.Forms.Label
    Friend WithEvents lblDatabase As System.Windows.Forms.Label
    Friend WithEvents lblWarnings As System.Windows.Forms.Label
    Friend WithEvents lblScsiHealth As System.Windows.Forms.Label
    Friend WithEvents lblScsiLastUpdateValue As System.Windows.Forms.Label
    Friend WithEvents lblScsiLastUpdate As System.Windows.Forms.Label
    Friend WithEvents tlpSelfTests As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblSelfTests As System.Windows.Forms.Label
    Friend WithEvents HorizontalLine1 As hdd_guardian.HorizontalLine
    Friend WithEvents tlpSelective As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblSelective As System.Windows.Forms.Label
    Friend WithEvents picAdmin As System.Windows.Forms.PictureBox
    Friend WithEvents tlpMessages As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents picNewVersion As System.Windows.Forms.PictureBox
    Friend WithEvents picOverviewHelp As System.Windows.Forms.PictureBox
    Friend WithEvents picWmiDevicesHelp As System.Windows.Forms.PictureBox
    Friend WithEvents mnuTitle As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents cmDeviceImage As System.Windows.Forms.ContextMenu
    Friend WithEvents mnuProfessional As System.Windows.Forms.MenuItem
    Friend WithEvents mnuGamer As System.Windows.Forms.MenuItem
    Friend WithEvents mnuLaptop As System.Windows.Forms.MenuItem
    Friend WithEvents chkCacheReorder As System.Windows.Forms.CheckBox
    Friend WithEvents lblCacheReorderInfo As System.Windows.Forms.Label
    Friend WithEvents tlpAamWaitMessage As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblAamWaitMessage As System.Windows.Forms.Label
    Friend WithEvents picLoaderAam As System.Windows.Forms.PictureBox
    Friend WithEvents tlpApmWaitMessage As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblApmWaitMessage As System.Windows.Forms.Label
    Friend WithEvents picLoaderApm As System.Windows.Forms.PictureBox
    Friend WithEvents tlpStandbyWaitMessage As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblStandbyWaitMessage As System.Windows.Forms.Label
    Friend WithEvents picLoaderStandby As System.Windows.Forms.PictureBox
    Friend WithEvents tlpWaitRWMessage As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblWaitRWMessage As System.Windows.Forms.Label
    Friend WithEvents picLoaderRW As System.Windows.Forms.PictureBox
    Friend WithEvents rmiDebug As hdd_guardian.RibbonMenuItem
    Friend WithEvents tpDebug As System.Windows.Forms.TabPage
    Friend WithEvents lvwProgLog As System.Windows.Forms.ListView
    Friend WithEvents chLogDate As System.Windows.Forms.ColumnHeader
    Friend WithEvents chEvent As System.Windows.Forms.ColumnHeader
    Friend WithEvents tlpLoadWmi As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblLoadWmi As System.Windows.Forms.Label
    Friend WithEvents picLoadWmi As System.Windows.Forms.PictureBox
    Friend WithEvents tlpDebug As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tlpDebugMenu As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents rbtSaveDebug As hdd_guardian.RibbonButton
    Friend WithEvents RibbonHorizontalSeparator5 As hdd_guardian.RibbonHorizontalSeparator
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuInfoPanel As System.Windows.Forms.MenuItem
    Friend WithEvents mnuReloadDevices As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    Friend WithEvents lblWorkTime As System.Windows.Forms.Label
    Friend WithEvents lblWorkTimeValue As System.Windows.Forms.Label
    Friend WithEvents lblAtaWorkTime As System.Windows.Forms.Label
    Friend WithEvents lblAtaWorkTimeValue As System.Windows.Forms.Label
    Friend WithEvents lblScsiWorkTime As System.Windows.Forms.Label
    Friend WithEvents lblScsiWorkTimeValue As System.Windows.Forms.Label
    Friend WithEvents MenuItem10 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuUpdateDatabase As System.Windows.Forms.MenuItem
    Friend WithEvents tpTemperatures As System.Windows.Forms.TabPage
    Friend WithEvents lblLifeTimeMax As System.Windows.Forms.Label
    Friend WithEvents lblCurrentTemp As System.Windows.Forms.Label
    Friend WithEvents lblCycleMin As System.Windows.Forms.Label
    Friend WithEvents lblMin As System.Windows.Forms.Label
    Friend WithEvents lblMax As System.Windows.Forms.Label
    Friend WithEvents lblCycleMax As System.Windows.Forms.Label
    Friend WithEvents lblRecommendedMax As System.Windows.Forms.Label
    Friend WithEvents lblLimitMax As System.Windows.Forms.Label
    Friend WithEvents lblCycle As System.Windows.Forms.Label
    Friend WithEvents lblLifeTime As System.Windows.Forms.Label
    Friend WithEvents lblLifeTimeMin As System.Windows.Forms.Label
    Friend WithEvents lblRecommendedMin As System.Windows.Forms.Label
    Friend WithEvents lblLimitMin As System.Windows.Forms.Label
    Friend WithEvents lblRecommended As System.Windows.Forms.Label
    Friend WithEvents lblLimit As System.Windows.Forms.Label
    Friend WithEvents lblCurrentTempValue As System.Windows.Forms.Label
    Friend WithEvents robTemperatures As hdd_guardian.RibbonOptionButton
    Friend WithEvents tbCycle As hdd_guardian.TemperaturesBar
    Friend WithEvents tbLifeTime As hdd_guardian.TemperaturesBar
    Friend WithEvents tbRecommended As hdd_guardian.TemperaturesBar
    Friend WithEvents tbLimit As hdd_guardian.TemperaturesBar
    Friend WithEvents lblZero As System.Windows.Forms.Label
    Friend WithEvents tlpTemperatures As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblAdminTemperatures As System.Windows.Forms.Label
    Friend WithEvents HorizontalLine9 As hdd_guardian.HorizontalLine
    Friend WithEvents lblTempMeans As System.Windows.Forms.Label
    Friend WithEvents tlpTempMeans As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblLimitValue As System.Windows.Forms.Label
    Friend WithEvents lblLimitMean As System.Windows.Forms.Label
    Friend WithEvents lblCycleMeans As System.Windows.Forms.Label
    Friend WithEvents lblLifeTimeMean As System.Windows.Forms.Label
    Friend WithEvents lblRecommendedMean As System.Windows.Forms.Label
    Friend WithEvents lblCycleValue As System.Windows.Forms.Label
    Friend WithEvents lblLifeTimeValue As System.Windows.Forms.Label
    Friend WithEvents lblRecommendedValue As System.Windows.Forms.Label
    Friend WithEvents lblForm As System.Windows.Forms.Label
    Friend WithEvents lblFormValue As System.Windows.Forms.Label
    Friend WithEvents tpAdvanced As System.Windows.Forms.TabPage
    Friend WithEvents tlpAdvanced As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents HorizontalLine12 As hdd_guardian.HorizontalLine
    Friend WithEvents lblAdminAdvanced As System.Windows.Forms.Label
    Friend WithEvents tlpRemapContent As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pnlAttributes As System.Windows.Forms.Panel
    Friend WithEvents lvwAttrFormat As System.Windows.Forms.ListView
    Friend WithEvents chAttrID As System.Windows.Forms.ColumnHeader
    Friend WithEvents chAttrFormat As System.Windows.Forms.ColumnHeader
    Friend WithEvents chAttrName As System.Windows.Forms.ColumnHeader
    Friend WithEvents tlpButtons As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents chkAttributes As System.Windows.Forms.CheckBox
    Friend WithEvents lblRemapInfo As System.Windows.Forms.Label
    Friend WithEvents lblPowerInfo As System.Windows.Forms.Label
    Friend WithEvents tlpFirmwareContent As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents flwFirmware As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents cboFirmware As System.Windows.Forms.ComboBox
    Friend WithEvents lblFirmwareDebug As System.Windows.Forms.Label
    Friend WithEvents chkFixSwap As System.Windows.Forms.CheckBox
    Friend WithEvents lblFixSwap As System.Windows.Forms.Label
    Friend WithEvents chkNoLogDir As System.Windows.Forms.CheckBox
    Friend WithEvents lblNoLogDir As System.Windows.Forms.Label
    Friend WithEvents chkXErrorLba As System.Windows.Forms.CheckBox
    Friend WithEvents lblXErrorLba As System.Windows.Forms.Label
    Friend WithEvents chkFirmware As System.Windows.Forms.CheckBox
    Friend WithEvents lblFirmwareDebugInfo As System.Windows.Forms.Label
    Friend WithEvents tlpPowerModeContent As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents flwPowerMode As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents rbNever As System.Windows.Forms.RadioButton
    Friend WithEvents lblNever As System.Windows.Forms.Label
    Friend WithEvents rbSleep As System.Windows.Forms.RadioButton
    Friend WithEvents lblSleep As System.Windows.Forms.Label
    Friend WithEvents rbStandby As System.Windows.Forms.RadioButton
    Friend WithEvents lblStandby As System.Windows.Forms.Label
    Friend WithEvents rbIdle As System.Windows.Forms.RadioButton
    Friend WithEvents lblIdle As System.Windows.Forms.Label
    Friend WithEvents chkPowerMode As System.Windows.Forms.CheckBox
    Friend WithEvents rbtClean As hdd_guardian.RibbonButton
    Friend WithEvents tabAdvanced As System.Windows.Forms.TabControl
    Friend WithEvents tpPower As System.Windows.Forms.TabPage
    Friend WithEvents tpRemap As System.Windows.Forms.TabPage
    Friend WithEvents tpFirmware As System.Windows.Forms.TabPage
    Friend WithEvents tabErrors As System.Windows.Forms.TabControl
    Friend WithEvents tpErrorDescription As System.Windows.Forms.TabPage
    Friend WithEvents lblErrorNumber As System.Windows.Forms.Label
    Friend WithEvents lblErrorNumberValue As System.Windows.Forms.Label
    Friend WithEvents lblErrorSectorsValue As System.Windows.Forms.Label
    Friend WithEvents lblErrorDescriptionValue As System.Windows.Forms.Label
    Friend WithEvents lblErrorElapsedValue As System.Windows.Forms.Label
    Friend WithEvents lblErrorDescription As System.Windows.Forms.Label
    Friend WithEvents lblErrorElapsed As System.Windows.Forms.Label
    Friend WithEvents lblErrorLba As System.Windows.Forms.Label
    Friend WithEvents lblErrorSectors As System.Windows.Forms.Label
    Friend WithEvents lblErrorLbaValue As System.Windows.Forms.Label
    Friend WithEvents tpErrorDetail As System.Windows.Forms.TabPage
    Friend WithEvents tlpErrorDetail As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblErrorStatus As System.Windows.Forms.Label
    Friend WithEvents lblErrorStatusValue As System.Windows.Forms.Label
    Friend WithEvents tlpErrorDescription As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pnlInfo As System.Windows.Forms.Panel
    Friend WithEvents tlpHealthStatus As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tlpTempGraphs As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents flwOtherFeatures As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents pnlWmiInfo As System.Windows.Forms.Panel

End Class
