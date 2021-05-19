using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Cannon_Project
{
    public partial class Main : Form
    {
        //các thành phần được khởi tạo ban đầu
        PDFView.MainForm PdfViewFrm;
        VideoView.VideoControl VideoViewFrm;
        WindowsApplication1.Form1 Read3DFrm;
        System.Windows.Forms.Integration.ElementHost hostVideo = new System.Windows.Forms.Integration.ElementHost();

        string outdirect = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\PhaoBinh\\a\\b\\c\\d\\e\\f\\g\\h\\ReadAbleFile";
        //string outdirect = "C:\\Program Files\\devDept Software\\Eyeshot Ultimate 12\\read";
        //các luồng để mở dữ liệu
        Thread pdfthread;
        public Main()
        {
            InitializeComponent();
            PdfViewFrm = new PDFView.MainForm();
            VideoViewFrm = new VideoView.VideoControl();
            Read3DFrm = new WindowsApplication1.Form1();
            PdfViewFrm.TopLevel = false;
            Read3DFrm.TopLevel = false;


        }
        LoginFrm home = new LoginFrm();

        private void btn_trangchu_Click(object sender, EventArgs e)
        {

            this.Close();
            home.Show();
        }
        private void main_close(object sender, FormClosingEventArgs e)
        {
            home.Show();
            //xóa tất cả file readble
            string direct = outdirect;
            if (Directory.Exists(direct))
            {
                string[] files = Directory.GetFiles(direct);
                foreach (var item in files)
                {
                    try { File.Delete(item); }
                    catch
                    {

                    }
                }
            }

        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            //xóa tất cả file readble
            string direct = outdirect;
            if (Directory.Exists(direct))
            {
                string[] files = Directory.GetFiles(direct);
                foreach (var item in files)
                {
                    try { File.Delete(item); }
                    catch
                    {

                    }
                }
            }
            if (pdfthread != null)
            {
                pdfthread.Interrupt();
                if (!pdfthread.Join(2000))
                {
                    pdfthread.Abort();
                }
            }

        }

        private void btn_lythuyet_Click(object sender, EventArgs e)
        {
            label_menu.Text = "Lý Thuyết";
            Hienthithanhphan(PdfViewFrm);
            HienthiDanhsach(panelLyThuyet);
        }

        private void btn_2d_Click(object sender, EventArgs e)
        {
            label_menu.Text = "Video";
            Hienthithanhphan(hostVideo);
            HienthiDanhsach(panelVideo);

        }

        private void btn_3d_Click(object sender, EventArgs e)
        {
            label_menu.Text = "3D";
            Hienthithanhphan(Read3DFrm);
            HienthiDanhsach(panel3d);

        }

        private void btn_thuchanh_Click(object sender, EventArgs e)
        {
            label_menu.Text = "Thực Hành";
            HienthiDanhsach(panelBaigiang);

        }

        private void btn_tuychinh_Click(object sender, EventArgs e)
        {

        }


        //khi load ứng dụng
        private void Main_Load(object sender, EventArgs e)
        {
            //tạo các thành phần  vào nội dung

            panelNoidung.Controls.Add(Read3DFrm);
            panelNoidung.Controls.Add(PdfViewFrm);
            panelNoidung.Controls.Add(hostVideo);

            Read3DFrm.Dock = System.Windows.Forms.DockStyle.Fill;
            Read3DFrm.Visible = false;
            PdfViewFrm.Dock = System.Windows.Forms.DockStyle.Fill;
            PdfViewFrm.Visible = false;
            hostVideo.Dock = System.Windows.Forms.DockStyle.Fill;
            hostVideo.Visible = false;
            hostVideo.Child = VideoViewFrm;

            CheckForIllegalCrossThreadCalls = false;
            //max tree size
            int maxheight = (int)System.Windows.SystemParameters.PrimaryScreenHeight;
            int maxwidth = (int)System.Windows.SystemParameters.PrimaryScreenWidth;
            tree3d.MaximumSize = new Size(tree3d.Width, maxheight - 120);
            treeLythuyet.MaximumSize = new Size(treeLythuyet.Width, maxheight - 120);
            treeVideo.MaximumSize = new Size(treeVideo.Width, maxheight - 120);
            treebaigiang.MaximumSize = new Size(treebaigiang.Width, maxheight - 120);


            LoadFullDS();

            string direct = outdirect;
            if (Directory.Exists(direct))
            {
                string[] files = Directory.GetFiles(direct);
                foreach (var item in files)
                {
                    try { File.Delete(item); }
                    catch
                    {

                    }
                }
            }


        }

        #region Load file


        public void LoadDirectory(string Dir, TreeView tree)
        {

            tree.MouseDown += (sender, args) =>
            tree.SelectedNode = tree.GetNodeAt(args.X, args.Y);

            foreach (var item in Directory.GetFiles(Dir))
            {
                TreeNode tds = tree.Nodes.Add(System.IO.Path.GetFileName(item));
                tds.Tag = item;
                tree.Height += 25;

            }

            foreach (var item in Directory.GetDirectories(Dir))
            {
                TreeNode tds = tree.Nodes.Add(System.IO.Path.GetFileName(item));
                tds.Tag = "Directory";
                tds.ForeColor = Color.Blue;
                tds.ImageIndex = 0;
                tds.SelectedImageIndex = 0;
                tree.Height += 25;
                LoadFiles(item, tds);
                LoadSubDirectories(item, tds);
            }

        }

        private void LoadSubDirectories(string dir, TreeNode td)
        {
            // Get all subdirectories  
            string[] subdirectoryEntries = Directory.GetDirectories(dir);
            // Loop through them to see if they have any other subdirectories  
            foreach (string subdirectory in subdirectoryEntries)
            {

                DirectoryInfo di = new DirectoryInfo(subdirectory);
                TreeNode tds = td.Nodes.Add(di.Name);
                tds.ForeColor = Color.Blue;
                tds.Tag = "Directory";
                tds.TreeView.Height += 25;
                LoadFiles(subdirectory, tds);
                LoadSubDirectories(subdirectory, tds);

            }
        }

        private void LoadFiles(string dir, TreeNode td)
        {
            string[] Files = Directory.GetFiles(dir, "*.*");

            // Loop through them to see files  
            foreach (string file in Files)
            {
                FileInfo fi = new FileInfo(file);
                TreeNode tds = td.Nodes.Add(fi.Name);
                tds.Tag = fi.FullName;
                tds.ImageIndex = 5;
                tds.SelectedImageIndex = 5;
                //UpdateProgress();
                td.TreeView.Height += 25;
            }
        }



        #endregion


        #region Hiển thị các thành phần
        //ẩn hiện cac thành phần
        private void btnVisibleDS_Click(object sender, EventArgs e)
        {
            panelDanhsach.Visible = !panelDanhsach.Visible;
            if (panelDanhsach.Visible)
            {
                btnVisibleDS.Text = "<";
            }
            else btnVisibleDS.Text = ">";
        }
        public void Hienthithanhphan(Control c)
        {
            //ẩn hết
            if (!c.Visible)
            {
                Read3DFrm.Visible = false;
                PdfViewFrm.Visible = false;
                hostVideo.Visible = false;
                c.Visible = true;

                if (!hostVideo.Visible)
                {
                    VideoViewFrm.PauseVideo();
                }
            }

        }

        public void DoiMauBtn(Control c)
        {
            //32, 32, 38
            btn_lythuyet.BackColor = Color.FromArgb(32, 32, 38);
            btn_video.BackColor = Color.FromArgb(32, 32, 38);
            btn_3d.BackColor = Color.FromArgb(32, 32, 38);
            btn_thuchanh.BackColor = Color.FromArgb(32, 32, 38);


            if (c == panelLyThuyet)
            {
                btn_lythuyet.BackColor = Color.FromArgb(42, 32, 38);
            }
            else if (c == panelVideo)
            {
                btn_video.BackColor = Color.FromArgb(42, 32, 38);

            }
            else if (c == panel3d)
            {
                btn_3d.BackColor = Color.FromArgb(42, 32, 38);

            }
            else if (c == panelBaigiang)
            {
                btn_thuchanh.BackColor = Color.FromArgb(42, 32, 38);

            }
        }

        public void HienthiDanhsach(Control c)
        {
            //ẩn hết
            if (!c.Visible || !panelDanhsach.Visible)
            {
                panelDanhsach.Visible = true;
                panelLyThuyet.Visible = false;
                panelVideo.Visible = false;
                panel3d.Visible = false;
                panelBaigiang.Visible = false;
                c.Visible = true;
            }
            else
            {
                panelDanhsach.Visible = false;
            }
            DoiMauBtn(c);


            if (panelDanhsach.Visible)
            {
                btnVisibleDS.Text = "<";
            }
            else btnVisibleDS.Text = ">";

        }

        public void LoadFullDS()
        {
            string str = Application.StartupPath;
            string str1 = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\PhaoBinh\\a\\b\\c\\d\\e\\f\\g\\h\\Content\\Baigiang";
            string str3d = str + @"\Content\Mohinh";
            LoadDirectory(str3d, tree3d);
            panel3d.Height = tree3d.MaximumSize.Height;
            //thêm danh sách lý thuyết

            string strlythuyet = str + @"\Content\Lythuyet";
            LoadDirectory(strlythuyet, treeLythuyet);
            panelLyThuyet.Height = treeLythuyet.Height + 50;

            string strVideo = str + @"\Content\Video";
            LoadDirectory(strVideo, treeVideo);
            panelVideo.Height = treeVideo.MaximumSize.Height;

            string strBaigiang = str1;
            if (Directory.Exists(strBaigiang))
            {
                LoadDirectory(strBaigiang, treebaigiang);
                panelBaigiang.Height = treebaigiang.MaximumSize.Height;
            }
            else
            {
                Directory.CreateDirectory(str1);
            }


        }

        //hiển thị danh sách
        public void Loaddanhsach(Control c)
        {
            string str = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            if (c == Read3DFrm)
            {
                string str3d = str + @"\Content\Mohinh";
                LoadDirectory(str3d, tree3d);
            }

            else if (c == PdfViewFrm)
            {
                //thêm danh sách lý thuyết
                string strlythuyet = str + @"\Content\Lythuyet";
                LoadDirectory(strlythuyet, treeLythuyet);

            }
            else if (c == hostVideo)
            {
                string strVideo = str + @"\Content\Video";
                LoadDirectory(strVideo, treeVideo);

            }
            else
            {
                string strBaigiang = str + @"\Content\Baigiang";
                LoadDirectory(strBaigiang, treebaigiang);

            }
        }


        #endregion

        #region Các hàm convert sang pdf
        public bool ConvertWordToPdf(string inputFile, string outputfile)
        {

            Microsoft.Office.Interop.Word.Application wordApp =
            new Microsoft.Office.Interop.Word.Application();
            Microsoft.Office.Interop.Word.Document wordDoc = null;
            object inputFileTemp = inputFile;

            try
            {
                wordDoc = wordApp.Documents.Open(inputFile);
                wordDoc.ExportAsFixedFormat(outputfile, Microsoft.Office.Interop.Word.WdExportFormat.wdExportFormatPDF);
            }
            catch (Exception)
            {
                MessageBox.Show("Co loi xay ra");
                return false;
            }
            finally
            {
                if (wordDoc != null)
                {
                    wordDoc.Close(Microsoft.Office.Interop.Word.WdSaveOptions.wdDoNotSaveChanges);
                }
                if (wordApp != null)
                {
                    wordApp.Quit(Microsoft.Office.Interop.Word.WdSaveOptions.wdDoNotSaveChanges);
                    wordApp = null;
                }
            }

            return true;
        }

        public static bool ConvertPowerPointToPdf(string inputFile, string outputfile)
        {
            string outputFileName = outputfile;
            Microsoft.Office.Interop.PowerPoint.Application powerPointApp =
            new Microsoft.Office.Interop.PowerPoint.Application();
            Microsoft.Office.Interop.PowerPoint.Presentation presentation = null;
            Microsoft.Office.Interop.PowerPoint.Presentations presentations = null;
            try
            {
                presentations = powerPointApp.Presentations;
                presentation = presentations.Open(inputFile, Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoFalse,
                Microsoft.Office.Core.MsoTriState.msoFalse);

                presentation.ExportAsFixedFormat(outputFileName, Microsoft.Office.Interop.PowerPoint.PpFixedFormatType.ppFixedFormatTypePDF,
                Microsoft.Office.Interop.PowerPoint.PpFixedFormatIntent.ppFixedFormatIntentScreen, Microsoft.Office.Core.MsoTriState.msoFalse,
                Microsoft.Office.Interop.PowerPoint.PpPrintHandoutOrder.ppPrintHandoutVerticalFirst, Microsoft.Office.Interop.PowerPoint.PpPrintOutputType.ppPrintOutputSlides,
                Microsoft.Office.Core.MsoTriState.msoFalse, null, Microsoft.Office.Interop.PowerPoint.PpPrintRangeType.ppPrintAll, string.Empty, false, true, true, true, false,
                Type.Missing);
            }
            catch (Exception)
            {
                MessageBox.Show("Co loi xay ra");
                return false;
            }
            finally
            {
                if (presentation != null)
                {
                    presentation.Close();
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(presentation);
                    presentation = null;
                }
                if (powerPointApp != null)
                {
                    powerPointApp.Quit();
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(powerPointApp);
                    powerPointApp = null;
                }
            }
            return true;
        }


        #endregion

        #region Mở file trong tree

        private string DecryptOpenFile(string path)
        {
            string name = System.IO.Path.GetFileName(path);
            if (!Directory.Exists(outdirect))
            {
                Directory.CreateDirectory(outdirect);
            }

            string outputfile = outdirect + "\\" + name;
            if (File.Exists(outputfile))
            {
                return outputfile;
            }
            new AesFileData().FileDecrypt(path, outputfile, "nguyenvannam");
            return outputfile;
        }
        private void treeLythuyet_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            string str = e.Node.Tag.ToString();
            if (str != "Directory")
            {
                try
                {
                    pdfthread = new Thread(() =>
                    {
                        OpenThreadLythuyet(str);

                    });
                    pdfthread.Start();
                }
                catch (Exception)
                {
                    return;
                }

            }


        }

        private void OpenThreadLythuyet(string str)
        {
            string name = System.IO.Path.GetFileNameWithoutExtension(str);
            string filepdfout = outdirect + "\\" + name + ".pdf";
            if (str != "Directory")
            {
                PdfViewFrm.AblePdf();
                PdfViewFrm.Enabled = false;

                if (File.Exists(filepdfout))
                {
                    PdfViewFrm.OpenFile(filepdfout);
                }
                else
                {
                    switch (System.IO.Path.GetExtension(str).ToLower())
                    {
                        case ".pdf":
                            PdfViewFrm.OpenFile(DecryptOpenFile(str));
                            break;
                        case ".doc":
                        case ".docx":
                            ConvertWordToPdf(DecryptOpenFile(str), filepdfout);
                            PdfViewFrm.OpenFile(filepdfout);
                            break;
                        case ".ppt":
                        case ".pptx":
                            ConvertPowerPointToPdf(DecryptOpenFile(str), filepdfout);
                            PdfViewFrm.OpenFile(filepdfout);
                            break;
                        default:
                            break;
                    }
                }
                PdfViewFrm.Enabled = true;
                PdfViewFrm.AblePdf();


            }

        }
        private void treeVideo_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            string str = e.Node.Tag.ToString();
            if (str != "Directory")
            {
                VideoViewFrm.OpenFile(str);
            }
        }

        private void tree3d_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            string str = e.Node.Tag.ToString();
            if (str != "Directory")
            {

                Read3DFrm.OpenFile(DecryptOpenFile(str));
            }
        }

        private void treebaigiang_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            string str = e.Node.Tag.ToString();
            string name = System.IO.Path.GetFileName(str);
            string fileout = outdirect + "\\" + name;

            if (str != "Directory")
            {

                switch (System.IO.Path.GetExtension(str).ToLower())
                {
                    case ".pdf":
                    case ".doc":
                    case ".docx":
                    case ".ppt":
                    case ".pptx":
                    case ".xls":
                    case ".xlsx":
                        Hienthithanhphan(PdfViewFrm);
                        try
                        {
                            pdfthread = new Thread(() =>
                            {
                                OpenThreadLythuyet(str);

                            });
                            pdfthread.Start();
                        }
                        catch (Exception)
                        {
                            break;
                        }

                        break;
                    case ".mp4":
                        Hienthithanhphan(hostVideo);

                        VideoViewFrm.OpenFile(str);
                        break;
                    case ".obj":
                    case ".stl":
                    case ".igs":
                    case ".iges":
                    case ".asc":
                    case ".las":
                    case ".step":
                    case ".stp":
                        Hienthithanhphan(Read3DFrm);

                        if (File.Exists(fileout))
                        {
                            Read3DFrm.OpenFile(fileout);
                            return;
                        }
                        Read3DFrm.OpenFile(DecryptOpenFile(str));

                        break;
                    default:
                        break;
                }
            }
        }

        #endregion

        #region Chỉnh sửa bài giảng

        //tạo bài giảng mới
        private void btnTaoBaigiang_Click(object sender, EventArgs e)
        {
            string value = "Bai giang moi";
            if (Main.InputBox("Thêm mới bài giảng", "Ten bai giang :", ref value) == DialogResult.OK)
            {
                TaoBaigiang(value);
            }
        }

        public static DialogResult InputBox(string title, string promptText, ref string value)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = title;
            label.Text = promptText;
            textBox.Text = value;

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(9, 20, 372, 13);
            textBox.SetBounds(12, 36, 372, 20);
            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);

            label.AutoSize = true;
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();
            value = textBox.Text;
            return dialogResult;
        }

        private void TaoBaigiang(string str)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\PhaoBinh\\a\\b\\c\\d\\e\\f\\g\\h\\Content\\Baigiang\\" + str;
            string lythuyet = path + "\\Ly_thuyet";
            string video = path + "\\Video";
            string mohinh = path + "\\Mohinh";
            if (Directory.Exists(path))
            {
                MessageBox.Show("Tên bài giảng đã tồn tại!");
                return;
            }
            Directory.CreateDirectory(path);

            Directory.CreateDirectory(lythuyet);
            Directory.CreateDirectory(video);
            Directory.CreateDirectory(mohinh);

            //cập nhật trong tree
            TreeNode tds = treebaigiang.Nodes.Add(str);
            tds.Tag = "Directory";
            treebaigiang.Height += 25;
            panelBaigiang.Height += 25;
            treebaigiang.SelectedNode = tds;

            TreeNode tds1 = tds.Nodes.Add("Ly_thuyet");
            tds1.Tag = "Directory";
            treebaigiang.Height += 25;
            panelBaigiang.Height += 25;

            TreeNode tds2 = tds.Nodes.Add("Video");
            tds2.Tag = "Directory";
            treebaigiang.Height += 25;
            panelBaigiang.Height += 25;

            TreeNode tds3 = tds.Nodes.Add("Mohinh");
            tds3.Tag = "Directory";
            treebaigiang.Height += 25;
            panelBaigiang.Height += 25;


        }


        //tải bài giảng
        private void btnTaibaigiang_Click(object sender, EventArgs e)
        {
            Taibaigiang();

        }

        public void Taibaigiang()
        {
            var dialog = new OpenFileDialog
            {
                DefaultExt = ".cn",
                Multiselect = false
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string filename = dialog.FileName;
                string str1 = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\PhaoBinh\\a\\b\\c\\d\\e\\f\\g\\h\\Content\\Baigiang\\";
                string desDirectory = CheckDirectoryExist(str1 + Path.GetFileNameWithoutExtension(filename));
                ZipFile.ExtractToDirectory(filename, desDirectory);

                DirectoryInfo info = new DirectoryInfo(desDirectory);
                TreeNode node = treebaigiang.Nodes.Add(info.Name);
                node.Tag = "Directory";
                treebaigiang.Height += 50;
                LoadSubDirectories(desDirectory, node);
            }
        }
    
        //xuất bài giảng

        private void btnXuatBaigiang_Click(object sender, EventArgs e)
        {
            XuatBaigiang();
        }
        private void XuatBaigiang()
        {
            if (treebaigiang.SelectedNode == null)
            {
                return;
            }
            TreeNode node = treebaigiang.SelectedNode;
            while (node.Level > 0)
            {
                node = node.Parent;
            }
            string str1 = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\PhaoBinh\\a\\b\\c\\d\\e\\f\\g\\h\\Content\\Baigiang\\";

            var dialog = new CommonOpenFileDialog
            {
                EnsurePathExists = true,
                EnsureFileExists = false,
                AllowNonFileSystemItems = false,
                Multiselect = false,
                DefaultFileName = "Chọn thư mục xuất bài giảng",
                Title = "Chọn thư mục xuất bài giảng"

            };
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                string pathBaigiang = str1 + node.Text;
                try
                {

                    ZipFile.CreateFromDirectory(pathBaigiang, dialog.FileName + "\\" + node.Text + ".cn");

                    MessageBox.Show("Xuất bài giảng thành công<-+->");
                }
                catch (Exception)
                {

                    MessageBox.Show("Đã tồn tại thư mục cùng tên hoặc bài giảng trống !!!");
                }

            }
        }


        //Thêm file vào bài giảng

        private void btnThemFileBaigiang_Click(object sender, EventArgs e)
        {

            ThemFile();
        }

        private void ThemFile()
        {
            string str1 = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\PhaoBinh\\a\\b\\c\\d\\e\\f\\g\\h\\Content\\Baigiang\\";
            string directory;
            if (treebaigiang.SelectedNode == null || treebaigiang.SelectedNode.Tag.ToString() != "Directory")
            {
                return;
            }
            directory = str1 + treebaigiang.SelectedNode.FullPath;

            if (!ThemFileBaigiang(directory))
            {
                MessageBox.Show("Có lỗi xảy ra khi thêm file bài giảng!");
            }
        }
        private bool ThemFileBaigiang(string directory)
        {
            OpenFileDialog openfile = new OpenFileDialog()
            {
                Multiselect = false,
                DefaultExt = ".pdf",
                Filter = @"Data Files (*.ppt,*.pptx,*.doc,*.docx,*.pdf,*.mp4, *.avi,*.3gp,*.mov,*.mp4v)|*.ppt; *.pptx; *.doc; *.docx; *.pdf;*.mp4; *.avi;*.3gp;*.mov;*.mp4v|Pdf Files (*.pdf)|*.pdf|PowerPoint Files (*.ppt, *.pptx)|*.ppt;*.pptx|Word Files (*.doc, *.docx)|*.doc;*.docx|Video Files (*.mp4, *.avi,*.3gp,*.mov,*.mp4v)|*.mp4; *.avi;*.3gp;*.mov;*.mp4v"
            };
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                string filename = Path.GetFileName(openfile.FileName);
                string dich = CheckFileExist(directory + "\\" + filename);
                try
                {
                    string ex = Path.GetExtension(filename).ToLower();
                    if (ex != ".mp4" && ex != ".avi" && ex != ".3gp" && ex != ".mov" && ex != ".mp4v")
                    {
                        new AesFileData().FileEncrypt(openfile.FileName, dich, "nguyenvannam");
                    }
                    else File.Copy(openfile.FileName, dich);
                    TreeNode treenode = treebaigiang.SelectedNode.Nodes.Add(filename);
                    treenode.Tag = dich;
                }
                catch (Exception)
                {
                    return false;
                }

            }
            return true;

        }

        //Thêm file vào bài giảng
        private string CheckFileExist(string path)
        {
            string filename = path;
            int i = 0;
            while (File.Exists(filename))
            {
                i++;
                filename = Path.GetDirectoryName(filename) + "\\" + Path.GetFileNameWithoutExtension(path) + "("+i+")" + Path.GetExtension(path);
            }
            
            return filename;
        }

        private string CheckDirectoryExist(string path)
        {
            string foldername = path;
            int i = 0;
            while (Directory.Exists(foldername))
            {
                i++;
                foldername = path + "(" + i + ")";
            }

            return foldername;
        }

        //xóa bài giảng
        private void btnDeleteBaigiang_Click(object sender, EventArgs e)
        {
            XoaFileOrBaigiang();
        }
        private void XoaFileOrBaigiang()
        {
            if (treebaigiang.SelectedNode == null)
            {
                return;
            }
            DialogResult result = MessageBox.Show("Bạn có thực sự muốn xóa ?", "Cảnh báo", MessageBoxButtons.YesNoCancel);

            if (result == DialogResult.Yes)
            {
                string str1 = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\PhaoBinh\\a\\b\\c\\d\\e\\f\\g\\h\\Content\\Baigiang\\";

                if (treebaigiang.SelectedNode.Tag.ToString() == "Directory")
                {
                    //xoa thu muc
                    string path = str1 + treebaigiang.SelectedNode.FullPath;
                    DeleteDirectory(path);
                    treebaigiang.Nodes.Remove(treebaigiang.SelectedNode);
                }
                else
                {
                    //xoas file
                    File.Delete(treebaigiang.SelectedNode.Tag.ToString());
                    treebaigiang.Nodes.Remove(treebaigiang.SelectedNode);

                }
            }

        }

        private void DeleteDirectory(string path)
        {
            string[] files = Directory.GetFiles(path);
            foreach (var file in files)
            {
                File.Delete(file);
            }

            string[] directories = Directory.GetDirectories(path);
            foreach (var dic in directories)
            {
                DeleteDirectory(dic);
            }
            Directory.Delete(path);

        }
        private void treebaigiang_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    {
                        contextMenuStrip1.Show(this, new Point(e.X + 230, e.Y + 100));//places the menu at the pointer position
                    }
                    break;
            }
        }

        private void addBaigiangstrip_Click(object sender, EventArgs e)
        {
            string value = "Bai giang moi";
            if (Main.InputBox("Thêm mới bài giảng", "Ten bai giang :", ref value) == DialogResult.OK)
            {
                TaoBaigiang(value);
            }
        }

        private void xuatbaigiangstrip_Click(object sender, EventArgs e)
        {
            XuatBaigiang();
        }

        private void AddFilestrip_Click(object sender, EventArgs e)
        {
            ThemFile();
        }

        private void taibaigiangstrip_Click(object sender, EventArgs e)
        {
            Taibaigiang();
        }

        private void xoastrip_Click(object sender, EventArgs e)
        {
            XoaFileOrBaigiang();
        }



        #endregion


        #region drag and drop node trong treeview

        private void treebaigiang_DragDrop(object sender, DragEventArgs e)
        {
            Point targetPoint = treebaigiang.PointToClient(new Point(e.X, e.Y));

            TreeNode targetNode = treebaigiang.GetNodeAt(targetPoint);
            if (targetNode==null)
            {
                return;
            }

            if (targetNode.Tag.ToString() !="Directory")
            {
                return;
            }
            //không được di chuyển cả bài giảng
            TreeNode draggedNode = (TreeNode)e.Data.GetData(typeof(TreeNode));
            if (draggedNode.Level == 0)
            {
                return;
            }
            string str1 = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\PhaoBinh\\a\\b\\c\\d\\e\\f\\g\\h\\Content\\Baigiang\\";

            if (!draggedNode.Equals(targetNode) && !ContainsNode(draggedNode, targetNode) && !ContainsNode(targetNode, draggedNode))
            {
                if (e.Effect == DragDropEffects.Move)
                {
                    if (draggedNode.Tag.ToString() == "Directory")
                    {
                        string fr = str1 + draggedNode.FullPath;
                        string to = CheckDirectoryExist( str1 + targetNode.FullPath +"\\"+ draggedNode.Text);
                        if (DichuyenFolder(fr,to,false))
                        {
                            draggedNode.Remove();
                            TreeNode node = new TreeNode(to.Split('\\').Last());
                            node.Tag = "Directory";
                            node.ForeColor = Color.Blue;
                            targetNode.Nodes.Add(node);
                            LoadFiles(to, node);
                            LoadSubDirectories(to, node);
                        }
                    }
                    else
                    {
                        string fr = draggedNode.Tag.ToString();
                        string to = str1 + targetNode.FullPath + "\\" + Path.GetFileName(fr);
                        string tag = CheckFileExist(to);
                        if (DichuyenFile(fr, to,false))
                        {
                            draggedNode.Remove();
                            TreeNode n = targetNode.Nodes.Add(Path.GetFileName(tag));
                            n.Tag = tag;
                        }
                    }
                    


                }

                else if (e.Effect == DragDropEffects.Copy)
                {
                    if (draggedNode.Tag.ToString() == "Directory")
                    {
                        string fr = str1 + draggedNode.FullPath;
                        string to = CheckDirectoryExist(str1 + targetNode.FullPath + "\\" + draggedNode.Text);
                        if (DichuyenFolder(fr, to, true))
                        {
                            TreeNode node = new TreeNode(to.Split('\\').Last());
                            node.Tag = "Directory";
                            node.ForeColor = Color.Blue;
                            targetNode.Nodes.Add(node);
                            LoadFiles(to, node);
                            LoadSubDirectories(to, node);
                        }
                    }
                    else
                    {
                        string fr = draggedNode.Tag.ToString();
                        string to = str1 + targetNode.FullPath + "\\" + Path.GetFileName(fr);
                        if (DichuyenFile(fr, to,true))
                        {
                            TreeNode n =  targetNode.Nodes.Add(Path.GetFileName(draggedNode.Tag.ToString()));
                            n.Tag = CheckFileExist(to);
                        }
                    }
                }

                targetNode.Expand();
            }

        }

        private bool DichuyenFolder(string fr, string tar, bool copy)
        {
            string path_tar = CheckDirectoryExist(tar);
            if (Directory.Exists(fr))
            {
                try
                {
                    if (copy)
                    {
                        CopyEntireDirectory(new DirectoryInfo(fr), new DirectoryInfo(tar), true);
                    }
                    else
                    Directory.Move(fr, path_tar);
                }
                catch (Exception)
                {
                    return false;
                    
                }
            }
            return true;

        }

        private bool DichuyenFile(string path, string tar, bool copy)
        {
            string path_tar = CheckFileExist(tar);
            if (File.Exists(path))
            {
                try
                {
                    if (copy)
                        File.Copy(path, path_tar);
                    else
                    File.Move(path, path_tar);
                }
                catch (Exception)
                {
                    return false;

                }
            }
            return true;

        }


        public static void CopyEntireDirectory(DirectoryInfo source, DirectoryInfo target, bool overwiteFiles = true)
        {
            if (!source.Exists) return;
            if (!target.Exists) target.Create();

            Parallel.ForEach(source.GetDirectories(), (sourceChildDirectory) =>
                CopyEntireDirectory(sourceChildDirectory, new DirectoryInfo(Path.Combine(target.FullName, sourceChildDirectory.Name))));

            Parallel.ForEach(source.GetFiles(), sourceFile =>
                sourceFile.CopyTo(Path.Combine(target.FullName, sourceFile.Name), overwiteFiles));
        }
        //kiểm tra node
        private bool ContainsNode(TreeNode node1, TreeNode node2)
        {
            if (node2.Parent == null ) return false;
            if (node2.Parent.Equals(node1)) return true;

            return ContainsNode(node1, node2.Parent);
        }

        private void treebaigiang_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        private void treebaigiang_ItemDrag(object sender, ItemDragEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DoDragDrop(e.Item, DragDropEffects.Move);
            }
            else if (e.Button == MouseButtons.Right)
            {
                DoDragDrop(e.Item, DragDropEffects.Copy);
            }

        }
        #endregion

    }
}
