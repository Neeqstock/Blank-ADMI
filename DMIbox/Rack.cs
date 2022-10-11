namespace BlankADMI
{
    internal static class Rack
    {

        private static BlankDMIBox netychordsdmibox = new BlankDMIBox();
        public static BlankDMIBox NDB { get => netychordsdmibox; set => netychordsdmibox = value; }
    }
}