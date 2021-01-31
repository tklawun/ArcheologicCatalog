using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArcheologicCatalogClassicV3
{
    public partial class ArcheologCatalogList : Form
    {
        private ArcheoObjectViewCtl archeoObjectViewCtl;
        public ArcheologCatalogList()
        {
            archeoObjectViewCtl = new ArcheoObjectViewCtl(this);
            InitializeComponent();
            listViewArcheoObjects.View = View.SmallIcon;
            listViewArcheoObjects.FullRowSelect = true;
            archeoObjectViewCtl.SetArcheoObjectListInView();
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            //TODO: es die Combobox muss neu gefüllt werden. 
            archeoObjectViewCtl.CreateArcheoObjectDetailView(null);
        }

        internal void SetListView(Dictionary<string, ArcheoObject> archeoObjects)
        {
            this.listViewArcheoObjects.Items.Clear();

            this.listViewArcheoObjects.GridLines = true;
            ImageList imageListSmall = new ImageList
            {
                ImageSize = new Size(100, 100)
            };
            listViewArcheoObjects.SmallImageList = imageListSmall;
            listViewArcheoObjects.LargeImageList = imageListSmall;
            listViewArcheoObjects.BeginUpdate();
            foreach (ArcheoObject key in archeoObjects.Values)
            {
                ListViewItem item = new ListViewItem(key.CodeOut);
                item.SubItems.Add(key.IdOut);
                if (new FilePaths().IsFileExists(key.PictureLinkOut))
                {
                    imageListSmall.Images.Add(Bitmap.FromFile(key.PictureLinkOut));
                }
                this.listViewArcheoObjects.Items.Add(item);
                item.ImageIndex = listViewArcheoObjects.Items.IndexOf(item);
            }

            listViewArcheoObjects.EndUpdate();
            this.Controls.Add(listViewArcheoObjects);
            this.Refresh();
        }
        private void listViewArcheoObjects_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listViewArcheoObjects_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.labelStatus.Visible = false;
            this.labelStatus.ForeColor = Color.Black;
            ListView.SelectedListViewItemCollection archeoObjectCodeList = this.listViewArcheoObjects.SelectedItems;
            try
            {
                string archeObjectCode = archeoObjectCodeList[0].Text;
                string archeObjectId = archeoObjectCodeList[0].SubItems[1].Text;
                archeoObjectViewCtl.CreateArcheoObjectDetailView(archeObjectId);
            }
            catch (Exception)
            {
                this.labelStatus.Text = "Element not found!";
                this.labelStatus.Visible = true;
                this.labelStatus.ForeColor = Color.Red;
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            archeoObjectViewCtl.CloseApplication();
        }

        private void buttonConfig_Click(object sender, EventArgs e)
        {
            archeoObjectViewCtl.OpenConfigDialog();
        }
        private void CreateMyListView()
        {
            // Create a new ListView control.
            ListView listView1 = new ListView();
            listView1.Bounds = new Rectangle(new Point(10, 10), new Size(300, 200));

            // Set the view to show details.
            listView1.View = View.Details;
            // Allow the user to edit item text.
            listView1.LabelEdit = true;
            // Allow the user to rearrange columns.
            listView1.AllowColumnReorder = true;
            // Display check boxes.
            listView1.CheckBoxes = true;
            // Select the item and subitems when selection is made.
            listView1.FullRowSelect = true;
            // Display grid lines.
            listView1.GridLines = true;
            // Sort the items in the list in ascending order.
            listView1.Sorting = SortOrder.Ascending;

            // Create three items and three sets of subitems for each item.
            ListViewItem item1 = new ListViewItem("item1", 0);
            // Place a check mark next to the item.
            item1.Checked = true;
            item1.SubItems.Add("1");
            item1.SubItems.Add("2");
            item1.SubItems.Add("3");
            ListViewItem item2 = new ListViewItem("item2", 1);
            item2.SubItems.Add("4");
            item2.SubItems.Add("5");
            item2.SubItems.Add("6");
            ListViewItem item3 = new ListViewItem("item3", 0);
            // Place a check mark next to the item.
            item3.Checked = true;
            item3.SubItems.Add("7");
            item3.SubItems.Add("8");
            item3.SubItems.Add("9");

            // Create columns for the items and subitems.
            // Width of -2 indicates auto-size.
            listView1.Columns.Add("Item Column", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Column 2", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Column 3", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Column 4", -2, HorizontalAlignment.Center);

            //Add the items to the ListView.
            listView1.Items.AddRange(new ListViewItem[] { item1, item2, item3 });

            // Create two ImageList objects.
            ImageList imageListSmall = new ImageList();
            ImageList imageListLarge = new ImageList();

            // Initialize the ImageList objects with bitmaps.
            imageListSmall.Images.Add(Bitmap.FromFile("C:\\MySmallImage1.bmp"));
            imageListSmall.Images.Add(Bitmap.FromFile("C:\\MySmallImage2.bmp"));
            imageListLarge.Images.Add(Bitmap.FromFile("C:\\MyLargeImage1.bmp"));
            imageListLarge.Images.Add(Bitmap.FromFile("C:\\MyLargeImage2.bmp"));

            //Assign the ImageList objects to the ListView.
            listView1.LargeImageList = imageListLarge;
            listView1.SmallImageList = imageListSmall;

            // Add the ListView to the control collection.
            this.Controls.Add(listView1);
        }
    }
}
