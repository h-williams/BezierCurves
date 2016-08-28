using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1 {
    public partial class Form1 : Form {

		List<PictureBox> curvePoints = new List<PictureBox>();
		Graphics g;
		bool mouseDrag = false;

		public Form1() {
            InitializeComponent();
		}

		private void ClearLines () {
			Refresh();
		}

		private void renderCurves_Click(object sender, EventArgs e) {
			drawCurve();
		}

		private void DrawLine (Point pA, Point pB) {
			pA = new Point(pA.X + 5, pA.Y + 5);
			pB = new Point(pB.X + 5, pB.Y + 5);
			Pen p = new Pen(Color.DarkCyan, 3);
			g = CreateGraphics();
			g.DrawLine(p, pA, pB);
			p.Dispose();
			g.Dispose();
		}

		private void drawCurve() {
			for (int i = 0; i < curvePoints.Count; i++) {
				Controls.Remove(curvePoints[i]);
			}
			curvePoints.Clear();
			ClearLines();
			Point[] p = new Point[] { point1.Location, point2.Location, point3.Location };
			List<Point> points = new List<Point>();
			int result = 0;
			int smoothness = 10;
			if (int.TryParse(smoothnessText.Text, out result)) {
				smoothness = result;
			}
			Console.WriteLine(smoothness.ToString());

			Point p1 = p[0];
			Point p2 = p[1];
			Point pFinal = p[0];
			points.Add(pFinal);

			for (float i = 1; i < smoothness + 1; i++) {
				Console.WriteLine(i / smoothness);
				p1 = lerpPoints(p[0], p[1], i / smoothness);
				p2 = lerpPoints(p[1], p[2], i / smoothness);
				pFinal = lerpPoints(p1, p2, i / smoothness);
				points.Add(pFinal);
				//Console.WriteLine(pFinal);
				if (cbShowPoints.CheckState == CheckState.Checked) {
					PictureBox pFinalImg = new PictureBox();
					pFinalImg.Image = Properties.Resources.curvePoint;
					pFinalImg.Size = new Size(10, 10);
					pFinalImg.Location = pFinal;
					Controls.Add(pFinalImg);
					curvePoints.Add(pFinalImg);
				}
			}

			for (int i = 0; i < points.Count - 1; i++) {
				DrawLine(points[i], points[i + 1]);
			}
		}

		private Point lerpPoints (Point pA, Point pB, float t) {
			Point lerpedPoint = new Point((int)(pA.X + t * (pB.X - pA.X)), (int)(pA.Y + t * (pB.Y - pA.Y)));
			return lerpedPoint;
		}

		private void setPositions_Click(object sender, EventArgs e) {
			point1.Location = new Point(int.Parse(p1x.Text), int.Parse(p1y.Text));
			point2.Location = new Point(int.Parse(p2x.Text), int.Parse(p2y.Text));
			point3.Location = new Point(int.Parse(p3x.Text), int.Parse(p3y.Text));
			drawCurve();
		}

		private void cbShowPoints_CheckedChanged(object sender, EventArgs e) {
			drawCurve();
		}
	}
}
