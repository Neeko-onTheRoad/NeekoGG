namespace nk {
    public class Item {

        private string        name        = "N/A";
        private NamedSprite icon        = new NamedSprite();
        private int?          price       = null;
        private string?       featues     = null;
        private string?       unique      = null;
        private List<Item>?   parentItems = null;
        private List<Item>?   childItems  = null;

        public string        Name        { get { return name;        } }
        public NamedSprite Icon        { get { return icon;        } }
        public int?          Price       { get { return price;       } }
        public string?       Featues     { get { return featues;     } }
        public string?       Unique      { get { return unique;      } }
        public List<Item>?   ParentItems { get { return parentItems; } }
        public List<Item>?   ChildItems  { get { return childItems;  } }

        private ItemStat stat = new ItemStat();
        public  ItemStat Stat { get { return stat; } }

        private List<ItemUseStat> use = new ItemUseStat();
        public  List<ItemUseStat> Use { get { return use; } }

    }
}