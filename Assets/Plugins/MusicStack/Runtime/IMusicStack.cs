namespace Feverfew.MusicStack
{
    public interface IMusicStack
    {
        public static readonly IMusicStack Default = new MusicStack();

        public static IMusicStack CreateNewMusicStack() => new MusicStack();

        public IMusicTicket GetTicket();
    }
}
