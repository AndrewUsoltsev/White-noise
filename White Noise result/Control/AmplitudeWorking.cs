using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace White_Noise_result.Control
{
    /// <summary>
    /// класс, для работы с амплитудами
    /// </summary>
    public class AmplitudeWorking
    {


        /// <summary>
        /// количества точек для графика
        /// </summary>
        public int sizeMas { get; private set; } = 640;

        /// <summary>
        /// общий массив амплитуд, в него суммируются все дорожки
        /// </summary>
        public float[] sumOfAmplitude { get; private set; }

        /// <summary>
        /// стандартный конструктор класса
        /// </summary>
        public AmplitudeWorking()
        {
            sumOfAmplitude = new float[sizeMas];
        }

        /// <summary>
        /// конструктор класса
        /// </summary>
        /// <param name="sizeMas">размер массива, в который записываются значения амплитуды аудиосигнала</param>
        public AmplitudeWorking(int sizeMas)
        {
            sumOfAmplitude = new float[sizeMas];
        }

        /// <summary>
        /// суммирование массива амплитуд определенной частоты из параметра
        /// с общим массивом амплитуд со всеми частотами 
        /// </summary>
        /// <param name="sumOfAmplitude">амплитуда текущей аудиодорожки</param>
        public void summing(float[] sumOfAmplitude)
        {
            for (int i = 0; i < sizeMas; i++)
                this.sumOfAmplitude[i] += sumOfAmplitude[i];
        }




    }
}
