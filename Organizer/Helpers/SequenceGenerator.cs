namespace Organizer.Helpers
{
    using System.Linq;
    using static Context;

    public static class SequenceGenerator
    {
        public static long GenerateNextValue() => _items.Count == 0 ? 0 : _items.Max(i => i.Id)+1;
    }
}
