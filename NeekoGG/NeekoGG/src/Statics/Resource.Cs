using SFML.Graphics;

namespace nk.Res {
	public static class Icon {
		public static class App {
			public static NamedTexture CloseButton    { get; }
			public static NamedTexture MinimizeButton { get; }

			static App() {
				Texture closeButtonTexture = new Texture("./NeekoGG/res/App/CloseButton.png");

				CloseButton    = new NamedTexture(closeButtonTexture, "CloseButton");
			}
		}

		public static class Item {
			public static class Use {
				public static NamedTexture Refill { get; }
				public static NamedTexture Consum { get; }

				static Use() {
					Texture refillTexture = new Texture("./NeekoGG/res/Icons/ItemUse_Refill.png");
					Texture consumTexture = new Texture("./NeekoGG/res/Icons/ItemUse_Consum.png");

					Refill = new NamedTexture(refillTexture, "ItemUse_Refill");
					Consum = new NamedTexture(consumTexture, "ItemUse_Consum");
				}
			}
		}
	}

	public static class Fonts {
		public static Font SuiteLight { get; }

		static Fonts() {
			SuiteLight = new Font("./NeekoGG/res/Fonts/SUITE-Light.ttf");
		}
	}
}
