namespace nk {
	public class ItemUseStat {

		public readonly static NamedSprite IconRefill;
		public readonly static NamedSprite IconConsum;

		static ItemUseStat() {
			IconRefill = new NamedSprite(Res.Icon.Item.Use.Refill);
			IconConsum = new NamedSprite(Res.Icon.Item.Use.Refill);
		}

		public enum Flag {
			Consumable  = 0,
			RegenInHome = 1,
		}
		
		public readonly byte?         MaxCount    = 0;
		public readonly float?        CoolTime    = 0f;
		public readonly byte          Flags       = 0;
		public readonly string?       Name        = null;
		public readonly InhabitString Description = new InhabitString();

		private byte?  remainingCount    = 0; 
		private float? remainingCoolTime = 0f;

		public ItemUseStat(
			byte?   _maxCount = 0,
			float?  _coolTime = 0f,
			byte    _flags    = 0,
			string? _name     = "N/A"
		) {
			MaxCount = _maxCount;
			CoolTime = _coolTime;
			Flags    = _flags;
			Name     = _name;
		}

		

	}
}