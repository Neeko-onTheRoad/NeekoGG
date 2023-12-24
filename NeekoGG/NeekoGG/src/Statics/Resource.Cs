using SFML.Graphics;

namespace nk.Res {
	public static class Icon {
		public static class App {
			public static Texture CloseButton      { get; }
			public static Texture MinimizeButton   { get; }
			public static Texture RoundedRectangle { get; }

			static App() {
				CloseButton      = new Texture("./NeekoGG/res/App/CloseButton.png");
				MinimizeButton   = new Texture("./NeekoGG/res/App/MinimizeButton.png");
				RoundedRectangle = new Texture("./NeekoGG/res/App/RoundedRectangle.png");
			}
		}

		public static class Item {
			public static class Use {
				public static Texture Refill { get; }
				public static Texture Consum { get; }

				static Use() {
					Refill = new Texture("./NeekoGG/res/Icons/ItemUse_Refill.png");
					Consum = new Texture("./NeekoGG/res/Icons/ItemUse_Consum.png");
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
