using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GetIconExample
{
    public partial class Form1 : Form
    {
        System.Windows.Forms.FlowLayoutPanel flowLayout = new System.Windows.Forms.FlowLayoutPanel();
        public Form1()
        {
            InitializeComponent();
            this.DragEnter += Form1_DragEnter1;//拖动操作进入处理
            this.DragDrop += Form1_DragDrop1;//拖动操作确认处理
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "\r\n\r\n";
            label1.Text = label1.Text + "可将需要测试的文件或文件夹拖入窗口，点测试方法看效果\r\n\r\n";
            label1.Text = label1.Text + "方法1：只对文件有效，且只能获取1个图标\r\n\r\n";
            label1.Text = label1.Text + "方法2：只对应用程序文件有效\r\n\r\n";
            label1.Text = label1.Text + "方法3：文件或文件夹都有效，可获取4种不同大小图标\r\n\r\n";
            label1.Text = label1.Text + "方法4：文件或文件夹都有效，只能获取2个图标\r\n\r\n";

            label1.Text = label1.Text + "获取系统所有图标后，再测试单个文件将导致有黑图标出现，重开程序会恢复正常，可能是系统缓存的原因。\r\n\r\n";




            flowLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            flowLayout.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(flowLayout);
        }
        private void Form1_DragDrop1(object sender, DragEventArgs e)
        {
            string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, false);            
            textBox1.Text=s[0];                
        }

        private void Form1_DragEnter1(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;//拖动时的图标
            else
                e.Effect = DragDropEffects.None;
        }
        private void test1(string name)
        {
            System.Drawing.Icon icon = MySystemIcon.GetSystemIconA.GetIconFromFile(name);
            if (icon == null)
                return;
            System.Drawing.Bitmap bitmap = icon.ToBitmap();

            System.Windows.Forms.PictureBox pic = new System.Windows.Forms.PictureBox();
            pic.Size = new System.Drawing.Size(icon.Size.Width, icon.Size.Height);
            flowLayout.Controls.Add(pic);
            pic.Image = bitmap;
            icon.Dispose();
        }
        private void test2(string name)
        {
            foreach (System.Drawing.Icon icon in MySystemIcon.GetSystemIconA.GetIconFromAPP(name))
            {
                System.Drawing.Bitmap bitmap = icon.ToBitmap();
                System.Windows.Forms.PictureBox pic = new System.Windows.Forms.PictureBox();
                pic.Size = new System.Drawing.Size(icon.Size.Width, icon.Size.Height);
                flowLayout.Controls.Add(pic);
                pic.Image = bitmap;
                icon.Dispose();
            }
        }
        private void test3(string name)
        {
            System.Drawing.Icon icon = MySystemIcon.GetSystemIconA.GetIconFromFile(name, MySystemIcon.GetSystemIconA.IMAGELIST_SIZE_FLAG.SHIL_SYSSMALL);
            System.Drawing.Bitmap bitmap = icon.ToBitmap();
            System.Windows.Forms.PictureBox pic = new System.Windows.Forms.PictureBox();
            pic.Size = new System.Drawing.Size(icon.Size.Width, icon.Size.Height);
            flowLayout.Controls.Add(pic);
            pic.Image = bitmap;
            icon.Dispose();

            icon = MySystemIcon.GetSystemIconA.GetIconFromFile(name, MySystemIcon.GetSystemIconA.IMAGELIST_SIZE_FLAG.SHIL_SMALL);
            bitmap = icon.ToBitmap();
            pic = new System.Windows.Forms.PictureBox();
            pic.Size = new System.Drawing.Size(icon.Size.Width, icon.Size.Height);
            flowLayout.Controls.Add(pic);
            pic.Image = bitmap;
            icon.Dispose();

            icon = MySystemIcon.GetSystemIconA.GetIconFromFile(name, MySystemIcon.GetSystemIconA.IMAGELIST_SIZE_FLAG.SHIL_LARGE);
            bitmap = icon.ToBitmap();
            pic = new System.Windows.Forms.PictureBox();
            pic.Size = new System.Drawing.Size(icon.Size.Width, icon.Size.Height);
            flowLayout.Controls.Add(pic);
            pic.Image = bitmap;
            icon.Dispose();

            icon = MySystemIcon.GetSystemIconA.GetIconFromFile(name, MySystemIcon.GetSystemIconA.IMAGELIST_SIZE_FLAG.SHIL_EXTRALARGE);
            bitmap = icon.ToBitmap();
            pic = new System.Windows.Forms.PictureBox();
            pic.Size = new System.Drawing.Size(icon.Size.Width, icon.Size.Height);
            flowLayout.Controls.Add(pic);
            pic.Image = bitmap;
            icon.Dispose();

            icon = MySystemIcon.GetSystemIconA.GetIconFromFile(name, MySystemIcon.GetSystemIconA.IMAGELIST_SIZE_FLAG.SHIL_JUMBO);
            bitmap = icon.ToBitmap();
            pic = new System.Windows.Forms.PictureBox();
            pic.Size = new System.Drawing.Size(icon.Size.Width, icon.Size.Height);
            flowLayout.Controls.Add(pic);
            pic.Image = bitmap;
            icon.Dispose();
        }
        private void test4(string name)
        {
            System.Drawing.Icon icon = MySystemIcon.GetSystemIconB.GetFileIcon(name, false);
            if (icon == null)
                return;
            System.Drawing.Bitmap bitmap = icon.ToBitmap();
            System.Windows.Forms.PictureBox pic = new System.Windows.Forms.PictureBox();
            pic.Size = new System.Drawing.Size(icon.Size.Width, icon.Size.Height);
            flowLayout.Controls.Add(pic);
            pic.Image = bitmap;
            icon.Dispose();

            icon = MySystemIcon.GetSystemIconB.GetFileIcon(name, true);
            bitmap = icon.ToBitmap();
            pic = new System.Windows.Forms.PictureBox();
            pic.Size = new System.Drawing.Size(icon.Size.Width, icon.Size.Height);
            flowLayout.Controls.Add(pic);
            pic.Image = bitmap;
            icon.Dispose();

            //icon = MySystemIcon.GetSystemIconB.GetDirectoryIcon(System.IO.Directory.GetParent(name).FullName, false);
            //bitmap = icon.ToBitmap();
            //pic = new System.Windows.Forms.PictureBox();
            //pic.Size = new System.Drawing.Size(icon.Size.Width, icon.Size.Height);
            //flowLayout.Controls.Add(pic);
            //pic.Image = bitmap;
            //icon.Dispose();

            //icon = MySystemIcon.GetSystemIconB.GetDirectoryIcon(System.IO.Directory.GetParent(name).FullName, true);
            //bitmap = icon.ToBitmap();
            //pic = new System.Windows.Forms.PictureBox();
            //pic.Size = new System.Drawing.Size(icon.Size.Width, icon.Size.Height);
            //flowLayout.Controls.Add(pic);
            //pic.Image = bitmap;
            //icon.Dispose();
        }
        /// <summary>
        /// 读取所有系统图标
        /// </summary>
        private void test5()
        {
            MySystemIcon.GetSystemIconA.IImageList list1 = null, list2 = null, list3 = null, list4 = null, list5 = null;
            Guid theGuid = new Guid(MySystemIcon.GetSystemIconA.IID_IImageList);
            MySystemIcon.GetSystemIconA.SHGetImageList(MySystemIcon.GetSystemIconA.IMAGELIST_SIZE_FLAG.SHIL_SMALL, ref theGuid, ref list1);//获取图标列表1：size(16,16)
            MySystemIcon.GetSystemIconA.SHGetImageList(MySystemIcon.GetSystemIconA.IMAGELIST_SIZE_FLAG.SHIL_SYSSMALL, ref theGuid, ref list2);//获取图标列表2：size(16,16)
            MySystemIcon.GetSystemIconA.SHGetImageList(MySystemIcon.GetSystemIconA.IMAGELIST_SIZE_FLAG.SHIL_LARGE, ref theGuid, ref list3);//获取图标列表3：size(32,32)
            MySystemIcon.GetSystemIconA.SHGetImageList(MySystemIcon.GetSystemIconA.IMAGELIST_SIZE_FLAG.SHIL_EXTRALARGE, ref theGuid, ref list4);//获取图标列表4：size(48,48)
            MySystemIcon.GetSystemIconA.SHGetImageList(MySystemIcon.GetSystemIconA.IMAGELIST_SIZE_FLAG.SHIL_JUMBO, ref theGuid, ref list5);//获取图标列表5：size(256,256)
            int count = 0;
            int r = list1.GetImageCount(ref count);//获取图标索引总数            
            for (int i = 0; i < count; i++)
            {
                IntPtr hIcon = IntPtr.Zero;
                list1.GetIcon(i, MySystemIcon.GetSystemIconA.ILD_TRANSPARENT | MySystemIcon.GetSystemIconA.ILD_IMAGE, ref hIcon);//获取指定索引号的图标句柄
                System.Drawing.Icon icon = null;
                try
                {
                    if (hIcon != IntPtr.Zero)
                        icon = System.Drawing.Icon.FromHandle(hIcon);
                    else
                        continue;
                }
                catch { return; }
                System.Drawing.Bitmap bitmap = icon.ToBitmap();
                System.Windows.Forms.PictureBox pic = new System.Windows.Forms.PictureBox();
                pic.Size = new System.Drawing.Size(icon.Size.Width, icon.Size.Height);
                flowLayout.Controls.Add(pic);
                pic.Image = bitmap;
                icon.Dispose();

                list2.GetIcon(i, MySystemIcon.GetSystemIconA.ILD_TRANSPARENT | MySystemIcon.GetSystemIconA.ILD_IMAGE, ref hIcon);//获取指定索引号的图标句柄
                icon = System.Drawing.Icon.FromHandle(hIcon);
                bitmap = icon.ToBitmap();
                pic = new System.Windows.Forms.PictureBox();
                pic.Size = new System.Drawing.Size(icon.Size.Width, icon.Size.Height);
                flowLayout.Controls.Add(pic);
                pic.Image = bitmap;
                icon.Dispose();

                list3.GetIcon(i, MySystemIcon.GetSystemIconA.ILD_TRANSPARENT | MySystemIcon.GetSystemIconA.ILD_IMAGE, ref hIcon);//获取指定索引号的图标句柄
                icon = System.Drawing.Icon.FromHandle(hIcon);
                bitmap = icon.ToBitmap();
                pic = new System.Windows.Forms.PictureBox();
                pic.Size = new System.Drawing.Size(icon.Size.Width, icon.Size.Height);
                flowLayout.Controls.Add(pic);
                pic.Image = bitmap;
                icon.Dispose();

                list4.GetIcon(i, MySystemIcon.GetSystemIconA.ILD_TRANSPARENT | MySystemIcon.GetSystemIconA.ILD_IMAGE, ref hIcon);//获取指定索引号的图标句柄
                icon = System.Drawing.Icon.FromHandle(hIcon);
                bitmap = icon.ToBitmap();
                pic = new System.Windows.Forms.PictureBox();
                pic.Size = new System.Drawing.Size(icon.Size.Width, icon.Size.Height);
                flowLayout.Controls.Add(pic);
                pic.Image = bitmap;
                icon.Dispose();

                list5.GetIcon(i, MySystemIcon.GetSystemIconA.ILD_TRANSPARENT | MySystemIcon.GetSystemIconA.ILD_IMAGE, ref hIcon);//获取指定索引号的图标句柄
                icon = System.Drawing.Icon.FromHandle(hIcon);
                bitmap = icon.ToBitmap();
                pic = new System.Windows.Forms.PictureBox();
                pic.Size = new System.Drawing.Size(icon.Size.Width, icon.Size.Height);
                flowLayout.Controls.Add(pic);
                pic.Image = bitmap;
                icon.Dispose();
            }
            
        }

        /// <summary>
        /// 读取所有32*32系统图标
        /// </summary>
        private void test6()
        {
            MySystemIcon.GetSystemIconA.IImageList list = null;
            Guid guil = new Guid(MySystemIcon.GetSystemIconA.IID_IImageList);//or IID_IImageList
            MySystemIcon.GetSystemIconA.SHGetImageList(MySystemIcon.GetSystemIconA.IMAGELIST_SIZE_FLAG.SHIL_LARGE, ref guil, ref list);//获取图标列表3：size(32,32)
            
            int count = 0;
            int r = list.GetImageCount(ref count);//获取图标索引总数            
            for (int i = 0; i < 700; i++)
            {
                IntPtr hIcon = IntPtr.Zero;
                list.GetIcon(i, MySystemIcon.GetSystemIconA.ILD_TRANSPARENT | MySystemIcon.GetSystemIconA.ILD_IMAGE, ref hIcon);//获取指定索引号的图标句柄
                System.Drawing.Icon icon = null;
                try
                {
                    if (hIcon != IntPtr.Zero)
                        icon = System.Drawing.Icon.FromHandle(hIcon);
                    else
                        continue;
                }
                catch { return; }
                System.Drawing.Bitmap bitmap = icon.ToBitmap();
                System.Windows.Forms.PictureBox pic = new System.Windows.Forms.PictureBox();
                pic.Size = new System.Drawing.Size(icon.Size.Width, icon.Size.Height);
                flowLayout.Controls.Add(pic);
                pic.Image = bitmap;
                icon.Dispose();
            }
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            flowLayout.Controls.Clear();

            test1(textBox1.Text);

            if (flowLayout.Controls.Count == 0)
                label1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            flowLayout.Controls.Clear();

            test2(textBox1.Text);

            if (flowLayout.Controls.Count == 0)
                label1.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            flowLayout.Controls.Clear();

            test3(textBox1.Text);

            if (flowLayout.Controls.Count == 0)
                label1.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            flowLayout.Controls.Clear();

            test4(textBox1.Text);

            if (flowLayout.Controls.Count == 0)
                label1.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            flowLayout.Controls.Clear();
            test5();
            if (flowLayout.Controls.Count == 0)
                label1.Visible = true;
            else
                MessageBox.Show(string.Format("总计获取[{0}]个图标", flowLayout.Controls.Count));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            flowLayout.Controls.Clear();
            test6();
            if (flowLayout.Controls.Count == 0)
                label1.Visible = true;
            else
                MessageBox.Show(string.Format("总计获取[{0}]个图标", flowLayout.Controls.Count));
        }
    }
}
