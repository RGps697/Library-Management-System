namespace UserInterfaceLibrary
{
    partial class SelectableItemPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.itemList = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // itemList
            // 
            this.itemList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemList.AutoScroll = true;
            this.itemList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.itemList.BackColor = System.Drawing.Color.Transparent;
            this.itemList.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.itemList.Location = new System.Drawing.Point(0, 0);
            this.itemList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.itemList.Name = "itemList";
            this.itemList.Size = new System.Drawing.Size(436, 368);
            this.itemList.TabIndex = 0;
            this.itemList.WrapContents = false;
            // 
            // SelectableItemPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.itemList);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "SelectableItemPanel";
            this.Size = new System.Drawing.Size(436, 368);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.FlowLayoutPanel itemList;
    }
}
