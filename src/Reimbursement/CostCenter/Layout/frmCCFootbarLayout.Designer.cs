using System;
using Smobiler.Core;
namespace COMSSmobilerDemo.Reimbursement.CostCenter.Layout
{
    partial class frmCCFootbarLayout : Smobiler.Core.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmCCFootbarLayout()
            : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();

            //Add any initialization after the InitializeComponent() call
        }

        //SmobilerForm overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }


        //NOTE: The following procedure is required by the SmobilerForm
        //It can be modified using the SmobilerForm.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.Label1 = new Smobiler.Core.Controls.Label();
            this.Label2 = new Smobiler.Core.Controls.Label();
            this.txtCCUser = new Smobiler.Core.Controls.TextBox();
            this.btnccuser = new Smobiler.Core.Controls.Button();
            this.btncurrentUser = new Smobiler.Core.Controls.ImageButton();
            this.txtCCName = new Smobiler.Core.Controls.TextBox();
            this.btnsearch = new Smobiler.Core.Controls.ImageButton();
            this.Line1 = new Smobiler.Core.Controls.Line();
            this.Line2 = new Smobiler.Core.Controls.Line();
            this.Line3 = new Smobiler.Core.Controls.Line();
            //
            //Label1
            //
            this.Label1.ForeColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(44)), Convert.ToInt32(Convert.ToByte(44)), Convert.ToInt32(Convert.ToByte(44)));
            this.Label1.Name = "Label1";
            this.Label1.Padding = new Smobiler.Core.Padding(2f, 0f, 0f, 0f);
            this.Label1.Size = new System.Drawing.Size(88,35);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "责任人";
            this.Label1.ZIndex = 2;
            //
            //Label2
            //
            this.Label2.ForeColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(44)), Convert.ToInt32(Convert.ToByte(44)), Convert.ToInt32(Convert.ToByte(44)));
            this.Label2.Location = new System.Drawing.Point(0,35);
            this.Label2.Name = "Label2";
            this.Label2.Padding = new Smobiler.Core.Padding(2f, 0f, 0f, 0f);
            this.Label2.Size = new System.Drawing.Size(88,35);
            this.Label2.TabIndex = 3;
            this.Label2.Text = "成本中心";
            this.Label2.ZIndex = 7;
            //
            //txtCCUser
            //
            this.txtCCUser.Border = new Smobiler.Core.Border(0);
            this.txtCCUser.BorderColor = System.Drawing.Color.LightGray;
            this.txtCCUser.ForeColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(102)), Convert.ToInt32(Convert.ToByte(99)), Convert.ToInt32(Convert.ToByte(99)));
            this.txtCCUser.Location = new System.Drawing.Point(88,0);
            this.txtCCUser.Name = "txtCCUser";
            this.txtCCUser.Size = new System.Drawing.Size(143,38);
            this.txtCCUser.TabIndex = 4;
            this.txtCCUser.ZIndex = 3;
            //
            //btnccuser
            //
            this.btnccuser.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnccuser.ForeColor = System.Drawing.Color.Gray;
            this.btnccuser.Location = new System.Drawing.Point(230,0);
            this.btnccuser.Name = "btnccuser";
            this.btnccuser.Size = new System.Drawing.Size(35,35);
            this.btnccuser.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.btnccuser.TabIndex = 5;
            this.btnccuser.Text = ">";
            this.btnccuser.ZIndex = 4;
            //
            //btncurrentUser
            //
            this.btncurrentUser.Border = new Smobiler.Core.Border(1, 0, 0, 0);
            this.btncurrentUser.BorderColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(230)), Convert.ToInt32(Convert.ToByte(230)), Convert.ToInt32(Convert.ToByte(230)));
            this.btncurrentUser.FontSize = 10;
            this.btncurrentUser.ForeColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(43)), Convert.ToInt32(Convert.ToByte(146)), Convert.ToInt32(Convert.ToByte(223)));
            this.btncurrentUser.Location = new System.Drawing.Point(265,0);
            this.btncurrentUser.Name = "btncurrentUser";
            this.btncurrentUser.ResourceID = "me";
            this.btncurrentUser.Size = new System.Drawing.Size(35,35);
            this.btncurrentUser.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.btncurrentUser.TabIndex = 6;
            this.btncurrentUser.Text = "我";
            this.btncurrentUser.ZIndex = 5;
            //
            //txtCCName
            //
            this.txtCCName.Border = new Smobiler.Core.Border(0);
            this.txtCCName.BorderColor = System.Drawing.Color.LightBlue;
            this.txtCCName.ForeColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(102)), Convert.ToInt32(Convert.ToByte(99)), Convert.ToInt32(Convert.ToByte(99)));
            this.txtCCName.Location = new System.Drawing.Point(88,35);
            this.txtCCName.Name = "txtCCName";
            this.txtCCName.Size = new System.Drawing.Size(213,35);
            this.txtCCName.TabIndex = 7;
            this.txtCCName.ZIndex = 8;
            //
            //btnsearch
            //
            this.btnsearch.BorderColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(43)), Convert.ToInt32(Convert.ToByte(146)), Convert.ToInt32(Convert.ToByte(223)));
            this.btnsearch.BorderRadius = 4;
            this.btnsearch.FontSize = 10;
            this.btnsearch.ForeColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(43)), Convert.ToInt32(Convert.ToByte(146)), Convert.ToInt32(Convert.ToByte(223)));
            this.btnsearch.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.btnsearch.Location = new System.Drawing.Point(100,80);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.ResourceID = "Search";
            this.btnsearch.Size = new System.Drawing.Size(100,35);
            this.btnsearch.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.btnsearch.TabIndex = 8;
            this.btnsearch.ZIndex = 9;
            //
            //Line1
            //
            this.Line1.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(230)), Convert.ToInt32(Convert.ToByte(230)), Convert.ToInt32(Convert.ToByte(230)));
            this.Line1.Location = new System.Drawing.Point(0,35);
            this.Line1.Name = "Line1";
            this.Line1.Size = new System.Drawing.Size(300,3);
            this.Line1.TabIndex = 9;
            this.Line1.ZIndex = 6;
            //
            //Line2
            //
            this.Line2.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(230)), Convert.ToInt32(Convert.ToByte(230)), Convert.ToInt32(Convert.ToByte(230)));
            this.Line2.Location = new System.Drawing.Point(3,70);
            this.Line2.Name = "Line2";
            this.Line2.Size = new System.Drawing.Size(300,3);
            this.Line2.TabIndex = 10;
            this.Line2.ZIndex = 8;
            //
            //Line3
            //
            this.Line3.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(230)), Convert.ToInt32(Convert.ToByte(230)), Convert.ToInt32(Convert.ToByte(230)));
            this.Line3.Name = "Line3";
            this.Line3.Size = new System.Drawing.Size(300,3);
            this.Line3.TabIndex = 11;
            this.Line3.ZIndex = 1;
            //
            //frmCCFootbarLayout
            //
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
		this.Line3,
		this.Label1,
		this.txtCCUser,
		this.btnccuser,
		this.btncurrentUser,
		this.Line1,
		this.Label2,
		this.txtCCName,
		this.Line2,
		this.btnsearch
	});
            this.Size = new System.Drawing.Size(300,125);

        }
        internal Smobiler.Core.Controls.Label Label1;
        internal Smobiler.Core.Controls.Label Label2;
        internal Smobiler.Core.Controls.TextBox txtCCUser;
        internal Smobiler.Core.Controls.Button btnccuser;
        internal Smobiler.Core.Controls.ImageButton btncurrentUser;
        internal Smobiler.Core.Controls.TextBox txtCCName;
        internal Smobiler.Core.Controls.ImageButton btnsearch;
        internal Smobiler.Core.Controls.Line Line1;
        internal Smobiler.Core.Controls.Line Line2;
        internal Smobiler.Core.Controls.Line Line3;

        #endregion
    }
}
