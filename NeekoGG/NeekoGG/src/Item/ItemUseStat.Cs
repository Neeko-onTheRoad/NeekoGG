using SFML.Graphics;

namespace nk {
	public static class ItemUseStat {

		private static NamedSprite iconRefill; public static NamedSprite IconRefill { get { return iconRefill; } }
		private static NamedSprite iconConsum; public static NamedSprite IconConsum { get { return iconConsum; } }

		static ItemUseStat() {
			Sprite iconRefillTexture = ;
			Sprite iconConsumTexture = ;

			iconRefill = new NamedSprite(iconRefillTexture, "ItemUse_Refill");
			iconRefill = new NamedSprite(iconConsumTexture, "ItemUse_Consum");
		}

		

	}
}
