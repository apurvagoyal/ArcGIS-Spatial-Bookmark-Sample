using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using ESRI.ArcGIS.Mobile;
using ESRI.ArcGIS.Mobile.Geometries;

namespace TimmonsGroup
{
    public partial class SpatialBookmarkManager : UserControl
    {
        private Map _map = null;
        private ESRI.ArcGIS.Mobile.SpatialReferences.SpatialReference _spatialReference = null;
        private SpatialBookmarkClass.SpatialBookmark _spatialBookmarkClass = null;
        public SpatialBookmarkManager()
        {
            InitializeComponent();
           
        }
        public Map BookmarkMap
        {
            get
            {
                return _map;
            }

            set
            {
                
                    _map = value;
                    //get the spatial reference information
                    _spatialReference = _map.SpatialReference;
                    _spatialBookmarkClass = new SpatialBookmarkClass.SpatialBookmark(_map);
                    //this.Dock = DockStyle.Fill;

             
            }

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtSpatialBookmarkName.Text))
                {
                    if (_map != null && _spatialBookmarkClass != null)
                    {
                        Exception createBookmarkEx = _spatialBookmarkClass.CreateBookmark(txtSpatialBookmarkName.Text,_map.GetExtent());
                        if (createBookmarkEx != null) { throw createBookmarkEx; }
                        this.lstBoxSpatialBookmarks.Items.Add(txtSpatialBookmarkName.Text);
                        txtSpatialBookmarkName.Text = "";

                    }
                }
                else
                {
                    throw new Exception("Please specify the bookmark name");
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnZoom_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstBoxSpatialBookmarks.SelectedIndex > -1)
                {
                    Exception zoomBookmarkEx = _spatialBookmarkClass.ZoomtoBookmark(lstBoxSpatialBookmarks.SelectedItem.ToString());
                    if (zoomBookmarkEx != null) { throw zoomBookmarkEx; }

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
      
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstBoxSpatialBookmarks.SelectedIndex > -1)
                {
                    Exception deleteBookmarkEx = _spatialBookmarkClass.DeleteBookmark(lstBoxSpatialBookmarks.SelectedItem.ToString());
                    if (deleteBookmarkEx != null) { throw deleteBookmarkEx; }
                    this.lstBoxSpatialBookmarks.Items.Remove(lstBoxSpatialBookmarks.SelectedItem.ToString());
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialogBookmarks.Filter = "XML Files(*.xml)|*.xml";
                saveFileDialogBookmarks.InitialDirectory = ".";
                //promt user for specifying the file location
                saveFileDialogBookmarks.ShowDialog();
                
                //write out the text file
                Exception exWriteXml=_spatialBookmarkClass.WritetoXML(saveFileDialogBookmarks.FileName);
                if (exWriteXml != null) { throw exWriteXml; }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openBookmarksFile = new OpenFileDialog();
                openBookmarksFile.Filter = "XML Files(*.xml)|*.xml";
                openBookmarksFile.InitialDirectory = ".";
                openBookmarksFile.ShowDialog();
                if (openBookmarksFile.FileName != string.Empty)
                {
                    Envelope envelope=_spatialBookmarkClass.ReadXML(openBookmarksFile.FileName);
                    
                    _map.SetExtent(envelope);
                    _map.Refresh();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

      

      
    }
}
