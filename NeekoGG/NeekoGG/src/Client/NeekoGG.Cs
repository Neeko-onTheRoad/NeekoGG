using SFML.Graphics;
using SFML.System;
using SFML.Window;

namespace nk.Client {
	public class NeekoGG : WindowBase {

		public NeekoGG() : base ("Neeko.GG") {}

		

		protected override void Initialize() {
			
		}

		private static class Sprites {
			public static List<Drawable> SpriteUnion;

			public static VertexArray    Background;
			public static RectangleShape BgFill;
			public static RectangleShape TeskBar;

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
				
				//* ---------------------------------------| Make Upper Line |--------------------------------------- *//

				{
					TeskBar = new RectangleShape(new Vector2f(WindowSize.X, WindowSize.Y * 0.05f));
					TeskBar.FillColor = new Color(0, 0, 0, 50);
					SpriteUnion.Add(TeskBar);
				}
			}
		}

		private object? clicking = null;

		protected override void Update(ClientTime _gameTime) {

			if (MouseListener.Status)

		}

		protected override void Draw(ClientTime gameTime) {
			foreach (var sprite in Sprites.SpriteUnion) {
				Window.Draw(sprite);
			}
		}
	}
}
