namespace Form_Loading
{
    partial class FormCart
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
            this.tabOrderForm = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtOrderAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dudProducts = new System.Windows.Forms.DomainUpDown();
            this.btnAddToOrder = new System.Windows.Forms.Button();
            this.tabOrderForm.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabOrderForm
            // 
            this.tabOrderForm.Controls.Add(this.tabPage1);
            this.tabOrderForm.Controls.Add(this.tabPage2);
            this.tabOrderForm.Controls.Add(this.tabPage3);
            this.tabOrderForm.Location = new System.Drawing.Point(244, 56);
            this.tabOrderForm.Name = "tabOrderForm";
            this.tabOrderForm.SelectedIndex = 0;
            this.tabOrderForm.Size = new System.Drawing.Size(790, 571);
            this.tabOrderForm.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnAddToOrder);
            this.tabPage1.Controls.Add(this.dudProducts);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtOrderAddress);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(782, 538);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Order Form";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(782, 538);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Shopping Cart";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(782, 538);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Mailing Label";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtOrderAddress
            // 
            this.txtOrderAddress.Location = new System.Drawing.Point(49, 78);
            this.txtOrderAddress.Multiline = true;
            this.txtOrderAddress.Name = "txtOrderAddress";
            this.txtOrderAddress.Size = new System.Drawing.Size(676, 270);
            this.txtOrderAddress.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Order Address";
            // 
            // dudProducts
            // 
            this.dudProducts.Location = new System.Drawing.Point(314, 419);
            this.dudProducts.Name = "dudProducts";
            this.dudProducts.Size = new System.Drawing.Size(162, 26);
            this.dudProducts.TabIndex = 2;
            // 
            // btnAddToOrder
            // 
            this.btnAddToOrder.Location = new System.Drawing.Point(353, 462);
            this.btnAddToOrder.Name = "btnAddToOrder";
            this.btnAddToOrder.Size = new System.Drawing.Size(86, 38);
            this.btnAddToOrder.TabIndex = 3;
            this.btnAddToOrder.Text = "button1";
            this.btnAddToOrder.UseVisualStyleBackColor = true;
            // 
            // FormCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
     
            this.ClientSize = new System.Drawing.Size(1260, 731);
            this.Controls.Add(this.tabOrderForm);
            this.Name = "FormCart";
            this.Text = "FormCart";
            this.tabOrderForm.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabOrderForm;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtOrderAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DomainUpDown dudProducts;
        private System.Windows.Forms.Button btnAddToOrder;
    }
}