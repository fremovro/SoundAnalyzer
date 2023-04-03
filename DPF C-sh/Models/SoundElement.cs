namespace DPF_C_sh.Models
{
    internal class SoundElement
    {
        /// <summary>
        /// Амплитуда для АЧХ
        /// </summary>
        public double Amplitude = 0;

        /// <summary>
        /// Частота гармоники
        /// </summary>
        public double Frecuency = 0;

        public SoundElement(double Amplitude, double Frecuency)
        {
            this.Amplitude = Amplitude;
            this.Frecuency = Frecuency;
        }
    }
}
