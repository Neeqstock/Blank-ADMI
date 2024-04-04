using BlankADMI.Modules;
using NITHdmis.NithSensors;
using NITHdmis.NithSensors.Wrappers.NithFaceCam;
using NITHdmis.Ports;
using NITHdmis.Template;
using System;
using System.Collections.Generic;

namespace BlankADMI.Setups
{
    public class DefaultSetup : ISetup
    {
        public DefaultSetup(InstrumentWindow instrumentWindow)
        {
            InstrumentWindow = instrumentWindow;
            Disposables = new List<IDisposable>();
        }

        private List<IDisposable> Disposables { get; set; }
        private InstrumentWindow InstrumentWindow { get; set; }

        /// <summary>
        /// Launches the setup actions for the instrument
        /// </summary>
        public void Setup()
        {
            // Make modules
            Rack.MappingModule = new MappingModule();
            Rack.RenderingModule = new RenderingModule(InstrumentWindow);
            Rack.USBportManager = new USBportManager();
            Rack.UDPportManager = new UDPportManager();
            Rack.NithModule = new NithModule();
            Rack.MidiModule = new NITHdmis.MIDI.MidiModuleNAudio(1, 1);

            // Connect USB port to NithModule
            Rack.USBportManager.Connect(3);
            Rack.UDPportManager.Connect();
            Rack.UDPportManager.Listeners.Add(Rack.NithModule);
            Rack.NithModule.Preprocessors.Add(new NithPreprocessor_FaceCam());

            // Add disposables to list
            Disposables.Add(Rack.RenderingModule);

            // You will probably want to leave this at the end!
            Rack.RenderingModule.StartRendering();
        }

        /// <summary>
        /// This method will dispose all the disposable modules. Call on program exit.
        /// </summary>
        public void Dispose()
        {
            foreach (IDisposable disposable in Disposables)
            {
                disposable.Dispose();
            }
        }
    }
}