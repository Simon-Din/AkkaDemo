
namespace ActorComm.View
{
    partial class Option
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
            this.gb_UseActorType = new System.Windows.Forms.GroupBox();
            this.rdb_UseActorType_General = new System.Windows.Forms.RadioButton();
            this.rdb_UseActorType_TcpIp = new System.Windows.Forms.RadioButton();
            this.gb_SetActorParams = new System.Windows.Forms.GroupBox();
            this.lb_SetActorParams_SelActorSystem = new System.Windows.Forms.Label();
            this.cb_SetActorParams_SelActorSystem = new System.Windows.Forms.ComboBox();
            this.lb_SetActorParams_SelFatherActor = new System.Windows.Forms.Label();
            this.cb_SetActorParams_SelFatherActor = new System.Windows.Forms.ComboBox();
            this.lb_SetActorParams_SetActorName = new System.Windows.Forms.Label();
            this.txt_SetActorParams_SetActorName = new System.Windows.Forms.TextBox();
            this.btn_AddActor = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.gb_UseActorType.SuspendLayout();
            this.gb_SetActorParams.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_UseActorType
            // 
            this.gb_UseActorType.Controls.Add(this.rdb_UseActorType_TcpIp);
            this.gb_UseActorType.Controls.Add(this.rdb_UseActorType_General);
            this.gb_UseActorType.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.gb_UseActorType.Location = new System.Drawing.Point(12, 12);
            this.gb_UseActorType.Name = "gb_UseActorType";
            this.gb_UseActorType.Size = new System.Drawing.Size(240, 50);
            this.gb_UseActorType.TabIndex = 1;
            this.gb_UseActorType.TabStop = false;
            this.gb_UseActorType.Text = "使用 Actor 類型";
            // 
            // rdb_UseActorType_General
            // 
            this.rdb_UseActorType_General.AutoSize = true;
            this.rdb_UseActorType_General.Checked = true;
            this.rdb_UseActorType_General.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdb_UseActorType_General.Location = new System.Drawing.Point(10, 21);
            this.rdb_UseActorType_General.Name = "rdb_UseActorType_General";
            this.rdb_UseActorType_General.Size = new System.Drawing.Size(79, 16);
            this.rdb_UseActorType_General.TabIndex = 2;
            this.rdb_UseActorType_General.TabStop = true;
            this.rdb_UseActorType_General.Text = "Use General";
            this.rdb_UseActorType_General.UseVisualStyleBackColor = true;
            // 
            // rdb_UseActorType_TcpIp
            // 
            this.rdb_UseActorType_TcpIp.AutoSize = true;
            this.rdb_UseActorType_TcpIp.Checked = true;
            this.rdb_UseActorType_TcpIp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdb_UseActorType_TcpIp.Location = new System.Drawing.Point(100, 21);
            this.rdb_UseActorType_TcpIp.Name = "rdb_UseActorType_TcpIp";
            this.rdb_UseActorType_TcpIp.Size = new System.Drawing.Size(71, 16);
            this.rdb_UseActorType_TcpIp.TabIndex = 3;
            this.rdb_UseActorType_TcpIp.TabStop = true;
            this.rdb_UseActorType_TcpIp.Text = "Use TcpIp";
            this.rdb_UseActorType_TcpIp.UseVisualStyleBackColor = true;
            // 
            // gb_SetActorParams
            // 
            this.gb_SetActorParams.Controls.Add(this.txt_SetActorParams_SetActorName);
            this.gb_SetActorParams.Controls.Add(this.lb_SetActorParams_SetActorName);
            this.gb_SetActorParams.Controls.Add(this.cb_SetActorParams_SelFatherActor);
            this.gb_SetActorParams.Controls.Add(this.lb_SetActorParams_SelFatherActor);
            this.gb_SetActorParams.Controls.Add(this.cb_SetActorParams_SelActorSystem);
            this.gb_SetActorParams.Controls.Add(this.lb_SetActorParams_SelActorSystem);
            this.gb_SetActorParams.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.gb_SetActorParams.Location = new System.Drawing.Point(12, 68);
            this.gb_SetActorParams.Name = "gb_SetActorParams";
            this.gb_SetActorParams.Size = new System.Drawing.Size(240, 120);
            this.gb_SetActorParams.TabIndex = 2;
            this.gb_SetActorParams.TabStop = false;
            this.gb_SetActorParams.Text = "設置 Actor 參數";
            // 
            // lb_SetActorParams_SelActorSystem
            // 
            this.lb_SetActorParams_SelActorSystem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_SetActorParams_SelActorSystem.Location = new System.Drawing.Point(8, 20);
            this.lb_SetActorParams_SelActorSystem.Name = "lb_SetActorParams_SelActorSystem";
            this.lb_SetActorParams_SelActorSystem.Size = new System.Drawing.Size(80, 23);
            this.lb_SetActorParams_SelActorSystem.TabIndex = 0;
            this.lb_SetActorParams_SelActorSystem.Text = "ActorSystem";
            this.lb_SetActorParams_SelActorSystem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cb_SetActorParams_SelActorSystem
            // 
            this.cb_SetActorParams_SelActorSystem.FormattingEnabled = true;
            this.cb_SetActorParams_SelActorSystem.Location = new System.Drawing.Point(100, 20);
            this.cb_SetActorParams_SelActorSystem.Name = "cb_SetActorParams_SelActorSystem";
            this.cb_SetActorParams_SelActorSystem.Size = new System.Drawing.Size(120, 20);
            this.cb_SetActorParams_SelActorSystem.TabIndex = 1;
            // 
            // lb_SetActorParams_SelFatherActor
            // 
            this.lb_SetActorParams_SelFatherActor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_SetActorParams_SelFatherActor.Location = new System.Drawing.Point(8, 50);
            this.lb_SetActorParams_SelFatherActor.Name = "lb_SetActorParams_SelFatherActor";
            this.lb_SetActorParams_SelFatherActor.Size = new System.Drawing.Size(80, 23);
            this.lb_SetActorParams_SelFatherActor.TabIndex = 2;
            this.lb_SetActorParams_SelFatherActor.Text = "Father Actor";
            this.lb_SetActorParams_SelFatherActor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cb_SetActorParams_SelFatherActor
            // 
            this.cb_SetActorParams_SelFatherActor.FormattingEnabled = true;
            this.cb_SetActorParams_SelFatherActor.Location = new System.Drawing.Point(100, 50);
            this.cb_SetActorParams_SelFatherActor.Name = "cb_SetActorParams_SelFatherActor";
            this.cb_SetActorParams_SelFatherActor.Size = new System.Drawing.Size(120, 20);
            this.cb_SetActorParams_SelFatherActor.TabIndex = 3;
            // 
            // lb_SetActorParams_SetActorName
            // 
            this.lb_SetActorParams_SetActorName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_SetActorParams_SetActorName.Location = new System.Drawing.Point(8, 80);
            this.lb_SetActorParams_SetActorName.Name = "lb_SetActorParams_SetActorName";
            this.lb_SetActorParams_SetActorName.Size = new System.Drawing.Size(80, 23);
            this.lb_SetActorParams_SetActorName.TabIndex = 4;
            this.lb_SetActorParams_SetActorName.Text = "Actor Name";
            this.lb_SetActorParams_SetActorName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_SetActorParams_SetActorName
            // 
            this.txt_SetActorParams_SetActorName.Location = new System.Drawing.Point(100, 80);
            this.txt_SetActorParams_SetActorName.Name = "txt_SetActorParams_SetActorName";
            this.txt_SetActorParams_SetActorName.Size = new System.Drawing.Size(120, 22);
            this.txt_SetActorParams_SetActorName.TabIndex = 5;
            // 
            // btn_AddActor
            // 
            this.btn_AddActor.Location = new System.Drawing.Point(96, 194);
            this.btn_AddActor.Name = "btn_AddActor";
            this.btn_AddActor.Size = new System.Drawing.Size(75, 23);
            this.btn_AddActor.TabIndex = 3;
            this.btn_AddActor.Text = "新增";
            this.btn_AddActor.UseVisualStyleBackColor = true;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(177, 194);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 4;
            this.btn_Cancel.Text = "取消";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // Option
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 241);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_AddActor);
            this.Controls.Add(this.gb_SetActorParams);
            this.Controls.Add(this.gb_UseActorType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Option";
            this.Text = "Option";
            this.gb_UseActorType.ResumeLayout(false);
            this.gb_UseActorType.PerformLayout();
            this.gb_SetActorParams.ResumeLayout(false);
            this.gb_SetActorParams.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gb_UseActorType;
        private System.Windows.Forms.RadioButton rdb_UseActorType_TcpIp;
        private System.Windows.Forms.RadioButton rdb_UseActorType_General;
        private System.Windows.Forms.GroupBox gb_SetActorParams;
        private System.Windows.Forms.TextBox txt_SetActorParams_SetActorName;
        private System.Windows.Forms.Label lb_SetActorParams_SetActorName;
        private System.Windows.Forms.ComboBox cb_SetActorParams_SelFatherActor;
        private System.Windows.Forms.Label lb_SetActorParams_SelFatherActor;
        private System.Windows.Forms.ComboBox cb_SetActorParams_SelActorSystem;
        private System.Windows.Forms.Label lb_SetActorParams_SelActorSystem;
        private System.Windows.Forms.Button btn_AddActor;
        private System.Windows.Forms.Button btn_Cancel;
    }
}