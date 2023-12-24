using SFML.Graphics;

namespace nk {
    public class Item {

        public string      Name        { get; } = "N/A";
        public Sprite      Icon        { get; } = new Sprite();
        public int?        Price       { get; } = null;
        public string?     Featues     { get; } = null;
        public string?     Unique      { get; } = null;
        public List<Item>? ParentItems { get; } = null;
        public List<Item>? ChildItems  { get; } = null;

        public  ItemStat          Stat    { get; } = new ItemStat();
        public  List<ItemUseStat> UseStat { get; } = new List<ItemUseStat>();

    }
}