namespace At_Windows_Startup
{
    partial class MainF
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainF));
            this.startupLB = new System.Windows.Forms.ListBox();
            this.aaddB = new System.Windows.Forms.Button();
            this.refreshB = new System.Windows.Forms.Button();
            this.removeB = new System.Windows.Forms.Button();
            this.editGB = new System.Windows.Forms.GroupBox();
            this.checkUpdatesB = new System.Windows.Forms.Button();
            this.eacceptB = new System.Windows.Forms.Button();
            this.epathTB = new System.Windows.Forms.TextBox();
            this.epathL = new System.Windows.Forms.Label();
            this.enameL = new System.Windows.Forms.Label();
            this.enameTB = new System.Windows.Forms.TextBox();
            this.lonamiwebsLL = new System.Windows.Forms.LinkLabel();
            this.addGB = new System.Windows.Forms.GroupBox();
            this.apathTB = new System.Windows.Forms.TextBox();
            this.apathL = new System.Windows.Forms.Label();
            this.anameL = new System.Windows.Forms.Label();
            this.anameTB = new System.Windows.Forms.TextBox();
            this.editGB.SuspendLayout();
            this.addGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // startupLB
            // 
            resources.ApplyResources(this.startupLB, "startupLB");
            this.startupLB.AllowDrop = true;
            this.startupLB.FormattingEnabled = true;
            this.startupLB.Name = "startupLB";
            this.startupLB.SelectedIndexChanged += new System.EventHandler(this.startupLB_SelectedIndexChanged);
            this.startupLB.DragDrop += new System.Windows.Forms.DragEventHandler(this.startupLB_DragDrop);
            this.startupLB.DragEnter += new System.Windows.Forms.DragEventHandler(this.startupLB_DragEnter);
            this.startupLB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.startupLB_KeyDown);
            // 
            // aaddB
            // 
            resources.ApplyResources(this.aaddB, "aaddB");
            this.aaddB.Name = "aaddB";
            this.aaddB.UseVisualStyleBackColor = true;
            this.aaddB.Click += new System.EventHandler(this.aaddB_Click);
            // 
            // refreshB
            // 
            resources.ApplyResources(this.refreshB, "refreshB");
            this.refreshB.Name = "refreshB";
            this.refreshB.UseVisualStyleBackColor = true;
            this.refreshB.Click += new System.EventHandler(this.refreshB_Click);
            // 
            // removeB
            // 
            resources.ApplyResources(this.removeB, "removeB");
            this.removeB.Name = "removeB";
            this.removeB.UseVisualStyleBackColor = true;
            this.removeB.Click += new System.EventHandler(this.removeB_Click);
            // 
            // editGB
            // 
            resources.ApplyResources(this.editGB, "editGB");
            this.editGB.Controls.Add(this.checkUpdatesB);
            this.editGB.Controls.Add(this.eacceptB);
            this.editGB.Controls.Add(this.epathTB);
            this.editGB.Controls.Add(this.epathL);
            this.editGB.Controls.Add(this.enameL);
            this.editGB.Controls.Add(this.enameTB);
            this.editGB.Name = "editGB";
            this.editGB.TabStop = false;
            // 
            // checkUpdatesB
            // 
            resources.ApplyResources(this.checkUpdatesB, "checkUpdatesB");
            this.checkUpdatesB.Name = "checkUpdatesB";
            this.checkUpdatesB.UseVisualStyleBackColor = true;
            this.checkUpdatesB.Click += new System.EventHandler(this.checkUpdatesB_Click);
            // 
            // eacceptB
            // 
            resources.ApplyResources(this.eacceptB, "eacceptB");
            this.eacceptB.Name = "eacceptB";
            this.eacceptB.UseVisualStyleBackColor = true;
            this.eacceptB.Click += new System.EventHandler(this.pacceptB_Click);
            // 
            // epathTB
            // 
            resources.ApplyResources(this.epathTB, "epathTB");
            this.epathTB.Name = "epathTB";
            this.epathTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ppathTB_KeyDown);
            // 
            // epathL
            // 
            resources.ApplyResources(this.epathL, "epathL");
            this.epathL.Name = "epathL";
            // 
            // enameL
            // 
            resources.ApplyResources(this.enameL, "enameL");
            this.enameL.Name = "enameL";
            // 
            // enameTB
            // 
            resources.ApplyResources(this.enameTB, "enameTB");
            this.enameTB.Name = "enameTB";
            this.enameTB.ReadOnly = true;
            // 
            // lonamiwebsLL
            // 
            resources.ApplyResources(this.lonamiwebsLL, "lonamiwebsLL");
            this.lonamiwebsLL.Name = "lonamiwebsLL";
            this.lonamiwebsLL.TabStop = true;
            this.lonamiwebsLL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lonamiwebsLL_LinkClicked);
            // 
            // addGB
            // 
            resources.ApplyResources(this.addGB, "addGB");
            this.addGB.Controls.Add(this.apathTB);
            this.addGB.Controls.Add(this.apathL);
            this.addGB.Controls.Add(this.anameL);
            this.addGB.Controls.Add(this.anameTB);
            this.addGB.Controls.Add(this.aaddB);
            this.addGB.Name = "addGB";
            this.addGB.TabStop = false;
            // 
            // apathTB
            // 
            resources.ApplyResources(this.apathTB, "apathTB");
            this.apathTB.Name = "apathTB";
            this.apathTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.apathTB_KeyDown);
            // 
            // apathL
            // 
            resources.ApplyResources(this.apathL, "apathL");
            this.apathL.Name = "apathL";
            // 
            // anameL
            // 
            resources.ApplyResources(this.anameL, "anameL");
            this.anameL.Name = "anameL";
            // 
            // anameTB
            // 
            resources.ApplyResources(this.anameTB, "anameTB");
            this.anameTB.Name = "anameTB";
            this.anameTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.anameTB_KeyDown);
            // 
            // MainF
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.addGB);
            this.Controls.Add(this.lonamiwebsLL);
            this.Controls.Add(this.editGB);
            this.Controls.Add(this.removeB);
            this.Controls.Add(this.refreshB);
            this.Controls.Add(this.startupLB);
            this.Name = "MainF";
            this.Load += new System.EventHandler(this.MainF_Load);
            this.editGB.ResumeLayout(false);
            this.editGB.PerformLayout();
            this.addGB.ResumeLayout(false);
            this.addGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox startupLB;
        private System.Windows.Forms.Button aaddB;
        private System.Windows.Forms.Button refreshB;
        private System.Windows.Forms.Button removeB;
        private System.Windows.Forms.GroupBox editGB;
        private System.Windows.Forms.Button eacceptB;
        private System.Windows.Forms.TextBox epathTB;
        private System.Windows.Forms.Label epathL;
        private System.Windows.Forms.Label enameL;
        private System.Windows.Forms.TextBox enameTB;
        private System.Windows.Forms.LinkLabel lonamiwebsLL;
        private System.Windows.Forms.GroupBox addGB;
        private System.Windows.Forms.TextBox apathTB;
        private System.Windows.Forms.Label apathL;
        private System.Windows.Forms.Label anameL;
        private System.Windows.Forms.TextBox anameTB;
        private System.Windows.Forms.Button checkUpdatesB;
    }
}

