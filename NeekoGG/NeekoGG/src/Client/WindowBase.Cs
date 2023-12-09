using SFML.Graphics;
using SFML.Window;
using SFML.System;

namespace nk.Client {
	public abstract class WindowBase {

		public const int   TARGET_FPS        = 60;
		public const float TIME_UNTIL_UPDATE = 1f/TARGET_FPS;

		public RenderWindow Window   { get; protected set; }
		public GameTime     GameTime { get; protected set; }
		
		protected WindowBase(uint _width, uint _height, string _title) {
			Window   = new RenderWindow(new VideoMode(_width, _height), _title);
			GameTime = new GameTime();
		}

		public void Run() {
			LoadContent();
			Initialize();

			float totalTimeBeforeUpdate = 0f;
			float previousTimeElapsed   = 0f;
			float deltaTime             = 0f;
			float totalTimeElapsed      = 0f;

			Clock clock = new Clock();

			while(Window.IsOpen) {
				Window.DispatchEvents();

				totalTimeElapsed    = clock.ElapsedTime.AsSeconds();
				deltaTime           = totalTimeElapsed - previousTimeElapsed;
				previousTimeElapsed = totalTimeElapsed;

				totalTimeBeforeUpdate += deltaTime;

				if (totalTimeBeforeUpdate >= TIME_UNTIL_UPDATE) {
					GameTime.Update(totalTimeBeforeUpdate, clock.ElapsedTime.AsSeconds());
					totalTimeBeforeUpdate = 0f;

					Update(GameTime);

					Window.Clear();
					Draw(GameTime);
					Window.Display();
				}
			}
		}

		public abstract void LoadContent();
		public abstract void Initialize();
		public abstract void Update(GameTime _gameTime);
		public abstract void Draw(GameTime gameTime);

	}
}
