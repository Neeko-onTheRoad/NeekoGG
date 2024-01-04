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
					if (IsHovering(Sprites.CloseButtonBg)) {
						clicking = Sprites.CloseButtonBg;
					}

					else if (IsHovering(Sprites.MinimizeButtonBg)) {
						clicking = Sprites.MinimizeButtonBg;
					}

					else if (MouseListener.Status.Position.Y <= Sprites.TitleBar.Size.Y) {
						clicking = Sprites.TitleBar;
					}
				}
			};

			Window.MouseButtonReleased += (object? _sender, MouseButtonEventArgs _event) => {
				if (_event.Button == Mouse.Button.Left) {
					if (clicking == Sprites.CloseButtonBg && IsHovering(Sprites.CloseButtonBg)) {
						Window.Close();
					}
					else if (clicking == Sprites.MinimizeButtonBg && IsHovering(Sprites.MinimizeButtonBg)) {
						ShowWindowAsync(Window.SystemHandle, 6);
					}

					if (clicking != null) clicking = null;
				}
			};

			Window.MouseMoved += (object? _sender, MouseMoveEventArgs _event) => {
				if (clicking == Sprites.TitleBar) {
					Window.Position -= (MouseListener.Status.DragStartPosition - new Vector2i(_event.X ,_event.Y));
				}
				
				Sprites.CloseButtonBg.Color = Sprites.CloseButtonBg.GetGlobalBounds().Contains(_event.X, _event.Y) ? new Color(255, 255, 255, 20) : new Color(0, 0, 0, 0);
				Sprites.MinimizeButtonBg.Color = Sprites.MinimizeButtonBg.GetGlobalBounds().Contains(_event.X, _event.Y) ? new Color(255, 255, 255, 20) : new Color(0, 0, 0, 0);
			};
		}

		private class Sprites {

			public static VertexArray    Background;
			public static RectangleShape BgFill;

			public static RectangleShape TitleBar;
			public static Sprite         CloseButton;
			public static Sprite         CloseButtonBg;
			public static Sprite         MinimizeButton;
			public static Sprite         MinimizeButtonBg;

			static Sprites() {

				//* ---------------------------------------| Make Background |--------------------------------------- *//

				{
					Background = new VertexArray(PrimitiveType.Quads, 4);
					Background[0] = new Vertex(new Vector2f(0,            0           ), Colors.Nk_Purple);
					Background[1] = new Vertex(new Vector2f(WindowSize.X, 0           ), Colors.Nk_Magenta);
					Background[2] = new Vertex(new Vector2f(WindowSize.X, WindowSize.Y), Colors.Nk_Purple);
					Background[3] = new Vertex(new Vector2f(0,            WindowSize.Y), Colors.Nk_Blue);
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
					CloseButtonBg          = new Sprite(Icon.App.RoundedRectangle);
					CloseButtonBg.Color    = new Color(255, 255, 255, 0);
					CloseButtonBg.Position = new Vector2f(
						WindowSize.X - (Icon.App.CloseButton.Size.X * 2.5f) - (Icon.App.RoundedRectangle.Size.X / 2f),
						(TitleBar.Size.Y / 2f) - (Icon.App.RoundedRectangle.Size.Y / 2)
					);
					SpriteUnion.Add(CloseButtonBg);

					CloseButton          = new Sprite(Icon.App.CloseButton);
					CloseButton.Color    = new Color(255, 255, 255, 100);
					CloseButton.Position = new Vector2f(
						WindowSize.X - (Icon.App.CloseButton.Size.X * 3f),
						(TitleBar.Size.Y / 2f) - (Icon.App.CloseButton.Size.Y / 2f)
					);
					SpriteUnion.Add(CloseButton);
				}

				{ // MinimizeButton
					MinimizeButtonBg          = new Sprite(Icon.App.RoundedRectangle);
					MinimizeButtonBg.Color    = new Color(255, 255, 255, 0);
					MinimizeButtonBg.Position = new Vector2f(
						WindowSize.X - (Icon.App.MinimizeButton.Size.X * 5.5f) - (Icon.App.RoundedRectangle.Size.X / 2f),
						(TitleBar.Size.Y / 2f) - (Icon.App.RoundedRectangle.Size.Y / 2)
					);
					SpriteUnion.Add(MinimizeButtonBg);

					MinimizeButton          = new Sprite(Icon.App.MinimizeButton);
					MinimizeButton.Color    = new Color(255, 255, 255, 100);
					MinimizeButton.Position = new Vector2f(
						WindowSize.X - (Icon.App.CloseButton.Size.X * 6f),
						(TitleBar.Size.Y / 2f) - (Icon.App.CloseButton.Size.Y * CloseButton.Scale.Y / 2f)
					);
					SpriteUnion.Add(MinimizeButton);
				}
			}
		}

		protected override void Update(ClientTime _clientTime) {
			
		}

		protected override void Draw(ClientTime gameTime) {
			SpriteUnion.ForEach(Window.Draw);
			
		}
	}
}
