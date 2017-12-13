using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
namespace White_Noise_result.Control
{
    /// <summary>
    /// отрисовка графика аудиосигнала
    /// </summary>
    public static class RenderGraph
    {

        /// <summary>
        /// отрисовка графика
        /// </summary>
        /// <param name="GraphBox">область отображения графика</param>
        /// <param name="masOfAmplitude">массив значения амплитуд аудиосигнала</param>
        /// <param name="amountOfPoints">количество отображаемых элементов из массива masOfAmplitude</param>
        /// <param name="penColor">цвет, которым будет рисоваться график</param>
        public static void DrawingGraph(PictureBox GraphBox, float[] masOfAmplitude, int amountOfPoints, Pen penColor)
        {
            Graphics g = GraphBox.CreateGraphics();
            int cx = GraphBox.Width;
            int cy = GraphBox.Height / 2;

            int scaleY = cy / 5; // масштаб по Y
            int scaleX = 1 + cx / amountOfPoints; // масштаб по X

            List<PointF> ptF = new List<PointF>();
            // для того, чтобы избежать выход за границы массива
            try
            {
                for (int i = 0; i < amountOfPoints; i++)
                    ptF.Add(new PointF(i * scaleX, 100 + masOfAmplitude[i] * scaleY));
            }
            catch(Exception ex)
            {

            }
            g.DrawLines(penColor, ptF.ToArray());
            g.Dispose();
        }

    }
}
