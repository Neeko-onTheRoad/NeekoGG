using SFML.Graphics;

namespace nk.Res {
	public static class Icon {
		public static class Item {
			public static class Use {
				private static NamedTexture refill; public static NamedTexture Refill { get { return refill; } }
				private static NamedTexture consum; public static NamedTexture Consum { get { return consum; } }

				static Use() {
					Texture refillTexture = new Texture("./res/Icon/ItemUse_Refill.png");
					Texture consumTexture = new Texture("./res/Icon/ItemUse_Consum.png");

					refill = new NamedTexture(refillTexture, "Icon: ItemUse_Refill");
					consum = new NamedTexture(consumTexture, "Icon: ItemUse_Consum");
				}
			}
		}
	}
}
