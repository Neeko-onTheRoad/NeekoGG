namespace nk {
	public class ItemUseStat {

		public static NamedSprite IconRefill { get; }
		public static NamedSprite IconConsum { get; }

		static ItemUseStat() {
			IconRefill = new NamedSprite(Res.Icon.Item.Use.Refill);
			IconConsum = new NamedSprite(Res.Icon.Item.Use.Refill);
		}

		public enum Flag {
			Consumable  = 0,
			RegenInHome = 1,
		}
		
		private byte?         MaxCount    { get; } = 0;
		private float?        CoolTime    { get; } = 0f;
		private byte          Flags       { get; } = 0;
		private string?       Name        { get; } = null;
		private InhabitString Description { get; } = new InhabitString();

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