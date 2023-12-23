using SFML.Graphics;
using SFML.Window;
using SFML.System;

namespace nk.Client {
	public abstract class WindowBase {
		
		public string WindowTitle     = "Neeko.GG";
		public int    TargetFPS       = 60;
		public float  TimeUntilUpdate = 1f/60;

		protected float DeltaTime   = 0f;

		protected static Vector2u WindowSize{ get; private set; }

		private RenderWindow window;
		public  RenderWindow Window     { get { return window; } protected set { window = value; } }
		public  ClientTime   ClientTime { get; protected set; }

		protected WindowBase(string _title) {
			window          = new RenderWindow(new VideoMode(0, 0), "");
			WindowTitle     = _title;
			TargetFPS       = 144;
			TimeUntilUpdate = 1f/TargetFPS;
			ClientTime      = new ClientTime();
		}

		public void Run() {
			CreateNewWindow(1f);

			float totalTimeBeforeUpdate = 0f;
			float previousTimeElapsed   = 0f;
			float deltaTime             = 0f;
			float totalTimeElapsed      = 0f;

			Clock clock = new Clock();

			while(Window.IsOpen) {

				totalTimeElapsed    = clock.ElapsedTime.AsSeconds();
				deltaTime           = totalTimeElapsed - previousTimeElapsed;
				previousTimeElapsed = totalTimeElapsed;

				totalTimeBeforeUpdate += deltaTime;

				DeltaTime = deltaTime;

				if (totalTimeBeforeUpdate >= TimeUntilUpdate) {
					UpdateEventHandlers(deltaTime);
					Window.DispatchEvents();

					ClientTime.Update(totalTimeBeforeUpdate, clock.ElapsedTime.AsSeconds());
					totalTimeBeforeUpdate = 0f;

					Update(ClientTime);
					Draw(ClientTime);
					Window.Display();
				}
				
			}			
		}

		protected abstract void Initialize();
		protected abstract void Update(ClientTime _gameTime);
		protected abstract void Draw(ClientTime _gameTime);

		protected void CreateNewWindow(float _size) {
			WindowSize = new Vector2u(
				(uint)(VideoMode.DesktopMode.Height * (4f / 6f) * (16f / 9f) * _size),
				(uint)(VideoMode.DesktopMode.Height * (4f / 6f) * _size)
			);
			Window.Close();
			Window      = new RenderWindow(new VideoMode(WindowSize.X, WindowSize.Y), WindowTitle, Styles.None);
			Window.Closed += WindowClosed;
			
			Initialize();
			InitializeEventHandlers();
		}

		private void WindowClosed(object? sender, EventArgs e) {
			Window.Close();
		}

		private void InitializeEventHandlers() {
			MouseListener.Initialize(ref window);
		}

		private void UpdateEventHandlers(float _deltaTime) {
			MouseListener.Update(_deltaTime);
		}
	}
}
