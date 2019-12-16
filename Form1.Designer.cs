namespace USGS_Earthquake_Test
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.quakeView = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.place = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.magnitude = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.syncTimeBox = new System.Windows.Forms.ListBox();
            this.syncButton = new System.Windows.Forms.Button();
            this.syncConButton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.syncTimeLabel = new System.Windows.Forms.Label();
            this.syncTimer = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.quakeView, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.syncTimeBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.syncButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.syncConButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.statusLabel, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.syncTimeLabel, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1178, 466);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // quakeView
            // 
            this.quakeView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.time,
            this.place,
            this.magnitude});
            this.tableLayoutPanel1.SetColumnSpan(this.quakeView, 2);
            this.quakeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quakeView.FullRowSelect = true;
            this.quakeView.GridLines = true;
            this.quakeView.HideSelection = false;
            this.quakeView.Location = new System.Drawing.Point(179, 3);
            this.quakeView.Name = "quakeView";
            this.tableLayoutPanel1.SetRowSpan(this.quakeView, 2);
            this.quakeView.Size = new System.Drawing.Size(996, 366);
            this.quakeView.TabIndex = 5;
            this.quakeView.UseCompatibleStateImageBehavior = false;
            this.quakeView.View = System.Windows.Forms.View.Details;
            this.quakeView.ItemActivate += new System.EventHandler(this.quakeView_ItemActivate);
            // 
            // id
            // 
            this.id.Text = "ID";
            this.id.Width = 100;
            // 
            // time
            // 
            this.time.Text = "Time";
            this.time.Width = 180;
            // 
            // place
            // 
            this.place.Text = "Place";
            this.place.Width = 240;
            // 
            // magnitude
            // 
            this.magnitude.Text = "Magnitude";
            this.magnitude.Width = 120;
            // 
            // syncTimeBox
            // 
            this.syncTimeBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.syncTimeBox.FormattingEnabled = true;
            this.syncTimeBox.ItemHeight = 16;
            this.syncTimeBox.Location = new System.Drawing.Point(3, 3);
            this.syncTimeBox.Name = "syncTimeBox";
            this.syncTimeBox.Size = new System.Drawing.Size(170, 273);
            this.syncTimeBox.TabIndex = 0;
            // 
            // syncButton
            // 
            this.syncButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.syncButton.Location = new System.Drawing.Point(3, 282);
            this.syncButton.Name = "syncButton";
            this.syncButton.Size = new System.Drawing.Size(170, 87);
            this.syncButton.TabIndex = 1;
            this.syncButton.Text = "Sync USGS Earthquake Data";
            this.syncButton.UseVisualStyleBackColor = true;
            this.syncButton.Click += new System.EventHandler(this.syncButton_Click);
            // 
            // syncConButton
            // 
            this.syncConButton.BackColor = System.Drawing.SystemColors.Control;
            this.syncConButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.syncConButton.Location = new System.Drawing.Point(3, 375);
            this.syncConButton.Name = "syncConButton";
            this.syncConButton.Size = new System.Drawing.Size(170, 88);
            this.syncConButton.TabIndex = 2;
            this.syncConButton.Text = "Toggle Sync";
            this.syncConButton.UseVisualStyleBackColor = true;
            this.syncConButton.Click += new System.EventHandler(this.syncConButton_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.BackColor = System.Drawing.SystemColors.Info;
            this.statusLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.Location = new System.Drawing.Point(826, 372);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(349, 94);
            this.statusLabel.TabIndex = 6;
            // 
            // syncTimeLabel
            // 
            this.syncTimeLabel.AutoSize = true;
            this.syncTimeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.syncTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.syncTimeLabel.Location = new System.Drawing.Point(179, 372);
            this.syncTimeLabel.Name = "syncTimeLabel";
            this.syncTimeLabel.Size = new System.Drawing.Size(641, 94);
            this.syncTimeLabel.TabIndex = 7;
            this.syncTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // syncTimer
            // 
            this.syncTimer.Tick += new System.EventHandler(this.syncTimer_Tick);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1178, 466);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "USGS Earthquake Viewer";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox syncTimeBox;
        private System.Windows.Forms.Button syncButton;
        private System.Windows.Forms.Button syncConButton;
        private System.Windows.Forms.Timer syncTimer;
        private System.Windows.Forms.ListView quakeView;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader time;
        private System.Windows.Forms.ColumnHeader place;
        private System.Windows.Forms.ColumnHeader magnitude;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label syncTimeLabel;
    }
}

