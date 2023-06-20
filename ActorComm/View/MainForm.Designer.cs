
namespace ActorComm.View
{
    partial class MainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tc_ActorInfos = new System.Windows.Forms.TabControl();
            this.btn_AddActor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tc_ActorInfos
            // 
            this.tc_ActorInfos.Location = new System.Drawing.Point(12, 41);
            this.tc_ActorInfos.Name = "tc_ActorInfos";
            this.tc_ActorInfos.SelectedIndex = 0;
            this.tc_ActorInfos.Size = new System.Drawing.Size(760, 508);
            this.tc_ActorInfos.TabIndex = 3;
            // 
            // btn_AddActor
            // 
            this.btn_AddActor.Location = new System.Drawing.Point(12, 12);
            this.btn_AddActor.Name = "btn_AddActor";
            this.btn_AddActor.Size = new System.Drawing.Size(80, 23);
            this.btn_AddActor.TabIndex = 4;
            this.btn_AddActor.Text = "添加Actor";
            this.btn_AddActor.UseVisualStyleBackColor = true;
            this.btn_AddActor.Click += new System.EventHandler(this.btn_AddActor_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btn_AddActor);
            this.Controls.Add(this.tc_ActorInfos);
            this.Name = "MainForm";
            this.Text = "Actor Demo";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tc_ActorInfos;
        private System.Windows.Forms.Button btn_AddActor;
    }
}

