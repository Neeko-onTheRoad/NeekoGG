using SFML.Graphics;

namespace nk {
	public class ItemUseStat {

		public static Sprite IconRefill { get; }
		public static Sprite IconConsum { get; }

		static ItemUseStat() {
			IconRefill = new Sprite(Res.Icon.Item.Use.Refill);
			IconConsum = new Sprite(Res.Icon.Item.Use.Refill);
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

		private byte?  wremainingCount    = 0;
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