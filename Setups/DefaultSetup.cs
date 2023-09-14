using BlankADMI.Modules;
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

            // Add disposables to list
            Disposables.Add(Rack.RenderingModule);

            // Make behaviors
            // ...

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