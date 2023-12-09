using SFML.Graphics;

namespace nk.Res {
	public static class Icon {
		public static class Item {
			public static class Use {
				public static NamedTexture Refill { get; }
				public static NamedTexture Consum { get; }

				static Use() {
					Texture refillTexture = new Texture("./res/Icon/ItemUse_Refill.png");
					Texture consumTexture = new Texture("./res/Icon/ItemUse_Consum.png");

					Refill = new NamedTexture(refillTexture, "Icon: ItemUse_Refill");
					Consum = new NamedTexture(consumTexture, "Icon: ItemUse_Consum");
				}
			}
		}
	}
}
