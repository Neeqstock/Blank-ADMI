namespace BlankADMI.Modules
{
    /// <summary>
    /// This will contains all the modules
    /// </summary>
    internal static class Rack
    {

        public static MappingModule MappingModule { get; set; }
        public static RenderingModule RenderingModule { get; set; }
        public static USBportManager USBportManager { get; set; }
        public static NithModule NithModule { get; set; }
        public static MidiModuleNAudio MidiModule { get; set; }
        public static UDPportManager UDPportManager { get; set; }

        // TODO declare here all the other modules!
    }
}