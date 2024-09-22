using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JanelaBD.Entities
{
	public class Point
	{
		private Vector3 position;
		private double thickness;

		public Point()
		{
			this.position = Vector3.Zero;
			this.thickness = 0.0;
		}

		public Point(Vector3 position) 
		{
			this.Position = position;
			this.thickness =  0.0;
		}	

		public double Thickness
		{
			get { return thickness; }
			set { thickness = value; }
		}


		public Vector3 Position
		{
			get { return position; }
			set { position = value; }
		}

	}
}
