namespace Form_Loading {
    partial class FormOne {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.buttonGoBack = new System.Windows.Forms.Button();
            this.textBoxTotalDistance = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonGoBack
            // 
            this.buttonGoBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGoBack.Location = new System.Drawing.Point(16, 15);
            this.buttonGoBack.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGoBack.Name = "buttonGoBack";
            this.buttonGoBack.Size = new System.Drawing.Size(149, 66);
            this.buttonGoBack.TabIndex = 0;
            this.buttonGoBack.Text = "Go Back to Form Main";
            this.buttonGoBack.UseVisualStyleBackColor = true;
            this.buttonGoBack.Click += new System.EventHandler(this.buttonGoBack_Click);
            // 
            // textBoxTotalDistance
            // 
            this.textBoxTotalDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotalDistance.Location = new System.Drawing.Point(277, 27);
            this.textBoxTotalDistance.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTotalDistance.Name = "textBoxTotalDistance";
            this.textBoxTotalDistance.Size = new System.Drawing.Size(132, 29);
            this.textBoxTotalDistance.TabIndex = 1;
            // 
            // FormOne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.textBoxTotalDistance);
            this.Controls.Add(this.buttonGoBack);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormOne";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "This is Form One";
            this.Load += new System.EventHandler(this.FormOne_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGoBack;
        private System.Windows.Forms.TextBox textBoxTotalDistance;
    }
}