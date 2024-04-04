using BlankADMI.Modules;

namespace BlankADMI
{
    /// <summary>
    /// A blank mapping module, which will contain the instrument mapping. Rename and edit!
    /// </summary>
    public class MappingModule
    {
        public int sensorValue { get; set; } = 0;

        public int nota = 60;

        public void SuonaNotaCorrente()
        {
            Rack.MidiModule.PlayNote(nota, 127);
        }
        public void StoppaNotaCorrente()
        {
            Rack.MidiModule.StopNote(nota);
        }
    }
}