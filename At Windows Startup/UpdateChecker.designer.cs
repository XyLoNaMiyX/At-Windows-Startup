namespace UpdateChecker
{
    partial class UpdateChecker
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name=Strings.str0>true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        void InitializeComponent()
        {
        	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateChecker));
        	checkB = new System.Windows.Forms.Button();
        	infoL = new System.Windows.Forms.Label();
        	checkingPB = new System.Windows.Forms.ProgressBar();
        	SuspendLayout();
        	// 
        	// checkB
        	// 
        	checkB.Location = new System.Drawing.Point(12, 82);
        	checkB.Name = "checkB";
        	checkB.Size = new System.Drawing.Size(288, 23);
        	checkB.TabIndex = 0;
        	checkB.UseVisualStyleBackColor = true;
        	checkB.Click += new System.EventHandler(checkB_Click);
        	// 
        	// infoL
        	// 
        	infoL.AutoSize = true;
        	infoL.Location = new System.Drawing.Point(13, 13);
        	infoL.Name = "infoL";
        	infoL.Size = new System.Drawing.Size(278, 26);
        	infoL.TabIndex = 1;
        	// 
        	// checkingPB
        	// 
        	checkingPB.Location = new System.Drawing.Point(12, 53);
        	checkingPB.MarqueeAnimationSpeed = 0;
        	checkingPB.Name = "checkingPB";
        	checkingPB.Size = new System.Drawing.Size(288, 23);
        	checkingPB.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
        	checkingPB.TabIndex = 2;
        	// 
        	// UpdateChecker
        	// 
        	AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	ClientSize = new System.Drawing.Size(312, 113);
        	Controls.Add(checkingPB);
        	Controls.Add(infoL);
        	Controls.Add(checkB);
        	FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        	Icon = ((System.Drawing.Icon)(resources.GetObject("$Icon")));
        	MaximizeBox = false;
        	MinimizeBox = false;
        	Name = "UpdateChecker";
        	ResumeLayout(false);
        	PerformLayout();

        }

        #endregion

        System.Windows.Forms.Button checkB;
        System.Windows.Forms.Label infoL;
        System.Windows.Forms.ProgressBar checkingPB;
    }
}

