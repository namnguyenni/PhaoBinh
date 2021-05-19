using System.Drawing;
using devDept.Eyeshot;
using devDept.Graphics;

namespace WindowsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            devDept.Eyeshot.CancelToolBarButton cancelToolBarButton1 = new devDept.Eyeshot.CancelToolBarButton("Cancel", devDept.Eyeshot.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.ProgressBar progressBar1 = new devDept.Eyeshot.ProgressBar(devDept.Eyeshot.ProgressBar.styleType.Circular, 0, "Idle", System.Drawing.Color.Red, System.Drawing.Color.Transparent, System.Drawing.Color.Green, 1D, true, cancelToolBarButton1, false, 0.1D, true);
            devDept.Graphics.BackgroundSettings backgroundSettings1 = new devDept.Graphics.BackgroundSettings(devDept.Graphics.backgroundStyleType.Solid, System.Drawing.Color.DeepSkyBlue, System.Drawing.Color.DodgerBlue, System.Drawing.Color.WhiteSmoke, 0.75D, null, devDept.Graphics.colorThemeType.Auto, 0.3D);
            devDept.Eyeshot.Camera camera1 = new devDept.Eyeshot.Camera(new devDept.Geometry.Point3D(0D, 0D, 0D), 617.101007166283D, new devDept.Geometry.Quaternion(0.12940952255126D, 0.224143868042013D, 0.482962913144534D, 0.836516303737808D), devDept.Graphics.projectionType.Perspective, 50D, 3.2756107948305604D, false, 0.001D);
            devDept.Eyeshot.HomeToolBarButton homeToolBarButton1 = new devDept.Eyeshot.HomeToolBarButton("Home", devDept.Eyeshot.ToolBarButton.styleType.PushButton, true, true);
            devDept.Eyeshot.MagnifyingGlassToolBarButton magnifyingGlassToolBarButton1 = new devDept.Eyeshot.MagnifyingGlassToolBarButton("Magnifying Glass", devDept.Eyeshot.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.ZoomWindowToolBarButton zoomWindowToolBarButton1 = new devDept.Eyeshot.ZoomWindowToolBarButton("Zoom Window", devDept.Eyeshot.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.ZoomToolBarButton zoomToolBarButton1 = new devDept.Eyeshot.ZoomToolBarButton("Zoom", devDept.Eyeshot.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.PanToolBarButton panToolBarButton1 = new devDept.Eyeshot.PanToolBarButton("Pan", devDept.Eyeshot.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.RotateToolBarButton rotateToolBarButton1 = new devDept.Eyeshot.RotateToolBarButton("Rotate", devDept.Eyeshot.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.ZoomFitToolBarButton zoomFitToolBarButton1 = new devDept.Eyeshot.ZoomFitToolBarButton("Zoom Fit", devDept.Eyeshot.ToolBarButton.styleType.PushButton, true, true);
            devDept.Eyeshot.ToolBar toolBar1 = new devDept.Eyeshot.ToolBar(devDept.Eyeshot.ToolBar.positionType.HorizontalTopCenter, true, new devDept.Eyeshot.ToolBarButton[] {
            ((devDept.Eyeshot.ToolBarButton)(homeToolBarButton1)),
            ((devDept.Eyeshot.ToolBarButton)(magnifyingGlassToolBarButton1)),
            ((devDept.Eyeshot.ToolBarButton)(zoomWindowToolBarButton1)),
            ((devDept.Eyeshot.ToolBarButton)(zoomToolBarButton1)),
            ((devDept.Eyeshot.ToolBarButton)(panToolBarButton1)),
            ((devDept.Eyeshot.ToolBarButton)(rotateToolBarButton1)),
            ((devDept.Eyeshot.ToolBarButton)(zoomFitToolBarButton1))});
            devDept.Eyeshot.Grid grid1 = new devDept.Eyeshot.Grid(new devDept.Geometry.Point3D(-50D, -50D, 0D), new devDept.Geometry.Point3D(100D, 100D, 0D), 10D, new devDept.Geometry.Plane(new devDept.Geometry.Point3D(0D, 0D, 0D), new devDept.Geometry.Vector3D(0D, 0D, 1D)), System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))), System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32))))), System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32))))), false, true, false, false, 10, 100, 10, System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90))))), System.Drawing.Color.Empty, false, System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255))))));
            devDept.Eyeshot.RotateSettings rotateSettings1 = new devDept.Eyeshot.RotateSettings(new devDept.Eyeshot.MouseButton(devDept.Eyeshot.mouseButtonsZPR.Middle, devDept.Eyeshot.modifierKeys.None), 10D, true, 1D, devDept.Eyeshot.rotationType.Trackball, devDept.Eyeshot.rotationCenterType.CursorLocation, new devDept.Geometry.Point3D(0D, 0D, 0D), false);
            devDept.Eyeshot.ZoomSettings zoomSettings1 = new devDept.Eyeshot.ZoomSettings(new devDept.Eyeshot.MouseButton(devDept.Eyeshot.mouseButtonsZPR.Middle, devDept.Eyeshot.modifierKeys.Shift), 25, true, devDept.Eyeshot.zoomStyleType.AtCursorLocation, false, 1D, System.Drawing.Color.DeepSkyBlue, devDept.Eyeshot.Camera.perspectiveFitType.Accurate, false, 10, true);
            devDept.Eyeshot.PanSettings panSettings1 = new devDept.Eyeshot.PanSettings(new devDept.Eyeshot.MouseButton(devDept.Eyeshot.mouseButtonsZPR.Middle, devDept.Eyeshot.modifierKeys.Ctrl), 25, true);
            devDept.Eyeshot.NavigationSettings navigationSettings1 = new devDept.Eyeshot.NavigationSettings(devDept.Eyeshot.Camera.navigationType.Examine, new devDept.Eyeshot.MouseButton(devDept.Eyeshot.mouseButtonsZPR.Left, devDept.Eyeshot.modifierKeys.None), new devDept.Geometry.Point3D(-1000D, -1000D, -1000D), new devDept.Geometry.Point3D(1000D, 1000D, 1000D), 8D, 50D, 50D);
            devDept.Eyeshot.Viewport.SavedViewsManager savedViewsManager1 = new devDept.Eyeshot.Viewport.SavedViewsManager(8);
            devDept.Eyeshot.Viewport viewport1 = new devDept.Eyeshot.Viewport(new System.Drawing.Point(0, 0), new System.Drawing.Size(909, 747), backgroundSettings1, camera1, new devDept.Eyeshot.ToolBar[] {
            toolBar1}, devDept.Eyeshot.displayType.Rendered, true, false, false, false, new devDept.Eyeshot.Grid[] {
            grid1}, false, rotateSettings1, zoomSettings1, panSettings1, navigationSettings1, savedViewsManager1, devDept.Eyeshot.viewType.Trimetric);
            devDept.Eyeshot.CoordinateSystemIcon coordinateSystemIcon1 = new devDept.Eyeshot.CoordinateSystemIcon(System.Drawing.Color.Black, System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80))))), System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80))))), System.Drawing.Color.OrangeRed, "Origin", "X", "Y", "Z", true, devDept.Eyeshot.coordinateSystemPositionType.BottomLeft, 37, false);
            devDept.Eyeshot.Legend legend1 = new devDept.Eyeshot.Legend(0D, 100D, "Title", "Subtitle", new System.Drawing.Point(24, 24), new System.Drawing.Size(10, 30), true, false, false, "{0:0.##}", System.Drawing.Color.Transparent, System.Drawing.Color.Black, System.Drawing.Color.Black, new System.Drawing.Color[] {
            System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(255))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(255))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(255))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(191))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(127))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(63))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(255)))), ((int)(((byte)(0))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(255)))), ((int)(((byte)(0))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(255)))), ((int)(((byte)(0))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(63)))), ((int)(((byte)(0))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))))}, false, false);
            devDept.Eyeshot.OriginSymbol originSymbol1 = new devDept.Eyeshot.OriginSymbol(10, devDept.Eyeshot.originSymbolStyleType.Ball, System.Drawing.Color.Black, System.Drawing.Color.Red, System.Drawing.Color.Green, System.Drawing.Color.Blue, "Origin", "X", "Y", "Z", true, null, false);
            devDept.Eyeshot.ViewCubeIcon viewCubeIcon1 = new devDept.Eyeshot.ViewCubeIcon(devDept.Eyeshot.coordinateSystemPositionType.TopRight, true, System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(20)))), ((int)(((byte)(147))))), true, "FRONT", "BACK", "LEFT", "RIGHT", "TOP", "BOTTOM", System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), 'S', 'N', 'W', 'E', true, System.Drawing.Color.White, System.Drawing.Color.Black, 120, true, true, null, null, null, null, null, null, false);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.mainStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.springToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.readWriteProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.rendererVersionStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.selectedCountStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.addedCountStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.removedCountStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.zoomSelButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.layerListView = new System.Windows.Forms.ListView();
            this.layerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.layerColor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.objectPropsLabel = new System.Windows.Forms.Label();
            this.layersLabel = new System.Windows.Forms.Label();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.exportButton = new System.Windows.Forms.Button();
            this.regenAsyncButton = new System.Windows.Forms.CheckBox();
            this.transformButton = new System.Windows.Forms.Button();
            this.zoomFitButton = new System.Windows.Forms.Button();
            this.zoomWindowButton = new System.Windows.Forms.CheckBox();
            this.rotateButton = new System.Windows.Forms.CheckBox();
            this.panButton = new System.Windows.Forms.CheckBox();
            this.zoomButton = new System.Windows.Forms.CheckBox();
            this.openCurrentCheckBox = new System.Windows.Forms.CheckBox();
            this.selectionFilterComboBox = new System.Windows.Forms.ComboBox();
            this.clearCurrentButton = new System.Windows.Forms.Button();
            this.setCurrentButton = new System.Windows.Forms.Button();
            this.statisticsButton = new System.Windows.Forms.Button();
            this.clipBox = new System.Windows.Forms.CheckBox();
            this.magGlassCheckBox = new System.Windows.Forms.CheckBox();
            this.flatButton = new System.Windows.Forms.RadioButton();
            this.selectCheckBox = new System.Windows.Forms.CheckBox();
            this.selectionComboBox = new System.Windows.Forms.ComboBox();
            this.animateCameraCheckBox = new System.Windows.Forms.CheckBox();
            this.topViewButton = new System.Windows.Forms.Button();
            this.sideViewButton = new System.Windows.Forms.Button();
            this.frontViewButton = new System.Windows.Forms.Button();
            this.isoViewButton = new System.Windows.Forms.Button();
            this.importButton = new System.Windows.Forms.Button();
            this.viewLabel = new System.Windows.Forms.Label();
            this.groupButton = new System.Windows.Forms.Button();
            this.explodeButton = new System.Windows.Forms.Button();
            this.showCurveDirectionButton = new System.Windows.Forms.CheckBox();
            this.miscLabel = new System.Windows.Forms.Label();
            this.vectorLabel = new System.Windows.Forms.Label();
            this.vectorSaveButton = new System.Windows.Forms.Button();
            this.vectorCopyToClipbardButton = new System.Windows.Forms.Button();
            this.dumpButton = new System.Windows.Forms.Button();
            this.rotateToFaceButton = new System.Windows.Forms.CheckBox();
            this.zoomSelectionButton = new System.Windows.Forms.Button();
            this.hiddenLinesButton = new System.Windows.Forms.RadioButton();
            this.showGridButton = new System.Windows.Forms.CheckBox();
            this.cullingButton = new System.Windows.Forms.CheckBox();
            this.pickFaceButton = new System.Windows.Forms.CheckBox();
            this.renderedButton = new System.Windows.Forms.RadioButton();
            this.pickVertexButton = new System.Windows.Forms.CheckBox();
            this.shadedButton = new System.Windows.Forms.RadioButton();
            this.inspectionLabel = new System.Windows.Forms.Label();
            this.wireframeButton = new System.Windows.Forms.RadioButton();
            this.untrimButton = new System.Windows.Forms.Button();
            this.imagingLabel = new System.Windows.Forms.Label();
            this.editingLabel = new System.Windows.Forms.Label();
            this.selectionLabel = new System.Windows.Forms.Label();
            this.hideShowLabel = new System.Windows.Forms.Label();
            this.zprLabel = new System.Windows.Forms.Label();
            this.projectionLabel = new System.Windows.Forms.Label();
            this.shadingLabel = new System.Windows.Forms.Label();
            this.pageSetupButton = new System.Windows.Forms.Button();
            this.printButton = new System.Windows.Forms.Button();
            this.rasterSaveButton = new System.Windows.Forms.Button();
            this.rasterCopyToClipboardButton = new System.Windows.Forms.Button();
            this.showVerticesButton = new System.Windows.Forms.CheckBox();
            this.showExtentsButton = new System.Windows.Forms.CheckBox();
            this.showOriginButton = new System.Windows.Forms.CheckBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.duplicateButton = new System.Windows.Forms.Button();
            this.invertSelectionButton = new System.Windows.Forms.Button();
            this.clearSelectionButton = new System.Windows.Forms.Button();
            this.prevViewButton = new System.Windows.Forms.Button();
            this.nextViewButton = new System.Windows.Forms.Button();
            this.perspectiveButton = new System.Windows.Forms.RadioButton();
            this.parallelButton = new System.Windows.Forms.RadioButton();
            this.printPreviewButton = new System.Windows.Forms.Button();
            this.volumeButton = new System.Windows.Forms.Button();
            this.areaButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.model1 = new devDept.Eyeshot.Model();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.model1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainStatusLabel,
            this.springToolStripStatusLabel,
            this.readWriteProgressBar,
            this.rendererVersionStatusLabel,
            this.selectedCountStatusLabel,
            this.addedCountStatusLabel,
            this.removedCountStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 772);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.ShowItemToolTips = true;
            this.statusStrip1.Size = new System.Drawing.Size(1263, 23);
            this.statusStrip1.TabIndex = 53;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // mainStatusLabel
            // 
            this.mainStatusLabel.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.mainStatusLabel.ForeColor = System.Drawing.Color.White;
            this.mainStatusLabel.Name = "mainStatusLabel";
            this.mainStatusLabel.Size = new System.Drawing.Size(667, 18);
            this.mainStatusLabel.Text = "Nhấn giữ chuột giữa để xoay , nhấn ctrl+chuột giữa để di chuyển. nhấn shift+ chuộ" +
    "t giữa để zoom, di chuột giữa để thu phóng";
            this.mainStatusLabel.ToolTipText = "Nhấn giữ chuột giữa để xoay , nhấn ctrl+chuột giữa để di chuyển. nhấn shift+ chuộ" +
    "t giữa để zoom, di chuột giữa để thu phóng";
            // 
            // springToolStripStatusLabel
            // 
            this.springToolStripStatusLabel.Name = "springToolStripStatusLabel";
            this.springToolStripStatusLabel.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.springToolStripStatusLabel.Size = new System.Drawing.Size(305, 18);
            this.springToolStripStatusLabel.Spring = true;
            // 
            // readWriteProgressBar
            // 
            this.readWriteProgressBar.Name = "readWriteProgressBar";
            this.readWriteProgressBar.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.readWriteProgressBar.Size = new System.Drawing.Size(105, 17);
            this.readWriteProgressBar.Visible = false;
            // 
            // rendererVersionStatusLabel
            // 
            this.rendererVersionStatusLabel.AutoSize = false;
            this.rendererVersionStatusLabel.AutoToolTip = true;
            this.rendererVersionStatusLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.rendererVersionStatusLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.rendererVersionStatusLabel.Margin = new System.Windows.Forms.Padding(0, 3, 5, 2);
            this.rendererVersionStatusLabel.Name = "rendererVersionStatusLabel";
            this.rendererVersionStatusLabel.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.rendererVersionStatusLabel.Size = new System.Drawing.Size(64, 18);
            this.rendererVersionStatusLabel.Text = "1.0";
            this.rendererVersionStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rendererVersionStatusLabel.ToolTipText = "Renderer Version";
            // 
            // selectedCountStatusLabel
            // 
            this.selectedCountStatusLabel.AutoSize = false;
            this.selectedCountStatusLabel.AutoToolTip = true;
            this.selectedCountStatusLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.selectedCountStatusLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.selectedCountStatusLabel.Margin = new System.Windows.Forms.Padding(0, 3, 5, 2);
            this.selectedCountStatusLabel.Name = "selectedCountStatusLabel";
            this.selectedCountStatusLabel.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.selectedCountStatusLabel.Size = new System.Drawing.Size(64, 18);
            this.selectedCountStatusLabel.Text = "0";
            this.selectedCountStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.selectedCountStatusLabel.ToolTipText = "Selected count";
            // 
            // addedCountStatusLabel
            // 
            this.addedCountStatusLabel.AutoSize = false;
            this.addedCountStatusLabel.AutoToolTip = true;
            this.addedCountStatusLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.addedCountStatusLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.addedCountStatusLabel.Margin = new System.Windows.Forms.Padding(0, 3, 5, 2);
            this.addedCountStatusLabel.Name = "addedCountStatusLabel";
            this.addedCountStatusLabel.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.addedCountStatusLabel.Size = new System.Drawing.Size(64, 18);
            this.addedCountStatusLabel.Text = "0";
            this.addedCountStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addedCountStatusLabel.ToolTipText = "Added to selection count";
            // 
            // removedCountStatusLabel
            // 
            this.removedCountStatusLabel.AutoSize = false;
            this.removedCountStatusLabel.AutoToolTip = true;
            this.removedCountStatusLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(169)))), ((int)(((byte)(175)))));
            this.removedCountStatusLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.removedCountStatusLabel.Margin = new System.Windows.Forms.Padding(0, 3, 5, 2);
            this.removedCountStatusLabel.Name = "removedCountStatusLabel";
            this.removedCountStatusLabel.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.removedCountStatusLabel.Size = new System.Drawing.Size(64, 18);
            this.removedCountStatusLabel.Text = "0";
            this.removedCountStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.removedCountStatusLabel.ToolTipText = "Removed from selection count";
            // 
            // zoomSelButton
            // 
            this.zoomSelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.zoomSelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.zoomSelButton.Location = new System.Drawing.Point(582, 202);
            this.zoomSelButton.Name = "zoomSelButton";
            this.zoomSelButton.Size = new System.Drawing.Size(78, 22);
            this.zoomSelButton.TabIndex = 82;
            this.zoomSelButton.Text = "Zoom Sel.";
            this.zoomSelButton.UseVisualStyleBackColor = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::WindowsApplication1.Properties.Resources.open;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Mở";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::WindowsApplication1.Properties.Resources.diskette;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Xuất";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Silver;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1263, 25);
            this.toolStrip1.TabIndex = 140;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.exportButton);
            this.panel1.Controls.Add(this.regenAsyncButton);
            this.panel1.Controls.Add(this.transformButton);
            this.panel1.Controls.Add(this.zoomFitButton);
            this.panel1.Controls.Add(this.zoomWindowButton);
            this.panel1.Controls.Add(this.rotateButton);
            this.panel1.Controls.Add(this.panButton);
            this.panel1.Controls.Add(this.zoomButton);
            this.panel1.Controls.Add(this.openCurrentCheckBox);
            this.panel1.Controls.Add(this.selectionFilterComboBox);
            this.panel1.Controls.Add(this.clearCurrentButton);
            this.panel1.Controls.Add(this.setCurrentButton);
            this.panel1.Controls.Add(this.statisticsButton);
            this.panel1.Controls.Add(this.clipBox);
            this.panel1.Controls.Add(this.magGlassCheckBox);
            this.panel1.Controls.Add(this.flatButton);
            this.panel1.Controls.Add(this.selectCheckBox);
            this.panel1.Controls.Add(this.selectionComboBox);
            this.panel1.Controls.Add(this.animateCameraCheckBox);
            this.panel1.Controls.Add(this.topViewButton);
            this.panel1.Controls.Add(this.sideViewButton);
            this.panel1.Controls.Add(this.frontViewButton);
            this.panel1.Controls.Add(this.isoViewButton);
            this.panel1.Controls.Add(this.importButton);
            this.panel1.Controls.Add(this.viewLabel);
            this.panel1.Controls.Add(this.groupButton);
            this.panel1.Controls.Add(this.explodeButton);
            this.panel1.Controls.Add(this.showCurveDirectionButton);
            this.panel1.Controls.Add(this.miscLabel);
            this.panel1.Controls.Add(this.vectorLabel);
            this.panel1.Controls.Add(this.vectorSaveButton);
            this.panel1.Controls.Add(this.vectorCopyToClipbardButton);
            this.panel1.Controls.Add(this.dumpButton);
            this.panel1.Controls.Add(this.rotateToFaceButton);
            this.panel1.Controls.Add(this.zoomSelectionButton);
            this.panel1.Controls.Add(this.hiddenLinesButton);
            this.panel1.Controls.Add(this.showGridButton);
            this.panel1.Controls.Add(this.cullingButton);
            this.panel1.Controls.Add(this.pickFaceButton);
            this.panel1.Controls.Add(this.renderedButton);
            this.panel1.Controls.Add(this.pickVertexButton);
            this.panel1.Controls.Add(this.shadedButton);
            this.panel1.Controls.Add(this.inspectionLabel);
            this.panel1.Controls.Add(this.wireframeButton);
            this.panel1.Controls.Add(this.untrimButton);
            this.panel1.Controls.Add(this.imagingLabel);
            this.panel1.Controls.Add(this.editingLabel);
            this.panel1.Controls.Add(this.selectionLabel);
            this.panel1.Controls.Add(this.hideShowLabel);
            this.panel1.Controls.Add(this.zprLabel);
            this.panel1.Controls.Add(this.projectionLabel);
            this.panel1.Controls.Add(this.shadingLabel);
            this.panel1.Controls.Add(this.pageSetupButton);
            this.panel1.Controls.Add(this.printButton);
            this.panel1.Controls.Add(this.rasterSaveButton);
            this.panel1.Controls.Add(this.rasterCopyToClipboardButton);
            this.panel1.Controls.Add(this.showVerticesButton);
            this.panel1.Controls.Add(this.showExtentsButton);
            this.panel1.Controls.Add(this.showOriginButton);
            this.panel1.Controls.Add(this.deleteButton);
            this.panel1.Controls.Add(this.duplicateButton);
            this.panel1.Controls.Add(this.invertSelectionButton);
            this.panel1.Controls.Add(this.clearSelectionButton);
            this.panel1.Controls.Add(this.prevViewButton);
            this.panel1.Controls.Add(this.nextViewButton);
            this.panel1.Controls.Add(this.perspectiveButton);
            this.panel1.Controls.Add(this.parallelButton);
            this.panel1.Controls.Add(this.printPreviewButton);
            this.panel1.Controls.Add(this.volumeButton);
            this.panel1.Controls.Add(this.areaButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(909, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(354, 747);
            this.panel1.TabIndex = 141;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.layerListView);
            this.panel3.Controls.Add(this.objectPropsLabel);
            this.panel3.Controls.Add(this.layersLabel);
            this.panel3.Controls.Add(this.propertyGrid1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 733);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(337, 84);
            this.panel3.TabIndex = 210;
            // 
            // layerListView
            // 
            this.layerListView.CheckBoxes = true;
            this.layerListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.layerName,
            this.layerColor});
            this.layerListView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.layerListView.HideSelection = false;
            this.layerListView.Location = new System.Drawing.Point(0, 19);
            this.layerListView.Name = "layerListView";
            this.layerListView.Size = new System.Drawing.Size(337, 65);
            this.layerListView.TabIndex = 82;
            this.layerListView.UseCompatibleStateImageBehavior = false;
            this.layerListView.View = System.Windows.Forms.View.Details;
            // 
            // layerName
            // 
            this.layerName.Text = "Name";
            this.layerName.Width = 100;
            // 
            // layerColor
            // 
            this.layerColor.Text = "Color";
            this.layerColor.Width = 80;
            // 
            // objectPropsLabel
            // 
            this.objectPropsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.objectPropsLabel.AutoSize = true;
            this.objectPropsLabel.ForeColor = System.Drawing.Color.Black;
            this.objectPropsLabel.Location = new System.Drawing.Point(182, 3);
            this.objectPropsLabel.Name = "objectPropsLabel";
            this.objectPropsLabel.Size = new System.Drawing.Size(129, 13);
            this.objectPropsLabel.TabIndex = 81;
            this.objectPropsLabel.Text = "Thuộc tính của đối tượng";
            // 
            // layersLabel
            // 
            this.layersLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.layersLabel.AutoSize = true;
            this.layersLabel.ForeColor = System.Drawing.Color.Black;
            this.layersLabel.Location = new System.Drawing.Point(12, 3);
            this.layersLabel.Name = "layersLabel";
            this.layersLabel.Size = new System.Drawing.Size(38, 13);
            this.layersLabel.TabIndex = 80;
            this.layersLabel.Text = "Layers";
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.propertyGrid1.CategoryForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.propertyGrid1.HelpVisible = false;
            this.propertyGrid1.LineColor = System.Drawing.SystemColors.ControlDark;
            this.propertyGrid1.Location = new System.Drawing.Point(203, 59);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(858, 22);
            this.propertyGrid1.TabIndex = 79;
            this.propertyGrid1.ToolbarVisible = false;
            // 
            // exportButton
            // 
            this.exportButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exportButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.exportButton.FlatAppearance.BorderSize = 0;
            this.exportButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.exportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exportButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportButton.ForeColor = System.Drawing.Color.White;
            this.exportButton.Location = new System.Drawing.Point(179, 711);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(78, 22);
            this.exportButton.TabIndex = 209;
            this.exportButton.Text = "Xuất";
            this.exportButton.UseVisualStyleBackColor = false;
            // 
            // regenAsyncButton
            // 
            this.regenAsyncButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.regenAsyncButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.regenAsyncButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.regenAsyncButton.FlatAppearance.BorderSize = 0;
            this.regenAsyncButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.regenAsyncButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regenAsyncButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regenAsyncButton.ForeColor = System.Drawing.Color.White;
            this.regenAsyncButton.Location = new System.Drawing.Point(95, 711);
            this.regenAsyncButton.Name = "regenAsyncButton";
            this.regenAsyncButton.Size = new System.Drawing.Size(78, 22);
            this.regenAsyncButton.TabIndex = 208;
            this.regenAsyncButton.Text = "Đồng bộ hóa";
            this.regenAsyncButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.regenAsyncButton.UseVisualStyleBackColor = false;
            // 
            // transformButton
            // 
            this.transformButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.transformButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.transformButton.FlatAppearance.BorderSize = 0;
            this.transformButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.transformButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transformButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transformButton.ForeColor = System.Drawing.Color.White;
            this.transformButton.Location = new System.Drawing.Point(13, 458);
            this.transformButton.Name = "transformButton";
            this.transformButton.Size = new System.Drawing.Size(78, 22);
            this.transformButton.TabIndex = 207;
            this.transformButton.Text = "Transform";
            this.transformButton.UseVisualStyleBackColor = false;
            // 
            // zoomFitButton
            // 
            this.zoomFitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.zoomFitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.zoomFitButton.FlatAppearance.BorderSize = 0;
            this.zoomFitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.zoomFitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zoomFitButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zoomFitButton.ForeColor = System.Drawing.Color.White;
            this.zoomFitButton.Location = new System.Drawing.Point(13, 173);
            this.zoomFitButton.Name = "zoomFitButton";
            this.zoomFitButton.Size = new System.Drawing.Size(78, 23);
            this.zoomFitButton.TabIndex = 206;
            this.zoomFitButton.Text = "Zoom Fit";
            this.zoomFitButton.UseVisualStyleBackColor = false;
            this.zoomFitButton.Click += new System.EventHandler(this.zoomFitButton_OnClick);
            // 
            // zoomWindowButton
            // 
            this.zoomWindowButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.zoomWindowButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.zoomWindowButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.zoomWindowButton.FlatAppearance.BorderSize = 0;
            this.zoomWindowButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.zoomWindowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zoomWindowButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zoomWindowButton.ForeColor = System.Drawing.Color.White;
            this.zoomWindowButton.Location = new System.Drawing.Point(259, 147);
            this.zoomWindowButton.Name = "zoomWindowButton";
            this.zoomWindowButton.Size = new System.Drawing.Size(78, 22);
            this.zoomWindowButton.TabIndex = 205;
            this.zoomWindowButton.Text = "Zoom Win.";
            this.zoomWindowButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.zoomWindowButton.UseVisualStyleBackColor = false;
            this.zoomWindowButton.Click += new System.EventHandler(this.zoomWindowButton_OnClick);
            // 
            // rotateButton
            // 
            this.rotateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rotateButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.rotateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rotateButton.FlatAppearance.BorderSize = 0;
            this.rotateButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.rotateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rotateButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rotateButton.ForeColor = System.Drawing.Color.White;
            this.rotateButton.Location = new System.Drawing.Point(177, 147);
            this.rotateButton.Name = "rotateButton";
            this.rotateButton.Size = new System.Drawing.Size(78, 22);
            this.rotateButton.TabIndex = 204;
            this.rotateButton.Text = "Rotate";
            this.rotateButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rotateButton.UseVisualStyleBackColor = false;
            this.rotateButton.Click += new System.EventHandler(this.rotateButton_OnClick);
            // 
            // panButton
            // 
            this.panButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.panButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panButton.FlatAppearance.BorderSize = 0;
            this.panButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.panButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.panButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panButton.ForeColor = System.Drawing.Color.White;
            this.panButton.Location = new System.Drawing.Point(95, 147);
            this.panButton.Name = "panButton";
            this.panButton.Size = new System.Drawing.Size(78, 22);
            this.panButton.TabIndex = 203;
            this.panButton.Text = "Pan";
            this.panButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.panButton.UseVisualStyleBackColor = false;
            this.panButton.Click += new System.EventHandler(this.panButton_OnClick);
            // 
            // zoomButton
            // 
            this.zoomButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.zoomButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.zoomButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.zoomButton.FlatAppearance.BorderSize = 0;
            this.zoomButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.zoomButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zoomButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zoomButton.ForeColor = System.Drawing.Color.White;
            this.zoomButton.Location = new System.Drawing.Point(13, 147);
            this.zoomButton.Name = "zoomButton";
            this.zoomButton.Size = new System.Drawing.Size(78, 22);
            this.zoomButton.TabIndex = 202;
            this.zoomButton.Text = "Zoom";
            this.zoomButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.zoomButton.UseVisualStyleBackColor = false;
            this.zoomButton.Click += new System.EventHandler(this.zoomButton_OnClick);
            // 
            // openCurrentCheckBox
            // 
            this.openCurrentCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.openCurrentCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.openCurrentCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.openCurrentCheckBox.FlatAppearance.BorderSize = 0;
            this.openCurrentCheckBox.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.openCurrentCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openCurrentCheckBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openCurrentCheckBox.ForeColor = System.Drawing.Color.White;
            this.openCurrentCheckBox.Location = new System.Drawing.Point(178, 386);
            this.openCurrentCheckBox.Name = "openCurrentCheckBox";
            this.openCurrentCheckBox.Size = new System.Drawing.Size(78, 22);
            this.openCurrentCheckBox.TabIndex = 201;
            this.openCurrentCheckBox.Text = "Open Current";
            this.openCurrentCheckBox.UseVisualStyleBackColor = false;
            // 
            // selectionFilterComboBox
            // 
            this.selectionFilterComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selectionFilterComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.selectionFilterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectionFilterComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectionFilterComboBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectionFilterComboBox.ForeColor = System.Drawing.Color.White;
            this.selectionFilterComboBox.Items.AddRange(new object[] {
            "Vertex",
            "Edge",
            "Face",
            "Entity"});
            this.selectionFilterComboBox.Location = new System.Drawing.Point(14, 361);
            this.selectionFilterComboBox.Name = "selectionFilterComboBox";
            this.selectionFilterComboBox.Size = new System.Drawing.Size(158, 21);
            this.selectionFilterComboBox.TabIndex = 200;
            // 
            // clearCurrentButton
            // 
            this.clearCurrentButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clearCurrentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.clearCurrentButton.FlatAppearance.BorderSize = 0;
            this.clearCurrentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.clearCurrentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearCurrentButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearCurrentButton.ForeColor = System.Drawing.Color.White;
            this.clearCurrentButton.Location = new System.Drawing.Point(95, 386);
            this.clearCurrentButton.Name = "clearCurrentButton";
            this.clearCurrentButton.Size = new System.Drawing.Size(78, 22);
            this.clearCurrentButton.TabIndex = 199;
            this.clearCurrentButton.Text = "Clear Curr.";
            this.clearCurrentButton.UseVisualStyleBackColor = false;
            // 
            // setCurrentButton
            // 
            this.setCurrentButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.setCurrentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.setCurrentButton.FlatAppearance.BorderSize = 0;
            this.setCurrentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.setCurrentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setCurrentButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setCurrentButton.ForeColor = System.Drawing.Color.White;
            this.setCurrentButton.Location = new System.Drawing.Point(13, 386);
            this.setCurrentButton.Name = "setCurrentButton";
            this.setCurrentButton.Size = new System.Drawing.Size(78, 22);
            this.setCurrentButton.TabIndex = 198;
            this.setCurrentButton.Text = "Set Current";
            this.setCurrentButton.UseVisualStyleBackColor = false;
            // 
            // statisticsButton
            // 
            this.statisticsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.statisticsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.statisticsButton.FlatAppearance.BorderSize = 0;
            this.statisticsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.statisticsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statisticsButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statisticsButton.ForeColor = System.Drawing.Color.White;
            this.statisticsButton.Location = new System.Drawing.Point(13, 551);
            this.statisticsButton.Name = "statisticsButton";
            this.statisticsButton.Size = new System.Drawing.Size(78, 22);
            this.statisticsButton.TabIndex = 197;
            this.statisticsButton.Text = "Statistics";
            this.statisticsButton.UseVisualStyleBackColor = false;
            // 
            // clipBox
            // 
            this.clipBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clipBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.clipBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.clipBox.FlatAppearance.BorderSize = 0;
            this.clipBox.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.clipBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clipBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clipBox.ForeColor = System.Drawing.Color.White;
            this.clipBox.Location = new System.Drawing.Point(258, 525);
            this.clipBox.Name = "clipBox";
            this.clipBox.Size = new System.Drawing.Size(78, 22);
            this.clipBox.TabIndex = 196;
            this.clipBox.Text = "Clip";
            this.clipBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.clipBox.UseVisualStyleBackColor = false;
            // 
            // magGlassCheckBox
            // 
            this.magGlassCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.magGlassCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.magGlassCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.magGlassCheckBox.FlatAppearance.BorderSize = 0;
            this.magGlassCheckBox.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.magGlassCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.magGlassCheckBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.magGlassCheckBox.ForeColor = System.Drawing.Color.White;
            this.magGlassCheckBox.Location = new System.Drawing.Point(259, 244);
            this.magGlassCheckBox.Name = "magGlassCheckBox";
            this.magGlassCheckBox.Size = new System.Drawing.Size(78, 22);
            this.magGlassCheckBox.TabIndex = 195;
            this.magGlassCheckBox.Text = "Mag. Glass";
            this.magGlassCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.magGlassCheckBox.UseVisualStyleBackColor = false;
            // 
            // flatButton
            // 
            this.flatButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flatButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.flatButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.flatButton.FlatAppearance.BorderSize = 0;
            this.flatButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.flatButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flatButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatButton.ForeColor = System.Drawing.Color.White;
            this.flatButton.Location = new System.Drawing.Point(13, 57);
            this.flatButton.Name = "flatButton";
            this.flatButton.Size = new System.Drawing.Size(78, 22);
            this.flatButton.TabIndex = 194;
            this.flatButton.Text = "Phẳng";
            this.flatButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.flatButton.UseVisualStyleBackColor = false;
            this.flatButton.CheckedChanged += new System.EventHandler(this.flatButton_CheckedChanged);
            // 
            // selectCheckBox
            // 
            this.selectCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selectCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.selectCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.selectCheckBox.FlatAppearance.BorderSize = 0;
            this.selectCheckBox.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.selectCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectCheckBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectCheckBox.ForeColor = System.Drawing.Color.White;
            this.selectCheckBox.Location = new System.Drawing.Point(177, 334);
            this.selectCheckBox.Name = "selectCheckBox";
            this.selectCheckBox.Size = new System.Drawing.Size(78, 22);
            this.selectCheckBox.TabIndex = 193;
            this.selectCheckBox.Text = "Select";
            this.selectCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.selectCheckBox.UseVisualStyleBackColor = false;
            // 
            // selectionComboBox
            // 
            this.selectionComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selectionComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.selectionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectionComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectionComboBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectionComboBox.ForeColor = System.Drawing.Color.White;
            this.selectionComboBox.Items.AddRange(new object[] {
            "by Pick",
            "by Box",
            "by Polygon",
            "by Box Enclosed",
            "by Polygon Enclosed",
            "Visible by Pick",
            "Visible by Box",
            "Visible by Polygon",
            "Visible by Pick Dynamic",
            "Visible by Pick Label"});
            this.selectionComboBox.Location = new System.Drawing.Point(14, 335);
            this.selectionComboBox.Name = "selectionComboBox";
            this.selectionComboBox.Size = new System.Drawing.Size(158, 21);
            this.selectionComboBox.TabIndex = 192;
            // 
            // animateCameraCheckBox
            // 
            this.animateCameraCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.animateCameraCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.animateCameraCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.animateCameraCheckBox.FlatAppearance.BorderSize = 0;
            this.animateCameraCheckBox.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.animateCameraCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.animateCameraCheckBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.animateCameraCheckBox.ForeColor = System.Drawing.Color.White;
            this.animateCameraCheckBox.Location = new System.Drawing.Point(177, 244);
            this.animateCameraCheckBox.Name = "animateCameraCheckBox";
            this.animateCameraCheckBox.Size = new System.Drawing.Size(78, 22);
            this.animateCameraCheckBox.TabIndex = 191;
            this.animateCameraCheckBox.Text = "Animation";
            this.animateCameraCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.animateCameraCheckBox.UseVisualStyleBackColor = false;
            this.animateCameraCheckBox.CheckedChanged += new System.EventHandler(this.animateCameraCheckBox_CheckedChanged);
            // 
            // topViewButton
            // 
            this.topViewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.topViewButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.topViewButton.FlatAppearance.BorderSize = 0;
            this.topViewButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.topViewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.topViewButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topViewButton.ForeColor = System.Drawing.Color.White;
            this.topViewButton.Location = new System.Drawing.Point(177, 218);
            this.topViewButton.Name = "topViewButton";
            this.topViewButton.Size = new System.Drawing.Size(78, 22);
            this.topViewButton.TabIndex = 190;
            this.topViewButton.Text = "Trên";
            this.topViewButton.UseVisualStyleBackColor = false;
            this.topViewButton.Click += new System.EventHandler(this.topViewButton_Click);
            // 
            // sideViewButton
            // 
            this.sideViewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sideViewButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sideViewButton.FlatAppearance.BorderSize = 0;
            this.sideViewButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.sideViewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sideViewButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sideViewButton.ForeColor = System.Drawing.Color.White;
            this.sideViewButton.Location = new System.Drawing.Point(95, 218);
            this.sideViewButton.Name = "sideViewButton";
            this.sideViewButton.Size = new System.Drawing.Size(78, 22);
            this.sideViewButton.TabIndex = 189;
            this.sideViewButton.Text = "Bên";
            this.sideViewButton.UseVisualStyleBackColor = false;
            this.sideViewButton.Click += new System.EventHandler(this.sideViewButton_Click);
            // 
            // frontViewButton
            // 
            this.frontViewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.frontViewButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.frontViewButton.FlatAppearance.BorderSize = 0;
            this.frontViewButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.frontViewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.frontViewButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frontViewButton.ForeColor = System.Drawing.Color.White;
            this.frontViewButton.Location = new System.Drawing.Point(13, 218);
            this.frontViewButton.Name = "frontViewButton";
            this.frontViewButton.Size = new System.Drawing.Size(78, 22);
            this.frontViewButton.TabIndex = 188;
            this.frontViewButton.Text = "Trước";
            this.frontViewButton.UseVisualStyleBackColor = false;
            this.frontViewButton.Click += new System.EventHandler(this.frontViewButton_Click);
            // 
            // isoViewButton
            // 
            this.isoViewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.isoViewButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.isoViewButton.FlatAppearance.BorderSize = 0;
            this.isoViewButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.isoViewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.isoViewButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isoViewButton.ForeColor = System.Drawing.Color.White;
            this.isoViewButton.Location = new System.Drawing.Point(259, 218);
            this.isoViewButton.Name = "isoViewButton";
            this.isoViewButton.Size = new System.Drawing.Size(78, 22);
            this.isoViewButton.TabIndex = 187;
            this.isoViewButton.Text = "Iso";
            this.isoViewButton.UseVisualStyleBackColor = false;
            this.isoViewButton.Click += new System.EventHandler(this.isoViewButton_Click);
            // 
            // importButton
            // 
            this.importButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.importButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.importButton.FlatAppearance.BorderSize = 0;
            this.importButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.importButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.importButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importButton.ForeColor = System.Drawing.Color.White;
            this.importButton.Location = new System.Drawing.Point(14, 711);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(78, 22);
            this.importButton.TabIndex = 186;
            this.importButton.Text = "Mở";
            this.importButton.UseVisualStyleBackColor = false;
            // 
            // viewLabel
            // 
            this.viewLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.viewLabel.AutoSize = true;
            this.viewLabel.ForeColor = System.Drawing.Color.Black;
            this.viewLabel.Location = new System.Drawing.Point(14, 203);
            this.viewLabel.Name = "viewLabel";
            this.viewLabel.Size = new System.Drawing.Size(50, 13);
            this.viewLabel.TabIndex = 178;
            this.viewLabel.Text = "Góc nhìn";
            // 
            // groupButton
            // 
            this.groupButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupButton.FlatAppearance.BorderSize = 0;
            this.groupButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.groupButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupButton.ForeColor = System.Drawing.Color.White;
            this.groupButton.Location = new System.Drawing.Point(259, 360);
            this.groupButton.Name = "groupButton";
            this.groupButton.Size = new System.Drawing.Size(78, 22);
            this.groupButton.TabIndex = 185;
            this.groupButton.Text = "Group";
            this.groupButton.UseVisualStyleBackColor = false;
            // 
            // explodeButton
            // 
            this.explodeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.explodeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.explodeButton.FlatAppearance.BorderSize = 0;
            this.explodeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.explodeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.explodeButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.explodeButton.ForeColor = System.Drawing.Color.White;
            this.explodeButton.Location = new System.Drawing.Point(259, 432);
            this.explodeButton.Name = "explodeButton";
            this.explodeButton.Size = new System.Drawing.Size(78, 22);
            this.explodeButton.TabIndex = 182;
            this.explodeButton.Text = "Explode";
            this.explodeButton.UseVisualStyleBackColor = false;
            // 
            // showCurveDirectionButton
            // 
            this.showCurveDirectionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.showCurveDirectionButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.showCurveDirectionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.showCurveDirectionButton.FlatAppearance.BorderSize = 0;
            this.showCurveDirectionButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.showCurveDirectionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showCurveDirectionButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showCurveDirectionButton.ForeColor = System.Drawing.Color.White;
            this.showCurveDirectionButton.Location = new System.Drawing.Point(95, 525);
            this.showCurveDirectionButton.Name = "showCurveDirectionButton";
            this.showCurveDirectionButton.Size = new System.Drawing.Size(78, 22);
            this.showCurveDirectionButton.TabIndex = 181;
            this.showCurveDirectionButton.Text = "Show Dir.";
            this.showCurveDirectionButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.showCurveDirectionButton.UseVisualStyleBackColor = false;
            // 
            // miscLabel
            // 
            this.miscLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.miscLabel.AutoSize = true;
            this.miscLabel.ForeColor = System.Drawing.Color.Black;
            this.miscLabel.Location = new System.Drawing.Point(14, 695);
            this.miscLabel.Name = "miscLabel";
            this.miscLabel.Size = new System.Drawing.Size(86, 13);
            this.miscLabel.TabIndex = 180;
            this.miscLabel.Text = "Chức năng khác";
            // 
            // vectorLabel
            // 
            this.vectorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.vectorLabel.AutoSize = true;
            this.vectorLabel.ForeColor = System.Drawing.Color.Black;
            this.vectorLabel.Location = new System.Drawing.Point(13, 625);
            this.vectorLabel.Name = "vectorLabel";
            this.vectorLabel.Size = new System.Drawing.Size(63, 13);
            this.vectorLabel.TabIndex = 179;
            this.vectorLabel.Text = "Xuất Vector";
            // 
            // vectorSaveButton
            // 
            this.vectorSaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.vectorSaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.vectorSaveButton.FlatAppearance.BorderSize = 0;
            this.vectorSaveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.vectorSaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vectorSaveButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vectorSaveButton.ForeColor = System.Drawing.Color.White;
            this.vectorSaveButton.Location = new System.Drawing.Point(95, 641);
            this.vectorSaveButton.Name = "vectorSaveButton";
            this.vectorSaveButton.Size = new System.Drawing.Size(78, 22);
            this.vectorSaveButton.TabIndex = 177;
            this.vectorSaveButton.Text = "Lưu";
            this.vectorSaveButton.UseVisualStyleBackColor = false;
            // 
            // vectorCopyToClipbardButton
            // 
            this.vectorCopyToClipbardButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.vectorCopyToClipbardButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.vectorCopyToClipbardButton.FlatAppearance.BorderSize = 0;
            this.vectorCopyToClipbardButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.vectorCopyToClipbardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vectorCopyToClipbardButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vectorCopyToClipbardButton.ForeColor = System.Drawing.Color.White;
            this.vectorCopyToClipbardButton.Location = new System.Drawing.Point(13, 641);
            this.vectorCopyToClipbardButton.Name = "vectorCopyToClipbardButton";
            this.vectorCopyToClipbardButton.Size = new System.Drawing.Size(78, 22);
            this.vectorCopyToClipbardButton.TabIndex = 176;
            this.vectorCopyToClipbardButton.Text = "Sao chép";
            this.vectorCopyToClipbardButton.UseVisualStyleBackColor = false;
            // 
            // dumpButton
            // 
            this.dumpButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dumpButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dumpButton.FlatAppearance.BorderSize = 0;
            this.dumpButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.dumpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dumpButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dumpButton.ForeColor = System.Drawing.Color.White;
            this.dumpButton.Location = new System.Drawing.Point(13, 525);
            this.dumpButton.Name = "dumpButton";
            this.dumpButton.Size = new System.Drawing.Size(78, 22);
            this.dumpButton.TabIndex = 175;
            this.dumpButton.Text = "Dump";
            this.dumpButton.UseVisualStyleBackColor = false;
            // 
            // rotateToFaceButton
            // 
            this.rotateToFaceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rotateToFaceButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.rotateToFaceButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rotateToFaceButton.FlatAppearance.BorderSize = 0;
            this.rotateToFaceButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.rotateToFaceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rotateToFaceButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rotateToFaceButton.ForeColor = System.Drawing.Color.White;
            this.rotateToFaceButton.Location = new System.Drawing.Point(95, 173);
            this.rotateToFaceButton.Name = "rotateToFaceButton";
            this.rotateToFaceButton.Size = new System.Drawing.Size(78, 22);
            this.rotateToFaceButton.TabIndex = 174;
            this.rotateToFaceButton.Text = "Rot. To Face";
            this.rotateToFaceButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rotateToFaceButton.UseVisualStyleBackColor = false;
            this.rotateToFaceButton.Click += new System.EventHandler(this.rotateToFaceButton_CheckedChanged);
            // 
            // zoomSelectionButton
            // 
            this.zoomSelectionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.zoomSelectionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.zoomSelectionButton.FlatAppearance.BorderSize = 0;
            this.zoomSelectionButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.zoomSelectionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zoomSelectionButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zoomSelectionButton.ForeColor = System.Drawing.Color.White;
            this.zoomSelectionButton.Location = new System.Drawing.Point(177, 173);
            this.zoomSelectionButton.Name = "zoomSelectionButton";
            this.zoomSelectionButton.Size = new System.Drawing.Size(78, 22);
            this.zoomSelectionButton.TabIndex = 173;
            this.zoomSelectionButton.Text = "Zoom Sel.";
            this.zoomSelectionButton.UseVisualStyleBackColor = false;
            this.zoomSelectionButton.Click += new System.EventHandler(this.zoomSelectionButton_Click);
            // 
            // hiddenLinesButton
            // 
            this.hiddenLinesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.hiddenLinesButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.hiddenLinesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.hiddenLinesButton.FlatAppearance.BorderSize = 0;
            this.hiddenLinesButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.hiddenLinesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hiddenLinesButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hiddenLinesButton.ForeColor = System.Drawing.Color.White;
            this.hiddenLinesButton.Location = new System.Drawing.Point(259, 31);
            this.hiddenLinesButton.Name = "hiddenLinesButton";
            this.hiddenLinesButton.Size = new System.Drawing.Size(78, 22);
            this.hiddenLinesButton.TabIndex = 172;
            this.hiddenLinesButton.Text = "Ẩn đường Line";
            this.hiddenLinesButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.hiddenLinesButton.UseVisualStyleBackColor = false;
            this.hiddenLinesButton.CheckedChanged += new System.EventHandler(this.hiddenLinesButton_CheckedChanged);
            // 
            // showGridButton
            // 
            this.showGridButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.showGridButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.showGridButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.showGridButton.Checked = true;
            this.showGridButton.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showGridButton.FlatAppearance.BorderSize = 0;
            this.showGridButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.showGridButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showGridButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showGridButton.ForeColor = System.Drawing.Color.White;
            this.showGridButton.Location = new System.Drawing.Point(259, 289);
            this.showGridButton.Name = "showGridButton";
            this.showGridButton.Size = new System.Drawing.Size(78, 22);
            this.showGridButton.TabIndex = 171;
            this.showGridButton.Text = "Grid";
            this.showGridButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.showGridButton.UseVisualStyleBackColor = false;
            // 
            // cullingButton
            // 
            this.cullingButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cullingButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.cullingButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cullingButton.FlatAppearance.BorderSize = 0;
            this.cullingButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.cullingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cullingButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cullingButton.ForeColor = System.Drawing.Color.White;
            this.cullingButton.Location = new System.Drawing.Point(177, 525);
            this.cullingButton.Name = "cullingButton";
            this.cullingButton.Size = new System.Drawing.Size(78, 22);
            this.cullingButton.TabIndex = 144;
            this.cullingButton.Text = "Culling";
            this.cullingButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cullingButton.UseVisualStyleBackColor = false;
            // 
            // pickFaceButton
            // 
            this.pickFaceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pickFaceButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.pickFaceButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pickFaceButton.FlatAppearance.BorderSize = 0;
            this.pickFaceButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.pickFaceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pickFaceButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pickFaceButton.ForeColor = System.Drawing.Color.White;
            this.pickFaceButton.Location = new System.Drawing.Point(95, 499);
            this.pickFaceButton.Name = "pickFaceButton";
            this.pickFaceButton.Size = new System.Drawing.Size(78, 22);
            this.pickFaceButton.TabIndex = 170;
            this.pickFaceButton.Text = "Pick Face";
            this.pickFaceButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pickFaceButton.UseVisualStyleBackColor = false;
            // 
            // renderedButton
            // 
            this.renderedButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.renderedButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.renderedButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.renderedButton.Checked = true;
            this.renderedButton.FlatAppearance.BorderSize = 0;
            this.renderedButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.renderedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.renderedButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.renderedButton.ForeColor = System.Drawing.Color.White;
            this.renderedButton.Location = new System.Drawing.Point(177, 31);
            this.renderedButton.Name = "renderedButton";
            this.renderedButton.Size = new System.Drawing.Size(78, 22);
            this.renderedButton.TabIndex = 143;
            this.renderedButton.TabStop = true;
            this.renderedButton.Text = "Kết xuất";
            this.renderedButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.renderedButton.UseVisualStyleBackColor = false;
            this.renderedButton.CheckedChanged += new System.EventHandler(this.renderedButton_CheckedChanged);
            // 
            // pickVertexButton
            // 
            this.pickVertexButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pickVertexButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.pickVertexButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pickVertexButton.FlatAppearance.BorderSize = 0;
            this.pickVertexButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.pickVertexButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pickVertexButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pickVertexButton.ForeColor = System.Drawing.Color.White;
            this.pickVertexButton.Location = new System.Drawing.Point(13, 499);
            this.pickVertexButton.Name = "pickVertexButton";
            this.pickVertexButton.Size = new System.Drawing.Size(78, 22);
            this.pickVertexButton.TabIndex = 169;
            this.pickVertexButton.Text = "Pick Vertex";
            this.pickVertexButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pickVertexButton.UseVisualStyleBackColor = false;
            // 
            // shadedButton
            // 
            this.shadedButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.shadedButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.shadedButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.shadedButton.FlatAppearance.BorderSize = 0;
            this.shadedButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.shadedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shadedButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shadedButton.ForeColor = System.Drawing.Color.White;
            this.shadedButton.Location = new System.Drawing.Point(95, 31);
            this.shadedButton.Name = "shadedButton";
            this.shadedButton.Size = new System.Drawing.Size(78, 22);
            this.shadedButton.TabIndex = 142;
            this.shadedButton.Text = "Bóng";
            this.shadedButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.shadedButton.UseVisualStyleBackColor = false;
            this.shadedButton.CheckedChanged += new System.EventHandler(this.shadedButton_CheckedChanged);
            // 
            // inspectionLabel
            // 
            this.inspectionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inspectionLabel.AutoSize = true;
            this.inspectionLabel.ForeColor = System.Drawing.Color.Black;
            this.inspectionLabel.Location = new System.Drawing.Point(13, 483);
            this.inspectionLabel.Name = "inspectionLabel";
            this.inspectionLabel.Size = new System.Drawing.Size(155, 13);
            this.inspectionLabel.TabIndex = 168;
            this.inspectionLabel.Text = "Kiểm tra/Thuộc tính khối lượng";
            // 
            // wireframeButton
            // 
            this.wireframeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.wireframeButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.wireframeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.wireframeButton.FlatAppearance.BorderSize = 0;
            this.wireframeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.wireframeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wireframeButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wireframeButton.ForeColor = System.Drawing.Color.White;
            this.wireframeButton.Location = new System.Drawing.Point(13, 31);
            this.wireframeButton.Name = "wireframeButton";
            this.wireframeButton.Size = new System.Drawing.Size(78, 22);
            this.wireframeButton.TabIndex = 141;
            this.wireframeButton.Text = "Lưới";
            this.wireframeButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.wireframeButton.UseVisualStyleBackColor = false;
            this.wireframeButton.CheckedChanged += new System.EventHandler(this.wireframeButton_CheckedChanged);
            // 
            // untrimButton
            // 
            this.untrimButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.untrimButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.untrimButton.FlatAppearance.BorderSize = 0;
            this.untrimButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.untrimButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.untrimButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.untrimButton.ForeColor = System.Drawing.Color.White;
            this.untrimButton.Location = new System.Drawing.Point(177, 432);
            this.untrimButton.Name = "untrimButton";
            this.untrimButton.Size = new System.Drawing.Size(78, 22);
            this.untrimButton.TabIndex = 167;
            this.untrimButton.Text = "Untrim";
            this.untrimButton.UseVisualStyleBackColor = false;
            // 
            // imagingLabel
            // 
            this.imagingLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imagingLabel.AutoSize = true;
            this.imagingLabel.ForeColor = System.Drawing.Color.Black;
            this.imagingLabel.Location = new System.Drawing.Point(13, 580);
            this.imagingLabel.Name = "imagingLabel";
            this.imagingLabel.Size = new System.Drawing.Size(50, 13);
            this.imagingLabel.TabIndex = 166;
            this.imagingLabel.Text = "Xuất ảnh";
            // 
            // editingLabel
            // 
            this.editingLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editingLabel.AutoSize = true;
            this.editingLabel.ForeColor = System.Drawing.Color.Black;
            this.editingLabel.Location = new System.Drawing.Point(13, 416);
            this.editingLabel.Name = "editingLabel";
            this.editingLabel.Size = new System.Drawing.Size(57, 13);
            this.editingLabel.TabIndex = 165;
            this.editingLabel.Text = "Tinh chỉnh";
            // 
            // selectionLabel
            // 
            this.selectionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selectionLabel.AutoSize = true;
            this.selectionLabel.ForeColor = System.Drawing.Color.Black;
            this.selectionLabel.Location = new System.Drawing.Point(13, 318);
            this.selectionLabel.Name = "selectionLabel";
            this.selectionLabel.Size = new System.Drawing.Size(59, 13);
            this.selectionLabel.TabIndex = 164;
            this.selectionLabel.Text = "Vùng chọn";
            // 
            // hideShowLabel
            // 
            this.hideShowLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.hideShowLabel.AutoSize = true;
            this.hideShowLabel.ForeColor = System.Drawing.Color.Black;
            this.hideShowLabel.Location = new System.Drawing.Point(13, 273);
            this.hideShowLabel.Name = "hideShowLabel";
            this.hideShowLabel.Size = new System.Drawing.Size(121, 13);
            this.hideShowLabel.TabIndex = 163;
            this.hideShowLabel.Text = "Ẩn hiện các thành phần";
            // 
            // zprLabel
            // 
            this.zprLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.zprLabel.AutoSize = true;
            this.zprLabel.ForeColor = System.Drawing.Color.Black;
            this.zprLabel.Location = new System.Drawing.Point(13, 131);
            this.zprLabel.Name = "zprLabel";
            this.zprLabel.Size = new System.Drawing.Size(124, 13);
            this.zprLabel.TabIndex = 162;
            this.zprLabel.Text = "Phóng to/Thu nhỏ/Xoay";
            // 
            // projectionLabel
            // 
            this.projectionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.projectionLabel.AutoSize = true;
            this.projectionLabel.ForeColor = System.Drawing.Color.Black;
            this.projectionLabel.Location = new System.Drawing.Point(13, 86);
            this.projectionLabel.Name = "projectionLabel";
            this.projectionLabel.Size = new System.Drawing.Size(61, 13);
            this.projectionLabel.TabIndex = 161;
            this.projectionLabel.Text = "Phép chiếu";
            // 
            // shadingLabel
            // 
            this.shadingLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.shadingLabel.AutoSize = true;
            this.shadingLabel.ForeColor = System.Drawing.Color.Black;
            this.shadingLabel.Location = new System.Drawing.Point(13, 15);
            this.shadingLabel.Name = "shadingLabel";
            this.shadingLabel.Size = new System.Drawing.Size(32, 13);
            this.shadingLabel.TabIndex = 160;
            this.shadingLabel.Text = "Bóng";
            // 
            // pageSetupButton
            // 
            this.pageSetupButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pageSetupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pageSetupButton.FlatAppearance.BorderSize = 0;
            this.pageSetupButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.pageSetupButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pageSetupButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageSetupButton.ForeColor = System.Drawing.Color.White;
            this.pageSetupButton.Location = new System.Drawing.Point(13, 666);
            this.pageSetupButton.Name = "pageSetupButton";
            this.pageSetupButton.Size = new System.Drawing.Size(78, 22);
            this.pageSetupButton.TabIndex = 159;
            this.pageSetupButton.Text = "Page Setup";
            this.pageSetupButton.UseVisualStyleBackColor = false;
            // 
            // printButton
            // 
            this.printButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.printButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.printButton.FlatAppearance.BorderSize = 0;
            this.printButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.printButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printButton.ForeColor = System.Drawing.Color.White;
            this.printButton.Location = new System.Drawing.Point(259, 641);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(78, 22);
            this.printButton.TabIndex = 158;
            this.printButton.Text = "In";
            this.printButton.UseVisualStyleBackColor = false;
            // 
            // rasterSaveButton
            // 
            this.rasterSaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rasterSaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rasterSaveButton.FlatAppearance.BorderSize = 0;
            this.rasterSaveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.rasterSaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rasterSaveButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rasterSaveButton.ForeColor = System.Drawing.Color.White;
            this.rasterSaveButton.Location = new System.Drawing.Point(95, 596);
            this.rasterSaveButton.Name = "rasterSaveButton";
            this.rasterSaveButton.Size = new System.Drawing.Size(78, 22);
            this.rasterSaveButton.TabIndex = 157;
            this.rasterSaveButton.Text = "Lưu ảnh";
            this.rasterSaveButton.UseVisualStyleBackColor = false;
            this.rasterSaveButton.Click += new System.EventHandler(this.rasterSaveImageButton_Click);
            // 
            // rasterCopyToClipboardButton
            // 
            this.rasterCopyToClipboardButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rasterCopyToClipboardButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rasterCopyToClipboardButton.FlatAppearance.BorderSize = 0;
            this.rasterCopyToClipboardButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.rasterCopyToClipboardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rasterCopyToClipboardButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rasterCopyToClipboardButton.ForeColor = System.Drawing.Color.White;
            this.rasterCopyToClipboardButton.Location = new System.Drawing.Point(13, 596);
            this.rasterCopyToClipboardButton.Name = "rasterCopyToClipboardButton";
            this.rasterCopyToClipboardButton.Size = new System.Drawing.Size(78, 22);
            this.rasterCopyToClipboardButton.TabIndex = 156;
            this.rasterCopyToClipboardButton.Text = "Sao chép ảnh";
            this.rasterCopyToClipboardButton.UseVisualStyleBackColor = false;
            this.rasterCopyToClipboardButton.Click += new System.EventHandler(this.rasterCopyToClipboardButton_Click);
            // 
            // showVerticesButton
            // 
            this.showVerticesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.showVerticesButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.showVerticesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.showVerticesButton.FlatAppearance.BorderSize = 0;
            this.showVerticesButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.showVerticesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showVerticesButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showVerticesButton.ForeColor = System.Drawing.Color.White;
            this.showVerticesButton.Location = new System.Drawing.Point(177, 289);
            this.showVerticesButton.Name = "showVerticesButton";
            this.showVerticesButton.Size = new System.Drawing.Size(78, 22);
            this.showVerticesButton.TabIndex = 155;
            this.showVerticesButton.Text = "Vertices";
            this.showVerticesButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.showVerticesButton.UseVisualStyleBackColor = false;
            // 
            // showExtentsButton
            // 
            this.showExtentsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.showExtentsButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.showExtentsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.showExtentsButton.FlatAppearance.BorderSize = 0;
            this.showExtentsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.showExtentsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showExtentsButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showExtentsButton.ForeColor = System.Drawing.Color.White;
            this.showExtentsButton.Location = new System.Drawing.Point(95, 289);
            this.showExtentsButton.Name = "showExtentsButton";
            this.showExtentsButton.Size = new System.Drawing.Size(78, 22);
            this.showExtentsButton.TabIndex = 154;
            this.showExtentsButton.Text = "Extents";
            this.showExtentsButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.showExtentsButton.UseVisualStyleBackColor = false;
            // 
            // showOriginButton
            // 
            this.showOriginButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.showOriginButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.showOriginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.showOriginButton.Checked = true;
            this.showOriginButton.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showOriginButton.FlatAppearance.BorderSize = 0;
            this.showOriginButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.showOriginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showOriginButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showOriginButton.ForeColor = System.Drawing.Color.White;
            this.showOriginButton.Location = new System.Drawing.Point(13, 289);
            this.showOriginButton.Name = "showOriginButton";
            this.showOriginButton.Size = new System.Drawing.Size(78, 22);
            this.showOriginButton.TabIndex = 153;
            this.showOriginButton.Text = "Origin";
            this.showOriginButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.showOriginButton.UseVisualStyleBackColor = false;
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.Color.White;
            this.deleteButton.Location = new System.Drawing.Point(95, 432);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(78, 22);
            this.deleteButton.TabIndex = 152;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            // 
            // duplicateButton
            // 
            this.duplicateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.duplicateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.duplicateButton.FlatAppearance.BorderSize = 0;
            this.duplicateButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.duplicateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.duplicateButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.duplicateButton.ForeColor = System.Drawing.Color.White;
            this.duplicateButton.Location = new System.Drawing.Point(13, 432);
            this.duplicateButton.Name = "duplicateButton";
            this.duplicateButton.Size = new System.Drawing.Size(78, 22);
            this.duplicateButton.TabIndex = 151;
            this.duplicateButton.Text = "Duplicate";
            this.duplicateButton.UseVisualStyleBackColor = false;
            // 
            // invertSelectionButton
            // 
            this.invertSelectionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.invertSelectionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.invertSelectionButton.FlatAppearance.BorderSize = 0;
            this.invertSelectionButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.invertSelectionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.invertSelectionButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invertSelectionButton.ForeColor = System.Drawing.Color.White;
            this.invertSelectionButton.Location = new System.Drawing.Point(177, 360);
            this.invertSelectionButton.Name = "invertSelectionButton";
            this.invertSelectionButton.Size = new System.Drawing.Size(78, 22);
            this.invertSelectionButton.TabIndex = 150;
            this.invertSelectionButton.Text = "Invert";
            this.invertSelectionButton.UseVisualStyleBackColor = false;
            // 
            // clearSelectionButton
            // 
            this.clearSelectionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clearSelectionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.clearSelectionButton.FlatAppearance.BorderSize = 0;
            this.clearSelectionButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.clearSelectionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearSelectionButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearSelectionButton.ForeColor = System.Drawing.Color.White;
            this.clearSelectionButton.Location = new System.Drawing.Point(259, 334);
            this.clearSelectionButton.Name = "clearSelectionButton";
            this.clearSelectionButton.Size = new System.Drawing.Size(78, 22);
            this.clearSelectionButton.TabIndex = 149;
            this.clearSelectionButton.Text = "Clear";
            this.clearSelectionButton.UseVisualStyleBackColor = false;
            // 
            // prevViewButton
            // 
            this.prevViewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.prevViewButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.prevViewButton.FlatAppearance.BorderSize = 0;
            this.prevViewButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.prevViewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prevViewButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prevViewButton.ForeColor = System.Drawing.Color.White;
            this.prevViewButton.Location = new System.Drawing.Point(13, 244);
            this.prevViewButton.Name = "prevViewButton";
            this.prevViewButton.Size = new System.Drawing.Size(78, 22);
            this.prevViewButton.TabIndex = 148;
            this.prevViewButton.Text = "Sau";
            this.prevViewButton.UseVisualStyleBackColor = false;
            this.prevViewButton.Click += new System.EventHandler(this.prevViewButton_Click);
            // 
            // nextViewButton
            // 
            this.nextViewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nextViewButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nextViewButton.FlatAppearance.BorderSize = 0;
            this.nextViewButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.nextViewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextViewButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextViewButton.ForeColor = System.Drawing.Color.White;
            this.nextViewButton.Location = new System.Drawing.Point(95, 244);
            this.nextViewButton.Name = "nextViewButton";
            this.nextViewButton.Size = new System.Drawing.Size(78, 22);
            this.nextViewButton.TabIndex = 147;
            this.nextViewButton.Text = "Trước";
            this.nextViewButton.UseVisualStyleBackColor = false;
            this.nextViewButton.Click += new System.EventHandler(this.nextViewButton_Click);
            // 
            // perspectiveButton
            // 
            this.perspectiveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.perspectiveButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.perspectiveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.perspectiveButton.FlatAppearance.BorderSize = 0;
            this.perspectiveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.perspectiveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.perspectiveButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.perspectiveButton.ForeColor = System.Drawing.Color.White;
            this.perspectiveButton.Location = new System.Drawing.Point(95, 102);
            this.perspectiveButton.Name = "perspectiveButton";
            this.perspectiveButton.Size = new System.Drawing.Size(78, 22);
            this.perspectiveButton.TabIndex = 146;
            this.perspectiveButton.Text = "Phối cảnh";
            this.perspectiveButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.perspectiveButton.UseVisualStyleBackColor = false;
            this.perspectiveButton.CheckedChanged += new System.EventHandler(this.perspectiveButton_CheckedChanged);
            // 
            // parallelButton
            // 
            this.parallelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.parallelButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.parallelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.parallelButton.FlatAppearance.BorderSize = 0;
            this.parallelButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.parallelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.parallelButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parallelButton.ForeColor = System.Drawing.Color.White;
            this.parallelButton.Location = new System.Drawing.Point(13, 102);
            this.parallelButton.Name = "parallelButton";
            this.parallelButton.Size = new System.Drawing.Size(78, 22);
            this.parallelButton.TabIndex = 145;
            this.parallelButton.Text = "Song song";
            this.parallelButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.parallelButton.UseVisualStyleBackColor = false;
            this.parallelButton.CheckedChanged += new System.EventHandler(this.parallelButton_CheckedChanged);
            // 
            // printPreviewButton
            // 
            this.printPreviewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.printPreviewButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.printPreviewButton.FlatAppearance.BorderSize = 0;
            this.printPreviewButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.printPreviewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printPreviewButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printPreviewButton.ForeColor = System.Drawing.Color.White;
            this.printPreviewButton.Location = new System.Drawing.Point(177, 641);
            this.printPreviewButton.Name = "printPreviewButton";
            this.printPreviewButton.Size = new System.Drawing.Size(78, 22);
            this.printPreviewButton.TabIndex = 140;
            this.printPreviewButton.Text = "Xem trước";
            this.printPreviewButton.UseVisualStyleBackColor = false;
            // 
            // volumeButton
            // 
            this.volumeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.volumeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.volumeButton.FlatAppearance.BorderSize = 0;
            this.volumeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.volumeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.volumeButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volumeButton.ForeColor = System.Drawing.Color.White;
            this.volumeButton.Location = new System.Drawing.Point(259, 499);
            this.volumeButton.Name = "volumeButton";
            this.volumeButton.Size = new System.Drawing.Size(78, 22);
            this.volumeButton.TabIndex = 184;
            this.volumeButton.Text = "Volume";
            this.volumeButton.UseVisualStyleBackColor = false;
            // 
            // areaButton
            // 
            this.areaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.areaButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.areaButton.FlatAppearance.BorderSize = 0;
            this.areaButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.areaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.areaButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.areaButton.ForeColor = System.Drawing.Color.White;
            this.areaButton.Location = new System.Drawing.Point(177, 499);
            this.areaButton.Name = "areaButton";
            this.areaButton.Size = new System.Drawing.Size(78, 22);
            this.areaButton.TabIndex = 183;
            this.areaButton.Text = "Area";
            this.areaButton.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.model1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(909, 747);
            this.panel2.TabIndex = 142;
            // 
            // model1
            // 
            this.model1.Cursor = System.Windows.Forms.Cursors.Default;
            this.model1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.model1.Location = new System.Drawing.Point(0, 0);
            this.model1.MinimumSize = new System.Drawing.Size(8, 8);
            this.model1.Name = "model1";
            this.model1.ProgressBar = progressBar1;
            this.model1.Size = new System.Drawing.Size(909, 747);
            this.model1.TabIndex = 1;
            coordinateSystemIcon1.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            viewport1.CoordinateSystemIcon = coordinateSystemIcon1;
            legend1.TextFont = null;
            legend1.TitleFont = null;
            viewport1.Legends = new devDept.Eyeshot.Legend[] {
        legend1};
            originSymbol1.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            viewport1.OriginSymbol = originSymbol1;
            viewCubeIcon1.Font = null;
            viewCubeIcon1.InitialRotation = new devDept.Geometry.Quaternion(0D, 0D, 0D, 1D);
            viewport1.ViewCubeIcon = viewCubeIcon1;
            this.model1.Viewports.Add(viewport1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1263, 795);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "3D View";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.model1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel mainStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel springToolStripStatusLabel;
        private System.Windows.Forms.ToolStripProgressBar readWriteProgressBar;
        public System.Windows.Forms.ToolStripStatusLabel selectedCountStatusLabel;
        public System.Windows.Forms.ToolStripStatusLabel addedCountStatusLabel;
        public System.Windows.Forms.ToolStripStatusLabel removedCountStatusLabel;
        public System.Windows.Forms.ToolStripStatusLabel rendererVersionStatusLabel;
        private System.Windows.Forms.Button zoomSelButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.CheckBox regenAsyncButton;
        private System.Windows.Forms.Button transformButton;
        private System.Windows.Forms.Button zoomFitButton;
        private System.Windows.Forms.CheckBox zoomWindowButton;
        private System.Windows.Forms.CheckBox rotateButton;
        private System.Windows.Forms.CheckBox panButton;
        private System.Windows.Forms.CheckBox zoomButton;
        private System.Windows.Forms.CheckBox openCurrentCheckBox;
        private System.Windows.Forms.ComboBox selectionFilterComboBox;
        private System.Windows.Forms.Button clearCurrentButton;
        private System.Windows.Forms.Button setCurrentButton;
        private System.Windows.Forms.Button statisticsButton;
        private System.Windows.Forms.CheckBox clipBox;
        private System.Windows.Forms.CheckBox magGlassCheckBox;
        private System.Windows.Forms.RadioButton flatButton;
        private System.Windows.Forms.CheckBox selectCheckBox;
        private System.Windows.Forms.ComboBox selectionComboBox;
        private System.Windows.Forms.CheckBox animateCameraCheckBox;
        private System.Windows.Forms.Button topViewButton;
        private System.Windows.Forms.Button sideViewButton;
        private System.Windows.Forms.Button frontViewButton;
        private System.Windows.Forms.Button isoViewButton;
        private System.Windows.Forms.Button importButton;
        private System.Windows.Forms.Label viewLabel;
        private System.Windows.Forms.Button groupButton;
        private System.Windows.Forms.Button explodeButton;
        private System.Windows.Forms.CheckBox showCurveDirectionButton;
        private System.Windows.Forms.Label miscLabel;
        private System.Windows.Forms.Label vectorLabel;
        private System.Windows.Forms.Button vectorSaveButton;
        private System.Windows.Forms.Button vectorCopyToClipbardButton;
        private System.Windows.Forms.Button dumpButton;
        private System.Windows.Forms.CheckBox rotateToFaceButton;
        private System.Windows.Forms.Button zoomSelectionButton;
        private System.Windows.Forms.RadioButton hiddenLinesButton;
        private System.Windows.Forms.CheckBox showGridButton;
        private System.Windows.Forms.CheckBox cullingButton;
        private System.Windows.Forms.CheckBox pickFaceButton;
        private System.Windows.Forms.RadioButton renderedButton;
        private System.Windows.Forms.CheckBox pickVertexButton;
        private System.Windows.Forms.RadioButton shadedButton;
        private System.Windows.Forms.Label inspectionLabel;
        private System.Windows.Forms.RadioButton wireframeButton;
        private System.Windows.Forms.Button untrimButton;
        private System.Windows.Forms.Label imagingLabel;
        private System.Windows.Forms.Label editingLabel;
        private System.Windows.Forms.Label selectionLabel;
        private System.Windows.Forms.Label hideShowLabel;
        private System.Windows.Forms.Label zprLabel;
        private System.Windows.Forms.Label projectionLabel;
        private System.Windows.Forms.Label shadingLabel;
        private System.Windows.Forms.Button pageSetupButton;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Button rasterSaveButton;
        private System.Windows.Forms.Button rasterCopyToClipboardButton;
        private System.Windows.Forms.CheckBox showVerticesButton;
        private System.Windows.Forms.CheckBox showExtentsButton;
        private System.Windows.Forms.CheckBox showOriginButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button duplicateButton;
        private System.Windows.Forms.Button invertSelectionButton;
        private System.Windows.Forms.Button clearSelectionButton;
        private System.Windows.Forms.Button prevViewButton;
        private System.Windows.Forms.Button nextViewButton;
        private System.Windows.Forms.RadioButton perspectiveButton;
        private System.Windows.Forms.RadioButton parallelButton;
        private System.Windows.Forms.Button printPreviewButton;
        private System.Windows.Forms.Button volumeButton;
        private System.Windows.Forms.Button areaButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListView layerListView;
        private System.Windows.Forms.ColumnHeader layerName;
        private System.Windows.Forms.ColumnHeader layerColor;
        private System.Windows.Forms.Label objectPropsLabel;
        private System.Windows.Forms.Label layersLabel;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private Model model1;
    }
}