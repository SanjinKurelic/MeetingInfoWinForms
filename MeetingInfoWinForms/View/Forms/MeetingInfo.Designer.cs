namespace MeetingInfoWinForms
{
    partial class MeetingInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MeetingInfo));
            this.meetingInfoTable = new System.Windows.Forms.TableLayoutPanel();
            this.lbTime = new System.Windows.Forms.Label();
            this.lbMeetingInfo = new System.Windows.Forms.Label();
            this.lbClient = new System.Windows.Forms.Label();
            this.tbPlace = new System.Windows.Forms.TextBox();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.lbPhone = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbSurname = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbClientInfo = new System.Windows.Forms.Label();
            this.lbPlace = new System.Windows.Forms.Label();
            this.lbDescription = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.tbDate = new System.Windows.Forms.DateTimePicker();
            this.tbClientPhone = new System.Windows.Forms.TextBox();
            this.tbClientEmail = new System.Windows.Forms.TextBox();
            this.tbClientSurname = new System.Windows.Forms.TextBox();
            this.tbClientName = new System.Windows.Forms.TextBox();
            this.cbClients = new System.Windows.Forms.ComboBox();
            this.buttonLayout = new System.Windows.Forms.TableLayoutPanel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.tbTime = new System.Windows.Forms.DateTimePicker();
            this.meetingInfoTable.SuspendLayout();
            this.buttonLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // meetingInfoTable
            // 
            resources.ApplyResources(this.meetingInfoTable, "meetingInfoTable");
            this.meetingInfoTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.meetingInfoTable.Controls.Add(this.lbTime, 0, 2);
            this.meetingInfoTable.Controls.Add(this.lbMeetingInfo, 0, 0);
            this.meetingInfoTable.Controls.Add(this.lbClient, 0, 7);
            this.meetingInfoTable.Controls.Add(this.tbPlace, 1, 5);
            this.meetingInfoTable.Controls.Add(this.tbDescription, 1, 4);
            this.meetingInfoTable.Controls.Add(this.tbTitle, 1, 3);
            this.meetingInfoTable.Controls.Add(this.lbPhone, 0, 11);
            this.meetingInfoTable.Controls.Add(this.lbEmail, 0, 10);
            this.meetingInfoTable.Controls.Add(this.lbSurname, 0, 9);
            this.meetingInfoTable.Controls.Add(this.lbName, 0, 8);
            this.meetingInfoTable.Controls.Add(this.lbClientInfo, 0, 6);
            this.meetingInfoTable.Controls.Add(this.lbPlace, 0, 5);
            this.meetingInfoTable.Controls.Add(this.lbDescription, 0, 4);
            this.meetingInfoTable.Controls.Add(this.lbTitle, 0, 3);
            this.meetingInfoTable.Controls.Add(this.lbDate, 0, 1);
            this.meetingInfoTable.Controls.Add(this.tbDate, 1, 1);
            this.meetingInfoTable.Controls.Add(this.tbClientPhone, 1, 11);
            this.meetingInfoTable.Controls.Add(this.tbClientEmail, 1, 10);
            this.meetingInfoTable.Controls.Add(this.tbClientSurname, 1, 9);
            this.meetingInfoTable.Controls.Add(this.tbClientName, 1, 8);
            this.meetingInfoTable.Controls.Add(this.cbClients, 1, 7);
            this.meetingInfoTable.Controls.Add(this.buttonLayout, 1, 12);
            this.meetingInfoTable.Controls.Add(this.tbTime, 1, 2);
            this.meetingInfoTable.Name = "meetingInfoTable";
            // 
            // lbTime
            // 
            resources.ApplyResources(this.lbTime, "lbTime");
            this.lbTime.Name = "lbTime";
            // 
            // lbMeetingInfo
            // 
            resources.ApplyResources(this.lbMeetingInfo, "lbMeetingInfo");
            this.meetingInfoTable.SetColumnSpan(this.lbMeetingInfo, 2);
            this.lbMeetingInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.lbMeetingInfo.Name = "lbMeetingInfo";
            // 
            // lbClient
            // 
            resources.ApplyResources(this.lbClient, "lbClient");
            this.lbClient.Name = "lbClient";
            // 
            // tbPlace
            // 
            this.tbPlace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            resources.ApplyResources(this.tbPlace, "tbPlace");
            this.tbPlace.Name = "tbPlace";
            // 
            // tbDescription
            // 
            this.tbDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            resources.ApplyResources(this.tbDescription, "tbDescription");
            this.tbDescription.Name = "tbDescription";
            // 
            // tbTitle
            // 
            this.tbTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            resources.ApplyResources(this.tbTitle, "tbTitle");
            this.tbTitle.Name = "tbTitle";
            // 
            // lbPhone
            // 
            resources.ApplyResources(this.lbPhone, "lbPhone");
            this.lbPhone.Name = "lbPhone";
            // 
            // lbEmail
            // 
            resources.ApplyResources(this.lbEmail, "lbEmail");
            this.lbEmail.Name = "lbEmail";
            // 
            // lbSurname
            // 
            resources.ApplyResources(this.lbSurname, "lbSurname");
            this.lbSurname.Name = "lbSurname";
            // 
            // lbName
            // 
            resources.ApplyResources(this.lbName, "lbName");
            this.lbName.Name = "lbName";
            // 
            // lbClientInfo
            // 
            resources.ApplyResources(this.lbClientInfo, "lbClientInfo");
            this.meetingInfoTable.SetColumnSpan(this.lbClientInfo, 2);
            this.lbClientInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.lbClientInfo.Name = "lbClientInfo";
            // 
            // lbPlace
            // 
            resources.ApplyResources(this.lbPlace, "lbPlace");
            this.lbPlace.Name = "lbPlace";
            // 
            // lbDescription
            // 
            resources.ApplyResources(this.lbDescription, "lbDescription");
            this.lbDescription.Name = "lbDescription";
            // 
            // lbTitle
            // 
            resources.ApplyResources(this.lbTitle, "lbTitle");
            this.lbTitle.Name = "lbTitle";
            // 
            // lbDate
            // 
            resources.ApplyResources(this.lbDate, "lbDate");
            this.lbDate.Name = "lbDate";
            // 
            // tbDate
            // 
            resources.ApplyResources(this.tbDate, "tbDate");
            this.tbDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tbDate.Name = "tbDate";
            // 
            // tbClientPhone
            // 
            this.tbClientPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tbClientPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.tbClientPhone, "tbClientPhone");
            this.tbClientPhone.Name = "tbClientPhone";
            this.tbClientPhone.ReadOnly = true;
            this.tbClientPhone.TabStop = false;
            // 
            // tbClientEmail
            // 
            this.tbClientEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tbClientEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.tbClientEmail, "tbClientEmail");
            this.tbClientEmail.Name = "tbClientEmail";
            this.tbClientEmail.ReadOnly = true;
            this.tbClientEmail.TabStop = false;
            // 
            // tbClientSurname
            // 
            this.tbClientSurname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tbClientSurname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.tbClientSurname, "tbClientSurname");
            this.tbClientSurname.Name = "tbClientSurname";
            this.tbClientSurname.ReadOnly = true;
            this.tbClientSurname.TabStop = false;
            // 
            // tbClientName
            // 
            this.tbClientName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tbClientName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.tbClientName, "tbClientName");
            this.tbClientName.Name = "tbClientName";
            this.tbClientName.ReadOnly = true;
            this.tbClientName.TabStop = false;
            // 
            // cbClients
            // 
            this.cbClients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            resources.ApplyResources(this.cbClients, "cbClients");
            this.cbClients.FormattingEnabled = true;
            this.cbClients.Name = "cbClients";
            this.cbClients.SelectedIndexChanged += new System.EventHandler(this.cbClients_SelectedIndexChanged);
            // 
            // buttonLayout
            // 
            resources.ApplyResources(this.buttonLayout, "buttonLayout");
            this.buttonLayout.Controls.Add(this.btnSave, 0, 0);
            this.buttonLayout.Controls.Add(this.btnClose, 0, 0);
            this.buttonLayout.Name = "buttonLayout";
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.btnClose, "btnClose");
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnClose.Name = "btnClose";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // tbTime
            // 
            resources.ApplyResources(this.tbTime, "tbTime");
            this.tbTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tbTime.MaxDate = new System.DateTime(1753, 1, 1, 20, 0, 0, 0);
            this.tbTime.MinDate = new System.DateTime(1753, 1, 1, 8, 0, 0, 0);
            this.tbTime.Name = "tbTime";
            this.tbTime.ShowUpDown = true;
            this.tbTime.Value = new System.DateTime(1753, 1, 1, 8, 0, 0, 0);
            // 
            // MeetingInfo
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.meetingInfoTable);
            this.Name = "MeetingInfo";
            this.Load += new System.EventHandler(this.MeetingInfo_Load);
            this.meetingInfoTable.ResumeLayout(false);
            this.meetingInfoTable.PerformLayout();
            this.buttonLayout.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel meetingInfoTable;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbSurname;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbClientInfo;
        private System.Windows.Forms.Label lbPlace;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.TextBox tbClientPhone;
        private System.Windows.Forms.TextBox tbClientSurname;
        private System.Windows.Forms.TextBox tbClientName;
        private System.Windows.Forms.TextBox tbPlace;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.DateTimePicker tbDate;
        private System.Windows.Forms.TextBox tbClientEmail;
        private System.Windows.Forms.Label lbClient;
        private System.Windows.Forms.ComboBox cbClients;
        private System.Windows.Forms.Label lbMeetingInfo;
        private System.Windows.Forms.TableLayoutPanel buttonLayout;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.DateTimePicker tbTime;
    }
}