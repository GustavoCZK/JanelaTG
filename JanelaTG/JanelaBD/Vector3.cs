using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace JanelaBD
{
    public class Vector3
    {
		private double x;
		private double y;
		private double z;

		public Vector3(double x, double y)
		{
			this.x = x;
			this.y = y;
			this.z = 0.0;
		}
        public Vector3(double x, double y, double z) : this(x,y)
        {
			this.z = z;
        }

        public double Z
		{
			get { return z; }
			set { z = value; }
		}


		public double X
		{
			get { return x; }
			set { x = value; }
		}


		public double Y
		{
			get { return y; }
			set { y = value; }
		}

		public System.Drawing.PointF ToPointF
		{
			get
			{
				return new System.Drawing.PointF((float)X, (float)Y);
            }
		}

		public static Vector3 Zero
		{
			get { return new Vector3(0.0, 0.0, 0.0); }
		}

	}

}
