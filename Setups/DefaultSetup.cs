using BlankADMI.Modules;
using NeeqDMIs.Template;

namespace BlankADMI.Setups
{
    public class DefaultSetup : ISetup
    {
        private InstrumentWindow InstrumentWindow { get; set; }
        public DefaultSetup(InstrumentWindow instrumentWindow)
        {
            InstrumentWindow = instrumentWindow;
        }

        /// <summary>
        /// Launches the setup actions for the instrument
        /// </summary>
        public void Setup()
        {
            Rack.MappingModule = new MappingModule();
            Rack.RenderingModule = new RenderingModule(InstrumentWindow);

            // You will probably want to leave this at the end!
            Rack.RenderingModule.StartRendering();
        }
    }
}