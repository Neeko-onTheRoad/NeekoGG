using SFML.Graphics;
using SFML.System;
using SFML.Window;

namespace nk.Client {
	public class NeekoGG : WindowBase {

		public NeekoGG() : base ("Neeko.GG") {}

		public override void Initialize() {
			
		}

		public override void Update(ClientTime _gameTime) {

		}

		public override void Draw(ClientTime gameTime) {
			//string totalTime = ClientTime.TotalTimeElapsed.ToString("0.000");
			//string deltaTime = ClientTime.DeltaTime.ToString("0.00000");
			//string fps = (1f / ClientTime.DeltaTime).ToString("0.00");

			//Text tt = new Text(totalTime, Res.Fonts.SuiteLight);
			//Text dt = new Text(deltaTime, Res.Fonts.SuiteLight);
			//Text fs = new Text(fps, Res.Fonts.SuiteLight);

			//tt.Position = new Vector2f(4f, 8f);
			//dt.Position = new Vector2f(4f, 28f);
			//fs.Position = new Vector2f(4f, 48f);

			//Window.Draw(tt);
			//Window.Draw(dt);
			//Window.Draw(fs);

			//* ---------------------------------------| Draw Background |--------------------------------------- *//

			{
				VertexArray background = new VertexArray(PrimitiveType.Quads, 4);
					background[0] = new Vertex(new Vector2f(0,            0           ), new Color(73,  0, 122));
					background[1] = new Vertex(new Vector2f(WindowSize.X, 0           ), new Color(136, 0, 109));
					background[2] = new Vertex(new Vector2f(WindowSize.X, WindowSize.Y), new Color(73,  0, 122));
					background[3] = new Vertex(new Vector2f(0,            WindowSize.Y), new Color(30,  0, 129));

				Window.Draw(background);

				RectangleShape bgFill = new RectangleShape(new Vector2f(WindowSize.X, WindowSize.Y));
				bgFill.FillColor = new Color(0, 0, 0, 150);
				Window.Draw(bgFill);
			}

			//* ---------------------------------------| Draw Upper Line |--------------------------------------- *//

			{
				RectangleShape teskBar = new RectangleShape(new Vector2f(WindowSize.X, WindowSize.Y * 0.05f));
				teskBar.FillColor = new Color(0, 0, 0, 50);
				Window.Draw(teskBar);

			}
		}
	}
}
