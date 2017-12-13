using System.Threading.Tasks;
using System.Threading;
using NAudio.Wave;

namespace White_Noise_result.Control
{
    /// <summary>
    /// класс, организующий воспроизведение аудио с разными частотами
    /// </summary>
    public class MainPlayer
    {
        // количество разных частот
        private static int N;
        // барьер для синхронизации воспроизведения разных частот
        private Barrier barrier;
        
        /// <summary>
        /// производится работа с амплитудой
        /// </summary>
        public AmplitudeWorking amplitude;

        /// <summary>
        /// конструктор класса
        /// </summary>
        /// <param name="countFreequency">количество разных дорожек</param>
        /// <param name="sizeMas">размер массива, в который будут записаны значения амплитуды в разные моменты времени</param>
        public MainPlayer(int countFreequency = 40, int sizeMas = 640)
        {
            N = countFreequency;
            barrier = new Barrier(N);
            amplitude = new AmplitudeWorking(sizeMas);
        }



        /// <summary>
        /// воспроизведение разных частот и суммирование их амплитуд в один массив
        /// </summary>
        /// <param name="beginFreequency">частота, с которой начинается воспроизведение</param>
        /// <param name="count">разница частот между двумя разными аудиодорожками</param>
        public void MainPlaying(int beginFreequency, int count = 250)
        {
            for (int i = 0; i < N; i++)
                PlayWithOneFreequency(beginFreequency + i * count);
        }

        // инициализация воспроизведения звука, так же его воспроизведение
        // суммирование массива амплитуд данной частоты с общей
        private async void PlayWithOneFreequency(int freequency)
        {
            var sineWaveProvider = new SineWaveProvider32(freequency); // частота воспроизведения
            sineWaveProvider.SetWaveFormat(8000, 1); // частота дискретизации, число каналов( от второго параметра зависит скорость воспроизведения)
            var waveOut = new WaveOut();
            waveOut.Init(sineWaveProvider);
            var masofAmplitude = sineWaveProvider.ReadAsync(amplitude.sizeMas); // можно и обычным приведением, но хз

            amplitude.summing(masofAmplitude);

            await Task.Run(() => PlayAudio(waveOut));
        }

        // воспроизведение звука
        private async void PlayAudio(WaveOut waveOut)
        {
            // барьер невероятно долго работает при большом количестве потоков
            barrier.SignalAndWait();
            await Task.Run(() => waveOut.Play());
        }


    }
}