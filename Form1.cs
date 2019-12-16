using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft;
using Newtonsoft.Json;

namespace USGS_Earthquake_Test
{

    public partial class Form1 : Form
    {
        private static readonly String USGS_QUAKE_DATA_URI = "https://earthquake.usgs.gov/earthquakes/feed/v1.0/summary/all_hour.geojson";
        private static readonly int DATA_UPDATE_INTERVAL_MILLISECS = 60000;
        private static readonly int TIME_BOX_HISTORY_LENGTH_MAX = Int32.MaxValue;

        private DateTime nextTime;
        public Form1()
        {
            InitializeComponent();
            syncTimer.Interval = DATA_UPDATE_INTERVAL_MILLISECS;
        }

        private void getQuakes()
        {
            // get USGS Earthquake Data
            dynamic data = null;
            try
            {
                string json;
                using (var webClient = new System.Net.WebClient())
                {
                    json = webClient.DownloadString(USGS_QUAKE_DATA_URI);
                }
                data = JsonConvert.DeserializeObject<dynamic>(json);
            }
            catch (Exception e)
            {
                statusLabel.BackColor = System.Drawing.Color.Red;
                statusLabel.Text = e.Message;
                if (syncTimer.Enabled)
                {
                    syncStop();
                }
                return;
            }

            foreach (dynamic quake in data.features)
            {
                addToQuakeView(quake);
            }
            addToSyncTimeBox();
            statusLabel.BackColor = System.Drawing.Color.LightGreen;
            statusLabel.Text = "Successful Data Sync: " + DateTime.Now.ToLocalTime().ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void addToQuakeView(dynamic quake)
        { 
            if (!quakeView.Items.ContainsKey((string)quake.id))
            {
                string time = new DateTime(1970, 1, 1).AddMilliseconds((long)quake.properties.time).ToLocalTime().ToString();
                ListViewItem quakeItem = new ListViewItem((string)quake.id);
                quakeItem.Name = (string)quake.id;
                ListViewItem.ListViewSubItem quakeItemTime = new ListViewItem.ListViewSubItem(quakeItem, time);
                ListViewItem.ListViewSubItem quakeItemPlace = new ListViewItem.ListViewSubItem(quakeItem, (string)quake.properties.place);
                ListViewItem.ListViewSubItem quakeItemMag = new ListViewItem.ListViewSubItem(quakeItem, (string)quake.properties.mag);
                quakeItem.SubItems.Add(quakeItemTime);
                quakeItem.SubItems.Add(quakeItemPlace);
                quakeItem.SubItems.Add(quakeItemMag);
                quakeItem.BackColor = System.Drawing.Color.LightSalmon;
                quakeView.Items.Add(quakeItem);
            }
        }

        private void addToSyncTimeBox()
        {
            if (syncTimeBox.Items.Count > TIME_BOX_HISTORY_LENGTH_MAX)
            {
                syncTimeBox.Items.Clear();
            }
            syncTimeBox.Items.Add(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
        }

        private void syncButton_Click(object sender, EventArgs e)
        {
            getQuakes();
        }


        private void syncConButton_Click(object sender, EventArgs e)
        {
            if (!syncTimer.Enabled)
            {
                syncStart();
            }
            else
            {
                syncStop();
            }
        }

        private void syncStart()
        {
            syncConButton.BackColor = System.Drawing.Color.Green;
            syncTimer.Start();
            updateSyncTimeLabelText();
        }

        private void syncStop()
        {
            syncConButton.BackColor = System.Drawing.Color.Red;
            syncTimer.Stop();
            syncTimeLabel.Text = "";
        }

        private void syncTimer_Tick(object sender, EventArgs e)
        {
            getQuakes();
            updateSyncTimeLabelText();
        }

        private void updateSyncTimeLabelText()
        {
            syncTimeLabel.Text = "Next Data Sync: " + DateTime.Now.AddMilliseconds(DATA_UPDATE_INTERVAL_MILLISECS).ToLocalTime().ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void quakeView_ItemActivate(object sender, EventArgs e)
        {
            foreach (ListViewItem quake in quakeView.SelectedItems)
            {
                quake.BackColor = System.Drawing.Color.White;
            }
        }
    }
}
