using nk.Res;
using SFML.Graphics;	
using SFML.System;
using SFML.Window;

namespace nk.Client {
	public class NeekoGG : WindowBase {

		public NeekoGG() : base ("Neeko.GG") {}

		private object? clicking = null;

		protected override void Initialize() {
			Window.MouseButtonPressed += (object? _sender, MouseButtonEventArgs _event) => {
				if (_event.Button == Mouse.Button.Left) {
					if (MouseListener.Status.Position.Y <= Sprites.TitleBar.Size.Y) {
						clicking = Sprites.TitleBar;
					}
				}
			};

			Window.MouseButtonReleased += (object? _sender, MouseButtonEventArgs _event) => {
				if (_event.Button == Mouse.Button.Left) {
					if (clicking != null) clicking = null;
				}
			};

			Window.MouseMoved += (object? _sender, MouseMoveEventArgs _event) => {
				if (clicking == Sprites.TitleBar) {
					Window.Position -= (MouseListener.Status.DragStartPosition - new Vector2i(_event.X ,_event.Y));
				}
			};
		}

		private static class Sprites {
			public static List<Drawable> SpriteUnion;

			public static VertexArray    Background;
			public static RectangleShape BgFill;
			public static RectangleShape TitleBar;
			public static Sprite         CloseButton;

			static Sprites() {

				SpriteUnion = new List<Drawable>();

				//* ---------------------------------------| Make Background |--------------------------------------- *//

				{
					Background = new VertexArray(PrimitiveType.Quads, 4);
					Background[0] = new Vertex(new Vector2f(0,            0           ), new Color(73,  0, 122));
					Background[1] = new Vertex(new Vector2f(WindowSize.X, 0           ), new Color(136, 0, 109));
					Background[2] = new Vertex(new Vector2f(WindowSize.X, WindowSize.Y), new Color(73,  0, 122));
					Background[3] = new Vertex(new Vector2f(0,            WindowSize.Y), new Color(30,  0, 129));
					SpriteUnion.Add(Background);

					BgFill = new RectangleShape(new Vector2f(WindowSize.X, WindowSize.Y));
					BgFill.FillColor =  new Color(0, 0, 0, 150);
					SpriteUnion.Add(BgFill);
				}
				
				//* ---------------------------------------| Make Title Bar |--------------------------------------- *//

				{ // Title Bar
					TitleBar = new RectangleShape(new Vector2f(WindowSize.X, WindowSize.Y * 0.05f));
					TitleBar.FillColor = new Color(0, 0, 0, 50);
					SpriteUnion.Add(TitleBar);
				}

				{ // Close Button
					CloseButton = new Sprite(Icon.App.CloseButton.Texture);
					CloseButton.Color    = new Color(255, 255, 255, 100);
					CloseButton.Scale    = new Vector2f(0.7f, 0.7f);
					CloseButton.Position = new Vector2f(WindowSize.X - 100, (TitleBar.Size.Y / 2) - (Icon.App.CloseButton.Texture.Size.Y / 2));
					SpriteUnion.Add(CloseButton);
				}

			}
		}

		protected override void Update(ClientTime _gameTime) {
		}

		protected override void Draw(ClientTime gameTime) {
			foreach (var sprite in Sprites.SpriteUnion) {
				Window.Draw(sprite);
			}
		}
	}
}
