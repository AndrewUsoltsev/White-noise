using System;
using System.Drawing;
using System.Windows.Forms;
using White_Noise_result.Control;

namespace White_Noise_result
{
    public partial class Form1 : Form
    {
       
        MainPlayer first;

        public Form1()
        {
            InitializeComponent();
            // можно сделать биения, для этого требуется две разных частоты с маленькой разностью
            first = new MainPlayer(2);
            
            first.MainPlaying(300,5);
        }


        // отрисовка графика
        private void BuildGraph_Click(object sender, EventArgs e)
        {
            GraphBox.Image = null;
            GraphBox.Update();
            RenderGraph.DrawingGraph(GraphBox, first.amplitude.sumOfAmplitude, first.amplitude.sizeMas, Pens.Red);
        }
       
    }
}
