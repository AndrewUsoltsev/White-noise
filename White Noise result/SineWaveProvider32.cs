using System;
using NAudio.Wave;

// экспортируемый класс для воспроизведения звука и отображения звуковой волны
public class SineWaveProvider32 : WaveProvider32
{
    private int sample = 0;

    public float Frequency { get; set; } 
    public float Amplitude { get; set; }

    public SineWaveProvider32(float frequency, float amplitude = 2f, int sampleRate = 16000, int channels = 1)
    {
        Frequency = frequency;
        Amplitude = amplitude;
        this.SetWaveFormat(sampleRate, channels);
    }

    // был в классе изначально
    // в данном проекте не используется
    public override int Read(float[] buffer, int offset, int sampleCount)
    {
        int sampleRate = WaveFormat.SampleRate;
        for (int n = 0; n < sampleCount; n++)
        {
            buffer[n + offset] = (float)(Amplitude * Math.Sin((2 * Math.PI * sample * Frequency) / sampleRate));
            sample++;
            if (sample >= sampleRate) sample = 0;
        }
        return sampleCount; 
    }


    // предполагаем, что волна без начального смещения
    public float[] ReadAsync(int sampleCount)
    {
        int sampleRate = WaveFormat.SampleRate;
        float[] buf = new float[sampleCount];
        for (int i = 0; i < sampleCount; i++)
            buf[i] = (float)(Amplitude * Math.Sin((float)(2 * Math.PI * i * Frequency / sampleRate)));
        return buf;
    }
}